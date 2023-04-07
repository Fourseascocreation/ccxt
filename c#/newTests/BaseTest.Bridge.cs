using System.Globalization;

namespace Tests;
using Main;
using dict = System.Collections.Generic.Dictionary<string, object>;

public class Helper
{
    public static void Green(string message)
    {
        System.Console.ForegroundColor = System.ConsoleColor.Green;
        System.Console.WriteLine(message);
        System.Console.ResetColor();
    }

    public static void Red(string message)
    {
        System.Console.ForegroundColor = System.ConsoleColor.Red;
        System.Console.WriteLine(message);
        System.Console.ResetColor();
    }

    public static void Warn(string message)
    {
        System.Console.ForegroundColor = System.ConsoleColor.Yellow;
        System.Console.WriteLine(message);
        System.Console.ResetColor();
    }
}

public partial class BaseTest
{
    public static void Assert(bool condition, object message2 = null)
    {
        var message = message2?.ToString();
        if (!condition)
        {
            var errorMessage = "Assertion failed";
            if (message != null)
            {
                errorMessage += ": " + message;
            }
            throw new Exception(errorMessage);
        }
    }
}

public partial class BaseTest
{
    public int TRUNCATE = Main.Exchange.TRUNCATE;
    public int DECIMAL_PLACES = Main.Exchange.DECIMAL_PLACES;
    public int ROUND = Main.Exchange.ROUND;
    public int ROUND_UP = Main.Exchange.ROUND_UP;
    public int ROUND_DOWN = Main.Exchange.ROUND_DOWN;
    public int SIGNIFICANT_DIGITS = Main.Exchange.SIGNIFICANT_DIGITS;
    public int TICK_SIZE = Main.Exchange.TICK_SIZE;
    public int NO_PADDING = Main.Exchange.NO_PADDING;
    public int PAD_WITH_ZERO = Main.Exchange.PAD_WITH_ZERO;

    // public Main.Precise Precise = Main.Precise;
    // initialize methods used here; (improve this later)
    public string numberToString(object a)
    {
        return this.exchange.numberToString(a);
    }
    public string decimalToPrecision(object a, object b, object c = null, object d = null, object e = null)
    {
        return this.exchange.decimalToPrecision(a, b, c, d, e);
    }
}

public partial class BaseTest
{

    // bridges to make auxiliary methods available in tests
    public object getValue(object a, object b) => Exchange.GetValue(a, b);
    public object getArrayLength(object a) => Exchange.getArrayLength(a);
    public bool isLessThan(object a, object b) => Exchange.isLessThan(a, b);
    public bool isGreaterThan(object a, object b) => Exchange.isGreaterThan(a, b);
    public bool isGreaterThanOrEqual(object a, object b) => Exchange.isGreaterThanOrEqual(a, b);
    public bool isLessThanOrEqual(object a, object b) => Exchange.isLessThanOrEqual(a, b);
    public object postFixIncrement(ref object a) => Exchange.postFixIncrement(ref a);
    public object add(object a, object b) => Exchange.add(a, b);
    public object subtract(object a, object b) => Exchange.subtract(a, b);
    public string toStringOrNull(object a) => Exchange.toStringOrNull(a);
    public static bool isEqual(object a, object b) => Exchange.isEqual(a, b);
    public static bool isTrue(object a) => Exchange.isTrue(a);
    public static object encode(object a) => a;
    public static string hash(object request2, Delegate algorithm2 = null, object digest2 = null) => Exchange.Hash(request2, algorithm2, digest2);
    public static string hmac(object request2, object secret2, Delegate algorithm2 = null, string digest = "hex") => Exchange.Hmac(request2, secret2, algorithm2, digest);
    public static string rsa(object request, object secret, Delegate alg = null) => Exchange.Rsa(request, secret, alg);
    public static string ecdsa(object request, object secret, Delegate alg = null, Delegate stub = null) => Exchange.Ecdsa(request, secret, alg, stub);
    public string jwt(object data, object secret, Delegate alg = null, bool isRsa = false) => Exchange.Jwt(data, secret, alg, isRsa);

    public static object crc32(object str, object signed2 = null) => Exchange.Crc32(str, signed2);
    public static string sha1() => "sha1";
    public static string sha256() => "sha256";
    public static string sha384() => "sha384";
    public static string sha512() => "sha512";
    public static string md5() => "md5";
    public static string ed25519() => "ed25519";
    public static string keccak() => "keccak";
    public static string secp256k1() => "secp256k1";

    public bool equals(object a, object b)
    {
        var dict1 = a as dict;
        var dict2 = b as dict;

        var keysA = dict1.Keys;
        foreach (var key in keysA)
        {
            if (!dict2.ContainsKey(key))
            {
                return false;
            }
            if (!isEqual(dict1[key], dict2[key]))
            {
                return false;
            }
        }
        return true;
    }

}