using Main;
namespace Main;

partial class lbank2 : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "lbank2" },
            { "name", "LBank" },
            { "countries", new List<object>() {"CN"} },
            { "version", "v2" },
            { "rateLimit", 20 },
            { "has", new Dictionary<string, object>() {
                { "CORS", false },
                { "spot", true },
                { "margin", false },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "addMargin", false },
                { "cancelAllOrders", true },
                { "cancelOrder", true },
                { "createOrder", true },
                { "createReduceOnlyOrder", false },
                { "createStopLimitOrder", false },
                { "createStopMarketOrder", false },
                { "createStopOrder", false },
                { "fetchBalance", true },
                { "fetchBorrowRate", false },
                { "fetchBorrowRateHistories", false },
                { "fetchBorrowRateHistory", false },
                { "fetchBorrowRates", false },
                { "fetchBorrowRatesPerSymbol", false },
                { "fetchClosedOrders", false },
                { "fetchDepositWithdrawFee", "emulated" },
                { "fetchDepositWithdrawFees", true },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", false },
                { "fetchFundingRateHistory", false },
                { "fetchFundingRates", false },
                { "fetchIndexOHLCV", false },
                { "fetchIsolatedPositions", false },
                { "fetchLeverage", false },
                { "fetchLeverageTiers", false },
                { "fetchMarginMode", false },
                { "fetchMarkets", true },
                { "fetchMarkOHLCV", false },
                { "fetchMyTrades", true },
                { "fetchOHLCV", true },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchOrders", true },
                { "fetchPosition", false },
                { "fetchPositionMode", false },
                { "fetchPositions", false },
                { "fetchPositionsRisk", false },
                { "fetchPremiumIndexOHLCV", false },
                { "fetchTicker", true },
                { "fetchTickers", true },
                { "fetchTrades", true },
                { "fetchTradingFees", true },
                { "fetchTransactionFees", true },
                { "reduceMargin", false },
                { "setLeverage", false },
                { "setMarginMode", false },
                { "setPositionMode", false },
                { "withdraw", false },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "minute1" },
                { "5m", "minute5" },
                { "15m", "minute15" },
                { "30m", "minute30" },
                { "1h", "hour1" },
                { "2h", "hour2" },
                { "4h", "hour4" },
                { "6h", "hour6" },
                { "8h", "hour8" },
                { "12h", "hour12" },
                { "1d", "day1" },
                { "1w", "week1" },
            } },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/1294454/38063602-9605e28a-3302-11e8-81be-64b1e53c4cfb.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "rest", "https://api.lbank.info" },
                } },
                { "api2", "https://api.lbkex.com" },
                { "www", "https://www.lbank.info" },
                { "doc", "https://www.lbank.info/en-US/docs/index.html" },
                { "fees", "https://lbankinfo.zendesk.com/hc/en-gb/articles/360012072873-Trading-Fees" },
                { "referral", "https://www.lbank.info/invitevip?icode=7QCY" },
            } },
            { "api", new Dictionary<string, object>() {
                { "public", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "currencyPairs", 2.5 },
                        { "accuracy", 2.5 },
                        { "usdToCny", 2.5 },
                        { "withdrawConfigs", 2.5 },
                        { "timestamp", 2.5 },
                        { "ticker/24hr", 2.5 },
                        { "ticker", 2.5 },
                        { "depth", 2.5 },
                        { "incrDepth", 2.5 },
                        { "trades", 2.5 },
                        { "kline", 2.5 },
                        { "supplement/system_ping", 2.5 },
                        { "supplement/incrDepth", 2.5 },
                        { "supplement/trades", 2.5 },
                        { "supplement/ticker/price", 2.5 },
                        { "supplement/ticker/bookTicker", 2.5 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "supplement/system_status", 2.5 },
                    } },
                } },
                { "private", new Dictionary<string, object>() {
                    { "post", new Dictionary<string, object>() {
                        { "user_info", 2.5 },
                        { "subscribe/get_key", 2.5 },
                        { "subscribe/refresh_key", 2.5 },
                        { "subscribe/destroy_key", 2.5 },
                        { "get_deposit_address", 2.5 },
                        { "deposit_history", 2.5 },
                        { "create_order", 1 },
                        { "batch_create_order", 1 },
                        { "cancel_order", 1 },
                        { "cancel_clientOrders", 1 },
                        { "orders_info", 2.5 },
                        { "orders_info_history", 2.5 },
                        { "order_transaction_detail", 2.5 },
                        { "transaction_history", 2.5 },
                        { "orders_info_no_deal", 2.5 },
                        { "withdraw", 2.5 },
                        { "withdrawCancel", 2.5 },
                        { "withdraws", 2.5 },
                        { "supplement/user_info", 2.5 },
                        { "supplement/withdraw", 2.5 },
                        { "supplement/deposit_history", 2.5 },
                        { "supplement/withdraws", 2.5 },
                        { "supplement/get_deposit_address", 2.5 },
                        { "supplement/asset_detail", 2.5 },
                        { "supplement/customer_trade_fee", 2.5 },
                        { "supplement/api_Restrictions", 2.5 },
                        { "supplement/system_ping", 2.5 },
                        { "supplement/create_order_test", 1 },
                        { "supplement/create_order", 1 },
                        { "supplement/cancel_order", 1 },
                        { "supplement/cancel_order_by_symbol", 1 },
                        { "supplement/orders_info", 2.5 },
                        { "supplement/orders_info_no_deal", 2.5 },
                        { "supplement/orders_info_history", 2.5 },
                        { "supplement/user_info_account", 2.5 },
                        { "supplement/transaction_history", 2.5 },
                    } },
                } },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "maker", this.parseNumber("0.001") },
                    { "taker", this.parseNumber("0.001") },
                } },
                { "funding", new Dictionary<string, object>() {
                    { "withdraw", new Dictionary<string, object>() {} },
                } },
            } },
            { "commonCurrencies", new Dictionary<string, object>() {
                { "VET_ERC20", "VEN" },
                { "PNT", "Penta" },
            } },
            { "precisionMode", TICK_SIZE },
            { "options", new Dictionary<string, object>() {
                { "cacheSecretAsPem", true },
                { "createMarketBuyOrderRequiresPrice", true },
                { "fetchTrades", new Dictionary<string, object>() {
                    { "method", "publicGetTrades" },
                } },
                { "fetchTransactionFees", new Dictionary<string, object>() {
                    { "method", "fetchPrivateTransactionFees" },
                } },
                { "fetchDepositWithdrawFees", new Dictionary<string, object>() {
                    { "method", "fetchPrivateDepositWithdrawFees" },
                } },
                { "fetchDepositAddress", new Dictionary<string, object>() {
                    { "method", "fetchDepositAddressDefault" },
                } },
                { "createOrder", new Dictionary<string, object>() {
                    { "method", "privatePostSupplementCreateOrder" },
                } },
                { "fetchOrder", new Dictionary<string, object>() {
                    { "method", "fetchOrderSupplement" },
                } },
                { "fetchBalance", new Dictionary<string, object>() {
                    { "method", "privatePostSupplementUserInfo" },
                } },
                { "networks", new Dictionary<string, object>() {
                    { "ERC20", "erc20" },
                    { "ETH", "erc20" },
                    { "TRC20", "trc20" },
                    { "TRX", "trc20" },
                    { "OMNI", "omni" },
                    { "ASA", "asa" },
                    { "BEP20", "bep20(bsc)" },
                    { "BSC", "bep20(bsc)" },
                    { "HT", "heco" },
                    { "BNB", "bep2" },
                    { "BTC", "btc" },
                    { "DOGE", "dogecoin" },
                    { "MATIC", "matic" },
                    { "POLYGON", "matic" },
                    { "OEC", "oec" },
                    { "BTCTRON", "btctron" },
                    { "XRP", "xrp" },
                } },
                { "inverse-networks", new Dictionary<string, object>() {
                    { "erc20", "ERC20" },
                    { "trc20", "TRC20" },
                    { "omni", "OMNI" },
                    { "asa", "ASA" },
                    { "bep20(bsc)", "BSC" },
                    { "bep20", "BSC" },
                    { "heco", "HT" },
                    { "bep2", "BNB" },
                    { "btc", "BTC" },
                    { "dogecoin", "DOGE" },
                    { "matic", "MATIC" },
                    { "oec", "OEC" },
                    { "btctron", "BTCTRON" },
                    { "xrp", "XRP" },
                } },
                { "defaultNetworks", new Dictionary<string, object>() {
                    { "USDT", "TRC20" },
                } },
            } },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchMarkets
        * @description retrieves data on all markets for lbank2
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        // needs to return a list of unified market structures
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetAccuracy();
        object data = this.safeValue(response, "data");
        //      [
        //          {
        //              symbol: 'snx3s_usdt',
        //              quantityAccuracy: '2',
        //              minTranQua: '0.01',
        //              priceAccuracy: '6'
        //          }
        //     ]
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object market = getValue(data, i);
            object marketId = this.safeString(market, "symbol");
            object parts = ((string)marketId).Split((string)"_").ToList<object>();
            object baseId = getValue(parts, 0);
            object quoteId = getValue(parts, 1);
            object bs = ((string)baseId).ToUpper();
            object quote = ((string)quoteId).ToUpper();
            object symbol = add(add(bs, "/"), quote);
            object productTypes = new Dictionary<string, object>() {
                { "3l", true },
                { "5l", true },
                { "3s", true },
                { "5s", true },
            };
            object ending = ((string)baseId).Substring((int)-2);
            object isLeveragedProduct = this.safeValue(productTypes, ending, false);
            if (isTrue(isLeveragedProduct))
            {
                symbol = add(symbol, add(":", quote));
            }
            object linear = null;
            if (isTrue(isEqual(isLeveragedProduct, true)))
            {
                linear = true;
            }
            ((List<object>)result).Add(new Dictionary<string, object>() {
                { "id", marketId },
                { "symbol", symbol },
                { "base", bs },
                { "quote", quote },
                { "settle", null },
                { "baseId", baseId },
                { "quoteId", quoteId },
                { "settleId", null },
                { "type", "spot" },
                { "spot", true },
                { "margin", false },
                { "swap", isLeveragedProduct },
                { "future", false },
                { "option", false },
                { "active", true },
                { "contract", isLeveragedProduct },
                { "linear", linear },
                { "inverse", null },
                { "contractSize", null },
                { "expiry", null },
                { "expiryDatetime", null },
                { "strike", null },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "amount", this.parseNumber(this.parsePrecision(this.safeString(market, "quantityAccuracy"))) },
                    { "price", this.parseNumber(this.parsePrecision(this.safeString(market, "priceAccuracy"))) },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", this.safeNumber(market, "minTranQua") },
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

    public override object parseTicker(object ticker, object market = null)
    {
        //
        //      {
        //          "symbol":"btc_usdt",
        //          "ticker": {
        //              "high":40200.88,
        //              "vol":7508.3096,
        //              "low":38239.38,
        //              "change":0.75,
        //              "turnover":292962771.34,
        //              "latest":39577.95
        //               },
        //           "timestamp":1647005189792
        //      }
        //
        object marketId = this.safeString(ticker, "symbol");
        object symbol = this.safeSymbol(marketId, market);
        object timestamp = this.safeInteger(ticker, "timestamp");
        object tickerData = this.safeValue(ticker, "ticker");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", this.safeString(tickerData, "high") },
            { "low", this.safeString(tickerData, "low") },
            { "bid", null },
            { "bidVolume", null },
            { "ask", null },
            { "askVolume", null },
            { "vwap", null },
            { "open", null },
            { "close", null },
            { "last", this.safeString(tickerData, "latest") },
            { "previousClose", null },
            { "change", null },
            { "percentage", this.safeString(tickerData, "change") },
            { "average", null },
            { "baseVolume", this.safeString(tickerData, "vol") },
            { "quoteVolume", this.safeString(tickerData, "turnover") },
            { "info", ticker },
        }, market);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        object response = await this.publicGetTicker24hr(this.extend(request, parameters));
        //
        //      {
        //          "result":"true",
        //          "data": [
        //              {
        //                  "symbol":"btc_usdt",
        //                  "ticker":{
        //                          "high":40200.88,
        //                          "vol":7508.3096,
        //                          "low":38239.38,
        //                          "change":0.75,
        //                          "turnover":292962771.34,
        //                          "latest":39577.95
        //                      },
        //                  "timestamp":1647005189792
        //               }
        //                   ],
        //          "error_code":0,"ts":1647005190755
        //      }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        object first = this.safeValue(data, 0, new Dictionary<string, object>() {});
        return this.parseTicker(first, market);
    }

    public async override Task<object> fetchTickers(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchTickers
        * @description fetches price tickers for multiple markets, statistical calculations with the information calculated over the past 24 hours each market
        * @param {[string]|undefined} symbols unified symbols of the markets to fetch the ticker for, all market tickers are returned if not assigned
        * @param {object} params extra parameters specific to the lbank api endpoint
        * @returns {object} a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "symbol", "all" },
        };
        object response = await this.publicGetTicker24hr(this.extend(request, parameters));
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parseTickers(data, symbols);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        if (isTrue(isEqual(limit, null)))
        {
            limit = 60;
        }
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "size", limit },
        };
        object response = await this.publicGetDepth(this.extend(request, parameters));
        object orderbook = getValue(response, "data");
        object timestamp = this.milliseconds();
        return this.parseOrderBook(orderbook, getValue(market, "symbol"), timestamp);
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        // fetchTrades (old) publicGetTrades
        //
        //      {
        //          "date_ms":1647021989789,
        //          "amount":0.0028,
        //          "price":38804.2,
        //          "type":"buy",
        //          "tid":"52d5616ee35c43019edddebe59b3e094"
        //      }
        //
        //
        // fetchTrades (new) publicGetTradesSupplement
        //
        //      {
        //          "quoteQty":1675.048485,
        //          "price":0.127545,
        //          "qty":13133,
        //          "id":"3589541dc22e4357b227283650f714e2",
        //          "time":1648058297110,
        //          "isBuyerMaker":false
        //      }
        //
        // fetchMyTrades (private)
        //
        //      {
        //          "orderUuid":"38b4e7a4-14f6-45fd-aba1-1a37024124a0",
        //          "tradeFeeRate":0.0010000000,
        //          "dealTime":1648500944496,
        //          "dealQuantity":30.00000000000000000000,
        //          "tradeFee":0.00453300000000000000,
        //          "txUuid":"11f3850cc6214ea3b495adad3a032794",
        //          "dealPrice":0.15111300000000000000,
        //          "dealVolumePrice":4.53339000000000000000,
        //          "tradeType":"sell_market"
        //      }
        //
        object timestamp = this.safeInteger2(trade, "date_ms", "time");
        if (isTrue(isEqual(timestamp, null)))
        {
            timestamp = this.safeInteger(trade, "dealTime");
        }
        object amountString = this.safeString2(trade, "amount", "qty");
        if (isTrue(isEqual(amountString, null)))
        {
            amountString = this.safeString(trade, "dealQuantity");
        }
        object priceString = this.safeString(trade, "price");
        if (isTrue(isEqual(priceString, null)))
        {
            priceString = this.safeString(trade, "dealPrice");
        }
        object costString = this.safeString(trade, "quoteQty");
        if (isTrue(isEqual(costString, null)))
        {
            costString = this.safeString(trade, "dealVolumePrice");
        }
        object side = this.safeString2(trade, "tradeType", "type");
        object type = null;
        object takerOrMaker = null;
        if (isTrue(!isEqual(side, null)))
        {
            object parts = ((string)side).Split((string)"_").ToList<object>();
            side = this.safeString(parts, 0);
            object typePart = this.safeString(parts, 1);
            type = "limit";
            takerOrMaker = "taker";
            if (isTrue(!isEqual(typePart, null)))
            {
                if (isTrue(isEqual(typePart, "market")))
                {
                    type = "market";
                } else if (isTrue(isEqual(typePart, "maker")))
                {
                    takerOrMaker = "maker";
                }
            }
        }
        object id = this.safeString2(trade, "tid", "id");
        if (isTrue(isEqual(id, null)))
        {
            id = this.safeString(trade, "txUuid");
        }
        object order = this.safeString(trade, "orderUuid");
        object symbol = this.safeSymbol(null, market);
        object fee = null;
        object feeCost = this.safeString(trade, "tradeFee");
        if (isTrue(!isEqual(feeCost, null)))
        {
            fee = new Dictionary<string, object>() {
                { "cost", feeCost },
                { "currency", null },
                { "rate", this.safeString(trade, "tradeFeeRate") },
            };
        }
        return this.safeTrade(new Dictionary<string, object>() {
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", symbol },
            { "id", id },
            { "order", order },
            { "type", type },
            { "takerOrMaker", takerOrMaker },
            { "side", side },
            { "price", priceString },
            { "amount", amountString },
            { "cost", costString },
            { "fee", fee },
            { "info", trade },
        }, market);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/en/latest/manual.html?#public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["time"] = since;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["size"] = limit;
        } else
        {
            ((Dictionary<string, object>)request)["size"] = 600; // max
        }
        object method = this.safeString(parameters, "method");
        parameters = this.omit(parameters, "method");
        if (isTrue(isEqual(method, null)))
        {
            object options = this.safeValue(this.options, "fetchTrades", new Dictionary<string, object>() {});
            method = this.safeString(options, "method", "publicGetTrades");
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        //      {
        //          "result":"true",
        //          "data": [
        //              {
        //                  "date_ms":1647021989789,
        //                  "amount":0.0028,
        //                  "price":38804.2,
        //                  "type":"buy",
        //                  "tid":"52d5616ee35c43019edddebe59b3e094"
        //               }
        //           ],
        //           "error_code":0,
        //           "ts":1647021999308
        //      }
        object trades = this.safeValue(response, "data", new List<object>() {});
        return this.parseTrades(trades, market, since, limit);
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //
        //   [
        //     1482311500, // timestamp
        //     5423.23,    // open
        //     5472.80,    // high
        //     5516.09,    // low
        //     5462,       // close
        //     234.3250    // volume
        //   ],
        //
        return new List<object> {this.safeTimestamp(ohlcv, 0), this.safeNumber(ohlcv, 1), this.safeNumber(ohlcv, 2), this.safeNumber(ohlcv, 3), this.safeNumber(ohlcv, 4), this.safeNumber(ohlcv, 5)};
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchOHLCV
        * @description fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents
        * @param {int|undefined} since timestamp in ms of the earliest candle to fetch
        * @param {int|undefined} limit the maximum amount of candles to fetch
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {[[int]]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        // endpoint doesnt work
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        if (isTrue(isEqual(limit, null)))
        {
            limit = 100;
        }
        if (isTrue(isEqual(since, null)))
        {
            object duration = this.parseTimeframe(timeframe);
            since = subtract(this.milliseconds(), multiply(multiply(duration, 1000), limit));
        }
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "type", this.safeString(this.timeframes, timeframe, timeframe) },
            { "time", this.parseToInt(divide(since, 1000)) },
            { "size", limit },
        };
        object response = await this.publicGetKline(this.extend(request, parameters));
        object ohlcvs = this.safeValue(response, "data", new List<object>() {});
        //
        //
        // [
        //   [
        //     1482311500,
        //     5423.23,
        //     5472.80,
        //     5516.09,
        //     5462,
        //     234.3250
        //   ],
        //   [
        //     1482311400,
        //     5432.52,
        //     5459.87,
        //     5414.30,
        //     5428.23,
        //     213.7329
        //   ]
        // ]
        //
        return this.parseOHLCVs(ohlcvs, market, timeframe, since, limit);
    }

    public virtual object parseBalance(object response)
    {
        //
        // privatePostUserInfo
        //
        //      {
        //          "toBtc": {
        //              "egc:": "0",
        //              "iog": "0",
        //              "ksm": "0",
        //              },
        //          "freeze": {
        //              "egc": "0",
        //              "iog": "0",
        //              "ksm": "0" ,
        //              },
        //          "asset": {
        //              "egc": "0",
        //              "iog": "0",
        //              "ksm": "0",
        //              },
        //          "free": {
        //              "egc": "0",
        //              "iog": "0",
        //              "ksm": "0",
        //              }
        //      }
        //
        // privatePostSupplementUserInfoAccount
        //
        //      {
        //          "balances":[
        //              {
        //                  "asset":"lbk",
        //                  "free":"0",
        //                  "locked":"0"
        //              }, ...
        //          ]
        //      }
        //
        // privatePostSupplementUserInfo
        //
        //      [
        //          {
        //              "usableAmt":"31.45130723",
        //              "assetAmt":"31.45130723",
        //              "networkList":[
        //                  {
        //                      "isDefault":true,
        //                      "withdrawFeeRate":"",
        //                      "name":"bep20(bsc)",
        //                      "withdrawMin":30,
        //                      "minLimit":0.0001,
        //                      "minDeposit":0.0001,
        //                      "feeAssetCode":"doge",
        //                      "withdrawFee":"30",
        //                      "type":1,
        //                      "coin":"doge",
        //                      "network":"bsc"
        //                  },
        //                  {
        //                      "isDefault":false,
        //                      "withdrawFeeRate":"",
        //                      "name":"dogecoin",
        //                      "withdrawMin":10,
        //                      "minLimit":0.0001,
        //                      "minDeposit":10,
        //                      "feeAssetCode":"doge",
        //                      "withdrawFee":"10",
        //                      "type":1,
        //                      "coin":"doge",
        //                      "network":"dogecoin"
        //                  }
        //              ],
        //              "freezeAmt":"0",
        //              "coin":"doge"
        //          }, ...
        //      ]
        //
        object timestamp = this.safeInteger(response, "ts");
        object result = new Dictionary<string, object>() {
            { "info", response },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
        };
        object data = this.safeValue(response, "data");
        // from privatePostUserInfo
        object toBtc = this.safeValue(data, "toBtc");
        if (isTrue(!isEqual(toBtc, null)))
        {
            object used = this.safeValue(data, "freeze", new Dictionary<string, object>() {});
            object free = this.safeValue(data, "free", new Dictionary<string, object>() {});
            object currencies = new List<string>(((Dictionary<string,object>)free).Keys);
            for (object i = 0; isLessThan(i, getArrayLength(currencies)); postFixIncrement(ref i))
            {
                object currencyId = getValue(currencies, i);
                object code = this.safeCurrencyCode(currencyId);
                object account = this.account();
                ((Dictionary<string, object>)account)["used"] = this.safeString(used, currencyId);
                ((Dictionary<string, object>)account)["free"] = this.safeString(free, currencyId);
                ((Dictionary<string, object>)result)[(string)code] = account;
            }
            return this.safeBalance(result);
        }
        // from privatePostSupplementUserInfoAccount
        object balances = this.safeValue(data, "balances");
        if (isTrue(!isEqual(balances, null)))
        {
            for (object i = 0; isLessThan(i, getArrayLength(balances)); postFixIncrement(ref i))
            {
                object item = getValue(balances, i);
                object currencyId = this.safeString(item, "asset");
                object codeInner = this.safeCurrencyCode(currencyId);
                object account = this.account();
                ((Dictionary<string, object>)account)["free"] = this.safeString(item, "free");
                ((Dictionary<string, object>)account)["used"] = this.safeString(item, "locked");
                ((Dictionary<string, object>)result)[(string)codeInner] = account;
            }
            return this.safeBalance(result);
        }
        // from privatePostSupplementUserInfo
        object isArray = (data.GetType().IsGenericType && data.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)));
        if (isTrue(isEqual(isArray, true)))
        {
            for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
            {
                object item = getValue(data, i);
                object currencyId = this.safeString(item, "coin");
                object codeInner = this.safeCurrencyCode(currencyId);
                object account = this.account();
                ((Dictionary<string, object>)account)["free"] = this.safeString(item, "usableAmt");
                ((Dictionary<string, object>)account)["used"] = this.safeString(item, "freezeAmt");
                ((Dictionary<string, object>)result)[(string)codeInner] = account;
            }
            return this.safeBalance(result);
        }
        return null;
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object method = this.safeString(parameters, "method");
        if (isTrue(isEqual(method, null)))
        {
            object options = this.safeValue(this.options, "fetchBalance", new Dictionary<string, object>() {});
            method = this.safeString(options, "method", "privatePostSupplementUserInfo");
        }
        object response = await this.callAsync(method);
        //
        //    {
        //        "result": "true",
        //        "data": [
        //            {
        //                "usableAmt": "14.36",
        //                "assetAmt": "14.36",
        //                "networkList": [
        //                    {
        //                        "isDefault": false,
        //                        "withdrawFeeRate": "",
        //                        "name": "erc20",
        //                        "withdrawMin": 30,
        //                        "minLimit": 0.0001,
        //                        "minDeposit": 20,
        //                        "feeAssetCode": "usdt",
        //                        "withdrawFee": "30",
        //                        "type": 1,
        //                        "coin": "usdt",
        //                        "network": "eth"
        //                    },
        //                    ...
        //                ],
        //                "freezeAmt": "0",
        //                "coin": "ada"
        //            }
        //        ],
        //        "code": 0
        //    }
        //
        return this.parseBalance(response);
    }

    public virtual object parseTradingFee(object fee, object market = null)
    {
        //
        //      {
        //          "symbol":"skt_usdt",
        //          "makerCommission":"0.10",
        //          "takerCommission":"0.10"
        //      }
        //
        object marketId = this.safeString(fee, "symbol");
        object symbol = this.safeSymbol(marketId);
        return new Dictionary<string, object>() {
            { "info", fee },
            { "symbol", symbol },
            { "maker", this.safeNumber(fee, "makerCommission") },
            { "taker", this.safeNumber(fee, "takerCommission") },
        };
    }

    public async override Task<object> fetchTradingFee(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchTradingFee
        * @description fetch the trading fees for a market
        * @param {string} symbol unified market symbol
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} a [fee structure]{@link https://docs.ccxt.com/#/?id=fee-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object market = this.market(symbol);
        object result = await this.fetchTradingFees(this.extend(parameters, new Dictionary<string, object>() {
    { "category", getValue(market, "id") },
}));
        return result;
    }

    public async override Task<object> fetchTradingFees(object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchTradingFees
        * @description fetch the trading fees for multiple markets
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} a dictionary of [fee structures]{@link https://docs.ccxt.com/#/?id=fee-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object response = await this.privatePostSupplementCustomerTradeFee(this.extend(request, parameters));
        object fees = this.safeValue(response, "data", new List<object>() {});
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(fees)); postFixIncrement(ref i))
        {
            object fee = this.parseTradingFee(getValue(fees, i));
            object symbol = getValue(fee, "symbol");
            ((Dictionary<string, object>)result)[(string)symbol] = fee;
        }
        return result;
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object clientOrderId = this.safeString2(parameters, "custom_id", "clientOrderId");
        object postOnly = this.safeValue(parameters, "postOnly", false);
        object timeInForce = this.safeStringUpper(parameters, "timeInForce");
        parameters = this.omit(parameters, new List<object>() {"custom_id", "clientOrderId", "timeInForce", "postOnly"});
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        object ioc = (isEqual(timeInForce, "IOC"));
        object fok = (isEqual(timeInForce, "FOK"));
        object maker = (isTrue(postOnly) || isTrue((isEqual(timeInForce, "PO"))));
        if (isTrue(isTrue((isEqual(type, "market"))) && isTrue((isTrue(isTrue(ioc) || isTrue(fok)) || isTrue(maker)))))
        {
            throw new InvalidOrder ((string)add(this.id, " createOrder () does not allow market FOK, IOC, or postOnly orders. Only limit IOC, FOK, and postOnly orders are allowed")) ;
        }
        if (isTrue(isEqual(type, "limit")))
        {
            ((Dictionary<string, object>)request)["type"] = side;
            ((Dictionary<string, object>)request)["price"] = this.priceToPrecision(symbol, price);
            ((Dictionary<string, object>)request)["amount"] = this.amountToPrecision(symbol, amount);
            if (isTrue(ioc))
            {
                ((Dictionary<string, object>)request)["type"] = add(add(side, "_"), "ioc");
            } else if (isTrue(fok))
            {
                ((Dictionary<string, object>)request)["type"] = add(add(side, "_"), "fok");
            } else if (isTrue(maker))
            {
                ((Dictionary<string, object>)request)["type"] = add(add(side, "_"), "maker");
            }
        } else if (isTrue(isEqual(type, "market")))
        {
            if (isTrue(isEqual(side, "sell")))
            {
                ((Dictionary<string, object>)request)["type"] = add(add(side, "_"), "market");
                ((Dictionary<string, object>)request)["amount"] = this.amountToPrecision(symbol, amount);
            } else if (isTrue(isEqual(side, "buy")))
            {
                ((Dictionary<string, object>)request)["type"] = add(add(side, "_"), "market");
                if (isTrue(getValue(this.options, "createMarketBuyOrderRequiresPrice")))
                {
                    if (isTrue(isEqual(price, null)))
                    {
                        throw new InvalidOrder ((string)add(this.id, " createOrder () requires the price argument with market buy orders to calculate total order cost (amount to spend), where cost = amount * price. Supply the price argument to createOrder() call if you want the cost to be calculated for you from price and amount, or, alternatively, add .options[\'createMarketBuyOrderRequiresPrice\'] = false to supply the cost in the amount argument (the exchange-specific behaviour)")) ;
                    } else
                    {
                        object amountString = this.numberToString(amount);
                        object priceString = this.numberToString(price);
                        object quoteAmount = Precise.stringMul(amountString, priceString);
                        object cost = this.parseNumber(quoteAmount);
                        ((Dictionary<string, object>)request)["price"] = this.priceToPrecision(symbol, cost);
                    }
                } else
                {
                    ((Dictionary<string, object>)request)["price"] = amount;
                }
            }
        }
        if (isTrue(!isEqual(clientOrderId, null)))
        {
            ((Dictionary<string, object>)request)["custom_id"] = clientOrderId;
        }
        object method = null;
        method = this.safeString(parameters, "method");
        parameters = this.omit(parameters, "method");
        if (isTrue(isEqual(method, null)))
        {
            object options = this.safeValue(this.options, "createOrder", new Dictionary<string, object>() {});
            method = this.safeString(options, "method", "privatePostSupplementCreateOrder");
        }
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data":{
        //              "symbol":"doge_usdt",
        //              "order_id":"0cf8a3de-4597-4296-af45-be7abaa06b07"
        //              },
        //          "error_code":0,
        //          "ts":1648162321043
        //      }
        //
        object result = this.safeValue(response, "data", new Dictionary<string, object>() {});
        return this.safeOrder(new Dictionary<string, object>() {
            { "id", this.safeString(result, "order_id") },
            { "info", result },
        }, market);
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "-1", "canceled" },
            { "0", "open" },
            { "1", "open" },
            { "2", "closed" },
            { "3", "canceled" },
            { "4", "closed" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object parseOrder(object order, object market = null)
    {
        //
        // fetchOrderSupplement (private)
        //
        //      {
        //          "cummulativeQuoteQty":0,
        //          "symbol":"doge_usdt",
        //          "executedQty":0,
        //          "orderId":"53d2d53e-70fb-4398-b722-f48571a5f61e",
        //          "origQty":1E+2,
        //          "price":0.05,
        //          "clientOrderId":null,
        //          "origQuoteOrderQty":5,
        //          "updateTime":1648163406000,
        //          "time":1648163139387,
        //          "type":"buy_maker",
        //          "status":-1
        //      }
        //
        //
        // fetchOrderDefault (private)
        //
        //      {
        //          "symbol":"shib_usdt",
        //          "amount":1,
        //          "create_time":1649367863356,
        //          "price":0.0000246103,
        //          "avg_price":0.00002466180000000104,
        //          "type":"buy_market",
        //          "order_id":"abe8b92d-86d9-4d6d-b71e-d14f5fb53ddf",
        //          "custom_id": "007",                                 // field only present if user creates it at order time
        //          "deal_amount":40548.54065802,
        //          "status":2
        //      }
        //
        // fetchOpenOrders (private)
        //
        //      {
        //          "cummulativeQuoteQty":0,
        //          "symbol":"doge_usdt",
        //          "executedQty":0,
        //          "orderId":"73878edf-008d-4e4c-8041-df1f1b2cd8bb",
        //          "origQty":100,
        //          "price":0.05,
        //          "origQuoteOrderQty":5,
        //          "updateTime":1648501762000,
        //          "time":1648501762353,
        //          "type":"buy",
        //          "status":0
        //      }
        //
        // fetchOrders (private)
        //
        //      {
        //          "cummulativeQuoteQty":0,
        //          "symbol":"doge_usdt",
        //          "executedQty":0,
        //          "orderId":"2cadc7cc-b5f6-486b-a5b4-d6ac49a9c186",
        //          "origQty":100,
        //          "price":0.05,
        //          "origQuoteOrderQty":5,
        //          "updateTime":1648501384000,
        //          "time":1648501363889,
        //          "type":"buy",
        //          "status":-1
        //      }
        //
        object id = this.safeString2(order, "orderId", "order_id");
        object clientOrderId = this.safeString2(order, "clientOrderId", "custom_id");
        object timestamp = this.safeInteger2(order, "time", "create_time");
        object rawStatus = this.safeString(order, "status");
        object marketId = this.safeString(order, "symbol");
        market = this.safeMarket(marketId, market);
        object timeInForce = null;
        object postOnly = false;
        object type = "limit";
        object rawType = this.safeString(order, "type"); // buy, sell, buy_market, sell_market, buy_maker,sell_maker,buy_ioc,sell_ioc, buy_fok, sell_fok
        object parts = ((string)rawType).Split((string)"_").ToList<object>();
        object side = this.safeString(parts, 0);
        object typePart = this.safeString(parts, 1); // market, maker, ioc, fok or undefined (limit)
        if (isTrue(isEqual(typePart, "market")))
        {
            type = "market";
        }
        if (isTrue(isEqual(typePart, "maker")))
        {
            postOnly = true;
            timeInForce = "PO";
        }
        if (isTrue(isEqual(typePart, "ioc")))
        {
            timeInForce = "IOC";
        }
        if (isTrue(isEqual(typePart, "fok")))
        {
            timeInForce = "FOK";
        }
        object price = this.safeString(order, "price");
        object costString = this.safeString(order, "cummulativeQuoteQty");
        object amountString = null;
        if (isTrue(!isEqual(rawType, "buy_market")))
        {
            amountString = this.safeString2(order, "origQty", "amount");
        }
        object filledString = this.safeString2(order, "executedQty", "deal_amount");
        return this.safeOrder(new Dictionary<string, object>() {
            { "id", id },
            { "clientOrderId", clientOrderId },
            { "datetime", this.iso8601(timestamp) },
            { "timestamp", timestamp },
            { "lastTradeTimestamp", null },
            { "status", this.parseOrderStatus(rawStatus) },
            { "symbol", getValue(market, "symbol") },
            { "type", type },
            { "timeInForce", timeInForce },
            { "postOnly", postOnly },
            { "side", side },
            { "price", price },
            { "stopPrice", null },
            { "triggerPrice", null },
            { "cost", costString },
            { "amount", amountString },
            { "filled", filledString },
            { "remaining", null },
            { "trades", null },
            { "fee", null },
            { "info", order },
            { "average", null },
        }, market);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string|undefined} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object method = this.safeString(parameters, "method");
        if (isTrue(isEqual(method, null)))
        {
            object options = this.safeValue(this.options, "fetchOrder", new Dictionary<string, object>() {});
            method = this.safeString(options, "method", "fetchOrderSupplement");
        }
        object result = await this.callAsync(method, id);
        return result;
    }

    public async virtual Task<object> fetchOrderSupplement(object id, object symbol = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrder () requires a symbol argument")) ;
        }
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "orderId", id },
        };
        object response = await this.privatePostSupplementOrdersInfo(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data":{
        //              "cummulativeQuoteQty":0,
        //              "symbol":"doge_usdt",
        //              "executedQty":0,
        //              "orderId":"53d2d53e-70fb-4398-b722-f48571a5f61e",
        //              "origQty":1E+2,
        //              "price":0.05,
        //              "clientOrderId":null,
        //              "origQuoteOrderQty":5,
        //              "updateTime":1648163406000,
        //              "time":1648163139387,
        //              "type":"buy_maker",
        //              "status":-1
        //              },
        //          "error_code":0,
        //          "ts":1648164471827
        //      }
        //
        object result = this.safeValue(response, "data", new Dictionary<string, object>() {});
        return this.parseOrder(result);
    }

    public async virtual Task<object> fetchOrderDefault(object id, object symbol = null, object parameters = null)
    {
        // Id can be a list of ids delimited by a comma
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrder () requires a symbol argument")) ;
        }
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "order_id", id },
        };
        object response = await this.privatePostOrdersInfo(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data":[
        //              {
        //                  "symbol":"doge_usdt",
        //                  "amount":18,
        //                  "create_time":1647455223186,
        //                  "price":0,
        //                  "avg_price":0.113344,
        //                  "type":"sell_market",
        //                  "order_id":"d4ca1ddd-40d9-42c1-9717-5de435865bec",
        //                  "deal_amount":18,
        //                  "status":2
        //                }
        //            ],
        //          "error_code":0,
        //          "ts":1647455270776
        //      }
        //
        object result = this.safeValue(response, "data", new List<object>() {});
        object numOrders = getArrayLength(result);
        if (isTrue(isEqual(numOrders, 1)))
        {
            return this.parseOrder(getValue(result, 0));
        } else
        {
            object parsedOrders = new List<object>() {};
            for (object i = 0; isLessThan(i, numOrders); postFixIncrement(ref i))
            {
                object parsedOrder = this.parseOrder(getValue(result, i));
                ((List<object>)parsedOrders).Add(parsedOrder);
            }
            return parsedOrders;
        }
    }

    public async override Task<object> fetchMyTrades(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchMyTrades
        * @description fetch all trades made by the user
        * @param {string} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch trades for
        * @param {int|undefined} limit the maximum number of trades structures to retrieve
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchMyTrades () requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        since = this.safeValue(parameters, "start_date", since);
        parameters = this.omit(parameters, "start_date");
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["size"] = limit;
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["start_date"] = this.ymd(since, "-"); // max query 2 days ago
        }
        object response = await this.privatePostTransactionHistory(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data":[
        //              {
        //                  "orderUuid":"38b4e7a4-14f6-45fd-aba1-1a37024124a0",
        //                  "tradeFeeRate":0.0010000000,
        //                  "dealTime":1648500944496,
        //                  "dealQuantity":30.00000000000000000000,
        //                  "tradeFee":0.00453300000000000000,
        //                  "txUuid":"11f3850cc6214ea3b495adad3a032794",
        //                  "dealPrice":0.15111300000000000000,
        //                  "dealVolumePrice":4.53339000000000000000,
        //                  "tradeType":"sell_market"
        //              }
        //          ],
        //          "error_code":0,
        //          "ts":1648509742164
        //      }
        //
        object trades = this.safeValue(response, "data", new List<object>() {});
        return this.parseTrades(trades, market, since, limit);
    }

    public async override Task<object> fetchOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchOrders
        * @description fetches information on multiple orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        // default query is for canceled and completely filled orders
        // does not return open orders unless specified explicitly
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrders() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        if (isTrue(isEqual(limit, null)))
        {
            limit = 100;
        }
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "current_page", 1 },
            { "page_length", limit },
        };
        object response = await this.privatePostSupplementOrdersInfoHistory(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data":{
        //              "total":1,
        //              "page_length":100,
        //              "orders":[
        //                  {
        //                      "cummulativeQuoteQty":0,
        //                      "symbol":"doge_usdt",
        //                      "executedQty":0,
        //                      "orderId":"2cadc7cc-b5f6-486b-a5b4-d6ac49a9c186",
        //                      "origQty":100,
        //                      "price":0.05,
        //                      "origQuoteOrderQty":5,
        //                      "updateTime":1648501384000,
        //                      "time":1648501363889,
        //                      "type":"buy",
        //                      "status":-1
        //                  }, ...
        //              ],
        //              "current_page":1
        //          },
        //          "error_code":0,
        //          "ts":1648505706348
        //      }
        //
        object result = this.safeValue(response, "data", new Dictionary<string, object>() {});
        object orders = this.safeValue(result, "orders", new List<object>() {});
        return this.parseOrders(orders, market, since, limit);
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOpenOrders() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        if (isTrue(isEqual(limit, null)))
        {
            limit = 100;
        }
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "current_page", 1 },
            { "page_length", limit },
        };
        object response = await this.privatePostSupplementOrdersInfoNoDeal(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data":{
        //              "total":1,
        //              "page_length":100,
        //              "orders":[
        //                  {
        //                      "cummulativeQuoteQty":0,
        //                      "symbol":"doge_usdt",
        //                      "executedQty":0,
        //                      "orderId":"73878edf-008d-4e4c-8041-df1f1b2cd8bb",
        //                      "origQty":100,
        //                      "price":0.05,
        //                      "origQuoteOrderQty":5,
        //                      "updateTime":1648501762000,
        //                      "time":1648501762353,
        //                      "type":"buy",
        //                      "status":0
        //                  }, ...
        //             ],
        //             "current_page":1
        //         },
        //         "error_code":0,
        //         "ts":1648506110196
        //     }
        //
        object result = this.safeValue(response, "data", new Dictionary<string, object>() {});
        object orders = this.safeValue(result, "orders", new List<object>() {});
        return this.parseOrders(orders, market, since, limit);
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " cancelOrder() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object clientOrderId = this.safeString2(parameters, "origClientOrderId", "clientOrderId");
        parameters = this.omit(parameters, new List<object>() {"origClientOrderId", "clientOrderId"});
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        if (isTrue(!isEqual(clientOrderId, null)))
        {
            ((Dictionary<string, object>)request)["origClientOrderId"] = clientOrderId;
        }
        ((Dictionary<string, object>)request)["orderId"] = id;
        object response = await this.privatePostSupplementCancelOrder(this.extend(request, parameters));
        //
        //   {
        //      "result":true,
        //      "data":{
        //          "executedQty":0.0,
        //          "price":0.05,
        //          "origQty":100.0,
        //          "tradeType":"buy",
        //          "status":0
        //          },
        //      "error_code":0,
        //      "ts":1648501286196
        //  }
        object result = this.safeValue(response, "data", new Dictionary<string, object>() {});
        return result;
    }

    public async override Task<object> cancelAllOrders(object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#cancelAllOrders
        * @description cancel all open orders in a market
        * @param {string} symbol unified market symbol of the market to cancel orders in
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " cancelAllOrders() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
        };
        object response = await this.privatePostSupplementCancelOrderBySymbol(this.extend(request, parameters));
        //
        //      {
        //          "result":"true",
        //          "data":[
        //              {
        //                  "executedQty":0.00000000000000000000,
        //                  "orderId":"293ef71b-3e67-4962-af93-aa06990a045f",
        //                  "price":0.05000000000000000000,
        //                  "origQty":100.00000000000000000000,
        //                  "tradeType":"buy",
        //                  "status":0
        //              },
        //          ],
        //          "error_code":0,
        //          "ts":1648506641469
        //      }
        //
        object result = this.safeValue(response, "data", new List<object>() {});
        return result;
    }

    public virtual object getNetworkCodeForCurrency(object currencyCode, object parameters)
    {
        object defaultNetworks = this.safeValue(this.options, "defaultNetworks");
        object defaultNetwork = this.safeStringUpper(defaultNetworks, currencyCode);
        object networks = this.safeValue(this.options, "networks", new Dictionary<string, object>() {});
        object network = this.safeStringUpper(parameters, "network", defaultNetwork); // this line allows the user to specify either ERC20 or ETH
        network = this.safeString(networks, network, network); // handle ERC20>ETH alias
        return network;
    }

    public async override Task<object> fetchDepositAddress(object code, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchDepositAddress
        * @description fetch the deposit address for a currency associated with this account
        * @param {string} code unified currency code
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object method = this.safeString(parameters, "method");
        parameters = this.omit(parameters, "method");
        if (isTrue(isEqual(method, null)))
        {
            object options = this.safeValue(this.options, "fetchDepositAddress", new Dictionary<string, object>() {});
            method = this.safeString(options, "method", "fetchPrivateTradingFees");
        }
        return await this.callAsync(method, code);
    }

    public async virtual Task<object> fetchDepositAddressDefault(object code, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "assetCode", getValue(currency, "id") },
        };
        object network = this.getNetworkCodeForCurrency(code, parameters);
        if (isTrue(!isEqual(network, null)))
        {
            ((Dictionary<string, object>)request)["netWork"] = network; // ... yes, really lol
            parameters = this.omit(parameters, "network");
        }
        object response = await this.privatePostGetDepositAddress(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data":{
        //              "assetCode":"usdt",
        //              "address":"0xc85689d37ca650bf2f2161364cdedee21eb6ca53",
        //              "memo":null,
        //              "netWork":"bep20(bsc)"
        //              },
        //          "error_code":0,
        //          "ts":1648075865103
        //      }
        //
        object result = this.safeValue(response, "data");
        object address = this.safeString(result, "address");
        object tag = this.safeString(result, "memo");
        object networkId = this.safeString(result, "netWork");
        object inverseNetworks = this.safeValue(this.options, "inverse-networks", new Dictionary<string, object>() {});
        object networkCode = this.safeStringUpper(inverseNetworks, networkId, networkId);
        return new Dictionary<string, object>() {
            { "currency", code },
            { "address", address },
            { "tag", tag },
            { "network", networkCode },
            { "info", response },
        };
    }

    public async virtual Task<object> fetchDepositAddressSupplement(object code, object parameters = null)
    {
        // returns the address for whatever the default network is...
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "coin", getValue(currency, "id") },
        };
        object networks = this.safeValue(this.options, "networks");
        object network = this.safeStringUpper(parameters, "network");
        network = this.safeString(networks, network, network);
        if (isTrue(!isEqual(network, null)))
        {
            ((Dictionary<string, object>)request)["networkName"] = network;
            parameters = this.omit(parameters, "network");
        }
        object response = await this.privatePostSupplementGetDepositAddress(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data":{
        //              "address":"TDxtabCC8iQwaxUUrPcE4WL2jArGAfvQ5A",
        //              "memo":null,
        //              "coin":"usdt"
        //              },
        //          "error_code":0,
        //          "ts":1648073818880
        //     }
        //
        object result = this.safeValue(response, "data");
        object address = this.safeString(result, "address");
        object tag = this.safeString(result, "memo");
        object inverseNetworks = this.safeValue(this.options, "inverse-networks", new Dictionary<string, object>() {});
        object networkCode = this.safeStringUpper(inverseNetworks, network, network);
        return new Dictionary<string, object>() {
            { "currency", code },
            { "address", address },
            { "tag", tag },
            { "network", networkCode },
            { "info", response },
        };
    }

    public async override Task<object> withdraw(object code, object amount, object address, object tag = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#withdraw
        * @description make a withdrawal
        * @param {string} code unified currency code
        * @param {float} amount the amount to withdraw
        * @param {string} address the address to withdraw to
        * @param {string|undefined} tag
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
                var tagparametersVariable = this.handleWithdrawTagAndParams(tag, parameters);
        tag = ((List<object>)tagparametersVariable)[0];
        parameters = ((List<object>)tagparametersVariable)[1];
        this.checkAddress(address);
        await this.loadMarkets();
        object fee = this.safeString(parameters, "fee");
        parameters = this.omit(parameters, "fee");
        if (isTrue(isEqual(fee, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " withdraw () requires a fee argument to be supplied in params, the relevant coin network fee can be found by calling fetchDepositWithdrawFees (), note: if no network param is supplied then the default network will be used, this can also be found in fetchDepositWithdrawFees ()")) ;
        }
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "address", address },
            { "coin", getValue(currency, "id") },
            { "amount", amount },
            { "fee", fee },
        };
        if (isTrue(!isEqual(tag, null)))
        {
            ((Dictionary<string, object>)request)["memo"] = tag;
        }
        object network = this.safeStringUpper2(parameters, "network", "networkName");
        parameters = this.omit(parameters, new List<object>() {"network", "networkName"});
        object networks = this.safeValue(this.options, "networks");
        object networkId = this.safeString(networks, network, network);
        if (isTrue(!isEqual(networkId, null)))
        {
            ((Dictionary<string, object>)request)["networkName"] = networkId;
        }
        object response = await this.privatePostSupplementWithdraw(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data": {
        //              "fee":10.00000000000000000000,
        //              "withdrawId":1900376
        //              },
        //          "error_code":0,
        //          "ts":1648992501414
        //      }
        //
        object result = this.safeValue(response, "data", new Dictionary<string, object>() {});
        return new Dictionary<string, object>() {
            { "info", result },
            { "id", this.safeString(result, "withdrawId") },
        };
    }

    public virtual object parseTransactionStatus(object status, object type)
    {
        object statuses = new Dictionary<string, object>() {
            { "deposit", new Dictionary<string, object>() {
                { "1", "pending" },
                { "2", "ok" },
                { "3", "failed" },
                { "4", "canceled" },
                { "5", "transfer" },
            } },
            { "withdrawal", new Dictionary<string, object>() {
                { "1", "pending" },
                { "2", "canceled" },
                { "3", "failed" },
                { "4", "ok" },
            } },
        };
        return this.safeString(this.safeValue(statuses, type, new Dictionary<string, object>() {}), status, status);
    }

    public override object parseTransaction(object transaction, object currency = null)
    {
        //
        // fetchDeposits (private)
        //
        //      {
        //          "insertTime":1649012310000,
        //          "amount":9.00000000000000000000,
        //          "address":"TYASr5UV6HEcXatwdFQfmLVUqQQQMUxHLS",
        //          "networkName":"trc20",
        //          "txId":"081e4e9351dd0274922168da5f2d14ea6c495b1c3b440244f4a6dd9fe196bf2b",
        //          "coin":"usdt",
        //          "status":"2"
        //      }
        //
        //
        // fetchWithdrawals (private)
        //
        //      {
        //          "amount":2.00000000000000000000,
        //          "address":"TBjrW5JHDyPZjFc5nrRMhRWUDaJmhGhmD6",
        //          "fee":1.00000000000000000000,
        //          "networkName":"trc20",
        //          "coid":"usdt",
        //          "transferType":"数字资产提现",
        //          "txId":"47eeee2763ad49b8817524dacfa7d092fb58f8b0ab7e5d25473314df1a793c3d",
        //          "id":1902194,
        //          "applyTime":1649014002000,
        //          "status":"4"
        //      }
        //
        object id = this.safeString(transaction, "id");
        object type = null;
        if (isTrue(isEqual(id, null)))
        {
            type = "deposit";
        } else
        {
            type = "withdrawal";
        }
        object txid = this.safeString(transaction, "txId");
        object timestamp = this.safeInteger2(transaction, "insertTime", "applyTime");
        object networks = this.safeValue(this.options, "inverse-networks", new Dictionary<string, object>() {});
        object networkId = this.safeString(transaction, "networkName");
        object network = this.safeString(networks, networkId, networkId);
        object address = this.safeString(transaction, "address");
        object addressFrom = null;
        object addressTo = null;
        if (isTrue(isEqual(type, "deposit")))
        {
            addressFrom = address;
        } else
        {
            addressTo = address;
        }
        object amount = this.safeNumber(transaction, "amount");
        object currencyId = this.safeString2(transaction, "coin", "coid");
        object code = this.safeCurrencyCode(currencyId, currency);
        object status = this.parseTransactionStatus(this.safeString(transaction, "status"), type);
        object fee = null;
        object feeCost = this.safeNumber(transaction, "fee");
        if (isTrue(!isEqual(feeCost, null)))
        {
            fee = new Dictionary<string, object>() {
                { "cost", feeCost },
                { "currency", code },
            };
        }
        return new Dictionary<string, object>() {
            { "info", transaction },
            { "id", id },
            { "txid", txid },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "network", network },
            { "address", address },
            { "addressTo", addressTo },
            { "addressFrom", addressFrom },
            { "tag", null },
            { "tagTo", null },
            { "tagFrom", null },
            { "type", type },
            { "amount", amount },
            { "currency", code },
            { "status", status },
            { "updated", null },
            { "comment", null },
            { "internal", (isEqual(status, "transfer")) },
            { "fee", fee },
        };
    }

    public async override Task<object> fetchDeposits(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchDeposits
        * @description fetch all deposits made to an account
        * @param {string|undefined} code unified currency code
        * @param {int|undefined} since the earliest time in ms to fetch deposits for
        * @param {int|undefined} limit the maximum number of deposits structures to retrieve
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {[object]} a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object currency = null;
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["coin"] = getValue(currency, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["startTime"] = since;
        }
        object response = await this.privatePostSupplementDepositHistory(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data": {
        //              "total":1,
        //              "depositOrders": [
        //                  {
        //                      "insertTime":1649012310000,
        //                      "amount":9.00000000000000000000,
        //                      "address":"TYASr5UV6HEcXatwdFQfmLVUqQQQMUxHLS",
        //                      "networkName":"trc20",
        //                      "txId":"081e4e9351dd0274922168da5f2d14ea6c495b1c3b440244f4a6dd9fe196bf2b",
        //                      "coin":"usdt",
        //                      "status":"2"
        //                  },
        //              ],
        //              "page_length":20,
        //              "current_page":1
        //          },
        //          "error_code":0,
        //          "ts":1649719721758
        //      }
        //
        object data = this.safeValue(response, "data", new Dictionary<string, object>() {});
        object deposits = this.safeValue(data, "depositOrders", new List<object>() {});
        return this.parseTransactions(deposits, currency, since, limit);
    }

    public async override Task<object> fetchWithdrawals(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchWithdrawals
        * @description fetch all withdrawals made from an account
        * @param {string|undefined} code unified currency code
        * @param {int|undefined} since the earliest time in ms to fetch withdrawals for
        * @param {int|undefined} limit the maximum number of withdrawals structures to retrieve
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {[object]} a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object currency = null;
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
            ((Dictionary<string, object>)request)["coin"] = getValue(currency, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["startTime"] = since;
        }
        object response = await this.privatePostSupplementWithdraws(this.extend(request, parameters));
        //
        //      {
        //          "result":true,
        //          "data": {
        //              "total":1,
        //              "withdraws": [
        //                  {
        //                      "amount":2.00000000000000000000,
        //                      "address":"TBjrW5JHDyPZjFc5nrRMhRWUDaJmhGhmD6",
        //                      "fee":1.00000000000000000000,
        //                      "networkName":"trc20",
        //                      "coid":"usdt",
        //                      "transferType":"数字资产提现",
        //                      "txId":"47eeee2763ad49b8817524dacfa7d092fb58f8b0ab7e5d25473314df1a793c3d",
        //                      "id":1902194,
        //                      "applyTime":1649014002000,
        //                      "status":"4"
        //                  },
        //              ],
        //              "page_length":20,
        //              "current_page":1
        //          },
        //          "error_code":0,
        //          "ts":1649720362362
        //      }
        //
        object data = this.safeValue(response, "data", new Dictionary<string, object>() {});
        object withdraws = this.safeValue(data, "withdraws", new List<object>() {});
        return this.parseTransactions(withdraws, currency, since, limit);
    }

    public async override Task<object> fetchTransactionFees(object codes = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchTransactionFees
        * @description *DEPRECATED* please use fetchDepositWithdrawFees instead
        * @param {[string]|undefined} codes not used by lbank2 fetchTransactionFees ()
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} a list of [fee structures]{@link https://docs.ccxt.com/#/?id=fee-structure}
        */
        // private only returns information for currencies with non-zero balance
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object isAuthorized = this.checkRequiredCredentials(false);
        object result = null;
        if (isTrue(isEqual(isAuthorized, true)))
        {
            object method = this.safeString(parameters, "method");
            parameters = this.omit(parameters, "method");
            if (isTrue(isEqual(method, null)))
            {
                object options = this.safeValue(this.options, "fetchTransactionFees", new Dictionary<string, object>() {});
                method = this.safeString(options, "method", "fetchPrivateTransactionFees");
            }
            result = await this.callAsync(method, parameters);
        } else
        {
            result = await this.fetchPublicTransactionFees(parameters);
        }
        return result;
    }

    public async virtual Task<object> fetchPrivateTransactionFees(object parameters = null)
    {
        // complete response
        // incl. for coins which undefined in public method
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.privatePostSupplementUserInfo();
        //
        //    {
        //        "result": "true",
        //        "data": [
        //            {
        //                "usableAmt": "14.36",
        //                "assetAmt": "14.36",
        //                "networkList": [
        //                    {
        //                        "isDefault": false,
        //                        "withdrawFeeRate": "",
        //                        "name": "erc20",
        //                        "withdrawMin": 30,
        //                        "minLimit": 0.0001,
        //                        "minDeposit": 20,
        //                        "feeAssetCode": "usdt",
        //                        "withdrawFee": "30",
        //                        "type": 1,
        //                        "coin": "usdt",
        //                        "network": "eth"
        //                    },
        //                    ...
        //                ],
        //                "freezeAmt": "0",
        //                "coin": "ada"
        //            }
        //        ],
        //        "code": 0
        //    }
        //
        object result = this.safeValue(response, "data", new List<object>() {});
        object withdrawFees = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(result)); postFixIncrement(ref i))
        {
            object entry = getValue(result, i);
            object currencyId = this.safeString(entry, "coin");
            object code = this.safeCurrencyCode(currencyId);
            object networkList = this.safeValue(entry, "networkList", new List<object>() {});
            ((Dictionary<string, object>)withdrawFees)[(string)code] = new Dictionary<string, object>() {};
            for (object j = 0; isLessThan(j, getArrayLength(networkList)); postFixIncrement(ref j))
            {
                object networkEntry = getValue(networkList, j);
                object networkId = this.safeString(networkEntry, "name");
                object networkCode = this.safeString(getValue(this.options, "inverse-networks"), networkId, networkId);
                object fee = this.safeNumber(networkEntry, "withdrawFee");
                if (isTrue(!isEqual(fee, null)))
                {
                    ((Dictionary<string, object>)getValue(withdrawFees, code))[(string)networkCode] = fee;
                }
            }
        }
        return new Dictionary<string, object>() {
            { "withdraw", withdrawFees },
            { "deposit", new Dictionary<string, object>() {} },
            { "info", response },
        };
    }

    public async virtual Task<object> fetchPublicTransactionFees(object parameters = null)
    {
        // extremely incomplete response
        // vast majority fees undefined
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object code = this.safeString2(parameters, "coin", "assetCode");
        parameters = this.omit(parameters, new List<object>() {"coin", "assetCode"});
        object request = new Dictionary<string, object>() {};
        if (isTrue(!isEqual(code, null)))
        {
            object currency = this.currency(code);
            ((Dictionary<string, object>)request)["assetCode"] = getValue(currency, "id");
        }
        object response = await this.publicGetWithdrawConfigs(this.extend(request, parameters));
        //
        //    {
        //        result: 'true',
        //        data: [
        //          {
        //            amountScale: '4',
        //            chain: 'heco',
        //            assetCode: 'lbk',
        //            min: '200',
        //            transferAmtScale: '4',
        //            canWithDraw: true,
        //            fee: '100',
        //            minTransfer: '0.0001',
        //            type: '1'
        //          },
        //          ...
        //        ],
        //        error_code: '0',
        //        ts: '1663364435973'
        //    }
        //
        object result = this.safeValue(response, "data", new List<object>() {});
        object withdrawFees = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(result)); postFixIncrement(ref i))
        {
            object item = getValue(result, i);
            object canWithdraw = this.safeValue(item, "canWithDraw");
            if (isTrue(isEqual(canWithdraw, "true")))
            {
                object currencyId = this.safeString(item, "assetCode");
                object codeInner = this.safeCurrencyCode(currencyId);
                object chain = this.safeString(item, "chain");
                object network = this.safeString(getValue(this.options, "inverse-networks"), chain, chain);
                if (isTrue(isEqual(network, null)))
                {
                    network = codeInner;
                }
                object fee = this.safeString(item, "fee");
                if (isTrue(isEqual(getValue(withdrawFees, codeInner), null)))
                {
                    ((Dictionary<string, object>)withdrawFees)[(string)codeInner] = new Dictionary<string, object>() {};
                }
                ((Dictionary<string, object>)getValue(withdrawFees, codeInner))[(string)network] = this.parseNumber(fee);
            }
        }
        return new Dictionary<string, object>() {
            { "withdraw", withdrawFees },
            { "deposit", new Dictionary<string, object>() {} },
            { "info", response },
        };
    }

    public async override Task<object> fetchDepositWithdrawFees(object codes = null, object parameters = null)
    {
        /**
        * @method
        * @name lbank2#fetchDepositWithdrawFees
        * @description when using private endpoint, only returns information for currencies with non-zero balance, use public method by specifying this.options['fetchDepositWithdrawFees']['method'] = 'fetchPublicDepositWithdrawFees'
        * @param {[string]|undefined} codes array of unified currency codes
        * @param {object} params extra parameters specific to the lbank2 api endpoint
        * @returns {object} a list of [fee structures]{@link https://docs.ccxt.com/#/?id=fee-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object isAuthorized = this.checkRequiredCredentials(false);
        object method = null;
        if (isTrue(isEqual(isAuthorized, true)))
        {
            method = this.safeString(parameters, "method");
            parameters = this.omit(parameters, "method");
            if (isTrue(isEqual(method, null)))
            {
                object options = this.safeValue(this.options, "fetchDepositWithdrawFees", new Dictionary<string, object>() {});
                method = this.safeString(options, "method", "fetchPrivateDepositWithdrawFees");
            }
        } else
        {
            method = "fetchPublicDepositWithdrawFees";
        }
        return await this.callAsync(method, codes);
    }

    public async virtual Task<object> fetchPrivateDepositWithdrawFees(object codes = null, object parameters = null)
    {
        // complete response
        // incl. for coins which undefined in public method
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.privatePostSupplementUserInfo(parameters);
        //
        //    {
        //        "result": "true",
        //        "data": [
        //            {
        //                "usableAmt": "14.36",
        //                "assetAmt": "14.36",
        //                "networkList": [
        //                    {
        //                        "isDefault": false,
        //                        "withdrawFeeRate": "",
        //                        "name": "erc20",
        //                        "withdrawMin": 30,
        //                        "minLimit": 0.0001,
        //                        "minDeposit": 20,
        //                        "feeAssetCode": "usdt",
        //                        "withdrawFee": "30",
        //                        "type": 1,
        //                        "coin": "usdt",
        //                        "network": "eth"
        //                    },
        //                    ...
        //                ],
        //                "freezeAmt": "0",
        //                "coin": "ada"
        //            }
        //        ],
        //        "code": 0
        //    }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parseDepositWithdrawFees(data, codes, "coin");
    }

    public async virtual Task<object> fetchPublicDepositWithdrawFees(object codes = null, object parameters = null)
    {
        // extremely incomplete response
        // vast majority fees undefined
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object response = await this.publicGetWithdrawConfigs(this.extend(request, parameters));
        //
        //    {
        //        result: 'true',
        //        data: [
        //            {
        //                amountScale: '4',
        //                chain: 'heco',
        //                assetCode: 'lbk',
        //                min: '200',
        //                transferAmtScale: '4',
        //                canWithDraw: true,
        //                fee: '100',
        //                minTransfer: '0.0001',
        //                type: '1'
        //            },
        //            ...
        //        ],
        //        error_code: '0',
        //        ts: '1663364435973'
        //    }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parsePublicDepositWithdrawFees(data, codes);
    }

    public virtual object parsePublicDepositWithdrawFees(object response, object codes = null)
    {
        //
        //    [
        //        {
        //            amountScale: '4',
        //            chain: 'heco',
        //            assetCode: 'lbk',
        //            min: '200',
        //            transferAmtScale: '4',
        //            canWithDraw: true,
        //            fee: '100',
        //            minTransfer: '0.0001',
        //            type: '1'
        //        },
        //        ...
        //    ]
        //
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object fee = getValue(response, i);
            object canWithdraw = this.safeValue(fee, "canWithDraw");
            if (isTrue(isEqual(canWithdraw, true)))
            {
                object currencyId = this.safeString(fee, "assetCode");
                object code = this.safeCurrencyCode(currencyId);
                if (isTrue(isTrue(isEqual(codes, null)) || isTrue(this.inArray(code, codes))))
                {
                    object withdrawFee = this.safeNumber(fee, "fee");
                    if (isTrue(!isEqual(withdrawFee, null)))
                    {
                        object resultValue = this.safeValue(result, code);
                        if (isTrue(isEqual(resultValue, null)))
                        {
                            ((Dictionary<string, object>)result)[(string)code] = this.depositWithdrawFee(new List<object>() {fee});
                        } else
                        {
                            ((List<object>)getValue(getValue(result, code), "info")).Add(fee);
                        }
                        object chain = this.safeString(fee, "chain");
                        object networkCode = this.safeString(getValue(this.options, "inverse-networks"), chain, chain);
                        if (isTrue(!isEqual(networkCode, null)))
                        {
                            ((Dictionary<string, object>)getValue(getValue(result, code), "networks"))[(string)networkCode] = new Dictionary<string, object>() {
                                { "withdraw", new Dictionary<string, object>() {
                                    { "fee", withdrawFee },
                                    { "percentage", null },
                                } },
                                { "deposit", new Dictionary<string, object>() {
                                    { "fee", null },
                                    { "percentage", null },
                                } },
                            };
                        } else
                        {
                            ((Dictionary<string, object>)getValue(result, code))["withdraw"] = new Dictionary<string, object>() {
                                { "fee", withdrawFee },
                                { "percentage", null },
                            };
                        }
                    }
                }
            }
        }
        return result;
    }

    public override object parseDepositWithdrawFee(object fee, object currency = null)
    {
        //
        // * only used for fetchPrivateDepositWithdrawFees
        //
        //    {
        //        "usableAmt": "14.36",
        //        "assetAmt": "14.36",
        //        "networkList": [
        //            {
        //                "isDefault": false,
        //                "withdrawFeeRate": "",
        //                "name": "erc20",
        //                "withdrawMin": 30,
        //                "minLimit": 0.0001,
        //                "minDeposit": 20,
        //                "feeAssetCode": "usdt",
        //                "withdrawFee": "30",
        //                "type": 1,
        //                "coin": "usdt",
        //                "network": "eth"
        //            },
        //            ...
        //        ],
        //        "freezeAmt": "0",
        //        "coin": "ada"
        //    }
        //
        object result = this.depositWithdrawFee(fee);
        object networkList = this.safeValue(fee, "networkList", new List<object>() {});
        for (object j = 0; isLessThan(j, getArrayLength(networkList)); postFixIncrement(ref j))
        {
            object networkEntry = getValue(networkList, j);
            object networkId = this.safeString(networkEntry, "name");
            object networkCode = this.safeStringUpper(getValue(this.options, "inverse-networks"), networkId, networkId);
            object withdrawFee = this.safeNumber(networkEntry, "withdrawFee");
            object isDefault = this.safeValue(networkEntry, "isDefault");
            if (isTrue(!isEqual(withdrawFee, null)))
            {
                if (isTrue(isDefault))
                {
                    ((Dictionary<string, object>)result)["withdraw"] = new Dictionary<string, object>() {
                        { "fee", withdrawFee },
                        { "percentage", null },
                    };
                }
                ((Dictionary<string, object>)getValue(result, "networks"))[(string)networkCode] = new Dictionary<string, object>() {
                    { "withdraw", new Dictionary<string, object>() {
                        { "fee", withdrawFee },
                        { "percentage", null },
                    } },
                    { "deposit", new Dictionary<string, object>() {
                        { "fee", null },
                        { "percentage", null },
                    } },
                };
            }
        }
        return result;
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object query = this.omit(parameters, this.extractParams(path));
        object url = add(add(add(add(getValue(getValue(this.urls, "api"), "rest"), "/"), this.version), "/"), this.implodeParams(path, parameters));
        // Every endpoint ends with ".do"
        url = add(url, ".do");
        if (isTrue(isEqual(api, "public")))
        {
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
            {
                url = add(url, add("?", this.urlencode(this.keysort(query))));
            }
        } else
        {
            this.checkRequiredCredentials();
            object timestamp = ((object)this.milliseconds()).ToString();
            object echostr = add(this.uuid22(), this.uuid16());
            query = this.extend(new Dictionary<string, object>() {
                { "api_key", this.apiKey },
            }, query);
            object signatureMethod = null;
            if (isTrue(isGreaterThan(((string)this.secret).Length, 32)))
            {
                signatureMethod = "RSA";
            } else
            {
                signatureMethod = "HmacSHA256";
            }
            object auth = this.rawencode(this.keysort(this.extend(new Dictionary<string, object>() {
                { "echostr", echostr },
                { "signature_method", signatureMethod },
                { "timestamp", timestamp },
            }, query)));
            object encoded = this.encode(auth);
            object hash = this.hash(encoded, sha256);
            object uppercaseHash = ((string)hash).ToUpper();
            object sign = null;
            if (isTrue(isEqual(signatureMethod, "RSA")))
            {
                object cacheSecretAsPem = this.safeValue(this.options, "cacheSecretAsPem", true);
                object pem = null;
                if (isTrue(cacheSecretAsPem))
                {
                    pem = this.safeValue(this.options, "pem");
                    if (isTrue(isEqual(pem, null)))
                    {
                        pem = this.convertSecretToPem(this.encode(this.secret));
                        ((Dictionary<string, object>)this.options)["pem"] = pem;
                    }
                } else
                {
                    pem = this.convertSecretToPem(this.encode(this.secret));
                }
                sign = rsa(uppercaseHash, pem, sha256);
            } else if (isTrue(isEqual(signatureMethod, "HmacSHA256")))
            {
                sign = this.hmac(this.encode(uppercaseHash), this.encode(this.secret), sha256);
            }
            ((Dictionary<string, object>)query)["sign"] = sign;
            body = this.urlencode(this.keysort(query));
            headers = new Dictionary<string, object>() {
                { "Content-Type", "application/x-www-form-urlencoded" },
                { "timestamp", timestamp },
                { "signature_method", signatureMethod },
                { "echostr", echostr },
            };
        }
        return new Dictionary<string, object>() {
            { "url", url },
            { "method", method },
            { "body", body },
            { "headers", headers },
        };
    }

    public virtual object convertSecretToPem(object secret)
    {
        object lineLength = 64;
        object secretLength = subtract(getArrayLength(secret), 0);
        object numLines = this.parseToInt(divide(secretLength, lineLength));
        numLines = this.sum(numLines, 1);
        object pem = "-----BEGIN PRIVATE KEY-----\n"; // eslint-disable-line
        for (object i = 0; isLessThan(i, numLines); postFixIncrement(ref i))
        {
            object start = multiply(i, lineLength);
            object end = this.sum(start, lineLength);
            pem = add(pem, add(((string)this.secret).Substring((int)start, (int)end), "\n")); // eslint-disable-line
        }
        return add(pem, "-----END PRIVATE KEY-----");
    }

    public override object handleErrors(object httpCode, object reason, object url, object method, object headers, object body, object response, object requestHeaders, object requestBody)
    {
        if (isTrue(isEqual(response, null)))
        {
            return null;
        }
        object success = this.safeString(response, "result");
        if (isTrue(isEqual(success, "false")))
        {
            object errorCode = this.safeString(response, "error_code");
            object message = this.safeString(new Dictionary<string, object>() {
                { "10000", "Internal error" },
                { "10001", "The required parameters can not be empty" },
                { "10002", "Validation failed" },
                { "10003", "Invalid parameter" },
                { "10004", "Request too frequent" },
                { "10005", "Secret key does not exist" },
                { "10006", "User does not exist" },
                { "10007", "Invalid signature" },
                { "10008", "Invalid Trading Pair" },
                { "10009", "Price and/or Amount are required for limit order" },
                { "10010", "Price and/or Amount must be less than minimum requirement" },
                { "10013", "The amount is too small" },
                { "10014", "Insufficient amount of money in the account" },
                { "10015", "Invalid order type" },
                { "10016", "Insufficient account balance" },
                { "10017", "Server Error" },
                { "10018", "Page size should be between 1 and 50" },
                { "10019", "Cancel NO more than 3 orders in one request" },
                { "10020", "Volume < 0.001" },
                { "10021", "Price < 0.01" },
                { "10022", "Invalid authorization" },
                { "10023", "Market Order is not supported yet" },
                { "10024", "User cannot trade on this pair" },
                { "10025", "Order has been filled" },
                { "10026", "Order has been cancelld" },
                { "10027", "Order is cancelling" },
                { "10028", "Wrong query time" },
                { "10029", "from is not in the query time" },
                { "10030", "from do not match the transaction type of inqury" },
                { "10031", "echostr length must be valid and length must be from 30 to 40" },
                { "10033", "Failed to create order" },
                { "10036", "customID duplicated" },
                { "10100", "Has no privilege to withdraw" },
                { "10101", "Invalid fee rate to withdraw" },
                { "10102", "Too little to withdraw" },
                { "10103", "Exceed daily limitation of withdraw" },
                { "10104", "Cancel was rejected" },
                { "10105", "Request has been cancelled" },
                { "10106", "None trade time" },
                { "10107", "Start price exception" },
                { "10108", "can not create order" },
                { "10109", "wallet address is not mapping" },
                { "10110", "transfer fee is not mapping" },
                { "10111", "mount > 0" },
                { "10112", "fee is too lower" },
                { "10113", "transfer fee is 0" },
                { "10600", "intercepted by replay attacks filter, check timestamp" },
                { "10601", "Interface closed unavailable" },
                { "10701", "invalid asset code" },
                { "10702", "not allowed deposit" },
            }, errorCode, this.json(response));
            object ErrorClass = this.safeValue(new Dictionary<string, object>() {
                { "10001", typeof(BadRequest) },
                { "10002", typeof(AuthenticationError) },
                { "10003", typeof(BadRequest) },
                { "10004", typeof(RateLimitExceeded) },
                { "10005", typeof(AuthenticationError) },
                { "10006", typeof(AuthenticationError) },
                { "10007", typeof(AuthenticationError) },
                { "10008", typeof(BadSymbol) },
                { "10009", typeof(InvalidOrder) },
                { "10010", typeof(InvalidOrder) },
                { "10013", typeof(InvalidOrder) },
                { "10014", typeof(InsufficientFunds) },
                { "10015", typeof(InvalidOrder) },
                { "10016", typeof(InsufficientFunds) },
                { "10017", typeof(ExchangeError) },
                { "10018", typeof(BadRequest) },
                { "10019", typeof(BadRequest) },
                { "10020", typeof(BadRequest) },
                { "10021", typeof(InvalidOrder) },
                { "10022", typeof(PermissionDenied) },
                { "10023", typeof(InvalidOrder) },
                { "10024", typeof(PermissionDenied) },
                { "10025", typeof(InvalidOrder) },
                { "10026", typeof(InvalidOrder) },
                { "10027", typeof(InvalidOrder) },
                { "10028", typeof(BadRequest) },
                { "10029", typeof(BadRequest) },
                { "10030", typeof(BadRequest) },
                { "10031", typeof(InvalidNonce) },
                { "10033", typeof(ExchangeError) },
                { "10036", typeof(DuplicateOrderId) },
                { "10100", typeof(PermissionDenied) },
                { "10101", typeof(BadRequest) },
                { "10102", typeof(InsufficientFunds) },
                { "10103", typeof(ExchangeError) },
                { "10104", typeof(ExchangeError) },
                { "10105", typeof(ExchangeError) },
                { "10106", typeof(BadRequest) },
                { "10107", typeof(BadRequest) },
                { "10108", typeof(ExchangeError) },
                { "10109", typeof(InvalidAddress) },
                { "10110", typeof(ExchangeError) },
                { "10111", typeof(BadRequest) },
                { "10112", typeof(BadRequest) },
                { "10113", typeof(BadRequest) },
                { "10600", typeof(BadRequest) },
                { "10601", typeof(ExchangeError) },
                { "10701", typeof(BadSymbol) },
                { "10702", typeof(PermissionDenied) },
            }, errorCode, typeof(ExchangeError));
            throwDynamicException((string)ErrorClass, message);return null;
        }
        return null;
    }
}
