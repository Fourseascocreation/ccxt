using Main;
namespace Main;

partial class flowbtc : ndax
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "flowbtc" },
            { "name", "flowBTC" },
            { "countries", new List<object>() {"BR"} },
            { "rateLimit", 1000 },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/51840849/87443317-01c0d080-c5fe-11ea-95c2-9ebe1a8fafd9.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "public", "https://api.flowbtc.com.br:8443/ap/" },
                    { "private", "https://api.flowbtc.com.br:8443/ap/" },
                } },
                { "www", "https://www.flowbtc.com.br" },
                { "doc", "https://www.flowbtc.com.br/api.html" },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "tierBased", false },
                    { "percentage", true },
                    { "maker", 0.0025 },
                    { "taker", 0.005 },
                } },
            } },
        });
    }
}
