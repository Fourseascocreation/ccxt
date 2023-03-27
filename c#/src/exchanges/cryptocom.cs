using Main;
namespace Main;

partial class cryptocom : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "cryptocom" },
            { "name", "Crypto.com" },
            { "countries", new List<object>() {"MT"} },
            { "version", "v2" },
            { "rateLimit", 10 },
            { "pro", true },
            { "has", new Dictionary<string, object>() {
                { "CORS", false },
                { "spot", true },
                { "margin", true },
                { "swap", null },
                { "future", null },
                { "option", null },
                { "borrowMargin", true },
                { "cancelAllOrders", true },
                { "cancelOrder", true },
                { "createOrder", true },
                { "fetchBalance", true },
                { "fetchBidsAsks", false },
                { "fetchBorrowInterest", true },
                { "fetchBorrowRate", false },
                { "fetchBorrowRateHistories", false },
                { "fetchBorrowRateHistory", false },
                { "fetchBorrowRates", true },
                { "fetchClosedOrders", "emulated" },
                { "fetchCurrencies", false },
                { "fetchDepositAddress", true },
                { "fetchDepositAddressesByNetwork", true },
                { "fetchDeposits", true },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", false },
                { "fetchFundingRates", false },
                { "fetchMarginMode", false },
                { "fetchMarkets", true },
                { "fetchMyTrades", true },
                { "fetchOHLCV", true },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchOrders", true },
                { "fetchPositionMode", false },
                { "fetchPositions", false },
                { "fetchStatus", false },
                { "fetchTicker", true },
                { "fetchTickers", true },
                { "fetchTime", false },
                { "fetchTrades", true },
                { "fetchTradingFee", false },
                { "fetchTradingFees", false },
                { "fetchTransactionFees", false },
                { "fetchTransactions", false },
                { "fetchTransfers", true },
                { "fetchWithdrawals", true },
                { "repayMargin", true },
                { "setLeverage", false },
                { "setMarginMode", false },
                { "transfer", true },
                { "withdraw", true },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "1m" },
                { "5m", "5m" },
                { "15m", "15m" },
                { "30m", "30m" },
                { "1h", "1h" },
                { "4h", "4h" },
                { "6h", "6h" },
                { "12h", "12h" },
                { "1d", "1D" },
                { "1w", "7D" },
                { "2w", "14D" },
                { "1M", "1M" },
            } },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/1294454/147792121-38ed5e36-c229-48d6-b49a-48d05fc19ed4.jpeg" },
                { "test", new Dictionary<string, object>() {
                    { "v1", "https://uat-api.3ona.co/exchange/v1" },
                    { "v2", "https://uat-api.3ona.co/v2" },
                    { "derivatives", "https://uat-api.3ona.co/v2" },
                } },
                { "api", new Dictionary<string, object>() {
                    { "v1", "https://api.crypto.com/exchange/v1" },
                    { "v2", "https://api.crypto.com/v2" },
                    { "derivatives", "https://deriv-api.crypto.com/v1" },
                } },
                { "www", "https://crypto.com/" },
                { "referral", "https://crypto.com/exch/5835vstech" },
                { "doc", new List<object>() {"https://exchange-docs.crypto.com/exchange/v1/rest-ws/index.html", "https://exchange-docs.crypto.com/spot/index.html", "https://exchange-docs.crypto.com/derivatives/index.html"} },
                { "fees", "https://crypto.com/exchange/document/fees-limits" },
            } },
            { "api", new Dictionary<string, object>() {
                { "v1", new Dictionary<string, object>() {
                    { "public", new Dictionary<string, object>() {
                        { "get", new Dictionary<string, object>() {
                            { "public/auth", divide(10, 3) },
                            { "public/get-instruments", divide(10, 3) },
                            { "public/get-book", 1 },
                            { "public/get-candlestick", 1 },
                            { "public/get-trades", 1 },
                            { "public/get-tickers", 1 },
                            { "public/get-valuations", 1 },
                            { "public/get-expired-settlement-price", divide(10, 3) },
                            { "public/get-insurance", 1 },
                        } },
                    } },
                    { "private", new Dictionary<string, object>() {
                        { "post", new Dictionary<string, object>() {
                            { "private/set-cancel-on-disconnect", divide(10, 3) },
                            { "private/get-cancel-on-disconnect", divide(10, 3) },
                            { "private/user-balance", divide(10, 3) },
                            { "private/user-balance-history", divide(10, 3) },
                            { "private/get-positions", divide(10, 3) },
                            { "private/create-order", divide(2, 3) },
                            { "private/create-order-list", divide(10, 3) },
                            { "private/cancel-order", divide(2, 3) },
                            { "private/cancel-order-list", divide(10, 3) },
                            { "private/cancel-all-orders", divide(2, 3) },
                            { "private/close-position", divide(10, 3) },
                            { "private/get-order-history", 100 },
                            { "private/get-open-orders", divide(10, 3) },
                            { "private/get-order-detail", divide(1, 3) },
                            { "private/get-trades", 100 },
                            { "private/change-account-leverage", divide(10, 3) },
                            { "private/get-transactions", divide(10, 3) },
                            { "private/create-subaccount-transfer", divide(10, 3) },
                            { "private/get-subaccount-balances", divide(10, 3) },
                            { "private/get-order-list", divide(10, 3) },
                            { "private/create-withdrawal", divide(10, 3) },
                            { "private/get-currency-networks", divide(10, 3) },
                            { "private/get-deposit-address", divide(10, 3) },
                            { "private/get-accounts", divide(10, 3) },
                        } },
                    } },
                } },
                { "v2", new Dictionary<string, object>() {
                    { "public", new Dictionary<string, object>() {
                        { "get", new Dictionary<string, object>() {
                            { "public/auth", 1 },
                            { "public/get-instruments", 1 },
                            { "public/get-book", 1 },
                            { "public/get-candlestick", 1 },
                            { "public/get-ticker", 1 },
                            { "public/get-trades", 1 },
                            { "public/margin/get-transfer-currencies", 1 },
                            { "public/margin/get-load-currenices", 1 },
                            { "public/respond-heartbeat", 1 },
                        } },
                    } },
                    { "private", new Dictionary<string, object>() {
                        { "post", new Dictionary<string, object>() {
                            { "private/set-cancel-on-disconnect", divide(10, 3) },
                            { "private/get-cancel-on-disconnect", divide(10, 3) },
                            { "private/create-withdrawal", divide(10, 3) },
                            { "private/get-withdrawal-history", divide(10, 3) },
                            { "private/get-currency-networks", divide(10, 3) },
                            { "private/get-deposit-history", divide(10, 3) },
                            { "private/get-deposit-address", divide(10, 3) },
                            { "private/get-account-summary", divide(10, 3) },
                            { "private/create-order", divide(2, 3) },
                            { "private/cancel-order", divide(2, 3) },
                            { "private/cancel-all-orders", divide(2, 3) },
                            { "private/create-order-list", divide(10, 3) },
                            { "private/get-order-history", divide(10, 3) },
                            { "private/get-open-orders", divide(10, 3) },
                            { "private/get-order-detail", divide(1, 3) },
                            { "private/get-trades", 100 },
                            { "private/margin/get-user-config", divide(10, 3) },
                            { "private/margin/get-account-summary", divide(10, 3) },
                            { "private/margin/transfer", divide(10, 3) },
                            { "private/margin/borrow", divide(10, 3) },
                            { "private/margin/repay", divide(10, 3) },
                            { "private/margin/get-transfer-history", divide(10, 3) },
                            { "private/margin/get-borrow-history", divide(10, 3) },
                            { "private/margin/get-interest-history", divide(10, 3) },
                            { "private/margin/get-repay-history", divide(10, 3) },
                            { "private/margin/get-liquidation-history", divide(10, 3) },
                            { "private/margin/get-liquidation-orders", divide(10, 3) },
                            { "private/margin/create-order", divide(2, 3) },
                            { "private/margin/cancel-order", divide(2, 3) },
                            { "private/margin/cancel-all-orders", divide(2, 3) },
                            { "private/margin/get-order-history", divide(10, 3) },
                            { "private/margin/get-open-orders", divide(10, 3) },
                            { "private/margin/get-order-detail", divide(1, 3) },
                            { "private/margin/get-trades", 100 },
                            { "private/deriv/transfer", divide(10, 3) },
                            { "private/deriv/get-transfer-history", divide(10, 3) },
                            { "private/get-accounts", divide(10, 3) },
                            { "private/get-subaccount-balances", divide(10, 3) },
                            { "private/create-subaccount-transfer", divide(10, 3) },
                            { "private/otc/get-otc-user", divide(10, 3) },
                            { "private/otc/get-instruments", divide(10, 3) },
                            { "private/otc/request-quote", 100 },
                            { "private/otc/accept-quote", 100 },
                            { "private/otc/get-quote-history", divide(10, 3) },
                            { "private/otc/get-trade-history", divide(10, 3) },
                        } },
                    } },
                } },
                { "derivatives", new Dictionary<string, object>() {
                    { "public", new Dictionary<string, object>() {
                        { "get", new Dictionary<string, object>() {
                            { "public/auth", divide(10, 3) },
                            { "public/get-instruments", divide(10, 3) },
                            { "public/get-book", 1 },
                            { "public/get-candlestick", 1 },
                            { "public/get-trades", 1 },
                            { "public/get-tickers", 1 },
                            { "public/get-valuations", 1 },
                            { "public/get-expired-settlement-price", divide(10, 3) },
                            { "public/get-insurance", 1 },
                        } },
                    } },
                    { "private", new Dictionary<string, object>() {
                        { "post", new Dictionary<string, object>() {
                            { "private/set-cancel-on-disconnect", divide(10, 3) },
                            { "private/get-cancel-on-disconnect", divide(10, 3) },
                            { "private/user-balance", divide(10, 3) },
                            { "private/user-balance-history", divide(10, 3) },
                            { "private/get-positions", divide(10, 3) },
                            { "private/create-order", divide(2, 3) },
                            { "private/create-order-list", divide(10, 3) },
                            { "private/cancel-order", divide(2, 3) },
                            { "private/cancel-order-list", divide(10, 3) },
                            { "private/cancel-all-orders", divide(2, 3) },
                            { "private/close-position", divide(10, 3) },
                            { "private/convert-collateral", divide(10, 3) },
                            { "private/get-order-history", 100 },
                            { "private/get-open-orders", divide(10, 3) },
                            { "private/get-order-detail", divide(1, 3) },
                            { "private/get-trades", 100 },
                            { "private/change-account-leverage", divide(10, 3) },
                            { "private/get-transactions", divide(10, 3) },
                            { "private/create-subaccount-transfer", divide(10, 3) },
                            { "private/get-subaccount-balances", divide(10, 3) },
                            { "private/get-order-list", divide(10, 3) },
                        } },
                    } },
                } },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "maker", this.parseNumber("0.004") },
                    { "taker", this.parseNumber("0.004") },
                    { "tiers", new Dictionary<string, object>() {
                        { "maker", new List<object>() {new List<object> {this.parseNumber("0"), this.parseNumber("0.004")}, new List<object> {this.parseNumber("25000"), this.parseNumber("0.0035")}, new List<object> {this.parseNumber("50000"), this.parseNumber("0.0015")}, new List<object> {this.parseNumber("100000"), this.parseNumber("0.001")}, new List<object> {this.parseNumber("250000"), this.parseNumber("0.0009")}, new List<object> {this.parseNumber("1000000"), this.parseNumber("0.0008")}, new List<object> {this.parseNumber("20000000"), this.parseNumber("0.0007")}, new List<object> {this.parseNumber("100000000"), this.parseNumber("0.0006")}, new List<object> {this.parseNumber("200000000"), this.parseNumber("0.0004")}} },
                        { "taker", new List<object>() {new List<object> {this.parseNumber("0"), this.parseNumber("0.004")}, new List<object> {this.parseNumber("25000"), this.parseNumber("0.0035")}, new List<object> {this.parseNumber("50000"), this.parseNumber("0.0025")}, new List<object> {this.parseNumber("100000"), this.parseNumber("0.0016")}, new List<object> {this.parseNumber("250000"), this.parseNumber("0.00015")}, new List<object> {this.parseNumber("1000000"), this.parseNumber("0.00014")}, new List<object> {this.parseNumber("20000000"), this.parseNumber("0.00013")}, new List<object> {this.parseNumber("100000000"), this.parseNumber("0.00012")}, new List<object> {this.parseNumber("200000000"), this.parseNumber("0.0001")}} },
                    } },
                } },
            } },
            { "options", new Dictionary<string, object>() {
                { "defaultType", "spot" },
                { "accountsById", new Dictionary<string, object>() {
                    { "funding", "SPOT" },
                    { "spot", "SPOT" },
                    { "margin", "MARGIN" },
                    { "derivatives", "DERIVATIVES" },
                    { "swap", "DERIVATIVES" },
                    { "future", "DERIVATIVES" },
                } },
            } },
            { "commonCurrencies", new Dictionary<string, object>() {
                { "USD_STABLE_COIN", "USDC" },
            } },
            { "precisionMode", TICK_SIZE },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {
                    { "10001", typeof(ExchangeError) },
                    { "10002", typeof(PermissionDenied) },
                    { "10003", typeof(PermissionDenied) },
                    { "10004", typeof(BadRequest) },
                    { "10005", typeof(PermissionDenied) },
                    { "10006", typeof(DDoSProtection) },
                    { "10007", typeof(InvalidNonce) },
                    { "10008", typeof(BadRequest) },
                    { "10009", typeof(BadRequest) },
                    { "20001", typeof(BadRequest) },
                    { "20002", typeof(InsufficientFunds) },
                    { "20005", typeof(AccountNotEnabled) },
                    { "30003", typeof(BadSymbol) },
                    { "30004", typeof(BadRequest) },
                    { "30005", typeof(BadRequest) },
                    { "30006", typeof(InvalidOrder) },
                    { "30007", typeof(InvalidOrder) },
                    { "30008", typeof(InvalidOrder) },
                    { "30009", typeof(InvalidOrder) },
                    { "30010", typeof(BadRequest) },
                    { "30013", typeof(InvalidOrder) },
                    { "30014", typeof(InvalidOrder) },
                    { "30016", typeof(InvalidOrder) },
                    { "30017", typeof(InvalidOrder) },
                    { "30023", typeof(InvalidOrder) },
                    { "30024", typeof(InvalidOrder) },
                    { "30025", typeof(InvalidOrder) },
                    { "40001", typeof(BadRequest) },
                    { "40002", typeof(BadRequest) },
                    { "40003", typeof(BadRequest) },
                    { "40004", typeof(BadRequest) },
                    { "40005", typeof(BadRequest) },
                    { "40006", typeof(BadRequest) },
                    { "40007", typeof(BadRequest) },
                    { "40101", typeof(AuthenticationError) },
                    { "50001", typeof(BadRequest) },
                    { "9010001", typeof(OnMaintenance) },
                } },
            } },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchMarkets
        * @see https://exchange-docs.crypto.com/spot/index.html#public-get-instruments
        * @see https://exchange-docs.crypto.com/derivatives/index.html#public-get-instruments
        * @description retrieves data on all markets for cryptocom
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        parameters ??= new Dictionary<string, object>();
        object promises = new List<object> {this.fetchSpotMarkets(parameters), this.fetchDerivativesMarkets(parameters)};
        // @ts-ignore
        promises = await promiseAll(promises);
        object spotMarkets = getValue(promises, 0);
        object derivativeMarkets = getValue(promises, 1);
        object markets = this.arrayConcat(spotMarkets, derivativeMarkets);
        return markets;
    }

    public async virtual Task<object> fetchSpotMarkets(object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        object response = await this.v2PublicGetPublicGetInstruments(parameters);
        //
        //    {
        //        id: 11,
        //        method: 'public/get-instruments',
        //        code: 0,
        //        result: {
        //            'instruments': [
        //                {
        //                    instrument_name: 'NEAR_BTC',
        //                    quote_currency: 'BTC',
        //                    base_currency: 'NEAR',
        //                    price_decimals: '8',
        //                    quantity_decimals: '2',
        //                    margin_trading_enabled: true,
        //                    margin_trading_enabled_5x: true,
        //                    margin_trading_enabled_10x: true,
        //                    max_quantity: '100000000',
        //                    min_quantity: '0.01',
        //                    max_price:'1',
        //                    min_price:'0.00000001',
        //                    last_update_date:1667263094857,
        //                    quantity_tick_size:'0.1',
        //                    price_tick_size:'0.00000001'
        //               },
        //            ]
        //        }
        //    }
        //
        object resultResponse = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object markets = this.safeValue(resultResponse, "instruments", new List<object>() {});
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(markets)); postFixIncrement(ref i))
        {
            object market = getValue(markets, i);
            object id = this.safeString(market, "instrument_name");
            object baseId = this.safeString(market, "base_currency");
            object quoteId = this.safeString(market, "quote_currency");
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
            object minPrice = this.safeString(market, "min_price");
            object minQuantity = this.safeString(market, "min_quantity");
            object maxLeverage = this.parseNumber("1");
            object margin_trading_enabled_5x = this.safeValue(market, "margin_trading_enabled_5x");
            if (isTrue(margin_trading_enabled_5x))
            {
                maxLeverage = this.parseNumber("5");
            }
            object margin_trading_enabled_10x = this.safeValue(market, "margin_trading_enabled_10x");
            if (isTrue(margin_trading_enabled_10x))
            {
                maxLeverage = this.parseNumber("10");
            }
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
                { "spot", true },
                { "margin", this.safeValue(market, "margin_trading_enabled") },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "active", null },
                { "contract", false },
                { "linear", null },
                { "inverse", null },
                { "contractSize", null },
                { "expiry", null },
                { "expiryDatetime", null },
                { "strike", null },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "amount", this.safeNumber(market, "quantity_tick_size") },
                    { "price", this.safeNumber(market, "price_tick_size") },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", this.parseNumber("1") },
                        { "max", maxLeverage },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", this.parseNumber(minQuantity) },
                        { "max", this.safeNumber(market, "max_quantity") },
                    } },
                    { "price", new Dictionary<string, object>() {
                        { "min", this.parseNumber(minPrice) },
                        { "max", this.safeNumber(market, "max_price") },
                    } },
                    { "cost", new Dictionary<string, object>() {
                        { "min", this.parseNumber(Precise.stringMul(minQuantity, minPrice)) },
                        { "max", null },
                    } },
                } },
                { "info", market },
            });
        }
        return result;
    }

    public async virtual Task<object> fetchDerivativesMarkets(object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        object result = new List<object>() {};
        object futuresResponse = await this.derivativesPublicGetPublicGetInstruments();
        //
        //     {
        //       id: -1,
        //       method: 'public/get-instruments',
        //       code: 0,
        //       result: {
        //         data: [
        //           {
        //             symbol: '1INCHUSD-PERP',
        //             inst_type: 'PERPETUAL_SWAP',
        //             display_name: '1INCHUSD Perpetual',
        //             base_ccy: '1INCH',
        //             quote_ccy: 'USD_Stable_Coin',
        //             quote_decimals: 4,
        //             quantity_decimals: 0,
        //             price_tick_size: '0.0001',
        //             qty_tick_size: '1',
        //             max_leverage: '50',
        //             tradable: true,
        //             expiry_timestamp_ms: 0,
        //             beta_product: false,
        //             underlying_symbol: '1INCHUSD-INDEX',
        //             put_call: 'UNDEFINED',
        //             strike: '0',
        //             contract_size: '1'
        //           },
        //         ]
        //       }
        //     }
        //
        object futuresResult = this.safeValue(futuresResponse, "result", new Dictionary<string, object>() {});
        object data = this.safeValue(futuresResult, "data", new List<object>() {});
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object market = getValue(data, i);
            object inst_type = this.safeString(market, "inst_type");
            object swap = isEqual(inst_type, "PERPETUAL_SWAP");
            object future = isEqual(inst_type, "FUTURE");
            if (isTrue(isEqual(inst_type, "CCY_PAIR")))
            {

            }
            object baseId = this.safeString(market, "base_ccy");
            object quoteId = this.safeString(market, "quote_ccy");
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
            object symbol = add(add(add(add(bs, "/"), quote), ":"), quote);
            object expiry = this.safeInteger(market, "expiry_timestamp_ms");
            if (isTrue(isEqual(expiry, 0)))
            {
                expiry = null;
            }
            object type = "swap";
            if (isTrue(future))
            {
                type = "future";
                symbol = add(add(symbol, "-"), this.yymmdd(expiry));
            }
            object contractSize = this.safeNumber(market, "contract_size");
            ((List<object>)result).Add(new Dictionary<string, object>() {
                { "id", this.safeString(market, "symbol") },
                { "symbol", symbol },
                { "base", bs },
                { "quote", quote },
                { "settle", quote },
                { "baseId", baseId },
                { "quoteId", quoteId },
                { "settleId", quoteId },
                { "type", type },
                { "spot", false },
                { "margin", false },
                { "swap", swap },
                { "future", future },
                { "option", false },
                { "active", this.safeValue(market, "tradable") },
                { "contract", true },
                { "linear", true },
                { "inverse", false },
                { "contractSize", contractSize },
                { "expiry", expiry },
                { "expiryDatetime", this.iso8601(expiry) },
                { "strike", null },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "price", this.parseNumber(this.parsePrecision(this.safeString(market, "quote_decimals"))) },
                    { "amount", this.parseNumber(this.parsePrecision(this.safeString(market, "quantity_decimals"))) },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", this.parseNumber("1") },
                        { "max", this.safeNumber(market, "max_leverage") },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", this.parseNumber(contractSize) },
                        { "max", null },
                    } },
                    { "price", new Dictionary<string, object>() {
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

    public async override Task<object> fetchTickers(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchTickers
        * @description fetches price tickers for multiple markets, statistical calculations with the information calculated over the past 24 hours each market
        * @see https://exchange-docs.crypto.com/spot/index.html#public-get-ticker
        * @see https://exchange-docs.crypto.com/derivatives/index.html#public-get-tickers
        * @param {[string]|undefined} symbols unified symbols of the markets to fetch the ticker for, all market tickers are returned if not assigned
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        symbols = this.marketSymbols(symbols);
        object market = null;
        if (isTrue(!isEqual(symbols, null)))
        {
            object symbol = this.safeValue(symbols, 0);
            market = this.market(symbol);
        }
        var marketTypequeryVariable = this.handleMarketTypeAndParams("fetchTickers", market, parameters);
        var marketType = ((List<object>) marketTypequeryVariable)[0];
        var query = ((List<object>) marketTypequeryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PublicGetPublicGetTicker" },
            { "future", "derivativesPublicGetPublicGetTickers" },
            { "swap", "derivativesPublicGetPublicGetTickers" },
        });
        object response = await this.callAsync(method, query);
        //
        //     {
        //         "code":0,
        //         "method":"public/get-ticker",
        //         "result":{
        //         "data": [
        //             {"i":"CRO_BTC","b":0.00000890,"k":0.00001179,"a":0.00001042,"t":1591770793901,"v":14905879.59,"h":0.00,"l":0.00,"c":0.00},
        //             {"i":"EOS_USDT","b":2.7676,"k":2.7776,"a":2.7693,"t":1591770798500,"v":774.51,"h":0.05,"l":0.05,"c":0.00},
        //             {"i":"BCH_USDT","b":247.49,"k":251.73,"a":251.67,"t":1591770797601,"v":1.01693,"h":0.01292,"l":0.01231,"c":-0.00047},
        //             {"i":"ETH_USDT","b":239.92,"k":242.59,"a":240.30,"t":1591770798701,"v":0.97575,"h":0.01236,"l":0.01199,"c":-0.00018},
        //             {"i":"ETH_CRO","b":2693.11,"k":2699.84,"a":2699.55,"t":1591770795053,"v":95.680,"h":8.218,"l":7.853,"c":-0.050}
        //         ]
        //         }
        //     }
        //
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object data = this.safeValue(result, "data", new List<object>() {});
        return this.parseTickers(data, symbols);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        var marketTypequeryVariable = this.handleMarketTypeAndParams("fetchTicker", market, parameters);
        var marketType = ((List<object>) marketTypequeryVariable)[0];
        var query = ((List<object>) marketTypequeryVariable)[1];
        if (isTrue(!isEqual(marketType, "spot")))
        {
            throw new NotSupported ((string)add(this.id, " fetchTicker() only supports spot markets")) ;
        }
        object response = await this.v2PublicGetPublicGetTicker(this.extend(request, query));
        //
        //   {
        //       "id":"-1",
        //       "method":"public/get-tickers",
        //       "code":"0",
        //       "result":{
        //          "data":[
        //             { "i":"BTC_USDT", "h":"20567.16", "l":"20341.39", "a":"20394.23", "v":"2236.3762", "vv":"45739074.30", "c":"-0.0036", "b":"20394.01", "k":"20394.02", "t":"1667406085934" }
        //          ]
        //   }
        //
        object resultResponse = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object data = this.safeValue(resultResponse, "data", new Dictionary<string, object>() {});
        object first = this.safeValue(data, 0, new Dictionary<string, object>() {});
        return this.parseTicker(first, market);
    }

    public async override Task<object> fetchOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchOrders
        * @description fetches information on multiple orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrders() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        if (isTrue(!isEqual(since, null)))
        {
            // maximum date range is one day
            ((Dictionary<string, object>)request)["start_ts"] = since;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["page_size"] = limit;
        }
        var marketTypemarketTypeQueryVariable = this.handleMarketTypeAndParams("fetchOrders", market, parameters);
        var marketType = ((List<object>) marketTypemarketTypeQueryVariable)[0];
        var marketTypeQuery = ((List<object>) marketTypemarketTypeQueryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PrivatePostPrivateGetOrderHistory" },
            { "margin", "v2PrivatePostPrivateMarginGetOrderHistory" },
            { "future", "derivativesPrivatePostPrivateGetOrderHistory" },
            { "swap", "derivativesPrivatePostPrivateGetOrderHistory" },
        });
        var marginModequeryVariable = this.customHandleMarginModeAndParams("fetchOrders", marketTypeQuery);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginGetOrderHistory";
        }
        object response = await this.callAsync(method, this.extend(request, query));
        //
        // spot and margin
        //     {
        //       id: 1641026542065,
        //       method: 'private/get-order-history',
        //       code: 0,
        //       result: {
        //         order_list: [
        //           {
        //             status: 'FILLED',
        //             side: 'BUY',
        //             price: 0,
        //             quantity: 110,
        //             order_id: '2120246337927715937',
        //             client_oid: '',
        //             create_time: 1641025064904,
        //             update_time: 1641025064958,
        //             type: 'MARKET',
        //             instrument_name: 'USDC_USDT',
        //             avg_price: 1.0001,
        //             cumulative_quantity: 110,
        //             cumulative_value: 110.011,
        //             fee_currency: 'USDC',
        //             exec_inst: '',
        //             time_in_force: 'GOOD_TILL_CANCEL'
        //           }
        //         ]
        //       }
        //     }
        //
        // swap
        //     {
        //       id: 1641026373106,
        //       method: 'private/get-order-history',
        //       code: 0,
        //       result: {
        //         data: [
        //           {
        //             account_id: '85ff689a-7508-4b96-aa79-dc0545d6e637',
        //             order_id: 13191401932,
        //             client_oid: '1641025941461',
        //             order_type: 'LIMIT',
        //             time_in_force: 'GOOD_TILL_CANCEL',
        //             side: 'BUY',
        //             exec_inst: [],
        //             quantity: '0.0001',
        //             limit_price: '48000.0',
        //             order_value: '4.80000000',
        //             maker_fee_rate: '0.00050',
        //             taker_fee_rate: '0.00070',
        //             avg_price: '47253.5',
        //             trigger_price: '0.0',
        //             ref_price_type: 'NULL_VAL',
        //             cumulative_quantity: '0.0001',
        //             cumulative_value: '4.72535000',
        //             cumulative_fee: '0.00330775',
        //             status: 'FILLED',
        //             update_user_id: 'ce075bef-b600-4277-bd6e-ff9007251e63',
        //             order_date: '2022-01-01',
        //             instrument_name: 'BTCUSD-PERP',
        //             fee_instrument_name: 'USD_Stable_Coin',
        //             create_time: 1641025941827,
        //             create_time_ns: '1641025941827994756',
        //             update_time: 1641025941827
        //           }
        //         ]
        //       }
        //     }
        //
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object orderList = this.safeValue2(data, "order_list", "data", new List<object>() {});
        return this.parseOrders(orderList, market, since, limit);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/en/latest/manual.html?#public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        if (isTrue(!isEqual(since, null)))
        {
            // maximum date range is one day
            ((Dictionary<string, object>)request)["start_ts"] = since;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["page_size"] = limit;
        }
        var marketTypequeryVariable = this.handleMarketTypeAndParams("fetchTrades", market, parameters);
        var marketType = ((List<object>) marketTypequeryVariable)[0];
        var query = ((List<object>) marketTypequeryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PublicGetPublicGetTrades" },
            { "future", "derivativesPublicGetPublicGetTrades" },
            { "swap", "derivativesPublicGetPublicGetTrades" },
        });
        object response = await this.callAsync(method, this.extend(request, query));
        // {
        //     "code":0,
        //     "method":"public/get-trades",
        //     "result": {
        //          "instrument_name": "BTC_USDT",
        //          "data:": [
        //              {"dataTime":1591710781947,"d":465533583799589409,"s":"BUY","p":2.96,"q":16.0,"t":1591710781946,"i":"ICX_CRO"},
        //              {"dataTime":1591707701899,"d":465430234542863152,"s":"BUY","p":0.007749,"q":115.0,"t":1591707701898,"i":"VET_USDT"},
        //              {"dataTime":1591710786155,"d":465533724976458209,"s":"SELL","p":25.676,"q":0.55,"t":1591710786154,"i":"XTZ_CRO"},
        //              {"dataTime":1591710783300,"d":465533629172286576,"s":"SELL","p":2.9016,"q":0.6,"t":1591710783298,"i":"XTZ_USDT"},
        //              {"dataTime":1591710784499,"d":465533669425626384,"s":"SELL","p":2.7662,"q":0.58,"t":1591710784498,"i":"EOS_USDT"},
        //              {"dataTime":1591710784700,"d":465533676120104336,"s":"SELL","p":243.21,"q":0.01647,"t":1591710784698,"i":"ETH_USDT"},
        //              {"dataTime":1591710786600,"d":465533739878620208,"s":"SELL","p":253.06,"q":0.00516,"t":1591710786598,"i":"BCH_USDT"},
        //              {"dataTime":1591710786900,"d":465533749959572464,"s":"BUY","p":0.9999,"q":0.2,"t":1591710786898,"i":"USDC_USDT"},
        //              {"dataTime":1591710787500,"d":465533770081010000,"s":"BUY","p":3.159,"q":1.65,"t":1591710787498,"i":"ATOM_USDT"},
        //            ]
        //      }
        // }
        object resultResponse = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object data = this.safeValue(resultResponse, "data", new List<object>() {});
        return this.parseTrades(data, market, since, limit);
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchOHLCV
        * @description fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents
        * @param {int|undefined} since timestamp in ms of the earliest candle to fetch
        * @param {int|undefined} limit the maximum amount of candles to fetch
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[[int]]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
            { "timeframe", this.safeString(this.timeframes, timeframe, timeframe) },
        };
        var marketTypequeryVariable = this.handleMarketTypeAndParams("fetchOHLCV", market, parameters);
        var marketType = ((List<object>) marketTypequeryVariable)[0];
        var query = ((List<object>) marketTypequeryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PublicGetPublicGetCandlestick" },
            { "future", "derivativesPublicGetPublicGetCandlestick" },
            { "swap", "derivativesPublicGetPublicGetCandlestick" },
        });
        if (isTrue(!isEqual(marketType, "spot")))
        {
            object reqLimit = 100;
            if (isTrue(!isEqual(limit, null)))
            {
                reqLimit = limit;
            }
            ((Dictionary<string, object>)request)["count"] = reqLimit;
        }
        object response = await this.callAsync(method, this.extend(request, query));
        // {
        //     "code":0,
        //     "method":"public/get-candlestick",
        //     "result":{
        //       "instrument_name":"BTC_USDT",
        //       "interval":"5m",
        //       "data":[
        //         {"t":1596944700000,"o":11752.38,"h":11754.77,"l":11746.65,"c":11753.64,"v":3.694583},
        //         {"t":1596945000000,"o":11753.63,"h":11754.77,"l":11739.83,"c":11746.17,"v":2.073019},
        //         {"t":1596945300000,"o":11746.16,"h":11753.24,"l":11738.1,"c":11740.65,"v":0.867247},
        //         ...
        //       ]
        //     }
        // }
        object resultResponse = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object data = this.safeValue(resultResponse, "data", new List<object>() {});
        return this.parseOHLCVs(data, market, timeframe, since, limit);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        if (isTrue(limit))
        {
            ((Dictionary<string, object>)request)["depth"] = limit;
        }
        var marketTypequeryVariable = this.handleMarketTypeAndParams("fetchOrderBook", market, parameters);
        var marketType = ((List<object>) marketTypequeryVariable)[0];
        var query = ((List<object>) marketTypequeryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PublicGetPublicGetBook" },
            { "future", "derivativesPublicGetPublicGetBook" },
            { "swap", "derivativesPublicGetPublicGetBook" },
        });
        object response = await this.callAsync(method, this.extend(request, query));
        // {
        //     "code":0,
        //     "method":"public/get-book",
        //     "result":{
        //       "bids":[[9668.44,0.006325,1.0],[9659.75,0.006776,1.0],[9653.14,0.011795,1.0],[9647.13,0.019434,1.0],[9634.62,0.013765,1.0],[9633.81,0.021395,1.0],[9628.46,0.037834,1.0],[9627.6,0.020909,1.0],[9621.51,0.026235,1.0],[9620.83,0.026701,1.0]],
        //       "asks":[[9697.0,0.68251,1.0],[9697.6,1.722864,2.0],[9699.2,1.664177,2.0],[9700.8,1.824953,2.0],[9702.4,0.85778,1.0],[9704.0,0.935792,1.0],[9713.32,0.002926,1.0],[9716.42,0.78923,1.0],[9732.19,0.00645,1.0],[9737.88,0.020216,1.0]],
        //       "t":1591704180270
        //     }
        // }
        object result = this.safeValue(response, "result");
        object data = this.safeValue(result, "data");
        object orderBook = this.safeValue(data, 0);
        object timestamp = this.safeInteger(orderBook, "t");
        return this.parseOrderBook(orderBook, symbol, timestamp);
    }

    public virtual object parseSwapBalance(object response)
    {
        object responseResult = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object data = this.safeValue(responseResult, "data", new List<object>() {});
        object result = new Dictionary<string, object>() {
            { "info", response },
        };
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object balance = getValue(data, i);
            object currencyId = this.safeString(balance, "instrument_name");
            object code = this.safeCurrencyCode(currencyId);
            object account = this.account();
            ((Dictionary<string, object>)account)["total"] = this.safeString(balance, "total_cash_balance");
            ((Dictionary<string, object>)account)["free"] = this.safeString(balance, "total_available_balance");
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public virtual object parseSpotBalance(object response)
    {
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object coinList = this.safeValue(data, "accounts", new List<object>() {});
        object result = new Dictionary<string, object>() {
            { "info", response },
        };
        for (object i = 0; isLessThan(i, getArrayLength(coinList)); postFixIncrement(ref i))
        {
            object balance = getValue(coinList, i);
            object currencyId = this.safeString(balance, "currency");
            object code = this.safeCurrencyCode(currencyId);
            object account = this.account();
            ((Dictionary<string, object>)account)["total"] = this.safeString(balance, "balance");
            ((Dictionary<string, object>)account)["free"] = this.safeString(balance, "available");
            ((Dictionary<string, object>)account)["used"] = this.safeString(balance, "order");
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        var marketTypemarketTypeQueryVariable = this.handleMarketTypeAndParams("fetchBalance", null, parameters);
        var marketType = ((List<object>) marketTypemarketTypeQueryVariable)[0];
        var marketTypeQuery = ((List<object>) marketTypemarketTypeQueryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PrivatePostPrivateGetAccountSummary" },
            { "margin", "v2PrivatePostPrivateMarginGetAccountSummary" },
            { "future", "derivativesPrivatePostPrivateUserBalance" },
            { "swap", "derivativesPrivatePostPrivateUserBalance" },
        });
        var marginModequeryVariable = this.customHandleMarginModeAndParams("fetchBalance", marketTypeQuery);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginGetAccountSummary";
        }
        object response = await this.callAsync(method, query);
        // spot
        //     {
        //         "id": 11,
        //         "method": "private/get-account-summary",
        //         "code": 0,
        //         "result": {
        //             "accounts": [
        //                 {
        //                     "balance": 99999999.905000000000000000,
        //                     "available": 99999996.905000000000000000,
        //                     "order": 3.000000000000000000,
        //                     "stake": 0,
        //                     "currency": "CRO"
        //                 }
        //             ]
        //         }
        //     }
        //
        // margin
        //     {
        //         "id": 1656529728178,
        //         "method": "private/margin/get-account-summary",
        //         "code": 0,
        //         "result": {
        //             "accounts": [
        //                 {
        //                     "balance": 0,
        //                     "available": 0,
        //                     "order": 0,
        //                     "borrowed": 0,
        //                     "position": 0,
        //                     "positionHomeCurrency": 0,
        //                     "positionBtc": 0,
        //                     "lastPriceHomeCurrency": 20111.38,
        //                     "lastPriceBtc": 1,
        //                     "currency": "BTC",
        //                     "accrued_interest": 0,
        //                     "liquidation_price": 0
        //                 },
        //             ],
        //             "is_liquidating": false,
        //             "total_balance": 16,
        //             "total_balance_btc": 0.00079556,
        //             "equity_value": 16,
        //             "equity_value_btc": 0.00079556,
        //             "total_borrowed": 0,
        //             "total_borrowed_btc": 0,
        //             "total_accrued_interest": 0,
        //             "total_accrued_interest_btc": 0,
        //             "margin_score": "GOOD",
        //             "currency": "USDT"
        //         }
        //     }
        //
        // swap
        //     {
        //       "id" : 1641025392400,
        //       "method" : "private/user-balance",
        //       "code" : 0,
        //       "result" : {
        //         "data" : [ {
        //           "total_available_balance" : "109.56000000",
        //           "total_margin_balance" : "109.56000000",
        //           "total_initial_margin" : "0.00000000",
        //           "total_maintenance_margin" : "0.00000000",
        //           "total_position_cost" : "0.00000000",
        //           "total_cash_balance" : "109.56000000",
        //           "total_collateral_value" : "109.56000000",
        //           "total_session_unrealized_pnl" : "0.00000000",
        //           "instrument_name" : "USD_Stable_Coin",
        //           "total_session_realized_pnl" : "0.00000000",
        //           "position_balances" : [ {
        //             "quantity" : "109.56000000",
        //             "collateral_weight" : "1.000000",
        //             "collateral_amount" : "109.56000000",
        //             "market_value" : "109.56000000",
        //             "max_withdrawal_balance" : "109.56000000",
        //             "instrument_name" : "USD_Stable_Coin"
        //           } ],
        //           "total_effective_leverage" : "0.000000",
        //           "position_limit" : "3000000.00000000",
        //           "used_position_limit" : "0.00000000",
        //           "is_liquidating" : false
        //         } ]
        //       }
        //     }
        //
        object parser = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "parseSpotBalance" },
            { "margin", "parseSpotBalance" },
            { "future", "parseSwapBalance" },
            { "swap", "parseSwapBalance" },
        });
        return this.callAsync(parser, response);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string|undefined} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
        }
        object request = new Dictionary<string, object>() {};
        var marketTypemarketTypeQueryVariable = this.handleMarketTypeAndParams("fetchOrder", market, parameters);
        var marketType = ((List<object>) marketTypemarketTypeQueryVariable)[0];
        var marketTypeQuery = ((List<object>) marketTypemarketTypeQueryVariable)[1];
        var marginModequeryVariable = this.customHandleMarginModeAndParams("fetchOrder", marketTypeQuery);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(isTrue(isTrue((isEqual(marketType, "spot"))) || isTrue((isEqual(marketType, "margin")))) || isTrue((!isEqual(marginMode, null)))))
        {
            ((Dictionary<string, object>)request)["order_id"] = ((object)id).ToString();
        } else
        {
            ((Dictionary<string, object>)request)["order_id"] = parseInt(id);
        }
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PrivatePostPrivateGetOrderDetail" },
            { "margin", "v2PrivatePostPrivateMarginGetOrderDetail" },
            { "future", "derivativesPrivatePostPrivateGetOrderDetail" },
            { "swap", "derivativesPrivatePostPrivateGetOrderDetail" },
        });
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginGetOrderDetail";
        }
        object response = await this.callAsync(method, this.extend(request, query));
        // {
        //     "id": 11,
        //     "method": "private/get-order-detail",
        //     "code": 0,
        //     "result": {
        //       "trade_list": [
        //         {
        //           "side": "BUY",
        //           "instrument_name": "ETH_CRO",
        //           "fee": 0.007,
        //           "trade_id": "371303044218155296",
        //           "create_time": 1588902493045,
        //           "traded_price": 7,
        //           "traded_quantity": 7,
        //           "fee_currency": "CRO",
        //           "order_id": "371302913889488619"
        //         }
        //       ],
        //       "order_info": {
        //         "status": "FILLED",
        //         "side": "BUY",
        //         "order_id": "371302913889488619",
        //         "client_oid": "9_yMYJDNEeqHxLqtD_2j3g",
        //         "create_time": 1588902489144,
        //         "update_time": 1588902493024,
        //         "type": "LIMIT",
        //         "instrument_name": "ETH_CRO",
        //         "cumulative_quantity": 7,
        //         "cumulative_value": 7,
        //         "avg_price": 7,
        //         "fee_currency": "CRO",
        //         "time_in_force": "GOOD_TILL_CANCEL",
        //         "exec_inst": "POST_ONLY"
        //       }
        //     }
        // }
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object order = this.safeValue(result, "order_info", result);
        return this.parseOrder(order, market);
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object uppercaseType = ((string)type).ToUpper();
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
            { "side", ((string)side).ToUpper() },
            { "type", uppercaseType },
            { "quantity", this.amountToPrecision(symbol, amount) },
        };
        if (isTrue(isTrue((isEqual(uppercaseType, "LIMIT"))) || isTrue((isEqual(uppercaseType, "STOP_LIMIT")))))
        {
            ((Dictionary<string, object>)request)["price"] = this.priceToPrecision(symbol, price);
        }
        object postOnly = this.safeValue(parameters, "postOnly", false);
        if (isTrue(postOnly))
        {
            ((Dictionary<string, object>)request)["exec_inst"] = "POST_ONLY";
            parameters = this.omit(parameters, new List<object>() {"postOnly"});
        }
        var marketTypemarketTypeQueryVariable = this.handleMarketTypeAndParams("createOrder", market, parameters);
        var marketType = ((List<object>) marketTypemarketTypeQueryVariable)[0];
        var marketTypeQuery = ((List<object>) marketTypemarketTypeQueryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PrivatePostPrivateCreateOrder" },
            { "margin", "v2PrivatePostPrivateMarginCreateOrder" },
            { "future", "derivativesPrivatePostPrivateCreateOrder" },
            { "swap", "derivativesPrivatePostPrivateCreateOrder" },
        });
        var marginModequeryVariable = this.customHandleMarginModeAndParams("createOrder", marketTypeQuery);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginCreateOrder";
        }
        object response = await this.callAsync(method, this.extend(request, query));
        // {
        //     "id": 11,
        //     "method": "private/create-order",
        //     "result": {
        //       "order_id": "337843775021233500",
        //       "client_oid": "my_order_0002"
        //     }
        // }
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        return this.parseOrder(result, market);
    }

    public async override Task<object> cancelAllOrders(object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#cancelAllOrders
        * @description cancel all open orders
        * @param {string|undefined} symbol unified market symbol, only orders in the market of this symbol are cancelled when symbol is not undefined
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
        }
        object request = new Dictionary<string, object>() {};
        var marketTypemarketTypeQueryVariable = this.handleMarketTypeAndParams("cancelAllOrders", market, parameters);
        var marketType = ((List<object>) marketTypemarketTypeQueryVariable)[0];
        var marketTypeQuery = ((List<object>) marketTypemarketTypeQueryVariable)[1];
        var marginModequeryVariable = this.customHandleMarginModeAndParams("cancelAllOrders", marketTypeQuery);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(isTrue(isTrue((isEqual(marketType, "spot"))) || isTrue((isEqual(marketType, "margin")))) || isTrue((!isEqual(marginMode, null)))))
        {
            if (isTrue(isEqual(symbol, null)))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " cancelAllOrders() requires a symbol argument for "), marketType), " orders")) ;
            }
            ((Dictionary<string, object>)request)["instrument_name"] = getValue(market, "id");
        }
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PrivatePostPrivateCancelAllOrders" },
            { "margin", "v2PrivatePostPrivateMarginCancelAllOrders" },
            { "future", "derivativesPrivatePostPrivateCancelAllOrders" },
            { "swap", "derivativesPrivatePostPrivateCancelAllOrders" },
        });
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginCancelAllOrders";
        }
        return await this.callAsync(method, this.extend(request, query));
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string|undefined} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
        }
        object request = new Dictionary<string, object>() {};
        var marketTypemarketTypeQueryVariable = this.handleMarketTypeAndParams("cancelOrder", market, parameters);
        var marketType = ((List<object>) marketTypemarketTypeQueryVariable)[0];
        var marketTypeQuery = ((List<object>) marketTypemarketTypeQueryVariable)[1];
        var marginModequeryVariable = this.customHandleMarginModeAndParams("cancelOrder", marketTypeQuery);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(isTrue(isTrue((isEqual(marketType, "spot"))) || isTrue((isEqual(marketType, "margin")))) || isTrue((!isEqual(marginMode, null)))))
        {
            if (isTrue(isEqual(symbol, null)))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " cancelOrder() requires a symbol argument for "), marketType), " orders")) ;
            }
            ((Dictionary<string, object>)request)["instrument_name"] = getValue(market, "id");
            ((Dictionary<string, object>)request)["order_id"] = ((object)id).ToString();
        } else
        {
            ((Dictionary<string, object>)request)["order_id"] = parseInt(id);
        }
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PrivatePostPrivateCancelOrder" },
            { "margin", "v2PrivatePostPrivateMarginCancelOrder" },
            { "future", "derivativesPrivatePostPrivateCancelOrder" },
            { "swap", "derivativesPrivatePostPrivateCancelOrder" },
        });
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginCancelOrder";
        }
        object response = await this.callAsync(method, this.extend(request, query));
        object result = this.safeValue(response, "result", response);
        return this.parseOrder(result);
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = null;
        object request = new Dictionary<string, object>() {};
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["instrument_name"] = getValue(market, "id");
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["page_size"] = limit;
        }
        var marketTypemarketTypeQueryVariable = this.handleMarketTypeAndParams("fetchOpenOrders", market, parameters);
        var marketType = ((List<object>) marketTypemarketTypeQueryVariable)[0];
        var marketTypeQuery = ((List<object>) marketTypemarketTypeQueryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PrivatePostPrivateGetOpenOrders" },
            { "margin", "v2PrivatePostPrivateMarginGetOpenOrders" },
            { "future", "derivativesPrivatePostPrivateGetOpenOrders" },
            { "swap", "derivativesPrivatePostPrivateGetOpenOrders" },
        });
        var marginModequeryVariable = this.customHandleMarginModeAndParams("fetchOpenOrders", marketTypeQuery);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginGetOpenOrders";
        }
        object response = await this.callAsync(method, this.extend(request, query));
        // {
        //     "id": 11,
        //     "method": "private/get-open-orders",
        //     "code": 0,
        //     "result": {
        //       "count": 1177,
        //       "order_list": [
        //         {
        //           "status": "ACTIVE",
        //           "side": "BUY",
        //           "price": 1,
        //           "quantity": 1,
        //           "order_id": "366543374673423753",
        //           "client_oid": "my_order_0002",
        //           "create_time": 1588760643829,
        //           "update_time": 1588760644292,
        //           "type": "LIMIT",
        //           "instrument_name": "ETH_CRO",
        //           "cumulative_quantity": 0,
        //           "cumulative_value": 0,
        //           "avg_price": 0,
        //           "fee_currency": "CRO",
        //           "time_in_force": "GOOD_TILL_CANCEL"
        //         },
        //         {
        //           "status": "ACTIVE",
        //           "side": "BUY",
        //           "price": 1,
        //           "quantity": 1,
        //           "order_id": "366455245775097673",
        //           "client_oid": "my_order_0002",
        //           "create_time": 1588758017375,
        //           "update_time": 1588758017411,
        //           "type": "LIMIT",
        //           "instrument_name": "ETH_CRO",
        //           "cumulative_quantity": 0,
        //           "cumulative_value": 0,
        //           "avg_price": 0,
        //           "fee_currency": "CRO",
        //           "time_in_force": "GOOD_TILL_CANCEL"
        //         }
        //       ]
        //     }
        // }
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object resultList = this.safeValue2(data, "order_list", "data", new List<object>() {});
        return this.parseOrders(resultList, market, since, limit);
    }

    public async override Task<object> fetchMyTrades(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchMyTrades
        * @description fetch all trades made by the user
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch trades for
        * @param {int|undefined} limit the maximum number of trades structures to retrieve
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["instrument_name"] = getValue(market, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            // maximum date range is one day
            ((Dictionary<string, object>)request)["start_ts"] = since;
            object endTimestamp = this.sum(since, multiply(multiply(multiply(24, 60), 60), 1000));
            ((Dictionary<string, object>)request)["end_ts"] = endTimestamp;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["page_size"] = limit;
        }
        var marketTypemarketTypeQueryVariable = this.handleMarketTypeAndParams("fetchMyTrades", market, parameters);
        var marketType = ((List<object>) marketTypemarketTypeQueryVariable)[0];
        var marketTypeQuery = ((List<object>) marketTypemarketTypeQueryVariable)[1];
        object method = this.getSupportedMapping(marketType, new Dictionary<string, object>() {
            { "spot", "v2PrivatePostPrivateGetTrades" },
            { "margin", "v2PrivatePostPrivateMarginGetTrades" },
            { "future", "derivativesPrivatePostPrivateGetTrades" },
            { "swap", "derivativesPrivatePostPrivateGetTrades" },
        });
        var marginModequeryVariable = this.customHandleMarginModeAndParams("fetchMyTrades", marketTypeQuery);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginGetTrades";
        }
        object response = await this.callAsync(method, this.extend(request, query));
        // {
        //     "id": 11,
        //     "method": "private/get-trades",
        //     "code": 0,
        //     "result": {
        //       "trade_list": [
        //         {
        //           "side": "SELL",
        //           "instrument_name": "ETH_CRO",
        //           "fee": 0.014,
        //           "trade_id": "367107655537806900",
        //           "create_time": 1588777459755,
        //           "traded_price": 7,
        //           "traded_quantity": 1,
        //           "fee_currency": "CRO",
        //           "order_id": "367107623521528450"
        //         }
        //       ]
        //     }
        // }
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object resultList = this.safeValue2(data, "trade_list", "data", new List<object>() {});
        return this.parseTrades(resultList, market, since, limit);
    }

    public virtual object parseAddress(object addressString)
    {
        object address = null;
        object tag = null;
        object rawTag = null;
        if (isTrue(isGreaterThan(getIndexOf(addressString, "?"), 0)))
        {
                        var addressrawTagVariable = ((string)addressString).Split((string)"?").ToList<object>();
            address = ((List<object>)addressrawTagVariable)[0];
            rawTag = ((List<object>)addressrawTagVariable)[1];
            object splitted = ((string)rawTag).Split((string)"=").ToList<object>();
            tag = getValue(splitted, 1);
        } else
        {
            address = addressString;
        }
        return new List<object>() {address, tag};
    }

    public async override Task<object> withdraw(object code, object amount, object address, object tag = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#withdraw
        * @description make a withdrawal
        * @param {string} code unified currency code
        * @param {float} amount the amount to withdraw
        * @param {string} address the address to withdraw to
        * @param {string|undefined} tag
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
                var tagparametersVariable = this.handleWithdrawTagAndParams(tag, parameters);
        tag = ((List<object>)tagparametersVariable)[0];
        parameters = ((List<object>)tagparametersVariable)[1];
        await this.loadMarkets();
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "currency", getValue(currency, "id") },
            { "amount", amount },
            { "address", address },
        };
        if (isTrue(!isEqual(tag, null)))
        {
            ((Dictionary<string, object>)request)["address_tag"] = tag;
        }
        object response = await this.v2PrivatePostPrivateCreateWithdrawal(this.extend(request, parameters));
        //
        //    {
        //        "id":-1,
        //        "method":"private/create-withdrawal",
        //        "code":0,
        //        "result": {
        //            "id": 2220,
        //            "amount": 1,
        //            "fee": 0.0004,
        //            "symbol": "BTC",
        //            "address": "2NBqqD5GRJ8wHy1PYyCXTe9ke5226FhavBf",
        //            "client_wid": "my_withdrawal_002",
        //            "create_time":1607063412000
        //        }
        //     }
        //
        object result = this.safeValue(response, "result");
        return this.parseTransaction(result, currency);
    }

    public async virtual Task<object> fetchDepositAddressesByNetwork(object code, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchDepositAddressesByNetwork
        * @description fetch a dictionary of addresses for a currency, indexed by network
        * @param {string} code unified currency code of the currency for the deposit address
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a dictionary of [address structures]{@link https://docs.ccxt.com/#/?id=address-structure} indexed by the network
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "currency", getValue(currency, "id") },
        };
        object response = await this.v2PrivatePostPrivateGetDepositAddress(this.extend(request, parameters));
        // {
        //     "id": 11,
        //     "method": "private/get-deposit-address",
        //     "code": 0,
        //     "result": {
        //          "deposit_address_list": [
        //              {
        //                  "currency": "CRO",
        //                  "create_time": 1615886328000,
        //                  "id": "12345",
        //                  "address": "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
        //                  "status": "1",
        //                  "network": "CRO"
        //              },
        //              {
        //                  "currency": "CRO",
        //                  "create_time": 1615886332000,
        //                  "id": "12346",
        //                  "address": "yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy",
        //                  "status": "1",
        //                  "network": "ETH"
        //              }
        //          ]
        //    }
        // }
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object addresses = this.safeValue(data, "deposit_address_list", new List<object>() {});
        object addressesLength = getArrayLength(addresses);
        if (isTrue(isEqual(addressesLength, 0)))
        {
            throw new ExchangeError ((string)add(this.id, " fetchDepositAddressesByNetwork() generating address...")) ;
        }
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, addressesLength); postFixIncrement(ref i))
        {
            object value = this.safeValue(addresses, i);
            object addressString = this.safeString(value, "address");
            object currencyId = this.safeString(value, "currency");
            object responseCode = this.safeCurrencyCode(currencyId);
            var addresstagVariable = this.parseAddress(addressString);
            var address = ((List<object>) addresstagVariable)[0];
            var tag = ((List<object>) addresstagVariable)[1];
            this.checkAddress(address);
            object networkId = this.safeString(value, "network");
            object network = this.safeNetwork(networkId);
            ((Dictionary<string, object>)result)[(string)network] = new Dictionary<string, object>() {
                { "info", value },
                { "currency", responseCode },
                { "address", address },
                { "tag", tag },
                { "network", network },
            };
        }
        return result;
    }

    public async override Task<object> fetchDepositAddress(object code, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchDepositAddress
        * @description fetch the deposit address for a currency associated with this account
        * @param {string} code unified currency code
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object network = this.safeStringUpper(parameters, "network");
        parameters = this.omit(parameters, new List<object>() {"network"});
        object depositAddresses = await this.fetchDepositAddressesByNetwork(code, parameters);
        if (isTrue(((Dictionary<string,object>)depositAddresses).ContainsKey(toStringOrNull(network))))
        {
            return getValue(depositAddresses, network);
        } else
        {
            object keys = new List<string>(((Dictionary<string,object>)depositAddresses).Keys);
            return getValue(depositAddresses, getValue(keys, 0));
        }
    }

    public virtual object safeNetwork(object networkId)
    {
        object networksById = new Dictionary<string, object>() {
            { "BTC", "BTC" },
            { "ETH", "ETH" },
            { "SOL", "SOL" },
            { "BNB", "BNB" },
            { "CRONOS", "CRONOS" },
            { "MATIC", "MATIC" },
            { "OP", "OP" },
        };
        return this.safeString(networksById, networkId, networkId);
    }

    public async override Task<object> fetchDeposits(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchDeposits
        * @description fetch all deposits made to an account
        * @param {string|undefined} code unified currency code
        * @param {int|undefined} since the earliest time in ms to fetch deposits for
        * @param {int|undefined} limit the maximum number of deposits structures to retrieve
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[object]} a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = null;
        object request = new Dictionary<string, object>() {};
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["currency"] = getValue(currency, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            // 90 days date range
            ((Dictionary<string, object>)request)["start_ts"] = since;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["page_size"] = limit;
        }
        object response = await this.v2PrivatePostPrivateGetDepositHistory(this.extend(request, parameters));
        // {
        //     "id": 11,
        //     "method": "private/get-deposit-history",
        //     "code": 0,
        //     "result": {
        //       "deposit_list": [
        //         {
        //           "currency": "XRP",
        //           "fee": 1.0,
        //           "create_time": 1607063412000,
        //           "id": "2220",
        //           "update_time": 1607063460000,
        //           "amount": 100,
        //           "address": "2NBqqD5GRJ8wHy1PYyCXTe9ke5226FhavBf?1234567890",
        //           "status": "1"
        //         }
        //       ]
        //     }
        // }
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object depositList = this.safeValue(data, "deposit_list", new List<object>() {});
        return this.parseTransactions(depositList, currency, since, limit);
    }

    public async override Task<object> fetchWithdrawals(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchWithdrawals
        * @description fetch all withdrawals made from an account
        * @param {string|undefined} code unified currency code
        * @param {int|undefined} since the earliest time in ms to fetch withdrawals for
        * @param {int|undefined} limit the maximum number of withdrawals structures to retrieve
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[object]} a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = null;
        object request = new Dictionary<string, object>() {};
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["currency"] = getValue(currency, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            // 90 days date range
            ((Dictionary<string, object>)request)["start_ts"] = since;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["page_size"] = limit;
        }
        object response = await this.v2PrivatePostPrivateGetWithdrawalHistory(this.extend(request, parameters));
        //
        //     {
        //       id: 1640704829096,
        //       method: 'private/get-withdrawal-history',
        //       code: 0,
        //       result: {
        //         withdrawal_list: [
        //           {
        //             currency: 'DOGE',
        //             client_wid: '',
        //             fee: 50,
        //             create_time: 1640425168000,
        //             id: '3180557',
        //             update_time: 1640425168000,
        //             amount: 1102.64092,
        //             address: 'DDrGGqmp5Ddo1QH9tUvDfoL4u4rqys5975',
        //             status: '5',
        //             txid: 'ce23e9e21b6c38eef953070a05110e6dca2fd2bcc76d3381000547b9ff5290b2/0'
        //           }
        //         ]
        //       }
        //     }
        //
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object withdrawalList = this.safeValue(data, "withdrawal_list", new List<object>() {});
        return this.parseTransactions(withdrawalList, currency, since, limit);
    }

    public async override Task<object> transfer(object code, object amount, object fromAccount, object toAccount, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#transfer
        * @description transfer currency internally between wallets on the same account
        * @param {string} code unified currency code
        * @param {float} amount amount to transfer
        * @param {string} fromAccount account to transfer from
        * @param {string} toAccount account to transfer to
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a [transfer structure]{@link https://docs.ccxt.com/#/?id=transfer-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = this.currency(code);
        fromAccount = ((string)fromAccount).ToLower();
        toAccount = ((string)toAccount).ToLower();
        object accountsById = this.safeValue(this.options, "accountsById", new Dictionary<string, object>() {});
        object fromId = this.safeString(accountsById, fromAccount, fromAccount);
        object toId = this.safeString(accountsById, toAccount, toAccount);
        object request = new Dictionary<string, object>() {
            { "currency", getValue(currency, "id") },
            { "amount", parseFloat(amount) },
            { "from", fromId },
            { "to", toId },
        };
        object method = "v2PrivatePostPrivateDerivTransfer";
        if (isTrue(isTrue((isEqual(fromAccount, "margin"))) || isTrue((isEqual(toAccount, "margin")))))
        {
            method = "v2PrivatePostPrivateMarginTransfer";
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        //     {
        //         "id": 11,
        //         "method": "private/deriv/transfer",
        //         "code": 0
        //     }
        //
        return this.parseTransfer(response, currency);
    }

    public async virtual Task<object> fetchTransfers(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchTransfers
        * @description fetch a history of internal transfers made on an account
        * @param {string|undefined} code unified currency code of the currency transferred
        * @param {int|undefined} since the earliest time in ms to fetch transfers for
        * @param {int|undefined} limit the maximum number of  transfers structures to retrieve
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {[object]} a list of [transfer structures]{@link https://docs.ccxt.com/#/?id=transfer-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (!isTrue((((Dictionary<string,object>)parameters).ContainsKey(toStringOrNull("direction")))))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchTransfers() requires a direction param to be either \"IN\" or \"OUT\"")) ;
        }
        await this.loadMarkets();
        object currency = null;
        object request = new Dictionary<string, object>() {
            { "direction", "OUT" },
        };
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["currency"] = getValue(currency, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["start_ts"] = since;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["page_size"] = limit;
        }
        object method = "v2PrivatePostPrivateDerivGetTransferHistory";
        var marginModequeryVariable = this.customHandleMarginModeAndParams("fetchTransfers", parameters);
        var marginMode = ((List<object>) marginModequeryVariable)[0];
        var query = ((List<object>) marginModequeryVariable)[1];
        if (isTrue(!isEqual(marginMode, null)))
        {
            method = "v2PrivatePostPrivateMarginGetTransferHistory";
        }
        object response = await this.callAsync(method, this.extend(request, query));
        //
        //     {
        //       id: '1641032709328',
        //       method: 'private/deriv/get-transfer-history',
        //       code: '0',
        //       result: {
        //         transfer_list: [
        //           {
        //             direction: 'IN',
        //             time: '1641025185223',
        //             amount: '109.56',
        //             status: 'COMPLETED',
        //             information: 'From Spot Wallet',
        //             currency: 'USDC'
        //           }
        //         ]
        //       }
        //     }
        //
        object transfer = new List<object>() {};
        ((List<object>)transfer).Add(new Dictionary<string, object>() {
            { "response", response },
        });
        return this.parseTransfers(transfer, currency, since, limit, parameters);
    }

    public virtual object parseTransferStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "COMPLETED", "ok" },
            { "PROCESSING", "pending" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object parseTransfer(object transfer, object currency = null)
    {
        //
        //   {
        //     response: {
        //       id: '1641032709328',
        //       method: 'private/deriv/get-transfer-history',
        //       code: '0',
        //       result: {
        //         transfer_list: [
        //           {
        //             direction: 'IN',
        //             time: '1641025185223',
        //             amount: '109.56',
        //             status: 'COMPLETED',
        //             information: 'From Spot Wallet',
        //             currency: 'USDC'
        //           }
        //         ]
        //       }
        //     }
        //   }
        //
        object response = this.safeValue(transfer, "response", new Dictionary<string, object>() {});
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object transferList = this.safeValue(result, "transfer_list", new List<object>() {});
        object timestamp = null;
        object amount = null;
        object code = null;
        object information = null;
        object status = null;
        for (object i = 0; isLessThan(i, getArrayLength(transferList)); postFixIncrement(ref i))
        {
            object entry = getValue(transferList, i);
            timestamp = this.safeInteger(entry, "time");
            amount = this.safeNumber(entry, "amount");
            object currencyId = this.safeString(entry, "currency");
            code = this.safeCurrencyCode(currencyId);
            information = this.safeString(entry, "information");
            object rawStatus = this.safeString(entry, "status");
            status = this.parseTransferStatus(rawStatus);
        }
        object fromAccount = null;
        object toAccount = null;
        if (isTrue(!isEqual(information, null)))
        {
            object parts = ((string)information).Split((string)" ").ToList<object>();
            object direction = this.safeStringLower(parts, 0);
            object method = this.safeString(response, "method");
            if (isTrue(isEqual(direction, "from")))
            {
                fromAccount = this.safeStringLower(parts, 1);
                if (isTrue(isEqual(method, "private/margin/get-transfer-history")))
                {
                    toAccount = "margin";
                } else
                {
                    toAccount = "derivative";
                }
            } else if (isTrue(isEqual(direction, "to")))
            {
                toAccount = this.safeStringLower(parts, 1);
                if (isTrue(isEqual(method, "private/margin/get-transfer-history")))
                {
                    fromAccount = "margin";
                } else
                {
                    fromAccount = "derivative";
                }
            }
        }
        return new Dictionary<string, object>() {
            { "info", transferList },
            { "id", this.safeString(response, "id") },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "currency", code },
            { "amount", amount },
            { "fromAccount", fromAccount },
            { "toAccount", toAccount },
            { "status", status },
        };
    }

    public override object parseTicker(object ticker, object market = null)
    {
        // {
        //     "i":"CRO_BTC",
        //     "b":0.00000890,
        //     "k":0.00001179,
        //     "a":0.00001042,
        //     "t":1591770793901,
        //     "v":14905879.59,
        //     "h":0.00,
        //     "l":0.00,
        //     "c":0.00
        // }
        object timestamp = this.safeInteger(ticker, "t");
        object marketId = this.safeString(ticker, "i");
        market = this.safeMarket(marketId, market, "_");
        object symbol = getValue(market, "symbol");
        object last = this.safeString(ticker, "a");
        object relativeChange = this.safeString(ticker, "c");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", this.safeString(ticker, "h") },
            { "low", this.safeString(ticker, "l") },
            { "bid", this.safeString(ticker, "b") },
            { "bidVolume", null },
            { "ask", this.safeString(ticker, "k") },
            { "askVolume", null },
            { "vwap", null },
            { "open", null },
            { "close", last },
            { "last", last },
            { "previousClose", null },
            { "change", relativeChange },
            { "percentage", null },
            { "average", null },
            { "baseVolume", this.safeString(ticker, "v") },
            { "quoteVolume", null },
            { "info", ticker },
        }, market);
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        // public/get-trades
        //
        // {"dataTime":1591710781947,"d":465533583799589409,"s":"BUY","p":2.96,"q":16.0,"t":1591710781946,"i":"ICX_CRO"},
        //
        // private/get-trades
        //
        // {
        //     "side": "SELL",
        //     "instrument_name": "ETH_CRO",
        //     "fee": 0.014,
        //     "trade_id": "367107655537806900",
        //     "create_time": 1588777459755,
        //     "traded_price": 7,
        //     "traded_quantity": 1,
        //     "fee_currency": "CRO",
        //     "order_id": "367107623521528450"
        // }
        object timestamp = this.safeInteger2(trade, "t", "create_time");
        object marketId = this.safeString2(trade, "i", "instrument_name");
        market = this.safeMarket(marketId, market, "_");
        object symbol = getValue(market, "symbol");
        object price = this.safeString2(trade, "p", "traded_price");
        object amount = this.safeString2(trade, "q", "traded_quantity");
        object side = this.safeString2(trade, "s", "side");
        if (isTrue(!isEqual(side, null)))
        {
            side = ((string)side).ToLower();
        }
        object id = this.safeString2(trade, "d", "trade_id");
        object takerOrMaker = this.safeStringLower2(trade, "liquidity_indicator", "taker_side");
        object order = this.safeString(trade, "order_id");
        object fee = null;
        object feeCost = this.safeString2(trade, "fee", "fees");
        if (isTrue(!isEqual(feeCost, null)))
        {
            object contract = this.safeValue(market, "contract", false);
            if (isTrue(contract))
            {
                feeCost = Precise.stringNeg(feeCost);
            }
            object feeCurrency = null;
            if (isTrue(getValue(market, "spot")))
            {
                feeCurrency = this.safeString(trade, "fee_currency");
            } else if (isTrue(getValue(market, "linear")))
            {
                feeCurrency = getValue(market, "quote");
            }
            fee = new Dictionary<string, object>() {
                { "currency", feeCurrency },
                { "cost", feeCost },
            };
        }
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "id", id },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", symbol },
            { "side", side },
            { "price", price },
            { "amount", amount },
            { "cost", null },
            { "order", order },
            { "takerOrMaker", takerOrMaker },
            { "type", null },
            { "fee", fee },
        }, market);
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //      {"t":1596944700000,"o":11752.38,"h":11754.77,"l":11746.65,"c":11753.64,"v":3.694583}
        return new List<object> {this.safeInteger(ohlcv, "t"), this.safeNumber(ohlcv, "o"), this.safeNumber(ohlcv, "h"), this.safeNumber(ohlcv, "l"), this.safeNumber(ohlcv, "c"), this.safeNumber(ohlcv, "v")};
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "ACTIVE", "open" },
            { "CANCELED", "canceled" },
            { "FILLED", "closed" },
            { "REJECTED", "rejected" },
            { "EXPIRED", "expired" },
        };
        return this.safeString(statuses, status, status);
    }

    public virtual object parseTimeInForce(object timeInForce)
    {
        object timeInForces = new Dictionary<string, object>() {
            { "GOOD_TILL_CANCEL", "GTC" },
            { "IMMEDIATE_OR_CANCEL", "IOC" },
            { "FILL_OR_KILL", "FOK" },
        };
        return this.safeString(timeInForces, timeInForce, timeInForce);
    }

    public override object parseOrder(object order, object market = null)
    {
        //       {
        //         "status": "FILLED",
        //         "side": "BUY",
        //         "order_id": "371302913889488619",
        //         "client_oid": "9_yMYJDNEeqHxLqtD_2j3g",
        //         "create_time": 1588902489144,
        //         "update_time": 1588902493024,
        //         "type": "LIMIT",
        //         "instrument_name": "ETH_CRO",
        //         "cumulative_quantity": 7,
        //         "cumulative_value": 7,
        //         "avg_price": 7,
        //         "fee_currency": "CRO",
        //         "time_in_force": "GOOD_TILL_CANCEL",
        //         "exec_inst": "POST_ONLY"
        //       }
        //
        //     {
        //       id: 1641026373106,
        //       method: 'private/get-order-history',
        //       code: 0,
        //       result: {
        //         data: [
        //           {
        //             account_id: '85ff689a-7508-4b96-aa79-dc0545d6e637',
        //             order_id: 13191401932,
        //             client_oid: '1641025941461',
        //             order_type: 'LIMIT',
        //             time_in_force: 'GOOD_TILL_CANCEL',
        //             side: 'BUY',
        //             exec_inst: [],
        //             quantity: '0.0001',
        //             limit_price: '48000.0',
        //             order_value: '4.80000000',
        //             maker_fee_rate: '0.00050',
        //             taker_fee_rate: '0.00070',
        //             avg_price: '47253.5',
        //             trigger_price: '0.0',
        //             ref_price_type: 'NULL_VAL',
        //             cumulative_quantity: '0.0001',
        //             cumulative_value: '4.72535000',
        //             cumulative_fee: '0.00330775',
        //             status: 'FILLED',
        //             update_user_id: 'ce075bef-b600-4277-bd6e-ff9007251e63',
        //             order_date: '2022-01-01',
        //             instrument_name: 'BTCUSD-PERP',
        //             fee_instrument_name: 'USD_Stable_Coin',
        //             create_time: 1641025941827,
        //             create_time_ns: '1641025941827994756',
        //             update_time: 1641025941827
        //           }
        //         ]
        //       }
        //     }
        //
        object created = this.safeInteger(order, "create_time");
        object updated = this.safeInteger(order, "update_time");
        object marketId = this.safeString(order, "instrument_name");
        object symbol = this.safeSymbol(marketId, market);
        object amount = this.safeString(order, "quantity");
        object filled = this.safeString(order, "cumulative_quantity");
        object status = this.parseOrderStatus(this.safeString(order, "status"));
        object id = this.safeString(order, "order_id");
        object clientOrderId = this.safeString(order, "client_oid");
        object price = this.safeString2(order, "price", "limit_price");
        object average = this.safeString(order, "avg_price");
        object type = this.safeStringLower2(order, "type", "order_type");
        object side = this.safeStringLower(order, "side");
        object timeInForce = this.parseTimeInForce(this.safeString(order, "time_in_force"));
        object execInst = this.safeString(order, "exec_inst");
        object postOnly = null;
        if (isTrue(!isEqual(execInst, null)))
        {
            postOnly = (isEqual(execInst, "POST_ONLY"));
        }
        object cost = this.safeString(order, "cumulative_value");
        object feeCost = this.safeString(order, "cumulative_fee");
        object fee = null;
        if (isTrue(!isEqual(feeCost, null)))
        {
            object feeCurrency = this.safeString(order, "fee_instrument_name");
            fee = new Dictionary<string, object>() {
                { "cost", feeCost },
                { "currency", this.safeCurrencyCode(feeCurrency) },
            };
        }
        return this.safeOrder(new Dictionary<string, object>() {
            { "info", order },
            { "id", id },
            { "clientOrderId", clientOrderId },
            { "timestamp", created },
            { "datetime", this.iso8601(created) },
            { "lastTradeTimestamp", updated },
            { "status", status },
            { "symbol", symbol },
            { "type", type },
            { "timeInForce", timeInForce },
            { "postOnly", postOnly },
            { "side", side },
            { "price", price },
            { "amount", amount },
            { "filled", filled },
            { "remaining", null },
            { "cost", cost },
            { "fee", fee },
            { "average", average },
            { "trades", new List<object>() {} },
        }, market);
    }

    public virtual object parseDepositStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "0", "pending" },
            { "1", "ok" },
            { "2", "failed" },
            { "3", "pending" },
        };
        return this.safeString(statuses, status, status);
    }

    public virtual object parseWithdrawalStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "0", "pending" },
            { "1", "pending" },
            { "2", "failed" },
            { "3", "pending" },
            { "4", "failed" },
            { "5", "ok" },
            { "6", "canceled" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object parseTransaction(object transaction, object currency = null)
    {
        //
        // fetchDeposits
        //
        //     {
        //         "currency": "XRP",
        //         "fee": 1.0,
        //         "create_time": 1607063412000,
        //         "id": "2220",
        //         "update_time": 1607063460000,
        //         "amount": 100,
        //         "address": "2NBqqD5GRJ8wHy1PYyCXTe9ke5226FhavBf?1234567890",
        //         "status": "1"
        //     }
        //
        // fetchWithdrawals
        //
        //     {
        //         "currency": "XRP",
        //         "client_wid": "my_withdrawal_002",
        //         "fee": 1.0,
        //         "create_time": 1607063412000,
        //         "id": "2220",
        //         "update_time": 1607063460000,
        //         "amount": 100,
        //         "address": "2NBqqD5GRJ8wHy1PYyCXTe9ke5226FhavBf?1234567890",
        //         "status": "1"
        //     }
        //
        // withdraw
        //
        //     {
        //         "id": 2220,
        //         "amount": 1,
        //         "fee": 0.0004,
        //         "symbol": "BTC",
        //         "address": "2NBqqD5GRJ8wHy1PYyCXTe9ke5226FhavBf",
        //         "client_wid": "my_withdrawal_002",
        //         "create_time":1607063412000
        //     }
        //
        object type = null;
        object rawStatus = this.safeString(transaction, "status");
        object status = null;
        if (isTrue(((Dictionary<string,object>)transaction).ContainsKey(toStringOrNull("client_wid"))))
        {
            type = "withdrawal";
            status = this.parseWithdrawalStatus(rawStatus);
        } else
        {
            type = "deposit";
            status = this.parseDepositStatus(rawStatus);
        }
        object id = this.safeString(transaction, "id");
        object addressString = this.safeString(transaction, "address");
        var addresstagVariable = this.parseAddress(addressString);
        var address = ((List<object>) addresstagVariable)[0];
        var tag = ((List<object>) addresstagVariable)[1];
        object currencyId = this.safeString(transaction, "currency");
        object code = this.safeCurrencyCode(currencyId, currency);
        object timestamp = this.safeInteger(transaction, "create_time");
        object amount = this.safeNumber(transaction, "amount");
        object txId = this.safeString(transaction, "txid");
        object feeCost = this.safeNumber(transaction, "fee");
        object fee = null;
        if (isTrue(!isEqual(feeCost, null)))
        {
            fee = new Dictionary<string, object>() {
                { "currency", code },
                { "cost", feeCost },
            };
        }
        object updated = this.safeInteger(transaction, "update_time");
        return new Dictionary<string, object>() {
            { "info", transaction },
            { "id", id },
            { "txid", txId },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "network", null },
            { "address", address },
            { "addressTo", address },
            { "addressFrom", null },
            { "tag", tag },
            { "tagTo", tag },
            { "tagFrom", null },
            { "type", type },
            { "amount", amount },
            { "currency", code },
            { "status", status },
            { "updated", updated },
            { "internal", null },
            { "fee", fee },
        };
    }

    public async virtual Task<object> repayMargin(object code, object amount, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#repayMargin
        * @description repay borrowed margin and interest
        * @see https://exchange-docs.crypto.com/spot/index.html#private-margin-repay
        * @param {string} code unified currency code of the currency to repay
        * @param {float} amount the amount to repay
        * @param {string|undefined} symbol unified market symbol, not used by cryptocom.repayMargin ()
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a [margin loan structure]{@link https://docs.ccxt.com/#/?id=margin-loan-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "currency", getValue(currency, "id") },
            { "amount", this.currencyToPrecision(code, amount) },
        };
        object response = await this.v2PrivatePostPrivateMarginRepay(this.extend(request, parameters));
        //
        //     {
        //         "id": 1656620104211,
        //         "method": "private/margin/repay",
        //         "code": 0,
        //         "result": {
        //             "badDebt": 0
        //         }
        //     }
        //
        object transaction = this.parseMarginLoan(response, currency);
        return this.extend(transaction, new Dictionary<string, object>() {
            { "amount", amount },
        });
    }

    public async virtual Task<object> borrowMargin(object code, object amount, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#borrowMargin
        * @description create a loan to borrow margin
        * @see https://exchange-docs.crypto.com/spot/index.html#private-margin-borrow
        * @param {string} code unified currency code of the currency to borrow
        * @param {float} amount the amount to borrow
        * @param {string|undefined} symbol unified market symbol, not used by cryptocom.repayMargin ()
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a [margin loan structure]{@link https://docs.ccxt.com/#/?id=margin-loan-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "currency", getValue(currency, "id") },
            { "amount", this.currencyToPrecision(code, amount) },
        };
        object response = await this.v2PrivatePostPrivateMarginBorrow(this.extend(request, parameters));
        //
        //     {
        //         "id": 1656619578559,
        //         "method": "private/margin/borrow",
        //         "code": 0
        //     }
        //
        object transaction = this.parseMarginLoan(response, currency);
        return this.extend(transaction, new Dictionary<string, object>() {
            { "amount", amount },
        });
    }

    public virtual object parseMarginLoan(object info, object currency = null)
    {
        //
        // borrowMargin
        //
        //     {
        //         "id": 1656619578559,
        //         "method": "private/margin/borrow",
        //         "code": 0
        //     }
        //
        // repayMargin
        //
        //     {
        //         "id": 1656620104211,
        //         "method": "private/margin/repay",
        //         "code": 0,
        //         "result": {
        //             "badDebt": 0
        //         }
        //     }
        //
        return new Dictionary<string, object>() {
            { "id", this.safeInteger(info, "id") },
            { "currency", this.safeCurrencyCode(null, currency) },
            { "amount", null },
            { "symbol", null },
            { "timestamp", null },
            { "datetime", null },
            { "info", info },
        };
    }

    public async virtual Task<object> fetchBorrowInterest(object code = null, object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object market = null;
        object currency = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
        }
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["currency"] = getValue(currency, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["start_ts"] = since;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["page_size"] = limit;
        }
        object response = await this.v2PrivatePostPrivateMarginGetInterestHistory(this.extend(request, parameters));
        //
        //     {
        //         "id": 1656705829020,
        //         "method": "private/margin/get-interest-history",
        //         "code": 0,
        //         "result": {
        //             "list": [
        //                 {
        //                     "loan_id": "2643528867803765921",
        //                     "currency": "USDT",
        //                     "interest": 0.00000004,
        //                     "time": 1656702899559,
        //                     "stake_amount": 6,
        //                     "interest_rate": 0.000025
        //                 },
        //             ]
        //         }
        //     }
        //
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object rows = this.safeValue(data, "list", new List<object>() {});
        object interest = null;
        for (object i = 0; isLessThan(i, getArrayLength(rows)); postFixIncrement(ref i))
        {
            interest = this.parseBorrowInterests(rows, market);
        }
        return this.filterByCurrencySinceLimit(interest, code, since, limit);
    }

    public override object parseBorrowInterest(object info, object market = null)
    {
        //
        //     {
        //         "loan_id": "2643528867803765921",
        //         "currency": "USDT",
        //         "interest": 0.00000004,
        //         "time": 1656702899559,
        //         "stake_amount": 6,
        //         "interest_rate": 0.000025
        //     },
        //
        object timestamp = this.safeInteger(info, "time");
        object symbol = null;
        if (isTrue(!isEqual(market, null)))
        {
            symbol = getValue(market, "symbol");
        }
        return new Dictionary<string, object>() {
            { "symbol", symbol },
            { "marginMode", null },
            { "currency", this.safeCurrencyCode(this.safeString(info, "currency")) },
            { "interest", this.safeNumber(info, "interest") },
            { "interestRate", this.safeNumber(info, "interest_rate") },
            { "amountBorrowed", null },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "info", info },
        };
    }

    public async override Task<object> fetchBorrowRates(object parameters = null)
    {
        /**
        * @method
        * @name cryptocom#fetchBorrowRates
        * @description fetch the borrow interest rates of all currencies
        * @param {object} params extra parameters specific to the cryptocom api endpoint
        * @returns {object} a list of [borrow rate structures]{@link https://docs.ccxt.com/#/?id=borrow-rate-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.v2PrivatePostPrivateMarginGetUserConfig(parameters);
        //
        //     {
        //         "id": 1656707947456,
        //         "method": "private/margin/get-user-config",
        //         "code": 0,
        //         "result": {
        //             "stake_amount": 6,
        //             "currency_configs": [
        //                 {
        //                     "currency": "AGLD",
        //                     "hourly_rate": 0.00003334,
        //                     "max_borrow_limit": 342.4032393,
        //                     "min_borrow_limit": 30
        //                 },
        //             ]
        //         }
        //     }
        //
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        object rates = this.safeValue(data, "currency_configs", new List<object>() {});
        return this.parseBorrowRates(rates, "currency");
    }

    public virtual object parseBorrowRates(object info, object codeKey)
    {
        //
        //     {
        //         "currency": "AGLD",
        //         "hourly_rate": 0.00003334,
        //         "max_borrow_limit": 342.4032393,
        //         "min_borrow_limit": 30
        //     },
        //
        object timestamp = this.milliseconds();
        object rates = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(info)); postFixIncrement(ref i))
        {
            object entry = getValue(info, i);
            ((List<object>)rates).Add(new Dictionary<string, object>() {
                { "currency", this.safeCurrencyCode(this.safeString(entry, "currency")) },
                { "rate", this.safeNumber(entry, "hourly_rate") },
                { "period", 3600000 },
                { "timestamp", timestamp },
                { "datetime", this.iso8601(timestamp) },
                { "info", entry },
            });
        }
        return rates;
    }

    public virtual object customHandleMarginModeAndParams(object methodName, object parameters = null)
    {
        /**
        * @ignore
        * @method
        * @description marginMode specified by params["marginMode"], this.options["marginMode"], this.options["defaultMarginMode"], params["margin"] = true or this.options["defaultType"] = 'margin'
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[string|undefined, object]} the marginMode in lowercase
        */
        parameters ??= new Dictionary<string, object>();
        object defaultType = this.safeString(this.options, "defaultType");
        object isMargin = this.safeValue(parameters, "margin", false);
        parameters = this.omit(parameters, "margin");
        object marginMode = null;
                var marginModeparametersVariable = this.handleMarginModeAndParams(methodName, parameters);
        marginMode = ((List<object>)marginModeparametersVariable)[0];
        parameters = ((List<object>)marginModeparametersVariable)[1];
        if (isTrue(!isEqual(marginMode, null)))
        {
            if (isTrue(!isEqual(marginMode, "cross")))
            {
                throw new NotSupported ((string)add(this.id, " only cross margin is supported")) ;
            }
        } else
        {
            if (isTrue(isTrue((isEqual(defaultType, "margin"))) || isTrue((isEqual(isMargin, true)))))
            {
                marginMode = "cross";
            }
        }
        return new List<object>() {marginMode, parameters};
    }

    public override object nonce()
    {
        return this.milliseconds();
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object type = this.safeString(api, 0);
        object access = this.safeString(api, 1);
        object url = add(add(getValue(getValue(this.urls, "api"), type), "/"), path);
        object query = this.omit(parameters, this.extractParams(path));
        if (isTrue(isEqual(access, "public")))
        {
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
            {
                url = add(url, add("?", this.urlencode(query)));
            }
        } else
        {
            this.checkRequiredCredentials();
            object nonce = ((object)this.nonce()).ToString();
            object requestParams = this.extend(new Dictionary<string, object>() {}, parameters);
            object keysorted = this.keysort(requestParams);
            object paramsKeys = new List<string>(((Dictionary<string,object>)keysorted).Keys);
            object strSortKey = "";
            for (object i = 0; isLessThan(i, getArrayLength(paramsKeys)); postFixIncrement(ref i))
            {
                strSortKey = add(add(strSortKey, ((object)getValue(paramsKeys, i)).ToString()), ((object)getValue(requestParams, getValue(paramsKeys, i))).ToString());
            }
            object payload = add(add(add(add(path, nonce), this.apiKey), strSortKey), nonce);
            object signature = this.hmac(this.encode(payload), this.encode(this.secret), sha256);
            object paramsKeysLength = getArrayLength(paramsKeys);
            body = this.json(new Dictionary<string, object>() {
                { "id", nonce },
                { "method", path },
                { "params", parameters },
                { "api_key", this.apiKey },
                { "sig", signature },
                { "nonce", nonce },
            });
            // fix issue https://github.com/ccxt/ccxt/issues/11179
            // php always encodes dictionaries as arrays
            // if an array is empty, php will put it in square brackets
            // python and js will put it in curly brackets
            // the code below checks and replaces those brackets in empty requests
            if (isTrue(isEqual(paramsKeysLength, 0)))
            {
                object paramsString = "{}";
                object arrayString = "[]";
                body = ((string)body).Replace((string)arrayString, (string)paramsString);
            }
            headers = new Dictionary<string, object>() {
                { "Content-Type", "application/json" },
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
        object errorCode = this.safeString(response, "code");
        if (isTrue(!isEqual(errorCode, "0")))
        {
            object feedback = add(add(this.id, " "), body);
            this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), errorCode, feedback);
            throw new ExchangeError ((string)add(add(this.id, " "), body)) ;
        }
        return null;
    }
}
