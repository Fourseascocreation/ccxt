using Main;
namespace Main;

partial class bitforex : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "bitforex" },
            { "name", "Bitforex" },
            { "countries", new List<object>() {"CN"} },
            { "rateLimit", 500 },
            { "version", "v1" },
            { "has", new Dictionary<string, object>() {
                { "CORS", null },
                { "spot", true },
                { "margin", false },
                { "swap", null },
                { "future", false },
                { "option", false },
                { "cancelOrder", true },
                { "createOrder", true },
                { "createStopLimitOrder", false },
                { "createStopMarketOrder", false },
                { "createStopOrder", false },
                { "fetchBalance", true },
                { "fetchBorrowRate", false },
                { "fetchBorrowRateHistories", false },
                { "fetchBorrowRateHistory", false },
                { "fetchBorrowRates", false },
                { "fetchBorrowRatesPerSymbol", false },
                { "fetchClosedOrders", true },
                { "fetchMarginMode", false },
                { "fetchMarkets", true },
                { "fetchMyTrades", false },
                { "fetchOHLCV", true },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchPositionMode", false },
                { "fetchTicker", true },
                { "fetchTickers", false },
                { "fetchTrades", true },
                { "fetchTransactionFees", false },
                { "fetchTransfer", false },
                { "fetchTransfers", false },
                { "fetchWithdrawal", false },
                { "fetchWithdrawals", false },
                { "transfer", false },
                { "withdraw", false },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "1min" },
                { "5m", "5min" },
                { "15m", "15min" },
                { "30m", "30min" },
                { "1h", "1hour" },
                { "2h", "2hour" },
                { "4h", "4hour" },
                { "12h", "12hour" },
                { "1d", "1day" },
                { "1w", "1week" },
                { "1M", "1month" },
            } },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/51840849/87295553-1160ec00-c50e-11ea-8ea0-df79276a9646.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "rest", "https://api.bitforex.com" },
                } },
                { "www", "https://www.bitforex.com" },
                { "doc", "https://github.com/githubdev2020/API_Doc_en/wiki" },
                { "fees", "https://help.bitforex.com/en_us/?cat=13" },
                { "referral", "https://www.bitforex.com/en/invitationRegister?inviterId=1867438" },
            } },
            { "api", new Dictionary<string, object>() {
                { "public", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "api/v1/market/symbols", 20 },
                        { "api/v1/market/ticker", 4 },
                        { "api/v1/market/ticker-all", 4 },
                        { "api/v1/market/depth", 4 },
                        { "api/v1/market/depth-all", 4 },
                        { "api/v1/market/trades", 20 },
                        { "api/v1/market/kline", 20 },
                    } },
                } },
                { "private", new Dictionary<string, object>() {
                    { "post", new Dictionary<string, object>() {
                        { "api/v1/fund/mainAccount", 1 },
                        { "api/v1/fund/allAccount", 30 },
                        { "api/v1/trade/placeOrder", 1 },
                        { "api/v1/trade/placeMultiOrder", 10 },
                        { "api/v1/trade/cancelOrder", 1 },
                        { "api/v1/trade/cancelMultiOrder", 20 },
                        { "api/v1/trade/cancelAllOrder", 20 },
                        { "api/v1/trade/orderInfo", 1 },
                        { "api/v1/trade/multiOrderInfo", 10 },
                        { "api/v1/trade/orderInfos", 20 },
                    } },
                } },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "tierBased", false },
                    { "percentage", true },
                    { "maker", this.parseNumber("0.001") },
                    { "taker", this.parseNumber("0.001") },
                } },
                { "funding", new Dictionary<string, object>() {
                    { "tierBased", false },
                    { "percentage", true },
                    { "deposit", new Dictionary<string, object>() {} },
                    { "withdraw", new Dictionary<string, object>() {} },
                } },
            } },
            { "commonCurrencies", new Dictionary<string, object>() {
                { "BKC", "Bank Coin" },
                { "CAPP", "Crypto Application Token" },
                { "CREDIT", "TerraCredit" },
                { "CTC", "Culture Ticket Chain" },
                { "EWT", "EcoWatt Token" },
                { "IQ", "IQ.Cash" },
                { "MIR", "MIR COIN" },
                { "NOIA", "METANOIA" },
                { "TON", "To The Moon" },
            } },
            { "precisionMode", TICK_SIZE },
            { "exceptions", new Dictionary<string, object>() {
                { "1000", typeof(OrderNotFound) },
                { "1003", typeof(BadSymbol) },
                { "1013", typeof(AuthenticationError) },
                { "1016", typeof(AuthenticationError) },
                { "1017", typeof(PermissionDenied) },
                { "1019", typeof(BadSymbol) },
                { "3002", typeof(InsufficientFunds) },
                { "4002", typeof(InvalidOrder) },
                { "4003", typeof(InvalidOrder) },
                { "4004", typeof(OrderNotFound) },
                { "10204", typeof(DDoSProtection) },
            } },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchMarkets
        * @description retrieves data on all markets for bitforex
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetApiV1MarketSymbols(parameters);
        //
        //    {
        //        "data": [
        //            {
        //                "amountPrecision":4,
        //                "minOrderAmount":3.0E-4,
        //                "pricePrecision":2,
        //                "symbol":"coin-usdt-btc"
        //            },
        //            ...
        //        ]
        //    }
        //
        object data = getValue(response, "data");
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object market = getValue(data, i);
            object id = this.safeString(market, "symbol");
            object symbolParts = ((string)id).Split((string)"-").ToList<object>();
            object baseId = getValue(symbolParts, 2);
            object quoteId = getValue(symbolParts, 1);
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
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
                { "margin", false },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "active", true },
                { "contract", false },
                { "linear", null },
                { "inverse", null },
                { "contractSize", null },
                { "expiry", null },
                { "expiryDateTime", null },
                { "strike", null },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "amount", this.parseNumber(this.parsePrecision(this.safeString(market, "amountPrecision"))) },
                    { "price", this.parseNumber(this.parsePrecision(this.safeString(market, "pricePrecision"))) },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", this.safeNumber(market, "minOrderAmount") },
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

    public override object parseTrade(object trade, object market = null)
    {
        //
        // fetchTrades (public) v1
        //
        //      {
        //          "price":57594.53,
        //          "amount":0.3172,
        //          "time":1637329685322,
        //          "direction":1,
        //          "tid":"1131019666"
        //      }
        //
        //      {
        //          "price":57591.33,
        //          "amount":0.002,
        //          "time":1637329685322,
        //          "direction":1,
        //          "tid":"1131019639"
        //      }
        //
        market = this.safeMarket(null, market);
        object timestamp = this.safeInteger(trade, "time");
        object id = this.safeString(trade, "tid");
        object orderId = null;
        object priceString = this.safeString(trade, "price");
        object amountString = this.safeString(trade, "amount");
        object sideId = this.safeInteger(trade, "direction");
        object side = this.parseSide(sideId);
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "id", id },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", getValue(market, "symbol") },
            { "type", null },
            { "side", side },
            { "price", priceString },
            { "amount", amountString },
            { "cost", null },
            { "order", orderId },
            { "fee", null },
            { "takerOrMaker", null },
        }, market);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/en/latest/manual.html?#public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "symbol", this.marketId(symbol) },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["size"] = limit;
        }
        object market = this.market(symbol);
        object response = await this.publicGetApiV1MarketTrades(this.extend(request, parameters));
        //
        // {
        //  "data":
        //      [
        //          {
        //              "price":57594.53,
        //              "amount":0.3172,
        //              "time":1637329685322,
        //              "direction":1,
        //              "tid":"1131019666"
        //          }
        //      ],
        //  "success": true,
        //  "time": 1637329688475
        // }
        //
        return this.parseTrades(getValue(response, "data"), market, since, limit);
    }

    public virtual object parseBalance(object response)
    {
        object data = getValue(response, "data");
        object result = new Dictionary<string, object>() {
            { "info", response },
        };
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object balance = getValue(data, i);
            object currencyId = this.safeString(balance, "currency");
            object code = this.safeCurrencyCode(currencyId);
            object account = this.account();
            ((Dictionary<string, object>)account)["used"] = this.safeString(balance, "frozen");
            ((Dictionary<string, object>)account)["free"] = this.safeString(balance, "active");
            ((Dictionary<string, object>)account)["total"] = this.safeString(balance, "fix");
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.privatePostApiV1FundAllAccount(parameters);
        return this.parseBalance(response);
    }

    public override object parseTicker(object ticker, object market = null)
    {
        //
        //     {
        //         "buy":7.04E-7,
        //         "date":1643371198598,
        //         "high":7.48E-7,
        //         "last":7.28E-7,
        //         "low":7.10E-7,
        //         "sell":7.54E-7,
        //         "vol":9877287.2874
        //     }
        //
        object symbol = this.safeSymbol(null, market);
        object timestamp = this.safeInteger(ticker, "date");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", this.safeString(ticker, "high") },
            { "low", this.safeString(ticker, "low") },
            { "bid", this.safeString(ticker, "buy") },
            { "bidVolume", null },
            { "ask", this.safeString(ticker, "sell") },
            { "askVolume", null },
            { "vwap", null },
            { "open", null },
            { "close", this.safeString(ticker, "last") },
            { "last", this.safeString(ticker, "last") },
            { "previousClose", null },
            { "change", null },
            { "percentage", null },
            { "average", null },
            { "baseVolume", this.safeString(ticker, "vol") },
            { "quoteVolume", null },
            { "info", ticker },
        }, market);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = getValue(this.markets, symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        object response = await this.publicGetApiV1MarketTickerAll(this.extend(request, parameters));
        object ticker = this.safeValue(response, "data");
        //
        //     {
        //         "data":{
        //             "buy":37082.83,
        //             "date":1643388686660,
        //             "high":37487.83,
        //             "last":37086.79,
        //             "low":35544.44,
        //             "sell":37090.52,
        //             "vol":690.9776
        //         },
        //         "success":true,
        //         "time":1643388686660
        //     }
        //
        return this.parseTicker(ticker, market);
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //
        //     {
        //         "close":0.02505143,
        //         "currencyVol":0,
        //         "high":0.02506422,
        //         "low":0.02505143,
        //         "open":0.02506095,
        //         "time":1591508940000,
        //         "vol":51.1869
        //     }
        //
        return new List<object> {this.safeInteger(ohlcv, "time"), this.safeNumber(ohlcv, "open"), this.safeNumber(ohlcv, "high"), this.safeNumber(ohlcv, "low"), this.safeNumber(ohlcv, "close"), this.safeNumber(ohlcv, "vol")};
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchOHLCV
        * @description fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents
        * @param {int|undefined} since timestamp in ms of the earliest candle to fetch
        * @param {int|undefined} limit the maximum amount of candles to fetch
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {[[int]]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "ktype", this.safeString(this.timeframes, timeframe, timeframe) },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["size"] = limit; // default 1, max 600
        }
        object response = await this.publicGetApiV1MarketKline(this.extend(request, parameters));
        //
        //     {
        //         "data":[
        //             {"close":0.02505143,"currencyVol":0,"high":0.02506422,"low":0.02505143,"open":0.02506095,"time":1591508940000,"vol":51.1869},
        //             {"close":0.02503914,"currencyVol":0,"high":0.02506687,"low":0.02503914,"open":0.02505358,"time":1591509000000,"vol":9.1082},
        //             {"close":0.02505172,"currencyVol":0,"high":0.02507466,"low":0.02503895,"open":0.02506371,"time":1591509060000,"vol":63.7431},
        //         ],
        //         "success":true,
        //         "time":1591509427131
        //     }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parseOHLCVs(data, market, timeframe, since, limit);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the bitforex api endpoint
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
            ((Dictionary<string, object>)request)["size"] = limit;
        }
        object response = await this.publicGetApiV1MarketDepthAll(this.extend(request, parameters));
        object data = this.safeValue(response, "data");
        object timestamp = this.safeInteger(response, "time");
        return this.parseOrderBook(data, getValue(market, "symbol"), timestamp, "bids", "asks", "price", "amount");
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "0", "open" },
            { "1", "open" },
            { "2", "closed" },
            { "3", "canceled" },
            { "4", "canceled" },
        };
        return ((bool) isTrue((((Dictionary<string,object>)statuses).ContainsKey(toStringOrNull(status))))) ? getValue(statuses, status) : status;
    }

    public virtual object parseSide(object sideId)
    {
        if (isTrue(isEqual(sideId, 1)))
        {
            return "buy";
        } else if (isTrue(isEqual(sideId, 2)))
        {
            return "sell";
        } else
        {
            return null;
        }
    }

    public override object parseOrder(object order, object market = null)
    {
        object id = this.safeString(order, "orderId");
        object timestamp = this.safeNumber(order, "createTime");
        object lastTradeTimestamp = this.safeNumber(order, "lastTime");
        object symbol = getValue(market, "symbol");
        object sideId = this.safeInteger(order, "tradeType");
        object side = this.parseSide(sideId);
        object type = null;
        object price = this.safeString(order, "orderPrice");
        object average = this.safeString(order, "avgPrice");
        object amount = this.safeString(order, "orderAmount");
        object filled = this.safeString(order, "dealAmount");
        object status = this.parseOrderStatus(this.safeString(order, "orderState"));
        object feeSide = ((bool) isTrue((isEqual(side, "buy")))) ? "base" : "quote";
        object feeCurrency = getValue(market, feeSide);
        object fee = new Dictionary<string, object>() {
            { "cost", this.safeNumber(order, "tradeFee") },
            { "currency", feeCurrency },
        };
        return this.safeOrder(new Dictionary<string, object>() {
            { "info", order },
            { "id", id },
            { "clientOrderId", null },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "lastTradeTimestamp", lastTradeTimestamp },
            { "symbol", symbol },
            { "type", type },
            { "timeInForce", null },
            { "postOnly", null },
            { "side", side },
            { "price", price },
            { "stopPrice", null },
            { "triggerPrice", null },
            { "cost", null },
            { "average", average },
            { "amount", amount },
            { "filled", filled },
            { "remaining", null },
            { "status", status },
            { "fee", fee },
            { "trades", null },
        }, market);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string|undefined} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", this.marketId(symbol) },
            { "orderId", id },
        };
        object response = await this.privatePostApiV1TradeOrderInfo(this.extend(request, parameters));
        object order = this.parseOrder(getValue(response, "data"), market);
        return order;
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchMyTrades() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", this.marketId(symbol) },
            { "state", 0 },
        };
        object response = await this.privatePostApiV1TradeOrderInfos(this.extend(request, parameters));
        return this.parseOrders(getValue(response, "data"), market, since, limit);
    }

    public async override Task<object> fetchClosedOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#fetchClosedOrders
        * @description fetches information on multiple closed orders made by the user
        * @param {string|undefined} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchMyTrades() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", this.marketId(symbol) },
            { "state", 1 },
        };
        object response = await this.privatePostApiV1TradeOrderInfos(this.extend(request, parameters));
        return this.parseOrders(getValue(response, "data"), market, since, limit);
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object sideId = null;
        if (isTrue(isEqual(side, "buy")))
        {
            sideId = 1;
        } else if (isTrue(isEqual(side, "sell")))
        {
            sideId = 2;
        }
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "price", price },
            { "amount", amount },
            { "tradeType", sideId },
        };
        object response = await this.privatePostApiV1TradePlaceOrder(this.extend(request, parameters));
        object data = getValue(response, "data");
        return this.safeOrder(new Dictionary<string, object>() {
            { "info", response },
            { "id", this.safeString(data, "orderId") },
        }, market);
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name bitforex#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string|undefined} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the bitforex api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "orderId", id },
        };
        if (isTrue(!isEqual(symbol, null)))
        {
            ((Dictionary<string, object>)request)["symbol"] = this.marketId(symbol);
        }
        object results = await this.privatePostApiV1TradeCancelOrder(this.extend(request, parameters));
        object success = getValue(results, "success");
        object returnVal = new Dictionary<string, object>() {
            { "info", results },
            { "success", success },
        };
        return returnVal;
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object url = add(add(getValue(getValue(this.urls, "api"), "rest"), "/"), this.implodeParams(path, parameters));
        object query = this.omit(parameters, this.extractParams(path));
        if (isTrue(isEqual(api, "public")))
        {
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
            {
                url = add(url, add("?", this.urlencode(query)));
            }
        } else
        {
            this.checkRequiredCredentials();
            object payload = this.urlencode(new Dictionary<string, object>() {
                { "accessKey", this.apiKey },
            });
            ((Dictionary<string, object>)query)["nonce"] = this.milliseconds();
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
            {
                payload = add(payload, add("&", this.urlencode(this.keysort(query))));
            }
            // let message = '/' + 'api/' + this.version + '/' + path + '?' + payload;
            object message = add(add(add("/", path), "?"), payload);
            object signature = this.hmac(this.encode(message), this.encode(this.secret), sha256);
            body = add(add(payload, "&signData="), signature);
            headers = new Dictionary<string, object>() {
                { "Content-Type", "application/x-www-form-urlencoded" },
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
        if (isTrue(!((body).GetType() == typeof(string))))
        {
            return null;  // fallback to default error handler
        }
        if (isTrue(isTrue((isEqual(getValue(body, 0), "{"))) || isTrue((isEqual(getValue(body, 0), "[")))))
        {
            object feedback = add(add(this.id, " "), body);
            object success = this.safeValue(response, "success");
            if (isTrue(!isEqual(success, null)))
            {
                if (!isTrue(success))
                {
                    object codeInner = this.safeString(response, "code");
                    this.throwExactlyMatchedException(this.exceptions, codeInner, feedback);
                    throw new ExchangeError ((string)feedback) ;
                }
            }
        }
        return null;
    }
}
