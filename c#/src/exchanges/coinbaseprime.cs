using Main;
namespace Main;

partial class coinbaseprime : coinbasepro
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "coinbaseprime" },
            { "name", "Coinbase Prime" },
            { "pro", true },
            { "hostname", "exchange.coinbase.com" },
            { "urls", new Dictionary<string, object>() {
                { "test", new Dictionary<string, object>() {
                    { "public", "https://public.sandbox.exchange.coinbase.com" },
                    { "private", "https://public.sandbox.exchange.coinbase.com" },
                } },
                { "logo", "https://user-images.githubusercontent.com/1294454/44539184-29f26e00-a70c-11e8-868f-e907fc236a7c.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "public", "https://api.{hostname}" },
                    { "private", "https://api.{hostname}" },
                } },
                { "www", "https://exchange.coinbase.com" },
                { "doc", "https://docs.exchange.coinbase.com" },
            } },
        });
    }
}
