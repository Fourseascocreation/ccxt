using Main;
namespace Main;

partial class probit : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "probit" },
            { "name", "ProBit" },
            { "countries", new List<object>() {"SC", "KR"} },
            { "rateLimit", 50 },
            { "has", new Dictionary<string, object>() {
                { "CORS", true },
                { "spot", true },
                { "margin", false },
                { "swap", false },
                { "future", false },
                { "option", false },
                { "addMargin", false },
                { "cancelOrder", true },
                { "createMarketOrder", true },
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
                { "fetchClosedOrders", true },
                { "fetchCurrencies", true },
                { "fetchDepositAddress", true },
                { "fetchDepositAddresses", true },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", false },
                { "fetchFundingRateHistory", false },
                { "fetchFundingRates", false },
                { "fetchIndexOHLCV", false },
                { "fetchLeverage", false },
                { "fetchLeverageTiers", false },
                { "fetchMarginMode", false },
                { "fetchMarkets", true },
                { "fetchMarkOHLCV", false },
                { "fetchMyTrades", true },
                { "fetchOHLCV", true },
                { "fetchOpenInterestHistory", false },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchPosition", false },
                { "fetchPositionMode", false },
                { "fetchPositions", false },
                { "fetchPositionsRisk", false },
                { "fetchPremiumIndexOHLCV", false },
                { "fetchTicker", true },
                { "fetchTickers", true },
                { "fetchTime", true },
                { "fetchTrades", true },
                { "fetchTradingFee", false },
                { "fetchTradingFees", false },
                { "fetchTransfer", false },
                { "fetchTransfers", false },
                { "fetchWithdrawal", false },
                { "fetchWithdrawals", false },
                { "reduceMargin", false },
                { "setLeverage", false },
                { "setMarginMode", false },
                { "setPositionMode", false },
                { "signIn", true },
                { "transfer", false },
                { "withdraw", true },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "1m" },
                { "3m", "3m" },
                { "5m", "5m" },
                { "10m", "10m" },
                { "15m", "15m" },
                { "30m", "30m" },
                { "1h", "1h" },
                { "4h", "4h" },
                { "6h", "6h" },
                { "12h", "12h" },
                { "1d", "1D" },
                { "1w", "1W" },
                { "1M", "1M" },
            } },
            { "version", "v1" },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/51840849/79268032-c4379480-7ea2-11ea-80b3-dd96bb29fd0d.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "accounts", "https://accounts.probit.com" },
                    { "public", "https://api.probit.com/api/exchange" },
                    { "private", "https://api.probit.com/api/exchange" },
                } },
                { "www", "https://www.probit.com" },
                { "doc", new List<object>() {"https://docs-en.probit.com", "https://docs-ko.probit.com"} },
                { "fees", "https://support.probit.com/hc/en-us/articles/360020968611-Trading-Fees" },
                { "referral", "https://www.probit.com/r/34608773" },
            } },
            { "api", new Dictionary<string, object>() {
                { "public", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "market", 1 },
                        { "currency", 1 },
                        { "currency_with_platform", 1 },
                        { "time", 1 },
                        { "ticker", 1 },
                        { "order_book", 1 },
                        { "trade", 1 },
                        { "candle", 1 },
                    } },
                } },
                { "private", new Dictionary<string, object>() {
                    { "post", new Dictionary<string, object>() {
                        { "new_order", 2 },
                        { "cancel_order", 1 },
                        { "withdrawal", 2 },
                    } },
                    { "get", new Dictionary<string, object>() {
                        { "balance", 1 },
                        { "order", 1 },
                        { "open_order", 1 },
                        { "order_history", 1 },
                        { "trade_history", 1 },
                        { "deposit_address", 1 },
                    } },
                } },
                { "accounts", new Dictionary<string, object>() {
                    { "post", new Dictionary<string, object>() {
                        { "token", 1 },
                    } },
                } },
            } },
            { "fees", new Dictionary<string, object>() {
                { "trading", new Dictionary<string, object>() {
                    { "tierBased", false },
                    { "percentage", true },
                    { "maker", this.parseNumber("0.002") },
                    { "taker", this.parseNumber("0.002") },
                } },
            } },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {
                    { "UNAUTHORIZED", typeof(AuthenticationError) },
                    { "INVALID_ARGUMENT", typeof(BadRequest) },
                    { "TRADING_UNAVAILABLE", typeof(ExchangeNotAvailable) },
                    { "NOT_ENOUGH_BALANCE", typeof(InsufficientFunds) },
                    { "NOT_ALLOWED_COMBINATION", typeof(BadRequest) },
                    { "INVALID_ORDER", typeof(InvalidOrder) },
                    { "RATE_LIMIT_EXCEEDED", typeof(RateLimitExceeded) },
                    { "MARKET_UNAVAILABLE", typeof(ExchangeNotAvailable) },
                    { "INVALID_MARKET", typeof(BadSymbol) },
                    { "MARKET_CLOSED", typeof(BadSymbol) },
                    { "MARKET_NOT_FOUND", typeof(BadSymbol) },
                    { "INVALID_CURRENCY", typeof(BadRequest) },
                    { "TOO_MANY_OPEN_ORDERS", typeof(DDoSProtection) },
                    { "DUPLICATE_ADDRESS", typeof(InvalidAddress) },
                    { "invalid_grant", typeof(AuthenticationError) },
                } },
            } },
            { "requiredCredentials", new Dictionary<string, object>() {
                { "apiKey", true },
                { "secret", true },
            } },
            { "precisionMode", TICK_SIZE },
            { "options", new Dictionary<string, object>() {
                { "createMarketBuyOrderRequiresPrice", true },
                { "timeInForce", new Dictionary<string, object>() {
                    { "limit", "gtc" },
                    { "market", "ioc" },
                } },
                { "networks", new Dictionary<string, object>() {
                    { "BEP20", "BSC" },
                    { "ERC20", "ETH" },
                    { "TRC20", "TRON" },
                } },
                { "networksById", new Dictionary<string, object>() {
                    { "BSC", "BEP20" },
                    { "ETH", "ERC20" },
                    { "TRON", "TRC20" },
                } },
            } },
            { "commonCurrencies", new Dictionary<string, object>() {
                { "AUTO", "Cube" },
                { "AZU", "Azultec" },
                { "BCC", "BCC" },
                { "BDP", "BidiPass" },
                { "BIRD", "Birdchain" },
                { "BTCBEAR", "BEAR" },
                { "BTCBULL", "BULL" },
                { "CBC", "CryptoBharatCoin" },
                { "CHE", "Chellit" },
                { "CLR", "Color Platform" },
                { "CTK", "Cryptyk" },
                { "CTT", "Castweet" },
                { "DIP", "Dipper" },
                { "DKT", "DAKOTA" },
                { "EGC", "EcoG9coin" },
                { "EPS", "Epanus" },
                { "FX", "Fanzy" },
                { "GDT", "Gorilla Diamond" },
                { "GM", "GM Holding" },
                { "GOGOL", "GOL" },
                { "GOL", "Goldofir" },
                { "GRB", "Global Reward Bank" },
                { "HBC", "Hybrid Bank Cash" },
                { "HUSL", "The Hustle App" },
                { "LAND", "Landbox" },
                { "LBK", "Legal Block" },
                { "ORC", "Oracle System" },
                { "PXP", "PIXSHOP COIN" },
                { "PYE", "CreamPYE" },
                { "ROOK", "Reckoon" },
                { "SOC", "Soda Coin" },
                { "SST", "SocialSwap" },
                { "TCT", "Top Coin Token" },
                { "TOR", "Torex" },
                { "TPAY", "Tetra Pay" },
                { "UNI", "UNICORN Token" },
                { "UNISWAP", "UNI" },
            } },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchMarkets
        * @description retrieves data on all markets for probit
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetMarket(parameters);
        //
        //     {
        //         "data":[
        //             {
        //                 "id":"MONA-USDT",
        //                 "base_currency_id":"MONA",
        //                 "quote_currency_id":"USDT",
        //                 "min_price":"0.001",
        //                 "max_price":"9999999999999999",
        //                 "price_increment":"0.001",
        //                 "min_quantity":"0.0001",
        //                 "max_quantity":"9999999999999999",
        //                 "quantity_precision":4,
        //                 "min_cost":"1",
        //                 "max_cost":"9999999999999999",
        //                 "cost_precision":8,
        //                 "taker_fee_rate":"0.2",
        //                 "maker_fee_rate":"0.2",
        //                 "show_in_ui":true,
        //                 "closed":false
        //             },
        //         ]
        //     }
        //
        object markets = this.safeValue(response, "data", new List<object>() {});
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(markets)); postFixIncrement(ref i))
        {
            object market = getValue(markets, i);
            object id = this.safeString(market, "id");
            object baseId = this.safeString(market, "base_currency_id");
            object quoteId = this.safeString(market, "quote_currency_id");
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
            object closed = this.safeValue(market, "closed", false);
            object takerFeeRate = this.safeString(market, "taker_fee_rate");
            object taker = Precise.stringDiv(takerFeeRate, "100");
            object makerFeeRate = this.safeString(market, "maker_fee_rate");
            object maker = Precise.stringDiv(makerFeeRate, "100");
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
                { "active", !isTrue(closed) },
                { "contract", false },
                { "linear", null },
                { "inverse", null },
                { "taker", this.parseNumber(taker) },
                { "maker", this.parseNumber(maker) },
                { "contractSize", null },
                { "expiry", null },
                { "expiryDatetime", null },
                { "strike", null },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "amount", this.parseNumber(this.parsePrecision(this.safeString(market, "quantity_precision"))) },
                    { "price", this.safeNumber(market, "price_increment") },
                    { "cost", this.parseNumber(this.parsePrecision(this.safeString(market, "cost_precision"))) },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", this.safeNumber(market, "min_quantity") },
                        { "max", this.safeNumber(market, "max_quantity") },
                    } },
                    { "price", new Dictionary<string, object>() {
                        { "min", this.safeNumber(market, "min_price") },
                        { "max", this.safeNumber(market, "max_price") },
                    } },
                    { "cost", new Dictionary<string, object>() {
                        { "min", this.safeNumber(market, "min_cost") },
                        { "max", this.safeNumber(market, "max_cost") },
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
        * @name probit#fetchCurrencies
        * @description fetches all available currencies on an exchange
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} an associative dictionary of currencies
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetCurrencyWithPlatform(parameters);
        //
        //     {
        //         "data":[
        //             {
        //                 "id":"USDT",
        //                 "display_name":{"ko-kr":"테더","en-us":"Tether"},
        //                 "show_in_ui":true,
        //                 "platform":[
        //                     {
        //                         "id":"ETH",
        //                         "priority":1,
        //                         "deposit":true,
        //                         "withdrawal":true,
        //                         "currency_id":"USDT",
        //                         "precision":6,
        //                         "min_confirmation_count":15,
        //                         "require_destination_tag":false,
        //                         "display_name":{"name":{"ko-kr":"ERC-20","en-us":"ERC-20"}},
        //                         "min_deposit_amount":"0",
        //                         "min_withdrawal_amount":"1",
        //                         "withdrawal_fee":[
        //                             {"amount":"0.01","priority":2,"currency_id":"ETH"},
        //                             {"amount":"1.5","priority":1,"currency_id":"USDT"},
        //                         ],
        //                         "deposit_fee":{},
        //                         "suspended_reason":"",
        //                         "deposit_suspended":false,
        //                         "withdrawal_suspended":false
        //                     },
        //                     {
        //                         "id":"OMNI",
        //                         "priority":2,
        //                         "deposit":true,
        //                         "withdrawal":true,
        //                         "currency_id":"USDT",
        //                         "precision":6,
        //                         "min_confirmation_count":3,
        //                         "require_destination_tag":false,
        //                         "display_name":{"name":{"ko-kr":"OMNI","en-us":"OMNI"}},
        //                         "min_deposit_amount":"0",
        //                         "min_withdrawal_amount":"5",
        //                         "withdrawal_fee":[{"amount":"5","priority":1,"currency_id":"USDT"}],
        //                         "deposit_fee":{},
        //                         "suspended_reason":"wallet_maintenance",
        //                         "deposit_suspended":false,
        //                         "withdrawal_suspended":false
        //                     }
        //                 ],
        //                 "stakeable":false,
        //                 "unstakeable":false,
        //                 "auto_stake":false,
        //                 "auto_stake_amount":"0"
        //             }
        //         ]
        //     }
        //
        object currencies = this.safeValue(response, "data", new List<object>() {});
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(currencies)); postFixIncrement(ref i))
        {
            object currency = getValue(currencies, i);
            object id = this.safeString(currency, "id");
            object code = this.safeCurrencyCode(id);
            object displayName = this.safeValue(currency, "display_name");
            object name = this.safeString(displayName, "en-us");
            object platforms = this.safeValue(currency, "platform", new List<object>() {});
            object platformsByPriority = this.sortBy(platforms, "priority");
            object platform = this.safeValue(platformsByPriority, 0, new Dictionary<string, object>() {});
            object depositSuspended = this.safeValue(platform, "deposit_suspended");
            object withdrawalSuspended = this.safeValue(platform, "withdrawal_suspended");
            object deposit = !isTrue(depositSuspended);
            object withdraw = !isTrue(withdrawalSuspended);
            object active = isTrue(deposit) && isTrue(withdraw);
            object withdrawalFees = this.safeValue(platform, "withdrawal_fee", new Dictionary<string, object>() {});
            object fees = new List<object>() {};
            // sometimes the withdrawal fee is an empty object
            // [ { 'amount': '0.015', 'priority': 1, 'currency_id': 'ETH' }, {} ]
            for (object j = 0; isLessThan(j, getArrayLength(withdrawalFees)); postFixIncrement(ref j))
            {
                object withdrawalFeeInner = getValue(withdrawalFees, j);
                object amount = this.safeNumber(withdrawalFeeInner, "amount");
                object priority = this.safeInteger(withdrawalFeeInner, "priority");
                if (isTrue(isTrue((!isEqual(amount, null))) && isTrue((!isEqual(priority, null)))))
                {
                    ((List<object>)fees).Add(withdrawalFeeInner);
                }
            }
            object withdrawalFeesByPriority = this.sortBy(fees, "priority");
            object withdrawalFee = this.safeValue(withdrawalFeesByPriority, 0, new Dictionary<string, object>() {});
            object fee = this.safeNumber(withdrawalFee, "amount");
            ((Dictionary<string, object>)result)[(string)code] = new Dictionary<string, object>() {
                { "id", id },
                { "code", code },
                { "info", currency },
                { "name", name },
                { "active", active },
                { "deposit", deposit },
                { "withdraw", withdraw },
                { "fee", fee },
                { "precision", this.parseNumber(this.parsePrecision(this.safeString(platform, "precision"))) },
                { "limits", new Dictionary<string, object>() {
                    { "amount", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", null },
                    } },
                    { "deposit", new Dictionary<string, object>() {
                        { "min", this.safeNumber(platform, "min_deposit_amount") },
                        { "max", null },
                    } },
                    { "withdraw", new Dictionary<string, object>() {
                        { "min", this.safeNumber(platform, "min_withdrawal_amount") },
                        { "max", null },
                    } },
                } },
            };
        }
        return result;
    }

    public virtual object parseBalance(object response)
    {
        object result = new Dictionary<string, object>() {
            { "info", response },
            { "timestamp", null },
            { "datetime", null },
        };
        object data = this.safeValue(response, "data", new List<object>() {});
        for (object i = 0; isLessThan(i, getArrayLength(data)); postFixIncrement(ref i))
        {
            object balance = getValue(data, i);
            object currencyId = this.safeString(balance, "currency_id");
            object code = this.safeCurrencyCode(currencyId);
            object account = this.account();
            ((Dictionary<string, object>)account)["total"] = this.safeString(balance, "total");
            ((Dictionary<string, object>)account)["free"] = this.safeString(balance, "available");
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.privateGetBalance(parameters);
        //
        //     {
        //         data: [
        //             {
        //                 "currency_id":"XRP",
        //                 "total":"100",
        //                 "available":"0",
        //             }
        //         ]
        //     }
        //
        return this.parseBalance(response);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "market_id", getValue(market, "id") },
        };
        object response = await this.publicGetOrderBook(this.extend(request, parameters));
        //
        //     {
        //         data: [
        //             { side: 'buy', price: '0.000031', quantity: '10' },
        //             { side: 'buy', price: '0.00356007', quantity: '4.92156877' },
        //             { side: 'sell', price: '0.1857', quantity: '0.17' },
        //         ]
        //     }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        object dataBySide = this.groupBy(data, "side");
        return this.parseOrderBook(dataBySide, getValue(market, "symbol"), null, "buy", "sell", "price", "quantity");
    }

    public async override Task<object> fetchTickers(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchTickers
        * @description fetches price tickers for multiple markets, statistical calculations with the information calculated over the past 24 hours each market
        * @param {[string]|undefined} symbols unified symbols of the markets to fetch the ticker for, all market tickers are returned if not assigned
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        if (isTrue(!isEqual(symbols, null)))
        {
            object marketIds = this.marketIds(symbols);
            ((Dictionary<string, object>)request)["market_ids"] = String.Join(",", marketIds);
        }
        object response = await this.publicGetTicker(this.extend(request, parameters));
        //
        //     {
        //         "data":[
        //             {
        //                 "last":"0.022902",
        //                 "low":"0.021693",
        //                 "high":"0.024093",
        //                 "change":"-0.000047",
        //                 "base_volume":"15681.986",
        //                 "quote_volume":"360.514403624",
        //                 "market_id":"ETH-BTC",
        //                 "time":"2020-04-12T18:43:38.000Z"
        //             }
        //         ]
        //     }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parseTickers(data, symbols);
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "market_ids", getValue(market, "id") },
        };
        object response = await this.publicGetTicker(this.extend(request, parameters));
        //
        //     {
        //         "data":[
        //             {
        //                 "last":"0.022902",
        //                 "low":"0.021693",
        //                 "high":"0.024093",
        //                 "change":"-0.000047",
        //                 "base_volume":"15681.986",
        //                 "quote_volume":"360.514403624",
        //                 "market_id":"ETH-BTC",
        //                 "time":"2020-04-12T18:43:38.000Z"
        //             }
        //         ]
        //     }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        object ticker = this.safeValue(data, 0);
        if (isTrue(isEqual(ticker, null)))
        {
            throw new BadResponse ((string)add(this.id, " fetchTicker() returned an empty response")) ;
        }
        return this.parseTicker(ticker, market);
    }

    public override object parseTicker(object ticker, object market = null)
    {
        //
        //     {
        //         "last":"0.022902",
        //         "low":"0.021693",
        //         "high":"0.024093",
        //         "change":"-0.000047",
        //         "base_volume":"15681.986",
        //         "quote_volume":"360.514403624",
        //         "market_id":"ETH-BTC",
        //         "time":"2020-04-12T18:43:38.000Z"
        //     }
        //
        object timestamp = this.parse8601(this.safeString(ticker, "time"));
        object marketId = this.safeString(ticker, "market_id");
        object symbol = this.safeSymbol(marketId, market, "-");
        object close = this.safeString(ticker, "last");
        object change = this.safeString(ticker, "change");
        object baseVolume = this.safeString(ticker, "base_volume");
        object quoteVolume = this.safeString(ticker, "quote_volume");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", this.safeString(ticker, "high") },
            { "low", this.safeString(ticker, "low") },
            { "bid", null },
            { "bidVolume", null },
            { "ask", null },
            { "askVolume", null },
            { "vwap", null },
            { "open", null },
            { "close", close },
            { "last", close },
            { "previousClose", null },
            { "change", change },
            { "percentage", null },
            { "average", null },
            { "baseVolume", baseVolume },
            { "quoteVolume", quoteVolume },
            { "info", ticker },
        }, market);
    }

    public async override Task<object> fetchMyTrades(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchMyTrades
        * @description fetch all trades made by the user
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch trades for
        * @param {int|undefined} limit the maximum number of trades structures to retrieve
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = null;
        object request = new Dictionary<string, object>() {
            { "limit", 100 },
            { "start_time", this.iso8601(0) },
            { "end_time", this.iso8601(this.milliseconds()) },
        };
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["market_id"] = getValue(market, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["start_time"] = this.iso8601(since);
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit;
        }
        object response = await this.privateGetTradeHistory(this.extend(request, parameters));
        //
        //     {
        //         data: [
        //             {
        //                 "id":"BTC-USDT:183566",
        //                 "order_id":"17209376",
        //                 "side":"sell",
        //                 "fee_amount":"0.657396569175",
        //                 "fee_currency_id":"USDT",
        //                 "status":"settled",
        //                 "price":"6573.96569175",
        //                 "quantity":"0.1",
        //                 "cost":"657.396569175",
        //                 "time":"2018-08-10T06:06:46.000Z",
        //                 "market_id":"BTC-USDT"
        //             }
        //         ]
        //     }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parseTrades(data, market, since, limit);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/en/latest/manual.html?#public-trades}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "market_id", getValue(market, "id") },
            { "limit", 100 },
            { "start_time", "1970-01-01T00:00:00.000Z" },
            { "end_time", this.iso8601(this.milliseconds()) },
        };
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["start_time"] = this.iso8601(since);
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["limit"] = limit;
        }
        object response = await this.publicGetTrade(this.extend(request, parameters));
        //
        //     {
        //         "data":[
        //             {
        //                 "id":"ETH-BTC:3331886",
        //                 "price":"0.022981",
        //                 "quantity":"12.337",
        //                 "time":"2020-04-12T20:55:42.371Z",
        //                 "side":"sell",
        //                 "tick_direction":"down"
        //             },
        //             {
        //                 "id":"ETH-BTC:3331885",
        //                 "price":"0.022982",
        //                 "quantity":"6.472",
        //                 "time":"2020-04-12T20:55:39.652Z",
        //                 "side":"sell",
        //                 "tick_direction":"down"
        //             }
        //         ]
        //     }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parseTrades(data, market, since, limit);
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        // fetchTrades (public)
        //
        //     {
        //         "id":"ETH-BTC:3331886",
        //         "price":"0.022981",
        //         "quantity":"12.337",
        //         "time":"2020-04-12T20:55:42.371Z",
        //         "side":"sell",
        //         "tick_direction":"down"
        //     }
        //
        // fetchMyTrades (private)
        //
        //     {
        //         "id":"BTC-USDT:183566",
        //         "order_id":"17209376",
        //         "side":"sell",
        //         "fee_amount":"0.657396569175",
        //         "fee_currency_id":"USDT",
        //         "status":"settled",
        //         "price":"6573.96569175",
        //         "quantity":"0.1",
        //         "cost":"657.396569175",
        //         "time":"2018-08-10T06:06:46.000Z",
        //         "market_id":"BTC-USDT"
        //     }
        //
        object timestamp = this.parse8601(this.safeString(trade, "time"));
        object id = this.safeString(trade, "id");
        object marketId = null;
        if (isTrue(!isEqual(id, null)))
        {
            object parts = ((string)id).Split((string)":").ToList<object>();
            marketId = this.safeString(parts, 0);
        }
        marketId = this.safeString(trade, "market_id", marketId);
        object symbol = this.safeSymbol(marketId, market, "-");
        object side = this.safeString(trade, "side");
        object priceString = this.safeString(trade, "price");
        object amountString = this.safeString(trade, "quantity");
        object orderId = this.safeString(trade, "order_id");
        object feeCostString = this.safeString(trade, "fee_amount");
        object fee = null;
        if (isTrue(!isEqual(feeCostString, null)))
        {
            object feeCurrencyId = this.safeString(trade, "fee_currency_id");
            object feeCurrencyCode = this.safeCurrencyCode(feeCurrencyId);
            fee = new Dictionary<string, object>() {
                { "cost", feeCostString },
                { "currency", feeCurrencyCode },
            };
        }
        return this.safeTrade(new Dictionary<string, object>() {
            { "id", id },
            { "info", trade },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", symbol },
            { "order", orderId },
            { "type", null },
            { "side", side },
            { "takerOrMaker", null },
            { "price", priceString },
            { "amount", amountString },
            { "cost", null },
            { "fee", fee },
        }, market);
    }

    public async override Task<object> fetchTime(object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchTime
        * @description fetches the current integer timestamp in milliseconds from the exchange server
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {int} the current integer timestamp in milliseconds from the exchange server
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetTime(parameters);
        //
        //     { "data":"2020-04-12T18:54:25.390Z" }
        //
        object timestamp = this.parse8601(this.safeString(response, "data"));
        return timestamp;
    }

    public virtual object normalizeOHLCVTimestamp(object timestamp, object timeframe, object after = null)
    {
        after ??= false;
        object duration = this.parseTimeframe(timeframe);
        if (isTrue(isEqual(timeframe, "1M")))
        {
            object iso8601 = this.iso8601(timestamp);
            object parts = ((string)iso8601).Split((string)"-").ToList<object>();
            object year = this.safeString(parts, 0);
            object month = this.safeInteger(parts, 1);
            object monthString = null;
            if (isTrue(after))
            {
                monthString = ((object)this.sum(month, 1)).ToString();
            }
            if (isTrue(isLessThan(month, 10)))
            {
                monthString = add("0", ((object)month).ToString());
            }
            return add(add(add(year, "-"), monthString), "-01T00:00:00.000Z");
        } else if (isTrue(isEqual(timeframe, "1w")))
        {
            timestamp = this.parseToInt(divide(timestamp, 1000));
            object firstSunday = 259200; // 1970-01-04T00:00:00.000Z
            object difference = subtract(timestamp, firstSunday);
            object numWeeks = (Math.Floor(Double.Parse((divide(difference, duration)).ToString())));
            object previousSunday = this.sum(firstSunday, multiply(numWeeks, duration));
            if (isTrue(after))
            {
                previousSunday = this.sum(previousSunday, duration);
            }
            return this.iso8601(multiply(previousSunday, 1000));
        } else
        {
            timestamp = this.parseToInt(divide(timestamp, 1000));
            timestamp = multiply(duration, this.parseToInt(divide(timestamp, duration)));
            if (isTrue(after))
            {
                timestamp = this.sum(timestamp, duration);
            }
            return this.iso8601(multiply(timestamp, 1000));
        }
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchOHLCV
        * @description fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents
        * @param {int|undefined} since timestamp in ms of the earliest candle to fetch
        * @param {int|undefined} limit the maximum amount of candles to fetch
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {[[int]]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object interval = this.safeString(this.timeframes, timeframe, timeframe);
        limit = ((bool) isTrue((isEqual(limit, null)))) ? 100 : limit;
        object requestLimit = this.sum(limit, 1);
        requestLimit = mathMin(1000, requestLimit); // max 1000
        object request = new Dictionary<string, object>() {
            { "market_ids", getValue(market, "id") },
            { "interval", interval },
            { "sort", "asc" },
            { "limit", requestLimit },
        };
        object now = this.milliseconds();
        object duration = this.parseTimeframe(timeframe);
        object startTime = since;
        object endTime = now;
        if (isTrue(isEqual(since, null)))
        {
            if (isTrue(isEqual(limit, null)))
            {
                limit = requestLimit;
            }
            startTime = subtract(now, multiply(multiply(limit, duration), 1000));
        } else
        {
            if (isTrue(isEqual(limit, null)))
            {
                endTime = now;
            } else
            {
                endTime = this.sum(since, multiply(multiply(this.sum(limit, 1), duration), 1000));
            }
        }
        object startTimeNormalized = this.normalizeOHLCVTimestamp(startTime, timeframe);
        object endTimeNormalized = this.normalizeOHLCVTimestamp(endTime, timeframe, true);
        ((Dictionary<string, object>)request)["start_time"] = startTimeNormalized;
        ((Dictionary<string, object>)request)["end_time"] = endTimeNormalized;
        object response = await this.publicGetCandle(this.extend(request, parameters));
        //
        //     {
        //         "data":[
        //             {
        //                 "market_id":"ETH-BTC",
        //                 "open":"0.02811",
        //                 "close":"0.02811",
        //                 "low":"0.02811",
        //                 "high":"0.02811",
        //                 "base_volume":"0.0005",
        //                 "quote_volume":"0.000014055",
        //                 "start_time":"2018-11-30T18:19:00.000Z",
        //                 "end_time":"2018-11-30T18:20:00.000Z"
        //             },
        //         ]
        //     }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parseOHLCVs(data, market, timeframe, since, limit);
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //
        //     {
        //         "market_id":"ETH-BTC",
        //         "open":"0.02811",
        //         "close":"0.02811",
        //         "low":"0.02811",
        //         "high":"0.02811",
        //         "base_volume":"0.0005",
        //         "quote_volume":"0.000014055",
        //         "start_time":"2018-11-30T18:19:00.000Z",
        //         "end_time":"2018-11-30T18:20:00.000Z"
        //     }
        //
        return new List<object> {this.parse8601(this.safeString(ohlcv, "start_time")), this.safeNumber(ohlcv, "open"), this.safeNumber(ohlcv, "high"), this.safeNumber(ohlcv, "low"), this.safeNumber(ohlcv, "close"), this.safeNumber(ohlcv, "base_volume")};
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        since = this.parse8601(since);
        object request = new Dictionary<string, object>() {};
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["market_id"] = getValue(market, "id");
        }
        object response = await this.privateGetOpenOrder(this.extend(request, parameters));
        object data = this.safeValue(response, "data");
        return this.parseOrders(data, market, since, limit);
    }

    public async override Task<object> fetchClosedOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchClosedOrders
        * @description fetches information on multiple closed orders made by the user
        * @param {string|undefined} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "start_time", this.iso8601(0) },
            { "end_time", this.iso8601(this.milliseconds()) },
            { "limit", 100 },
        };
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["market_id"] = getValue(market, "id");
        }
        if (isTrue(since))
        {
            ((Dictionary<string, object>)request)["start_time"] = this.iso8601(since);
        }
        if (isTrue(limit))
        {
            ((Dictionary<string, object>)request)["limit"] = limit;
        }
        object response = await this.privateGetOrderHistory(this.extend(request, parameters));
        object data = this.safeValue(response, "data");
        return this.parseOrders(data, market, since, limit);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the probit api endpoint
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
            { "market_id", getValue(market, "id") },
        };
        object clientOrderId = this.safeString2(parameters, "clientOrderId", "client_order_id");
        if (isTrue(!isEqual(clientOrderId, null)))
        {
            ((Dictionary<string, object>)request)["client_order_id"] = clientOrderId;
        } else
        {
            ((Dictionary<string, object>)request)["order_id"] = id;
        }
        object query = this.omit(parameters, new List<object>() {"clientOrderId", "client_order_id"});
        object response = await this.privateGetOrder(this.extend(request, query));
        object data = this.safeValue(response, "data", new List<object>() {});
        object order = this.safeValue(data, 0);
        return this.parseOrder(order, market);
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "open", "open" },
            { "cancelled", "canceled" },
            { "filled", "closed" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object parseOrder(object order, object market = null)
    {
        //
        //     {
        //         id: string,
        //         user_id: string,
        //         market_id: string,
        //         type: 'orderType',
        //         side: 'side',
        //         quantity: string,
        //         limit_price: string,
        //         time_in_force: 'timeInForce',
        //         filled_cost: string,
        //         filled_quantity: string,
        //         open_quantity: string,
        //         cancelled_quantity: string,
        //         status: 'orderStatus',
        //         time: 'date',
        //         client_order_id: string,
        //     }
        //
        object status = this.parseOrderStatus(this.safeString(order, "status"));
        object id = this.safeString(order, "id");
        object type = this.safeString(order, "type");
        object side = this.safeString(order, "side");
        object marketId = this.safeString(order, "market_id");
        object symbol = this.safeSymbol(marketId, market, "-");
        object timestamp = this.parse8601(this.safeString(order, "time"));
        object price = this.safeString(order, "limit_price");
        object filled = this.safeString(order, "filled_quantity");
        object remaining = this.safeString(order, "open_quantity");
        object canceledAmount = this.safeString(order, "cancelled_quantity");
        if (isTrue(!isEqual(canceledAmount, null)))
        {
            remaining = Precise.stringAdd(remaining, canceledAmount);
        }
        object amount = this.safeString(order, "quantity", Precise.stringAdd(filled, remaining));
        object cost = this.safeString2(order, "filled_cost", "cost");
        if (isTrue(isEqual(type, "market")))
        {
            price = null;
        }
        object clientOrderId = this.safeString(order, "client_order_id");
        object timeInForce = this.safeStringUpper(order, "time_in_force");
        return this.safeOrder(new Dictionary<string, object>() {
            { "id", id },
            { "info", order },
            { "clientOrderId", clientOrderId },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "lastTradeTimestamp", null },
            { "symbol", symbol },
            { "type", type },
            { "timeInForce", timeInForce },
            { "side", side },
            { "status", status },
            { "price", price },
            { "stopPrice", null },
            { "triggerPrice", null },
            { "amount", amount },
            { "filled", filled },
            { "remaining", remaining },
            { "average", null },
            { "cost", cost },
            { "fee", null },
            { "trades", null },
        }, market);
    }

    public override object costToPrecision(object symbol, object cost)
    {
        return this.decimalToPrecision(cost, TRUNCATE, getValue(getValue(getValue(this.markets, symbol), "precision"), "cost"), this.precisionMode);
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object options = this.safeValue(this.options, "timeInForce");
        object defaultTimeInForce = this.safeValue(options, type);
        object timeInForce = this.safeString2(parameters, "timeInForce", "time_in_force", defaultTimeInForce);
        object request = new Dictionary<string, object>() {
            { "market_id", getValue(market, "id") },
            { "type", type },
            { "side", side },
            { "time_in_force", timeInForce },
        };
        object clientOrderId = this.safeString2(parameters, "clientOrderId", "client_order_id");
        if (isTrue(!isEqual(clientOrderId, null)))
        {
            ((Dictionary<string, object>)request)["client_order_id"] = clientOrderId;
        }
        object costToPrecision = null;
        if (isTrue(isEqual(type, "limit")))
        {
            ((Dictionary<string, object>)request)["limit_price"] = this.priceToPrecision(symbol, price);
            ((Dictionary<string, object>)request)["quantity"] = this.amountToPrecision(symbol, amount);
        } else if (isTrue(isEqual(type, "market")))
        {
            // for market buy it requires the amount of quote currency to spend
            if (isTrue(isEqual(side, "buy")))
            {
                object cost = this.safeNumber(parameters, "cost");
                object createMarketBuyOrderRequiresPrice = this.safeValue(this.options, "createMarketBuyOrderRequiresPrice", true);
                if (isTrue(createMarketBuyOrderRequiresPrice))
                {
                    if (isTrue(!isEqual(price, null)))
                    {
                        if (isTrue(isEqual(cost, null)))
                        {
                            cost = multiply(amount, price);
                        }
                    } else if (isTrue(isEqual(cost, null)))
                    {
                        throw new InvalidOrder ((string)add(this.id, " createOrder() requires the price argument for market buy orders to calculate total order cost (amount to spend), where cost = amount * price. Supply a price argument to createOrder() call if you want the cost to be calculated for you from price and amount, or, alternatively, add .options[\'createMarketBuyOrderRequiresPrice\'] = false and supply the total cost value in the \'amount\' argument or in the \'cost\' extra parameter (the exchange-specific behaviour)")) ;
                    }
                } else
                {
                    cost = ((bool) isTrue((isEqual(cost, null)))) ? amount : cost;
                }
                costToPrecision = this.costToPrecision(symbol, cost);
                ((Dictionary<string, object>)request)["cost"] = costToPrecision;
            } else
            {
                ((Dictionary<string, object>)request)["quantity"] = this.amountToPrecision(symbol, amount);
            }
        }
        object query = this.omit(parameters, new List<object>() {"timeInForce", "time_in_force", "clientOrderId", "client_order_id"});
        object response = await this.privatePostNewOrder(this.extend(request, query));
        //
        //     {
        //         data: {
        //             id: string,
        //             user_id: string,
        //             market_id: string,
        //             type: 'orderType',
        //             side: 'side',
        //             quantity: string,
        //             limit_price: string,
        //             time_in_force: 'timeInForce',
        //             filled_cost: string,
        //             filled_quantity: string,
        //             open_quantity: string,
        //             cancelled_quantity: string,
        //             status: 'orderStatus',
        //             time: 'date',
        //             client_order_id: string,
        //         }
        //     }
        //
        object data = this.safeValue(response, "data");
        object order = this.parseOrder(data, market);
        // a workaround for incorrect huge amounts
        // returned by the exchange on market buys
        if (isTrue(isTrue((isEqual(type, "market"))) && isTrue((isEqual(side, "buy")))))
        {
            ((Dictionary<string, object>)order)["amount"] = null;
            ((Dictionary<string, object>)order)["cost"] = this.parseNumber(costToPrecision);
            ((Dictionary<string, object>)order)["remaining"] = null;
        }
        return order;
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the probit api endpoint
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
            { "market_id", getValue(market, "id") },
            { "order_id", id },
        };
        object response = await this.privatePostCancelOrder(this.extend(request, parameters));
        object data = this.safeValue(response, "data");
        return this.parseOrder(data);
    }

    public override object parseDepositAddress(object depositAddress, object currency = null)
    {
        object address = this.safeString(depositAddress, "address");
        object tag = this.safeString(depositAddress, "destination_tag");
        object currencyId = this.safeString(depositAddress, "currency_id");
        currency = this.safeCurrency(currencyId, currency);
        object code = getValue(currency, "code");
        object network = this.safeString(depositAddress, "platform_id");
        this.checkAddress(address);
        return new Dictionary<string, object>() {
            { "currency", code },
            { "address", address },
            { "tag", tag },
            { "network", network },
            { "info", depositAddress },
        };
    }

    public async override Task<object> fetchDepositAddress(object code, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchDepositAddress
        * @description fetch the deposit address for a currency associated with this account
        * @param {string} code unified currency code
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "currency_id", getValue(currency, "id") },
        };
        object networks = this.safeValue(this.options, "networks", new Dictionary<string, object>() {});
        object network = this.safeStringUpper(parameters, "network"); // this line allows the user to specify either ERC20 or ETH
        network = this.safeString(networks, network, network); // handle ERC20>ETH alias
        if (isTrue(!isEqual(network, null)))
        {
            ((Dictionary<string, object>)request)["platform_id"] = network;
            parameters = this.omit(parameters, "platform_id");
        }
        object response = await this.privateGetDepositAddress(this.extend(request, parameters));
        //
        // without 'platform_id'
        //     {
        //         "data":[
        //             {
        //                 "currency_id":"ETH",
        //                 "address":"0x12e2caf3c4051ba1146e612f532901a423a9898a",
        //                 "destination_tag":null
        //             }
        //         ]
        //     }
        //
        // with 'platform_id'
        //     {
        //         "data":[
        //             {
        //                 "platform_id":"TRON",
        //                 "address":"TDQLMxBTa6MzuoZ6deSGZkqET3Ek8v7uC6",
        //                 "destination_tag":null
        //             }
        //         ]
        //     }
        //
        object data = this.safeValue(response, "data", new List<object>() {});
        object firstAddress = this.safeValue(data, 0);
        if (isTrue(isEqual(firstAddress, null)))
        {
            throw new InvalidAddress ((string)add(this.id, " fetchDepositAddress() returned an empty response")) ;
        }
        return this.parseDepositAddress(firstAddress, currency);
    }

    public async override Task<object> fetchDepositAddresses(object codes = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#fetchDepositAddresses
        * @description fetch deposit addresses for multiple currencies and chain types
        * @param {[string]|undefined} codes list of unified currency codes, default is undefined
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} a list of [address structures]{@link https://docs.ccxt.com/#/?id=address-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        if (isTrue(codes))
        {
            object currencyIds = new List<object>() {};
            for (object i = 0; isLessThan(i, getArrayLength(codes)); postFixIncrement(ref i))
            {
                object currency = this.currency(getValue(codes, i));
                ((List<object>)currencyIds).Add(getValue(currency, "id"));
            }
            ((Dictionary<string, object>)request)["currency_id"] = String.Join(",", codes);
        }
        object response = await this.privateGetDepositAddress(this.extend(request, parameters));
        object data = this.safeValue(response, "data", new List<object>() {});
        return this.parseDepositAddresses(data, codes);
    }

    public async override Task<object> withdraw(object code, object amount, object address, object tag = null, object parameters = null)
    {
        /**
        * @method
        * @name probit#withdraw
        * @description make a withdrawal
        * @param {string} code unified currency code
        * @param {float} amount the amount to withdraw
        * @param {string} address the address to withdraw to
        * @param {string|undefined} tag
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns {object} a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
                var tagparametersVariable = this.handleWithdrawTagAndParams(tag, parameters);
        tag = ((List<object>)tagparametersVariable)[0];
        parameters = ((List<object>)tagparametersVariable)[1];
        // In order to use this method
        // you need to allow API withdrawal from the API Settings Page, and
        // and register the list of withdrawal addresses and destination tags on the API Settings page
        // you can only withdraw to the registered addresses using the API
        this.checkAddress(address);
        await this.loadMarkets();
        object currency = this.currency(code);
        if (isTrue(isEqual(tag, null)))
        {
            tag = "";
        }
        object request = new Dictionary<string, object>() {
            { "currency_id", getValue(currency, "id") },
            { "address", address },
            { "destination_tag", tag },
            { "amount", this.numberToString(amount) },
        };
        object networks = this.safeValue(this.options, "networks", new Dictionary<string, object>() {});
        object network = this.safeStringUpper(parameters, "network"); // this line allows the user to specify either ERC20 or ETH
        network = this.safeString(networks, network, network); // handle ERC20>ETH alias
        if (isTrue(!isEqual(network, null)))
        {
            ((Dictionary<string, object>)request)["platform_id"] = network;
            parameters = this.omit(parameters, "network");
        }
        object response = await this.privatePostWithdrawal(this.extend(request, parameters));
        object data = this.safeValue(response, "data");
        return this.parseTransaction(data, currency);
    }

    public override object parseTransaction(object transaction, object currency = null)
    {
        object id = this.safeString(transaction, "id");
        object amount = this.safeNumber(transaction, "amount");
        object address = this.safeString(transaction, "address");
        object tag = this.safeString(transaction, "destination_tag");
        object txid = this.safeString(transaction, "hash");
        object timestamp = this.parse8601(this.safeString(transaction, "time"));
        object type = this.safeString(transaction, "type");
        object currencyId = this.safeString(transaction, "currency_id");
        object code = this.safeCurrencyCode(currencyId);
        object status = this.parseTransactionStatus(this.safeString(transaction, "status"));
        object feeCost = this.safeNumber(transaction, "fee");
        object fee = null;
        if (isTrue(isTrue(!isEqual(feeCost, null)) && isTrue(!isEqual(feeCost, 0))))
        {
            fee = new Dictionary<string, object>() {
                { "currency", code },
                { "cost", feeCost },
            };
        }
        return new Dictionary<string, object>() {
            { "id", id },
            { "currency", code },
            { "amount", amount },
            { "network", null },
            { "addressFrom", null },
            { "address", address },
            { "addressTo", address },
            { "tagFrom", null },
            { "tag", tag },
            { "tagTo", tag },
            { "status", status },
            { "type", type },
            { "txid", txid },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "updated", null },
            { "fee", fee },
            { "info", transaction },
        };
    }

    public virtual object parseTransactionStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "requested", "pending" },
            { "pending", "pending" },
            { "confirming", "pending" },
            { "confirmed", "pending" },
            { "applying", "pending" },
            { "done", "ok" },
            { "cancelled", "canceled" },
            { "cancelling", "canceled" },
        };
        return this.safeString(statuses, status, status);
    }

    public async override Task<object> fetchDepositWithdrawFees(object codes = null, object parameters = null)
    {
        /**
        * @method
        * @name poloniex#fetchDepositWithdrawFees
        * @description fetch deposit and withdraw fees
        * @see https://docs.poloniex.com/#public-endpoints-reference-data-currency-information
        * @param {[string]|undefined} codes list of unified currency codes
        * @param {object} params extra parameters specific to the poloniex api endpoint
        * @returns {[object]} a list of [fees structures]{@link https://docs.ccxt.com/#/?id=fee-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.publicGetCurrencyWithPlatform(parameters);
        //
        //  {
        //     "data": [
        //       {
        //       "id": "AFX",
        //       "display_name": {
        //       "ko-kr": "아프릭스",
        //       "en-us": "Afrix"
        //       },
        //       "show_in_ui": true,
        //       "platform": [
        //       {
        //       "id": "ZYN",
        //       "priority": 1,
        //       "deposit": true,
        //       "withdrawal": true,
        //       "currency_id": "AFX",
        //       "precision": 18,
        //       "min_confirmation_count": 60,
        //       "require_destination_tag": false,
        //       "allow_withdrawal_destination_tag": false,
        //       "display_name": {
        //       "name": {
        //       "ko-kr": "지네코인",
        //       "en-us": "Wethio"
        //       }
        //       },
        //       "min_deposit_amount": "0",
        //       "min_withdrawal_amount": "0",
        //       "withdrawal_fee": [
        //       {
        //       "currency_id": "ZYN",
        //       "amount": "0.5",
        //       "priority": 1
        //       }
        //       ],
        //       "deposit_fee": {},
        //       "suspended_reason": "",
        //       "deposit_suspended": false,
        //       "withdrawal_suspended": false,
        //       "platform_currency_display_name": {}
        //       }
        //       ],
        //       "internal_transfer": {
        //       "suspended_reason": null,
        //       "suspended": false
        //       },
        //       "stakeable": false,
        //       "unstakeable": false,
        //       "auto_stake": false,
        //       "auto_stake_amount": "0"
        //       },
        //     ]
        //  }
        //
        object data = this.safeValue(response, "data");
        return this.parseDepositWithdrawFees(data, codes, "id");
    }

    public override object parseDepositWithdrawFee(object fee, object currency = null)
    {
        //
        // {
        //     id: 'USDT',
        //     display_name: { 'ko-kr': '테더', 'en-us': 'Tether' },
        //     show_in_ui: true,
        //     platform: [
        //       {
        //         id: 'ETH',
        //         priority: '1',
        //         deposit: true,
        //         withdrawal: true,
        //         currency_id: 'USDT',
        //         precision: '6',
        //         min_confirmation_count: '15',
        //         require_destination_tag: false,
        //         allow_withdrawal_destination_tag: false,
        //         display_name: [Object],
        //         min_deposit_amount: '0',
        //         min_withdrawal_amount: '1',
        //         withdrawal_fee: [Array],
        //         deposit_fee: {},
        //         suspended_reason: '',
        //         deposit_suspended: false,
        //         withdrawal_suspended: false,
        //         platform_currency_display_name: [Object]
        //       },
        //     ],
        //     internal_transfer: { suspended_reason: null, suspended: false },
        //     stakeable: false,
        //     unstakeable: false,
        //     auto_stake: false,
        //     auto_stake_amount: '0'
        //   }
        //
        object depositWithdrawFee = this.depositWithdrawFee(new Dictionary<string, object>() {});
        object platforms = this.safeValue(fee, "platform", new List<object>() {});
        object depositResult = new Dictionary<string, object>() {
            { "fee", null },
            { "percentage", null },
        };
        for (object i = 0; isLessThan(i, getArrayLength(platforms)); postFixIncrement(ref i))
        {
            object network = getValue(platforms, i);
            object networkId = this.safeString(network, "id");
            object networkCode = this.networkIdToCode(networkId, getValue(currency, "code"));
            object withdrawalFees = this.safeValue(network, "withdrawal_fee", new Dictionary<string, object>() {});
            object withdrawFee = this.safeNumber(getValue(withdrawalFees, 0), "amount");
            if (isTrue(isGreaterThan(getArrayLength(withdrawalFees), 0)))
            {
                object withdrawResult = new Dictionary<string, object>() {
                    { "fee", withdrawFee },
                    { "percentage", ((bool) isTrue((!isEqual(withdrawFee, null)))) ? false : null },
                };
                if (isTrue(isEqual(i, 0)))
                {
                    ((Dictionary<string, object>)depositWithdrawFee)["withdraw"] = withdrawResult;
                }
                ((Dictionary<string, object>)getValue(depositWithdrawFee, "networks"))[(string)networkCode] = new Dictionary<string, object>() {
                    { "withdraw", withdrawResult },
                    { "deposit", depositResult },
                };
            }
        }
        ((Dictionary<string, object>)depositWithdrawFee)["info"] = fee;
        return depositWithdrawFee;
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
        object url = add(getValue(getValue(this.urls, "api"), api), "/");
        object query = this.omit(parameters, this.extractParams(path));
        if (isTrue(isEqual(api, "accounts")))
        {
            this.checkRequiredCredentials();
            url = add(url, this.implodeParams(path, parameters));
            object auth = add(add(this.apiKey, ":"), this.secret);
            object auth64 = this.stringToBase64(auth);
            headers = new Dictionary<string, object>() {
                { "Authorization", add("Basic ", auth64) },
                { "Content-Type", "application/json" },
            };
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
            {
                body = this.json(query);
            }
        } else
        {
            url = add(url, add(this.version, "/"));
            if (isTrue(isEqual(api, "public")))
            {
                url = add(url, this.implodeParams(path, parameters));
                if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
                {
                    url = add(url, add("?", this.urlencode(query)));
                }
            } else if (isTrue(isEqual(api, "private")))
            {
                object now = this.milliseconds();
                this.checkRequiredCredentials();
                object expires = this.safeInteger(this.options, "expires");
                if (isTrue(isTrue((isEqual(expires, null))) || isTrue((isLessThan(expires, now)))))
                {
                    throw new AuthenticationError ((string)add(this.id, " access token expired, call signIn() method")) ;
                }
                object accessToken = this.safeString(this.options, "accessToken");
                headers = new Dictionary<string, object>() {
                    { "Authorization", add("Bearer ", accessToken) },
                };
                url = add(url, this.implodeParams(path, parameters));
                if (isTrue(isEqual(method, "GET")))
                {
                    if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
                    {
                        url = add(url, add("?", this.urlencode(query)));
                    }
                } else if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)query).Keys))))
                {
                    body = this.json(query);
                    ((Dictionary<string, object>)headers)["Content-Type"] = "application/json";
                }
            }
        }
        return new Dictionary<string, object>() {
            { "url", url },
            { "method", method },
            { "body", body },
            { "headers", headers },
        };
    }

    public async virtual Task<object> signIn(object parameters = null)
    {
        /**
        * @method
        * @name probit#signIn
        * @description sign in, must be called prior to using other authenticated methods
        * @param {object} params extra parameters specific to the probit api endpoint
        * @returns response from exchange
        */
        parameters ??= new Dictionary<string, object>();
        this.checkRequiredCredentials();
        object request = new Dictionary<string, object>() {
            { "grant_type", "client_credentials" },
        };
        object response = await this.accountsPostToken(this.extend(request, parameters));
        //
        //     {
        //         access_token: '0ttDv/2hTTn3bLi8GP1gKaneiEQ6+0hOBenPrxNQt2s=',
        //         token_type: 'bearer',
        //         expires_in: 900
        //     }
        //
        object expiresIn = this.safeInteger(response, "expires_in");
        object accessToken = this.safeString(response, "access_token");
        ((Dictionary<string, object>)this.options)["accessToken"] = accessToken;
        ((Dictionary<string, object>)this.options)["expires"] = this.sum(this.milliseconds(), multiply(expiresIn, 1000));
        return response;
    }

    public override object handleErrors(object code, object reason, object url, object method, object headers, object body, object response, object requestHeaders, object requestBody)
    {
        if (isTrue(isEqual(response, null)))
        {
            return null;  // fallback to default error handler
        }
        if (isTrue(((Dictionary<string,object>)response).ContainsKey(toStringOrNull("errorCode"))))
        {
            object errorCode = this.safeString(response, "errorCode");
            object message = this.safeString(response, "message");
            if (isTrue(!isEqual(errorCode, null)))
            {
                object feedback = add(add(this.id, " "), body);
                this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), message, feedback);
                this.throwBroadlyMatchedException(getValue(this.exceptions, "exact"), errorCode, feedback);
                throw new ExchangeError ((string)feedback) ;
            }
        }
        return null;
    }
}
