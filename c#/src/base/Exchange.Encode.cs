namespace Main;
using System.Security.Cryptography;
using System.Text;


using dict = Dictionary<string, object>;
using list = List<object>;

public partial class Exchange
{

    public object base16ToBinary(object str)
    {
        return (string)str; // stub
    }

    public object remove0xPrefix(object str)
    {
        return (string)str; // stub
    }

    public string stringToBase64(object pt)
    {
        var plainText = (string)pt;
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    public string base64ToBinary(object pt)
    {
        // check this
        var plainText = (string)pt;
        var base64EncodedBytes = System.Convert.FromBase64String(plainText);
        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    }

    public string base58ToBinary(object str)
    {
        return (string)str; // stub
    }

    public object binaryConcat(object a, object b)
    {
        return (string)a + (string)b; // stub
    }

    public object binaryConcatArray(object a)
    {
        return (string)a; // stub
    }

    public object numberToBE(object n, object padding = null)
    {
        // implement number to big endian
        return (string)n; // stub
    }

    public static string binaryToHex(byte[] buff)
    {
        var result = string.Empty;
        foreach (var t in buff)
            result += t.ToString("X2");
        // return result;
        return result.ToLower();// check this
    }

    public string binaryToBase16(object buff2)
    {
        var buff = (byte[])buff2;
        return binaryToHex(buff);
    }

    public static string binaryToBase64(byte[] buff)
    {
        return Convert.ToBase64String(buff);
    }

    public byte[] stringToBinary(string buff)
    {
        return Encoding.UTF8.GetBytes(buff);
    }

    public string encode(object data)
    {
        return (string)data; // stub for python
    }

    public string decode(object data)
    {
        return (string)data; // stub for python
    }

    public string rawencode(object paramaters1)
    {
        var paramaters = (dict)paramaters1;
        var keys = new List<string>(((dict)paramaters).Keys);
        var outList = new List<object>();
        foreach (string key in keys)
        {
            outList.Add(key + "=" + paramaters[key]);
        }
        return string.Join("&", outList);
    }

    public string urlencodeWithArrayRepeat(object parameters)
    {
        var paramaters = (dict)parameters;
        var keys = new List<string>(((dict)paramaters).Keys);
        var outList = new List<object>();
        foreach (string key in keys)
        {
            outList.Add(key + "=" + paramaters[key]);
        }
        return string.Join("&", outList);
    }

    public string urlencodeNested(object paramaters)
    {
        // stub check this out
        var queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
        var keys = new List<string>(((dict)paramaters).Keys);
        foreach (string key in keys)
        {
            var value = ((dict)paramaters)[key];
            if (value != null && value.GetType() == typeof(dict))
            {
                var keys2 = new List<string>(((dict)value).Keys);
                foreach (string key2 in keys2)
                {
                    var value2 = ((dict)value)[key2];
                    queryString.Add(key + "[" + key2 + "]", value2.ToString());
                }
            }
            else
            {
                queryString.Add(key, value.ToString());
            }
        }
        return queryString.ToString();
    }

    public string urlencode(object parameters2)
    {
        var parameters = (dict)parameters2;
        var x = new Dictionary<string, object>() { { "ola", 1 } };
        var y = new List<string>(x.Keys);
        var z = new List<object>(x.Values);

        var queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
        var keys = new List<string>(parameters.Keys);
        foreach (string key in keys)
        {
            queryString.Add(key, parameters[key].ToString());
        }
        return queryString.ToString();
    }

    public string encodeURIComponent(string str)
    {
        // check this later
        var result = new StringBuilder();
        var unreserved = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";
        foreach (char symbol in str)
        {
            if (unreserved.IndexOf(symbol) != -1)
            {
                result.Append(symbol);
            }
            else
            {
                result.Append('%' + string.Format("{0:X2}", (int)symbol));
            }
        }
        return result.ToString();
    }

}
