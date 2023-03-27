using Main;
namespace Main;

partial class ripio : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "ripio" },
            { "name", "Ripio" },
            { "countries", new List<object>() {"AR", "BR"} },
            { "rateLimit", 50 },
            { "version", "v1" },
            { "pro", true },
            { "has", new Dictionary<string, object>() {
                { "CORS", null },
                { "spot", true },
                { "margin", false },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "addMargin", false },
                { "cancelOrder", true },
                { "createOrder", true },
                { "createReduceOnlyOrder", false },
                { "fetchBalance", true },
                { "fetchBorrowRate", false },
                { "fetchBorrowRateHistories", false },
                { "fetchBorrowRateHistory", false },
                { "fetchBorrowRates", false },
                { "fetchBorrowRatesPerSymbol", false },
                { "fetchClosedOrders", true },
                { "fetchCurrencies", true },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", false },
                { "fetchFundingRateHistory", false },
                { "fetchFundingRates", false },
                { "fetchIndexOHLCV", false },
                { "fetchLeverage", false },
                { "fetchLeverageTiers", false },
                { "fetchMarginMode", false },
                { "fetchMarkOHLCV", false },
                { "fetchMyTrades", true },
                { "fetchOpenInterestHistory", false },
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
                { "fetchTradingFee", false },
                { "fetchTradingFees", true },
                { "reduceMargin", false },
                { "setLeverage", false },
                { "setMarginMode", false },
                { "setPositionMode", false },
            } },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/1294454/94507548-a83d6a80-0218-11eb-9998-28b9cec54165.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "public", "https://api.exchange.ripio.com/api" },
                    { "private", "https://api.exchange.ripio.com/api" },
                } },
                { "www", "https://exchange.ripio.com" },
                { "doc", new List<object>() {"https://exchange.ripio.com/en/api/"} },
                { "fees", "https://exchange.ripio.com/en/fee" },
            } },
            { "api", new Dictionary<string, object>() {
                { "public", new Dictionary<string, object>() {
                    { "get", new List<object>() {"rate/all/", "rate/{pair}/", "orderbook/{pair}/", "tradehistory/{pair}/", "pair/", "currency/", "orderbook/{pair}/depth/"} },
                } },
                { "private", new Dictionary<string, object>() {
                    { "get", new List<object>() {"balances/exchange_balances/", "order/{pair}/{order_id}/", "order/{pair}/", "trade/{pair}/"} },
                    { "post", new List<object>() {"order/{pair}/", "order/{pair}/{order_id}/cancel/"} },
                } },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "tierBased", true },
                    { "percentage", true },
                    { "taker", this.parseNumber("0.0") },
                    { "maker", this.parseNumber("0.0") },
                } },
            } },
            { "precisionMode", TICK_SIZE },
            { "requiredCredentials", new Dictionary<string, object>() {
                { "apiKey", true },
                { "secret", false },
            } },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {} },
                { "broad", new Dictionary<string, object>() {
                    { "Authentication credentials were not provided", typeof(AuthenticationError) },
                    { "Disabled pair", typeof(BadSymbol) },
                    { "Invalid order type", typeof(InvalidOrder) },
                    { "Your balance is not enough", typeof(InsufficientFunds) },
                    { "Order couldn\'t be created", typeof(ExchangeError) },
                    { "not found", typeof(OrderNotFound) },
                    { "Invalid pair", typeof(BadSymbol) },
                    { "amount must be a number", typeof(BadRequest) },
                    { "Total must be at least", typeof(InvalidOrder) },
                    { "Account not found", typeof(BadRequest) },
                    { "Wrong password provided", typeof(AuthenticationError) },
                    { "User tokens limit", typeof(DDoSProtection) },
                    { "Something unexpected ocurred", typeof(ExchangeError) },
                    { "account_balance", typeof(BadRequest) },
                } },
            } },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchMarkets
        * @description retrieves data on all markets for ripio
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetPair(parameters);
        //
        //     {
        //         "next":null,
        //         "previous":null,
        //         "results":[
        //             {
        //                 "base":"BTC",
        //                 "base_name":"Bitcoin",
        //                 "quote":"USDC",
        //                 "quote_name":"USD Coin",
        //                 "symbol":"BTC_USDC",
        //                 "fees":[
        //                     {
        //                         "traded_volume": 0.0,
        //                         "maker_fee": 0.0,
        //                         "taker_fee": 0.0,
        //                         "cancellation_fee": 0.0
        //                     }
        //                 ],
        //                 "country":"ZZ",
        //                 "enabled":true,
        //                 "priority":10,
        //                 "min_amount":"0.00001",
        //                 "price_tick":"0.000001",
        //                 "min_value":"10",
        //                 "limit_price_threshold":"25.00"
        //             },
        //         ]
        //     }
        //
        object result = new List<object>() {};
        object results = this.safeValue(response, "results", new List<object>() {});
        for (object i = 0; isLessThan(i, getArrayLength(results)); postFixIncrement(ref i))
        {
            object market = getValue(results, i);
            object baseId = this.safeString(market, "base");
            object quoteId = this.safeString(market, "quote");
            object id = this.safeString(market, "symbol");
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
            object fees = this.safeValue(market, "fees", new List<object>() {});
            object firstFee = this.safeValue(fees, 0, new Dictionary<string, object>() {});
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
                { "active", this.safeValue(market, "enabled", true) },
                { "contract", false },
                { "linear", null },
                { "inverse", null },
                { "taker", this.safeNumber(firstFee, "taker_fee", 0) },
                { "maker", this.safeNumber(firstFee, "maker_fee", 0) },
                { "contractSize", null },
                { "expiry", null },
                { "expiryDatetime", null },
                { "strike", null },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "amount", this.safeNumber(market, "min_amount") },
                    { "price", this.safeNumber(market, "price_tick") },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", this.safeNumber(market, "min_amount") },
                        { "max", null },
                    } },
                    { "price", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "cost", new Dictionary<string, object>() {
                        { "min", this.safeNumber(market, "min_value") },
                        { "max", null },
                    } },
                } },
                { "info", market },
            });
        }
        return result;
    }

    public async override Task<object> fetchCurrencies(object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchCurrencies
        * @description fetches all available currencies on an exchange
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} an associative dictionary of currencies
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetCurrency(parameters);
        //
        //     {
        //         "next":null,
        //         "previous":null,
        //         "results":[
        //             {
        //                 "name":"Argentine Peso",
        //                 "symbol":"$",
        //                 "currency":"ARS",
        //                 "country":"AR",
        //                 "decimal_places":"2",
        //                 "enabled":true
        //             },
        //             {
        //                 "name":"Bitcoin Cash",
        //                 "symbol":"BCH",
        //                 "currency":"BCH",
        //                 "country":"AR",
        //                 "decimal_places":"8",
        //                 "enabled":true
        //             },
        //             {
        //                 "name":"Bitcoin",
        //                 "symbol":"BTC",
        //                 "currency":"BTC",
        //                 "country":"AR",
        //                 "decimal_places":"8",
        //                 "enabled":true
        //             }
        //         ]
        //     }
        //
        object results = this.safeValue(response, "results", new List<object>() {});
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(results)); postFixIncrement(ref i))
        {
            object currency = getValue(results, i);
            object id = this.safeString(currency, "currency");
            object code = this.safeCurrencyCode(id);
            object name = this.safeString(currency, "name");
            object active = this.safeValue(currency, "enabled", true);
            ((Dictionary<string, object>)result)[(string)code] = new Dictionary<string, object>() {
                { "id", id },
                { "code", code },
                { "name", name },
                { "info", currency },
                { "active", active },
                { "deposit", null },
                { "withdraw", null },
                { "fee", null },
                { "precision", this.parseNumber(this.parsePrecision(this.safeString(currency, "decimal_places"))) },
                { "limits", new Dictionary<string, object>() {
                    { "amount", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "withdraw", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                } },
            };
        }
        return result;
    }

    public override object parseTicker(object ticker, object market = null)
    {
        //
        // fetchTicker, fetchTickers
        //
        //     {
        //         "pair":"BTC_USDC",
        //         "last_price":"10850.02",
        //         "low":"10720.03",
        //         "high":"10909.99",
        //         "variation":"1.21",
        //         "volume":"0.83868",
        //         "base":"BTC",
        //         "base_name":"Bitcoin",
        //         "quote":"USDC",
        //         "quote_name":"USD Coin",
        //         "bid":"10811.00",
        //         "ask":"10720.03",
        //         "avg":"10851.47",
        //         "ask_volume":"0.00140",
        //         "bid_volume":"0.00185",
        //         "created_at":"2020-09-28 21:44:51.228920+00:00"
        //     }
        //
        object timestamp = this.parse8601(this.safeString(ticker, "created_at"));
        object marketId = this.safeString(ticker, "pair");
        market = this.safeMarket(marketId, market, "_");
        object symbol = getValue(market, "symbol");
        object last = this.safeString(ticker, "last_price");
        object average = this.safeString(ticker, "avg");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", this.safeString(ticker, "high") },
            { "low", this.safeString(ticker, "low") },
            { "bid", this.safeString(ticker, "bid") },
            { "bidVolume", this.safeString(ticker, "bid_volume") },
            { "ask", this.safeString(ticker, "ask") },
            { "askVolume", this.safeString(ticker, "ask_volume") },
            { "vwap", null },
            { "open", null },
            { "close", last },
            { "last", last },
            { "previousClose", null },
            { "change", null },
            { "percentage", null },
            { "average", average },
            { "baseVolume", null },
            { "quoteVolume", null },
            { "info", ticker },
        }, market);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "pair", getValue(market, "id") },
        };
        object response = await this.publicGetRatePair(this.extend(request, parameters));
        //
        //     {
        //         "pair":"BTC_USDC",
        //         "last_price":"10850.02",
        //         "low":"10720.03",
        //         "high":"10909.99",
        //         "variation":"1.21",
        //         "volume":"0.83868",
        //         "base":"BTC",
        //         "base_name":"Bitcoin",
        //         "quote":"USDC",
        //         "quote_name":"USD Coin",
        //         "bid":"10811.00",
        //         "ask":"10720.03",
        //         "avg":"10851.47",
        //         "ask_volume":"0.00140",
        //         "bid_volume":"0.00185",
        //         "created_at":"2020-09-28 21:44:51.228920+00:00"
        //     }
        //
        return this.parseTicker(response, market);
    }

    public async override Task<object> fetchTickers(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchTickers
        * @description fetches price tickers for multiple markets, statistical calculations with the information calculated over the past 24 hours each market
        * @param {[string]|undefined} symbols unified symbols of the markets to fetch the ticker for, all market tickers are returned if not assigned
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        symbols = this.marketSymbols(symbols);
        object response = await this.publicGetRateAll(parameters);
        //
        //     [
        //         {
        //             "pair":"BTC_USDC",
        //             "last_price":"10850.02",
        //             "low":"10720.03",
        //             "high":"10909.99",
        //             "variation":"1.21",
        //             "volume":"0.83868",
        //             "base":"BTC",
        //             "base_name":"Bitcoin",
        //             "quote":"USDC",
        //             "quote_name":"USD Coin",
        //             "bid":"10811.00",
        //             "ask":"10720.03",
        //             "avg":"10851.47",
        //             "ask_volume":"0.00140",
        //             "bid_volume":"0.00185",
        //             "created_at":"2020-09-28 21:44:51.228920+00:00"
        //         }
        //     ]
        //
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object ticker = this.parseTicker(getValue(response, i));
            object symbol = getValue(ticker, "symbol");
            ((Dictionary<string, object>)result)[(string)symbol] = ticker;
        }
        return this.filterByArray(result, "symbol", symbols);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "pair", getValue(market, "id") },
        };
        object response = await this.publicGetOrderbookPair(this.extend(request, parameters));
        //
        //     {
        //         "buy":[
        //             {"amount":"0.00230","total":"24.95","price":"10850.02"},
        //             {"amount":"0.07920","total":"858.52","price":"10840.00"},
        //             {"amount":"0.00277","total":"30.00","price":"10833.03"},
        //         ],
        //         "sell":[
        //             {"amount":"0.03193","total":"348.16","price":"10904.00"},
        //             {"amount":"0.00210","total":"22.90","price":"10905.70"},
        //             {"amount":"0.00300","total":"32.72","price":"10907.98"},
        //         ],
        //         "updated_id":47225
        //     }
        //
        object orderbook = this.parseOrderBook(response, getValue(market, "symbol"), null, "buy", "sell", "price", "amount");
        ((Dictionary<string, object>)orderbook)["nonce"] = this.safeInteger(response, "updated_id");
        return orderbook;
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        //
        // fetchTrades (public)
        //
        //      {
        //          "created_at":1649899167,
        //          "amount":"0.00852",
        //          "price":"3106.000000",
        //          "side":"SELL",
        //          "pair":"ETH_USDC",
        //          "taker_fee":"0",
        //          "taker_side":"SELL",
        //          "maker_fee":"0"
        //      }
        //
        //
        // fetchMyTrades (private)
        //
        //     {
        //         "created_at":1601322501,
        //         "amount":"0.00276",
        //         "price":"10850.020000",
        //         "side":"SELL",
        //         "pair":"BTC_USDC",
        //         "taker_fee":"0",
        //         "taker_side":"SELL",
        //         "maker_fee":"0",
        //         "taker":2577953,
        //         "maker":2577937
        //     }
        //
        // createOrder fills
        //
        //     {
        //         "pair":"BTC_USDC",
        //         "exchanged":0.002,
        //         "match_price":10593.99,
        //         "maker_fee":0.0,
        //         "taker_fee":0.0,
        //         "timestamp":1601730306942
        //     }
        //
        object id = this.safeString(trade, "id");
        object timestamp = this.safeInteger(trade, "timestamp");
        timestamp = this.safeTimestamp(trade, "created_at", timestamp);
        object side = this.safeString(trade, "side");
        object takerSide = this.safeString(trade, "taker_side");
        object takerOrMaker = ((bool) isTrue((isEqual(takerSide, side)))) ? "taker" : "maker";
        if (isTrue(!isEqual(side, null)))
        {
            side = ((string)side).ToLower();
        }
        object priceString = this.safeString2(trade, "price", "match_price");
        object amountString = this.safeString2(trade, "amount", "exchanged");
        object marketId = this.safeString(trade, "pair");
        market = this.safeMarket(marketId, market);
        object feeCostString = this.safeString(trade, add(takerOrMaker, "_fee"));
        object orderId = this.safeString(trade, takerOrMaker);
        object fee = null;
        if (isTrue(!isEqual(feeCostString, null)))
        {
            fee = new Dictionary<string, object>() {
                { "cost", feeCostString },
                { "currency", ((bool) isTrue((isEqual(side, "buy")))) ? getValue(market, "base") : getValue(market, "quote") },
            };
        }
        return this.safeTrade(new Dictionary<string, object>() {
            { "id", id },
            { "order", orderId },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", getValue(market, "symbol") },
            { "type", null },
            { "side", side },
            { "price", priceString },
            { "amount", amountString },
            { "cost", null },
            { "takerOrMaker", takerOrMaker },
            { "fee", fee },
            { "info", trade },
        }, market);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/en/latest/manual.html?#public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "pair", getValue(market, "id") },
        };
        object response = await this.publicGetTradehistoryPair(this.extend(request, parameters));
        //
        //      [
        //          {
        //              "created_at":1649899167,
        //              "amount":"0.00852",
        //              "price":"3106.000000",
        //              "side":"SELL",
        //              "pair":"ETH_USDC",
        //              "taker_fee":"0",
        //              "taker_side":"SELL",
        //              "maker_fee":"0"
        //          }
        //      ]
        //
        return this.parseTrades(response, market, since, limit);
    }

    public async override Task<object> fetchTradingFees(object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchTradingFees
        * @description fetch the trading fees for multiple markets
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} a dictionary of [fee structures]{@link https://docs.ccxt.com/#/?id=fee-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.publicGetPair(parameters);
        //
        //     {
        //         next: null,
        //         previous: null,
        //         results: [
        //             {
        //                 base: 'BTC',
        //                 base_name: 'Bitcoin',
        //                 quote: 'USDC',
        //                 quote_name: 'USD Coin',
        //                 symbol: 'BTC_USDC',
        //                 fees: [
        //                     {
        //                         traded_volume: '0.0',
        //                         maker_fee: '0.0',
        //                         taker_fee: '0.0',
        //                         cancellation_fee: '0.0'
        //                     }
        //                 ],
        //                 country: 'ZZ',
        //                 enabled: true,
        //                 priority: '10',
        //                 min_amount: '0.0000100000',
        //                 price_tick: '0.000001',
        //                 min_value: '10',
        //                 limit_price_threshold: '25.00'
        //             },
        //         ]
        //     }
        //
        object results = this.safeValue(response, "results", new List<object>() {});
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(results)); postFixIncrement(ref i))
        {
            object pair = getValue(results, i);
            object marketId = this.safeString(pair, "symbol");
            object symbol = this.safeSymbol(marketId, null, "_");
            object fees = this.safeValue(pair, "fees", new List<object>() {});
            object fee = this.safeValue(fees, 0, new Dictionary<string, object>() {});
            ((Dictionary<string, object>)result)[(string)symbol] = new Dictionary<string, object>() {
                { "info", pair },
                { "symbol", symbol },
                { "maker", this.safeNumber(fee, "maker_fee") },
                { "taker", this.safeNumber(fee, "taker_fee") },
                { "tierBased", false },
            };
        }
        return result;
    }

    public virtual object parseBalance(object response)
    {
        object result = new Dictionary<string, object>() {
            { "info", response },
        };
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object balance = getValue(response, i);
            object currencyId = this.safeString(balance, "symbol");
            object code = this.safeCurrencyCode(currencyId);
            object account = this.account();
            ((Dictionary<string, object>)account)["free"] = this.safeString(balance, "available");
            ((Dictionary<string, object>)account)["used"] = this.safeString(balance, "locked");
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.privateGetBalancesExchangeBalances(parameters);
        //
        //     [
        //         {
        //             "id":603794,
        //             "currency":"USD Coin",
        //             "symbol":"USDC",
        //             "available":"0",
        //             "locked":"0",
        //             "code":"exchange",
        //             "balance_type":"crypto"
        //         },
        //     ]
        //
        return this.parseBalance(response);
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object uppercaseType = ((string)type).ToUpper();
        object uppercaseSide = ((string)side).ToUpper();
        object request = new Dictionary<string, object>() {
            { "pair", getValue(market, "id") },
            { "order_type", uppercaseType },
            { "side", uppercaseSide },
            { "amount", this.amountToPrecision(symbol, amount) },
        };
        if (isTrue(isEqual(uppercaseType, "LIMIT")))
        {
            ((Dictionary<string, object>)request)["limit_price"] = this.priceToPrecision(symbol, price);
        }
        object response = await this.privatePostOrderPair(this.extend(request, parameters));
        //
        //     {
        //         "order_id": "160f523c-f6ef-4cd1-a7c9-1a8ede1468d8",
        //         "pair": "BTC_ARS",
        //         "side": "BUY",
        //         "amount": "0.00400",
        //         "notional": null,
        //         "fill_or_kill": false,
        //         "all_or_none": false,
        //         "order_type": "LIMIT",
        //         "status": "OPEN",
        //         "created_at": 1578413945,
        //         "filled": "0.00000",
        //         "limit_price": "10.00",
        //         "stop_price": null,
        //         "distance": null
        //     }
        //
        // createOrder market type
        //
        //     {
        //         "order_id":"d6b60c01-8624-44f2-9e6c-9e8cd677ea5c",
        //         "pair":"BTC_USDC",
        //         "side":"BUY",
        //         "amount":"0.00200",
        //         "notional":"50",
        //         "fill_or_kill":false,
        //         "all_or_none":false,
        //         "order_type":"MARKET",
        //         "status":"OPEN",
        //         "created_at":1601730306,
        //         "filled":"0.00000",
        //         "fill_price":10593.99,
        //         "fee":0.0,
        //         "fills":[
        //             {
        //                 "pair":"BTC_USDC",
        //                 "exchanged":0.002,
        //                 "match_price":10593.99,
        //                 "maker_fee":0.0,
        //                 "taker_fee":0.0,
        //                 "timestamp":1601730306942
        //             }
        //         ],
        //         "filled_at":"2020-10-03T13:05:06.942186Z",
        //         "limit_price":"0.000000",
        //         "stop_price":null,
        //         "distance":null
        //     }
        //
        return this.parseOrder(response, market);
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " cancelOrder() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "pair", getValue(market, "id") },
            { "order_id", id },
        };
        object response = await this.privatePostOrderPairOrderIdCancel(this.extend(request, parameters));
        //
        //     {
        //         "order_id": "286e560e-b8a2-464b-8b84-15a7e2a67eab",
        //         "pair": "BTC_ARS",
        //         "side": "SELL",
        //         "amount": "0.00100",
        //         "notional": null,
        //         "fill_or_kill": false,
        //         "all_or_none": false,
        //         "order_type": "LIMIT",
        //         "status": "CANC",
        //         "created_at": 1575472707,
        //         "filled": "0.00000",
        //         "limit_price": "681000.00",
        //         "stop_price": null,
        //         "distance": null
        //     }
        //
        return this.parseOrder(response, market);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchOrder() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "pair", getValue(market, "id") },
            { "order_id", id },
        };
        object response = await this.privateGetOrderPairOrderId(this.extend(request, parameters));
        //
        //     {
        //         "order_id": "0b4ff48e-cfd6-42db-8d8c-3b536da447af",
        //         "pair": "BTC_ARS",
        //         "side": "BUY",
        //         "amount": "0.00100",
        //         "notional": null,
        //         "fill_or_kill": false,
        //         "all_or_none": false,
        //         "order_type": "LIMIT",
        //         "status": "OPEN",
        //         "created_at": 1575472944,
        //         "filled": "0.00000",
        //         "limit_price": "661000.00",
        //         "stop_price": null,
        //         "distance": null
        //     }
        //
        return this.parseOrder(response, market);
    }

    public async override Task<object> fetchOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchOrders
        * @description fetches information on multiple orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the ripio api endpoint
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
            { "pair", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["offset"] = limit;
        }
        object response = await this.privateGetOrderPair(this.extend(request, parameters));
        //
        //     {
        //         "next": "https://api.exchange.ripio.com/api/v1/order/BTC_ARS/?limit=20&offset=20&page=1&page_size=25&status=OPEN%2CPART",
        //         "previous": null,
        //         "results": {
        //             "data": [
        //                 {
        //                     "order_id": "ca74280b-6966-4b73-a720-68709078922b",
        //                     "pair": "BTC_ARS",
        //                     "side": "SELL",
        //                     "amount": "0.00100",
        //                     "notional": null,
        //                     "fill_or_kill": false,
        //                     "all_or_none": false,
        //                     "order_type": "LIMIT",
        //                     "status": "OPEN",
        //                     "created_at": 1578340134,
        //                     "filled": "0.00000",
        //                     "limit_price": "665000.00",
        //                     "stop_price": null,
        //                     "distance": null
        //                 },
        //             ]
        //         }
        //     }
        //
        object results = this.safeValue(response, "results", new Dictionary<string, object>() {});
        object data = this.safeValue(results, "data", new List<object>() {});
        return this.parseOrders(data, market, since, limit);
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object request = new Dictionary<string, object>() {
            { "status", "OPEN,PART" },
        };
        return await this.fetchOrders(symbol, since, limit, this.extend(request, parameters));
    }

    public async override Task<object> fetchClosedOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchClosedOrders
        * @description fetches information on multiple closed orders made by the user
        * @param {string} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object request = new Dictionary<string, object>() {
            { "status", "CLOS,CANC,COMP" },
        };
        return await this.fetchOrders(symbol, since, limit, this.extend(request, parameters));
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "OPEN", "open" },
            { "PART", "open" },
            { "CLOS", "canceled" },
            { "CANC", "canceled" },
            { "COMP", "closed" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object parseOrder(object order, object market = null)
    {
        //
        // createOrder, cancelOrder, fetchOpenOrders, fetchClosedOrders, fetchOrders, fetchOrder
        //
        //     {
        //         "order_id": "286e560e-b8a2-464b-8b84-15a7e2a67eab",
        //         "pair": "BTC_ARS",
        //         "side": "SELL",
        //         "amount": "0.00100",
        //         "notional": null,
        //         "fill_or_kill": false,
        //         "all_or_none": false,
        //         "order_type": "LIMIT",
        //         "status": "CANC",
        //         "created_at": 1575472707,
        //         "filled": "0.00000",
        //         "limit_price": "681000.00",
        //         "stop_price": null,
        //         "distance": null
        //     }
        //
        //     {
        //         "order_id": "d6b60c01-8624-44f2-9e6c-9e8cd677ea5c",
        //         "pair": "BTC_USDC",
        //         "side": "BUY",
        //         "amount": "0.00200",
        //         "notional": "50",
        //         "fill_or_kill": false,
        //         "all_or_none": false,
        //         "order_type": "MARKET",
        //         "status": "OPEN",
        //         "created_at": 1601730306,
        //         "filled": "0.00000",
        //         "fill_price": 10593.99,
        //         "fee": 0.0,
        //         "fills": [
        //             {
        //                 "pair": "BTC_USDC",
        //                 "exchanged": 0.002,
        //                 "match_price": 10593.99,
        //                 "maker_fee": 0.0,
        //                 "taker_fee": 0.0,
        //                 "timestamp": 1601730306942
        //             }
        //         ],
        //         "filled_at": "2020-10-03T13:05:06.942186Z",
        //         "limit_price": "0.000000",
        //         "stop_price": null,
        //         "distance": null
        //     }
        //
        object id = this.safeString(order, "order_id");
        object amount = this.safeString(order, "amount");
        object cost = this.safeString(order, "notional");
        object type = this.safeStringLower(order, "order_type");
        object priceField = ((bool) isTrue((isEqual(type, "market")))) ? "fill_price" : "limit_price";
        object price = this.safeString(order, priceField);
        object side = this.safeStringLower(order, "side");
        object status = this.parseOrderStatus(this.safeString(order, "status"));
        object timestamp = this.safeTimestamp(order, "created_at");
        object average = this.safeString(order, "fill_price");
        object filled = this.safeString(order, "filled");
        object fills = this.safeValue(order, "fills");
        object marketId = this.safeString(order, "pair");
        return this.safeOrder(new Dictionary<string, object>() {
            { "info", order },
            { "id", id },
            { "clientOrderId", null },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "lastTradeTimestamp", null },
            { "symbol", this.safeSymbol(marketId, market, "_") },
            { "type", type },
            { "timeInForce", null },
            { "postOnly", null },
            { "side", side },
            { "price", price },
            { "stopPrice", this.safeString(order, "stop_price") },
            { "triggerPrice", this.safeString(order, "stop_price") },
            { "amount", amount },
            { "cost", cost },
            { "average", average },
            { "filled", filled },
            { "remaining", null },
            { "status", status },
            { "fee", null },
            { "trades", fills },
        }, market);
    }

    public async override Task<object> fetchMyTrades(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name ripio#fetchMyTrades
        * @description fetch all trades made by the user
        * @param {string} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch trades for
        * @param {int|undefined} limit the maximum number of trades structures to retrieve
        * @param {object} params extra parameters specific to the ripio api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchMyTrades() requires a symbol argument")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "pair", getValue(market, "id") },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit;
        }
        object response = await this.privateGetTradePair(this.extend(request, parameters));
        //
        //     {
        //         "next": "https://api.exchange.ripio.com/api/v1/trade/<pair>/?limit=20&offset=20",
        //         "previous": null,
        //         "results": {
        //             "data": [
        //                 {
        //                     "created_at": 1578414028,
        //                     "amount": "0.00100",
        //                     "price": "665000.00",
        //                     "side": "BUY",
        //                     "taker_fee": "0",
        //                     "taker_side": "BUY",
        //                     "match_price": "66500000",
        //                     "maker_fee": "0",
        //                     "taker": 4892,
        //                     "maker": 4889
        //                 },
        //             ]
        //         }
        //     }
        //
        object results = this.safeValue(response, "results", new Dictionary<string, object>() {});
        object data = this.safeValue(results, "data", new List<object>() {});
        return this.parseTrades(data, market, since, limit);
    }

    public override object sign(object path, object api = null, object method = null, object parameters = null, object headers = null, object body = null)
    {
        api ??= "public";
        method ??= "GET";
        parameters ??= new Dictionary<string, object>();
        object request = add(add(add("/", this.version), "/"), this.implodeParams(path, parameters));
        object url = add(getValue(getValue(this.urls, "api"), api), request);
        object query = this.omit(parameters, this.extractParams(path));
        if (isTrue(isEqual(api, "public")))
        {
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
            {
                url = add(url, add("?", this.urlencode(query)));
            }
        } else if (isTrue(isEqual(api, "private")))
        {
            this.checkRequiredCredentials();
            if (isTrue(isEqual(method, "POST")))
            {
                body = this.json(query);
            } else
            {
                if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
                {
                    url = add(url, add("?", this.urlencode(query)));
                }
            }
            headers = new Dictionary<string, object>() {
                { "Content-Type", "application/json" },
                { "Authorization", add("Bearer ", this.apiKey) },
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
        if (isTrue(isEqual(response, null)))
        {
            return null;
        }
        //
        //      {"detail":"Authentication credentials were not provided."}
        //      {"status_code":400,"errors":{"pair":["Invalid pair FOOBAR"]},"message":"An error has occurred, please check the form."}
        //      {"status_code":400,"errors":{"order_type":["Invalid order type. Valid options: ['MARKET', 'LIMIT']"]},"message":"An error has occurred, please check the form."}
        //      {"status_code":400,"errors":{"non_field_errors":"Something unexpected ocurred!"},"message":"Seems like an unexpected error occurred. Please try again later or write us to support@ripio.com if the problem persists."}
        //      {"status_code":400,"errors":{"pair":["Invalid/Disabled pair BTC_ARS"]},"message":"An error has occurred, please check the form."}
        //
        object detail = this.safeString(response, "detail");
        if (isTrue(!isEqual(detail, null)))
        {
            object feedback = add(add(this.id, " "), body);
            // this.throwExactlyMatchedException (this.exceptions['exact'], message, feedback);
            this.throwBroadlyMatchedException(getValue(this.exceptions, "broad"), detail, feedback);
        }
        object errors = this.safeValue(response, "errors");
        if (isTrue(!isEqual(errors, null)))
        {
            object feedback = add(add(this.id, " "), body);
            object keys = new List<string>(((Dictionary<string,object>)errors).Keys);
            for (object i = 0; isLessThan(i, getArrayLength(keys)); postFixIncrement(ref i))
            {
                object key = getValue(keys, i);
                object error = this.safeValue(errors, key, new List<object>() {});
                object message = this.safeString(error, 0);
                // this.throwExactlyMatchedException (this.exceptions['exact'], message, feedback);
                this.throwBroadlyMatchedException(getValue(this.exceptions, "broad"), message, feedback);
            }
            throw new ExchangeError ((string)feedback) ;
        }
        return null;
    }
}
