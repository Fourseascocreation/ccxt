using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net;

namespace ccxt;

using dict = Dictionary<string, object>;

public partial class Exchange
{

    public Exchange(dict userConfig = null)
    {
        this.initializeProperties(userConfig);
        var empty = new List<string>();
        transformApiNew(this.api);

        this.initRestLimiter();
        this.initHttpClient();

        if (this.markets != null)
        {
            this.setMarkets(this.markets);
        }
    }

    private void initHttpClient()
    {
        if (this.httpProxy != null && this.httpProxy.ToString().Length > 0)
        {
            var proxy = new WebProxy(this.httpProxy.ToString());
            this.client = new HttpClient(new HttpClientHandler { Proxy = proxy });
        }
        else
        {
            this.client = new HttpClient();
        }
    }

    private void transformApiNew(dict api, List<string> paths = null)
    {
        if (api == null)
            return;
        paths ??= new List<string>();
        List<string> keyList = new List<string>(api.Keys);
        foreach (string key in keyList)
        {
            var value = api[key];

            if (isHttpMethod(key))
            {
                var dictValue = value as dict;
                List<string> endpoints = null;
                if (dictValue != null)
                {
                    endpoints = new List<string>(dictValue.Keys);
                }
                else
                {
                    if (value.GetType() == typeof(List<object>))
                    {
                        // when endpoints are a list of string
                        endpoints = new List<string>();
                        var listValue = value as List<object>;
                        foreach (var item in listValue)
                        {
                            endpoints.Add(item.ToString());
                        }
                    }
                }
                // var endpoints = new List<string>(dictValue.Keys);
                foreach (string endpoint in endpoints)
                {
                    var cost = 1;
                    if (dictValue != null)
                    {
                        var config = dictValue[endpoint];

                        if (config.GetType() == typeof(dict))
                        {
                            var dictConfig = config as dict;
                            var rawCost = dictConfig.GetValueOrDefault("cost");
                            cost = rawCost != null ? Convert.ToInt32(rawCost) : 1;
                        }
                        else
                        {
                            cost = (int)cost;
                        }
                    }

                    // calculate the endpoint
                    // string input = string.Join("/", paths) + "/" + key + "/" + endpoint;
                    string pattern = @"[^a-zA-Z0-9]";
                    Regex rgx = new Regex(pattern);
                    var result = rgx.Split(endpoint);
                    // create unified endpoint name
                    var listKey = new List<string>() { key };
                    var pathParts = paths.Concat(listKey).Concat(result.Where(x => x.Length > 0));
                    var completePaths = pathParts.Select(x => char.ToUpper(x[0]) + x.Substring(1)).ToList();
                    var path = string.Join("", completePaths);
                    path = char.ToLower(path[0]) + path.Substring(1); // lowercase first letter
                    var apiObj = paths.Count > 1 ? (object)paths : paths[0];
                    this.transformedApi[path] = new dict {
                            { "method", key.ToUpper() },
                            { "path",   endpoint },
                            { "api",    apiObj},
                            { "cost",  cost}
                        };
                }
            }
            else
            {
                transformApiNew((dict)value, paths.Concat(new List<string> { key }).ToList());
            }
        }
    }

    public void handleHttpStatusCode(object code, object reason, object url, object method, object body)
    {
        var codeString = code.ToString();
        var codeInHttpExceptions = safeValue(this.httpExceptions, codeString);
        if (codeInHttpExceptions != null)
        {
            var errorMessage = this.id + ' ' + method + ' ' + url + ' ' + codeString + ' ' + reason + ' ' + body;
            var Exception = NewException(codeInHttpExceptions as Type, errorMessage);
            throw Exception;
        }
    }

