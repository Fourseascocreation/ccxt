using Main;
namespace Main;

partial class alpaca : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "alpaca" },
            { "name", "Alpaca" },
            { "countries", new List<object>() {"US"} },
            { "rateLimit", 333 },
            { "hostname", "alpaca.markets" },
            { "pro", true },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/1294454/187234005-b864db3d-f1e3-447a-aaf9-a9fc7b955d07.jpg" },
                { "www", "https://alpaca.markets" },
                { "api", new Dictionary<string, object>() {
                    { "public", "https://api.{hostname}/{version}" },
                    { "private", "https://api.{hostname}/{version}" },
                    { "cryptoPublic", "https://data.{hostname}/{version}" },
                    { "markets", "https://api.{hostname}/{version}" },
                } },
                { "test", new Dictionary<string, object>() {
                    { "public", "https://paper-api.{hostname}/{version}" },
                    { "private", "https://paper-api.{hostname}/{version}" },
                    { "cryptoPublic", "https://data.{hostname}/{version}" },
                    { "markets", "https://api.{hostname}/{version}" },
                } },
                { "doc", "https://alpaca.markets/docs/" },
                { "fees", "https://alpaca.markets/support/what-are-the-fees-associated-with-crypto-trading/" },
            } },
            { "has", new Dictionary<string, object>() {
                { "CORS", false },
                { "spot", true },
                { "margin", false },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "cancelAllOrders", true },
                { "cancelOrder", true },
                { "createOrder", true },
                { "fetchBalance", true },
                { "fetchBidsAsks", false },
                { "fetchClosedOrders", false },
                { "fetchCurrencies", false },
                { "fetchDepositAddress", false },
                { "fetchDepositAddressesByNetwork", false },
                { "fetchDeposits", false },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", false },
                { "fetchFundingRates", false },
                { "fetchL1OrderBook", true },
                { "fetchL2OrderBook", false },
                { "fetchMarkets", true },
                { "fetchMyTrades", false },
                { "fetchOHLCV", true },
                { "fetchOpenOrder", false },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchOrders", false },
                { "fetchPositions", false },
                { "fetchStatus", false },
                { "fetchTicker", false },
                { "fetchTickers", false },
                { "fetchTime", false },
                { "fetchTrades", true },
                { "fetchTradingFee", false },
                { "fetchTradingFees", false },
                { "fetchTransactionFees", false },
                { "fetchTransactions", false },
                { "fetchTransfers", false },
                { "fetchWithdrawals", false },
                { "setLeverage", false },
                { "setMarginMode", false },
                { "transfer", false },
                { "withdraw", false },
            } },
            { "api", new Dictionary<string, object>() {
                { "markets", new Dictionary<string, object>() {
                    { "get", new List<object>() {"assets/public/beta"} },
                } },
                { "private", new Dictionary<string, object>() {
                    { "get", new List<object>() {"account", "orders", "orders/{order_id}", "positions", "positions/{symbol}", "account/activities/{activity_type}"} },
                    { "post", new List<object>() {"orders"} },
                    { "delete", new List<object>() {"orders", "orders/{order_id}"} },
                } },
                { "cryptoPublic", new Dictionary<string, object>() {
                    { "get", new List<object>() {"crypto/latest/orderbooks", "crypto/trades", "crypto/quotes", "crypto/latest/quotes", "crypto/bars", "crypto/snapshots"} },
                } },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "1min" },
                { "3m", "3min" },
                { "5m", "5min" },
                { "15m", "15min" },
                { "30m", "30min" },
                { "1h", "1H" },
                { "2h", "2H" },
                { "4h", "4H" },
                { "6h", "6H" },
                { "8h", "8H" },
                { "12h", "12H" },
                { "1d", "1D" },
                { "3d", "3D" },
                { "1w", "1W" },
                { "1M", "1M" },
            } },
            { "precisionMode", TICK_SIZE },
            { "requiredCredentials", new Dictionary<string, object>() {
                { "apiKey", true },
                { "secret", true },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "tierBased", true },
                    { "percentage", true },
                    { "maker", this.parseNumber("0.003") },
                    { "taker", this.parseNumber("0.003") },
                    { "tiers", new Dictionary<string, object>() {
                        { "taker", new List<object>() {new List<object> {this.parseNumber("0"), this.parseNumber("0.003")}, new List<object> {this.parseNumber("500000"), this.parseNumber("0.0028")}, new List<object> {this.parseNumber("1000000"), this.parseNumber("0.0025")}, new List<object> {this.parseNumber("5000000"), this.parseNumber("0.002")}, new List<object> {this.parseNumber("10000000"), this.parseNumber("0.0018")}, new List<object> {this.parseNumber("25000000"), this.parseNumber("0.0015")}, new List<object> {this.parseNumber("50000000"), this.parseNumber("0.00125")}, new List<object> {this.parseNumber("100000000"), this.parseNumber("0.001")}} },
                        { "maker", new List<object>() {new List<object> {this.parseNumber("0"), this.parseNumber("0.003")}, new List<object> {this.parseNumber("500000"), this.parseNumber("0.0028")}, new List<object> {this.parseNumber("1000000"), this.parseNumber("0.0025")}, new List<object> {this.parseNumber("5000000"), this.parseNumber("0.002")}, new List<object> {this.parseNumber("10000000"), this.parseNumber("0.0018")}, new List<object> {this.parseNumber("25000000"), this.parseNumber("0.0015")}, new List<object> {this.parseNumber("50000000"), this.parseNumber("0.00125")}, new List<object> {this.parseNumber("100000000"), this.parseNumber("0.001")}} },
                    } },
                } },
            } },
            { "headers", new Dictionary<string, object>() {
                { "APCA-PARTNER-ID", "ccxt" },
            } },
            { "options", new Dictionary<string, object>() {
                { "fetchTradesMethod", "cryptoPublicGetCryptoTrades" },
                { "fetchOHLCVMethod", "cryptoPublicGetCryptoBars" },
                { "versions", new Dictionary<string, object>() {
                    { "public", "v2" },
                    { "private", "v2" },
                    { "cryptoPublic", "v1beta2" },
                    { "markets", "v2" },
                } },
                { "defaultExchange", "CBSE" },
                { "exchanges", new List<object>() {"CBSE", "FTX", "GNSS", "ERSX"} },
                { "defaultTimeInForce", "gtc" },
                { "clientOrderId", "ccxt_{id}" },
            } },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {
                    { "forbidden.", typeof(PermissionDenied) },
                    { "40410000", typeof(InvalidOrder) },
                    { "40010001", typeof(BadRequest) },
                    { "40110000", typeof(PermissionDenied) },
                    { "40310000", typeof(InsufficientFunds) },
                } },
                { "broad", new Dictionary<string, object>() {
                    { "Invalid format for parameter", typeof(BadRequest) },
                    { "Invalid symbol", typeof(BadSymbol) },
                } },
            } },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name alpaca#fetchMarkets
        * @description retrieves data on all markets for alpaca
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        parameters ??= new Dictionary<string, object>();
        object request = new Dictionary<string, object>() {
            { "asset_class", "crypto" },
            { "tradeable", true },
        };
        object assets = await this.marketsGetAssetsPublicBeta(this.extend(request, parameters));
        //
        //    [
        //        {
        //           "id":"a3ba8ac0-166d-460b-b17a-1f035622dd47",
        //           "class":"crypto",
        //           "exchange":"FTXU",
        //           "symbol":"DOGEUSD",
        //           "name":"Dogecoin",
        //           "status":"active",
        //           "tradable":true,
        //           "marginable":false,
        //           "shortable":false,
        //           "easy_to_borrow":false,
        //           "fractionable":true,
        //           "min_order_size":"1",
        //           "min_trade_increment":"1",
        //           "price_increment":"0.0000005"
        //        }
        //    ]
        //
        object markets = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(assets)); postFixIncrement(ref i))
        {
            object asset = getValue(assets, i);
            object marketId = this.safeString(asset, "symbol");
            object parts = ((string)marketId).Split((string)"/").ToList<object>();
            object baseId = this.safeString(parts, 0);
            object quoteId = this.safeString(parts, 1);
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
            object symbol = add(add(bs, "/"), quote);
            object status = this.safeString(asset, "status");
            object active = (isEqual(status, "active"));
            object minAmount = this.safeNumber(asset, "min_order_size");
            object amount = this.safeNumber(asset, "min_trade_increment");
            object price = this.safeNumber(asset, "price_increment");
            ((List<object>)markets).Add(new Dictionary<string, object>() {
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
                { "margin", null },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "active", active },
                { "contract", false },
                { "linear", null },
                { "inverse", null },
                { "contractSize", null },
                { "expiry", null },
                { "expiryDatetime", null },
                { "strike", null },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "amount", amount },
                    { "price", price },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", minAmount },
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
                { "info", asset },
            });
        }
        return markets;
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name alpaca#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the alpaca api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/en/latest/manual.html?#public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object id = getValue(market, "id");
        object request = new Dictionary<string, object>() {
            { "symbols", id },
        };
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["start"] = this.iso8601(since);
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = parseInt(limit);
        }
        object method = this.safeString(this.options, "fetchTradesMethod", "cryptoPublicGetCryptoTrades");
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        // {
        //     "next_page_token":null,
        //     "trades":{
        //        "BTC/USD":[
        //           {
        //              "i":36440704,
        //              "p":22625,
        //              "s":0.0001,
        //              "t":"2022-07-21T11:47:31.073391Z",
        //              "tks":"B"
        //           }
        //        ]
        //     }
        // }
        //
        object trades = this.safeValue(response, "trades", new Dictionary<string, object>() {});
        object symbolTrades = this.safeValue(trades, getValue(market, "id"), new Dictionary<string, object>() {});
        return this.parseTrades(symbolTrades, market, since, limit);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name alpaca#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the alpaca api endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object id = getValue(market, "id");
        object request = new Dictionary<string, object>() {
            { "symbols", id },
        };
        object response = await this.cryptoPublicGetCryptoLatestOrderbooks(this.extend(request, parameters));
        //
        //   {
        //       "orderbooks":{
        //          "BTC/USD":{
        //             "a":[
        //                {
        //                   "p":22208,
        //                   "s":0.0051
        //                },
        //                {
        //                   "p":22209,
        //                   "s":0.1123
        //                },
        //                {
        //                   "p":22210,
        //                   "s":0.2465
        //                }
        //             ],
        //             "b":[
        //                {
        //                   "p":22203,
        //                   "s":0.395
        //                },
        //                {
        //                   "p":22202,
        //                   "s":0.2465
        //                },
        //                {
        //                   "p":22201,
        //                   "s":0.6455
        //                }
        //             ],
        //             "t":"2022-07-19T13:41:55.13210112Z"
        //          }
        //       }
        //   }
        //
        object orderbooks = this.safeValue(response, "orderbooks", new Dictionary<string, object>() {});
        object rawOrderbook = this.safeValue(orderbooks, id, new Dictionary<string, object>() {});
        object timestamp = this.parse8601(this.safeString(rawOrderbook, "t"));
        return this.parseOrderBook(rawOrderbook, getValue(market, "symbol"), timestamp, "b", "a", "p", "s");
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name alpaca#fetchOHLCV
        * @description fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents
        * @param {int|undefined} since timestamp in ms of the earliest candle to fetch
        * @param {int|undefined} limit the maximum amount of candles to fetch
        * @param {object} params extra parameters specific to the alpha api endpoint
        * @returns {[[int]]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbols", getValue(market, "id") },
            { "timeframe", this.safeString(this.timeframes, timeframe, timeframe) },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit;
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["start"] = this.yyyymmdd(since);
        }
        object method = this.safeString(this.options, "fetchOHLCVMethod", "cryptoPublicGetCryptoBars");
        object response = await this.callAsync(method, this.extend(request, parameters));
        //
        //    {
        //        "bars":{
        //           "BTC/USD":[
        //              {
        //                 "c":22887,
        //                 "h":22888,
        //                 "l":22873,
        //                 "n":11,
        //                 "o":22883,
        //                 "t":"2022-07-21T05:00:00Z",
        //                 "v":1.1138,
        //                 "vw":22883.0155324116
        //              },
        //              {
        //                 "c":22895,
        //                 "h":22895,
        //                 "l":22884,
        //                 "n":6,
        //                 "o":22884,
        //                 "t":"2022-07-21T05:01:00Z",
        //                 "v":0.001,
        //                 "vw":22889.5
        //              }
        //           ]
        //        },
        //        "next_page_token":"QlRDL1VTRHxNfDIwMjItMDctMjFUMDU6MDE6MDAuMDAwMDAwMDAwWg=="
        //     }
        //
        object bars = this.safeValue(response, "bars", new Dictionary<string, object>() {});
        object ohlcvs = this.safeValue(bars, getValue(market, "id"), new Dictionary<string, object>() {});
        return this.parseOHLCVs(ohlcvs, market, timeframe, since, limit);
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //
        //     {
        //        "c":22895,
        //        "h":22895,
        //        "l":22884,
        //        "n":6,
        //        "o":22884,
        //        "t":"2022-07-21T05:01:00Z",
        //        "v":0.001,
        //        "vw":22889.5
        //     }
        //
        object datetime = this.safeString(ohlcv, "t");
        object timestamp = this.parse8601(datetime);
        return new List<object>() {timestamp, this.safeNumber(ohlcv, "o"), this.safeNumber(ohlcv, "h"), this.safeNumber(ohlcv, "l"), this.safeNumber(ohlcv, "c"), this.safeNumber(ohlcv, "v")};
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name alpaca#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market', 'limit' or 'stop_limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the alpaca api endpoint
        * @param {float} params.triggerPrice The price at which a trigger order is triggered at
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object id = getValue(market, "id");
        object request = new Dictionary<string, object>() {
            { "symbol", id },
            { "qty", this.amountToPrecision(symbol, amount) },
            { "side", side },
            { "type", type },
        };
        object triggerPrice = this.safeStringN(parameters, new List<object>() {"triggerPrice", "stop_price"});
        if (isTrue(!isEqual(triggerPrice, null)))
        {
            object newType = null;
            if (isTrue(isGreaterThanOrEqual(getIndexOf(type, "limit"), 0)))
            {
                newType = "stop_limit";
            } else
            {
                throw new NotSupported ((string)add(add(add(this.id, " createOrder() does not support stop orders for "), type), " orders, only stop_limit orders are supported")) ;
            }
            ((Dictionary<string, object>)request)["stop_price"] = this.priceToPrecision(symbol, triggerPrice);
            ((Dictionary<string, object>)request)["type"] = newType;
        }
        if (isTrue(isGreaterThanOrEqual(getIndexOf(type, "limit"), 0)))
        {
            ((Dictionary<string, object>)request)["limit_price"] = this.priceToPrecision(symbol, price);
        }
        object defaultTIF = this.safeString(this.options, "defaultTimeInForce");
        ((Dictionary<string, object>)request)["time_in_force"] = this.safeString(parameters, "timeInForce", defaultTIF);
        parameters = this.omit(parameters, new List<object>() {"timeInForce", "triggerPrice"});
        object clientOrderIdprefix = this.safeString(this.options, "clientOrderId");
        object uuid = this.uuid();
        object parts = ((string)uuid).Split((string)"-").ToList<object>();
        object random_id = String.Join("", parts);
        object defaultClientId = this.implodeParams(clientOrderIdprefix, new Dictionary<string, object>() {
            { "id", random_id },
        });
        object clientOrderId = this.safeString(parameters, "clientOrderId", defaultClientId);
        ((Dictionary<string, object>)request)["client_order_id"] = clientOrderId;
        parameters = this.omit(parameters, new List<object>() {"clientOrderId"});
        object order = await this.privatePostOrders(this.extend(request, parameters));
        //
        //   {
        //      "id": "61e69015-8549-4bfd-b9c3-01e75843f47d",
        //      "client_order_id": "eb9e2aaa-f71a-4f51-b5b4-52a6c565dad4",
        //      "created_at": "2021-03-16T18:38:01.942282Z",
        //      "updated_at": "2021-03-16T18:38:01.942282Z",
        //      "submitted_at": "2021-03-16T18:38:01.937734Z",
        //      "filled_at": null,
        //      "expired_at": null,
        //      "canceled_at": null,
        //      "failed_at": null,
        //      "replaced_at": null,
        //      "replaced_by": null,
        //      "replaces": null,
        //      "asset_id": "b0b6dd9d-8b9b-48a9-ba46-b9d54906e415",
        //      "symbol": "AAPL",
        //      "asset_class": "us_equity",
        //      "notional": "500",
        //      "qty": null,
        //      "filled_qty": "0",
        //      "filled_avg_price": null,
        //      "order_class": "",
        //      "order_type": "market",
        //      "type": "market",
        //      "side": "buy",
        //      "time_in_force": "day",
        //      "limit_price": null,
        //      "stop_price": null,
        //      "status": "accepted",
        //      "extended_hours": false,
        //      "legs": null,
        //      "trail_percent": null,
        //      "trail_price": null,
        //      "hwm": null
        //   }
        //
        return this.parseOrder(order, market);
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name alpaca#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string|undefined} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the alpaca api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object request = new Dictionary<string, object>() {
            { "order_id", id },
        };
        object response = await this.privateDeleteOrdersOrderId(this.extend(request, parameters));
        //
        //   {
        //       "code": 40410000,
        //       "message": "order is not found."
        //   }
        //
        return this.safeValue(response, "message", new Dictionary<string, object>() {});
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name alpaca#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string|undefined} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the alpaca api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "order_id", id },
        };
        object order = await this.privateGetOrdersOrderId(this.extend(request, parameters));
        object marketId = this.safeString(order, "symbol");
        object market = this.safeMarket(marketId);
        return this.parseOrder(order, market);
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name alpaca#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the alpaca api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
        }
        object orders = await this.privateGetOrders(parameters);
        return this.parseOrders(orders, market, since, limit);
    }

    public override object parseOrder(object order, object market = null)
    {
        //
        //    {
        //        "id":"6ecfcc34-4bed-4b53-83ba-c564aa832a81",
        //        "client_order_id":"ccxt_1c6ceab0b5e84727b2f1c0394ba17560",
        //        "created_at":"2022-06-14T13:59:30.224037068Z",
        //        "updated_at":"2022-06-14T13:59:30.224037068Z",
        //        "submitted_at":"2022-06-14T13:59:30.221856828Z",
        //        "filled_at":null,
        //        "expired_at":null,
        //        "canceled_at":null,
        //        "failed_at":null,
        //        "replaced_at":null,
        //        "replaced_by":null,
        //        "replaces":null,
        //        "asset_id":"64bbff51-59d6-4b3c-9351-13ad85e3c752",
        //        "symbol":"BTCUSD",
        //        "asset_class":"crypto",
        //        "notional":null,
        //        "qty":"0.01",
        //        "filled_qty":"0",
        //        "filled_avg_price":null,
        //        "order_class":"",
        //        "order_type":"limit",
        //        "type":"limit",
        //        "side":"buy",
        //        "time_in_force":"day",
        //        "limit_price":"14000",
        //        "stop_price":null,
        //        "status":"accepted",
        //        "extended_hours":false,
        //        "legs":null,
        //        "trail_percent":null,
        //        "trail_price":null,
        //        "hwm":null,
        //        "commission":"0.42",
        //        "source":null
        //    }
        //
        object marketId = this.safeString(order, "symbol");
        market = this.safeMarket(marketId, market);
        object symbol = getValue(market, "symbol");
        object alpacaStatus = this.safeString(order, "status");
        object status = this.parseOrderStatus(alpacaStatus);
        object feeValue = this.safeString(order, "commission");
        object fee = null;
        if (isTrue(!isEqual(feeValue, null)))
        {
            fee = new Dictionary<string, object>() {
                { "cost", feeValue },
                { "currency", "USD" },
            };
        }
        object orderType = this.safeString(order, "order_type");
        if (isTrue(isGreaterThanOrEqual(getIndexOf(orderType, "limit"), 0)))
        {
            // might be limit or stop-limit
            orderType = "limit";
        }
        object datetime = this.safeString(order, "submitted_at");
        object timestamp = this.parse8601(datetime);
        return this.safeOrder(new Dictionary<string, object>() {
            { "id", this.safeString(order, "id") },
            { "clientOrderId", this.safeString(order, "client_order_id") },
            { "timestamp", timestamp },
            { "datetime", datetime },
            { "lastTradeTimeStamp", null },
            { "status", status },
            { "symbol", symbol },
            { "type", orderType },
            { "timeInForce", this.parseTimeInForce(this.safeString(order, "time_in_force")) },
            { "postOnly", null },
            { "side", this.safeString(order, "side") },
            { "price", this.safeNumber(order, "limit_price") },
            { "stopPrice", this.safeNumber(order, "stop_price") },
            { "triggerPrice", this.safeNumber(order, "stop_price") },
            { "cost", null },
            { "average", this.safeNumber(order, "filled_avg_price") },
            { "amount", this.safeNumber(order, "qty") },
            { "filled", this.safeNumber(order, "filled_qty") },
            { "remaining", null },
            { "trades", null },
            { "fee", fee },
            { "info", order },
        }, market);
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "pending_new", "open" },
            { "accepted", "open" },
            { "new", "open" },
            { "partially_filled", "open" },
            { "activated", "open" },
            { "filled", "closed" },
        };
        return this.safeString(statuses, status, status);
    }

    public virtual object parseTimeInForce(object timeInForce)
    {
        object timeInForces = new Dictionary<string, object>() {
            { "day", "Day" },
        };
        return this.safeString(timeInForces, timeInForce, timeInForce);
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        //   {
        //       "t":"2022-06-14T05:00:00.027869Z",
        //       "x":"CBSE",
        //       "p":"21942.15",
        //       "s":"0.0001",
        //       "tks":"S",
        //       "i":"355681339"
        //   }
        //
        object marketId = this.safeString(trade, "S");
        object symbol = this.safeSymbol(marketId, market);
        object datetime = this.safeString(trade, "t");
        object timestamp = this.parse8601(datetime);
        object alpacaSide = this.safeString(trade, "tks");
        object side = null;
        if (isTrue(isEqual(alpacaSide, "B")))
        {
            side = "buy";
        } else if (isTrue(isEqual(alpacaSide, "S")))
        {
            side = "sell";
        }
        object priceString = this.safeString(trade, "p");
        object amountString = this.safeString(trade, "s");
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "id", this.safeString(trade, "i") },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", symbol },
            { "order", null },
            { "type", null },
            { "side", side },
            { "takerOrMaker", "taker" },
            { "price", priceString },
            { "amount", amountString },
            { "cost", null },
            { "fee", null },
        }, market);
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object versions = this.safeValue(this.options, "versions");
        object version = this.safeString(versions, api);
        object endpoint = add("/", this.implodeParams(path, parameters));
        object url = this.implodeParams(getValue(getValue(this.urls, "api"), api), new Dictionary<string, object>() {
            { "version", version },
        });
        url = this.implodeHostname(url);
        headers = ((bool) isTrue((!isEqual(headers, null)))) ? headers : new Dictionary<string, object>() {};
        if (isTrue(isEqual(api, "private")))
        {
            ((Dictionary<string, object>)headers)["APCA-API-KEY-ID"] = this.apiKey;
            ((Dictionary<string, object>)headers)["APCA-API-SECRET-KEY"] = this.secret;
        }
        object query = this.omit(parameters, this.extractParams(path));
        if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
        {
            if (isTrue(isTrue((isEqual(method, "GET"))) || isTrue((isEqual(method, "DELETE")))))
            {
                endpoint = add(endpoint, add("?", this.urlencode(query)));
            } else
            {
                body = this.json(query);
                ((Dictionary<string, object>)headers)["Content-Type"] = "application/json";
            }
        }
        url = add(url, endpoint);
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
            return null;  // default error handler
        }
        // {
        //     "code": 40110000,
        //     "message": "request is not authorized"
        // }
        object feedback = add(add(this.id, " "), body);
        object errorCode = this.safeString(response, "code");
        if (isTrue(!isEqual(code, null)))
        {
            this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), errorCode, feedback);
        }
        object message = this.safeValue(response, "message", null);
        if (isTrue(!isEqual(message, null)))
        {
            this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), message, feedback);
            this.throwBroadlyMatchedException(getValue(this.exceptions, "broad"), message, feedback);
            throw new ExchangeError ((string)feedback) ;
        }
        return null;
    }
}
