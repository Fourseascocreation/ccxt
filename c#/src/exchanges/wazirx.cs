using Main;
namespace Main;

partial class wazirx : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "wazirx" },
            { "name", "WazirX" },
            { "countries", new List<object>() {"IN"} },
            { "version", "v2" },
            { "rateLimit", 1000 },
            { "pro", true },
            { "has", new Dictionary<string, object>() {
                { "CORS", false },
                { "spot", true },
                { "margin", null },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "cancelAllOrders", true },
                { "cancelOrder", true },
                { "createOrder", true },
                { "createStopLimitOrder", true },
                { "createStopMarketOrder", true },
                { "createStopOrder", true },
                { "fetchBalance", true },
                { "fetchBidsAsks", false },
                { "fetchClosedOrders", false },
                { "fetchCurrencies", false },
                { "fetchDepositAddress", false },
                { "fetchDepositAddressesByNetwork", false },
                { "fetchDeposits", true },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", false },
                { "fetchFundingRateHistory", false },
                { "fetchFundingRates", false },
                { "fetchIndexOHLCV", false },
                { "fetchMarginMode", false },
                { "fetchMarkets", true },
                { "fetchMarkOHLCV", false },
                { "fetchMyTrades", false },
                { "fetchOHLCV", true },
                { "fetchOpenInterestHistory", false },
                { "fetchOpenOrders", true },
                { "fetchOrder", false },
                { "fetchOrderBook", true },
                { "fetchOrders", true },
                { "fetchPositionMode", false },
                { "fetchPremiumIndexOHLCV", false },
                { "fetchStatus", true },
                { "fetchTicker", true },
                { "fetchTickers", true },
                { "fetchTime", true },
                { "fetchTrades", true },
                { "fetchTradingFee", false },
                { "fetchTradingFees", false },
                { "fetchTransactionFees", false },
                { "fetchTransactions", false },
                { "fetchTransfers", false },
                { "fetchWithdrawals", false },
                { "transfer", false },
                { "withdraw", false },
            } },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/1294454/148647666-c109c20b-f8ac-472f-91c3-5f658cb90f49.jpeg" },
                { "api", new Dictionary<string, object>() {
                    { "rest", "https://api.wazirx.com/sapi/v1" },
                } },
                { "www", "https://wazirx.com" },
                { "doc", "https://docs.wazirx.com/#public-rest-api-for-wazirx" },
                { "fees", "https://wazirx.com/fees" },
                { "referral", "https://wazirx.com/invite/k7rrnks5" },
            } },
            { "api", new Dictionary<string, object>() {
                { "public", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "exchangeInfo", 1 },
                        { "depth", 1 },
                        { "ping", 1 },
                        { "systemStatus", 1 },
                        { "tickers/24hr", 1 },
                        { "ticker/24hr", 1 },
                        { "time", 1 },
                        { "trades", 1 },
                        { "klines", 1 },
                    } },
                } },
                { "private", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "account", 1 },
                        { "allOrders", 1 },
                        { "funds", 1 },
                        { "historicalTrades", 1 },
                        { "openOrders", 1 },
                        { "order", 1 },
                        { "myTrades", 1 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "order", 1 },
                        { "order/test", 1 },
                    } },
                    { "delete", new Dictionary<string, object>() {
                        { "order", 1 },
                        { "openOrders", 1 },
                    } },
                } },
            } },
            { "fees", new Dictionary<string, object>() {
                { "WRX", new Dictionary<string, object>() {
                    { "maker", this.parseNumber("0.0") },
                    { "taker", this.parseNumber("0.0") },
                } },
            } },
            { "precisionMode", TICK_SIZE },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {
                    { "-1121", typeof(BadSymbol) },
                    { "1999", typeof(BadRequest) },
                    { "2002", typeof(InsufficientFunds) },
                    { "2005", typeof(BadRequest) },
                    { "2078", typeof(PermissionDenied) },
                    { "2098", typeof(BadRequest) },
                    { "2031", typeof(InvalidOrder) },
                    { "2113", typeof(BadRequest) },
                    { "2115", typeof(BadRequest) },
                    { "2136", typeof(RateLimitExceeded) },
                    { "94001", typeof(InvalidOrder) },
                } },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "1m" },
                { "5m", "5m" },
                { "30m", "30m" },
                { "1h", "1h" },
                { "2h", "2h" },
                { "4h", "4h" },
                { "6h", "6h" },
                { "12h", "12h" },
                { "1d", "1d" },
                { "1w", "1w" },
            } },
            { "options", new Dictionary<string, object>() {
                { "recvWindow", 10000 },
            } },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchMarkets
        * @description retrieves data on all markets for wazirx
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetExchangeInfo(parameters);
        //
        // {
        //     "timezone":"UTC",
        //     "serverTime":1641336850932,
        //     "symbols":[
        //     {
        //         "symbol":"btcinr",
        //         "status":"trading",
        //         "baseAsset":"btc",
        //         "quoteAsset":"inr",
        //         "baseAssetPrecision":5,
        //         "quoteAssetPrecision":0,
        //         "orderTypes":[
        //             "limit",
        //             "stop_limit"
        //         ],
        //         "isSpotTradingAllowed":true,
        //         "filters":[
        //             {
        //                 "filterType":"PRICE_FILTER",
        //                 "minPrice":"1",
        //                 "tickSize":"1"
        //             }
        //         ]
        //     },
        //
        object markets = this.safeValue(response, "symbols", new List<object>() {});
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(markets)); postFixIncrement(ref i))
        {
            object market = getValue(markets, i);
            object id = this.safeString(market, "symbol");
            object baseId = this.safeString(market, "baseAsset");
            object quoteId = this.safeString(market, "quoteAsset");
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
            object isSpot = this.safeValue(market, "isSpotTradingAllowed");
            object filters = this.safeValue(market, "filters");
            object minPrice = null;
            for (object j = 0; isLessThan(j, getArrayLength(filters)); postFixIncrement(ref j))
            {
                object filter = getValue(filters, j);
                object filterType = this.safeString(filter, "filterType");
                if (isTrue(isEqual(filterType, "PRICE_FILTER")))
                {
                    minPrice = this.safeNumber(filter, "minPrice");
                }
            }
            object fee = this.safeValue(this.fees, quote, new Dictionary<string, object>() {});
            object takerString = this.safeString(fee, "taker", "0.2");
            takerString = Precise.stringDiv(takerString, "100");
            object makerString = this.safeString(fee, "maker", "0.2");
            makerString = Precise.stringDiv(makerString, "100");
            object status = this.safeString(market, "status");
            ((List<object>)result).Add(new Dictionary<string, object>() {
                { "id", id },
                { "symbol", add(add(bs, "/"), quote) },
                { "base", bs },
                { "quote", quote },
                { "settle", null },
                { "baseId", baseId },
                { "quoteId", quoteId },
                { "settleId", null },
                { "type", "spot" },
                { "spot", isSpot },
                { "margin", false },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "active", (isEqual(status, "trading")) },
                { "contract", false },
                { "linear", null },
                { "inverse", null },
                { "taker", this.parseNumber(takerString) },
                { "maker", this.parseNumber(makerString) },
                { "contractSize", null },
                { "expiry", null },
                { "expiryDatetime", null },
                { "strike", null },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "amount", this.parseNumber(this.parsePrecision(this.safeString(market, "baseAssetPrecision"))) },
                    { "price", this.parseNumber(this.parsePrecision(this.safeString(market, "quoteAssetPrecision"))) },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "price", new Dictionary<string, object>() {
                        { "min", minPrice },
                        { "max", null },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "cost", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                } },
                { "info", market },
            });
        }
        return result;
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchOHLCV
        * @description fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents. Available values [1m,5m,15m,30m,1h,2h,4h,6h,12h,1d,1w]
        * @param {int|undefined} since timestamp in ms of the earliest candle to fetch
        * @param {int|undefined} limit the maximum amount of candles to fetch
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @param {int|undefined} params.until timestamp in s of the latest candle to fetch
        * @returns {[[int]]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "interval", this.safeString(this.timeframes, timeframe, timeframe) },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit;
        }
        object until = this.safeInteger(parameters, "until");
        parameters = this.omit(parameters, new List<object>() {"until"});
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["startTime"] = this.parseToInt(divide(since, 1000));
        }
        if (isTrue(!isEqual(until, null)))
        {
            ((Dictionary<string, object>)request)["endTime"] = until;
        }
        object response = await this.publicGetKlines(this.extend(request, parameters));
        //
        //    [
        //        [1669014360,1402001,1402001,1402001,1402001,0],
        //        ...
        //    ]
        //
        return this.parseOHLCVs(response, market, timeframe, since, limit);
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //
        //    [1669014300,1402001,1402001,1402001,1402001,0],
        //
        return new List<object> {this.safeTimestamp(ohlcv, 0), this.safeNumber(ohlcv, 1), this.safeNumber(ohlcv, 2), this.safeNumber(ohlcv, 3), this.safeNumber(ohlcv, 4), this.safeNumber(ohlcv, 5)};
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit; // [1, 5, 10, 20, 50, 100, 500, 1000]
        }
        object response = await this.publicGetDepth(this.extend(request, parameters));
        //
        //     {
        //          "timestamp":1559561187,
        //          "asks":[
        //                     ["8540.0","1.5"],
        //                     ["8541.0","0.0042"]
        //                 ],
        //          "bids":[
        //                     ["8530.0","0.8814"],
        //                     ["8524.0","1.4"]
        //                 ]
        //      }
        //
        object timestamp = this.safeInteger(response, "timestamp");
        return this.parseOrderBook(response, symbol, timestamp);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        object ticker = await this.publicGetTicker24hr(this.extend(request, parameters));
        //
        // {
        //     "symbol":"wrxinr",
        //     "baseAsset":"wrx",
        //     "quoteAsset":"inr",
        //     "openPrice":"94.77",
        //     "lowPrice":"92.7",
        //     "highPrice":"95.17",
        //     "lastPrice":"94.03",
        //     "volume":"1118700.0",
        //     "bidPrice":"94.02",
        //     "askPrice":"94.03",
        //     "at":1641382455000
        // }
        //
        return this.parseTicker(ticker, market);
    }

    public async override Task<object> fetchTickers(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchTickers
        * @description fetches price tickers for multiple markets, statistical calculations with the information calculated over the past 24 hours each market
        * @param {[string]|undefined} symbols unified symbols of the markets to fetch the ticker for, all market tickers are returned if not assigned
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {object} a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object tickers = await this.publicGetTickers24hr();
        //
        // [
        //     {
        //        "symbol":"btcinr",
        //        "baseAsset":"btc",
        //        "quoteAsset":"inr",
        //        "openPrice":"3698486",
        //        "lowPrice":"3641155.0",
        //        "highPrice":"3767999.0",
        //        "lastPrice":"3713212.0",
        //        "volume":"254.11582",
        //        "bidPrice":"3715021.0",
        //        "askPrice":"3715022.0",
        //     }
        //     ...
        // ]
        //
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(tickers)); postFixIncrement(ref i))
        {
            object ticker = getValue(tickers, i);
            object parsedTicker = this.parseTicker(ticker);
            object symbol = getValue(parsedTicker, "symbol");
            ((Dictionary<string, object>)result)[(string)symbol] = parsedTicker;
        }
        return result;
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/en/latest/manual.html?#public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit; // Default 500; max 1000.
        }
        object method = this.safeString(this.options, "fetchTradesMethod", "publicGetTrades");
        object response = await this.callAsync(method, this.extend(request, parameters));
        // [
        //     {
        //         "id":322307791,
        //         "price":"93.7",
        //         "qty":"0.7",
        //         "quoteQty":"65.59",
        //         "time":1641386701000,
        //         "isBuyerMaker":false
        //     },
        // ]
        return this.parseTrades(response, market, since, limit);
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        //     {
        //         "id":322307791,
        //         "price":"93.7",
        //         "qty":"0.7",
        //         "quoteQty":"65.59",
        //         "time":1641386701000,
        //         "isBuyerMaker":false
        //     }
        //
        object id = this.safeString(trade, "id");
        object timestamp = this.safeInteger(trade, "time");
        object datetime = this.iso8601(timestamp);
        market = this.safeMarket(null, market);
        object isBuyerMaker = this.safeValue(trade, "isBuyerMaker");
        object side = ((bool) isTrue(isBuyerMaker)) ? "sell" : "buy";
        object price = this.safeNumber(trade, "price");
        object amount = this.safeNumber(trade, "qty");
        object cost = this.safeNumber(trade, "quoteQty");
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "id", id },
            { "timestamp", timestamp },
            { "datetime", datetime },
            { "symbol", getValue(market, "symbol") },
            { "order", id },
            { "type", null },
            { "side", side },
            { "takerOrMaker", null },
            { "price", price },
            { "amount", amount },
            { "cost", cost },
            { "fee", null },
        }, market);
    }

    public async override Task<object> fetchStatus(object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchStatus
        * @description the latest known information on the availability of the exchange API
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {object} a [status structure]{@link https://docs.ccxt.com/#/?id=exchange-status-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetSystemStatus(parameters);
        //
        //     {
        //         "status":"normal", // normal, system maintenance
        //         "message":"System is running normally."
        //     }
        //
        object status = this.safeString(response, "status");
        return new Dictionary<string, object>() {
            { "status", ((bool) isTrue((isEqual(status, "normal")))) ? "ok" : "maintenance" },
            { "updated", null },
            { "eta", null },
            { "url", null },
            { "info", response },
        };
    }

    public async override Task<object> fetchTime(object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchTime
        * @description fetches the current integer timestamp in milliseconds from the exchange server
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {int} the current integer timestamp in milliseconds from the exchange server
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetTime(parameters);
        //
        //     {
        //         "serverTime":1635467280514
        //     }
        //
        return this.safeInteger(response, "serverTime");
    }

    public override object parseTicker(object ticker, object market = null)
    {
        //
        //     {
        //        "symbol":"btcinr",
        //        "baseAsset":"btc",
        //        "quoteAsset":"inr",
        //        "openPrice":"3698486",
        //        "lowPrice":"3641155.0",
        //        "highPrice":"3767999.0",
        //        "lastPrice":"3713212.0",
        //        "volume":"254.11582", // base volume
        //        "bidPrice":"3715021.0",
        //        "askPrice":"3715022.0",
        //        "at":1641382455000 // only on fetchTicker
        //     }
        //
        object marketId = this.safeString(ticker, "symbol");
        market = this.safeMarket(marketId, market);
        object symbol = getValue(market, "symbol");
        object last = this.safeString(ticker, "lastPrice");
        object open = this.safeString(ticker, "openPrice");
        object high = this.safeString(ticker, "highPrice");
        object low = this.safeString(ticker, "lowPrice");
        object baseVolume = this.safeString(ticker, "volume");
        object bid = this.safeString(ticker, "bidPrice");
        object ask = this.safeString(ticker, "askPrice");
        object timestamp = this.safeInteger(ticker, "at");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", high },
            { "low", low },
            { "bid", bid },
            { "bidVolume", null },
            { "ask", ask },
            { "askVolume", null },
            { "vwap", null },
            { "open", open },
            { "close", last },
            { "last", last },
            { "previousClose", null },
            { "change", null },
            { "percentage", null },
            { "average", null },
            { "baseVolume", baseVolume },
            { "quoteVolume", null },
            { "info", ticker },
        }, market);
    }

    public virtual object parseBalance(object response)
    {
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object balance = getValue(response, i);
            object id = this.safeString(balance, "asset");
            object code = this.safeCurrencyCode(id);
            object account = this.account();
            ((Dictionary<string, object>)account)["free"] = this.safeString(balance, "free");
            ((Dictionary<string, object>)account)["used"] = this.safeString(balance, "locked");
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.privateGetFunds(parameters);
        //
        // [
        //       {
        //          "asset":"inr",
        //          "free":"0.0",
        //          "locked":"0.0"
        //       },
        // ]
        //
        return this.parseBalance(response);
    }

    public async override Task<object> fetchOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchOrders
        * @description fetches information on multiple orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrders() requires a `symbol` argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["startTime"] = since;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit;
        }
        object response = await this.privateGetAllOrders(this.extend(request, parameters));
        //
        //   [
        //       {
        //           "id": 28,
        //           "symbol": "wrxinr",
        //           "price": "9293.0",
        //           "origQty": "10.0",
        //           "executedQty": "8.2",
        //           "status": "cancel",
        //           "type": "limit",
        //           "side": "sell",
        //           "createdTime": 1499827319559,
        //           "updatedTime": 1499827319559
        //       },
        //       {
        //           "id": 30,
        //           "symbol": "wrxinr",
        //           "price": "9293.0",
        //           "stopPrice": "9200.0",
        //           "origQty": "10.0",
        //           "executedQty": "0.0",
        //           "status": "cancel",
        //           "type": "stop_limit",
        //           "side": "sell",
        //           "createdTime": 1499827319559,
        //           "updatedTime": 1507725176595
        //       }
        //   ]
        //
        object orders = this.parseOrders(response, market, since, limit);
        orders = this.filterBy(orders, "symbol", symbol);
        return orders;
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["symbol"] = getValue(market, "id");
        }
        object response = await this.privateGetOpenOrders(this.extend(request, parameters));
        // [
        //     {
        //         "id": 28,
        //         "symbol": "wrxinr",
        //         "price": "9293.0",
        //         "origQty": "10.0",
        //         "executedQty": "8.2",
        //         "status": "cancel",
        //         "type": "limit",
        //         "side": "sell",
        //         "createdTime": 1499827319559,
        //         "updatedTime": 1499827319559
        //     },
        //     {
        //         "id": 30,
        //         "symbol": "wrxinr",
        //         "price": "9293.0",
        //         "stopPrice": "9200.0",
        //         "origQty": "10.0",
        //         "executedQty": "0.0",
        //         "status": "cancel",
        //         "type": "stop_limit",
        //         "side": "sell",
        //         "createdTime": 1499827319559,
        //         "updatedTime": 1507725176595
        //     }
        // ]
        object orders = this.parseOrders(response, market, since, limit);
        return orders;
    }

    public async override Task<object> cancelAllOrders(object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#cancelAllOrders
        * @description cancel all open orders in a market
        * @param {string} symbol unified market symbol of the market to cancel orders in
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " cancelAllOrders() requires a `symbol` argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        return await this.privateDeleteOpenOrders(this.extend(request, parameters));
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " cancelOrder() requires a `symbol` argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "orderId", id },
        };
        object response = await this.privateDeleteOrder(this.extend(request, parameters));
        return this.parseOrder(response);
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name wazirx#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the wazirx api endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        type = ((string)type).ToLower();
        if (isTrue(isTrue((!isEqual(type, "limit"))) && isTrue((!isEqual(type, "stop_limit")))))
        {
            throw new ExchangeError ((string)add(this.id, " createOrder() supports limit and stop_limit orders only")) ;
        }
        if (isTrue(isEqual(price, null)))
        {
            throw new ExchangeError ((string)add(this.id, " createOrder() requires a price argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "side", side },
            { "quantity", amount },
            { "type", "limit" },
        };
        ((Dictionary<string, object>)request)["price"] = this.priceToPrecision(symbol, price);
        object stopPrice = this.safeString(parameters, "stopPrice");
        if (isTrue(!isEqual(stopPrice, null)))
        {
            ((Dictionary<string, object>)request)["type"] = "stop_limit";
        }
        object response = await this.privatePostOrder(this.extend(request, parameters));
        // {
        //     "id": 28,
        //     "symbol": "wrxinr",
        //     "price": "9293.0",
        //     "origQty": "10.0",
        //     "executedQty": "8.2",
        //     "status": "wait",
        //     "type": "limit",
        //     "side": "sell",
        //     "createdTime": 1499827319559,
        //     "updatedTime": 1499827319559
        // }
        return this.parseOrder(response, market);
    }

    public override object parseOrder(object order, object market = null)
    {
        // {
        //     "id":1949417813,
        //     "symbol":"ltcusdt",
        //     "type":"limit",
        //     "side":"sell",
        //     "status":"done",
        //     "price":"146.2",
        //     "origQty":"0.05",
        //     "executedQty":"0.05",
        //     "createdTime":1641252564000,
        //     "updatedTime":1641252564000
        // },
        object created = this.safeInteger(order, "createdTime");
        object updated = this.safeInteger(order, "updatedTime");
        object marketId = this.safeString(order, "symbol");
        object symbol = this.safeSymbol(marketId, market);
        object amount = this.safeString(order, "quantity");
        object filled = this.safeString(order, "executedQty");
        object status = this.parseOrderStatus(this.safeString(order, "status"));
        object id = this.safeString(order, "id");
        object price = this.safeString(order, "price");
        object type = this.safeStringLower(order, "type");
        object side = this.safeStringLower(order, "side");
        return this.safeOrder(new Dictionary<string, object>() {
            { "info", order },
            { "id", id },
            { "clientOrderId", null },
            { "timestamp", created },
            { "datetime", this.iso8601(created) },
            { "lastTradeTimestamp", updated },
            { "status", status },
            { "symbol", symbol },
            { "type", type },
            { "timeInForce", null },
            { "postOnly", null },
            { "side", side },
            { "price", price },
            { "amount", amount },
            { "filled", filled },
            { "remaining", null },
            { "cost", null },
            { "fee", null },
            { "average", null },
            { "trades", new List<object>() {} },
        }, market);
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "wait", "open" },
            { "done", "closed" },
            { "cancel", "canceled" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object url = add(add(getValue(getValue(this.urls, "api"), "rest"), "/"), path);
        if (isTrue(isEqual(api, "public")))
        {
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)parameters).Keys))))
            {
                url = add(url, add("?", this.urlencode(parameters)));
            }
        }
        if (isTrue(isEqual(api, "private")))
        {
            this.checkRequiredCredentials();
            object timestamp = this.milliseconds();
            object data = this.extend(new Dictionary<string, object>() {
                { "recvWindow", getValue(this.options, "recvWindow") },
                { "timestamp", timestamp },
            }, parameters);
            data = this.keysort(data);
            object signature = this.hmac(this.encode(this.urlencode(data)), this.encode(this.secret), sha256);
            url = add(url, add("?", this.urlencode(data)));
            url = add(url, add(add("&", "signature="), signature));
            headers = new Dictionary<string, object>() {
                { "Content-Type", "application/x-www-form-urlencoded" },
                { "X-Api-Key", this.apiKey },
            };
        }
        return new Dictionary<string, object>() {
            { "url", url },
            { "method", method },
            { "body", body },
            { "headers", headers },
        };
    }

    public override object handleErrors(object code, object reason, object url, object method, object headers, object body, object response, object requestHeaders, object requestBody)
    {
        //
        // {"code":2098,"message":"Request out of receiving window."}
        //
        if (isTrue(isEqual(response, null)))
        {
            return null;
        }
        object errorCode = this.safeString(response, "code");
        if (isTrue(!isEqual(errorCode, null)))
        {
            object feedback = add(add(this.id, " "), body);
            this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), errorCode, feedback);
            throw new ExchangeError ((string)feedback) ;
        }
        return null;
    }
}