    public async virtual Task<object> fetch(object url2, object method2, object headers2, object body2)
    {
        var url = url2 as String;
        var method = method2 as String;
        var headers = headers2 as dict;
        var body = body2 as String;

        if (this.verbose)
            this.log("fetch Request:\n" + this.id + " " + method + " " + url + "\nRequestHeaders:\n" + this.stringifyObject(headers) + "\nRequestBody:\n" + this.stringifyObject(body) + "\n");

        // add headers
        client.DefaultRequestHeaders.Accept.Clear();
        var headersList = new List<string>(headers.Keys);

        var contentType = "";
        foreach (string key in headersList)
        {

            if (key.ToLower() != "content-type")
            {
                client.DefaultRequestHeaders.Add(key, headers[key].ToString());
            }
            else
            {
                // can't set content type header here, because it's part of the content
                // check: https://nzpcmad.blogspot.com/2017/07/aspnet-misused-header-name-make-sure.html
                contentType = headers[key].ToString();

            }
        }
        // user agent
        if (this.userAgent != null && this.userAgent.Length > 0)
            client.DefaultRequestHeaders.Add("User-Agent", userAgent);


        var result = "";
        HttpResponseMessage response = null;
        object responseBody = null;

        if (method == "GET")
        {
            response = await this.client.GetAsync(url);
            result = await response.Content.ReadAsStringAsync();
        }
        else if (method == "POST")
        {
            contentType = contentType == "" ? "application/json" : contentType;
            var contentTypeHeader = new MediaTypeWithQualityHeaderValue(contentType);
            var stringContent = new StringContent(body, Encoding.UTF8, contentTypeHeader);
            response = await this.client.PostAsync(url, stringContent);
            result = await response.Content.ReadAsStringAsync();
        }

        this.client.DefaultRequestHeaders.Clear();

        var responseHeaders = response?.Headers.ToDictionary(x => x, y => y.Value.First());
        var httpStatusCode = (int)response?.StatusCode;
        var httpStatusText = response?.ReasonPhrase;

        if (this.verbose)
        {
            this.log("handleRestResponse:\n" + this.id + " " + method + " " + url + " " + httpStatusCode + " " + httpStatusText + "\nResponseHeaders:\n" + this.stringifyObject(responseHeaders) + "\nResponseBody:\n" + result + "\n");
        }

        responseBody = JsonHelper.Deserialize(result);

        var res = handleErrors(httpStatusCode, httpStatusText, url, method, responseHeaders, result, responseBody, headers, body);
        if (res == null)
            handleHttpStatusCode(httpStatusCode, httpStatusText, url, method, result);

        return responseBody;
    }

    public async virtual Task<object> fetch2(string path, string api, string method, dict headers, dict body, dict parameters, dict config, dict context = null)
    {
        if (this.enableRateLimit)
        {
            var cost = config["cost"]; // protect this call
            await this.throttler.throttle(cost);
        }
        this.lastRestRequestTimestamp = this.milliseconds();
        var request = this.sign(path, api, method, parameters, headers, body);
        return await fetch(request["url"] as String, request["method"] as String, request["headers"] as dict, request["body"] as dict);
    }

    public object call(string implicitEndpoint, object parameters2)
    {
        var parameters = (dict)parameters2;
        if (this.transformedApi.GetValueOrDefault(implicitEndpoint) != null)
        {
            var endpointInfo = this.transformedApi[implicitEndpoint] as dict;
            var method = endpointInfo["method"] as String;
            var path = endpointInfo["path"] as String;
            var api = endpointInfo["api"] as String;
            var cost = endpointInfo["cost"] != null ? endpointInfo["cost"] : 1;

            // return await this.fetch2(path, api, method, new dict(), new dict(), parameters, new dict { { "cost", cost } });

        }
        throw new Exception("Endpoint not found!");
    }

    public async virtual Task<object> callAsync(object implicitEndpoint2, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        var implicitEndpoint = (string)implicitEndpoint2;
        if (this.transformedApi.GetValueOrDefault(implicitEndpoint) != null)
        {
            var endpointInfo = this.transformedApi[implicitEndpoint] as dict;
            var method = endpointInfo["method"] as String;
            var path = endpointInfo["path"] as String;
            var api = endpointInfo["api"];
            var cost = endpointInfo["cost"] != null ? endpointInfo["cost"] : 1;

            // return await this.fetch2(path, api, method, new dict(), new dict(), (dict)parameters, new dict { { "cost", cost } });
            return await this.fetch2(path, api, method, (dict)parameters, new dict(), new dict(), new dict { { "cost", cost } });

        }
        throw new Exception("Endpoint not found!");
    }


    public void handleErrors(int statusCode, string statusText, string url, string method, dict responseHeaders, dict responseBody, dict response, dict requestHeaders, dict requestBody)
    {
        // it is a stub method that must be virtuald in the derived exchange classes
        // throw new NotSupported (this.id + ' handleErrors() not implemented yet');
    }


    public virtual dict sign(object path, object api, string method = "GET", dict headers = null, object body2 = null, object parameters2 = null)
    {
        api ??= "public";
        headers ??= new dict();
        body2 ??= new dict();
        parameters2 ??= new dict();

        var body = (dict)body2;
        var parameters = (dict)parameters2;

        var url = this.url;
        if (((string)api) == "public")
        {
            if (parameters.Keys.Count > 0)
                url += path + "?" + this.urlencode(parameters);
        }

        return new dict {
            { "url", this.url + path },
            { "method", method },
            { "headers", headers },
            { "body", body },
        };
    }

