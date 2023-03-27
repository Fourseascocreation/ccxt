using Main;
namespace Main;

partial class btcex : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "btcex" },
            { "name", "BTCEX" },
            { "countries", new List<object>() {"CA"} },
            { "version", "v1" },
            { "certified", false },
            { "pro", true },
            { "requiredCredentials", new Dictionary<string, object>() {
                { "apiKey", true },
                { "secret", true },
            } },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/1294454/173489620-d49807a4-55cd-4f4e-aca9-534921298bbf.jpg" },
                { "www", "https://www.btcex.com/" },
                { "api", new Dictionary<string, object>() {
                    { "rest", "https://api.btcex.com" },
                } },
                { "doc", "https://docs.btcex.com/" },
                { "fees", "https://support.btcex.com/hc/en-us/articles/4415995130647" },
                { "referral", new Dictionary<string, object>() {
                    { "url", "https://www.btcex.com/en-us/register?i=48biatg1" },
                    { "discount", 0.1 },
                } },
            } },
            { "has", new Dictionary<string, object>() {
                { "CORS", null },
                { "spot", true },
                { "margin", true },
                { "swap", true },
                { "future", true },
                { "option", true },
                { "cancelAllOrders", true },
                { "cancelOrder", true },
                { "createLimitBuyOrder", true },
                { "createLimitSellOrder", true },
                { "createMarketBuyOrder", true },
                { "createMarketSellOrder", true },
                { "createOrder", true },
                { "createPostOnlyOrder", true },
                { "createReduceOnlyOrder", true },
                { "createStopLimitOrder", true },
                { "createStopMarketOrder", true },
                { "createStopOrder", true },
                { "editOrder", false },
                { "fetchBalance", true },
                { "fetchBorrowRate", false },
                { "fetchBorrowRateHistories", false },
                { "fetchBorrowRateHistory", false },
                { "fetchBorrowRates", false },
                { "fetchClosedOrders", true },
                { "fetchCurrencies", false },
                { "fetchDepositAddress", false },
                { "fetchDeposits", true },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", true },
                { "fetchFundingRateHistory", false },
                { "fetchFundingRates", true },
                { "fetchIndexOHLCV", false },
                { "fetchLeverage", true },
                { "fetchLeverageTiers", true },
                { "fetchMarginMode", false },
                { "fetchMarketLeverageTiers", true },
                { "fetchMarkets", true },
                { "fetchMarkOHLCV", false },
                { "fetchMyTrades", true },
                { "fetchOHLCV", true },
                { "fetchOpenInterest", true },
                { "fetchOpenInterestHistory", false },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchOrders", true },
                { "fetchOrderTrades", true },
                { "fetchPosition", true },
                { "fetchPositionMode", false },
                { "fetchPositions", true },
                { "fetchPremiumIndexOHLCV", false },
                { "fetchTicker", true },
                { "fetchTickers", false },
                { "fetchTime", false },
                { "fetchTrades", true },
                { "fetchTradingFee", false },
                { "fetchTradingFees", false },
                { "fetchTransactionFees", null },
                { "fetchWithdrawal", true },
                { "fetchWithdrawals", true },
                { "setLeverage", true },
                { "setMarginMode", true },
                { "signIn", true },
                { "transfer", true },
                { "withdraw", false },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "1" },
                { "3m", "3" },
                { "5m", "5" },
                { "15m", "15" },
                { "30m", "30" },
                { "1h", "60" },
                { "2h", "120" },
                { "3h", "180" },
                { "4h", "240" },
                { "6h", "360" },
                { "12h", "720" },
                { "1d", "1D" },
                { "3d", "3D" },
                { "1M", "30D" },
            } },
            { "api", new Dictionary<string, object>() {
                { "public", new Dictionary<string, object>() {
                    { "get", new List<object>() {"get_last_trades_by_currency", "get_last_trades_by_instrument", "get_order_book", "tickers", "get_instruments", "get_tradingview_chart_data", "cmc_spot_summary", "cmc_spot_ticker", "cmc_spot_orderbook", "cmc_market_trades", "cmc_contracts", "cmc_contract_orderbook", "coin_gecko_spot_pairs", "coin_gecko_spot_ticker", "coin_gecko_spot_orderbook", "coin_gecko_market_trades", "coin_gecko_contracts", "coin_gecko_contract_orderbook", "get_perpetual_leverage_bracket", "get_perpetual_leverage_bracket_all"} },
                    { "post", new List<object>() {"auth"} },
                } },
                { "private", new Dictionary<string, object>() {
                    { "get", new List<object>() {"get_deposit_record", "get_withdraw_record", "get_position", "get_positions", "get_open_orders_by_currency", "get_open_orders_by_instrument", "get_order_history_by_currency", "get_order_history_by_instrument", "get_order_state", "get_user_trades_by_currency", "get_user_trades_by_instrument", "get_user_trades_by_order", "get_perpetual_user_config"} },
                    { "post", new List<object>() {"logout", "get_assets_info", "add_withdraw_address", "buy", "sell", "cancel", "cancel_all_by_currency", "cancel_all_by_instrument", "close_position", "adjust_perpetual_leverage", "adjust_perpetual_margin_type", "submit_transfer"} },
                    { "delete", new List<object>() {} },
                } },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "tierBased", false },
                    { "percentage", true },
                    { "maker", this.parseNumber("0.001") },
                    { "taker", this.parseNumber("0.001") },
                } },
                { "margin", new Dictionary<string, object>() {
                    { "tierBased", false },
                    { "percentage", true },
                    { "maker", this.parseNumber("0.001") },
                    { "taker", this.parseNumber("0.001") },
                } },
                { "perpetual", new Dictionary<string, object>() {
                    { "tierBased", false },
                    { "percentage", true },
                    { "maker", this.parseNumber("0.002") },
                    { "taker", this.parseNumber("0.002") },
                } },
            } },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {
                    { "9999", typeof(ExchangeError) },
                    { "9900", typeof(ExchangeNotAvailable) },
                    { "401", typeof(AuthenticationError) },
                    { "403", typeof(AuthenticationError) },
                    { "1000", typeof(ExchangeNotAvailable) },
                    { "1001", typeof(BadRequest) },
                    { "1005", typeof(DDoSProtection) },
                    { "2000", typeof(AuthenticationError) },
                    { "2001", typeof(AuthenticationError) },
                    { "2002", typeof(AuthenticationError) },
                    { "2003", typeof(AuthenticationError) },
                    { "2010", typeof(PermissionDenied) },
                    { "3000", typeof(AuthenticationError) },
                    { "3002", typeof(AuthenticationError) },
                    { "3003", typeof(AuthenticationError) },
                    { "3004", typeof(BadRequest) },
                    { "3005", typeof(NotSupported) },
                    { "3007", typeof(AuthenticationError) },
                    { "3008", typeof(AuthenticationError) },
                    { "3009", typeof(AuthenticationError) },
                    { "3011", typeof(AuthenticationError) },
                    { "3012", typeof(AuthenticationError) },
                    { "3013", typeof(RequestTimeout) },
                    { "3015", typeof(AuthenticationError) },
                    { "3016", typeof(AuthenticationError) },
                    { "3018", typeof(BadRequest) },
                    { "3019", typeof(BadRequest) },
                    { "3020", typeof(BadRequest) },
                    { "3021", typeof(BadRequest) },
                    { "3022", typeof(BadRequest) },
                    { "3023", typeof(BadRequest) },
                    { "3024", typeof(BadRequest) },
                    { "3025", typeof(BadRequest) },
                    { "3026", typeof(BadRequest) },
                    { "3027", typeof(BadRequest) },
                    { "3028", typeof(BadRequest) },
                    { "3029", typeof(DDoSProtection) },
                    { "3030", typeof(DDoSProtection) },
                    { "3031", typeof(BadRequest) },
                    { "3032", typeof(BadRequest) },
                    { "3033", typeof(BadRequest) },
                    { "3034", typeof(AuthenticationError) },
                    { "3035", typeof(BadRequest) },
                    { "3036", typeof(BadRequest) },
                    { "3037", typeof(BadRequest) },
                    { "3038", typeof(BadRequest) },
                    { "3039", typeof(BadRequest) },
                    { "3040", typeof(AuthenticationError) },
                    { "3041", typeof(BadRequest) },
                    { "4000", typeof(BadRequest) },
                    { "4001", typeof(InvalidAddress) },
                    { "4002", typeof(InvalidAddress) },
                    { "4003", typeof(BadRequest) },
                    { "4004", typeof(NotSupported) },
                    { "4005", typeof(ExchangeError) },
                    { "4006", typeof(InsufficientFunds) },
                    { "4007", typeof(BadRequest) },
                    { "4008", typeof(NotSupported) },
                    { "4009", typeof(InvalidAddress) },
                    { "4010", typeof(BadRequest) },
                    { "4011", typeof(BadRequest) },
                    { "5001", typeof(InvalidOrder) },
                    { "5002", typeof(OrderNotFound) },
                    { "5003", typeof(InvalidOrder) },
                    { "5004", typeof(InvalidOrder) },
                    { "5005", typeof(InvalidOrder) },
                    { "5006", typeof(InvalidOrder) },
                    { "5007", typeof(InvalidOrder) },
                    { "5008", typeof(InvalidOrder) },
                    { "5009", typeof(InvalidOrder) },
                    { "5010", typeof(InvalidOrder) },
                    { "5011", typeof(InvalidOrder) },
                    { "5012", typeof(InvalidOrder) },
                    { "5013", typeof(InvalidOrder) },
                    { "5014", typeof(InvalidOrder) },
                    { "5109", typeof(InvalidOrder) },
                    { "5119", typeof(InvalidOrder) },
                    { "5135", typeof(InvalidOrder) },
                    { "5901", typeof(InvalidOrder) },
                    { "5902", typeof(InvalidOrder) },
                    { "5903", typeof(InvalidOrder) },
                    { "5904", typeof(InvalidOrder) },
                    { "5905", typeof(InvalidOrder) },
                    { "5906", typeof(InvalidOrder) },
                    { "5907", typeof(InsufficientFunds) },
                    { "8000", typeof(BadRequest) },
                    { "8001", typeof(BadRequest) },
                    { "8100", typeof(BadRequest) },
                    { "8101", typeof(RequestTimeout) },
                    { "8102", typeof(DDoSProtection) },
                    { "8103", typeof(BadRequest) },
                    { "8104", typeof(BadRequest) },
                    { "8105", typeof(BadRequest) },
                    { "8106", typeof(DDoSProtection) },
                    { "8107", typeof(ExchangeError) },
                    { "10000", typeof(AuthenticationError) },
                    { "11000", typeof(BadRequest) },
                } },
                { "broad", new Dictionary<string, object>() {} },
            } },
            { "precisionMode", TICK_SIZE },
            { "options", new Dictionary<string, object>() {
                { "accountsByType", new Dictionary<string, object>() {
                    { "wallet", "WALLET" },
                    { "spot", "SPOT" },
                    { "perpetual", "PERPETUAL" },
                    { "margin", "MARGIN" },
                    { "swap", "PERPETUAL" },
                    { "BTC", "BTC" },
                    { "ETH", "ETH" },
                } },
                { "createMarketBuyOrderRequiresPrice", true },
            } },
            { "commonCurrencies", new Dictionary<string, object>() {} },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetGetInstruments(parameters);
        object markets = this.safeValue(response, "result", new List<object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647533492507,
        //         "usOut":1647533492511,
        //         "usDiff":4,
        //         "result":[{
        //             "currency":"BTC",
        //             "base_currency":"USDT",
        //             "contract_size":"0.01",
        //             "creation_timestamp":"1632384961348",
        //             "expiration_timestamp":"1648195200000",
        //             "instrument_name":"BTC-25MAR22",
        //             "show_name":"BTC-25MAR22",
        //             "is_active":true,
        //             "kind":"future",
        //             "leverage":0,
        //             "maker_commission":"10",
        //             "taker_commission":"17",
        //             "min_trade_amount":"0.01",
        //             "option_type":"init",
        //             "quote_currency":"USDT",
        //             "settlement_period":"week",
        //             "strike":"0",
        //             "tick_size":"0.1",
        //             "instr_multiple":"0.01",
        //             "order_price_low_rate":"0.8",
        //             "order_price_high_rate":"1.2",
        //             "order_price_limit_type":0,
        //             "min_qty":"0.01",
        //             "min_notional":"0",
        //             "support_trace_trade":false
        //         }]
        //     }
        //
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(markets)); postFixIncrement(ref i))
        {
            object market = getValue(markets, i);
            object id = this.safeString(market, "instrument_name");
            object type = this.safeString(market, "kind");
            object unifiedType = type;
            if (isTrue(isEqual(type, "perpetual")))
            {
                unifiedType = "swap";
            }
            object baseId = this.safeString(market, "quote_currency");
            object quoteId = this.safeString(market, "base_currency");
            object swap = (isEqual(type, "perpetual"));
            object spot = (isEqual(type, "spot"));
            object margin = (isEqual(type, "margin"));
            object option = (isEqual(type, "option"));
            object future = (isEqual(type, "future"));
            object contract = isTrue(isTrue(swap) || isTrue(future)) || isTrue(option);
            object expiry = null;
            if (isTrue(isTrue(option) || isTrue(future)))
            {
                baseId = this.safeString(market, "currency");
                expiry = this.safeInteger(market, "expiration_timestamp");
            }
            object contractSize = null;
            object settleId = null;
            object settle = null;
            if (isTrue(contract))
            {
                settleId = quoteId;
                settle = this.safeCurrencyCode(settleId);
            }
            object optionType = null;
            object strike = null;
            if (isTrue(option))
            {
                optionType = this.safeString(market, "option_type");
                strike = this.safeNumber(market, "strike");
            }
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
            object symbol = null;
            if (isTrue(margin))
            {
                symbol = id;
            } else
            {
                symbol = add(add(bs, "/"), quote);
            }
            if (isTrue(contract))
            {
                contractSize = this.safeNumber(market, "contract_size");
                symbol = add(add(symbol, ":"), settle);
                if (isTrue(isTrue(future) || isTrue(option)))
                {
                    symbol = add(add(symbol, "-"), this.yymmdd(expiry));
                    if (isTrue(option))
                    {
                        object letter = ((bool) isTrue((isEqual(optionType, "call")))) ? "C" : "P";
                        symbol = add(add(add(add(symbol, ":"), this.numberToString(strike)), ":"), letter);
                    }
                }
            }
            object minTradeAmount = this.safeNumber(market, "min_trade_amount");
            object tickSize = this.safeNumber(market, "tick_size");
            object maker = this.safeNumber(market, "maker_commission");
            object taker = this.safeNumber(market, "taker_commission");
            object percentage = !isTrue((isTrue(option) || isTrue(future)));
            ((List<object>)result).Add(new Dictionary<string, object>() {
                { "id", id },
                { "symbol", symbol },
                { "base", bs },
                { "quote", quote },
                { "baseId", baseId },
                { "quoteId", quoteId },
                { "settleId", settleId },
                { "settle", settle },
                { "type", unifiedType },
                { "maker", maker },
                { "taker", taker },
                { "percentage", percentage },
                { "spot", spot },
                { "margin", margin },
                { "swap", swap },
                { "future", future },
                { "option", option },
                { "active", this.safeValue(market, "is_active") },
                { "contract", contract },
                { "linear", ((bool) isTrue(contract)) ? true : null },
                { "inverse", ((bool) isTrue(contract)) ? false : null },
                { "contractSize", contractSize },
                { "expiry", expiry },
                { "expiryDatetime", this.iso8601(expiry) },
                { "strike", strike },
                { "optionType", optionType },
                { "precision", new Dictionary<string, object>() {
                    { "amount", minTradeAmount },
                    { "price", tickSize },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", this.safeString(market, "leverage") },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", minTradeAmount },
                        { "max", null },
                    } },
                    { "price", new Dictionary<string, object>() {
                        { "min", tickSize },
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

    public override object parseTicker(object ticker, object market = null)
    {
        //
        //     {
        //         "best_ask_amount":"0.20962",
        //         "best_ask_price":"40491.7",
        //         "best_bid_amount":"0.08855",
        //         "best_bid_price":"40491.6",
        //         "instrument_name":"BTC-USDT",
        //         "last_price":"40493",
        //         "mark_price":"40493.10644717",
        //         "state":"open",
        //         "stats":{
        //             "high":"41468.8",
        //             "low":"40254.9",
        //             "price_change":"-0.0159",
        //             "volume":"3847.35240000000000005"
        //             "turnover":"1109811189.67100102035328746"
        //         },
        //         "timestamp":"1647569486224"
        //     }
        //
        object marketId = this.safeString(ticker, "instrument_name");
        if (isTrue(isLessThan(getIndexOf(marketId, "PERPETUAL"), 0)))
        {
            marketId = add(marketId, "-SPOT");
        }
        market = this.safeMarket(marketId, market);
        object symbol = this.safeSymbol(marketId, market, "-");
        object timestamp = this.safeInteger(ticker, "timestamp");
        object stats = this.safeValue(ticker, "stats");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", this.safeString(stats, "high") },
            { "low", this.safeString(stats, "low") },
            { "bid", this.safeString(ticker, "best_bid_price") },
            { "bidVolume", this.safeString(ticker, "best_bid_amount") },
            { "ask", this.safeString(ticker, "best_ask_price") },
            { "askVolume", this.safeString(ticker, "best_ask_amount") },
            { "vwap", null },
            { "open", null },
            { "close", this.safeString(ticker, "last_price") },
            { "last", this.safeString(ticker, "last_price") },
            { "previousClose", null },
            { "change", null },
            { "percentage", this.safeString(stats, "price_change") },
            { "average", null },
            { "baseVolume", this.safeString(stats, "volume") },
            { "quoteVolume", this.safeString(stats, "turnover") },
            { "info", ticker },
        }, market);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        object response = await this.publicGetTickers(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647569487238,
        //         "usOut":1647569487240,
        //         "usDiff":2,
        //         "result":[{
        //             "best_ask_amount":"0.20962",
        //             "best_ask_price":"40491.7",
        //             "best_bid_amount":"0.08855",
        //             "best_bid_price":"40491.6",
        //             "instrument_name":"BTC-USDT",
        //             "last_price":"40493",
        //             "mark_price":"40493.10644717",
        //             "state":"open",
        //             "stats":{
        //                 "high":"41468.8",
        //                 "low":"40254.9",
        //                 "price_change":"-0.0159",
        //                 "volume":"3847.35240000000000005"
        //             },
        //             "timestamp":"1647569486224"
        //         }]
        //     }
        //
        object ticker = this.safeValue(result, 0);
        return this.parseTicker(ticker, market);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["depth"] = limit;
        }
        object response = await this.publicGetGetOrderBook(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647573916524,
        //         "usOut":1647573916526,
        //         "usDiff":2,
        //         "result":{
        //             "asks":[["10155.00000","0.200","186.980","0.000"],["10663.00000","0.200","217.480","0.000"]],
        //             "bids":[["7896.00000","0.200","1.000","0.000"],["7481.00000","0.200","1.000","0.000"]],
        //             "timestamp":"1647573916525",
        //             "instrument_name":"BTC-25MAR22-32000-C",
        //             "version":1002541
        //         }
        //     }
        //
        object timestamp = this.safeInteger(result, "timestamp");
        object orderBook = this.parseOrderBook(result, getValue(market, "symbol"), timestamp);
        ((Dictionary<string, object>)orderBook)["nonce"] = this.safeInteger(result, "version");
        return orderBook;
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //
        //     {
        //         "tick":1647547200,
        //         "open":"40868.16800000",
        //         "high":"40877.65600000",
        //         "low":"40647.00000000",
        //         "close":"40699.10000000",
        //         "volume":"100.27789000",
        //         "cost":"4083185.78337596"
        //     }
        //
        return new List<object> {this.safeTimestamp(ohlcv, "tick"), this.safeNumber(ohlcv, "open"), this.safeNumber(ohlcv, "high"), this.safeNumber(ohlcv, "low"), this.safeNumber(ohlcv, "close"), this.safeNumber(ohlcv, "volume")};
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        if (isTrue(isEqual(limit, null)))
        {
            limit = 10;
        }
        object request = new Dictionary<string, object>() {
            { "resolution", this.safeString(this.timeframes, timeframe, timeframe) },
        };
        object marketId = getValue(market, "id");
        if (isTrue(isTrue(getValue(market, "spot")) || isTrue(getValue(market, "margin"))))
        {
            marketId = add(add(getValue(market, "baseId"), "-"), getValue(market, "quoteId"));
        }
        ((Dictionary<string, object>)request)["instrument_name"] = marketId;
        if (isTrue(isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["end_timestamp"] = this.milliseconds();
            ((Dictionary<string, object>)request)["start_timestamp"] = 0;
        } else
        {
            object timeframeInSeconds = this.parseTimeframe(timeframe);
            object timeframeInMilliseconds = multiply(timeframeInSeconds, 1000);
            ((Dictionary<string, object>)request)["start_timestamp"] = since;
            ((Dictionary<string, object>)request)["end_timestamp"] = this.sum(getValue(request, "start_timestamp"), multiply(limit, timeframeInMilliseconds));
        }
        object response = await this.publicGetGetTradingviewChartData(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new List<object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647578562427,
        //         "usOut":1647578562428,
        //         "usDiff":1,
        //         "result":[{
        //             "tick":1647547200,
        //             "open":"40868.16800000",
        //             "high":"40877.65600000",
        //             "low":"40647.00000000",
        //             "close":"40699.10000000",
        //             "volume":"100.27789000",
        //             "cost":"4083185.78337596"
        //         }]
        //     }
        //
        return this.parseOHLCVs(result, market, timeframe, since, limit);
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        // fetchTrades (public)
        //
        //     {
        //         "amount":"0.0003",
        //         "direction":"sell",
        //         "iv":"0",
        //         "price":"40767.18",
        //         "timestamp":"1647582687050",
        //         "instrument_name":"BTC-USDT-SPOT",
        //         "trade_id":57499240
        //     }
        //
        // fetchOrderTrades || fetchMyTrades
        //
        //     {
        //         "direction":"sell",
        //         "amount":"0.03",
        //         "price":"397.8",
        //         "fee":"0.011934",
        //         "timestamp":1647668570759,
        //         "role":"taker",
        //         "trade_id":"58319385",
        //         "order_id":"250979478947823616",
        //         "instrument_name":"BNB-USDT-SPOT",
        //         "order_type":"market",
        //         "fee_use_coupon":false,
        //         "fee_coin_type":"USDT",
        //         "index_price":"",
        //         "self_trade":false
        //     }
        //
        object id = this.safeString(trade, "trade_id");
        object marketId = this.safeString(trade, "instrument_name");
        object symbol = this.safeSymbol(marketId, market);
        object timestamp = this.safeInteger(trade, "timestamp");
        object side = this.safeString(trade, "direction");
        object priceString = this.safeString(trade, "price");
        object amountString = this.safeString(trade, "amount");
        object takerOrMaker = this.safeString(trade, "role");
        object feeCostString = this.safeString(trade, "fee");
        object fee = null;
        if (isTrue(!isEqual(feeCostString, null)))
        {
            object feeCurrencyId = this.safeString(trade, "fee_coin_type");
            object feeCurrencyCode = this.safeCurrencyCode(feeCurrencyId);
            fee = new Dictionary<string, object>() {
                { "cost", feeCostString },
                { "currency", feeCurrencyCode },
            };
        }
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "id", id },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", symbol },
            { "order", this.safeString(trade, "order_id") },
            { "type", this.safeString(trade, "order_type") },
            { "side", side },
            { "takerOrMaker", takerOrMaker },
            { "price", priceString },
            { "amount", amountString },
            { "cost", null },
            { "fee", fee },
        }, market);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit; // default 10
        }
        object response = await this.publicGetGetLastTradesByInstrument(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647582703220,
        //         "usOut":1647582703253,
        //         "usDiff":33,
        //         "result":{
        //             "trades":[{
        //                 "amount":"0.0003",
        //                 "direction":"sell",
        //                 "iv":"0",
        //                 "price":"40767.18",
        //                 "timestamp":"1647582687050",
        //                 "instrument_name":"BTC-USDT-SPOT",
        //                 "trade_id":57499240
        //             }],
        //             "has_more":true
        //         }
        //     }
        //
        object trades = this.safeValue(result, "trades", new List<object>() {});
        return this.parseTrades(trades, market, since, limit);
    }

    public async virtual Task<object> signIn(object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        object accessToken = this.safeString(this.options, "accessToken");
        if (isTrue(!isEqual(accessToken, null)))
        {
            return accessToken;
        }
        this.checkRequiredCredentials();
        object request = new Dictionary<string, object>() {
            { "grant_type", "client_credentials" },
            { "client_id", this.apiKey },
            { "client_secret", this.secret },
        };
        object response = await this.publicPostAuth(this.extend(request, parameters));
        object result = this.safeValue(response, "result");
        //
        //     {
        //         jsonrpc: '2.0',
        //         usIn: '1647601525586',
        //         usOut: '1647601525597',
        //         usDiff: '11',
        //         result: {
        //         access_token: '',
        //         token_type: 'bearer',
        //         refresh_token: '',
        //         expires_in: '604799',
        //         scope: 'account:read_write block_trade:read_write trade:read_write wallet:read_write'
        //         }
        //     }
        //
        accessToken = this.safeString(result, "access_token");
        ((Dictionary<string, object>)this.options)["accessToken"] = accessToken;
        return accessToken;
    }

    public virtual object parseBalance(object response)
    {
        //
        //     {
        //         "WALLET":{
        //             "total":"0",
        //             "coupon":"0",
        //             "details":[{
        //                 "available":"0",
        //                 "freeze":"0",
        //                 "coin_type":"1INCH",
        //                 "current_mark_price":"1.657"
        //             }]
        //         },
        //         "MARGIN":{
        //             "total":"0",
        //             "net":"0",
        //             "available":"0",
        //             "borrowed":"0",
        //             "details":[],
        //             "maintenance_margin":"0",
        //             "interest_owed":"0"
        //         },
        //         "SPOT":{
        //             "total":"3.965",
        //             "available":"15.887066",
        //             "details":[{
        //                 "available":"0",
        //                 "freeze":"0",
        //                 "total":"0",
        //                 "coin_type":"1INCH",
        //                 "current_mark_price":"1.657"
        //             }]
        //         },
        //         "BTC":{
        //             "currency":"BTC",
        //             "balance":"0",
        //             "freeze":"0",
        //             "equity":"0",
        //             "base_currency":"USDT",
        //             "available_funds":"0",
        //             "available_withdrawal_funds":"0",
        //             "initial_margin":"0",
        //             "maintenance_margin":"0",
        //             "margin_balance":"0",
        //             "session_funding":"0",
        //             "session_rpl":"0",
        //             "session_upl":"0",
        //             "futures_pl":"0",
        //             "futures_session_rpl":"0",
        //             "futures_session_upl":"0",
        //             "options_value":"0",
        //             "options_pl":"0",
        //             "options_session_rpl":"0",
        //             "options_session_upl":"0",
        //             "total_pl":"0",
        //             "options_delta":"0",
        //             "options_gamma":"0",
        //             "options_theta":"0",
        //             "options_vega":"0",
        //             "delta_total":"0"
        //         },
        //         "ETH":{
        //             "currency":"ETH",
        //             "balance":"0",
        //             "freeze":"0",
        //             "equity":"0",
        //             "base_currency":"USDT",
        //             "available_funds":"0",
        //             "available_withdrawal_funds":"0",
        //             "initial_margin":"0",
        //             "maintenance_margin":"0",
        //             "margin_balance":"0",
        //             "session_funding":"0",
        //             "session_rpl":"0",
        //             "session_upl":"0",
        //             "futures_pl":"0",
        //             "futures_session_rpl":"0",
        //             "futures_session_upl":"0",
        //             "options_value":"0",
        //             "options_pl":"0",
        //             "options_session_rpl":"0",
        //             "options_session_upl":"0",
        //             "total_pl":"0",
        //             "options_delta":"0",
        //             "options_gamma":"0",
        //             "options_theta":"0",
        //             "options_vega":"0",
        //             "delta_total":"0"
        //         },
        //         "PERPETUAL":{
        //             "bonus":"0",
        //             "global_state":0,
        //             "available_funds":"0",
        //             "wallet_balance":"0",
        //             "available_withdraw_funds":"0",
        //             "total_pl":"0",
        //             "total_upl":"0",
        //             "position_rpl":"0",
        //             "total_upl_isolated":"0",
        //             "total_upl_cross":"0",
        //             "total_initial_margin_cross":"0",
        //             "total_initial_margin_isolated":"0",
        //             "total_margin_balance_isolated":"0",
        //             "total_margin_balance":"0",
        //             "total_margin_balance_cross":"0",
        //             "total_maintenance_margin_cross":"0",
        //             "total_wallet_balance_isolated":"0",
        //             "order_frozen":"0",
        //             "order_cross_frozen":"0",
        //             "order_isolated_frozen":"0",
        //             "risk_level":"0",
        //             "bonus_max":"0"
        //         }
        //     }
        //
        object result = new Dictionary<string, object>() {
            { "info", response },
        };
        object assetTypes = new List<string>(((Dictionary<string,object>)response).Keys);
        for (object i = 0; isLessThan(i, getArrayLength(assetTypes)); postFixIncrement(ref i))
        {
            object assetType = getValue(assetTypes, i);
            object currency = this.safeValue(response, assetType);
            if (isTrue(isTrue((isEqual(assetType, "WALLET"))) || isTrue((isEqual(assetType, "SPOT")))))
            {
                object details = this.safeValue(currency, "details");
                if (isTrue(!isEqual(details, null)))
                {
                    for (object j = 0; isLessThan(j, getArrayLength(details)); postFixIncrement(ref j))
                    {
                        object detail = getValue(details, j);
                        object coinType = this.safeString(detail, "coin_type");
                        object code = this.safeCurrencyCode(coinType);
                        object account = this.safeValue(result, code, this.account());
                        ((Dictionary<string, object>)account)["free"] = this.safeString(detail, "available");
                        ((Dictionary<string, object>)account)["used"] = this.safeString(detail, "freeze");
                        ((Dictionary<string, object>)account)["total"] = this.safeString(detail, "total");
                        ((Dictionary<string, object>)result)[(string)code] = account;
                    }
                }
            } else
            {
                // all other wallets are linear futures
                object code = "USDT";
                object account = this.account();
                ((Dictionary<string, object>)account)["total"] = this.safeString(currency, "wallet_balance");
                ((Dictionary<string, object>)account)["free"] = this.safeString(currency, "available_withdraw_funds");
                ((Dictionary<string, object>)result)[(string)code] = account;
            }
        }
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.signIn();
        await this.loadMarkets();
        object type = this.safeStringLower(parameters, "type", "spot");
        object types = this.safeValue(this.options, "accountsByType", new Dictionary<string, object>() {});
        object assetType = this.safeString(types, type, type);
        parameters = this.omit(parameters, "type");
        object request = new Dictionary<string, object>() {
            { "asset_type", new List<object>() {assetType} },
        };
        object response = await this.privatePostGetAssetsInfo(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new List<object>() {});
        //
        //     {
        //         "id":"1647675393",
        //         "jsonrpc":"2.0",
        //         "usIn":1647675394091,
        //         "usOut":1647675394104,
        //         "usDiff":13,
        //         "result":{
        //             "WALLET":{
        //                 "total":"0",
        //                 "coupon":"0",
        //                 "details":[{
        //                     "available":"0",
        //                     "freeze":"0",
        //                     "coin_type":"1INCH",
        //                     "current_mark_price":"1.657"
        //                 }]
        //             },
        //             "MARGIN":{
        //                 "total":"0",
        //                 "net":"0",
        //                 "available":"0",
        //                 "borrowed":"0",
        //                 "details":[],
        //                 "maintenance_margin":"0",
        //                 "interest_owed":"0"
        //             },
        //             "SPOT":{
        //                 "total":"3.965",
        //                 "available":"15.887066",
        //                 "details":[{
        //                     "available":"0",
        //                     "freeze":"0",
        //                     "total":"0",
        //                     "coin_type":"1INCH",
        //                     "current_mark_price":"1.657"
        //                 }]
        //             },
        //             "BTC":{
        //                 "currency":"BTC",
        //                 "balance":"0",
        //                 "freeze":"0",
        //                 "equity":"0",
        //                 "base_currency":"USDT",
        //                 "available_funds":"0",
        //                 "available_withdrawal_funds":"0",
        //                 "initial_margin":"0",
        //                 "maintenance_margin":"0",
        //                 "margin_balance":"0",
        //                 "session_funding":"0",
        //                 "session_rpl":"0",
        //                 "session_upl":"0",
        //                 "futures_pl":"0",
        //                 "futures_session_rpl":"0",
        //                 "futures_session_upl":"0",
        //                 "options_value":"0",
        //                 "options_pl":"0",
        //                 "options_session_rpl":"0",
        //                 "options_session_upl":"0",
        //                 "total_pl":"0",
        //                 "options_delta":"0",
        //                 "options_gamma":"0",
        //                 "options_theta":"0",
        //                 "options_vega":"0",
        //                 "delta_total":"0"
        //             },
        //             "ETH":{
        //                 "currency":"ETH",
        //                 "balance":"0",
        //                 "freeze":"0",
        //                 "equity":"0",
        //                 "base_currency":"USDT",
        //                 "available_funds":"0",
        //                 "available_withdrawal_funds":"0",
        //                 "initial_margin":"0",
        //                 "maintenance_margin":"0",
        //                 "margin_balance":"0",
        //                 "session_funding":"0",
        //                 "session_rpl":"0",
        //                 "session_upl":"0",
        //                 "futures_pl":"0",
        //                 "futures_session_rpl":"0",
        //                 "futures_session_upl":"0",
        //                 "options_value":"0",
        //                 "options_pl":"0",
        //                 "options_session_rpl":"0",
        //                 "options_session_upl":"0",
        //                 "total_pl":"0",
        //                 "options_delta":"0",
        //                 "options_gamma":"0",
        //                 "options_theta":"0",
        //                 "options_vega":"0",
        //                 "delta_total":"0"
        //             },
        //             "PERPETUAL":{
        //                 "bonus":"0",
        //                 "global_state":0,
        //                 "available_funds":"0",
        //                 "wallet_balance":"0",
        //                 "available_withdraw_funds":"0",
        //                 "total_pl":"0",
        //                 "total_upl":"0",
        //                 "position_rpl":"0",
        //                 "total_upl_isolated":"0",
        //                 "total_upl_cross":"0",
        //                 "total_initial_margin_cross":"0",
        //                 "total_initial_margin_isolated":"0",
        //                 "total_margin_balance_isolated":"0",
        //                 "total_margin_balance":"0",
        //                 "total_margin_balance_cross":"0",
        //                 "total_maintenance_margin_cross":"0",
        //                 "total_wallet_balance_isolated":"0",
        //                 "order_frozen":"0",
        //                 "order_cross_frozen":"0",
        //                 "order_isolated_frozen":"0",
        //                 "risk_level":"0",
        //                 "bonus_max":"0"
        //             }
        //         }
        //     }
        //
        return this.parseBalance(result);
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "open", "open" },
            { "cancelled", "canceled" },
            { "filled", "closed" },
            { "rejected", "rejected" },
        };
        return this.safeString(statuses, status, status);
    }

    public virtual object parseTimeInForce(object timeInForce)
    {
        if (isTrue(isEqual(timeInForce, "-")))
        {
            return null;
        }
        object timeInForces = new Dictionary<string, object>() {
            { "good_til_cancelled", "GTC" },
            { "good_til_date", "GTD" },
            { "fill_or_kill", "FOK" },
            { "immediate_or_cancel", "IOC" },
        };
        return this.safeString(timeInForces, timeInForce, timeInForce);
    }

    public override object parseOrder(object order, object market = null)
    {
        //
        // fetchOrder || fetchOpenOrders || fetchClosedOrders
        //         {
        //             "kind":"spot",
        //             "direction":"sell",
        //             "amount":"0.02",
        //             "price":"900",
        //             "advanced":"usdt",
        //             "source":"api",
        //             "mmp":false,
        //             "version":1,
        //             "order_id":"250971492850401280",
        //             "order_state":"open",
        //             "instrument_name":"BNB-USDT-SPOT",
        //             "filled_amount":"0",
        //             "average_price":"0",
        //             "order_type":"limit",
        //             "time_in_force":"GTC",
        //             "post_only":false,
        //             "reduce_only":false,
        //             "creation_timestamp":1647666666723,
        //             "last_update_timestamp":1647666666725
        //         }
        //
        // createOrder
        //
        //         {
        //             "order_id":"251052889774161920",
        //             "custom_order_id":"-"
        //         }
        //
        // closeOrder
        //         {
        //             "order_id":"250979354159153152"
        //         }
        //
        object timestamp = this.safeInteger(order, "creation_timestamp");
        object lastUpdate = this.safeInteger(order, "last_update_timestamp");
        object id = this.safeString(order, "order_id");
        object priceString = this.safeString(order, "price");
        if (isTrue(isEqual(priceString, "-1")))
        {
            priceString = null;
        }
        object averageString = this.safeString(order, "average_price");
        object amountString = this.safeString(order, "amount");
        object filledString = this.safeString(order, "filled_amount");
        object status = this.parseOrderStatus(this.safeString(order, "order_state"));
        object marketId = this.safeString(order, "instrument_name");
        market = this.safeMarket(marketId, market);
        object side = this.safeStringLower(order, "direction");
        object feeCostString = this.safeString(order, "commission");
        object fee = null;
        if (isTrue(!isEqual(feeCostString, null)))
        {
            feeCostString = Precise.stringAbs(feeCostString);
            fee = new Dictionary<string, object>() {
                { "cost", feeCostString },
                { "currency", getValue(market, "base") },
            };
        }
        // injected in createOrder
        object trades = this.safeValue(order, "trades");
        object stopPrice = this.safeNumber(order, "trigger_price");
        return this.safeOrder(new Dictionary<string, object>() {
            { "info", order },
            { "id", id },
            { "clientOrderId", null },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "lastTradeTimestamp", lastUpdate },
            { "symbol", getValue(market, "symbol") },
            { "type", this.safeString(order, "order_type") },
            { "timeInForce", this.parseTimeInForce(this.safeString(order, "time_in_force")) },
            { "postOnly", this.safeValue(order, "post_only") },
            { "side", side },
            { "price", this.parseNumber(priceString) },
            { "stopPrice", stopPrice },
            { "triggerPrice", stopPrice },
            { "stopLossPrice", this.safeNumber(order, "stop_loss_price") },
            { "takeProfitPrice", this.safeNumber(order, "take_profit_price") },
            { "amount", amountString },
            { "cost", null },
            { "average", averageString },
            { "filled", filledString },
            { "remaining", null },
            { "status", status },
            { "fee", fee },
            { "trades", trades },
        }, market);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.signIn();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "order_id", id },
        };
        object response = await this.privateGetGetOrderState(this.extend(request, parameters));
        object result = this.safeValue(response, "result");
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647672034018,
        //         "usOut":1647672034033,
        //         "usDiff":15,
        //         "result":{
        //             "currency":"SPOT",
        //             "kind":"spot",
        //             "direction":"sell",
        //             "amount":"0.03",
        //             "price":"-1",
        //             "advanced":"usdt",
        //             "source":"api",
        //             "mmp":false,
        //             "version":1,
        //             "order_id":"250979478947823616",
        //             "order_state":"filled",
        //             "instrument_name":"BNB-USDT-SPOT",
        //             "filled_amount":"0.03",
        //             "average_price":"397.8",
        //             "order_type":"market",
        //             "time_in_force":"GTC",
        //             "post_only":false,
        //             "reduce_only":false,
        //             "creation_timestamp":1647668570759,
        //             "last_update_timestamp":1647668570761
        //         }
        //     }
        //
        return this.parseOrder(result);
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name btcex#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of the base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the btcex api endpoint
        * ----------------- Exchange Specific Parameters -----------------
        * @param {float|undefined} params.cost amount in USDT to spend for market orders
        * @param {float|undefined} params.triggerPrice price to trigger stop orders
        * @param {float|undefined} params.stopPrice price to trigger stop orders
        * @param {float|undefined} params.stopLossPrice price to trigger stop-loss orders (only for perpetuals)
        * @param {float|undefined} params.takeProfitPrice price to trigger take-profit orders (only for perpetuals)
        * @param {object|undefined} params.stopLoss for setting a stop-loss attached to an order, set the value of the stopLoss key 'price' (only for perpetuals)
        * @param {object|undefined} params.takeProfit for setting a take-profit attached to an order, set the value of the takeProfit key 'price' (only for perpetuals)
        * @param {int|undefined} params.trigger_price_type 1: mark-price, 2: last-price. (only for perpetuals)
        * @param {int|undefined} params.stop_loss_type 1: mark-price, 2: last-price (only for perpetuals)
        * @param {int|undefined} params.take_profit_type 1: mark-price, 2: last-price (only for perpetuals)
        * @param {bool|undefined} params.market_amount_order if set to true，then the amount field means USDT value (only for perpetuals)
        * @param {string|undefined} params.condition_type 'NORMAL', 'STOP', 'TRAILING', 'IF_TOUCHED'
        * @param {string|undefined} params.position_side 'BOTH', for one-way mode 'LONG' or 'SHORT', for hedge-mode
        * @param {string|undefined} params.timeInForce 'GTC', 'IOC', 'FOK'
        * @param {bool|undefined} params.postOnly
        * @param {bool|undefined} params.reduceOnly
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.signIn();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
            { "type", type },
        };
        if (isTrue(isTrue(isEqual(side, "sell")) || isTrue(isEqual(type, "limit"))))
        {
            ((Dictionary<string, object>)request)["amount"] = this.amountToPrecision(symbol, amount);
        }
        if (isTrue(isEqual(type, "limit")))
        {
            ((Dictionary<string, object>)request)["price"] = this.priceToPrecision(symbol, price);
        } else
        {
            object costParam = this.safeNumber(parameters, "cost");
            object amountString = this.numberToString(amount);
            object priceString = this.numberToString(price);
            object cost = this.parseNumber(Precise.stringMul(amountString, priceString), costParam);
            if (isTrue(getValue(market, "swap")))
            {
                if (isTrue(!isEqual(cost, null)))
                {
                    ((Dictionary<string, object>)request)["amount"] = this.priceToPrecision(symbol, cost);
                    ((Dictionary<string, object>)request)["market_amount_order"] = true;
                } else
                {
                    ((Dictionary<string, object>)request)["market_amount_order"] = false;
                    ((Dictionary<string, object>)request)["amount"] = this.amountToPrecision(symbol, amount);
                }
            } else
            {
                if (isTrue(isEqual(side, "buy")))
                {
                    object createMarketBuyOrderRequiresPrice = this.safeValue(this.options, "createMarketBuyOrderRequiresPrice", true);
                    if (isTrue(createMarketBuyOrderRequiresPrice))
                    {
                        if (isTrue(isEqual(cost, null)))
                        {
                            throw new InvalidOrder ((string)add(this.id, " createOrder() requires a price argument for market buy orders on spot markets to calculate the total amount to spend (amount * price), alternatively set the createMarketBuyOrderRequiresPrice option to false and pass in the cost to spend into the amount parameter")) ;
                        } else
                        {
                            ((Dictionary<string, object>)request)["amount"] = this.priceToPrecision(symbol, cost);
                        }
                    } else
                    {
                        ((Dictionary<string, object>)request)["amount"] = this.priceToPrecision(symbol, amount);
                    }
                }
            }
            parameters = this.omit(parameters, "cost");
        }
        if (isTrue(getValue(market, "swap")))
        {
            object timeInForce = this.safeStringUpper(parameters, "timeInForce");
            if (isTrue(isEqual(timeInForce, "GTC")))
            {
                ((Dictionary<string, object>)request)["time_in_force"] = "good_till_cancelled";
            } else if (isTrue(isEqual(timeInForce, "FOK")))
            {
                ((Dictionary<string, object>)request)["time_in_force"] = "fill_or_kill";
            } else if (isTrue(isEqual(timeInForce, "IOC")))
            {
                ((Dictionary<string, object>)request)["time_in_force"] = "immediate_or_cancel";
            }
            object isMarketOrder = isEqual(type, "market");
            object exchangeSpecificParam = this.safeValue(parameters, "post_only", false);
            object postOnly = this.isPostOnly(isMarketOrder, exchangeSpecificParam, parameters);
            if (isTrue(postOnly))
            {
                ((Dictionary<string, object>)request)["post_only"] = true;
            }
            object reduceOnly = this.safeValue(parameters, "reduceOnly", false);
            if (isTrue(reduceOnly))
            {
                ((Dictionary<string, object>)request)["reduce_only"] = true;
            }
            if (isTrue(isEqual(side, "buy")))
            {
                object requestType = ((bool) isTrue((reduceOnly))) ? "SHORT" : "LONG";
                ((Dictionary<string, object>)request)["position_side"] = requestType;
            } else
            {
                object requestType = ((bool) isTrue((reduceOnly))) ? "LONG" : "SHORT";
                ((Dictionary<string, object>)request)["position_side"] = requestType;
            }
            object stopPrice = this.safeNumber2(parameters, "triggerPrice", "stopPrice");
            object stopLossPrice = this.safeNumber(parameters, "stopLossPrice");
            object takeProfitPrice = this.safeNumber(parameters, "takeProfitPrice");
            object isStopLoss = this.safeValue(parameters, "stopLoss");
            object isTakeProfit = this.safeValue(parameters, "takeProfit");
            if (isTrue(stopPrice))
            {
                ((Dictionary<string, object>)request)["condition_type"] = "STOP";
                ((Dictionary<string, object>)request)["trigger_price"] = this.priceToPrecision(symbol, stopPrice);
                ((Dictionary<string, object>)request)["trigger_price_type"] = 1;
            } else if (isTrue(isTrue(stopLossPrice) || isTrue(takeProfitPrice)))
            {
                ((Dictionary<string, object>)request)["condition_type"] = "STOP";
                if (isTrue(stopLossPrice))
                {
                    ((Dictionary<string, object>)request)["trigger_price"] = this.priceToPrecision(symbol, stopLossPrice);
                } else
                {
                    ((Dictionary<string, object>)request)["trigger_price"] = this.priceToPrecision(symbol, takeProfitPrice);
                }
                ((Dictionary<string, object>)request)["reduce_only"] = true;
                ((Dictionary<string, object>)request)["trigger_price_type"] = 1;
            } else if (isTrue(isTrue(isStopLoss) || isTrue(isTakeProfit)))
            {
                if (isTrue(isStopLoss))
                {
                    stopLossPrice = this.safeNumber(isStopLoss, "price");
                    ((Dictionary<string, object>)request)["stop_loss_price"] = this.priceToPrecision(symbol, stopLossPrice);
                    ((Dictionary<string, object>)request)["stop_loss_type"] = 1;
                } else
                {
                    takeProfitPrice = this.safeNumber(isTakeProfit, "price");
                    ((Dictionary<string, object>)request)["take_profit_price"] = this.priceToPrecision(symbol, takeProfitPrice);
                    ((Dictionary<string, object>)request)["take_profit_type"] = 1;
                }
            }
            parameters = this.omit(parameters, new List<object>() {"timeInForce", "postOnly", "reduceOnly", "stopPrice", "triggerPrice", "stopLossPrice", "takeProfitPrice", "stopLoss", "takeProfit"});
        }
        object method = add("privatePost", this.capitalize(side));
        object response = await this.callAsync(method, this.extend(request, parameters));
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        //
        //     {
        //         "id":"1647686073",
        //         "jsonrpc":"2.0",
        //         "usIn":1647686073252,
        //         "usOut":1647686073264,
        //         "usDiff":12,
        //         "result":{
        //             "order":{
        //                 "order_id":"251052889774161920",
        //                 "custom_order_id":"-"
        //             }
        //         }
        //     }
        //
        object order = this.safeValue(result, "order");
        return this.parseOrder(order, market);
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.signIn();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "order_id", id },
        };
        object response = await this.privatePostCancel(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        //
        //     {
        //         "id":"1647675007",
        //         "jsonrpc":"2.0",
        //         "usIn":1647675007485,
        //         "usOut":1647675007494,
        //         "usDiff":9,
        //         "result":{
        //             "order_id":"250979354159153152"
        //         }
        //     }
        //
        return this.parseOrder(result);
    }

    public async override Task<object> cancelAllOrders(object symbol = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " cancelAllOrders() requires a symbol argument")) ;
        }
        await this.signIn();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        object response = await this.privatePostCancelAllByInstrument(this.extend(request, parameters));
        //
        //     {
        //         "id":"1647686580",
        //         "jsonrpc":"2.0",
        //         "usIn":1647686581216,
        //         "usOut":1647686581224,
        //         "usDiff":8,
        //         "result":2
        //     }
        //
        return response;
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOpenOrders() requires a symbol argument")) ;
        }
        await this.signIn();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        object response = await this.privateGetGetOpenOrdersByInstrument(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new List<object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647667026285,
        //         "usOut":1647667026291,
        //         "usDiff":6,
        //         "result":[{
        //             "kind":"spot",
        //             "direction":"sell",
        //             "amount":"0.02",
        //             "price":"900",
        //             "advanced":"usdt",
        //             "source":"api",
        //             "mmp":false,
        //             "version":1,
        //             "order_id":"250971492850401280",
        //             "order_state":"open",
        //             "instrument_name":"BNB-USDT-SPOT",
        //             "filled_amount":"0",
        //             "average_price":"0",
        //             "order_type":"limit",
        //             "time_in_force":"GTC",
        //             "post_only":false,
        //             "reduce_only":false,
        //             "creation_timestamp":1647666666723,
        //             "last_update_timestamp":1647666666725
        //         }]
        //     }
        //
        return this.parseOrders(result, market, since, limit);
    }

    public async override Task<object> fetchClosedOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchClosedOrders() requires a symbol argument")) ;
        }
        await this.signIn();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit;
        }
        object response = await this.privateGetGetOrderHistoryByInstrument(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new List<object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647671721716,
        //         "usOut":1647671721730,
        //         "usDiff":14,
        //         "result":[{
        //             "currency":"SPOT",
        //             "kind":"spot",
        //             "direction":"sell",
        //             "amount":"0.03",
        //             "price":"-1",
        //             "advanced":"usdt",
        //             "source":"api",
        //             "mmp":false,
        //             "version":1,
        //             "order_id":"250979478947823616",
        //             "order_state":"filled",
        //             "instrument_name":"BNB-USDT-SPOT",
        //             "filled_amount":"0.03",
        //             "average_price":"397.8",
        //             "order_type":"market",
        //             "time_in_force":"GTC",
        //             "post_only":false,
        //             "reduce_only":false,
        //             "creation_timestamp":1647668570759,
        //             "last_update_timestamp":1647668570761
        //         }]
        //     }
        //
        return this.parseOrders(result, market, since, limit);
    }

    public async virtual Task<object> fetchOrderTrades(object id, object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(id, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrderTrades() requires a id argument")) ;
        }
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "order_id", id },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit; // default 20
        }
        object response = await this.privateGetGetUserTradesByOrder(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647671425457,
        //         "usOut":1647671425470,
        //         "usDiff":13,
        //         "result":{
        //             "count":1,
        //             "trades":[{
        //                 "direction":"sell",
        //                 "amount":"0.03",
        //                 "price":"397.8",
        //                 "fee":"0.011934",
        //                 "timestamp":1647668570759,
        //                 "role":"taker",
        //                 "trade_id":"58319385",
        //                 "order_id":"250979478947823616",
        //                 "instrument_name":"BNB-USDT-SPOT",
        //                 "order_type":"market",
        //                 "fee_use_coupon":false,
        //                 "fee_coin_type":"USDT",
        //                 "index_price":"",
        //                 "self_trade":false
        //             }],
        //             "has_more":false
        //         }
        //     }
        //
        object trades = this.safeValue(result, "trades", new List<object>() {});
        return this.parseTrades(trades, null, since, limit);
    }

    public async override Task<object> fetchMyTrades(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchMyTrades() requires a id argument")) ;
        }
        await this.signIn();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object market = this.market(symbol);
        ((Dictionary<string, object>)request)["instrument_name"] = getValue(market, "id");
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit; // default 20
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["start_timestamp"] = since;
        }
        object response = await this.privateGetGetUserTradesByInstrument(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new Dictionary<string, object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647668582167,
        //         "usOut":1647668582187,
        //         "usDiff":20,
        //         "result":{
        //             "count":1,
        //             "trades":[{
        //                 "direction":"sell",
        //                 "amount":"0.03",
        //                 "price":"397.8",
        //                 "fee":"0.011934",
        //                 "timestamp":1647668570759,
        //                 "role":"taker",
        //                 "trade_id":"58319385",
        //                 "order_id":"250979478947823616",
        //                 "instrument_name":"BNB-USDT-SPOT",
        //                 "order_type":"market",
        //                 "fee_use_coupon":false,
        //                 "fee_coin_type":"USDT",
        //                 "index_price":"",
        //                 "self_trade":false
        //             }],
        //             "has_more":false
        //         }
        //     }
        //
        object trades = this.safeValue(result, "trades", new List<object>() {});
        return this.parseTrades(trades, market, since, limit);
    }

    public override object parsePosition(object position, object market = null)
    {
        //
        //     {
        //         "currency":"PERPETUAL",
        //         "kind":"perpetual",
        //         "size":"-0.08",
        //         "direction":"sell",
        //         "leverage":"3",
        //         "margin":"10.7724",
        //         "version":"553",
        //         "roe":"-0.000483",
        //         "traceType":0,
        //         "pos_id":"0",
        //         "instrument_name":"BNB-USDT-PERPETUAL",
        //         "average_price":"403.9",
        //         "mark_price":"403.965",
        //         "initial_margin":"10.77066668",
        //         "maintenance_margin":"0.2100618",
        //         "floating_profit_loss":"-0.0052",
        //         "liquid_price":"549.15437158",
        //         "margin_type":"cross",
        //         "risk_level":"0.017651",
        //         "available_withdraw_funds":"1.13004332",
        //         "order_id":"251085320510201856",
        //         "stop_loss_price":"0",
        //         "stop_loss_type":1,
        //         "take_profit_price":"0",
        //         "take_profit_type":1
        //     }
        //
        object contract = this.safeString(position, "instrument_name");
        market = this.safeMarket(contract, market);
        object size = this.safeString(position, "size");
        object side = this.safeString(position, "direction");
        side = ((bool) isTrue((isEqual(side, "buy")))) ? "long" : "short";
        object maintenanceMarginString = this.safeString(position, "maintenance_margin");
        object riskLevel = this.safeString(position, "risk_level");
        // maint_margin / collateral = risk_level
        // collateral = maint_margin / risk_level
        object collateral = Precise.stringDiv(maintenanceMarginString, riskLevel);
        object markPrice = this.safeString(position, "mark_price");
        object notionalString = Precise.stringMul(markPrice, size);
        object unrealisedPnl = this.safeString(position, "floating_profit_loss");
        object initialMarginString = this.safeString(position, "initial_margin");
        object percentage = Precise.stringMul(Precise.stringDiv(unrealisedPnl, initialMarginString), "100");
        object marginType = this.safeString(position, "margin_type");
        return new Dictionary<string, object>() {
            { "info", position },
            { "id", null },
            { "symbol", this.safeString(market, "symbol") },
            { "timestamp", null },
            { "datetime", null },
            { "initialMargin", this.parseNumber(initialMarginString) },
            { "initialMarginPercentage", this.parseNumber(Precise.stringDiv(initialMarginString, notionalString)) },
            { "maintenanceMargin", this.parseNumber(maintenanceMarginString) },
            { "maintenanceMarginPercentage", this.parseNumber(Precise.stringDiv(maintenanceMarginString, notionalString)) },
            { "entryPrice", this.safeNumber(position, "average_price") },
            { "notional", this.parseNumber(notionalString) },
            { "leverage", this.safeNumber(position, "leverage") },
            { "unrealizedPnl", this.parseNumber(unrealisedPnl) },
            { "contracts", this.parseNumber(size) },
            { "contractSize", this.safeValue(market, "contractSize") },
            { "marginRatio", this.parseNumber(riskLevel) },
            { "liquidationPrice", this.safeNumber(position, "liquid_price") },
            { "markPrice", this.parseNumber(markPrice) },
            { "collateral", this.parseNumber(collateral) },
            { "marginType", marginType },
            { "side", side },
            { "percentage", this.parseNumber(percentage) },
        };
    }

    public async override Task<object> fetchPosition(object symbol, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.signIn();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        object response = await this.privateGetGetPosition(this.extend(request, parameters));
        object result = this.safeValue(response, "result");
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647693832273,
        //         "usOut":1647693832282,
        //         "usDiff":9,
        //         "result":{
        //             "currency":"PERPETUAL",
        //             "kind":"perpetual",
        //             "size":"-0.08",
        //             "direction":"sell",
        //             "leverage":"3",
        //             "margin":"10.7724",
        //             "version":"553",
        //             "roe":"-0.000483",
        //             "traceType":0,
        //             "pos_id":"0",
        //             "instrument_name":"BNB-USDT-PERPETUAL",
        //             "average_price":"403.9",
        //             "mark_price":"403.965",
        //             "initial_margin":"10.77066668",
        //             "maintenance_margin":"0.2100618",
        //             "floating_profit_loss":"-0.0052",
        //             "liquid_price":"549.15437158",
        //             "margin_type":"cross",
        //             "risk_level":"0.017651",
        //             "available_withdraw_funds":"1.13004332",
        //             "order_id":"251085320510201856",
        //             "stop_loss_price":"0",
        //             "stop_loss_type":1,
        //             "take_profit_price":"0",
        //             "take_profit_type":1
        //         }
        //     }
        //
        return this.parsePosition(result);
    }

    public async override Task<object> fetchPositions(object symbols = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.signIn();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "currency", "PERPETUAL" },
        };
        object response = await this.privateGetGetPositions(this.extend(request, parameters));
        object result = this.safeValue(response, "result");
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647694531356,
        //         "usOut":1647694531364,
        //         "usDiff":8,
        //         "result":[{
        //             "currency":"PERPETUAL",
        //             "kind":"perpetual",
        //             "size":"-0.08",
        //             "direction":"sell",
        //             "leverage":"3",
        //             "margin":"10.7836",
        //             "version":"1251",
        //             "roe":"-0.003602",
        //             "traceType":0,
        //             "pos_id":"0",
        //             "instrument_name":"BNB-USDT-PERPETUAL",
        //             "average_price":"403.9",
        //             "mark_price":"404.385",
        //             "initial_margin":"10.77066668",
        //             "maintenance_margin":"0.2102802",
        //             "floating_profit_loss":"-0.0388",
        //             "liquid_price":"549.15437158",
        //             "margin_type":"cross",
        //             "risk_level":"0.01772",
        //             "available_withdraw_funds":"1.09644332",
        //             "order_id":"251085320510201856",
        //             "stop_loss_price":"0",
        //             "stop_loss_type":1,
        //             "take_profit_price":"0",
        //             "take_profit_type":1
        //         }]
        //     }
        //
        return this.parsePositions(result, symbols);
    }

    public virtual object parseTransactionStatus(object status)
    {
        object states = new Dictionary<string, object>() {
            { "deposit_confirmed", "ok" },
            { "deposit_waiting_confirm", "pending" },
            { "withdraw_init", "pending" },
            { "withdraw_noticed_block_chain", "pending" },
            { "withdraw_waiting_confirm", "pending" },
            { "withdraw_confirmed", "ok" },
            { "withdraw_failed", "failed" },
            { "withdraw_auditing", "pending" },
            { "withdraw_audit_reject", "failed" },
        };
        return this.safeString(states, status, status);
    }

    public override object parseTransaction(object transaction, object currency = null)
    {
        //
        // fetchDeposits
        //         {
        //             "id":"250325458128736256",
        //             "amount":"0.04",
        //             "state":"deposit_confirmed",
        //             "coin_type":"BNB",
        //             "token_code":"BNB",
        //             "create_time":"1647512640040",
        //             "update_time":"1647512640053",
        //             "tx_hash":"",
        //             "full_name":"Binance Coin"
        //         }
        //
        // fetchWithdrawals || fetchWithdraw
        //         {
        //             "id":"251076247882829824",
        //             "address":"",
        //             "amount":"0.01",
        //             "state":"withdraw_auditing",
        //             "coin_type":"BNB",
        //             "create_time":"1647691642267",
        //             "update_time":"1647691650090",
        //             "full_name":"Binance Coin",
        //             "token_code":"BNB"
        //         }
        //
        object currencyId = this.safeString(transaction, "coin_type");
        object code = this.safeCurrencyCode(currencyId, currency);
        object id = this.safeString(transaction, "id");
        object txId = this.safeString(transaction, "tx_hash");
        object timestamp = this.safeInteger(transaction, "create_time");
        object updated = this.safeInteger(transaction, "update_time");
        object amount = this.safeNumber(transaction, "amount");
        object status = this.safeString(transaction, "state");
        return new Dictionary<string, object>() {
            { "info", transaction },
            { "id", id },
            { "txid", txId },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "network", null },
            { "addressFrom", null },
            { "address", null },
            { "addressTo", null },
            { "tagFrom", null },
            { "tag", null },
            { "tagTo", null },
            { "type", null },
            { "amount", amount },
            { "currency", code },
            { "status", this.parseTransactionStatus(status) },
            { "updated", updated },
            { "fee", null },
        };
    }

    public async override Task<object> fetchDeposits(object code = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(code, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchDeposits() requires the code argument")) ;
        }
        await this.signIn();
        await this.loadMarkets();
        object currency = this.safeCurrency(code);
        object request = new Dictionary<string, object>() {
            { "coin_type", getValue(currency, "id") },
        };
        object response = await this.privateGetGetDepositRecord(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new List<object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647606752447,
        //         "usOut":1647606752457,
        //         "usDiff":10,
        //         "result":[{
        //             "id":"250325458128736256",
        //             "amount":"0.04",
        //             "state":"deposit_confirmed",
        //             "coin_type":"BNB",
        //             "token_code":"BNB",
        //             "create_time":"1647512640040",
        //             "update_time":"1647512640053",
        //             "tx_hash":"",
        //             "full_name":"Binance Coin"
        //         }]
        //     }
        //     }
        //
        return this.parseTransactions(result, currency, since, limit, new Dictionary<string, object>() {
            { "type", "deposit" },
        });
    }

    public async override Task<object> fetchWithdrawals(object code = null, object since = null, object limit = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(code, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchWithdrawals() requires the code argument")) ;
        }
        await this.signIn();
        await this.loadMarkets();
        object currency = this.safeCurrency(code);
        object request = new Dictionary<string, object>() {
            { "coin_type", getValue(currency, "id") },
        };
        object response = await this.privateGetGetWithdrawRecord(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new List<object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647691750112,
        //         "usOut":1647691750125,
        //         "usDiff":13,
        //         "result":[{
        //             "id":"251076247882829824",
        //             "address":"",
        //             "amount":"0.01",
        //             "state":"withdraw_auditing",
        //             "coin_type":"BNB",
        //             "create_time":"1647691642267",
        //             "update_time":"1647691650090",
        //             "full_name":"Binance Coin",
        //             "token_code":"BNB"
        //         }]
        //     }
        //
        return this.parseTransactions(result, currency, since, limit, new Dictionary<string, object>() {
            { "type", "withdrawal" },
        });
    }

    public async virtual Task<object> fetchWithdrawal(object id, object code = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(code, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchWithdrawal() requires the code argument")) ;
        }
        await this.signIn();
        await this.loadMarkets();
        object currency = this.safeCurrency(code);
        object request = new Dictionary<string, object>() {
            { "coin_type", getValue(currency, "id") },
            { "withdraw_id", id },
        };
        object response = await this.privateGetGetWithdrawRecord(this.extend(request, parameters));
        object result = this.safeValue(response, "result", new List<object>() {});
        //
        //     {
        //         "jsonrpc":"2.0",
        //         "usIn":1647691750112,
        //         "usOut":1647691750125,
        //         "usDiff":13,
        //         "result":[{
        //             "id":"251076247882829824",
        //             "address":"",
        //             "amount":"0.01",
        //             "state":"withdraw_auditing",
        //             "coin_type":"BNB",
        //             "create_time":"1647691642267",
        //             "update_time":"1647691650090",
        //             "full_name":"Binance Coin",
        //             "token_code":"BNB"
        //         }]
        //     }
        //
        object records = this.filterBy(result, "id", id);
        object record = this.safeValue(records, 0);
        return this.parseTransaction(record, currency);
    }

    public async virtual Task<object> fetchLeverage(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name btcex#fetchLeverage
        * @see https://docs.btcex.com/#get-perpetual-instrument-config
        * @description fetch the set leverage for a market
        * @param {string} symbol unified market symbol
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {object} a [leverage structure]{@link https://docs.ccxt.com/#/?id=leverage-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.signIn();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        object response = await this.privateGetGetPerpetualUserConfig(this.extend(request, parameters));
        //
        //     {
        //         "jsonrpc": "2.0",
        //         "usIn": 1674182494283,
        //         "usOut": 1674182494294,
        //         "usDiff": 11,
        //         "result": {
        //             "margin_type": "cross",
        //             "leverage": "20",
        //             "instrument_name": "BTC-USDT-PERPETUAL",
        //             "time": "1674182494293"
        //         }
        //     }
        //
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        return this.safeNumber(data, "leverage");
    }

    public async override Task<object> fetchMarketLeverageTiers(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name btcex#fetchMarketLeverageTiers
        * @see https://docs.btcex.com/#get-perpetual-instrument-leverage-config
        * @description retrieve information on the maximum leverage, for different trade sizes for a single market
        * @param {string} symbol unified market symbol
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {object} a [leverage tiers structure]{@link https://docs.ccxt.com/#/?id=leverage-tiers-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        if (!isTrue(getValue(market, "swap")))
        {
            throw new BadRequest ((string)add(this.id, " fetchMarketLeverageTiers() supports swap markets only")) ;
        }
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
        };
        object response = await this.publicGetGetPerpetualLeverageBracket(this.extend(request, parameters));
        //
        //     {
        //         "jsonrpc": "2.0",
        //         "usIn": 1674184074454,
        //         "usOut": 1674184074457,
        //         "usDiff": 3,
        //         "result": [
        //             {
        //                 "bracket": 1,
        //                 "initialLeverage": 125,
        //                 "maintenanceMarginRate": "0.004",
        //                 "notionalCap": "50000",
        //                 "notionalFloor": "0",
        //                 "cum": "0"
        //             },
        //             ...
        //         ]
        //     }
        //
        object data = this.safeValue(response, "result", new List<object>() {});
        return this.parseMarketLeverageTiers(data, market);
    }

    public override object parseMarketLeverageTiers(object info, object market = null)
    {
        //
        //     [
        //         {
        //             "bracket": 1,
        //             "initialLeverage": 125,
        //             "maintenanceMarginRate": "0.004",
        //             "notionalCap": "50000",
        //             "notionalFloor": "0",
        //             "cum": "0"
        //         },
        //         ...
        //     ]
        //
        object tiers = new List<object>() {};
        object brackets = info;
        for (object i = 0; isLessThan(i, getArrayLength(brackets)); postFixIncrement(ref i))
        {
            object tier = getValue(brackets, i);
            ((List<object>)tiers).Add(new Dictionary<string, object>() {
                { "tier", this.safeInteger(tier, "bracket") },
                { "currency", getValue(market, "settle") },
                { "minNotional", this.safeNumber(tier, "notionalFloor") },
                { "maxNotional", this.safeNumber(tier, "notionalCap") },
                { "maintenanceMarginRate", this.safeNumber(tier, "maintenanceMarginRate") },
                { "maxLeverage", this.safeNumber(tier, "initialLeverage") },
                { "info", tier },
            });
        }
        return tiers;
    }

    public async override Task<object> fetchLeverageTiers(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name btcex#fetchLeverageTiers
        * @see https://docs.btcex.com/#get-all-perpetual-instrument-leverage-config
        * @description retrieve information on the maximum leverage, for different trade sizes
        * @param {[string]|undefined} symbols a list of unified market symbols
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {object} a dictionary of [leverage tiers structures]{@link https://docs.ccxt.com/#/?id=leverage-tiers-structure}, indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.publicGetGetPerpetualLeverageBracketAll(parameters);
        //
        //     {
        //         "jsonrpc": "2.0",
        //         "usIn": 1674183578745,
        //         "usOut": 1674183578752,
        //         "usDiff": 7,
        //         "result": {
        //             "WAVES-USDT-PERPETUAL": [
        //                 {
        //                     "bracket": 1,
        //                     "initialLeverage": 50,
        //                     "maintenanceMarginRate": "0.01",
        //                     "notionalCap": "50000",
        //                     "notionalFloor": "0",
        //                     "cum": "0"
        //                 },
        //                 ...
        //             ]
        //         }
        //     }
        //
        object data = this.safeValue(response, "result", new Dictionary<string, object>() {});
        symbols = this.marketSymbols(symbols);
        return this.parseLeverageTiers(data, symbols, "symbol");
    }

    public override object parseLeverageTiers(object response, object symbols = null, object marketIdKey = null)
    {
        //
        //     {
        //         "WAVES-USDT-PERPETUAL": [
        //             {
        //                 "bracket": 1,
        //                 "initialLeverage": 50,
        //                 "maintenanceMarginRate": "0.01",
        //                 "notionalCap": "50000",
        //                 "notionalFloor": "0",
        //                 "cum": "0"
        //             },
        //             ...
        //         ]
        //     }
        //
        object tiers = new Dictionary<string, object>() {};
        object result = new Dictionary<string, object>() {};
        object marketIds = new List<string>(((Dictionary<string,object>)response).Keys);
        for (object i = 0; isLessThan(i, getArrayLength(marketIds)); postFixIncrement(ref i))
        {
            object marketId = getValue(marketIds, i);
            object entry = getValue(response, marketId);
            object market = this.safeMarket(marketId);
            object symbol = this.safeSymbol(marketId, market);
            object symbolsLength = 0;
            ((Dictionary<string, object>)tiers)[(string)symbol] = this.parseMarketLeverageTiers(entry, market);
            if (isTrue(!isEqual(symbols, null)))
            {
                symbolsLength = getArrayLength(symbols);
                if (isTrue(this.inArray(symbol, symbols)))
                {
                    ((Dictionary<string, object>)result)[(string)symbol] = this.parseMarketLeverageTiers(entry, market);
                }
            }
            if (isTrue(isTrue(!isEqual(symbol, null)) && isTrue((isTrue(isEqual(symbolsLength, 0)) || isTrue(this.inArray(symbol, symbols))))))
            {
                ((Dictionary<string, object>)result)[(string)symbol] = this.parseMarketLeverageTiers(entry, market);
            }
        }
        return result;
    }

    public async virtual Task<object> setMarginMode(object marginMode, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name btcex#setMarginMode
        * @description set margin mode to 'cross' or 'isolated'
        * @see https://docs.btcex.com/#modify-perpetual-instrument-margin-type
        * @param {string} marginMode 'cross' or 'isolated'
        * @param {string|undefined} symbol unified market symbol
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {object} response from the exchange
        */
        parameters ??= new Dictionary<string, object>();
        this.checkRequiredSymbol("setMarginMode", symbol);
        await this.signIn();
        await this.loadMarkets();
        object market = this.market(symbol);
        if (!isTrue(getValue(market, "swap")))
        {
            throw new BadRequest ((string)add(this.id, " setMarginMode() supports swap contracts only")) ;
        }
        if (isTrue(isTrue(isTrue((!isEqual(marginMode, "isolated"))) && isTrue((!isEqual(marginMode, "isolate")))) && isTrue((!isEqual(marginMode, "cross")))))
        {
            throw new BadRequest ((string)add(this.id, " marginMode must be either isolated or cross")) ;
        }
        marginMode = ((bool) isTrue((isEqual(marginMode, "isolated")))) ? "isolate" : "cross";
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
            { "margin_type", marginMode },
        };
        object result = await this.privatePostAdjustPerpetualMarginType(this.extend(request, parameters));
        //
        //     {
        //         "id": "1674857919",
        //         "jsonrpc": "2.0",
        //         "usIn": 1674857920070,
        //         "usOut": 1674857920079,
        //         "usDiff": 9,
        //         "result": "ok"
        //     }
        //
        return result;
    }

    public async override Task<object> setLeverage(object leverage, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name btcex#setLeverage
        * @description set the leverage amount for a market
        * @see https://docs.btcex.com/#modify-perpetual-instrument-leverage
        * @param {float} leverage the rate of leverage
        * @param {string} symbol unified market symbol
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {object} response from the exchange
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " setLeverage() requires a symbol argument")) ;
        }
        await this.signIn();
        await this.loadMarkets();
        this.checkRequiredSymbol("setLeverage", symbol);
        object market = this.market(symbol);
        if (!isTrue(getValue(market, "swap")))
        {
            throw new BadRequest ((string)add(this.id, " setLeverage() supports swap contracts only")) ;
        }
        if (isTrue(isTrue((isLessThan(leverage, 1))) || isTrue((isGreaterThan(leverage, 125)))))
        {
            throw new BadRequest ((string)add(this.id, " leverage should be between 1 and 125")) ;
        }
        object request = new Dictionary<string, object>() {
            { "instrument_name", getValue(market, "id") },
            { "leverage", leverage },
        };
        object response = await this.privatePostAdjustPerpetualLeverage(this.extend(request, parameters));
        //
        //     {
        //         "id": "1674856410",
        //         "jsonrpc": "2.0",
        //         "usIn": 1674856410930,
        //         "usOut": 1674856410988,
        //         "usDiff": 58,
        //         "result": "ok"
        //     }
        //
        return response;
    }

    public async override Task<object> fetchFundingRates(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name btcex#fetchFundingRates
        * @description fetch the current funding rates
        * @see https://docs.btcex.com/#contracts
        * @param {[string]} symbols unified market symbols
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {[object]} an array of [funding rate structures]{@link https://docs.ccxt.com/#/?id=funding-rate-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        symbols = this.marketSymbols(symbols);
        object response = await this.publicGetCoinGeckoContracts(parameters);
        //
        //     {
        //         "jsonrpc": "2.0",
        //         "usIn": 1674803585896,
        //         "usOut": 1674803585943,
        //         "usDiff": 47,
        //         "result": [
        //             {
        //                 "ticker_id": "BTC-USDT-PERPETUAL",
        //                 "base_currency": "BTC",
        //                 "target_currency": "USDT",
        //                 "last_price": "23685",
        //                 "base_volume": "167011.37199999999999989",
        //                 "target_volume": "3837763191.33800288010388613",
        //                 "bid": "23684.5",
        //                 "ask": "23685",
        //                 "high": "23971.5",
        //                 "low": "23156",
        //                 "product_type": "perpetual",
        //                 "open_interest": "24242.36",
        //                 "index_price": "23686.4",
        //                 "index_name": "BTC-USDT",
        //                 "index_currency": "BTC",
        //                 "start_timestamp": 1631004005882,
        //                 "funding_rate": "0.000187",
        //                 "next_funding_rate_timestamp": 1675065600000,
        //                 "contract_type": "Quanto",
        //                 "contract_price": "23685",
        //                 "contract_price_currency": "USDT"
        //             },
        //         ]
        //     }
        //
        object data = this.safeValue(response, "result", new List<object>() {});
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object entry = getValue(data, i);
            object marketId = this.safeString(entry, "ticker_id");
            object market = this.safeMarket(marketId);
            object symbol = getValue(market, "symbol");
            if (isTrue(!isEqual(symbols, null)))
            {
                if (isTrue(this.inArray(symbol, symbols)))
                {
                    ((Dictionary<string, object>)result)[(string)symbol] = this.parseFundingRate(entry, market);
                }
            } else
            {
                ((Dictionary<string, object>)result)[(string)symbol] = this.parseFundingRate(entry, market);
            }
        }
        return this.filterByArray(result, "symbol", symbols);
    }

    public async override Task<object> fetchFundingRate(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name btcex#fetchFundingRate
        * @description fetch the current funding rate
        * @see https://docs.btcex.com/#contracts
        * @param {string} symbol unified market symbol
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {object} a [funding rate structure]{@link https://docs.ccxt.com/#/?id=funding-rate-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object response = await this.publicGetCoinGeckoContracts(parameters);
        //
        //     {
        //         "jsonrpc": "2.0",
        //         "usIn": 1674803585896,
        //         "usOut": 1674803585943,
        //         "usDiff": 47,
        //         "result": [
        //             {
        //                 "ticker_id": "BTC-USDT-PERPETUAL",
        //                 "base_currency": "BTC",
        //                 "target_currency": "USDT",
        //                 "last_price": "23685",
        //                 "base_volume": "167011.37199999999999989",
        //                 "target_volume": "3837763191.33800288010388613",
        //                 "bid": "23684.5",
        //                 "ask": "23685",
        //                 "high": "23971.5",
        //                 "low": "23156",
        //                 "product_type": "perpetual",
        //                 "open_interest": "24242.36",
        //                 "index_price": "23686.4",
        //                 "index_name": "BTC-USDT",
        //                 "index_currency": "BTC",
        //                 "start_timestamp": 1631004005882,
        //                 "funding_rate": "0.000187",
        //                 "next_funding_rate_timestamp": 1675065600000,
        //                 "contract_type": "Quanto",
        //                 "contract_price": "23685",
        //                 "contract_price_currency": "USDT"
        //             },
        //         ]
        //     }
        //
        object data = this.safeValue(response, "result", new List<object>() {});
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object entry = getValue(data, i);
            object marketId = this.safeString(entry, "ticker_id");
            if (isTrue(isEqual(marketId, getValue(market, "id"))))
            {
                return this.parseFundingRate(entry, market);
            }
        }
        return this.parseFundingRate(data, market);
    }

    public override object parseFundingRate(object contract, object market = null)
    {
        //
        //     {
        //         "ticker_id": "BTC-USDT-PERPETUAL",
        //         "base_currency": "BTC",
        //         "target_currency": "USDT",
        //         "last_price": "23685",
        //         "base_volume": "167011.37199999999999989",
        //         "target_volume": "3837763191.33800288010388613",
        //         "bid": "23684.5",
        //         "ask": "23685",
        //         "high": "23971.5",
        //         "low": "23156",
        //         "product_type": "perpetual",
        //         "open_interest": "24242.36",
        //         "index_price": "23686.4",
        //         "index_name": "BTC-USDT",
        //         "index_currency": "BTC",
        //         "start_timestamp": 1631004005882,
        //         "funding_rate": "0.000187",
        //         "next_funding_rate_timestamp": 1675065600000,
        //         "contract_type": "Quanto",
        //         "contract_price": "23685",
        //         "contract_price_currency": "USDT"
        //     }
        //
        object marketId = this.safeString(contract, "ticker_id");
        object fundingTimestamp = this.safeInteger(contract, "next_funding_rate_timestamp");
        return new Dictionary<string, object>() {
            { "info", contract },
            { "symbol", this.safeSymbol(marketId, market) },
            { "markPrice", null },
            { "indexPrice", this.safeNumber(contract, "index_price") },
            { "interestRate", null },
            { "estimatedSettlePrice", null },
            { "timestamp", null },
            { "datetime", null },
            { "fundingRate", this.safeNumber(contract, "funding_rate") },
            { "fundingTimestamp", fundingTimestamp },
            { "fundingDatetime", this.iso8601(fundingTimestamp) },
            { "nextFundingRate", null },
            { "nextFundingTimestamp", null },
            { "nextFundingDatetime", null },
            { "previousFundingRate", null },
            { "previousFundingTimestamp", null },
            { "previousFundingDatetime", null },
        };
    }

    public async override Task<object> transfer(object code, object amount, object fromAccount, object toAccount, object parameters = null)
    {
        /**
        * @method
        * @name btcex#transfer
        * @description transfer currency internally between wallets on the same account
        * @see https://docs.btcex.com/#asset-transfer
        * @param {string} code unified currency code
        * @param {float} amount amount to transfer
        * @param {string} fromAccount account to transfer from
        * @param {string} toAccount account to transfer to
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {object} a [transfer structure]{@link https://docs.ccxt.com/#/?id=transfer-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.signIn();
        await this.loadMarkets();
        object currency = this.currency(code);
        object accountsByType = this.safeValue(this.options, "accountsByType", new Dictionary<string, object>() {});
        object fromId = this.safeString(accountsByType, fromAccount, fromAccount);
        object toId = this.safeString(accountsByType, toAccount, toAccount);
        object request = new Dictionary<string, object>() {
            { "coin_type", getValue(currency, "id") },
            { "amount", this.currencyToPrecision(code, amount) },
            { "from", fromId },
            { "to", toId },
        };
        object response = await this.privatePostSubmitTransfer(this.extend(request, parameters));
        //
        //     {
        //         "id": "1674937273",
        //         "jsonrpc": "2.0",
        //         "usIn": 1674937274762,
        //         "usOut": 1674937274774,
        //         "usDiff": 12,
        //         "result": "ok"
        //     }
        //
        return this.parseTransfer(response, currency);
    }

    public override object parseTransfer(object transfer, object currency = null)
    {
        //
        //     {
        //         "id": "1674937273",
        //         "jsonrpc": "2.0",
        //         "usIn": 1674937274762,
        //         "usOut": 1674937274774,
        //         "usDiff": 12,
        //         "result": "ok"
        //     }
        //
        return new Dictionary<string, object>() {
            { "info", transfer },
            { "id", this.safeString(transfer, "id") },
            { "timestamp", null },
            { "datetime", null },
            { "currency", null },
            { "amount", null },
            { "fromAccount", null },
            { "toAccount", null },
            { "status", null },
        };
    }

    public async virtual Task<object> fetchOpenInterest(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name btcex#fetchOpenInterest
        * @description fetch the open interest of a market
        * @see https://docs.btcex.com/#contracts
        * @param {string} symbol unified CCXT market symbol
        * @param {object} params extra parameters specific to the btcex api endpoint
        * @returns {object} an open interest structure{@link https://docs.ccxt.com/#/?id=interest-history-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        if (!isTrue(getValue(market, "contract")))
        {
            throw new BadRequest ((string)add(this.id, " fetchOpenInterest() supports contract markets only")) ;
        }
        object response = await this.publicGetCoinGeckoContracts(parameters);
        //
        //     {
        //         "jsonrpc": "2.0",
        //         "usIn": 1674803585896,
        //         "usOut": 1674803585943,
        //         "usDiff": 47,
        //         "result": [
        //             {
        //                 "ticker_id": "BTC-USDT-PERPETUAL",
        //                 "base_currency": "BTC",
        //                 "target_currency": "USDT",
        //                 "last_price": "23685",
        //                 "base_volume": "167011.37199999999999989",
        //                 "target_volume": "3837763191.33800288010388613",
        //                 "bid": "23684.5",
        //                 "ask": "23685",
        //                 "high": "23971.5",
        //                 "low": "23156",
        //                 "product_type": "perpetual",
        //                 "open_interest": "24242.36",
        //                 "index_price": "23686.4",
        //                 "index_name": "BTC-USDT",
        //                 "index_currency": "BTC",
        //                 "start_timestamp": 1631004005882,
        //                 "funding_rate": "0.000187",
        //                 "next_funding_rate_timestamp": 1675065600000,
        //                 "contract_type": "Quanto",
        //                 "contract_price": "23685",
        //                 "contract_price_currency": "USDT"
        //             },
        //         ]
        //     }
        //
        object data = this.safeValue(response, "result", new List<object>() {});
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object entry = getValue(data, i);
            object marketId = this.safeString(entry, "ticker_id");
            if (isTrue(isEqual(marketId, getValue(market, "id"))))
            {
                return this.parseOpenInterest(entry, market);
            }
        }
        return this.parseOpenInterest(data, market);
    }

    public override object parseOpenInterest(object interest, object market = null)
    {
        //
        //     {
        //         "ticker_id": "BTC-USDT-PERPETUAL",
        //         "base_currency": "BTC",
        //         "target_currency": "USDT",
        //         "last_price": "23685",
        //         "base_volume": "167011.37199999999999989",
        //         "target_volume": "3837763191.33800288010388613",
        //         "bid": "23684.5",
        //         "ask": "23685",
        //         "high": "23971.5",
        //         "low": "23156",
        //         "product_type": "perpetual",
        //         "open_interest": "24242.36",
        //         "index_price": "23686.4",
        //         "index_name": "BTC-USDT",
        //         "index_currency": "BTC",
        //         "start_timestamp": 1631004005882,
        //         "funding_rate": "0.000187",
        //         "next_funding_rate_timestamp": 1675065600000,
        //         "contract_type": "Quanto",
        //         "contract_price": "23685",
        //         "contract_price_currency": "USDT"
        //     }
        //
        object marketId = this.safeString(interest, "ticker_id");
        market = this.safeMarket(marketId, market);
        object openInterest = this.safeNumber(interest, "open_interest");
        return new Dictionary<string, object>() {
            { "info", interest },
            { "symbol", getValue(market, "symbol") },
            { "baseVolume", openInterest },
            { "quoteVolume", null },
            { "openInterestAmount", openInterest },
            { "openInterestValue", null },
            { "timestamp", null },
            { "datetime", null },
        };
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object request = add(add(add(add(add(add("/", "api/"), this.version), "/"), api), "/"), path);
        if (isTrue(isEqual(api, "public")))
        {
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)parameters).Keys))))
            {
                request = add(request, add("?", this.urlencode(parameters)));
            }
        }
        if (isTrue(isEqual(api, "private")))
        {
            this.checkRequiredCredentials();
            if (isTrue(isEqual(method, "GET")))
            {
                if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)parameters).Keys))))
                {
                    request = add(request, add("?", this.urlencode(parameters)));
                }
            }
            object sessionToken = this.safeString(this.options, "accessToken");
            if (isTrue(isEqual(sessionToken, null)))
            {
                throw new AuthenticationError ((string)add(this.id, " sign() requires access token")) ;
            }
            headers = new Dictionary<string, object>() {
                { "Authorization", add("bearer ", sessionToken) },
            };
            if (isTrue(isEqual(method, "POST")))
            {
                ((Dictionary<string, object>)headers)["Content-Type"] = "application/json";
                if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)parameters).Keys))))
                {
                    object rpcPayload = new Dictionary<string, object>() {
                        { "jsonrpc", "2.0" },
                        { "id", this.nonce() },
                        { "method", add(add(add("/", api), "/"), path) },
                        { "params", parameters },
                    };
                    body = this.json(rpcPayload);
                }
            }
        }
        object url = add(getValue(getValue(this.urls, "api"), "rest"), request);
        return new Dictionary<string, object>() {
            { "url", url },
            { "method", method },
            { "body", body },
            { "headers", headers },
        };
    }

    public override object handleErrors(object code, object reason, object url, object method, object headers, object body, object response, object requestHeaders, object requestBody)
    {
        if (isTrue(isEqual(response, null)))
        {
            return null;  // fallback to the default error handler
        }
        object error = this.safeValue(response, "error");
        if (isTrue(error))
        {
            object feedback = add(add(this.id, " "), body);
            object codeInner = this.safeString(error, "code");
            object message = this.safeString(error, "message");
            this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), codeInner, feedback);
            this.throwBroadlyMatchedException(getValue(this.exceptions, "broad"), message, feedback);
            throw new ExchangeError ((string)feedback) ;
        }
        return null;
    }
}
