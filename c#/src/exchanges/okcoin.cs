using Main;
namespace Main;

partial class okcoin : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "okcoin" },
            { "name", "OKCoin" },
            { "countries", new List<object>() {"CN", "US"} },
            { "version", "v3" },
            { "rateLimit", 20 },
            { "pro", true },
            { "has", new Dictionary<string, object>() {
                { "CORS", null },
                { "spot", true },
                { "margin", false },
                { "swap", null },
                { "future", true },
                { "option", null },
                { "cancelOrder", true },
                { "createOrder", true },
                { "fetchBalance", true },
                { "fetchClosedOrders", true },
                { "fetchCurrencies", true },
                { "fetchDepositAddress", true },
                { "fetchDeposits", true },
                { "fetchLedger", true },
                { "fetchMarkets", true },
                { "fetchMyTrades", true },
                { "fetchOHLCV", true },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchOrders", null },
                { "fetchOrderTrades", true },
                { "fetchPosition", true },
                { "fetchPositions", true },
                { "fetchTicker", true },
                { "fetchTickers", true },
                { "fetchTime", true },
                { "fetchTrades", true },
                { "fetchTransactions", null },
                { "fetchWithdrawals", true },
                { "transfer", true },
                { "withdraw", true },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "60" },
                { "3m", "180" },
                { "5m", "300" },
                { "15m", "900" },
                { "30m", "1800" },
                { "1h", "3600" },
                { "2h", "7200" },
                { "4h", "14400" },
                { "6h", "21600" },
                { "12h", "43200" },
                { "1d", "86400" },
                { "1w", "604800" },
                { "1M", "2678400" },
                { "3M", "8035200" },
                { "6M", "16070400" },
                { "1y", "31536000" },
            } },
            { "hostname", "okcoin.com" },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/51840849/87295551-102fbf00-c50e-11ea-90a9-462eebba5829.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "rest", "https://www.{hostname}" },
                } },
                { "www", "https://www.okcoin.com" },
                { "doc", "https://www.okcoin.com/docs/en/" },
                { "fees", "https://www.okcoin.com/coin-fees" },
                { "referral", "https://www.okcoin.com/account/register?flag=activity&channelId=600001513" },
                { "test", new Dictionary<string, object>() {
                    { "rest", "https://testnet.okex.com" },
                } },
            } },
            { "api", new Dictionary<string, object>() {
                { "general", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "time", 8.3334 },
                    } },
                } },
                { "account", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "wallet", 8.3334 },
                        { "sub-account", 1000 },
                        { "asset-valuation", 1000 },
                        { "wallet/{currency}", 8.3334 },
                        { "withdrawal/history", 8.3334 },
                        { "withdrawal/history/{currency}", 8.3334 },
                        { "ledger", 5 },
                        { "deposit/address", 8.3334 },
                        { "deposit/history", 8.3334 },
                        { "deposit/history/{currency}", 8.3334 },
                        { "currencies", 8.3334 },
                        { "withdrawal/fee", 8.3334 },
                        { "deposit-lightning", 50 },
                        { "withdrawal-lightning", 50 },
                        { "fiat/deposit/detail", 5 },
                        { "fiat/deposit/details", 8.3334 },
                        { "fiat/withdraw/detail", 5 },
                        { "fiat/withdraw/details", 8.3334 },
                        { "fiat/channel", 8.3334 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "transfer", 100 },
                        { "withdrawal", 8.3334 },
                        { "fiat/cancel_deposit", 1 },
                        { "fiat/deposit", 8.3334 },
                        { "fiat/withdraw", 8.3334 },
                        { "fiat/cancel_withdrawal", 1 },
                    } },
                } },
                { "otc", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "rfq/instruments", 50 },
                        { "rfq/trade", 50 },
                        { "rfq/history", 50 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "rfq/quote", 50 },
                        { "rfq/trade", 50 },
                    } },
                } },
                { "users", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "subaccount-info", 20 },
                        { "account-info", 20 },
                        { "subaccount/apikey", 20 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "create-subaccount", 5 },
                        { "delete-subaccount", 5 },
                        { "subaccount/apikey", 50 },
                        { "subacount/delete-apikey", 20 },
                        { "subacount/modify-apikey", 20 },
                    } },
                } },
                { "earning", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "offers", 5 },
                        { "orders", 5 },
                        { "positions", 8.3334 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "purchase", 5 },
                        { "redeem", 5 },
                        { "cancel", 5 },
                    } },
                } },
                { "spot", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "accounts", 5 },
                        { "accounts/{currency}", 5 },
                        { "accounts/{currency}/ledger", 5 },
                        { "orders", 10 },
                        { "orders_pending", 5 },
                        { "orders/{order_id}", 5 },
                        { "orders/{client_oid}", 5 },
                        { "trade_fee", 5 },
                        { "fills", 10 },
                        { "algo", 5 },
                        { "instruments", 5 },
                        { "instruments/{instrument_id}/book", 5 },
                        { "instruments/ticker", 5 },
                        { "instruments/{instrument_id}/ticker", 5 },
                        { "instruments/{instrument_id}/trades", 5 },
                        { "instruments/{instrument_id}/candles", 5 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "order_algo", 2.5 },
                        { "orders", 1 },
                        { "batch_orders", 2 },
                        { "cancel_orders/{order_id}", 1 },
                        { "cancel_orders/{client_oid}", 1 },
                        { "cancel_batch_algos", 5 },
                        { "cancel_batch_orders", 5 },
                        { "amend_order/{instrument_id}", 2.5 },
                        { "amend_batch_orders", 5 },
                    } },
                } },
                { "margin", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "accounts", 5 },
                        { "accounts/{instrument_id}", 5 },
                        { "accounts/{instrument_id}/ledger", 5 },
                        { "accounts/availability", 5 },
                        { "accounts/{instrument_id}/availability", 5 },
                        { "accounts/borrowed", 5 },
                        { "accounts/{instrument_id}/borrowed", 5 },
                        { "orders", 10 },
                        { "accounts/{instrument_id}/leverage", 1 },
                        { "orders/{order_id}", 5 },
                        { "orders/{client_oid}", 5 },
                        { "orders_pending", 5 },
                        { "fills", 10 },
                        { "instruments/{instrument_id}/mark_price", 5 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "accounts/borrow", 1 },
                        { "accounts/repayment", 1 },
                        { "orders", 1 },
                        { "batch_orders", 2 },
                        { "cancel_orders", 1 },
                        { "cancel_orders/{order_id}", 1 },
                        { "cancel_orders/{client_oid}", 1 },
                        { "cancel_batch_orders", 2 },
                        { "amend_order/{instrument_id}", 2.5 },
                        { "amend_batch_orders", 5 },
                        { "accounts/{instrument_id}/leverage", 1 },
                    } },
                } },
                { "system", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "status", 250 },
                    } },
                } },
                { "market", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "oracle", 250 },
                    } },
                } },
                { "futures", new Dictionary<string, object>() {
                    { "get", new List<object>() {"position", "{instrument_id}/position", "accounts", "accounts/{underlying}", "accounts/{underlying}/leverage", "accounts/{underlying}/ledger", "order_algo/{instrument_id}", "orders/{instrument_id}", "orders/{instrument_id}/{order_id}", "orders/{instrument_id}/{client_oid}", "fills", "trade_fee", "accounts/{instrument_id}/holds", "instruments", "instruments/{instrument_id}/book", "instruments/ticker", "instruments/{instrument_id}/ticker", "instruments/{instrument_id}/trades", "instruments/{instrument_id}/candles", "instruments/{instrument_id}/history/candles", "instruments/{instrument_id}/index", "rate", "instruments/{instrument_id}/estimated_price", "instruments/{instrument_id}/open_interest", "instruments/{instrument_id}/price_limit", "instruments/{instrument_id}/mark_price", "instruments/{instrument_id}/liquidation"} },
                    { "post", new List<object>() {"accounts/{underlying}/leverage", "order", "amend_order/{instrument_id}", "orders", "cancel_order/{instrument_id}/{order_id}", "cancel_order/{instrument_id}/{client_oid}", "cancel_batch_orders/{instrument_id}", "accounts/margin_mode", "close_position", "cancel_all", "order_algo", "cancel_algos"} },
                } },
                { "swap", new Dictionary<string, object>() {
                    { "get", new List<object>() {"position", "{instrument_id}/position", "accounts", "{instrument_id}/accounts", "accounts/{instrument_id}/settings", "accounts/{instrument_id}/ledger", "orders/{instrument_id}", "orders/{instrument_id}/{order_id}", "orders/{instrument_id}/{client_oid}", "fills", "accounts/{instrument_id}/holds", "trade_fee", "order_algo/{instrument_id}", "instruments", "instruments/{instrument_id}/depth", "instruments/ticker", "instruments/{instrument_id}/ticker", "instruments/{instrument_id}/trades", "instruments/{instrument_id}/candles", "instruments/{instrument_id}/history/candles", "instruments/{instrument_id}/index", "rate", "instruments/{instrument_id}/open_interest", "instruments/{instrument_id}/price_limit", "instruments/{instrument_id}/liquidation", "instruments/{instrument_id}/funding_time", "instruments/{instrument_id}/mark_price", "instruments/{instrument_id}/historical_funding_rate"} },
                    { "post", new List<object>() {"accounts/{instrument_id}/leverage", "order", "amend_order/{instrument_id}", "orders", "cancel_order/{instrument_id}/{order_id}", "cancel_order/{instrument_id}/{client_oid}", "cancel_batch_orders/{instrument_id}", "order_algo", "cancel_algos", "close_position", "cancel_all"} },
                } },
                { "option", new Dictionary<string, object>() {
                    { "get", new List<object>() {"accounts", "position", "{underlying}/position", "accounts/{underlying}", "orders/{underlying}", "fills/{underlying}", "accounts/{underlying}/ledger", "trade_fee", "orders/{underlying}/{order_id}", "orders/{underlying}/{client_oid}", "underlying", "instruments/{underlying}", "instruments/{underlying}/summary", "instruments/{underlying}/summary/{instrument_id}", "instruments/{instrument_id}/book", "instruments/{instrument_id}/trades", "instruments/{instrument_id}/ticker", "instruments/{instrument_id}/candles"} },
                    { "post", new List<object>() {"order", "orders", "cancel_order/{underlying}/{order_id}", "cancel_order/{underlying}/{client_oid}", "cancel_batch_orders/{underlying}", "amend_order/{underlying}", "amend_batch_orders/{underlying}"} },
                } },
                { "information", new Dictionary<string, object>() {
                    { "get", new List<object>() {"{currency}/long_short_ratio", "{currency}/volume", "{currency}/taker", "{currency}/sentiment", "{currency}/margin"} },
                } },
                { "index", new Dictionary<string, object>() {
                    { "get", new List<object>() {"{instrument_id}/constituents"} },
                } },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "taker", 0.002 },
                    { "maker", 0.001 },
                } },
                { "spot", new Dictionary<string, object>() {
                    { "taker", 0.0015 },
                    { "maker", 0.001 },
                } },
            } },
            { "requiredCredentials", new Dictionary<string, object>() {
                { "apiKey", true },
                { "secret", true },
                { "password", true },
            } },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {
                    { "1", typeof(ExchangeError) },
                    { "failure to get a peer from the ring-balancer", typeof(ExchangeNotAvailable) },
                    { "Server is busy, please try again.", typeof(ExchangeNotAvailable) },
                    { "An unexpected error occurred", typeof(ExchangeError) },
                    { "System error", typeof(ExchangeError) },
                    { "4010", typeof(PermissionDenied) },
                    { "4001", typeof(ExchangeError) },
                    { "4002", typeof(ExchangeError) },
                    { "30001", typeof(AuthenticationError) },
                    { "30002", typeof(AuthenticationError) },
                    { "30003", typeof(AuthenticationError) },
                    { "30004", typeof(AuthenticationError) },
                    { "30005", typeof(InvalidNonce) },
                    { "30006", typeof(AuthenticationError) },
                    { "30007", typeof(BadRequest) },
                    { "30008", typeof(RequestTimeout) },
                    { "30009", typeof(ExchangeError) },
                    { "30010", typeof(AuthenticationError) },
                    { "30011", typeof(PermissionDenied) },
                    { "30012", typeof(AuthenticationError) },
                    { "30013", typeof(AuthenticationError) },
                    { "30014", typeof(DDoSProtection) },
                    { "30015", typeof(AuthenticationError) },
                    { "30016", typeof(ExchangeError) },
                    { "30017", typeof(ExchangeError) },
                    { "30018", typeof(ExchangeError) },
                    { "30019", typeof(ExchangeNotAvailable) },
                    { "30020", typeof(BadRequest) },
                    { "30021", typeof(BadRequest) },
                    { "30022", typeof(PermissionDenied) },
                    { "30023", typeof(BadRequest) },
                    { "30024", typeof(BadSymbol) },
                    { "30025", typeof(BadRequest) },
                    { "30026", typeof(DDoSProtection) },
                    { "30027", typeof(AuthenticationError) },
                    { "30028", typeof(PermissionDenied) },
                    { "30029", typeof(AccountSuspended) },
                    { "30030", typeof(ExchangeNotAvailable) },
                    { "30031", typeof(BadRequest) },
                    { "30032", typeof(BadSymbol) },
                    { "30033", typeof(BadRequest) },
                    { "30034", typeof(ExchangeError) },
                    { "30035", typeof(ExchangeError) },
                    { "30036", typeof(ExchangeError) },
                    { "30037", typeof(ExchangeNotAvailable) },
                    { "30038", typeof(OnMaintenance) },
                    { "30044", typeof(RequestTimeout) },
                    { "32001", typeof(AccountSuspended) },
                    { "32002", typeof(PermissionDenied) },
                    { "32003", typeof(CancelPending) },
                    { "32004", typeof(ExchangeError) },
                    { "32005", typeof(InvalidOrder) },
                    { "32006", typeof(InvalidOrder) },
                    { "32007", typeof(InvalidOrder) },
                    { "32008", typeof(InvalidOrder) },
                    { "32009", typeof(InvalidOrder) },
                    { "32010", typeof(ExchangeError) },
                    { "32011", typeof(ExchangeError) },
                    { "32012", typeof(ExchangeError) },
                    { "32013", typeof(ExchangeError) },
                    { "32014", typeof(ExchangeError) },
                    { "32015", typeof(ExchangeError) },
                    { "32016", typeof(ExchangeError) },
                    { "32017", typeof(ExchangeError) },
                    { "32018", typeof(ExchangeError) },
                    { "32019", typeof(ExchangeError) },
                    { "32020", typeof(ExchangeError) },
                    { "32021", typeof(ExchangeError) },
                    { "32022", typeof(ExchangeError) },
                    { "32023", typeof(ExchangeError) },
                    { "32024", typeof(ExchangeError) },
                    { "32025", typeof(ExchangeError) },
                    { "32026", typeof(ExchangeError) },
                    { "32027", typeof(ExchangeError) },
                    { "32028", typeof(ExchangeError) },
                    { "32029", typeof(ExchangeError) },
                    { "32030", typeof(InvalidOrder) },
                    { "32031", typeof(ArgumentsRequired) },
                    { "32038", typeof(AuthenticationError) },
                    { "32040", typeof(ExchangeError) },
                    { "32044", typeof(ExchangeError) },
                    { "32045", typeof(ExchangeError) },
                    { "32046", typeof(ExchangeError) },
                    { "32047", typeof(ExchangeError) },
                    { "32048", typeof(InvalidOrder) },
                    { "32049", typeof(ExchangeError) },
                    { "32050", typeof(InvalidOrder) },
                    { "32051", typeof(InvalidOrder) },
                    { "32052", typeof(ExchangeError) },
                    { "32053", typeof(ExchangeError) },
                    { "32057", typeof(ExchangeError) },
                    { "32054", typeof(ExchangeError) },
                    { "32055", typeof(InvalidOrder) },
                    { "32056", typeof(ExchangeError) },
                    { "32058", typeof(ExchangeError) },
                    { "32059", typeof(InvalidOrder) },
                    { "32060", typeof(InvalidOrder) },
                    { "32061", typeof(InvalidOrder) },
                    { "32062", typeof(InvalidOrder) },
                    { "32063", typeof(InvalidOrder) },
                    { "32064", typeof(ExchangeError) },
                    { "32065", typeof(ExchangeError) },
                    { "32066", typeof(ExchangeError) },
                    { "32067", typeof(ExchangeError) },
                    { "32068", typeof(ExchangeError) },
                    { "32069", typeof(ExchangeError) },
                    { "32070", typeof(ExchangeError) },
                    { "32071", typeof(ExchangeError) },
                    { "32072", typeof(ExchangeError) },
                    { "32073", typeof(ExchangeError) },
                    { "32074", typeof(ExchangeError) },
                    { "32075", typeof(ExchangeError) },
                    { "32076", typeof(ExchangeError) },
                    { "32077", typeof(ExchangeError) },
                    { "32078", typeof(ExchangeError) },
                    { "32079", typeof(ExchangeError) },
                    { "32080", typeof(ExchangeError) },
                    { "32083", typeof(ExchangeError) },
                    { "33001", typeof(PermissionDenied) },
                    { "33002", typeof(AccountSuspended) },
                    { "33003", typeof(InsufficientFunds) },
                    { "33004", typeof(ExchangeError) },
                    { "33005", typeof(ExchangeError) },
                    { "33006", typeof(ExchangeError) },
                    { "33007", typeof(ExchangeError) },
                    { "33008", typeof(InsufficientFunds) },
                    { "33009", typeof(ExchangeError) },
                    { "33010", typeof(ExchangeError) },
                    { "33011", typeof(ExchangeError) },
                    { "33012", typeof(ExchangeError) },
                    { "33013", typeof(InvalidOrder) },
                    { "33014", typeof(OrderNotFound) },
                    { "33015", typeof(InvalidOrder) },
                    { "33016", typeof(ExchangeError) },
                    { "33017", typeof(InsufficientFunds) },
                    { "33018", typeof(ExchangeError) },
                    { "33020", typeof(ExchangeError) },
                    { "33021", typeof(BadRequest) },
                    { "33022", typeof(InvalidOrder) },
                    { "33023", typeof(ExchangeError) },
                    { "33024", typeof(InvalidOrder) },
                    { "33025", typeof(InvalidOrder) },
                    { "33026", typeof(ExchangeError) },
                    { "33027", typeof(InvalidOrder) },
                    { "33028", typeof(InvalidOrder) },
                    { "33029", typeof(InvalidOrder) },
                    { "33034", typeof(ExchangeError) },
                    { "33035", typeof(ExchangeError) },
                    { "33036", typeof(ExchangeError) },
                    { "33037", typeof(ExchangeError) },
                    { "33038", typeof(ExchangeError) },
                    { "33039", typeof(ExchangeError) },
                    { "33040", typeof(ExchangeError) },
                    { "33041", typeof(ExchangeError) },
                    { "33042", typeof(ExchangeError) },
                    { "33043", typeof(ExchangeError) },
                    { "33044", typeof(ExchangeError) },
                    { "33045", typeof(ExchangeError) },
                    { "33046", typeof(ExchangeError) },
                    { "33047", typeof(ExchangeError) },
                    { "33048", typeof(ExchangeError) },
                    { "33049", typeof(ExchangeError) },
                    { "33050", typeof(ExchangeError) },
                    { "33051", typeof(ExchangeError) },
                    { "33059", typeof(BadRequest) },
                    { "33060", typeof(BadRequest) },
                    { "33061", typeof(ExchangeError) },
                    { "33062", typeof(ExchangeError) },
                    { "33063", typeof(ExchangeError) },
                    { "33064", typeof(ExchangeError) },
                    { "33065", typeof(ExchangeError) },
                    { "33085", typeof(InvalidOrder) },
                    { "21009", typeof(ExchangeError) },
                    { "34001", typeof(PermissionDenied) },
                    { "34002", typeof(InvalidAddress) },
                    { "34003", typeof(ExchangeError) },
                    { "34004", typeof(ExchangeError) },
                    { "34005", typeof(ExchangeError) },
                    { "34006", typeof(ExchangeError) },
                    { "34007", typeof(ExchangeError) },
                    { "34008", typeof(InsufficientFunds) },
                    { "34009", typeof(ExchangeError) },
                    { "34010", typeof(ExchangeError) },
                    { "34011", typeof(ExchangeError) },
                    { "34012", typeof(ExchangeError) },
                    { "34013", typeof(ExchangeError) },
                    { "34014", typeof(ExchangeError) },
                    { "34015", typeof(ExchangeError) },
                    { "34016", typeof(PermissionDenied) },
                    { "34017", typeof(AccountSuspended) },
                    { "34018", typeof(AuthenticationError) },
                    { "34019", typeof(PermissionDenied) },
                    { "34020", typeof(PermissionDenied) },
                    { "34021", typeof(InvalidAddress) },
                    { "34022", typeof(ExchangeError) },
                    { "34023", typeof(PermissionDenied) },
                    { "34026", typeof(RateLimitExceeded) },
                    { "34036", typeof(ExchangeError) },
                    { "34037", typeof(ExchangeError) },
                    { "34038", typeof(ExchangeError) },
                    { "34039", typeof(ExchangeError) },
                    { "35001", typeof(ExchangeError) },
                    { "35002", typeof(ExchangeError) },
                    { "35003", typeof(ExchangeError) },
                    { "35004", typeof(ExchangeError) },
                    { "35005", typeof(AuthenticationError) },
                    { "35008", typeof(InvalidOrder) },
                    { "35010", typeof(InvalidOrder) },
                    { "35012", typeof(InvalidOrder) },
                    { "35014", typeof(InvalidOrder) },
                    { "35015", typeof(InvalidOrder) },
                    { "35017", typeof(ExchangeError) },
                    { "35019", typeof(InvalidOrder) },
                    { "35020", typeof(InvalidOrder) },
                    { "35021", typeof(InvalidOrder) },
                    { "35022", typeof(BadRequest) },
                    { "35024", typeof(BadRequest) },
                    { "35025", typeof(InsufficientFunds) },
                    { "35026", typeof(BadRequest) },
                    { "35029", typeof(OrderNotFound) },
                    { "35030", typeof(InvalidOrder) },
                    { "35031", typeof(InvalidOrder) },
                    { "35032", typeof(ExchangeError) },
                    { "35037", typeof(ExchangeError) },
                    { "35039", typeof(InsufficientFunds) },
                    { "35040", typeof(InvalidOrder) },
                    { "35044", typeof(ExchangeError) },
                    { "35046", typeof(InsufficientFunds) },
                    { "35047", typeof(InsufficientFunds) },
                    { "35048", typeof(ExchangeError) },
                    { "35049", typeof(InvalidOrder) },
                    { "35050", typeof(InvalidOrder) },
                    { "35052", typeof(InsufficientFunds) },
                    { "35053", typeof(ExchangeError) },
                    { "35055", typeof(InsufficientFunds) },
                    { "35057", typeof(ExchangeError) },
                    { "35058", typeof(ExchangeError) },
                    { "35059", typeof(BadRequest) },
                    { "35060", typeof(BadRequest) },
                    { "35061", typeof(BadRequest) },
                    { "35062", typeof(InvalidOrder) },
                    { "35063", typeof(InvalidOrder) },
                    { "35064", typeof(InvalidOrder) },
                    { "35066", typeof(InvalidOrder) },
                    { "35067", typeof(InvalidOrder) },
                    { "35068", typeof(InvalidOrder) },
                    { "35069", typeof(InvalidOrder) },
                    { "35070", typeof(InvalidOrder) },
                    { "35071", typeof(InvalidOrder) },
                    { "35072", typeof(InvalidOrder) },
                    { "35073", typeof(InvalidOrder) },
                    { "35074", typeof(InvalidOrder) },
                    { "35075", typeof(InvalidOrder) },
                    { "35076", typeof(InvalidOrder) },
                    { "35077", typeof(InvalidOrder) },
                    { "35078", typeof(InvalidOrder) },
                    { "35079", typeof(InvalidOrder) },
                    { "35080", typeof(InvalidOrder) },
                    { "35081", typeof(InvalidOrder) },
                    { "35082", typeof(InvalidOrder) },
                    { "35083", typeof(InvalidOrder) },
                    { "35084", typeof(InvalidOrder) },
                    { "35085", typeof(InvalidOrder) },
                    { "35086", typeof(InvalidOrder) },
                    { "35087", typeof(InvalidOrder) },
                    { "35088", typeof(InvalidOrder) },
                    { "35089", typeof(InvalidOrder) },
                    { "35090", typeof(ExchangeError) },
                    { "35091", typeof(ExchangeError) },
                    { "35092", typeof(ExchangeError) },
                    { "35093", typeof(ExchangeError) },
                    { "35094", typeof(ExchangeError) },
                    { "35095", typeof(BadRequest) },
                    { "35096", typeof(ExchangeError) },
                    { "35097", typeof(ExchangeError) },
                    { "35098", typeof(ExchangeError) },
                    { "35099", typeof(ExchangeError) },
                    { "35102", typeof(RateLimitExceeded) },
                    { "36001", typeof(BadRequest) },
                    { "36002", typeof(BadRequest) },
                    { "36005", typeof(ExchangeError) },
                    { "36101", typeof(AuthenticationError) },
                    { "36102", typeof(PermissionDenied) },
                    { "36103", typeof(PermissionDenied) },
                    { "36104", typeof(PermissionDenied) },
                    { "36105", typeof(PermissionDenied) },
                    { "36106", typeof(PermissionDenied) },
                    { "36107", typeof(PermissionDenied) },
                    { "36108", typeof(InsufficientFunds) },
                    { "36109", typeof(PermissionDenied) },
                    { "36201", typeof(PermissionDenied) },
                    { "36202", typeof(PermissionDenied) },
                    { "36203", typeof(InvalidOrder) },
                    { "36204", typeof(ExchangeError) },
                    { "36205", typeof(BadRequest) },
                    { "36206", typeof(BadRequest) },
                    { "36207", typeof(InvalidOrder) },
                    { "36208", typeof(InvalidOrder) },
                    { "36209", typeof(InvalidOrder) },
                    { "36210", typeof(InvalidOrder) },
                    { "36211", typeof(InvalidOrder) },
                    { "36212", typeof(InvalidOrder) },
                    { "36213", typeof(InvalidOrder) },
                    { "36214", typeof(ExchangeError) },
                    { "36216", typeof(OrderNotFound) },
                    { "36217", typeof(InvalidOrder) },
                    { "36218", typeof(InvalidOrder) },
                    { "36219", typeof(InvalidOrder) },
                    { "36220", typeof(InvalidOrder) },
                    { "36221", typeof(InvalidOrder) },
                    { "36222", typeof(InvalidOrder) },
                    { "36223", typeof(InvalidOrder) },
                    { "36224", typeof(InvalidOrder) },
                    { "36225", typeof(InvalidOrder) },
                    { "36226", typeof(InvalidOrder) },
                    { "36227", typeof(InvalidOrder) },
                    { "36228", typeof(InvalidOrder) },
                    { "36229", typeof(InvalidOrder) },
                    { "36230", typeof(InvalidOrder) },
                } },
                { "broad", new Dictionary<string, object>() {} },
            } },
            { "precisionMode", TICK_SIZE },
            { "options", new Dictionary<string, object>() {
                { "fetchOHLCV", new Dictionary<string, object>() {
                    { "type", "Candles" },
                } },
                { "createMarketBuyOrderRequiresPrice", true },
                { "fetchMarkets", new List<object>() {"spot"} },
                { "defaultType", "spot" },
                { "accountsByType", new Dictionary<string, object>() {
                    { "spot", "1" },
                    { "funding", "6" },
                    { "main", "6" },
                } },
                { "accountsById", new Dictionary<string, object>() {
                    { "1", "spot" },
                    { "6", "funding" },
                } },
                { "auth", new Dictionary<string, object>() {
                    { "time", "public" },
                    { "currencies", "private" },
                    { "instruments", "public" },
                    { "rate", "public" },
                    { "{instrument_id}/constituents", "public" },
                } },
                { "warnOnFetchCurrenciesWithoutAuthorization", false },
            } },
            { "commonCurrencies", new Dictionary<string, object>() {
                { "AE", "AET" },
                { "BOX", "DefiBox" },
                { "HOT", "Hydro Protocol" },
                { "HSR", "HC" },
                { "MAG", "Maggie" },
                { "SBTC", "Super Bitcoin" },
                { "TRADE", "Unitrade" },
                { "YOYO", "YOYOW" },
                { "WIN", "WinToken" },
            } },
        });
    }

    public async override Task<object> fetchTime(object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchTime
        * @description fetches the current integer timestamp in milliseconds from the exchange server
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {int} the current integer timestamp in milliseconds from the exchange server
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.generalGetTime(parameters);
        //
        //     {
        //         "iso": "2015-01-07T23:47:25.201Z",
        //         "epoch": 1420674445.201
        //     }
        //
        return this.parse8601(this.safeString(response, "iso"));
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchMarkets
        * @description retrieves data on all markets for okcoin
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        parameters ??= new Dictionary<string, object>();
        object types = this.safeValue(this.options, "fetchMarkets");
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(types)); postFixIncrement(ref i))
        {
            object markets = await this.fetchMarketsByType(getValue(types, i), parameters);
            result = this.arrayConcat(result, markets);
        }
        return result;
    }

    public virtual object parseMarkets(object markets)
    {
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(markets)); postFixIncrement(ref i))
        {
            ((List<object>)result).Add(this.parseMarket(getValue(markets, i)));
        }
        return result;
    }

    public virtual object parseMarket(object market)
    {
        //
        // spot markets
        //
        //     {
        //         base_currency: "EOS",
        //         instrument_id: "EOS-OKB",
        //         min_size: "0.01",
        //         quote_currency: "OKB",
        //         size_increment: "0.000001",
        //         tick_size: "0.0001"
        //     }
        //
        // futures markets
        //
        //     {
        //         instrument_id: "XRP-USD-200320",
        //         underlying_index: "XRP",
        //         quote_currency: "USD",
        //         tick_size: "0.0001",
        //         contract_val: "10",
        //         listing: "2020-03-06",
        //         delivery: "2020-03-20",
        //         trade_increment: "1",
        //         alias: "this_week",
        //         underlying: "XRP-USD",
        //         base_currency: "XRP",
        //         settlement_currency: "XRP",
        //         is_inverse: "true",
        //         contract_val_currency: "USD",
        //     }
        //
        // swap markets
        //
        //     {
        //         instrument_id: "BSV-USD-SWAP",
        //         underlying_index: "BSV",
        //         quote_currency: "USD",
        //         coin: "BSV",
        //         contract_val: "10",
        //         listing: "2018-12-21T07:53:47.000Z",
        //         delivery: "2020-03-14T08:00:00.000Z",
        //         size_increment: "1",
        //         tick_size: "0.01",
        //         base_currency: "BSV",
        //         underlying: "BSV-USD",
        //         settlement_currency: "BSV",
        //         is_inverse: "true",
        //         contract_val_currency: "USD"
        //     }
        //
        // options markets
        //
        //     {
        //         instrument_id: 'BTC-USD-200327-4000-C',
        //         underlying: 'BTC-USD',
        //         settlement_currency: 'BTC',
        //         contract_val: '0.1000',
        //         option_type: 'C',
        //         strike: '4000',
        //         tick_size: '0.0005',
        //         lot_size: '1.0000',
        //         listing: '2019-12-25T08:30:36.302Z',
        //         delivery: '2020-03-27T08:00:00.000Z',
        //         state: '2',
        //         trading_start_time: '2019-12-25T08:30:36.302Z',
        //         timestamp: '2020-03-13T08:05:09.456Z',
        //     }
        //
        object id = this.safeString(market, "instrument_id");
        object optionType = this.safeValue(market, "option_type");
        object contractVal = this.safeNumber(market, "contract_val");
        object contract = !isEqual(contractVal, null);
        object futuresAlias = this.safeString(market, "alias");
        object marketType = "spot";
        object spot = !isTrue(contract);
        object option = (!isEqual(optionType, null));
        object future = !isTrue(option) && isTrue((!isEqual(futuresAlias, null)));
        object swap = isTrue(isTrue(contract) && !isTrue(future)) && !isTrue(option);
        object baseId = this.safeString(market, "base_currency");
        object quoteId = this.safeString(market, "quote_currency");
        object settleId = this.safeString(market, "settlement_currency");
        if (isTrue(option))
        {
            object underlying = this.safeString(market, "underlying");
            object parts = ((string)underlying).Split((string)"-").ToList<object>();
            baseId = this.safeString(parts, 0);
            quoteId = this.safeString(parts, 1);
            marketType = "option";
        } else if (isTrue(future))
        {
            baseId = this.safeString(market, "underlying_index");
            marketType = "futures";
        } else if (isTrue(swap))
        {
            marketType = "swap";
        }
        object bs = this.safeCurrencyCode(baseId);
        object quote = this.safeCurrencyCode(quoteId);
        object settle = this.safeCurrencyCode(settleId);
        object symbol = add(add(bs, "/"), quote);
        object expiryDatetime = this.safeString(market, "delivery");
        object expiry = null;
        object strike = this.safeValue(market, "strike");
        if (isTrue(contract))
        {
            symbol = add(add(symbol, ":"), settle);
            if (isTrue(isTrue(future) || isTrue(option)))
            {
                if (isTrue(future))
                {
                    expiryDatetime = add(expiryDatetime, "T00:00:00Z");
                }
                expiry = this.parse8601(expiryDatetime);
                symbol = add(add(symbol, "-"), this.yymmdd(expiry));
                if (isTrue(option))
                {
                    symbol = add(add(add(add(symbol, ":"), strike), ":"), optionType);
                    optionType = ((bool) isTrue((isEqual(optionType, "C")))) ? "call" : "put";
                }
            }
        }
        object lotSize = this.safeNumber2(market, "lot_size", "trade_increment");
        object minPrice = this.safeString(market, "tick_size");
        object minAmountString = this.safeString2(market, "min_size", "base_min_size");
        object minAmount = this.parseNumber(minAmountString);
        object minCost = null;
        if (isTrue(isTrue((!isEqual(minAmount, null))) && isTrue((!isEqual(minPrice, null)))))
        {
            minCost = this.parseNumber(Precise.stringMul(minPrice, minAmountString));
        }
        object fees = this.safeValue2(this.fees, marketType, "trading", new Dictionary<string, object>() {});
        object maxLeverageString = this.safeString(market, "max_leverage", "1");
        object maxLeverage = this.parseNumber(Precise.stringMax(maxLeverageString, "1"));
        object precisionPrice = this.parseNumber(minPrice);
        return this.extend(fees, new Dictionary<string, object>() {
            { "id", id },
            { "symbol", symbol },
            { "base", bs },
            { "quote", quote },
            { "settle", settle },
            { "baseId", baseId },
            { "quoteId", quoteId },
            { "settleId", settleId },
            { "type", marketType },
            { "spot", spot },
            { "margin", false },
            { "swap", swap },
            { "future", future },
            { "futures", future },
            { "option", option },
            { "active", true },
            { "contract", contract },
            { "linear", ((bool) isTrue(contract)) ? (isEqual(quote, settle)) : null },
            { "inverse", ((bool) isTrue(contract)) ? (isEqual(bs, settle)) : null },
            { "contractSize", contractVal },
            { "expiry", expiry },
            { "expiryDatetime", this.iso8601(expiry) },
            { "strike", strike },
            { "optionType", optionType },
            { "precision", new Dictionary<string, object>() {
                { "amount", this.safeNumber(market, "size_increment", lotSize) },
                { "price", precisionPrice },
            } },
            { "limits", new Dictionary<string, object>() {
                { "leverage", new Dictionary<string, object>() {
                    { "min", this.parseNumber("1") },
                    { "max", this.parseNumber(maxLeverage) },
                } },
                { "amount", new Dictionary<string, object>() {
                    { "min", minAmount },
                    { "max", null },
                } },
                { "price", new Dictionary<string, object>() {
                    { "min", precisionPrice },
                    { "max", null },
                } },
                { "cost", new Dictionary<string, object>() {
                    { "min", minCost },
                    { "max", null },
                } },
            } },
            { "info", market },
        });
    }

    public async virtual Task<object> fetchMarketsByType(object type, object parameters = null)
    {
        //
        // options markets
        //
        //     [
        //         {
        //             instrument_id: 'BTC-USD-200327-4000-C',
        //             underlying: 'BTC-USD',
        //             settlement_currency: 'BTC',
        //             contract_val: '0.1000',
        //             option_type: 'C',
        //             strike: '4000',
        //             tick_size: '0.0005',
        //             lot_size: '1.0000',
        //             listing: '2019-12-25T08:30:36.302Z',
        //             delivery: '2020-03-27T08:00:00.000Z',
        //             state: '2',
        //             trading_start_time: '2019-12-25T08:30:36.302Z',
        //             timestamp: '2020-03-13T08:05:09.456Z',
        //         },
        //     ]
        //
        //
        // spot markets
        //
        //     [
        //         {
        //             base_currency: "EOS",
        //             instrument_id: "EOS-OKB",
        //             min_size: "0.01",
        //             quote_currency: "OKB",
        //             size_increment: "0.000001",
        //             tick_size: "0.0001"
        //         }
        //     ]
        //
        // futures markets
        //
        //     [
        //         {
        //             instrument_id: "XRP-USD-200320",
        //             underlying_index: "XRP",
        //             quote_currency: "USD",
        //             tick_size: "0.0001",
        //             contract_val: "10",
        //             listing: "2020-03-06",
        //             delivery: "2020-03-20",
        //             trade_increment: "1",
        //             alias: "this_week",
        //             underlying: "XRP-USD",
        //             base_currency: "XRP",
        //             settlement_currency: "XRP",
        //             is_inverse: "true",
        //             contract_val_currency: "USD",
        //         }
        //     ]
        //
        // swap markets
        //
        //     [
        //         {
        //             instrument_id: "BSV-USD-SWAP",
        //             underlying_index: "BSV",
        //             quote_currency: "USD",
        //             coin: "BSV",
        //             contract_val: "10",
        //             listing: "2018-12-21T07:53:47.000Z",
        //             delivery: "2020-03-14T08:00:00.000Z",
        //             size_increment: "1",
        //             tick_size: "0.01",
        //             base_currency: "BSV",
        //             underlying: "BSV-USD",
        //             settlement_currency: "BSV",
        //             is_inverse: "true",
        //             contract_val_currency: "USD"
        //         }
        //     ]
        //
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(type, "option")))
        {
            object underlying = await this.optionGetUnderlying(parameters);
            object result = new List<object>() {};
            for (object i = 0; isLessThan(i, getArrayLength(underlying)); postFixIncrement(ref i))
            {
                object response = await this.optionGetInstrumentsUnderlying(new Dictionary<string, object>() {
    { "underlying", getValue(underlying, i) },
});
                result = this.arrayConcat(result, response);
            }
            return this.parseMarkets(result);
        } else if (isTrue(isTrue(isTrue((isEqual(type, "spot"))) || isTrue((isEqual(type, "futures")))) || isTrue((isEqual(type, "swap")))))
        {
            object method = add(type, "GetInstruments");
            object response = await this.callAsync(method, parameters);
            return this.parseMarkets(response);
        } else
        {
            throw new NotSupported ((string)add(add(this.id, " fetchMarketsByType() does not support market type "), type)) ;
        }
    }

    public async override Task<object> fetchCurrencies(object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchCurrencies
        * @description fetches all available currencies on an exchange
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} an associative dictionary of currencies
        */
        // despite that their docs say these endpoints are public:
        //     https://www.okex.com/api/account/v3/withdrawal/fee
        //     https://www.okex.com/api/account/v3/currencies
        // it will still reply with { "code":30001, "message": "OK-ACCESS-KEY header is required" }
        // if you attempt to access it without authentication
        //
        //     [
        //         {
        //             name: '',
        //             currency: 'BTC',
        //             can_withdraw: '1',
        //             can_deposit: '1',
        //             min_withdrawal: '0.0100000000000000'
        //         },
        //     ]
        //
        parameters ??= new Dictionary<string, object>();
        if (!isTrue(this.checkRequiredCredentials(false)))
        {
            if (isTrue(getValue(this.options, "warnOnFetchCurrenciesWithoutAuthorization")))
            {
                throw new ExchangeError ((string)add(this.id, " fetchCurrencies() is a private API endpoint that requires authentication with API keys. Set the API keys on the exchange instance or exchange.options[\"warnOnFetchCurrenciesWithoutAuthorization\"] = false to suppress this warning message.")) ;
            }
            return null;
        } else
        {
            object response = await this.accountGetCurrencies(parameters);
            object result = new Dictionary<string, object>() {};
            for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
            {
                object currency = getValue(response, i);
                object id = this.safeString(currency, "currency");
                object code = this.safeCurrencyCode(id);
                object name = this.safeString(currency, "name");
                object canDeposit = this.safeInteger(currency, "can_deposit");
                object canWithdraw = this.safeInteger(currency, "can_withdraw");
                object depositEnabled = (isEqual(canDeposit, 1));
                object withdrawEnabled = (isEqual(canWithdraw, 1));
                object active = ((bool) isTrue((isTrue(canDeposit) && isTrue(canWithdraw)))) ? true : false;
                ((Dictionary<string, object>)result)[(string)code] = new Dictionary<string, object>() {
                    { "id", id },
                    { "code", code },
                    { "info", currency },
                    { "type", null },
                    { "name", name },
                    { "active", active },
                    { "deposit", depositEnabled },
                    { "withdraw", withdrawEnabled },
                    { "fee", null },
                    { "precision", this.parseNumber("1e-8") },
                    { "limits", new Dictionary<string, object>() {
                        { "amount", new Dictionary<string, object>() {
                            { "min", null },
                            { "max", null },
                        } },
                        { "withdraw", new Dictionary<string, object>() {
                            { "min", this.safeNumber(currency, "min_withdrawal") },
                            { "max", null },
                        } },
                    } },
                };
            }
            return result;
        }
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object method = add(getValue(market, "type"), "GetInstrumentsInstrumentId");
        method = add(method, ((bool) isTrue((isEqual(getValue(market, "type"), "swap")))) ? "Depth" : "Book");
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["size"] = limit; // max 200
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        // spot
        //
        //     {      asks: [ ["0.02685268", "0.242571", "1"],
        //                    ["0.02685493", "0.164085", "1"],
        //                    ...
        //                    ["0.02779", "1.039", "1"],
        //                    ["0.027813", "0.0876", "1"]        ],
        //            bids: [ ["0.02684052", "10.371849", "1"],
        //                    ["0.02684051", "3.707", "4"],
        //                    ...
        //                    ["0.02634963", "0.132934", "1"],
        //                    ["0.02634962", "0.264838", "2"]    ],
        //       timestamp:   "2018-12-17T20:24:16.159Z"            }
        //
        // swap
        //
        //     {
        //         "asks":[
        //             ["916.21","94","0","1"]
        //         ],
        //         "bids":[
        //             ["916.1","15","0","1"]
        //         ],
        //         "time":"2021-04-16T02:04:48.282Z"
        //     }
        //
        object timestamp = this.parse8601(this.safeString2(response, "timestamp", "time"));
        return this.parseOrderBook(response, symbol, timestamp);
    }

    public override object parseTicker(object ticker, object market = null)
    {
        //
        //     {         best_ask: "0.02665472",
        //               best_bid: "0.02665221",
        //          instrument_id: "ETH-BTC",
        //             product_id: "ETH-BTC",
        //                   last: "0.02665472",
        //                    ask: "0.02665472", // missing in the docs
        //                    bid: "0.02665221", // not mentioned in the docs
        //               open_24h: "0.02645482",
        //               high_24h: "0.02714633",
        //                low_24h: "0.02614109",
        //        base_volume_24h: "572298.901923",
        //              timestamp: "2018-12-17T21:20:07.856Z",
        //       quote_volume_24h: "15094.86831261"            }
        //
        object timestamp = this.parse8601(this.safeString(ticker, "timestamp"));
        object marketId = this.safeString(ticker, "instrument_id");
        market = this.safeMarket(marketId, market, "-");
        object symbol = getValue(market, "symbol");
        object last = this.safeString(ticker, "last");
        object open = this.safeString(ticker, "open_24h");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", this.safeString(ticker, "high_24h") },
            { "low", this.safeString(ticker, "low_24h") },
            { "bid", this.safeString(ticker, "best_bid") },
            { "bidVolume", this.safeString(ticker, "best_bid_size") },
            { "ask", this.safeString(ticker, "best_ask") },
            { "askVolume", this.safeString(ticker, "best_ask_size") },
            { "vwap", null },
            { "open", open },
            { "close", last },
            { "last", last },
            { "previousClose", null },
            { "change", null },
            { "percentage", null },
            { "average", null },
            { "baseVolume", this.safeString(ticker, "base_volume_24h") },
            { "quoteVolume", this.safeString(ticker, "quote_volume_24h") },
            { "info", ticker },
        }, market);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object method = add(getValue(market, "type"), "GetInstrumentsInstrumentIdTicker");
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
        };
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        //     {         best_ask: "0.02665472",
        //               best_bid: "0.02665221",
        //          instrument_id: "ETH-BTC",
        //             product_id: "ETH-BTC",
        //                   last: "0.02665472",
        //                    ask: "0.02665472",
        //                    bid: "0.02665221",
        //               open_24h: "0.02645482",
        //               high_24h: "0.02714633",
        //                low_24h: "0.02614109",
        //        base_volume_24h: "572298.901923",
        //              timestamp: "2018-12-17T21:20:07.856Z",
        //       quote_volume_24h: "15094.86831261"            }
        //
        return this.parseTicker(response);
    }

    public async virtual Task<object> fetchTickersByType(object type, object symbols = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        symbols = this.marketSymbols(symbols);
        object method = add(type, "GetInstrumentsTicker");
        object response = await this.callAsync(method, parameters);
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object ticker = this.parseTicker(getValue(response, i));
            object symbol = getValue(ticker, "symbol");
            ((Dictionary<string, object>)result)[(string)symbol] = ticker;
        }
        return this.filterByArray(result, "symbol", symbols);
    }

    public async override Task<object> fetchTickers(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchTickers
        * @description fetches price tickers for multiple markets, statistical calculations with the information calculated over the past 24 hours each market
        * @param {[string]|undefined} symbols unified symbols of the markets to fetch the ticker for, all market tickers are returned if not assigned
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        symbols = this.marketSymbols(symbols);
        object first = this.safeString(symbols, 0);
        object market = null;
        if (isTrue(!isEqual(first, null)))
        {
            market = this.market(first);
        }
        object type = null;
                var typeparametersVariable = this.handleMarketTypeAndParams("fetchTickers", market, parameters);
        type = ((List<object>)typeparametersVariable)[0];
        parameters = ((List<object>)typeparametersVariable)[1];
        return await this.fetchTickersByType(type, symbols, this.omit(parameters, "type"));
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        // fetchTrades (public)
        //
        //     spot trades
        //
        //         {
        //             time: "2018-12-17T23:31:08.268Z",
        //             timestamp: "2018-12-17T23:31:08.268Z",
        //             trade_id: "409687906",
        //             price: "0.02677805",
        //             size: "0.923467",
        //             side: "sell"
        //         }
        //
        //     futures trades, swap trades
        //
        //         {
        //             trade_id: "1989230840021013",
        //             side: "buy",
        //             price: "92.42",
        //             qty: "184", // missing in swap markets
        //             size: "5", // missing in futures markets
        //             timestamp: "2018-12-17T23:26:04.613Z"
        //         }
        //
        // fetchOrderTrades (private)
        //
        //     spot trades
        //
        //         {
        //             "created_at":"2019-03-15T02:52:56.000Z",
        //             "exec_type":"T", // whether the order is taker or maker
        //             "fee":"0.00000082",
        //             "instrument_id":"BTC-USDT",
        //             "ledger_id":"3963052721",
        //             "liquidity":"T", // whether the order is taker or maker
        //             "order_id":"2482659399697408",
        //             "price":"3888.6",
        //             "product_id":"BTC-USDT",
        //             "side":"buy",
        //             "size":"0.00055306",
        //             "timestamp":"2019-03-15T02:52:56.000Z"
        //         },
        //
        //     futures trades, swap trades
        //
        //         {
        //             "trade_id":"197429674631450625",
        //             "instrument_id":"EOS-USD-SWAP",
        //             "order_id":"6a-7-54d663a28-0",
        //             "price":"3.633",
        //             "order_qty":"1.0000",
        //             "fee":"-0.000551",
        //             "created_at":"2019-03-21T04:41:58.0Z", // missing in swap trades
        //             "timestamp":"2019-03-25T05:56:31.287Z", // missing in futures trades
        //             "exec_type":"M", // whether the order is taker or maker
        //             "side":"short", // "buy" in futures trades
        //         }
        //
        object marketId = this.safeString(trade, "instrument_id");
        market = this.safeMarket(marketId, market, "-");
        object symbol = getValue(market, "symbol");
        object timestamp = this.parse8601(this.safeString2(trade, "timestamp", "created_at"));
        object priceString = this.safeString(trade, "price");
        object amountString = this.safeString2(trade, "size", "qty");
        amountString = this.safeString(trade, "order_qty", amountString);
        object takerOrMaker = this.safeString2(trade, "exec_type", "liquidity");
        if (isTrue(isEqual(takerOrMaker, "M")))
        {
            takerOrMaker = "maker";
        } else if (isTrue(isEqual(takerOrMaker, "T")))
        {
            takerOrMaker = "taker";
        }
        object side = this.safeString(trade, "side");
        object feeCostString = this.safeString(trade, "fee");
        object fee = null;
        if (isTrue(!isEqual(feeCostString, null)))
        {
            object feeCurrency = ((bool) isTrue((isEqual(side, "buy")))) ? getValue(market, "base") : getValue(market, "quote");
            fee = new Dictionary<string, object>() {
                { "cost", Precise.stringNeg(feeCostString) },
                { "currency", feeCurrency },
            };
        }
        object orderId = this.safeString(trade, "order_id");
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", symbol },
            { "id", this.safeString2(trade, "trade_id", "ledger_id") },
            { "order", orderId },
            { "type", null },
            { "takerOrMaker", takerOrMaker },
            { "side", side },
            { "price", priceString },
            { "amount", amountString },
            { "cost", null },
            { "fee", fee },
        }, market);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/en/latest/manual.html?#public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object method = add(getValue(market, "type"), "GetInstrumentsInstrumentIdTrades");
        if (isTrue(isTrue((isEqual(limit, null))) || isTrue((isGreaterThan(limit, 100)))))
        {
            limit = 100; // maximum = default = 100
        }
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
            { "limit", limit },
        };
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        // spot markets
        //
        //     [
        //         {
        //             time: "2018-12-17T23:31:08.268Z",
        //             timestamp: "2018-12-17T23:31:08.268Z",
        //             trade_id: "409687906",
        //             price: "0.02677805",
        //             size: "0.923467",
        //             side: "sell"
        //         }
        //     ]
        //
        // futures markets, swap markets
        //
        //     [
        //         {
        //             trade_id: "1989230840021013",
        //             side: "buy",
        //             price: "92.42",
        //             qty: "184", // missing in swap markets
        //             size: "5", // missing in futures markets
        //             timestamp: "2018-12-17T23:26:04.613Z"
        //         }
        //     ]
        //
        return this.parseTrades(response, market, since, limit);
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //
        // spot markets
        //
        //     {
        //         close: "0.02684545",
        //         high: "0.02685084",
        //         low: "0.02683312",
        //         open: "0.02683894",
        //         time: "2018-12-17T20:28:00.000Z",
        //         volume: "101.457222"
        //     }
        //
        // futures markets
        //
        //     [
        //         1545072720000,
        //         0.3159,
        //         0.3161,
        //         0.3144,
        //         0.3149,
        //         22886,
        //         725179.26172331,
        //     ]
        //
        if (isTrue((ohlcv.GetType().IsGenericType && ohlcv.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)))))
        {
            object numElements = getArrayLength(ohlcv);
            object volumeIndex = ((bool) isTrue((isGreaterThan(numElements, 6)))) ? 6 : 5;
            object timestamp = this.safeValue(ohlcv, 0);
            if (isTrue(((timestamp).GetType() == typeof(string))))
            {
                timestamp = this.parse8601(timestamp);
            }
            return new List<object>() {timestamp, this.safeNumber(ohlcv, 1), this.safeNumber(ohlcv, 2), this.safeNumber(ohlcv, 3), this.safeNumber(ohlcv, 4), this.safeNumber(ohlcv, volumeIndex)};
        } else
        {
            return new List<object> {this.parse8601(this.safeString(ohlcv, "time")), this.safeNumber(ohlcv, "open"), this.safeNumber(ohlcv, "high"), this.safeNumber(ohlcv, "low"), this.safeNumber(ohlcv, "close"), this.safeNumber(ohlcv, "volume")};
        }
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchOHLCV
        * @description fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents
        * @param {int|undefined} since timestamp in ms of the earliest candle to fetch
        * @param {int|undefined} limit the maximum amount of candles to fetch
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[[int]]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object duration = this.parseTimeframe(timeframe);
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
            { "granularity", this.safeString(this.timeframes, timeframe, timeframe) },
        };
        object options = this.safeValue(this.options, "fetchOHLCV", new Dictionary<string, object>() {});
        object defaultType = this.safeString(options, "type", "Candles"); // Candles or HistoryCandles
        object type = this.safeString(parameters, "type", defaultType);
        parameters = this.omit(parameters, "type");
        object method = add(add(getValue(market, "type"), "GetInstrumentsInstrumentId"), type);
        if (isTrue(isEqual(type, "Candles")))
        {
            if (isTrue(!isEqual(since, null)))
            {
                if (isTrue(!isEqual(limit, null)))
                {
                    ((Dictionary<string, object>)request)["end"] = this.iso8601(this.sum(since, multiply(multiply(limit, duration), 1000)));
                }
                ((Dictionary<string, object>)request)["start"] = this.iso8601(since);
            } else
            {
                if (isTrue(!isEqual(limit, null)))
                {
                    object now = this.milliseconds();
                    ((Dictionary<string, object>)request)["start"] = this.iso8601(subtract(now, multiply(multiply(limit, duration), 1000)));
                    ((Dictionary<string, object>)request)["end"] = this.iso8601(now);
                }
            }
        } else if (isTrue(isEqual(type, "HistoryCandles")))
        {
            if (isTrue(getValue(market, "option")))
            {
                throw new NotSupported ((string)add(add(add(add(add(this.id, " fetchOHLCV() does not have "), type), " for "), getValue(market, "type")), " markets")) ;
            }
            if (isTrue(!isEqual(since, null)))
            {
                if (isTrue(isEqual(limit, null)))
                {
                    limit = 300; // default
                }
                ((Dictionary<string, object>)request)["start"] = this.iso8601(this.sum(since, multiply(multiply(limit, duration), 1000)));
                ((Dictionary<string, object>)request)["end"] = this.iso8601(since);
            } else
            {
                if (isTrue(!isEqual(limit, null)))
                {
                    object now = this.milliseconds();
                    ((Dictionary<string, object>)request)["end"] = this.iso8601(subtract(now, multiply(multiply(limit, duration), 1000)));
                    ((Dictionary<string, object>)request)["start"] = this.iso8601(now);
                }
            }
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        // spot markets
        //
        //     [
        //         {
        //             close: "0.02683401",
        //             high: "0.02683401",
        //             low: "0.02683401",
        //             open: "0.02683401",
        //             time: "2018-12-17T23:47:00.000Z",
        //             volume: "0"
        //         },
        //         {
        //             close: "0.02684545",
        //             high: "0.02685084",
        //             low: "0.02683312",
        //             open: "0.02683894",
        //             time: "2018-12-17T20:28:00.000Z",
        //             volume: "101.457222"
        //         }
        //     ]
        //
        // futures
        //
        //     [
        //         [
        //             1545090660000,
        //             0.3171,
        //             0.3174,
        //             0.3171,
        //             0.3173,
        //             1648,
        //             51930.38579450868
        //         ],
        //         [
        //             1545072720000,
        //             0.3159,
        //             0.3161,
        //             0.3144,
        //             0.3149,
        //             22886,
        //             725179.26172331
        //         ]
        //     ]
        //
        return this.parseOHLCVs(response, market, timeframe, since, limit);
    }

    public virtual object parseAccountBalance(object response)
    {
        //
        // account
        //
        //     [
        //         {
        //             balance:  0,
        //             available:  0,
        //             currency: "BTC",
        //             hold:  0
        //         },
        //         {
        //             balance:  0,
        //             available:  0,
        //             currency: "ETH",
        //             hold:  0
        //         }
        //     ]
        //
        // spot
        //
        //     [
        //         {
        //             frozen: "0",
        //             hold: "0",
        //             id: "2149632",
        //             currency: "BTC",
        //             balance: "0.0000000497717339",
        //             available: "0.0000000497717339",
        //             holds: "0"
        //         },
        //         {
        //             frozen: "0",
        //             hold: "0",
        //             id: "2149632",
        //             currency: "ICN",
        //             balance: "0.00000000925",
        //             available: "0.00000000925",
        //             holds: "0"
        //         }
        //     ]
        //
        object result = new Dictionary<string, object>() {
            { "info", response },
            { "timestamp", null },
            { "datetime", null },
        };
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object balance = getValue(response, i);
            object currencyId = this.safeString(balance, "currency");
            object code = this.safeCurrencyCode(currencyId);
            object account = this.account();
            ((Dictionary<string, object>)account)["total"] = this.safeString(balance, "balance");
            ((Dictionary<string, object>)account)["used"] = this.safeString(balance, "hold");
            ((Dictionary<string, object>)account)["free"] = this.safeString(balance, "available");
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public virtual object parseFuturesBalance(object response)
    {
        //
        //     {
        //         "info":{
        //             "eos":{
        //                 "auto_margin":"0",
        //                 "contracts": [
        //                     {
        //                         "available_qty":"40.37069445",
        //                         "fixed_balance":"0",
        //                         "instrument_id":"EOS-USD-190329",
        //                         "margin_for_unfilled":"0",
        //                         "margin_frozen":"0",
        //                         "realized_pnl":"0",
        //                         "unrealized_pnl":"0"
        //                     },
        //                     {
        //                         "available_qty":"40.37069445",
        //                         "fixed_balance":"14.54895721",
        //                         "instrument_id":"EOS-USD-190628",
        //                         "margin_for_unfilled":"0",
        //                         "margin_frozen":"10.64042157",
        //                         "realized_pnl":"-3.90853564",
        //                         "unrealized_pnl":"-0.259"
        //                     },
        //                 ],
        //                 "equity":"50.75220665",
        //                 "margin_mode":"fixed",
        //                 "total_avail_balance":"40.37069445"
        //             },
        //         }
        //     }
        //
        // their root field name is "info", so our info will contain their info
        object result = new Dictionary<string, object>() {
            { "info", response },
            { "timestamp", null },
            { "datetime", null },
        };
        object info = this.safeValue(response, "info", new Dictionary<string, object>() {});
        object ids = new List<string>(((Dictionary<string,object>)info).Keys);
        for (object i = 0; isLessThan(i, getArrayLength(ids)); postFixIncrement(ref i))
        {
            object id = getValue(ids, i);
            object code = this.safeCurrencyCode(id);
            object balance = this.safeValue(info, id, new Dictionary<string, object>() {});
            object account = this.account();
            object totalAvailBalance = this.safeString(balance, "total_avail_balance");
            if (isTrue(isEqual(this.safeString(balance, "margin_mode"), "fixed")))
            {
                object contracts = this.safeValue(balance, "contracts", new List<object>() {});
                object free = totalAvailBalance;
                for (object j = 0; isLessThan(j, getArrayLength(contracts)); postFixIncrement(ref j))
                {
                    object contract = getValue(contracts, j);
                    object fixedBalance = this.safeString(contract, "fixed_balance");
                    object realizedPnl = this.safeString(contract, "realized_pnl");
                    object marginFrozen = this.safeString(contract, "margin_frozen");
                    object marginForUnfilled = this.safeString(contract, "margin_for_unfilled");
                    object margin = Precise.stringSub(Precise.stringSub(Precise.stringAdd(fixedBalance, realizedPnl), marginFrozen), marginForUnfilled);
                    free = Precise.stringAdd(free, margin);
                }
                ((Dictionary<string, object>)account)["free"] = free;
            } else
            {
                object realizedPnl = this.safeString(balance, "realized_pnl");
                object unrealizedPnl = this.safeString(balance, "unrealized_pnl");
                object marginFrozen = this.safeString(balance, "margin_frozen");
                object marginForUnfilled = this.safeString(balance, "margin_for_unfilled");
                object positive = Precise.stringAdd(Precise.stringAdd(totalAvailBalance, realizedPnl), unrealizedPnl);
                ((Dictionary<string, object>)account)["free"] = Precise.stringSub(Precise.stringSub(positive, marginFrozen), marginForUnfilled);
            }
            // it may be incorrect to use total, free and used for swap accounts
            ((Dictionary<string, object>)account)["total"] = this.safeString(balance, "equity");
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public virtual object parseSwapBalance(object response)
    {
        //
        //     {
        //         "info": [
        //             {
        //                 "equity":"3.0139",
        //                 "fixed_balance":"0.0000",
        //                 "instrument_id":"EOS-USD-SWAP",
        //                 "margin":"0.5523",
        //                 "margin_frozen":"0.0000",
        //                 "margin_mode":"crossed",
        //                 "margin_ratio":"1.0913",
        //                 "realized_pnl":"-0.0006",
        //                 "timestamp":"2019-03-25T03:46:10.336Z",
        //                 "total_avail_balance":"3.0000",
        //                 "unrealized_pnl":"0.0145"
        //             }
        //         ]
        //     }
        //
        // their root field name is "info", so our info will contain their info
        object result = new Dictionary<string, object>() {
            { "info", response },
        };
        object timestamp = null;
        object info = this.safeValue(response, "info", new List<object>() {});
        for (object i = 0; isLessThan(i, getArrayLength(info)); postFixIncrement(ref i))
        {
            object balance = getValue(info, i);
            object marketId = this.safeString(balance, "instrument_id");
            object symbol = this.safeSymbol(marketId);
            object balanceTimestamp = this.parse8601(this.safeString(balance, "timestamp"));
            timestamp = ((bool) isTrue((isEqual(timestamp, null)))) ? balanceTimestamp : mathMax(timestamp, balanceTimestamp);
            object account = this.account();
            // it may be incorrect to use total, free and used for swap accounts
            ((Dictionary<string, object>)account)["total"] = this.safeString(balance, "equity");
            ((Dictionary<string, object>)account)["free"] = this.safeString(balance, "total_avail_balance");
            ((Dictionary<string, object>)result)[(string)symbol] = account;
        }
        ((Dictionary<string, object>)result)["timestamp"] = timestamp;
        ((Dictionary<string, object>)result)["datetime"] = this.iso8601(timestamp);
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object defaultType = this.safeString2(this.options, "fetchBalance", "defaultType");
        object type = this.safeString(parameters, "type", defaultType);
        if (isTrue(isEqual(type, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchBalance() requires a type parameter (one of \'account\', \'spot\', \'futures\', \'swap\')")) ;
        }
        await this.loadMarkets();
        object suffix = ((bool) isTrue((isEqual(type, "account")))) ? "Wallet" : "Accounts";
        object method = add(add(type, "Get"), suffix);
        object query = this.omit(parameters, "type");
        object response = await this.callAsync(method, query);
        //
        // account
        //
        //     [
        //         {
        //             balance:  0,
        //             available:  0,
        //             currency: "BTC",
        //             hold:  0
        //         },
        //         {
        //             balance:  0,
        //             available:  0,
        //             currency: "ETH",
        //             hold:  0
        //         }
        //     ]
        //
        // spot
        //
        //     [
        //         {
        //             frozen: "0",
        //             hold: "0",
        //             id: "2149632",
        //             currency: "BTC",
        //             balance: "0.0000000497717339",
        //             available: "0.0000000497717339",
        //             holds: "0"
        //         },
        //         {
        //             frozen: "0",
        //             hold: "0",
        //             id: "2149632",
        //             currency: "ICN",
        //             balance: "0.00000000925",
        //             available: "0.00000000925",
        //             holds: "0"
        //         }
        //     ]
        //
        //
        // futures
        //
        //     {
        //         "info":{
        //             "eos":{
        //                 "auto_margin":"0",
        //                 "contracts": [
        //                     {
        //                         "available_qty":"40.37069445",
        //                         "fixed_balance":"0",
        //                         "instrument_id":"EOS-USD-190329",
        //                         "margin_for_unfilled":"0",
        //                         "margin_frozen":"0",
        //                         "realized_pnl":"0",
        //                         "unrealized_pnl":"0"
        //                     },
        //                     {
        //                         "available_qty":"40.37069445",
        //                         "fixed_balance":"14.54895721",
        //                         "instrument_id":"EOS-USD-190628",
        //                         "margin_for_unfilled":"0",
        //                         "margin_frozen":"10.64042157",
        //                         "realized_pnl":"-3.90853564",
        //                         "unrealized_pnl":"-0.259"
        //                     },
        //                 ],
        //                 "equity":"50.75220665",
        //                 "margin_mode":"fixed",
        //                 "total_avail_balance":"40.37069445"
        //             },
        //         }
        //     }
        //
        // swap
        //
        //     {
        //         "info": [
        //             {
        //                 "equity":"3.0139",
        //                 "fixed_balance":"0.0000",
        //                 "instrument_id":"EOS-USD-SWAP",
        //                 "margin":"0.5523",
        //                 "margin_frozen":"0.0000",
        //                 "margin_mode":"crossed",
        //                 "margin_ratio":"1.0913",
        //                 "realized_pnl":"-0.0006",
        //                 "timestamp":"2019-03-25T03:46:10.336Z",
        //                 "total_avail_balance":"3.0000",
        //                 "unrealized_pnl":"0.0145"
        //             }
        //         ]
        //     }
        //
        return this.parseBalanceByType(type, response);
    }

    public virtual object parseBalanceByType(object type, object response)
    {
        if (isTrue(isTrue((isEqual(type, "account"))) || isTrue((isEqual(type, "spot")))))
        {
            return this.parseAccountBalance(response);
        } else if (isTrue(isEqual(type, "futures")))
        {
            return this.parseFuturesBalance(response);
        } else if (isTrue(isEqual(type, "swap")))
        {
            return this.parseSwapBalance(response);
        }
        throw new NotSupported ((string)add(add(add(this.id, " fetchBalance does not support the \'"), type), "\' type (the type must be one of \'account\', \'spot\', \'futures\', \'swap\')")) ;
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
        };
        object clientOrderId = this.safeString2(parameters, "client_oid", "clientOrderId");
        if (isTrue(!isEqual(clientOrderId, null)))
        {
            ((Dictionary<string, object>)request)["client_oid"] = clientOrderId;
            parameters = this.omit(parameters, new List<object>() {"client_oid", "clientOrderId"});
        }
        object method = null;
        if (isTrue(isTrue(getValue(market, "futures")) || isTrue(getValue(market, "swap"))))
        {
            object size = ((bool) isTrue(getValue(market, "futures"))) ? this.numberToString(amount) : this.amountToPrecision(symbol, amount);
            request = this.extend(request, new Dictionary<string, object>() {
                { "type", type },
                { "size", size },
            });
            object orderType = this.safeString(parameters, "order_type");
            // order_type === '4' means a market order
            object isMarketOrder = isTrue((isEqual(type, "market"))) || isTrue((isEqual(orderType, "4")));
            if (isTrue(isMarketOrder))
            {
                ((Dictionary<string, object>)request)["order_type"] = "4";
            } else
            {
                ((Dictionary<string, object>)request)["price"] = this.priceToPrecision(symbol, price);
            }
            if (isTrue(getValue(market, "futures")))
            {
                ((Dictionary<string, object>)request)["leverage"] = "10"; // or '20'
            }
            method = add(getValue(market, "type"), "PostOrder");
        } else
        {
            request = this.extend(request, new Dictionary<string, object>() {
                { "side", side },
                { "type", type },
            });
            if (isTrue(isEqual(type, "limit")))
            {
                ((Dictionary<string, object>)request)["price"] = this.priceToPrecision(symbol, price);
                ((Dictionary<string, object>)request)["size"] = this.amountToPrecision(symbol, amount);
            } else if (isTrue(isEqual(type, "market")))
            {
                // for market buy it requires the amount of quote currency to spend
                if (isTrue(isEqual(side, "buy")))
                {
                    object notional = this.safeNumber(parameters, "notional");
                    object createMarketBuyOrderRequiresPrice = this.safeValue(this.options, "createMarketBuyOrderRequiresPrice", true);
                    if (isTrue(createMarketBuyOrderRequiresPrice))
                    {
                        if (isTrue(!isEqual(price, null)))
                        {
                            if (isTrue(isEqual(notional, null)))
                            {
                                notional = multiply(amount, price);
                            }
                        } else if (isTrue(isEqual(notional, null)))
                        {
                            throw new InvalidOrder ((string)add(this.id, " createOrder() requires the price argument with market buy orders to calculate total order cost (amount to spend), where cost = amount * price. Supply a price argument to createOrder() call if you want the cost to be calculated for you from price and amount, or, alternatively, add .options[\'createMarketBuyOrderRequiresPrice\'] = false and supply the total cost value in the \'amount\' argument or in the \'notional\' extra parameter (the exchange-specific behaviour)")) ;
                        }
                    } else
                    {
                        notional = ((bool) isTrue((isEqual(notional, null)))) ? amount : notional;
                    }
                    ((Dictionary<string, object>)request)["notional"] = this.costToPrecision(symbol, notional);
                } else
                {
                    ((Dictionary<string, object>)request)["size"] = this.amountToPrecision(symbol, amount);
                }
            }
            method = "spotPostOrders";
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        //     {
        //         "client_oid":"oktspot79",
        //         "error_code":"",
        //         "error_message":"",
        //         "order_id":"2510789768709120",
        //         "result":true
        //     }
        //
        object order = this.parseOrder(response, market);
        return this.extend(order, new Dictionary<string, object>() {
            { "type", type },
            { "side", side },
        });
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " cancelOrder() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object type = null;
        if (isTrue(isTrue(getValue(market, "futures")) || isTrue(getValue(market, "swap"))))
        {
            type = getValue(market, "type");
        } else
        {
            object defaultType = this.safeString2(this.options, "cancelOrder", "defaultType", getValue(market, "type"));
            type = this.safeString(parameters, "type", defaultType);
        }
        if (isTrue(isEqual(type, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " cancelOrder() requires a type parameter (one of \'spot\', \'futures\', \'swap\').")) ;
        }
        object method = add(type, "PostCancelOrder");
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
        };
        if (isTrue(isTrue(getValue(market, "futures")) || isTrue(getValue(market, "swap"))))
        {
            method = add(method, "InstrumentId");
        } else
        {
            method = add(method, "s");
        }
        object clientOrderId = this.safeString2(parameters, "client_oid", "clientOrderId");
        if (isTrue(!isEqual(clientOrderId, null)))
        {
            method = add(method, "ClientOid");
            ((Dictionary<string, object>)request)["client_oid"] = clientOrderId;
        } else
        {
            method = add(method, "OrderId");
            ((Dictionary<string, object>)request)["order_id"] = id;
        }
        object query = this.omit(parameters, new List<object>() {"type", "client_oid", "clientOrderId"});
        object response = await this.callAsync(method, this.extend(request, query));
        object result = ((bool) isTrue((((Dictionary<string,object>)response).ContainsKey(toStringOrNull("result"))))) ? response : this.safeValue(response, getValue(market, "id"), new Dictionary<string, object>() {});
        //
        // spot
        //
        //     {
        //         "btc-usdt": [
        //             {
        //                 "result":true,
        //                 "client_oid":"a123",
        //                 "order_id": "2510832677225473"
        //             }
        //         ]
        //     }
        //
        // futures, swap
        //
        //     {
        //         "result": true,
        //         "client_oid": "oktfuture10", // missing if requested by order_id
        //         "order_id": "2517535534836736",
        //         "instrument_id": "EOS-USD-190628"
        //     }
        //
        return this.parseOrder(result, market);
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "-2", "failed" },
            { "-1", "canceled" },
            { "0", "open" },
            { "1", "open" },
            { "2", "closed" },
            { "3", "open" },
            { "4", "canceled" },
        };
        return this.safeString(statuses, status, status);
    }

    public virtual object parseOrderSide(object side)
    {
        object sides = new Dictionary<string, object>() {
            { "1", "buy" },
            { "2", "sell" },
            { "3", "sell" },
            { "4", "buy" },
        };
        return this.safeString(sides, side, side);
    }

    public override object parseOrder(object order, object market = null)
    {
        //
        // createOrder
        //
        //     {
        //         "client_oid":"oktspot79",
        //         "error_code":"",
        //         "error_message":"",
        //         "order_id":"2510789768709120",
        //         "result":true
        //     }
        //
        // cancelOrder
        //
        //     {
        //         "result": true,
        //         "client_oid": "oktfuture10", // missing if requested by order_id
        //         "order_id": "2517535534836736",
        //         // instrument_id is missing for spot/margin orders
        //         // available in futures and swap orders only
        //         "instrument_id": "EOS-USD-190628",
        //     }
        //
        // fetchOrder, fetchOrdersByState, fetchOpenOrders, fetchClosedOrders
        //
        //     // spot orders
        //
        //     {
        //         "client_oid":"oktspot76",
        //         "created_at":"2019-03-18T07:26:49.000Z",
        //         "filled_notional":"3.9734",
        //         "filled_size":"0.001", // filled_qty in futures and swap orders
        //         "funds":"", // this is most likely the same as notional
        //         "instrument_id":"BTC-USDT",
        //         "notional":"",
        //         "order_id":"2500723297813504",
        //         "order_type":"0",
        //         "price":"4013",
        //         "product_id":"BTC-USDT", // missing in futures and swap orders
        //         "side":"buy",
        //         "size":"0.001",
        //         "status":"filled",
        //         "state": "2",
        //         "timestamp":"2019-03-18T07:26:49.000Z",
        //         "type":"limit"
        //     }
        //
        //     // futures and swap orders
        //
        //     {
        //         "instrument_id":"EOS-USD-190628",
        //         "size":"10",
        //         "timestamp":"2019-03-20T10:04:55.000Z",
        //         "filled_qty":"10", // filled_size in spot orders
        //         "fee":"-0.00841043",
        //         "order_id":"2512669605501952",
        //         "price":"3.668",
        //         "price_avg":"3.567", // missing in spot orders
        //         "status":"2",
        //         "state": "2",
        //         "type":"4",
        //         "contract_val":"10",
        //         "leverage":"10", // missing in swap, spot orders
        //         "client_oid":"",
        //         "pnl":"1.09510794", // missing in swap, spot orders
        //         "order_type":"0"
        //     }
        //
        object id = this.safeString(order, "order_id");
        object timestamp = this.parse8601(this.safeString(order, "timestamp"));
        object side = this.safeString(order, "side");
        object type = this.safeString(order, "type");
        if (isTrue(isTrue((!isEqual(side, "buy"))) && isTrue((!isEqual(side, "sell")))))
        {
            side = this.parseOrderSide(type);
        }
        object marketId = this.safeString(order, "instrument_id");
        market = this.safeMarket(marketId, market);
        object amount = this.safeString(order, "size");
        object filled = this.safeString2(order, "filled_size", "filled_qty");
        object remaining = null;
        if (isTrue(!isEqual(amount, null)))
        {
            if (isTrue(!isEqual(filled, null)))
            {
                amount = Precise.stringMax(amount, filled);
                remaining = Precise.stringMax("0", Precise.stringSub(amount, filled));
            }
        }
        if (isTrue(isEqual(type, "market")))
        {
            remaining = "0";
        }
        object cost = this.safeString2(order, "filled_notional", "funds");
        object price = this.safeString(order, "price");
        object average = this.safeString(order, "price_avg");
        if (isTrue(isEqual(cost, null)))
        {
            if (isTrue(isTrue(!isEqual(filled, null)) && isTrue(!isEqual(average, null))))
            {
                cost = Precise.stringMul(average, filled);
            }
        } else
        {
            if (isTrue(isTrue(isTrue((isEqual(average, null))) && isTrue((!isEqual(filled, null)))) && isTrue(Precise.stringGt(filled, "0"))))
            {
                average = Precise.stringDiv(cost, filled);
            }
        }
        object status = this.parseOrderStatus(this.safeString(order, "state"));
        object feeCost = this.safeNumber(order, "fee");
        object fee = null;
        if (isTrue(!isEqual(feeCost, null)))
        {
            object feeCurrency = null;
            fee = new Dictionary<string, object>() {
                { "cost", feeCost },
                { "currency", feeCurrency },
            };
        }
        object clientOrderId = this.safeString(order, "client_oid");
        if (isTrue(isTrue((!isEqual(clientOrderId, null))) && isTrue((isLessThan(((string)clientOrderId).Length, 1)))))
        {
            clientOrderId = null; // fix empty clientOrderId string
        }
        object stopPrice = this.safeNumber(order, "trigger_price");
        return this.safeOrder(new Dictionary<string, object>() {
            { "info", order },
            { "id", id },
            { "clientOrderId", clientOrderId },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "lastTradeTimestamp", null },
            { "symbol", getValue(market, "symbol") },
            { "type", type },
            { "timeInForce", null },
            { "postOnly", null },
            { "side", side },
            { "price", price },
            { "stopPrice", stopPrice },
            { "triggerPrice", stopPrice },
            { "average", average },
            { "cost", cost },
            { "amount", amount },
            { "filled", filled },
            { "remaining", remaining },
            { "status", status },
            { "fee", fee },
            { "trades", null },
        }, market);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrder() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object defaultType = this.safeString2(this.options, "fetchOrder", "defaultType", getValue(market, "type"));
        object type = this.safeString(parameters, "type", defaultType);
        if (isTrue(isEqual(type, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrder() requires a type parameter (one of \'spot\', \'futures\', \'swap\').")) ;
        }
        object instrumentId = ((bool) isTrue((isTrue(getValue(market, "futures")) || isTrue(getValue(market, "swap"))))) ? "InstrumentId" : "";
        object method = add(add(type, "GetOrders"), instrumentId);
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
        };
        object clientOid = this.safeString(parameters, "client_oid");
        if (isTrue(!isEqual(clientOid, null)))
        {
            method = add(method, "ClientOid");
            ((Dictionary<string, object>)request)["client_oid"] = clientOid;
        } else
        {
            method = add(method, "OrderId");
            ((Dictionary<string, object>)request)["order_id"] = id;
        }
        object query = this.omit(parameters, "type");
        object response = await this.callAsync(method, this.extend(request, query));
        //
        // spot
        //
        //     {
        //         "client_oid":"oktspot70",
        //         "created_at":"2019-03-15T02:52:56.000Z",
        //         "filled_notional":"3.8886",
        //         "filled_size":"0.001",
        //         "funds":"",
        //         "instrument_id":"BTC-USDT",
        //         "notional":"",
        //         "order_id":"2482659399697408",
        //         "order_type":"0",
        //         "price":"3927.3",
        //         "product_id":"BTC-USDT",
        //         "side":"buy",
        //         "size":"0.001",
        //         "status":"filled",
        //         "state": "2",
        //         "timestamp":"2019-03-15T02:52:56.000Z",
        //         "type":"limit"
        //     }
        //
        // futures, swap
        //
        //     {
        //         "instrument_id":"EOS-USD-190628",
        //         "size":"10",
        //         "timestamp":"2019-03-20T02:46:38.000Z",
        //         "filled_qty":"10",
        //         "fee":"-0.0080819",
        //         "order_id":"2510946213248000",
        //         "price":"3.712",
        //         "price_avg":"3.712",
        //         "status":"2",
        //         "state": "2",
        //         "type":"2",
        //         "contract_val":"10",
        //         "leverage":"10",
        //         "client_oid":"", // missing in swap orders
        //         "pnl":"0", // missing in swap orders
        //         "order_type":"0"
        //     }
        //
        return this.parseOrder(response);
    }

    public async virtual Task<object> fetchOrdersByState(object state, object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrdersByState() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object type = null;
        if (isTrue(isTrue(getValue(market, "futures")) || isTrue(getValue(market, "swap"))))
        {
            type = getValue(market, "type");
        } else
        {
            object defaultType = this.safeString2(this.options, "fetchOrder", "defaultType", getValue(market, "type"));
            type = this.safeString(parameters, "type", defaultType);
        }
        if (isTrue(isEqual(type, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrdersByState() requires a type parameter (one of \'spot\', \'futures\', \'swap\').")) ;
        }
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
            { "state", state },
        };
        object method = add(type, "GetOrders");
        if (isTrue(isTrue(getValue(market, "futures")) || isTrue(getValue(market, "swap"))))
        {
            method = add(method, "InstrumentId");
        }
        object query = this.omit(parameters, "type");
        object response = await this.callAsync(method, this.extend(request, query));
        //
        // spot
        //
        //     [
        //         // in fact, this documented API response does not correspond
        //         // to their actual API response for spot markets
        //         // OKEX v3 API returns a plain array of orders (see below)
        //         [
        //             {
        //                 "client_oid":"oktspot76",
        //                 "created_at":"2019-03-18T07:26:49.000Z",
        //                 "filled_notional":"3.9734",
        //                 "filled_size":"0.001",
        //                 "funds":"",
        //                 "instrument_id":"BTC-USDT",
        //                 "notional":"",
        //                 "order_id":"2500723297813504",
        //                 "order_type":"0",
        //                 "price":"4013",
        //                 "product_id":"BTC-USDT",
        //                 "side":"buy",
        //                 "size":"0.001",
        //                 "status":"filled",
        //                 "state": "2",
        //                 "timestamp":"2019-03-18T07:26:49.000Z",
        //                 "type":"limit"
        //             },
        //         ],
        //         {
        //             "before":"2500723297813504",
        //             "after":"2500650881647616"
        //         }
        //     ]
        //
        // futures, swap
        //
        //     {
        //         "result":true,  // missing in swap orders
        //         "order_info": [
        //             {
        //                 "instrument_id":"EOS-USD-190628",
        //                 "size":"10",
        //                 "timestamp":"2019-03-20T10:04:55.000Z",
        //                 "filled_qty":"10",
        //                 "fee":"-0.00841043",
        //                 "order_id":"2512669605501952",
        //                 "price":"3.668",
        //                 "price_avg":"3.567",
        //                 "status":"2",
        //                 "state": "2",
        //                 "type":"4",
        //                 "contract_val":"10",
        //                 "leverage":"10", // missing in swap orders
        //                 "client_oid":"",
        //                 "pnl":"1.09510794", // missing in swap orders
        //                 "order_type":"0"
        //             },
        //         ]
        //     }
        //
        object orders = null;
        if (isTrue(isTrue(getValue(market, "swap")) || isTrue(getValue(market, "futures"))))
        {
            orders = this.safeValue(response, "order_info", new List<object>() {});
        } else
        {
            orders = response;
            object responseLength = getArrayLength(response);
            if (isTrue(isLessThan(responseLength, 1)))
            {
                return new List<object>() {};
            }
            // in fact, this documented API response does not correspond
            // to their actual API response for spot markets
            // OKEX v3 API returns a plain array of orders
            if (isTrue(isGreaterThan(responseLength, 1)))
            {
                object before = this.safeValue(getValue(response, 1), "before");
                if (isTrue(!isEqual(before, null)))
                {
                    orders = getValue(response, 0);
                }
            }
        }
        return this.parseOrders(orders, market, since, limit);
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        // '-2': failed,
        // '-1': cancelled,
        //  '0': open ,
        //  '1': partially filled,
        //  '2': fully filled,
        //  '3': submitting,
        //  '4': cancelling,
        //  '6': incomplete（open+partially filled),
        //  '7': complete（cancelled+fully filled),
        parameters ??= new Dictionary<string, object>();
        return await this.fetchOrdersByState("6", symbol, since, limit, parameters);
    }

    public async override Task<object> fetchClosedOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchClosedOrders
        * @description fetches information on multiple closed orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        // '-2': failed,
        // '-1': cancelled,
        //  '0': open ,
        //  '1': partially filled,
        //  '2': fully filled,
        //  '3': submitting,
        //  '4': cancelling,
        //  '6': incomplete（open+partially filled),
        //  '7': complete（cancelled+fully filled),
        parameters ??= new Dictionary<string, object>();
        return await this.fetchOrdersByState("7", symbol, since, limit, parameters);
    }

    public override object parseDepositAddress(object depositAddress, object currency = null)
    {
        //
        //     {
        //         address: '0x696abb81974a8793352cbd33aadcf78eda3cfdfa',
        //         currency: 'eth'
        //         tag: 'abcde12345', // will be missing if the token does not require a deposit tag
        //         payment_id: 'abcde12345', // will not be returned if the token does not require a payment_id
        //         // can_deposit: 1, // 0 or 1, documented but missing
        //         // can_withdraw: 1, // 0 or 1, documented but missing
        //     }
        //
        object address = this.safeString(depositAddress, "address");
        object tag = this.safeString2(depositAddress, "tag", "payment_id");
        tag = this.safeString2(depositAddress, "memo", "Memo", tag);
        object currencyId = this.safeString(depositAddress, "currency");
        object code = this.safeCurrencyCode(currencyId);
        this.checkAddress(address);
        return new Dictionary<string, object>() {
            { "currency", code },
            { "address", address },
            { "tag", tag },
            { "info", depositAddress },
        };
    }

    public async override Task<object> fetchDepositAddress(object code, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchDepositAddress
        * @description fetch the deposit address for a currency associated with this account
        * @param {string} code unified currency code
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object parts = ((string)code).Split((string)"-").ToList<object>();
        object currency = this.currency(getValue(parts, 0));
        object request = new Dictionary<string, object>() {
            { "currency", getValue(currency, "id") },
        };
        object response = await this.accountGetDepositAddress(this.extend(request, parameters));
        //
        //     [
        //         {
        //             address: '0x696abb81974a8793352cbd33aadcf78eda3cfdfa',
        //             currency: 'eth'
        //         }
        //     ]
        //
        object addressesByCode = this.parseDepositAddresses(response, new List<object>() {getValue(currency, "code")});
        object address = this.safeValue(addressesByCode, code);
        if (isTrue(isEqual(address, null)))
        {
            throw new InvalidAddress ((string)add(this.id, " fetchDepositAddress() cannot return nonexistent addresses, you should create withdrawal addresses with the exchange website first")) ;
        }
        return address;
    }

    public async override Task<object> transfer(object code, object amount, object fromAccount, object toAccount, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#transfer
        * @description transfer currency internally between wallets on the same account
        * @param {string} code unified currency code
        * @param {float} amount amount to transfer
        * @param {string} fromAccount account to transfer from
        * @param {string} toAccount account to transfer to
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} a [transfer structure]{@link https://docs.ccxt.com/#/?id=transfer-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = this.currency(code);
        object accountsByType = this.safeValue(this.options, "accountsByType", new Dictionary<string, object>() {});
        object fromId = this.safeString(accountsByType, fromAccount, fromAccount);
        object toId = this.safeString(accountsByType, toAccount, toAccount);
        object request = new Dictionary<string, object>() {
            { "amount", this.currencyToPrecision(code, amount) },
            { "currency", getValue(currency, "id") },
            { "from", fromId },
            { "to", toId },
            { "type", "0" },
        };
        if (isTrue(isEqual(fromId, "main")))
        {
            ((Dictionary<string, object>)request)["type"] = "1";
            ((Dictionary<string, object>)request)["sub_account"] = toId;
            ((Dictionary<string, object>)request)["to"] = "0";
        } else if (isTrue(isEqual(toId, "main")))
        {
            ((Dictionary<string, object>)request)["type"] = "2";
            ((Dictionary<string, object>)request)["sub_account"] = fromId;
            ((Dictionary<string, object>)request)["from"] = "0";
            ((Dictionary<string, object>)request)["to"] = "6";
        }
        object response = await this.accountPostTransfer(this.extend(request, parameters));
        //
        //      {
        //          "transfer_id": "754147",
        //          "currency": "ETC",
        //          "from": "6",
        //          "amount": "0.1",
        //          "to": "1",
        //          "result": true
        //      }
        //
        return this.parseTransfer(response, currency);
    }

    public override object parseTransfer(object transfer, object currency = null)
    {
        //
        //      {
        //          "transfer_id": "754147",
        //          "currency": "ETC",
        //          "from": "6",
        //          "amount": "0.1",
        //          "to": "1",
        //          "result": true
        //      }
        //
        object accountsById = this.safeValue(this.options, "accountsById", new Dictionary<string, object>() {});
        return new Dictionary<string, object>() {
            { "info", transfer },
            { "id", this.safeString(transfer, "transfer_id") },
            { "timestamp", null },
            { "datetime", null },
            { "currency", this.safeCurrencyCode(this.safeString(transfer, "currency"), currency) },
            { "amount", this.safeNumber(transfer, "amount") },
            { "fromAccount", this.safeString(accountsById, this.safeString(transfer, "from")) },
            { "toAccount", this.safeString(accountsById, this.safeString(transfer, "to")) },
            { "status", this.parseTransferStatus(this.safeString(transfer, "result")) },
        };
    }

    public virtual object parseTransferStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "true", "ok" },
        };
        return this.safeString(statuses, status, "failed");
    }

    public async override Task<object> withdraw(object code, object amount, object address, object tag = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#withdraw
        * @description make a withdrawal
        * @param {string} code unified currency code
        * @param {float} amount the amount to withdraw
        * @param {string} address the address to withdraw to
        * @param {string|undefined} tag
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
                var tagparametersVariable = this.handleWithdrawTagAndParams(tag, parameters);
        tag = ((List<object>)tagparametersVariable)[0];
        parameters = ((List<object>)tagparametersVariable)[1];
        this.checkAddress(address);
        await this.loadMarkets();
        object currency = this.currency(code);
        if (isTrue(tag))
        {
            address = add(add(address, ":"), tag);
        }
        object fee = this.safeString(parameters, "fee");
        if (isTrue(isEqual(fee, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " withdraw() requires a \'fee\' string parameter, network transaction fee must be ≥ 0. Withdrawals to OKCoin or OKEx are fee-free, please set \'0\'. Withdrawing to external digital asset address requires network transaction fee.")) ;
        }
        object request = new Dictionary<string, object>() {
            { "currency", getValue(currency, "id") },
            { "to_address", address },
            { "destination", "4" },
            { "amount", this.numberToString(amount) },
            { "fee", fee },
        };
        if (isTrue(((Dictionary<string,object>)parameters).ContainsKey(toStringOrNull("password"))))
        {
            ((Dictionary<string, object>)request)["trade_pwd"] = getValue(parameters, "password");
        } else if (isTrue(((Dictionary<string,object>)parameters).ContainsKey(toStringOrNull("trade_pwd"))))
        {
            ((Dictionary<string, object>)request)["trade_pwd"] = getValue(parameters, "trade_pwd");
        } else if (isTrue(this.password))
        {
            ((Dictionary<string, object>)request)["trade_pwd"] = this.password;
        }
        object query = this.omit(parameters, new List<object>() {"fee", "password", "trade_pwd"});
        if (!isTrue((((Dictionary<string,object>)request).ContainsKey(toStringOrNull("trade_pwd")))))
        {
            throw new ExchangeError ((string)add(this.id, " withdraw() requires this.password set on the exchange instance or a password / trade_pwd parameter")) ;
        }
        object response = await this.accountPostWithdrawal(this.extend(request, query));
        //
        //     {
        //         "amount":"0.1",
        //         "withdrawal_id":"67485",
        //         "currency":"btc",
        //         "result":true
        //     }
        //
        return this.parseTransaction(response, currency);
    }

    public async override Task<object> fetchDeposits(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchDeposits
        * @description fetch all deposits made to an account
        * @param {string|undefined} code unified currency code
        * @param {int|undefined} since the earliest time in ms to fetch deposits for
        * @param {int|undefined} limit the maximum number of deposits structures to retrieve
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[object]} a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object method = "accountGetDepositHistory";
        object currency = null;
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["currency"] = getValue(currency, "id");
            method = add(method, "Currency");
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        return this.parseTransactions(response, currency, since, limit, parameters);
    }

    public async override Task<object> fetchWithdrawals(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchWithdrawals
        * @description fetch all withdrawals made from an account
        * @param {string|undefined} code unified currency code
        * @param {int|undefined} since the earliest time in ms to fetch withdrawals for
        * @param {int|undefined} limit the maximum number of withdrawals structures to retrieve
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[object]} a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object method = "accountGetWithdrawalHistory";
        object currency = null;
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["currency"] = getValue(currency, "id");
            method = add(method, "Currency");
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        return this.parseTransactions(response, currency, since, limit, parameters);
    }

    public virtual object parseTransactionStatus(object status)
    {
        //
        // deposit statuses
        //
        //     {
        //         '0': 'waiting for confirmation',
        //         '1': 'confirmation account',
        //         '2': 'recharge success'
        //     }
        //
        // withdrawal statues
        //
        //     {
        //        '-3': 'pending cancel',
        //        '-2': 'cancelled',
        //        '-1': 'failed',
        //         '0': 'pending',
        //         '1': 'sending',
        //         '2': 'sent',
        //         '3': 'email confirmation',
        //         '4': 'manual confirmation',
        //         '5': 'awaiting identity confirmation'
        //     }
        //
        object statuses = new Dictionary<string, object>() {
            { "-3", "pending" },
            { "-2", "canceled" },
            { "-1", "failed" },
            { "0", "pending" },
            { "1", "pending" },
            { "2", "ok" },
            { "3", "pending" },
            { "4", "pending" },
            { "5", "pending" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object parseTransaction(object transaction, object currency = null)
    {
        //
        // withdraw
        //
        //     {
        //         "amount":"0.1",
        //         "withdrawal_id":"67485",
        //         "currency":"btc",
        //         "result":true
        //     }
        //
        // fetchWithdrawals
        //
        //     {
        //         amount: "4.72100000",
        //         withdrawal_id: "1729116",
        //         fee: "0.01000000eth",
        //         txid: "0xf653125bbf090bcfe4b5e8e7b8f586a9d87aa7de94598702758c0802b…",
        //         currency: "ETH",
        //         from: "7147338839",
        //         to: "0x26a3CB49578F07000575405a57888681249c35Fd",
        //         timestamp: "2018-08-17T07:03:42.000Z",
        //         status: "2"
        //     }
        //
        // fetchDeposits
        //
        //     {
        //         "amount": "4.19511659",
        //         "txid": "14c9a8c925647cdb7e5b2937ea9aefe2b29b2c273150ad3f44b3b8a4635ed437",
        //         "currency": "XMR",
        //         "from": "",
        //         "to": "48PjH3ksv1fiXniKvKvyH5UtFs5WhfS2Vf7U3TwzdRJtCc7HJWvCQe56dRahyhQyTAViXZ8Nzk4gQg6o4BJBMUoxNy8y8g7",
        //         "tag": "1234567",
        //         "deposit_id": 11571659, <-- we can use this
        //         "timestamp": "2019-10-01T14:54:19.000Z",
        //         "status": "2"
        //     }
        //
        object type = null;
        object id = null;
        object address = null;
        object withdrawalId = this.safeString(transaction, "withdrawal_id");
        object addressFrom = this.safeString(transaction, "from");
        object addressTo = this.safeString(transaction, "to");
        object tagTo = this.safeString(transaction, "tag");
        if (isTrue(!isEqual(withdrawalId, null)))
        {
            type = "withdrawal";
            id = withdrawalId;
            address = addressTo;
        } else
        {
            // the payment_id will appear on new deposits but appears to be removed from the response after 2 months
            id = this.safeString2(transaction, "payment_id", "deposit_id");
            type = "deposit";
            address = addressTo;
        }
        object currencyId = this.safeString(transaction, "currency");
        object code = this.safeCurrencyCode(currencyId);
        object amount = this.safeNumber(transaction, "amount");
        object status = this.parseTransactionStatus(this.safeString(transaction, "status"));
        object txid = this.safeString(transaction, "txid");
        object timestamp = this.parse8601(this.safeString(transaction, "timestamp"));
        object feeCost = null;
        if (isTrue(isEqual(type, "deposit")))
        {
            feeCost = 0;
        } else
        {
            if (isTrue(!isEqual(currencyId, null)))
            {
                object feeWithCurrencyId = this.safeString(transaction, "fee");
                if (isTrue(!isEqual(feeWithCurrencyId, null)))
                {
                    // https://github.com/ccxt/ccxt/pull/5748
                    object lowercaseCurrencyId = ((string)currencyId).ToLower();
                    object feeWithoutCurrencyId = ((string)feeWithCurrencyId).Replace((string)lowercaseCurrencyId, (string)"");
                    feeCost = parseFloat(feeWithoutCurrencyId);
                }
            }
        }
        // todo parse tags
        return new Dictionary<string, object>() {
            { "info", transaction },
            { "id", id },
            { "currency", code },
            { "amount", amount },
            { "network", null },
            { "addressFrom", addressFrom },
            { "addressTo", addressTo },
            { "address", address },
            { "tagFrom", null },
            { "tagTo", tagTo },
            { "tag", tagTo },
            { "status", status },
            { "type", type },
            { "updated", null },
            { "txid", txid },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "fee", new Dictionary<string, object>() {
                { "currency", code },
                { "cost", feeCost },
            } },
        };
    }

    public virtual object parseMyTrade(object pair, object market = null)
    {
        // check that trading symbols match in both entries
        object userTrade = this.safeValue(pair, 1);
        object otherTrade = this.safeValue(pair, 0);
        object firstMarketId = this.safeString(otherTrade, "instrument_id");
        object secondMarketId = this.safeString(userTrade, "instrument_id");
        if (isTrue(!isEqual(firstMarketId, secondMarketId)))
        {
            throw new NotSupported ((string)add(this.id, " parseMyTrade() received unrecognized response format, differing instrument_ids in one fill, the exchange API might have changed, paste your verbose output: https://github.com/ccxt/ccxt/wiki/FAQ#what-is-required-to-get-help")) ;
        }
        object marketId = firstMarketId;
        market = this.safeMarket(marketId, market);
        object symbol = getValue(market, "symbol");
        object quoteId = getValue(market, "quoteId");
        object side = null;
        object amountString = null;
        object costString = null;
        object receivedCurrencyId = this.safeString(userTrade, "currency");
        object feeCurrencyId = null;
        if (isTrue(isEqual(receivedCurrencyId, quoteId)))
        {
            side = this.safeString(otherTrade, "side");
            amountString = this.safeString(otherTrade, "size");
            costString = this.safeString(userTrade, "size");
            feeCurrencyId = this.safeString(otherTrade, "currency");
        } else
        {
            side = this.safeString(userTrade, "side");
            amountString = this.safeString(userTrade, "size");
            costString = this.safeString(otherTrade, "size");
            feeCurrencyId = this.safeString(userTrade, "currency");
        }
        object id = this.safeString(userTrade, "trade_id");
        object priceString = this.safeString(userTrade, "price");
        object feeCostFirstString = this.safeString(otherTrade, "fee");
        object feeCostSecondString = this.safeString(userTrade, "fee");
        object feeCurrencyCodeFirst = this.safeCurrencyCode(this.safeString(otherTrade, "currency"));
        object feeCurrencyCodeSecond = this.safeCurrencyCode(this.safeString(userTrade, "currency"));
        object fee = null;
        object fees = null;
        // fee is either a positive number (invitation rebate)
        // or a negative number (transaction fee deduction)
        // therefore we need to invert the fee
        // more about it https://github.com/ccxt/ccxt/issues/5909
        if (isTrue(isTrue((!isEqual(feeCostFirstString, null))) && !isTrue(Precise.stringEquals(feeCostFirstString, "0"))))
        {
            if (isTrue(isTrue((!isEqual(feeCostSecondString, null))) && !isTrue(Precise.stringEquals(feeCostSecondString, "0"))))
            {
                fees = new List<object>() {new Dictionary<string, object>() {
    { "cost", Precise.stringNeg(feeCostFirstString) },
    { "currency", feeCurrencyCodeFirst },
}, new Dictionary<string, object>() {
    { "cost", Precise.stringNeg(feeCostSecondString) },
    { "currency", feeCurrencyCodeSecond },
}};
            } else
            {
                fee = new Dictionary<string, object>() {
                    { "cost", Precise.stringNeg(feeCostFirstString) },
                    { "currency", feeCurrencyCodeFirst },
                };
            }
        } else if (isTrue(isTrue((!isEqual(feeCostSecondString, null))) && !isTrue(Precise.stringEquals(feeCostSecondString, "0"))))
        {
            fee = new Dictionary<string, object>() {
                { "cost", Precise.stringNeg(feeCostSecondString) },
                { "currency", feeCurrencyCodeSecond },
            };
        } else
        {
            fee = new Dictionary<string, object>() {
                { "cost", "0" },
                { "currency", this.safeCurrencyCode(feeCurrencyId) },
            };
        }
        //
        // simplified structures to show the underlying semantics
        //
        //     // market/limit sell
        //
        //     {
        //         "currency":"USDT",
        //         "fee":"-0.04647925", // ←--- fee in received quote currency
        //         "price":"129.13", // ←------ price
        //         "size":"30.98616393", // ←-- cost
        //     },
        //     {
        //         "currency":"ETH",
        //         "fee":"0",
        //         "price":"129.13",
        //         "size":"0.23996099", // ←--- amount
        //     },
        //
        //     // market/limit buy
        //
        //     {
        //         "currency":"ETH",
        //         "fee":"-0.00036049", // ←--- fee in received base currency
        //         "price":"129.16", // ←------ price
        //         "size":"0.240322", // ←----- amount
        //     },
        //     {
        //         "currency":"USDT",
        //         "fee":"0",
        //         "price":"129.16",
        //         "size":"31.03998952", // ←-- cost
        //     }
        //
        object timestamp = this.parse8601(this.safeString2(userTrade, "timestamp", "created_at"));
        object takerOrMaker = this.safeString2(userTrade, "exec_type", "liquidity");
        if (isTrue(isEqual(takerOrMaker, "M")))
        {
            takerOrMaker = "maker";
        } else if (isTrue(isEqual(takerOrMaker, "T")))
        {
            takerOrMaker = "taker";
        }
        object orderId = this.safeString(userTrade, "order_id");
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", pair },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", symbol },
            { "id", id },
            { "order", orderId },
            { "type", null },
            { "takerOrMaker", takerOrMaker },
            { "side", side },
            { "price", priceString },
            { "amount", amountString },
            { "cost", costString },
            { "fee", fee },
            { "fees", fees },
        }, market);
    }

    public virtual object parseMyTrades(object trades, object market = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        object grouped = this.groupBy(trades, "trade_id");
        object tradeIds = new List<string>(((Dictionary<string,object>)grouped).Keys);
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(tradeIds)); postFixIncrement(ref i))
        {
            object tradeId = getValue(tradeIds, i);
            object pair = getValue(grouped, tradeId);
            // make sure it has exactly 2 trades, no more, no less
            object numTradesInPair = getArrayLength(pair);
            if (isTrue(isEqual(numTradesInPair, 2)))
            {
                object trade = this.parseMyTrade(pair);
                ((List<object>)result).Add(trade);
            }
        }
        market = this.safeMarket(null, market);
        return this.filterBySymbolSinceLimit(result, getValue(market, "symbol"), since, limit);
    }

    public async override Task<object> fetchMyTrades(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchMyTrades
        * @description fetch all trades made by the user
        * @param {string} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch trades for
        * @param {int|undefined} limit the maximum number of trades structures to retrieve
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}
        */
        // okex actually returns ledger entries instead of fills here, so each fill in the order
        // is represented by two trades with opposite buy/sell sides, not one :\
        // this aspect renders the 'fills' endpoint unusable for fetchOrderTrades
        // until either OKEX fixes the API or we workaround this on our side somehow
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchMyTrades() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        if (isTrue(isTrue((!isEqual(limit, null))) && isTrue((isGreaterThan(limit, 100)))))
        {
            limit = 100;
        }
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
        };
        object defaultType = this.safeString2(this.options, "fetchMyTrades", "defaultType");
        object type = this.safeString(parameters, "type", defaultType);
        object query = this.omit(parameters, "type");
        object method = add(type, "GetFills");
        object response = await this.callAsync(method, this.extend(request, query));
        //
        //     [
        //         // sell
        //         {
        //             "created_at":"2020-03-29T11:55:25.000Z",
        //             "currency":"USDT",
        //             "exec_type":"T",
        //             "fee":"-0.04647925",
        //             "instrument_id":"ETH-USDT",
        //             "ledger_id":"10562924353",
        //             "liquidity":"T",
        //             "order_id":"4636470489136128",
        //             "price":"129.13",
        //             "product_id":"ETH-USDT",
        //             "side":"buy",
        //             "size":"30.98616393",
        //             "timestamp":"2020-03-29T11:55:25.000Z",
        //             "trade_id":"18551601"
        //         },
        //         {
        //             "created_at":"2020-03-29T11:55:25.000Z",
        //             "currency":"ETH",
        //             "exec_type":"T",
        //             "fee":"0",
        //             "instrument_id":"ETH-USDT",
        //             "ledger_id":"10562924352",
        //             "liquidity":"T",
        //             "order_id":"4636470489136128",
        //             "price":"129.13",
        //             "product_id":"ETH-USDT",
        //             "side":"sell",
        //             "size":"0.23996099",
        //             "timestamp":"2020-03-29T11:55:25.000Z",
        //             "trade_id":"18551601"
        //         },
        //         // buy
        //         {
        //             "created_at":"2020-03-29T11:55:16.000Z",
        //             "currency":"ETH",
        //             "exec_type":"T",
        //             "fee":"-0.00036049",
        //             "instrument_id":"ETH-USDT",
        //             "ledger_id":"10562922669",
        //             "liquidity":"T",
        //             "order_id": "4636469894136832",
        //             "price":"129.16",
        //             "product_id":"ETH-USDT",
        //             "side":"buy",
        //             "size":"0.240322",
        //             "timestamp":"2020-03-29T11:55:16.000Z",
        //             "trade_id":"18551600"
        //         },
        //         {
        //             "created_at":"2020-03-29T11:55:16.000Z",
        //             "currency":"USDT",
        //             "exec_type":"T",
        //             "fee":"0",
        //             "instrument_id":"ETH-USDT",
        //             "ledger_id":"10562922668",
        //             "liquidity":"T",
        //             "order_id":"4636469894136832",
        //             "price":"129.16",
        //             "product_id":"ETH-USDT",
        //             "side":"sell",
        //             "size":"31.03998952",
        //             "timestamp":"2020-03-29T11:55:16.000Z",
        //             "trade_id":"18551600"
        //         }
        //     ]
        //
        return ((object)this.parseMyTrades(response, market, since, limit, parameters));
    }

    public async virtual Task<object> fetchOrderTrades(object id, object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchOrderTrades
        * @description fetch all the trades made from a single order
        * @param {string} id order id
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch trades for
        * @param {int|undefined} limit the maximum number of trades to retrieve
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object request = new Dictionary<string, object>() {
            { "order_id", id },
        };
        return await this.fetchMyTrades(symbol, since, limit, this.extend(request, parameters));
    }

    public async override Task<object> fetchPosition(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchPosition
        * @description fetch data on a single open contract trade position
        * @param {string} symbol unified market symbol of the market the position is held in, default is undefined
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} a [position structure]{@link https://docs.ccxt.com/#/?id=position-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object method = null;
        object request = new Dictionary<string, object>() {
            { "instrument_id", getValue(market, "id") },
        };
        object type = getValue(market, "type");
        if (isTrue(isTrue((isEqual(type, "futures"))) || isTrue((isEqual(type, "swap")))))
        {
            method = add(type, "GetInstrumentIdPosition");
        } else if (isTrue(isEqual(type, "option")))
        {
            object underlying = this.safeString(parameters, "underlying");
            if (isTrue(isEqual(underlying, null)))
            {
                throw new ArgumentsRequired ((string)add(add(add(add(this.id, " fetchPosition() requires an underlying parameter for "), type), " market "), symbol)) ;
            }
            method = add(type, "GetUnderlyingPosition");
        } else
        {
            throw new NotSupported ((string)add(add(add(add(add(this.id, " fetchPosition() does not support "), type), " market "), symbol), ", supported market types are futures, swap or option")) ;
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        // futures
        //
        //     crossed margin mode
        //
        //     {
        //         "result": true,
        //         "holding": [
        //             {
        //                 "long_qty": "2",
        //                 "long_avail_qty": "2",
        //                 "long_avg_cost": "8260",
        //                 "long_settlement_price": "8260",
        //                 "realised_pnl": "0.00020928",
        //                 "short_qty": "2",
        //                 "short_avail_qty": "2",
        //                 "short_avg_cost": "8259.99",
        //                 "short_settlement_price": "8259.99",
        //                 "liquidation_price": "113.81",
        //                 "instrument_id": "BTC-USD-191227",
        //                 "leverage": "10",
        //                 "created_at": "2019-09-25T07:58:42.129Z",
        //                 "updated_at": "2019-10-08T14:02:51.029Z",
        //                 "margin_mode": "crossed",
        //                 "short_margin": "0.00242197",
        //                 "short_pnl": "6.63E-6",
        //                 "short_pnl_ratio": "0.002477997",
        //                 "short_unrealised_pnl": "6.63E-6",
        //                 "long_margin": "0.00242197",
        //                 "long_pnl": "-6.65E-6",
        //                 "long_pnl_ratio": "-0.002478",
        //                 "long_unrealised_pnl": "-6.65E-6",
        //                 "long_settled_pnl": "0",
        //                 "short_settled_pnl": "0",
        //                 "last": "8257.57"
        //             }
        //         ],
        //         "margin_mode": "crossed"
        //     }
        //
        //     fixed margin mode
        //
        //     {
        //         "result": true,
        //         "holding": [
        //             {
        //                 "long_qty": "4",
        //                 "long_avail_qty": "4",
        //                 "long_margin": "0.00323844",
        //                 "long_liqui_price": "7762.09",
        //                 "long_pnl_ratio": "0.06052306",
        //                 "long_avg_cost": "8234.43",
        //                 "long_settlement_price": "8234.43",
        //                 "realised_pnl": "-0.00000296",
        //                 "short_qty": "2",
        //                 "short_avail_qty": "2",
        //                 "short_margin": "0.00241105",
        //                 "short_liqui_price": "9166.74",
        //                 "short_pnl_ratio": "0.03318052",
        //                 "short_avg_cost": "8295.13",
        //                 "short_settlement_price": "8295.13",
        //                 "instrument_id": "BTC-USD-191227",
        //                 "long_leverage": "15",
        //                 "short_leverage": "10",
        //                 "created_at": "2019-09-25T07:58:42.129Z",
        //                 "updated_at": "2019-10-08T13:12:09.438Z",
        //                 "margin_mode": "fixed",
        //                 "short_margin_ratio": "0.10292507",
        //                 "short_maint_margin_ratio": "0.005",
        //                 "short_pnl": "7.853E-5",
        //                 "short_unrealised_pnl": "7.853E-5",
        //                 "long_margin_ratio": "0.07103743",
        //                 "long_maint_margin_ratio": "0.005",
        //                 "long_pnl": "1.9841E-4",
        //                 "long_unrealised_pnl": "1.9841E-4",
        //                 "long_settled_pnl": "0",
        //                 "short_settled_pnl": "0",
        //                 "last": "8266.99"
        //             }
        //         ],
        //         "margin_mode": "fixed"
        //     }
        //
        // swap
        //
        //     crossed margin mode
        //
        //     {
        //         "margin_mode": "crossed",
        //         "timestamp": "2019-09-27T03:49:02.018Z",
        //         "holding": [
        //             {
        //                 "avail_position": "3",
        //                 "avg_cost": "59.49",
        //                 "instrument_id": "LTC-USD-SWAP",
        //                 "last": "55.98",
        //                 "leverage": "10.00",
        //                 "liquidation_price": "4.37",
        //                 "maint_margin_ratio": "0.0100",
        //                 "margin": "0.0536",
        //                 "position": "3",
        //                 "realized_pnl": "0.0000",
        //                 "unrealized_pnl": "0",
        //                 "settled_pnl": "-0.0330",
        //                 "settlement_price": "55.84",
        //                 "side": "long",
        //                 "timestamp": "2019-09-27T03:49:02.018Z"
        //             },
        //         ]
        //     }
        //
        //     fixed margin mode
        //
        //     {
        //         "margin_mode": "fixed",
        //         "timestamp": "2019-09-27T03:47:37.230Z",
        //         "holding": [
        //             {
        //                 "avail_position": "20",
        //                 "avg_cost": "8025.0",
        //                 "instrument_id": "BTC-USD-SWAP",
        //                 "last": "8113.1",
        //                 "leverage": "15.00",
        //                 "liquidation_price": "7002.6",
        //                 "maint_margin_ratio": "0.0050",
        //                 "margin": "0.0454",
        //                 "position": "20",
        //                 "realized_pnl": "-0.0001",
        //                 "unrealized_pnl": "0",
        //                 "settled_pnl": "0.0076",
        //                 "settlement_price": "8279.2",
        //                 "side": "long",
        //                 "timestamp": "2019-09-27T03:47:37.230Z"
        //             }
        //         ]
        //     }
        //
        // option
        //
        //     {
        //         "holding":[
        //             {
        //                 "instrument_id":"BTC-USD-190927-12500-C",
        //                 "position":"20",
        //                 "avg_cost":"3.26",
        //                 "avail_position":"20",
        //                 "settlement_price":"0.017",
        //                 "total_pnl":"50",
        //                 "pnl_ratio":"0.3",
        //                 "realized_pnl":"40",
        //                 "unrealized_pnl":"10",
        //                 "pos_margin":"100",
        //                 "option_value":"70",
        //                 "created_at":"2019-08-30T03:09:20.315Z",
        //                 "updated_at":"2019-08-30T03:40:18.318Z"
        //             },
        //             {
        //                 "instrument_id":"BTC-USD-190927-12500-P",
        //                 "position":"20",
        //                 "avg_cost":"3.26",
        //                 "avail_position":"20",
        //                 "settlement_price":"0.019",
        //                 "total_pnl":"50",
        //                 "pnl_ratio":"0.3",
        //                 "realized_pnl":"40",
        //                 "unrealized_pnl":"10",
        //                 "pos_margin":"100",
        //                 "option_value":"70",
        //                 "created_at":"2019-08-30T03:09:20.315Z",
        //                 "updated_at":"2019-08-30T03:40:18.318Z"
        //             }
        //         ]
        //     }
        //
        // todo unify parsePosition/parsePositions
        return response;
    }

    public async override Task<object> fetchPositions(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchPositions
        * @description fetch all open positions
        * @param {[string]|undefined} symbols not used by okcoin fetchPositions
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {[object]} a list of [position structure]{@link https://docs.ccxt.com/#/?id=position-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object method = null;
        object defaultType = this.safeString2(this.options, "fetchPositions", "defaultType");
        object type = this.safeString(parameters, "type", defaultType);
        if (isTrue(isTrue((isEqual(type, "futures"))) || isTrue((isEqual(type, "swap")))))
        {
            method = add(type, "GetPosition");
        } else if (isTrue(isEqual(type, "option")))
        {
            object underlying = this.safeString(parameters, "underlying");
            if (isTrue(isEqual(underlying, null)))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " fetchPositions() requires an underlying parameter for "), type), " markets")) ;
            }
            method = add(type, "GetUnderlyingPosition");
        } else
        {
            throw new NotSupported ((string)add(add(add(this.id, " fetchPositions() does not support "), type), " markets, supported market types are futures, swap or option")) ;
        }
        parameters = this.omit(parameters, "type");
        object response = await this.callAsync(method, parameters);
        //
        // futures
        //
        //     ...
        //
        //
        // swap
        //
        //     ...
        //
        // option
        //
        //     {
        //         "holding":[
        //             {
        //                 "instrument_id":"BTC-USD-190927-12500-C",
        //                 "position":"20",
        //                 "avg_cost":"3.26",
        //                 "avail_position":"20",
        //                 "settlement_price":"0.017",
        //                 "total_pnl":"50",
        //                 "pnl_ratio":"0.3",
        //                 "realized_pnl":"40",
        //                 "unrealized_pnl":"10",
        //                 "pos_margin":"100",
        //                 "option_value":"70",
        //                 "created_at":"2019-08-30T03:09:20.315Z",
        //                 "updated_at":"2019-08-30T03:40:18.318Z"
        //             },
        //             {
        //                 "instrument_id":"BTC-USD-190927-12500-P",
        //                 "position":"20",
        //                 "avg_cost":"3.26",
        //                 "avail_position":"20",
        //                 "settlement_price":"0.019",
        //                 "total_pnl":"50",
        //                 "pnl_ratio":"0.3",
        //                 "realized_pnl":"40",
        //                 "unrealized_pnl":"10",
        //                 "pos_margin":"100",
        //                 "option_value":"70",
        //                 "created_at":"2019-08-30T03:09:20.315Z",
        //                 "updated_at":"2019-08-30T03:40:18.318Z"
        //             }
        //         ]
        //     }
        //
        // todo unify parsePosition/parsePositions
        return response;
    }

    public async virtual Task<object> fetchLedger(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name okcoin#fetchLedger
        * @description fetch the history of changes, actions done by the user or operations that altered balance of the user
        * @param {string|undefined} code unified currency code, default is undefined
        * @param {int|undefined} since timestamp in ms of the earliest ledger entry, default is undefined
        * @param {int|undefined} limit max number of ledger entrys to return, default is undefined
        * @param {object} params extra parameters specific to the okcoin api endpoint
        * @returns {object} a [ledger structure]{@link https://docs.ccxt.com/#/?id=ledger-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object defaultType = this.safeString2(this.options, "fetchLedger", "defaultType");
        object type = this.safeString(parameters, "type", defaultType);
        object query = this.omit(parameters, "type");
        object suffix = ((bool) isTrue((isEqual(type, "account")))) ? "" : "Accounts";
        object argument = "";
        object request = new Dictionary<string, object>() {};
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit;
        }
        object currency = null;
        if (isTrue(isEqual(type, "spot")))
        {
            if (isTrue(isEqual(code, null)))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " fetchLedger() requires a currency code argument for \'"), type), "\' markets")) ;
            }
            argument = "Currency";
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["currency"] = getValue(currency, "id");
        } else if (isTrue(isEqual(type, "futures")))
        {
            if (isTrue(isEqual(code, null)))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " fetchLedger() requires an underlying symbol for \'"), type), "\' markets")) ;
            }
            argument = "Underlying";
            object market = this.market(code); // we intentionally put a market inside here for the swap ledgers
            object marketInfo = this.safeValue(market, "info", new Dictionary<string, object>() {});
            object settlementCurrencyId = this.safeString(marketInfo, "settlement_currency");
            object settlementCurrencyCode = this.safeCurrencyCode(settlementCurrencyId);
            currency = this.currency(settlementCurrencyCode);
            object underlyingId = this.safeString(marketInfo, "underlying");
            ((Dictionary<string, object>)request)["underlying"] = underlyingId;
        } else if (isTrue(isEqual(type, "swap")))
        {
            if (isTrue(isEqual(code, null)))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " fetchLedger() requires a code argument (a market symbol) for \'"), type), "\' markets")) ;
            }
            argument = "InstrumentId";
            object market = this.market(code); // we intentionally put a market inside here for the swap ledgers
            currency = this.currency(getValue(market, "base"));
            ((Dictionary<string, object>)request)["instrument_id"] = getValue(market, "id");
        } else if (isTrue(isEqual(type, "account")))
        {
            if (isTrue(!isEqual(code, null)))
            {
                currency = this.currency(code);
                ((Dictionary<string, object>)request)["currency"] = getValue(currency, "id");
            }
        } else
        {
            throw new NotSupported ((string)add(add(add(this.id, " fetchLedger does not support the \'"), type), "\' type (the type must be one of \'account\', \'spot\', \'margin\', \'futures\', \'swap\')")) ;
        }
        object method = add(add(add(add(type, "Get"), suffix), argument), "Ledger");
        object response = await this.callAsync(method, this.extend(request, query));
        //
        // transfer     funds transfer in/out
        // trade        funds moved as a result of a trade, spot accounts only
        // rebate       fee rebate as per fee schedule, spot accounts only
        // match        open long/open short/close long/close short (futures) or a change in the amount because of trades (swap)
        // fee          fee, futures only
        // settlement   settlement/clawback/settle long/settle short
        // liquidation  force close long/force close short/deliver close long/deliver close short
        // funding      funding fee, swap only
        // margin       a change in the amount after adjusting margin, swap only
        //
        // account
        //
        //     [
        //         {
        //             "amount":0.00051843,
        //             "balance":0.00100941,
        //             "currency":"BTC",
        //             "fee":0,
        //             "ledger_id":8987285,
        //             "timestamp":"2018-10-12T11:01:14.000Z",
        //             "typename":"Get from activity"
        //         }
        //     ]
        //
        // spot
        //
        //     [
        //         {
        //             "timestamp":"2019-03-18T07:08:25.000Z",
        //             "ledger_id":"3995334780",
        //             "created_at":"2019-03-18T07:08:25.000Z",
        //             "currency":"BTC",
        //             "amount":"0.0009985",
        //             "balance":"0.0029955",
        //             "type":"trade",
        //             "details":{
        //                 "instrument_id":"BTC-USDT",
        //                 "order_id":"2500650881647616",
        //                 "product_id":"BTC-USDT"
        //             }
        //         }
        //     ]
        //
        // futures
        //
        //     [
        //         {
        //             "ledger_id":"2508090544914461",
        //             "timestamp":"2019-03-19T14:40:24.000Z",
        //             "amount":"-0.00529521",
        //             "balance":"0",
        //             "currency":"EOS",
        //             "type":"fee",
        //             "details":{
        //                 "order_id":"2506982456445952",
        //                 "instrument_id":"EOS-USD-190628"
        //             }
        //         }
        //     ]
        //
        // swap
        //
        //     [
        //         {
        //             "amount":"0.004742",
        //             "fee":"-0.000551",
        //             "type":"match",
        //             "instrument_id":"EOS-USD-SWAP",
        //             "ledger_id":"197429674941902848",
        //             "timestamp":"2019-03-25T05:56:31.286Z"
        //         },
        //     ]
        //
        object responseLength = getArrayLength(response);
        if (isTrue(isLessThan(responseLength, 1)))
        {
            return new List<object>() {};
        }
        if (isTrue(isEqual(type, "swap")))
        {
            object ledgerEntries = this.parseLedger(response);
            return this.filterBySymbolSinceLimit(ledgerEntries, code, since, limit);
        }
        return this.parseLedger(response, currency, since, limit);
    }

    public virtual object parseLedgerEntryType(object type)
    {
        object types = new Dictionary<string, object>() {
            { "transfer", "transfer" },
            { "trade", "trade" },
            { "rebate", "rebate" },
            { "match", "trade" },
            { "fee", "fee" },
            { "settlement", "trade" },
            { "liquidation", "trade" },
            { "funding", "fee" },
            { "margin", "margin" },
        };
        return this.safeString(types, type, type);
    }

    public override object parseLedgerEntry(object item, object currency = null)
    {
        //
        //
        // account
        //
        //     {
        //         "amount":0.00051843,
        //         "balance":0.00100941,
        //         "currency":"BTC",
        //         "fee":0,
        //         "ledger_id":8987285,
        //         "timestamp":"2018-10-12T11:01:14.000Z",
        //         "typename":"Get from activity"
        //     }
        //
        // spot
        //
        //     {
        //         "timestamp":"2019-03-18T07:08:25.000Z",
        //         "ledger_id":"3995334780",
        //         "created_at":"2019-03-18T07:08:25.000Z",
        //         "currency":"BTC",
        //         "amount":"0.0009985",
        //         "balance":"0.0029955",
        //         "type":"trade",
        //         "details":{
        //             "instrument_id":"BTC-USDT",
        //             "order_id":"2500650881647616",
        //             "product_id":"BTC-USDT"
        //         }
        //     }
        //
        // futures
        //
        //     {
        //         "ledger_id":"2508090544914461",
        //         "timestamp":"2019-03-19T14:40:24.000Z",
        //         "amount":"-0.00529521",
        //         "balance":"0",
        //         "currency":"EOS",
        //         "type":"fee",
        //         "details":{
        //             "order_id":"2506982456445952",
        //             "instrument_id":"EOS-USD-190628"
        //         }
        //     }
        //
        // swap
        //
        //     {
        //         "amount":"0.004742",
        //         "fee":"-0.000551",
        //         "type":"match",
        //         "instrument_id":"EOS-USD-SWAP",
        //         "ledger_id":"197429674941902848",
        //         "timestamp":"2019-03-25T05:56:31.286Z"
        //     },
        //
        object id = this.safeString(item, "ledger_id");
        object account = null;
        object details = this.safeValue(item, "details", new Dictionary<string, object>() {});
        object referenceId = this.safeString(details, "order_id");
        object referenceAccount = null;
        object type = this.parseLedgerEntryType(this.safeString(item, "type"));
        object code = this.safeCurrencyCode(this.safeString(item, "currency"), currency);
        object amount = this.safeNumber(item, "amount");
        object timestamp = this.parse8601(this.safeString(item, "timestamp"));
        object fee = new Dictionary<string, object>() {
            { "cost", this.safeNumber(item, "fee") },
            { "currency", code },
        };
        object before = null;
        object after = this.safeNumber(item, "balance");
        object status = "ok";
        object marketId = this.safeString(item, "instrument_id");
        object symbol = this.safeSymbol(marketId);
        return new Dictionary<string, object>() {
            { "info", item },
            { "id", id },
            { "account", account },
            { "referenceId", referenceId },
            { "referenceAccount", referenceAccount },
            { "type", type },
            { "currency", code },
            { "symbol", symbol },
            { "amount", amount },
            { "before", before },
            { "after", after },
            { "status", status },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "fee", fee },
        };
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object isArray = (parameters.GetType().IsGenericType && parameters.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)));
        object request = add(add(add(add("/api/", api), "/"), this.version), "/");
        request = add(request, ((bool) isTrue(isArray)) ? path : this.implodeParams(path, parameters));
        object query = ((bool) isTrue(isArray)) ? parameters : this.omit(parameters, this.extractParams(path));
        object url = add(this.implodeHostname(getValue(getValue(this.urls, "api"), "rest")), request);
        object type = this.getPathAuthenticationType(path);
        if (isTrue(isTrue((isEqual(type, "public"))) || isTrue((isEqual(type, "information")))))
        {
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
            {
                url = add(url, add("?", this.urlencode(query)));
            }
        } else if (isTrue(isEqual(type, "private")))
        {
            this.checkRequiredCredentials();
            object timestamp = this.iso8601(this.milliseconds());
            headers = new Dictionary<string, object>() {
                { "OK-ACCESS-KEY", this.apiKey },
                { "OK-ACCESS-PASSPHRASE", this.password },
                { "OK-ACCESS-TIMESTAMP", timestamp },
            };
            object auth = add(add(timestamp, method), request);
            if (isTrue(isEqual(method, "GET")))
            {
                if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
                {
                    object urlencodedQuery = add("?", this.urlencode(query));
                    url = add(url, urlencodedQuery);
                    auth = add(auth, urlencodedQuery);
                }
            } else
            {
                if (isTrue(isTrue(isArray) || isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys)))))
                {
                    body = this.json(query);
                    auth = add(auth, body);
                }
                ((Dictionary<string, object>)headers)["Content-Type"] = "application/json";
            }
            object signature = this.hmac(this.encode(auth), this.encode(this.secret), sha256, "base64");
            ((Dictionary<string, object>)headers)["OK-ACCESS-SIGN"] = signature;
        }
        return new Dictionary<string, object>() {
            { "url", url },
            { "method", method },
            { "body", body },
            { "headers", headers },
        };
    }

    public virtual object getPathAuthenticationType(object path)
    {
        // https://github.com/ccxt/ccxt/issues/6651
        // a special case to handle the optionGetUnderlying interefering with
        // other endpoints containing this keyword
        if (isTrue(isEqual(path, "underlying")))
        {
            return "public";
        }
        object auth = this.safeValue(this.options, "auth", new Dictionary<string, object>() {});
        object key = this.findBroadlyMatchedKey(auth, path);
        return this.safeString(auth, key, "private");
    }

    public override object handleErrors(object code, object reason, object url, object method, object headers, object body, object response, object requestHeaders, object requestBody)
    {
        if (!isTrue(response))
        {
            return null;  // fallback to default error handler
        }
        object feedback = add(add(this.id, " "), body);
        if (isTrue(isEqual(code, 503)))
        {
            throw new ExchangeNotAvailable ((string)feedback) ;
        }
        //
        //     {"error_message":"Order does not exist","result":"true","error_code":"35029","order_id":"-1"}
        //
        object message = this.safeString(response, "message");
        object errorCode = this.safeString2(response, "code", "error_code");
        object nonEmptyMessage = (isTrue((!isEqual(message, null))) && isTrue((!isEqual(message, ""))));
        object nonZeroErrorCode = isTrue((!isEqual(errorCode, null))) && isTrue((!isEqual(errorCode, "0")));
        if (isTrue(nonEmptyMessage))
        {
            this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), message, feedback);
            this.throwBroadlyMatchedException(getValue(this.exceptions, "broad"), message, feedback);
        }
        if (isTrue(nonZeroErrorCode))
        {
            this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), errorCode, feedback);
        }
        if (isTrue(isTrue(nonZeroErrorCode) || isTrue(nonEmptyMessage)))
        {
            throw new ExchangeError ((string)feedback) ;
        }
        return null;
    }
}