    public Int64 seconds()
    {
        double res = (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
        return Convert.ToInt64(res);
    }

    public async virtual Task<object> loadMarketsHelper(bool reload = false, dict parameters = null)
    {
        if (!reload && this.markets != null)
        {
            if (this.markets_by_id == null)
            {
                return this.setMarkets(this.markets);
            }
            // return Task.FromResult(this.markets);
            return this.markets;
        }

        object currencies = null;
        var has = this.has as dict;
        if (has["fetchCurrencies"] != null)
        {
            currencies = await this.fetchCurrencies();
        }
        var markets = await this.fetchMarkets();
        return this.setMarkets(markets, currencies);
    }

    public virtual Task<object> loadMarkets(object reload2 = null, object parameters2 = null)
    {
        reload2 ??= false;
        var reload = (bool)reload2;
        parameters2 ??= new dict();
        var parameters = (dict)parameters2;
        if ((reload && !this.reloadingMarkets) || this.marketsLoading == null)
        {
            this.reloadingMarkets = true;
            this.marketsLoading = (this.loadMarketsHelper(reload, parameters).ContinueWith((t) =>
            {
                this.reloadingMarkets = false;
                return t.Result;
            }));
        }

        return marketsLoading;
    }

    public virtual async Task<object> fetchMarkets(object parameters = null)
    {
        return this.toArray(this.markets);
    }

    public virtual async Task<object> fetchCurrencies(object parameters = null)
    {
        return this.currencies;
    }

    public void log(string s)
    {
        Console.WriteLine(s);
    }

    public string totp(object a)
    {
        return "";
    }

    public bool checkAddress(object address)
    {
        return true;
    }

    public int parseTimeframe(object timeframe2)
    {
        var timeframe = (string)timeframe2;
        var amount = Int32.Parse(timeframe.Substring(0, timeframe.Length - 1));
        var unit = timeframe.Substring(timeframe.Length - 1);
        int scale = 0;
        if (unit == "y")
        {
            scale = 60 * 60 * 24 * 365;
        }
        else if (unit == "M")
        {
            scale = 60 * 60 * 24 * 30;
        }
        else if (unit == "w")
        {
            scale = 60 * 60 * 24 * 7;
        }
        else if (unit == "d")
        {
            scale = 60 * 60 * 24;
        }
        else if (unit == "h")
        {
            scale = 60 * 60;
        }
        else if (unit == "m")
        {
            scale = 60;
        }
        else if (unit == "s")
        {
            scale = 1;
        }
        else
        {
            throw new Exception("Invalid timeframe: " + timeframe);
        }
        return amount * scale;
    }

    public async Task throttle(object cost)
    {
        await this.throttler.throttle(cost);
    }

    public void initRestLimiter()
    {
        if (this.rateLimit == -1)
        {
            throw new Exception(this.id + ".rateLimit property is not configured'");
        }
        this.tokenBucket = this.extend(new dict() {
            {"delay" , 0.001},
            {"capacity" , 1},
            {"cost" , 1},
            {"maxCapacity", 1000},
            {"refillRate", (this.rateLimit > 0) ? 1 / this.rateLimit : float.MaxValue},
        }, this.tokenBucket);
        this.throttler = new Throttler(this.tokenBucket);
    }

    public virtual void setSandboxMode(object enable2)
    {
        var enable = (bool)enable2;
        var urls = safeValue(this.urls, "api");
        var apiBackup = safeValue(this.urls, "apiBackup");
        if (enable)
        {
            var urlsDict = this.urls as dict;
            var test = safeValue(urlsDict, "test");
            var api = safeValue(urlsDict, "api");
            if (test != null)
            {
                if (api.GetType() == typeof(string))
                {
                    urlsDict["apiBackup"] = urls;
                    ((dict)this.urls)["api"] = test as dict;

                }
                else
                {
                    urlsDict["apiBackup"] = api;
                    ((dict)this.urls)["api"] = test; // clone here?
                }
            }
            else
            {
                throw new NotSupported("Sandbox mode is not supported by this exchange");

            }

        }
        else if (apiBackup != null)
        {
            if (api.GetType() == typeof(string))
            {
                api = apiBackup as dict;

            }
            else
            {
                api = apiBackup as dict; // clone this
            }
        }

    }

    public void checkRequiredDependencies()
    {
        // stub to implement later
    }

    public virtual object parseNumber(object value, object number = null, object defaultValue = null)
    {
        if (value == null || (value.GetType() == typeof(string) && value.ToString().Trim() == ""))
            return defaultValue;


        if (this.number.GetType() == typeof(float).GetType())
        {
            return float.Parse(value.ToString(), CultureInfo.InvariantCulture);
        }
        return value;
    }

    public object convertToBigInt(object value)
    {
        if (value.GetType() == typeof(float).GetType())
        {
            return Convert.ToInt64(value);
        }
        return value;
    }
}
