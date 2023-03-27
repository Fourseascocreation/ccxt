using Main;
namespace Main;

partial class bitmex : Exchange
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "bitmex" },
            { "name", "BitMEX" },
            { "countries", new List<object>() {"SC"} },
            { "version", "v1" },
            { "userAgent", null },
            { "rateLimit", 100 },
            { "pro", true },
            { "has", new Dictionary<string, object>() {
                { "CORS", null },
                { "spot", true },
                { "margin", false },
                { "swap", true },
                { "future", true },
                { "option", false },
                { "addMargin", null },
                { "cancelAllOrders", true },
                { "cancelOrder", true },
                { "cancelOrders", true },
                { "createOrder", true },
                { "createReduceOnlyOrder", true },
                { "editOrder", true },
                { "fetchBalance", true },
                { "fetchClosedOrders", true },
                { "fetchDepositAddress", true },
                { "fetchDepositAddresses", false },
                { "fetchDepositAddressesByNetwork", false },
                { "fetchFundingHistory", false },
                { "fetchFundingRate", false },
                { "fetchFundingRateHistory", true },
                { "fetchFundingRates", true },
                { "fetchIndexOHLCV", false },
                { "fetchLedger", true },
                { "fetchLeverage", false },
                { "fetchLeverageTiers", false },
                { "fetchMarketLeverageTiers", false },
                { "fetchMarkets", true },
                { "fetchMarkOHLCV", false },
                { "fetchMyTrades", true },
                { "fetchOHLCV", true },
                { "fetchOpenOrders", true },
                { "fetchOrder", true },
                { "fetchOrderBook", true },
                { "fetchOrders", true },
                { "fetchPosition", false },
                { "fetchPositions", true },
                { "fetchPositionsRisk", false },
                { "fetchPremiumIndexOHLCV", false },
                { "fetchTicker", true },
                { "fetchTickers", true },
                { "fetchTrades", true },
                { "fetchTransactions", "emulated" },
                { "fetchTransfer", false },
                { "fetchTransfers", false },
                { "reduceMargin", null },
                { "setLeverage", true },
                { "setMargin", null },
                { "setMarginMode", true },
                { "setPositionMode", false },
                { "transfer", false },
                { "withdraw", true },
            } },
            { "timeframes", new Dictionary<string, object>() {
                { "1m", "1m" },
                { "5m", "5m" },
                { "1h", "1h" },
                { "1d", "1d" },
            } },
            { "urls", new Dictionary<string, object>() {
                { "test", new Dictionary<string, object>() {
                    { "public", "https://testnet.bitmex.com" },
                    { "private", "https://testnet.bitmex.com" },
                } },
                { "logo", "https://user-images.githubusercontent.com/1294454/27766319-f653c6e6-5ed4-11e7-933d-f0bc3699ae8f.jpg" },
                { "api", new Dictionary<string, object>() {
                    { "public", "https://www.bitmex.com" },
                    { "private", "https://www.bitmex.com" },
                } },
                { "www", "https://www.bitmex.com" },
                { "doc", new List<object>() {"https://www.bitmex.com/app/apiOverview", "https://github.com/BitMEX/api-connectors/tree/master/official-http"} },
                { "fees", "https://www.bitmex.com/app/fees" },
                { "referral", "https://www.bitmex.com/register/upZpOX" },
            } },
            { "api", new Dictionary<string, object>() {
                { "public", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "announcement", 5 },
                        { "announcement/urgent", 5 },
                        { "funding", 5 },
                        { "instrument", 5 },
                        { "instrument/active", 5 },
                        { "instrument/activeAndIndices", 5 },
                        { "instrument/activeIntervals", 5 },
                        { "instrument/compositeIndex", 5 },
                        { "instrument/indices", 5 },
                        { "insurance", 5 },
                        { "leaderboard", 5 },
                        { "liquidation", 5 },
                        { "orderBook", 5 },
                        { "orderBook/L2", 5 },
                        { "quote", 5 },
                        { "quote/bucketed", 5 },
                        { "schema", 5 },
                        { "schema/websocketHelp", 5 },
                        { "settlement", 5 },
                        { "stats", 5 },
                        { "stats/history", 5 },
                        { "trade", 5 },
                        { "trade/bucketed", 5 },
                        { "wallet/assets", 5 },
                        { "wallet/networks", 5 },
                    } },
                } },
                { "private", new Dictionary<string, object>() {
                    { "get", new Dictionary<string, object>() {
                        { "apiKey", 5 },
                        { "chat", 5 },
                        { "chat/channels", 5 },
                        { "chat/connected", 5 },
                        { "execution", 5 },
                        { "execution/tradeHistory", 5 },
                        { "notification", 5 },
                        { "order", 5 },
                        { "position", 5 },
                        { "user", 5 },
                        { "user/affiliateStatus", 5 },
                        { "user/checkReferralCode", 5 },
                        { "user/commission", 5 },
                        { "user/depositAddress", 5 },
                        { "user/executionHistory", 5 },
                        { "user/margin", 5 },
                        { "user/minWithdrawalFee", 5 },
                        { "user/wallet", 5 },
                        { "user/walletHistory", 5 },
                        { "user/walletSummary", 5 },
                        { "wallet/assets", 5 },
                        { "wallet/networks", 5 },
                        { "userEvent", 5 },
                    } },
                    { "post", new Dictionary<string, object>() {
                        { "apiKey", 5 },
                        { "apiKey/disable", 5 },
                        { "apiKey/enable", 5 },
                        { "chat", 5 },
                        { "order", 1 },
                        { "order/bulk", 5 },
                        { "order/cancelAllAfter", 5 },
                        { "order/closePosition", 5 },
                        { "position/isolate", 1 },
                        { "position/leverage", 1 },
                        { "position/riskLimit", 5 },
                        { "position/transferMargin", 1 },
                        { "user/cancelWithdrawal", 5 },
                        { "user/confirmEmail", 5 },
                        { "user/confirmEnableTFA", 5 },
                        { "user/confirmWithdrawal", 5 },
                        { "user/disableTFA", 5 },
                        { "user/logout", 5 },
                        { "user/logoutAll", 5 },
                        { "user/preferences", 5 },
                        { "user/requestEnableTFA", 5 },
                        { "user/requestWithdrawal", 5 },
                    } },
                    { "put", new Dictionary<string, object>() {
                        { "order", 1 },
                        { "order/bulk", 5 },
                        { "user", 5 },
                    } },
                    { "delete", new Dictionary<string, object>() {
                        { "apiKey", 5 },
                        { "order", 1 },
                        { "order/all", 1 },
                    } },
                } },
            } },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {
                    { "Invalid API Key.", typeof(AuthenticationError) },
                    { "This key is disabled.", typeof(PermissionDenied) },
                    { "Access Denied", typeof(PermissionDenied) },
                    { "Duplicate clOrdID", typeof(InvalidOrder) },
                    { "orderQty is invalid", typeof(InvalidOrder) },
                    { "Invalid price", typeof(InvalidOrder) },
                    { "Invalid stopPx for ordType", typeof(InvalidOrder) },
                } },
                { "broad", new Dictionary<string, object>() {
                    { "Signature not valid", typeof(AuthenticationError) },
                    { "overloaded", typeof(ExchangeNotAvailable) },
                    { "Account has insufficient Available Balance", typeof(InsufficientFunds) },
                    { "Service unavailable", typeof(ExchangeNotAvailable) },
                    { "Server Error", typeof(ExchangeError) },
                    { "Unable to cancel order due to existing state", typeof(InvalidOrder) },
                    { "We require all new traders to verify", typeof(PermissionDenied) },
                } },
            } },
            { "precisionMode", TICK_SIZE },
            { "options", new Dictionary<string, object>() {
                { "api-expires", 5 },
                { "fetchOHLCVOpenTimestamp", true },
                { "networks", new Dictionary<string, object>() {
                    { "BTC", "btc" },
                    { "ETH", "eth" },
                    { "BSC", "bsc" },
                    { "BNB", "bsc" },
                    { "TRON", "tron" },
                    { "ERC20", "eth" },
                    { "BEP20", "bsc" },
                    { "TRC20", "tron" },
                    { "TRX", "tron" },
                    { "AVAX", "avax" },
                    { "NEAR", "near" },
                    { "XTZ", "xtz" },
                    { "DOT", "dot" },
                    { "SOL", "sol" },
                } },
                { "networksById", new Dictionary<string, object>() {
                    { "btc", "BTC" },
                    { "eth", "ERC20" },
                    { "bsc", "BSC" },
                    { "tron", "TRX" },
                    { "avax", "AVAX" },
                    { "near", "NEAR" },
                    { "xtz", "XTZ" },
                    { "dot", "DOT" },
                    { "sol", "SOL" },
                } },
            } },
            { "commonCurrencies", new Dictionary<string, object>() {
                { "USDt", "USDT" },
                { "XBt", "BTC" },
                { "XBT", "BTC" },
                { "Gwei", "ETH" },
                { "GWEI", "ETH" },
                { "LAMP", "SOL" },
                { "LAMp", "SOL" },
            } },
        });
    }

    public async override Task<object> fetchMarkets(object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchMarkets
        * @description retrieves data on all markets for bitmex
        * @param {object} params extra parameters specific to the exchange api endpoint
        * @returns {[object]} an array of objects representing market data
        */
        parameters ??= new Dictionary<string, object>();
        object response = await this.publicGetInstrumentActiveAndIndices(parameters);
        //
        //    {
        //        "symbol": "LTCUSDT",
        //        "rootSymbol": "LTC",
        //        "state": "Open",
        //        "typ": "FFWCSX",
        //        "listing": "2021-11-10T04:00:00.000Z",
        //        "front": "2021-11-10T04:00:00.000Z",
        //        "expiry": null,
        //        "settle": null,
        //        "listedSettle": null,
        //        "relistInterval": null,
        //        "inverseLeg": "",
        //        "sellLeg": "",
        //        "buyLeg": "",
        //        "optionStrikePcnt": null,
        //        "optionStrikeRound": null,
        //        "optionStrikePrice": null,
        //        "optionMultiplier": null,
        //        "positionCurrency": "LTC",
        //        "underlying": "LTC",
        //        "quoteCurrency": "USDT",
        //        "underlyingSymbol": "LTCT=",
        //        "reference": "BMEX",
        //        "referenceSymbol": ".BLTCT",
        //        "calcInterval": null,
        //        "publishInterval": null,
        //        "publishTime": null,
        //        "maxOrderQty": 1000000000,
        //        "maxPrice": 1000000,
        //        "lotSize": 1000,
        //        "tickSize": 0.01,
        //        "multiplier": 100,
        //        "settlCurrency": "USDt",
        //        "underlyingToPositionMultiplier": 10000,
        //        "underlyingToSettleMultiplier": null,
        //        "quoteToSettleMultiplier": 1000000,
        //        "isQuanto": false,
        //        "isInverse": false,
        //        "initMargin": 0.03,
        //        "maintMargin": 0.015,
        //        "riskLimit": 1000000000000,
        //        "riskStep": 1000000000000,
        //        "limit": null,
        //        "capped": false,
        //        "taxed": true,
        //        "deleverage": true,
        //        "makerFee": -0.0001,
        //        "takerFee": 0.0005,
        //        "settlementFee": 0,
        //        "insuranceFee": 0,
        //        "fundingBaseSymbol": ".LTCBON8H",
        //        "fundingQuoteSymbol": ".USDTBON8H",
        //        "fundingPremiumSymbol": ".LTCUSDTPI8H",
        //        "fundingTimestamp": "2022-01-14T20:00:00.000Z",
        //        "fundingInterval": "2000-01-01T08:00:00.000Z",
        //        "fundingRate": 0.0001,
        //        "indicativeFundingRate": 0.0001,
        //        "rebalanceTimestamp": null,
        //        "rebalanceInterval": null,
        //        "openingTimestamp": "2022-01-14T17:00:00.000Z",
        //        "closingTimestamp": "2022-01-14T18:00:00.000Z",
        //        "sessionInterval": "2000-01-01T01:00:00.000Z",
        //        "prevClosePrice": 138.511,
        //        "limitDownPrice": null,
        //        "limitUpPrice": null,
        //        "bankruptLimitDownPrice": null,
        //        "bankruptLimitUpPrice": null,
        //        "prevTotalVolume": 12699024000,
        //        "totalVolume": 12702160000,
        //        "volume": 3136000,
        //        "volume24h": 114251000,
        //        "prevTotalTurnover": 232418052349000,
        //        "totalTurnover": 232463353260000,
        //        "turnover": 45300911000,
        //        "turnover24h": 1604331340000,
        //        "homeNotional24h": 11425.1,
        //        "foreignNotional24h": 1604331.3400000003,
        //        "prevPrice24h": 135.48,
        //        "vwap": 140.42165,
        //        "highPrice": 146.42,
        //        "lowPrice": 135.08,
        //        "lastPrice": 144.36,
        //        "lastPriceProtected": 144.36,
        //        "lastTickDirection": "MinusTick",
        //        "lastChangePcnt": 0.0655,
        //        "bidPrice": 143.75,
        //        "midPrice": 143.855,
        //        "askPrice": 143.96,
        //        "impactBidPrice": 143.75,
        //        "impactMidPrice": 143.855,
        //        "impactAskPrice": 143.96,
        //        "hasLiquidity": true,
        //        "openInterest": 38103000,
        //        "openValue": 547963053300,
        //        "fairMethod": "FundingRate",
        //        "fairBasisRate": 0.1095,
        //        "fairBasis": 0.004,
        //        "fairPrice": 143.811,
        //        "markMethod": "FairPrice",
        //        "markPrice": 143.811,
        //        "indicativeTaxRate": null,
        //        "indicativeSettlePrice": 143.807,
        //        "optionUnderlyingPrice": null,
        //        "settledPriceAdjustmentRate": null,
        //        "settledPrice": null,
        //        "timestamp": "2022-01-14T17:49:55.000Z"
        //    }
        //
        object result = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object market = getValue(response, i);
            object id = this.safeString(market, "symbol");
            object baseId = this.safeString(market, "underlying");
            object quoteId = this.safeString(market, "quoteCurrency");
            object settleId = this.safeString(market, "settlCurrency", "");
            object bs = this.safeCurrencyCode(baseId);
            object quote = this.safeCurrencyCode(quoteId);
            object settle = this.safeCurrencyCode(settleId);
            object basequote = add(baseId, quoteId);
            object swap = (isEqual(id, basequote));
            // 'positionCurrency' may be empty ("", as Bitmex currently returns for ETHUSD)
            // so let's take the settlCurrency first and then adjust if needed
            object type = null;
            object future = false;
            object prediction = false;
            object index = false;
            object symbol = add(add(add(add(bs, "/"), quote), ":"), settle);
            object expiryDatetime = this.safeString(market, "expiry");
            object expiry = this.parse8601(expiryDatetime);
            object inverse = this.safeValue(market, "isInverse");
            object status = this.safeString(market, "state");
            object active = !isEqual(status, "Unlisted");
            if (isTrue(swap))
            {
                type = "swap";
            } else if (isTrue(isGreaterThanOrEqual(getIndexOf(id, "B_"), 0)))
            {
                prediction = true;
                type = "prediction";
                symbol = id;
            } else if (isTrue(!isEqual(expiry, null)))
            {
                future = true;
                type = "future";
                symbol = add(add(symbol, "-"), this.yymmdd(expiry));
            } else
            {
                index = true;
                type = "index";
                symbol = id;
                active = false;
            }
            object positionId = this.safeString2(market, "positionCurrency", "underlying");
            object position = this.safeCurrencyCode(positionId);
            object positionIsQuote = (isEqual(position, quote));
            object maxOrderQty = this.safeNumber(market, "maxOrderQty");
            object contract = !isTrue(index);
            object initMargin = this.safeString(market, "initMargin", "1");
            object maxLeverage = this.parseNumber(Precise.stringDiv("1", initMargin));
            object multiplierString = Precise.stringAbs(this.safeString(market, "multiplier"));
            ((List<object>)result).Add(new Dictionary<string, object>() {
                { "id", id },
                { "symbol", symbol },
                { "base", bs },
                { "quote", quote },
                { "settle", settle },
                { "baseId", baseId },
                { "quoteId", quoteId },
                { "settleId", settleId },
                { "type", type },
                { "spot", false },
                { "margin", false },
                { "swap", swap },
                { "future", future },
                { "option", false },
                { "prediction", prediction },
                { "index", index },
                { "active", active },
                { "contract", contract },
                { "linear", ((bool) isTrue(contract)) ? !isTrue(inverse) : null },
                { "inverse", ((bool) isTrue(contract)) ? inverse : null },
                { "taker", this.safeNumber(market, "takerFee") },
                { "maker", this.safeNumber(market, "makerFee") },
                { "contractSize", this.parseNumber(multiplierString) },
                { "expiry", expiry },
                { "expiryDatetime", expiryDatetime },
                { "strike", this.safeNumber(market, "optionStrikePrice") },
                { "optionType", null },
                { "precision", new Dictionary<string, object>() {
                    { "amount", this.safeNumber(market, "lotSize") },
                    { "price", this.safeNumber(market, "tickSize") },
                    { "quote", this.safeNumber(market, "tickSize") },
                    { "base", this.safeNumber(market, "tickSize") },
                } },
                { "limits", new Dictionary<string, object>() {
                    { "leverage", new Dictionary<string, object>() {
                        { "min", ((bool) isTrue(contract)) ? this.parseNumber("1") : null },
                        { "max", ((bool) isTrue(contract)) ? maxLeverage : null },
                    } },
                    { "amount", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", ((bool) isTrue(positionIsQuote)) ? null : maxOrderQty },
                    } },
                    { "price", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", this.safeNumber(market, "maxPrice") },
                    } },
                    { "cost", new Dictionary<string, object>() {
                        { "min", null },
                        { "max", ((bool) isTrue(positionIsQuote)) ? maxOrderQty : null },
                    } },
                } },
                { "info", market },
            });
        }
        return result;
    }

    public virtual object parseBalance(object response)
    {
        //
        //     [
        //         {
        //             "account":1455728,
        //             "currency":"XBt",
        //             "riskLimit":1000000000000,
        //             "prevState":"",
        //             "state":"",
        //             "action":"",
        //             "amount":263542,
        //             "pendingCredit":0,
        //             "pendingDebit":0,
        //             "confirmedDebit":0,
        //             "prevRealisedPnl":0,
        //             "prevUnrealisedPnl":0,
        //             "grossComm":0,
        //             "grossOpenCost":0,
        //             "grossOpenPremium":0,
        //             "grossExecCost":0,
        //             "grossMarkValue":0,
        //             "riskValue":0,
        //             "taxableMargin":0,
        //             "initMargin":0,
        //             "maintMargin":0,
        //             "sessionMargin":0,
        //             "targetExcessMargin":0,
        //             "varMargin":0,
        //             "realisedPnl":0,
        //             "unrealisedPnl":0,
        //             "indicativeTax":0,
        //             "unrealisedProfit":0,
        //             "syntheticMargin":null,
        //             "walletBalance":263542,
        //             "marginBalance":263542,
        //             "marginBalancePcnt":1,
        //             "marginLeverage":0,
        //             "marginUsedPcnt":0,
        //             "excessMargin":263542,
        //             "excessMarginPcnt":1,
        //             "availableMargin":263542,
        //             "withdrawableMargin":263542,
        //             "timestamp":"2020-08-03T12:01:01.246Z",
        //             "grossLastValue":0,
        //             "commission":null
        //         }
        //     ]
        //
        object result = new Dictionary<string, object>() {
            { "info", response },
        };
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object balance = getValue(response, i);
            object currencyId = this.safeString(balance, "currency");
            object code = this.safeCurrencyCode(currencyId);
            object account = this.account();
            object free = this.safeString(balance, "availableMargin");
            object total = this.safeString(balance, "marginBalance");
            if (isTrue(!isEqual(code, "USDT")))
            {
                // tmp fix until this PR gets merged
                // https://github.com/ccxt/ccxt/pull/15311
                object symbol = add(code, "_USDT");
                object market = this.safeMarket(symbol);
                object info = this.safeValue(market, "info", new Dictionary<string, object>() {});
                object multiplier = this.safeString(info, "underlyingToPositionMultiplier");
                if (isTrue(!isEqual(multiplier, null)))
                {
                    free = Precise.stringDiv(free, multiplier);
                    total = Precise.stringDiv(total, multiplier);
                } else
                {
                    free = Precise.stringDiv(free, "1e8");
                    total = Precise.stringDiv(total, "1e8");
                }
            } else
            {
                free = Precise.stringDiv(free, "1e6");
                total = Precise.stringDiv(total, "1e6");
            }
            ((Dictionary<string, object>)account)["free"] = free;
            ((Dictionary<string, object>)account)["total"] = total;
            ((Dictionary<string, object>)result)[(string)code] = account;
        }
        return this.safeBalance(result);
    }

    public async override Task<object> fetchBalance(object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchBalance
        * @description query for balance and get the amount of funds available for trading or funds locked in orders
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} a [balance structure]{@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "currency", "all" },
        };
        object response = await this.privateGetUserMargin(this.extend(request, parameters));
        //
        //     [
        //         {
        //             "account":1455728,
        //             "currency":"XBt",
        //             "riskLimit":1000000000000,
        //             "prevState":"",
        //             "state":"",
        //             "action":"",
        //             "amount":263542,
        //             "pendingCredit":0,
        //             "pendingDebit":0,
        //             "confirmedDebit":0,
        //             "prevRealisedPnl":0,
        //             "prevUnrealisedPnl":0,
        //             "grossComm":0,
        //             "grossOpenCost":0,
        //             "grossOpenPremium":0,
        //             "grossExecCost":0,
        //             "grossMarkValue":0,
        //             "riskValue":0,
        //             "taxableMargin":0,
        //             "initMargin":0,
        //             "maintMargin":0,
        //             "sessionMargin":0,
        //             "targetExcessMargin":0,
        //             "varMargin":0,
        //             "realisedPnl":0,
        //             "unrealisedPnl":0,
        //             "indicativeTax":0,
        //             "unrealisedProfit":0,
        //             "syntheticMargin":null,
        //             "walletBalance":263542,
        //             "marginBalance":263542,
        //             "marginBalancePcnt":1,
        //             "marginLeverage":0,
        //             "marginUsedPcnt":0,
        //             "excessMargin":263542,
        //             "excessMarginPcnt":1,
        //             "availableMargin":263542,
        //             "withdrawableMargin":263542,
        //             "timestamp":"2020-08-03T12:01:01.246Z",
        //             "grossLastValue":0,
        //             "commission":null
        //         }
        //     ]
        //
        return this.parseBalance(response);
    }

    public async override Task<object> fetchOrderBook(object symbol, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchOrderBook
        * @description fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
        * @param {string} symbol unified symbol of the market to fetch the order book for
        * @param {int|undefined} limit the maximum amount of order book entries to return
        * @param {object} params extra parameters specific to the bitmex api endpoint
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
            ((Dictionary<string, object>)request)["depth"] = limit;
        }
        object response = await this.publicGetOrderBookL2(this.extend(request, parameters));
        object result = new Dictionary<string, object>() {
            { "symbol", symbol },
            { "bids", new List<object>() {} },
            { "asks", new List<object>() {} },
            { "timestamp", null },
            { "datetime", null },
            { "nonce", null },
        };
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object order = getValue(response, i);
            object side = ((bool) isTrue((isEqual(getValue(order, "side"), "Sell")))) ? "asks" : "bids";
            object amount = this.safeNumber(order, "size");
            object price = this.safeNumber(order, "price");
            // https://github.com/ccxt/ccxt/issues/4926
            // https://github.com/ccxt/ccxt/issues/4927
            // the exchange sometimes returns null price in the orderbook
            if (isTrue(!isEqual(price, null)))
            {
                ((List<object>)getValue(result, side)).Add(new List<object>() {price, amount});
            }
        }
        ((Dictionary<string, object>)result)["bids"] = this.sortBy(getValue(result, "bids"), 0, true);
        ((Dictionary<string, object>)result)["asks"] = this.sortBy(getValue(result, "asks"), 0);
        return ((object)result);
    }

    public async override Task<object> fetchOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchOrder
        * @description fetches information on an order made by the user
        * @param {string|undefined} symbol unified symbol of the market the order was made in
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object filter = new Dictionary<string, object>() {
            { "filter", new Dictionary<string, object>() {
                { "orderID", id },
            } },
        };
        object response = await this.fetchOrders(symbol, null, null, this.deepExtend(filter, parameters));
        object numResults = getArrayLength(response);
        if (isTrue(isEqual(numResults, 1)))
        {
            return getValue(response, 0);
        }
        throw new OrderNotFound ((string)add(add(add(this.id, ": The order "), id), " not found.")) ;
    }

    public async override Task<object> fetchOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchOrders
        * @description fetches information on multiple orders made by the user
        * @param {string|undefined} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = null;
        object request = new Dictionary<string, object>() {};
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["symbol"] = getValue(market, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["startTime"] = this.iso8601(since);
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit;
        }
        request = this.deepExtend(request, parameters);
        // why the hassle? urlencode in python is kinda broken for nested dicts.
        // E.g. self.urlencode({"filter": {"open": True}}) will return "filter={'open':+True}"
        // Bitmex doesn't like that. Hence resorting to this hack.
        if (isTrue(((Dictionary<string,object>)request).ContainsKey(toStringOrNull("filter"))))
        {
            ((Dictionary<string, object>)request)["filter"] = this.json(getValue(request, "filter"));
        }
        object response = await this.privateGetOrder(request);
        return this.parseOrders(response, market, since, limit);
    }

    public async override Task<object> fetchOpenOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchOpenOrders
        * @description fetch all unfilled currently open orders
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch open orders for
        * @param {int|undefined} limit the maximum number of  open orders structures to retrieve
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        object request = new Dictionary<string, object>() {
            { "filter", new Dictionary<string, object>() {
                { "open", true },
            } },
        };
        return await this.fetchOrders(symbol, since, limit, this.deepExtend(request, parameters));
    }

    public async override Task<object> fetchClosedOrders(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchClosedOrders
        * @description fetches information on multiple closed orders made by the user
        * @param {string|undefined} symbol unified market symbol of the market orders were made in
        * @param {int|undefined} since the earliest time in ms to fetch orders for
        * @param {int|undefined} limit the maximum number of  orde structures to retrieve
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        // Bitmex barfs if you set 'open': false in the filter...
        parameters ??= new Dictionary<string, object>();
        object orders = await this.fetchOrders(symbol, since, limit, parameters);
        return this.filterBy(orders, "status", "closed");
    }

    public async override Task<object> fetchMyTrades(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchMyTrades
        * @description fetch all trades made by the user
        * @param {string|undefined} symbol unified market symbol
        * @param {int|undefined} since the earliest time in ms to fetch trades for
        * @param {int|undefined} limit the maximum number of trades structures to retrieve
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {[object]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = null;
        object request = new Dictionary<string, object>() {};
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["symbol"] = getValue(market, "id");
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["startTime"] = this.iso8601(since);
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit;
        }
        request = this.deepExtend(request, parameters);
        // why the hassle? urlencode in python is kinda broken for nested dicts.
        // E.g. self.urlencode({"filter": {"open": True}}) will return "filter={'open':+True}"
        // Bitmex doesn't like that. Hence resorting to this hack.
        if (isTrue(((Dictionary<string,object>)request).ContainsKey(toStringOrNull("filter"))))
        {
            ((Dictionary<string, object>)request)["filter"] = this.json(getValue(request, "filter"));
        }
        object response = await this.privateGetExecutionTradeHistory(request);
        //
        //     [
        //         {
        //             "execID": "string",
        //             "orderID": "string",
        //             "clOrdID": "string",
        //             "clOrdLinkID": "string",
        //             "account": 0,
        //             "symbol": "string",
        //             "side": "string",
        //             "lastQty": 0,
        //             "lastPx": 0,
        //             "underlyingLastPx": 0,
        //             "lastMkt": "string",
        //             "lastLiquidityInd": "string",
        //             "simpleOrderQty": 0,
        //             "orderQty": 0,
        //             "price": 0,
        //             "displayQty": 0,
        //             "stopPx": 0,
        //             "pegOffsetValue": 0,
        //             "pegPriceType": "string",
        //             "currency": "string",
        //             "settlCurrency": "string",
        //             "execType": "string",
        //             "ordType": "string",
        //             "timeInForce": "string",
        //             "execInst": "string",
        //             "contingencyType": "string",
        //             "exDestination": "string",
        //             "ordStatus": "string",
        //             "triggered": "string",
        //             "workingIndicator": true,
        //             "ordRejReason": "string",
        //             "simpleLeavesQty": 0,
        //             "leavesQty": 0,
        //             "simpleCumQty": 0,
        //             "cumQty": 0,
        //             "avgPx": 0,
        //             "commission": 0,
        //             "tradePublishIndicator": "string",
        //             "multiLegReportingType": "string",
        //             "text": "string",
        //             "trdMatchID": "string",
        //             "execCost": 0,
        //             "execComm": 0,
        //             "homeNotional": 0,
        //             "foreignNotional": 0,
        //             "transactTime": "2019-03-05T12:47:02.762Z",
        //             "timestamp": "2019-03-05T12:47:02.762Z"
        //         }
        //     ]
        //
        return this.parseTrades(response, market, since, limit);
    }

    public virtual object parseLedgerEntryType(object type)
    {
        object types = new Dictionary<string, object>() {
            { "Withdrawal", "transaction" },
            { "RealisedPNL", "margin" },
            { "UnrealisedPNL", "margin" },
            { "Deposit", "transaction" },
            { "Transfer", "transfer" },
            { "AffiliatePayout", "referral" },
        };
        return this.safeString(types, type, type);
    }

    public override object parseLedgerEntry(object item, object currency = null)
    {
        //
        //     {
        //         transactID: "69573da3-7744-5467-3207-89fd6efe7a47",
        //         account:  24321,
        //         currency: "XBt",
        //         transactType: "Withdrawal", // "AffiliatePayout", "Transfer", "Deposit", "RealisedPNL", ...
        //         amount:  -1000000,
        //         fee:  300000,
        //         transactStatus: "Completed", // "Canceled", ...
        //         address: "1Ex4fkF4NhQaQdRWNoYpqiPbDBbq18Kdd9",
        //         tx: "3BMEX91ZhhKoWtsH9QRb5dNXnmnGpiEetA",
        //         text: "",
        //         transactTime: "2017-03-21T20:05:14.388Z",
        //         walletBalance:  0, // balance after
        //         marginBalance:  null,
        //         timestamp: "2017-03-22T13:09:23.514Z"
        //     }
        //
        // ButMEX returns the unrealized pnl from the wallet history endpoint.
        // The unrealized pnl transaction has an empty timestamp.
        // It is not related to historical pnl it has status set to "Pending".
        // Therefore it's not a part of the history at all.
        // https://github.com/ccxt/ccxt/issues/6047
        //
        //     {
        //         "transactID":"00000000-0000-0000-0000-000000000000",
        //         "account":121210,
        //         "currency":"XBt",
        //         "transactType":"UnrealisedPNL",
        //         "amount":-5508,
        //         "fee":0,
        //         "transactStatus":"Pending",
        //         "address":"XBTUSD",
        //         "tx":"",
        //         "text":"",
        //         "transactTime":null,  # ←---------------------------- null
        //         "walletBalance":139198767,
        //         "marginBalance":139193259,
        //         "timestamp":null  # ←---------------------------- null
        //     }
        //
        object id = this.safeString(item, "transactID");
        object account = this.safeString(item, "account");
        object referenceId = this.safeString(item, "tx");
        object referenceAccount = null;
        object type = this.parseLedgerEntryType(this.safeString(item, "transactType"));
        object currencyId = this.safeString(item, "currency");
        object code = this.safeCurrencyCode(currencyId, currency);
        object amount = this.safeNumber(item, "amount");
        if (isTrue(!isEqual(amount, null)))
        {
            amount = divide(amount, 100000000);
        }
        object timestamp = this.parse8601(this.safeString(item, "transactTime"));
        if (isTrue(isEqual(timestamp, null)))
        {
            // https://github.com/ccxt/ccxt/issues/6047
            // set the timestamp to zero, 1970 Jan 1 00:00:00
            // for unrealized pnl and other transactions without a timestamp
            timestamp = 0; // see comments above
        }
        object feeCost = this.safeNumber(item, "fee", 0);
        if (isTrue(!isEqual(feeCost, null)))
        {
            feeCost = divide(feeCost, 100000000);
        }
        object fee = new Dictionary<string, object>() {
            { "cost", feeCost },
            { "currency", code },
        };
        object after = this.safeNumber(item, "walletBalance");
        if (isTrue(!isEqual(after, null)))
        {
            after = divide(after, 100000000);
        }
        object before = this.sum(after, prefixUnaryNeg(ref amount));
        object direction = null;
        if (isTrue(isLessThan(amount, 0)))
        {
            direction = "out";
            amount = Math.Abs((double)amount);
        } else
        {
            direction = "in";
        }
        object status = this.parseTransactionStatus(this.safeString(item, "transactStatus"));
        return new Dictionary<string, object>() {
            { "id", id },
            { "info", item },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "direction", direction },
            { "account", account },
            { "referenceId", referenceId },
            { "referenceAccount", referenceAccount },
            { "type", type },
            { "currency", code },
            { "amount", amount },
            { "before", before },
            { "after", after },
            { "status", status },
            { "fee", fee },
        };
    }

    public async virtual Task<object> fetchLedger(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchLedger
        * @description fetch the history of changes, actions done by the user or operations that altered balance of the user
        * @param {string|undefined} code unified currency code, default is undefined
        * @param {int|undefined} since timestamp in ms of the earliest ledger entry, default is undefined
        * @param {int|undefined} limit max number of ledger entrys to return, default is undefined
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} a [ledger structure]{@link https://docs.ccxt.com/#/?id=ledger-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object currency = null;
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
        }
        object request = new Dictionary<string, object>() {};
        //
        //     if (since !== undefined) {
        //         // date-based pagination not supported
        //     }
        //
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit;
        }
        object response = await this.privateGetUserWalletHistory(this.extend(request, parameters));
        //
        //     [
        //         {
        //             transactID: "69573da3-7744-5467-3207-89fd6efe7a47",
        //             account:  24321,
        //             currency: "XBt",
        //             transactType: "Withdrawal", // "AffiliatePayout", "Transfer", "Deposit", "RealisedPNL", ...
        //             amount:  -1000000,
        //             fee:  300000,
        //             transactStatus: "Completed", // "Canceled", ...
        //             address: "1Ex4fkF4NhQaQdRWNoYpqiPbDBbq18Kdd9",
        //             tx: "3BMEX91ZhhKoWtsH9QRb5dNXnmnGpiEetA",
        //             text: "",
        //             transactTime: "2017-03-21T20:05:14.388Z",
        //             walletBalance:  0, // balance after
        //             marginBalance:  null,
        //             timestamp: "2017-03-22T13:09:23.514Z"
        //         }
        //     ]
        //
        return this.parseLedger(response, currency, since, limit);
    }

    public async override Task<object> fetchTransactions(object code = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchTransactions
        * @description fetch history of deposits and withdrawals
        * @param {string|undefined} code unified currency code for the currency of the transactions, default is undefined
        * @param {int|undefined} since timestamp in ms of the earliest transaction, default is undefined
        * @param {int|undefined} limit max number of transactions to return, default is undefined
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} a list of [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {
            { "currency", "all" },
        };
        //
        //     if (since !== undefined) {
        //         // date-based pagination not supported
        //     }
        //
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit;
        }
        object response = await this.privateGetUserWalletHistory(this.extend(request, parameters));
        object transactions = this.filterByArray(response, "transactType", new List<object>() {"Withdrawal", "Deposit"}, false);
        object currency = null;
        if (isTrue(!isEqual(code, null)))
        {
            currency = this.currency(code);
        }
        return this.parseTransactions(transactions, currency, since, limit);
    }

    public virtual object parseTransactionStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "Canceled", "canceled" },
            { "Completed", "ok" },
            { "Pending", "pending" },
        };
        return this.safeString(statuses, status, status);
    }

    public override object parseTransaction(object transaction, object currency = null)
    {
        //
        //    {
        //        'transactID': 'ffe699c2-95ee-4c13-91f9-0faf41daec25',
        //        'account': 123456,
        //        'currency': 'XBt',
        //        'network':'',
        //        'transactType': 'Withdrawal',
        //        'amount': -100100000,
        //        'fee': 100000,
        //        'transactStatus': 'Completed',
        //        'address': '385cR5DM96n1HvBDMzLHPYcw89fZAXULJP',
        //        'tx': '3BMEXabcdefghijklmnopqrstuvwxyz123',
        //        'text': '',
        //        'transactTime': '2019-01-02T01:00:00.000Z',
        //        'walletBalance': 99900000,
        //        'marginBalance': None,
        //        'timestamp': '2019-01-02T13:00:00.000Z'
        //    }
        //
        object currencyId = this.safeString(transaction, "currency");
        currency = this.safeCurrency(currencyId, currency);
        // For deposits, transactTime == timestamp
        // For withdrawals, transactTime is submission, timestamp is processed
        object transactTime = this.parse8601(this.safeString(transaction, "transactTime"));
        object timestamp = this.parse8601(this.safeString(transaction, "timestamp"));
        object type = this.safeStringLower(transaction, "transactType");
        // Deposits have no from address or to address, withdrawals have both
        object address = null;
        object addressFrom = null;
        object addressTo = null;
        if (isTrue(isEqual(type, "withdrawal")))
        {
            address = this.safeString(transaction, "address");
            addressFrom = this.safeString(transaction, "tx");
            addressTo = address;
        }
        object amountString = this.safeString(transaction, "amount");
        object scale = ((bool) isTrue((isEqual(getValue(currency, "code"), "BTC")))) ? "1e8" : "1e6";
        amountString = Precise.stringDiv(Precise.stringAbs(amountString), scale);
        object feeCostString = this.safeString(transaction, "fee");
        feeCostString = Precise.stringDiv(feeCostString, scale);
        object status = this.safeString(transaction, "transactStatus");
        if (isTrue(!isEqual(status, null)))
        {
            status = this.parseTransactionStatus(status);
        }
        return new Dictionary<string, object>() {
            { "info", transaction },
            { "id", this.safeString(transaction, "transactID") },
            { "txid", this.safeString(transaction, "tx") },
            { "type", type },
            { "currency", getValue(currency, "code") },
            { "network", this.safeString(transaction, "status") },
            { "amount", this.parseNumber(amountString) },
            { "status", status },
            { "timestamp", transactTime },
            { "datetime", this.iso8601(transactTime) },
            { "address", address },
            { "addressFrom", addressFrom },
            { "addressTo", addressTo },
            { "tag", null },
            { "tagFrom", null },
            { "tagTo", null },
            { "updated", timestamp },
            { "comment", null },
            { "fee", new Dictionary<string, object>() {
                { "currency", getValue(currency, "code") },
                { "cost", this.parseNumber(feeCostString) },
                { "rate", null },
            } },
        };
    }

    public async override Task<object> fetchTicker(object symbol, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchTicker
        * @description fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
        * @param {string} symbol unified symbol of the market to fetch the ticker for
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object tickers = await this.fetchTickers(new List<object>() {getValue(market, "symbol")}, parameters);
        object ticker = this.safeValue(tickers, getValue(market, "symbol"));
        if (isTrue(isEqual(ticker, null)))
        {
            throw new BadSymbol ((string)add(add(add(this.id, " fetchTicker() symbol "), symbol), " not found")) ;
        }
        return ticker;
    }

    public async override Task<object> fetchTickers(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchTickers
        * @description fetches price tickers for multiple markets, statistical calculations with the information calculated over the past 24 hours each market
        * @param {[string]|undefined} symbols unified symbols of the markets to fetch the ticker for, all market tickers are returned if not assigned
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} a dictionary of [ticker structures]{@link https://docs.ccxt.com/#/?id=ticker-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        symbols = this.marketSymbols(symbols);
        object response = await this.publicGetInstrumentActiveAndIndices(parameters);
        //
        //     [
        //         {
        //             "symbol":".EVOL7D",
        //             "rootSymbol":"EVOL",
        //             "state":"Unlisted",
        //             "typ":"MRIXXX",
        //             "listing":null,
        //             "front":null,
        //             "expiry":null,
        //             "settle":null,
        //             "listedSettle":null,
        //             "relistInterval":null,
        //             "inverseLeg":"",
        //             "sellLeg":"",
        //             "buyLeg":"",
        //             "optionStrikePcnt":null,
        //             "optionStrikeRound":null,
        //             "optionStrikePrice":null,
        //             "optionMultiplier":null,
        //             "positionCurrency":"",
        //             "underlying":"ETH",
        //             "quoteCurrency":"XXX",
        //             "underlyingSymbol":".EVOL7D",
        //             "reference":"BMI",
        //             "referenceSymbol":".BETHXBT",
        //             "calcInterval":"2000-01-08T00:00:00.000Z",
        //             "publishInterval":"2000-01-01T00:05:00.000Z",
        //             "publishTime":null,
        //             "maxOrderQty":null,
        //             "maxPrice":null,
        //             "lotSize":null,
        //             "tickSize":0.01,
        //             "multiplier":null,
        //             "settlCurrency":"",
        //             "underlyingToPositionMultiplier":null,
        //             "underlyingToSettleMultiplier":null,
        //             "quoteToSettleMultiplier":null,
        //             "isQuanto":false,
        //             "isInverse":false,
        //             "initMargin":null,
        //             "maintMargin":null,
        //             "riskLimit":null,
        //             "riskStep":null,
        //             "limit":null,
        //             "capped":false,
        //             "taxed":false,
        //             "deleverage":false,
        //             "makerFee":null,
        //             "takerFee":null,
        //             "settlementFee":null,
        //             "insuranceFee":null,
        //             "fundingBaseSymbol":"",
        //             "fundingQuoteSymbol":"",
        //             "fundingPremiumSymbol":"",
        //             "fundingTimestamp":null,
        //             "fundingInterval":null,
        //             "fundingRate":null,
        //             "indicativeFundingRate":null,
        //             "rebalanceTimestamp":null,
        //             "rebalanceInterval":null,
        //             "openingTimestamp":null,
        //             "closingTimestamp":null,
        //             "sessionInterval":null,
        //             "prevClosePrice":null,
        //             "limitDownPrice":null,
        //             "limitUpPrice":null,
        //             "bankruptLimitDownPrice":null,
        //             "bankruptLimitUpPrice":null,
        //             "prevTotalVolume":null,
        //             "totalVolume":null,
        //             "volume":null,
        //             "volume24h":null,
        //             "prevTotalTurnover":null,
        //             "totalTurnover":null,
        //             "turnover":null,
        //             "turnover24h":null,
        //             "homeNotional24h":null,
        //             "foreignNotional24h":null,
        //             "prevPrice24h":5.27,
        //             "vwap":null,
        //             "highPrice":null,
        //             "lowPrice":null,
        //             "lastPrice":4.72,
        //             "lastPriceProtected":null,
        //             "lastTickDirection":"ZeroMinusTick",
        //             "lastChangePcnt":-0.1044,
        //             "bidPrice":null,
        //             "midPrice":null,
        //             "askPrice":null,
        //             "impactBidPrice":null,
        //             "impactMidPrice":null,
        //             "impactAskPrice":null,
        //             "hasLiquidity":false,
        //             "openInterest":null,
        //             "openValue":0,
        //             "fairMethod":"",
        //             "fairBasisRate":null,
        //             "fairBasis":null,
        //             "fairPrice":null,
        //             "markMethod":"LastPrice",
        //             "markPrice":4.72,
        //             "indicativeTaxRate":null,
        //             "indicativeSettlePrice":null,
        //             "optionUnderlyingPrice":null,
        //             "settledPriceAdjustmentRate":null,
        //             "settledPrice":null,
        //             "timestamp":"2022-05-21T04:30:00.000Z"
        //         }
        //     ]
        //
        object result = new Dictionary<string, object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object ticker = this.parseTicker(getValue(response, i));
            object symbol = this.safeString(ticker, "symbol");
            if (isTrue(!isEqual(symbol, null)))
            {
                ((Dictionary<string, object>)result)[(string)symbol] = ticker;
            }
        }
        return this.filterByArray(result, "symbol", symbols);
    }

    public override object parseTicker(object ticker, object market = null)
    {
        //
        //     {                         symbol: "ETHH19",
        //                           rootSymbol: "ETH",
        //                                state: "Open",
        //                                  typ: "FFCCSX",
        //                              listing: "2018-12-17T04:00:00.000Z",
        //                                front: "2019-02-22T12:00:00.000Z",
        //                               expiry: "2019-03-29T12:00:00.000Z",
        //                               settle: "2019-03-29T12:00:00.000Z",
        //                       relistInterval:  null,
        //                           inverseLeg: "",
        //                              sellLeg: "",
        //                               buyLeg: "",
        //                     optionStrikePcnt:  null,
        //                    optionStrikeRound:  null,
        //                    optionStrikePrice:  null,
        //                     optionMultiplier:  null,
        //                     positionCurrency: "ETH",
        //                           underlying: "ETH",
        //                        quoteCurrency: "XBT",
        //                     underlyingSymbol: "ETHXBT=",
        //                            reference: "BMEX",
        //                      referenceSymbol: ".BETHXBT30M",
        //                         calcInterval:  null,
        //                      publishInterval:  null,
        //                          publishTime:  null,
        //                          maxOrderQty:  100000000,
        //                             maxPrice:  10,
        //                              lotSize:  1,
        //                             tickSize:  0.00001,
        //                           multiplier:  100000000,
        //                        settlCurrency: "XBt",
        //       underlyingToPositionMultiplier:  1,
        //         underlyingToSettleMultiplier:  null,
        //              quoteToSettleMultiplier:  100000000,
        //                             isQuanto:  false,
        //                            isInverse:  false,
        //                           initMargin:  0.02,
        //                          maintMargin:  0.01,
        //                            riskLimit:  5000000000,
        //                             riskStep:  5000000000,
        //                                limit:  null,
        //                               capped:  false,
        //                                taxed:  true,
        //                           deleverage:  true,
        //                             makerFee:  -0.0005,
        //                             takerFee:  0.0025,
        //                        settlementFee:  0,
        //                         insuranceFee:  0,
        //                    fundingBaseSymbol: "",
        //                   fundingQuoteSymbol: "",
        //                 fundingPremiumSymbol: "",
        //                     fundingTimestamp:  null,
        //                      fundingInterval:  null,
        //                          fundingRate:  null,
        //                indicativeFundingRate:  null,
        //                   rebalanceTimestamp:  null,
        //                    rebalanceInterval:  null,
        //                     openingTimestamp: "2019-02-13T08:00:00.000Z",
        //                     closingTimestamp: "2019-02-13T09:00:00.000Z",
        //                      sessionInterval: "2000-01-01T01:00:00.000Z",
        //                       prevClosePrice:  0.03347,
        //                       limitDownPrice:  null,
        //                         limitUpPrice:  null,
        //               bankruptLimitDownPrice:  null,
        //                 bankruptLimitUpPrice:  null,
        //                      prevTotalVolume:  1386531,
        //                          totalVolume:  1387062,
        //                               volume:  531,
        //                            volume24h:  17118,
        //                    prevTotalTurnover:  4741294246000,
        //                        totalTurnover:  4743103466000,
        //                             turnover:  1809220000,
        //                          turnover24h:  57919845000,
        //                      homeNotional24h:  17118,
        //                   foreignNotional24h:  579.19845,
        //                         prevPrice24h:  0.03349,
        //                                 vwap:  0.03383564,
        //                            highPrice:  0.03458,
        //                             lowPrice:  0.03329,
        //                            lastPrice:  0.03406,
        //                   lastPriceProtected:  0.03406,
        //                    lastTickDirection: "ZeroMinusTick",
        //                       lastChangePcnt:  0.017,
        //                             bidPrice:  0.03406,
        //                             midPrice:  0.034065,
        //                             askPrice:  0.03407,
        //                       impactBidPrice:  0.03406,
        //                       impactMidPrice:  0.034065,
        //                       impactAskPrice:  0.03407,
        //                         hasLiquidity:  true,
        //                         openInterest:  83679,
        //                            openValue:  285010674000,
        //                           fairMethod: "ImpactMidPrice",
        //                        fairBasisRate:  0,
        //                            fairBasis:  0,
        //                            fairPrice:  0.03406,
        //                           markMethod: "FairPrice",
        //                            markPrice:  0.03406,
        //                    indicativeTaxRate:  0,
        //                indicativeSettlePrice:  0.03406,
        //                optionUnderlyingPrice:  null,
        //                         settledPrice:  null,
        //                            timestamp: "2019-02-13T08:40:30.000Z",
        //     }
        //
        object marketId = this.safeString(ticker, "symbol");
        object symbol = this.safeSymbol(marketId, market);
        object timestamp = this.parse8601(this.safeString(ticker, "timestamp"));
        object open = this.safeString(ticker, "prevPrice24h");
        object last = this.safeString(ticker, "lastPrice");
        return this.safeTicker(new Dictionary<string, object>() {
            { "symbol", symbol },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "high", this.safeString(ticker, "highPrice") },
            { "low", this.safeString(ticker, "lowPrice") },
            { "bid", this.safeString(ticker, "bidPrice") },
            { "bidVolume", null },
            { "ask", this.safeString(ticker, "askPrice") },
            { "askVolume", null },
            { "vwap", this.safeString(ticker, "vwap") },
            { "open", open },
            { "close", last },
            { "last", last },
            { "previousClose", null },
            { "change", null },
            { "percentage", null },
            { "average", null },
            { "baseVolume", this.safeString(ticker, "homeNotional24h") },
            { "quoteVolume", this.safeString(ticker, "foreignNotional24h") },
            { "info", ticker },
        }, market);
    }

    public override object parseOHLCV(object ohlcv, object market = null)
    {
        //
        //     {
        //         "timestamp":"2015-09-25T13:38:00.000Z",
        //         "symbol":"XBTUSD",
        //         "open":237.45,
        //         "high":237.45,
        //         "low":237.45,
        //         "close":237.45,
        //         "trades":0,
        //         "volume":0,
        //         "vwap":null,
        //         "lastSize":null,
        //         "turnover":0,
        //         "homeNotional":0,
        //         "foreignNotional":0
        //     }
        //
        return new List<object> {this.parse8601(this.safeString(ohlcv, "timestamp")), this.safeNumber(ohlcv, "open"), this.safeNumber(ohlcv, "high"), this.safeNumber(ohlcv, "low"), this.safeNumber(ohlcv, "close"), this.safeNumber(ohlcv, "volume")};
    }

    public async override Task<object> fetchOHLCV(object symbol, object timeframe = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchOHLCV
        * @description fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
        * @param {string} symbol unified symbol of the market to fetch OHLCV data for
        * @param {string} timeframe the length of time each candle represents
        * @param {int|undefined} since timestamp in ms of the earliest candle to fetch
        * @param {int|undefined} limit the maximum amount of candles to fetch
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {[[int]]} A list of candles ordered as timestamp, open, high, low, close, volume
        */
        timeframe ??= "1m";
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        // send JSON key/value pairs, such as {"key": "value"}
        // filter by individual fields and do advanced queries on timestamps
        // let filter = { 'key': 'value' };
        // send a bare series (e.g. XBU) to nearest expiring contract in that series
        // you can also send a timeframe, e.g. XBU:monthly
        // timeframes: daily, weekly, monthly, quarterly, and biquarterly
        object market = this.market(symbol);
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "binSize", this.safeString(this.timeframes, timeframe, timeframe) },
            { "partial", true },
        };
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit; // default 100, max 500
        }
        object duration = multiply(this.parseTimeframe(timeframe), 1000);
        object fetchOHLCVOpenTimestamp = this.safeValue(this.options, "fetchOHLCVOpenTimestamp", true);
        // if since is not set, they will return candles starting from 2017-01-01
        if (isTrue(!isEqual(since, null)))
        {
            object timestamp = since;
            if (isTrue(fetchOHLCVOpenTimestamp))
            {
                timestamp = this.sum(timestamp, duration);
            }
            object ymdhms = this.ymdhms(timestamp);
            ((Dictionary<string, object>)request)["startTime"] = ymdhms; // starting date filter for results
        } else
        {
            ((Dictionary<string, object>)request)["reverse"] = true;
        }
        object response = await this.publicGetTradeBucketed(this.extend(request, parameters));
        //
        //     [
        //         {"timestamp":"2015-09-25T13:38:00.000Z","symbol":"XBTUSD","open":237.45,"high":237.45,"low":237.45,"close":237.45,"trades":0,"volume":0,"vwap":null,"lastSize":null,"turnover":0,"homeNotional":0,"foreignNotional":0},
        //         {"timestamp":"2015-09-25T13:39:00.000Z","symbol":"XBTUSD","open":237.45,"high":237.45,"low":237.45,"close":237.45,"trades":0,"volume":0,"vwap":null,"lastSize":null,"turnover":0,"homeNotional":0,"foreignNotional":0},
        //         {"timestamp":"2015-09-25T13:40:00.000Z","symbol":"XBTUSD","open":237.45,"high":237.45,"low":237.45,"close":237.45,"trades":0,"volume":0,"vwap":null,"lastSize":null,"turnover":0,"homeNotional":0,"foreignNotional":0}
        //     ]
        //
        object result = this.parseOHLCVs(response, market, timeframe, since, limit);
        if (isTrue(fetchOHLCVOpenTimestamp))
        {
            // bitmex returns the candle's close timestamp - https://github.com/ccxt/ccxt/issues/4446
            // we can emulate the open timestamp by shifting all the timestamps one place
            // so the previous close becomes the current open, and we drop the first candle
            for (object i = 0; isLessThan(i, getArrayLength(result)); postFixIncrement(ref i))
            {
                ((List<object>)getValue(result, i))[(int)0] = subtract(getValue(getValue(result, i), 0), duration);
            }
        }
        return result;
    }

    public override object parseTrade(object trade, object market = null)
    {
        //
        // fetchTrades (public)
        //
        //     {
        //         timestamp: '2018-08-28T00:00:02.735Z',
        //         symbol: 'XBTUSD',
        //         side: 'Buy',
        //         size: 2000,
        //         price: 6906.5,
        //         tickDirection: 'PlusTick',
        //         trdMatchID: 'b9a42432-0a46-6a2f-5ecc-c32e9ca4baf8',
        //         grossValue: 28958000,
        //         homeNotional: 0.28958,
        //         foreignNotional: 2000
        //     }
        //
        // fetchMyTrades (private)
        //
        //     {
        //         "execID": "string",
        //         "orderID": "string",
        //         "clOrdID": "string",
        //         "clOrdLinkID": "string",
        //         "account": 0,
        //         "symbol": "string",
        //         "side": "string",
        //         "lastQty": 0,
        //         "lastPx": 0,
        //         "underlyingLastPx": 0,
        //         "lastMkt": "string",
        //         "lastLiquidityInd": "string",
        //         "simpleOrderQty": 0,
        //         "orderQty": 0,
        //         "price": 0,
        //         "displayQty": 0,
        //         "stopPx": 0,
        //         "pegOffsetValue": 0,
        //         "pegPriceType": "string",
        //         "currency": "string",
        //         "settlCurrency": "string",
        //         "execType": "string",
        //         "ordType": "string",
        //         "timeInForce": "string",
        //         "execInst": "string",
        //         "contingencyType": "string",
        //         "exDestination": "string",
        //         "ordStatus": "string",
        //         "triggered": "string",
        //         "workingIndicator": true,
        //         "ordRejReason": "string",
        //         "simpleLeavesQty": 0,
        //         "leavesQty": 0,
        //         "simpleCumQty": 0,
        //         "cumQty": 0,
        //         "avgPx": 0,
        //         "commission": 0,
        //         "tradePublishIndicator": "string",
        //         "multiLegReportingType": "string",
        //         "text": "string",
        //         "trdMatchID": "string",
        //         "execCost": 0,
        //         "execComm": 0,
        //         "homeNotional": 0,
        //         "foreignNotional": 0,
        //         "transactTime": "2019-03-05T12:47:02.762Z",
        //         "timestamp": "2019-03-05T12:47:02.762Z"
        //     }
        //
        object timestamp = this.parse8601(this.safeString(trade, "timestamp"));
        object priceString = this.safeString2(trade, "avgPx", "price");
        object amountString = this.safeString2(trade, "size", "lastQty");
        object execCost = this.safeString(trade, "execCost");
        object costString = Precise.stringDiv(Precise.stringAbs(execCost), "1e8");
        object id = this.safeString(trade, "trdMatchID");
        object order = this.safeString(trade, "orderID");
        object side = this.safeStringLower(trade, "side");
        // price * amount doesn't work for all symbols (e.g. XBT, ETH)
        object fee = null;
        object feeCostString = Precise.stringDiv(this.safeString(trade, "execComm"), "1e8");
        if (isTrue(!isEqual(feeCostString, null)))
        {
            object currencyId = this.safeString(trade, "settlCurrency");
            object feeCurrencyCode = this.safeCurrencyCode(currencyId);
            object feeRateString = this.safeString(trade, "commission");
            fee = new Dictionary<string, object>() {
                { "cost", feeCostString },
                { "currency", feeCurrencyCode },
                { "rate", feeRateString },
            };
        }
        // Trade or Funding
        object execType = this.safeString(trade, "execType");
        object takerOrMaker = null;
        if (isTrue(isTrue(!isEqual(feeCostString, null)) && isTrue(isEqual(execType, "Trade"))))
        {
            takerOrMaker = ((bool) isTrue(Precise.stringLt(feeCostString, "0"))) ? "maker" : "taker";
        }
        object marketId = this.safeString(trade, "symbol");
        object symbol = this.safeSymbol(marketId, market);
        object type = this.safeStringLower(trade, "ordType");
        return this.safeTrade(new Dictionary<string, object>() {
            { "info", trade },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "symbol", symbol },
            { "id", id },
            { "order", order },
            { "type", type },
            { "takerOrMaker", takerOrMaker },
            { "side", side },
            { "price", priceString },
            { "cost", costString },
            { "amount", amountString },
            { "fee", fee },
        }, market);
    }

    public virtual object parseOrderStatus(object status)
    {
        object statuses = new Dictionary<string, object>() {
            { "New", "open" },
            { "PartiallyFilled", "open" },
            { "Filled", "closed" },
            { "DoneForDay", "open" },
            { "Canceled", "canceled" },
            { "PendingCancel", "open" },
            { "PendingNew", "open" },
            { "Rejected", "rejected" },
            { "Expired", "expired" },
            { "Stopped", "open" },
            { "Untriggered", "open" },
            { "Triggered", "open" },
        };
        return this.safeString(statuses, status, status);
    }

    public virtual object parseTimeInForce(object timeInForce)
    {
        object timeInForces = new Dictionary<string, object>() {
            { "Day", "Day" },
            { "GoodTillCancel", "GTC" },
            { "ImmediateOrCancel", "IOC" },
            { "FillOrKill", "FOK" },
        };
        return this.safeString(timeInForces, timeInForce, timeInForce);
    }

    public override object parseOrder(object order, object market = null)
    {
        //
        //     {
        //         "orderID":"56222c7a-9956-413a-82cf-99f4812c214b",
        //         "clOrdID":"",
        //         "clOrdLinkID":"",
        //         "account":1455728,
        //         "symbol":"XBTUSD",
        //         "side":"Sell",
        //         "simpleOrderQty":null,
        //         "orderQty":1,
        //         "price":40000,
        //         "displayQty":null,
        //         "stopPx":null,
        //         "pegOffsetValue":null,
        //         "pegPriceType":"",
        //         "currency":"USD",
        //         "settlCurrency":"XBt",
        //         "ordType":"Limit",
        //         "timeInForce":"GoodTillCancel",
        //         "execInst":"",
        //         "contingencyType":"",
        //         "exDestination":"XBME",
        //         "ordStatus":"New",
        //         "triggered":"",
        //         "workingIndicator":true,
        //         "ordRejReason":"",
        //         "simpleLeavesQty":null,
        //         "leavesQty":1,
        //         "simpleCumQty":null,
        //         "cumQty":0,
        //         "avgPx":null,
        //         "multiLegReportingType":"SingleSecurity",
        //         "text":"Submitted via API.",
        //         "transactTime":"2021-01-02T21:38:49.246Z",
        //         "timestamp":"2021-01-02T21:38:49.246Z"
        //     }
        //
        object status = this.parseOrderStatus(this.safeString(order, "ordStatus"));
        object marketId = this.safeString(order, "symbol");
        object symbol = this.safeSymbol(marketId, market);
        object timestamp = this.parse8601(this.safeString(order, "timestamp"));
        object lastTradeTimestamp = this.parse8601(this.safeString(order, "transactTime"));
        object price = this.safeString(order, "price");
        object amount = this.safeString(order, "orderQty");
        object filled = this.safeString(order, "cumQty");
        object average = this.safeString(order, "avgPx");
        object id = this.safeString(order, "orderID");
        object type = this.safeStringLower(order, "ordType");
        object side = this.safeStringLower(order, "side");
        object clientOrderId = this.safeString(order, "clOrdID");
        object timeInForce = this.parseTimeInForce(this.safeString(order, "timeInForce"));
        object stopPrice = this.safeNumber(order, "stopPx");
        object execInst = this.safeString(order, "execInst");
        object postOnly = null;
        if (isTrue(!isEqual(execInst, null)))
        {
            postOnly = (isEqual(execInst, "ParticipateDoNotInitiate"));
        }
        return this.safeOrder(new Dictionary<string, object>() {
            { "info", order },
            { "id", id },
            { "clientOrderId", clientOrderId },
            { "timestamp", timestamp },
            { "datetime", this.iso8601(timestamp) },
            { "lastTradeTimestamp", lastTradeTimestamp },
            { "symbol", symbol },
            { "type", type },
            { "timeInForce", timeInForce },
            { "postOnly", postOnly },
            { "side", side },
            { "price", price },
            { "stopPrice", stopPrice },
            { "triggerPrice", stopPrice },
            { "amount", amount },
            { "cost", null },
            { "average", average },
            { "filled", filled },
            { "remaining", null },
            { "status", status },
            { "fee", null },
            { "trades", null },
        }, market);
    }

    public async override Task<object> fetchTrades(object symbol, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchTrades
        * @description get the list of most recent trades for a particular symbol
        * @param {string} symbol unified symbol of the market to fetch trades for
        * @param {int|undefined} since timestamp in ms of the earliest trade to fetch
        * @param {int|undefined} limit the maximum amount of trades to fetch
        * @param {object} params extra parameters specific to the bitmex api endpoint
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
            ((Dictionary<string, object>)request)["startTime"] = this.iso8601(since);
        } else
        {
            // by default reverse=false, i.e. trades are fetched since the time of market inception (year 2015 for XBTUSD)
            ((Dictionary<string, object>)request)["reverse"] = true;
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit;
        }
        object response = await this.publicGetTrade(this.extend(request, parameters));
        //
        //     [
        //         {
        //             timestamp: '2018-08-28T00:00:02.735Z',
        //             symbol: 'XBTUSD',
        //             side: 'Buy',
        //             size: 2000,
        //             price: 6906.5,
        //             tickDirection: 'PlusTick',
        //             trdMatchID: 'b9a42432-0a46-6a2f-5ecc-c32e9ca4baf8',
        //             grossValue: 28958000,
        //             homeNotional: 0.28958,
        //             foreignNotional: 2000
        //         },
        //         {
        //             timestamp: '2018-08-28T00:00:03.778Z',
        //             symbol: 'XBTUSD',
        //             side: 'Sell',
        //             size: 1000,
        //             price: 6906,
        //             tickDirection: 'MinusTick',
        //             trdMatchID: '0d4f1682-5270-a800-569b-4a0eb92db97c',
        //             grossValue: 14480000,
        //             homeNotional: 0.1448,
        //             foreignNotional: 1000
        //         },
        //     ]
        //
        return this.parseTrades(response, market, since, limit);
    }

    public async override Task<object> createOrder(object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#createOrder
        * @description create a trade order
        * @param {string} symbol unified symbol of the market to create an order in
        * @param {string} type 'market' or 'limit'
        * @param {string} side 'buy' or 'sell'
        * @param {float} amount how much of currency you want to trade in units of base currency
        * @param {float|undefined} price the price at which the order is to be fullfilled, in units of the quote currency, ignored in market orders
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object market = this.market(symbol);
        object orderType = this.capitalize(type);
        object reduceOnly = this.safeValue(parameters, "reduceOnly");
        if (isTrue(!isEqual(reduceOnly, null)))
        {
            if (isTrue(isTrue((!isEqual(getValue(market, "type"), "swap"))) && isTrue((!isEqual(getValue(market, "type"), "future")))))
            {
                throw new InvalidOrder ((string)add(add(add(this.id, " createOrder() does not support reduceOnly for "), getValue(market, "type")), " orders, reduceOnly orders are supported for swap and future markets only")) ;
            }
        }
        object brokerId = this.safeString(this.options, "brokerId", "CCXT");
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "side", this.capitalize(side) },
            { "orderQty", parseFloat(this.amountToPrecision(symbol, amount)) },
            { "ordType", orderType },
            { "text", brokerId },
        };
        if (isTrue(isTrue(isTrue(isTrue((isEqual(orderType, "Stop"))) || isTrue((isEqual(orderType, "StopLimit")))) || isTrue((isEqual(orderType, "MarketIfTouched")))) || isTrue((isEqual(orderType, "LimitIfTouched")))))
        {
            object stopPrice = this.safeNumber2(parameters, "stopPx", "stopPrice");
            if (isTrue(isEqual(stopPrice, null)))
            {
                throw new ArgumentsRequired ((string)add(add(add(this.id, " createOrder() requires a stopPx or stopPrice parameter for the "), orderType), " order type")) ;
            } else
            {
                ((Dictionary<string, object>)request)["stopPx"] = parseFloat(this.priceToPrecision(symbol, stopPrice));
                parameters = this.omit(parameters, new List<object>() {"stopPx", "stopPrice"});
            }
        }
        if (isTrue(isTrue(isTrue((isEqual(orderType, "Limit"))) || isTrue((isEqual(orderType, "StopLimit")))) || isTrue((isEqual(orderType, "LimitIfTouched")))))
        {
            ((Dictionary<string, object>)request)["price"] = parseFloat(this.priceToPrecision(symbol, price));
        }
        object clientOrderId = this.safeString2(parameters, "clOrdID", "clientOrderId");
        if (isTrue(!isEqual(clientOrderId, null)))
        {
            ((Dictionary<string, object>)request)["clOrdID"] = clientOrderId;
            parameters = this.omit(parameters, new List<object>() {"clOrdID", "clientOrderId"});
        }
        object response = await this.privatePostOrder(this.extend(request, parameters));
        return this.parseOrder(response, market);
    }

    public async override Task<object> editOrder(object id, object symbol, object type, object side, object amount, object price = null, object parameters = null)
    {
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object origClOrdID = this.safeString2(parameters, "origClOrdID", "clientOrderId");
        if (isTrue(!isEqual(origClOrdID, null)))
        {
            ((Dictionary<string, object>)request)["origClOrdID"] = origClOrdID;
            object clientOrderId = this.safeString(parameters, "clOrdID", "clientOrderId");
            if (isTrue(!isEqual(clientOrderId, null)))
            {
                ((Dictionary<string, object>)request)["clOrdID"] = clientOrderId;
            }
            parameters = this.omit(parameters, new List<object>() {"origClOrdID", "clOrdID", "clientOrderId"});
        } else
        {
            ((Dictionary<string, object>)request)["orderID"] = id;
        }
        if (isTrue(!isEqual(amount, null)))
        {
            ((Dictionary<string, object>)request)["orderQty"] = amount;
        }
        if (isTrue(!isEqual(price, null)))
        {
            ((Dictionary<string, object>)request)["price"] = price;
        }
        object brokerId = this.safeString(this.options, "brokerId", "CCXT");
        ((Dictionary<string, object>)request)["text"] = brokerId;
        object response = await this.privatePutOrder(this.extend(request, parameters));
        return this.parseOrder(response);
    }

    public async override Task<object> cancelOrder(object id, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#cancelOrder
        * @description cancels an open order
        * @param {string} id order id
        * @param {string|undefined} symbol not used by bitmex cancelOrder ()
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        // https://github.com/ccxt/ccxt/issues/6507
        object clientOrderId = this.safeValue2(parameters, "clOrdID", "clientOrderId");
        object request = new Dictionary<string, object>() {};
        if (isTrue(isEqual(clientOrderId, null)))
        {
            ((Dictionary<string, object>)request)["orderID"] = id;
        } else
        {
            ((Dictionary<string, object>)request)["clOrdID"] = clientOrderId;
            parameters = this.omit(parameters, new List<object>() {"clOrdID", "clientOrderId"});
        }
        object response = await this.privateDeleteOrder(this.extend(request, parameters));
        object order = this.safeValue(response, 0, new Dictionary<string, object>() {});
        object error = this.safeString(order, "error");
        if (isTrue(!isEqual(error, null)))
        {
            if (isTrue(isGreaterThanOrEqual(getIndexOf(error, "Unable to cancel order due to existing state"), 0)))
            {
                throw new OrderNotFound ((string)add(add(this.id, " cancelOrder() failed: "), error)) ;
            }
        }
        return this.parseOrder(order);
    }

    public async virtual Task<object> cancelOrders(object ids, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#cancelOrders
        * @description cancel multiple orders
        * @param {[string]} ids order ids
        * @param {string|undefined} symbol not used by bitmex cancelOrders ()
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} an list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        // return await this.cancelOrder (ids, symbol, params);
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        // https://github.com/ccxt/ccxt/issues/6507
        object clientOrderId = this.safeValue2(parameters, "clOrdID", "clientOrderId");
        object request = new Dictionary<string, object>() {};
        if (isTrue(isEqual(clientOrderId, null)))
        {
            ((Dictionary<string, object>)request)["orderID"] = ids;
        } else
        {
            ((Dictionary<string, object>)request)["clOrdID"] = clientOrderId;
            parameters = this.omit(parameters, new List<object>() {"clOrdID", "clientOrderId"});
        }
        object response = await this.privateDeleteOrder(this.extend(request, parameters));
        return this.parseOrders(response);
    }

    public async override Task<object> cancelAllOrders(object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#cancelAllOrders
        * @description cancel all open orders
        * @param {string|undefined} symbol unified market symbol, only orders in the market of this symbol are cancelled when symbol is not undefined
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {[object]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object market = null;
        if (isTrue(!isEqual(symbol, null)))
        {
            market = this.market(symbol);
            ((Dictionary<string, object>)request)["symbol"] = getValue(market, "id");
        }
        object response = await this.privateDeleteOrderAll(this.extend(request, parameters));
        //
        //     [
        //         {
        //             "orderID": "string",
        //             "clOrdID": "string",
        //             "clOrdLinkID": "string",
        //             "account": 0,
        //             "symbol": "string",
        //             "side": "string",
        //             "simpleOrderQty": 0,
        //             "orderQty": 0,
        //             "price": 0,
        //             "displayQty": 0,
        //             "stopPx": 0,
        //             "pegOffsetValue": 0,
        //             "pegPriceType": "string",
        //             "currency": "string",
        //             "settlCurrency": "string",
        //             "ordType": "string",
        //             "timeInForce": "string",
        //             "execInst": "string",
        //             "contingencyType": "string",
        //             "exDestination": "string",
        //             "ordStatus": "string",
        //             "triggered": "string",
        //             "workingIndicator": true,
        //             "ordRejReason": "string",
        //             "simpleLeavesQty": 0,
        //             "leavesQty": 0,
        //             "simpleCumQty": 0,
        //             "cumQty": 0,
        //             "avgPx": 0,
        //             "multiLegReportingType": "string",
        //             "text": "string",
        //             "transactTime": "2020-06-01T09:36:35.290Z",
        //             "timestamp": "2020-06-01T09:36:35.290Z"
        //         }
        //     ]
        //
        return this.parseOrders(response, market);
    }

    public async override Task<object> fetchPositions(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchPositions
        * @description fetch all open positions
        * @param {[string]|undefined} symbols list of unified market symbols
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {[object]} a list of [position structure]{@link https://docs.ccxt.com/#/?id=position-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.privateGetPosition(parameters);
        //
        //     [
        //         {
        //             "account": 0,
        //             "symbol": "string",
        //             "currency": "string",
        //             "underlying": "string",
        //             "quoteCurrency": "string",
        //             "commission": 0,
        //             "initMarginReq": 0,
        //             "maintMarginReq": 0,
        //             "riskLimit": 0,
        //             "leverage": 0,
        //             "crossMargin": true,
        //             "deleveragePercentile": 0,
        //             "rebalancedPnl": 0,
        //             "prevRealisedPnl": 0,
        //             "prevUnrealisedPnl": 0,
        //             "prevClosePrice": 0,
        //             "openingTimestamp": "2020-11-09T06:53:59.892Z",
        //             "openingQty": 0,
        //             "openingCost": 0,
        //             "openingComm": 0,
        //             "openOrderBuyQty": 0,
        //             "openOrderBuyCost": 0,
        //             "openOrderBuyPremium": 0,
        //             "openOrderSellQty": 0,
        //             "openOrderSellCost": 0,
        //             "openOrderSellPremium": 0,
        //             "execBuyQty": 0,
        //             "execBuyCost": 0,
        //             "execSellQty": 0,
        //             "execSellCost": 0,
        //             "execQty": 0,
        //             "execCost": 0,
        //             "execComm": 0,
        //             "currentTimestamp": "2020-11-09T06:53:59.893Z",
        //             "currentQty": 0,
        //             "currentCost": 0,
        //             "currentComm": 0,
        //             "realisedCost": 0,
        //             "unrealisedCost": 0,
        //             "grossOpenCost": 0,
        //             "grossOpenPremium": 0,
        //             "grossExecCost": 0,
        //             "isOpen": true,
        //             "markPrice": 0,
        //             "markValue": 0,
        //             "riskValue": 0,
        //             "homeNotional": 0,
        //             "foreignNotional": 0,
        //             "posState": "string",
        //             "posCost": 0,
        //             "posCost2": 0,
        //             "posCross": 0,
        //             "posInit": 0,
        //             "posComm": 0,
        //             "posLoss": 0,
        //             "posMargin": 0,
        //             "posMaint": 0,
        //             "posAllowance": 0,
        //             "taxableMargin": 0,
        //             "initMargin": 0,
        //             "maintMargin": 0,
        //             "sessionMargin": 0,
        //             "targetExcessMargin": 0,
        //             "varMargin": 0,
        //             "realisedGrossPnl": 0,
        //             "realisedTax": 0,
        //             "realisedPnl": 0,
        //             "unrealisedGrossPnl": 0,
        //             "longBankrupt": 0,
        //             "shortBankrupt": 0,
        //             "taxBase": 0,
        //             "indicativeTaxRate": 0,
        //             "indicativeTax": 0,
        //             "unrealisedTax": 0,
        //             "unrealisedPnl": 0,
        //             "unrealisedPnlPcnt": 0,
        //             "unrealisedRoePcnt": 0,
        //             "simpleQty": 0,
        //             "simpleCost": 0,
        //             "simpleValue": 0,
        //             "simplePnl": 0,
        //             "simplePnlPcnt": 0,
        //             "avgCostPrice": 0,
        //             "avgEntryPrice": 0,
        //             "breakEvenPrice": 0,
        //             "marginCallPrice": 0,
        //             "liquidationPrice": 0,
        //             "bankruptPrice": 0,
        //             "timestamp": "2020-11-09T06:53:59.894Z",
        //             "lastPrice": 0,
        //             "lastValue": 0
        //         }
        //     ]
        //
        return this.parsePositions(response, symbols);
    }

    public override object parsePosition(object position, object market = null)
    {
        //
        //     {
        //         "account": 9371654,
        //         "symbol": "ETHUSDT",
        //         "currency": "USDt",
        //         "underlying": "ETH",
        //         "quoteCurrency": "USDT",
        //         "commission": 0.00075,
        //         "initMarginReq": 0.3333333333333333,
        //         "maintMarginReq": 0.01,
        //         "riskLimit": 1000000000000,
        //         "leverage": 3,
        //         "crossMargin": false,
        //         "deleveragePercentile": 1,
        //         "rebalancedPnl": 0,
        //         "prevRealisedPnl": 0,
        //         "prevUnrealisedPnl": 0,
        //         "prevClosePrice": 2053.738,
        //         "openingTimestamp": "2022-05-21T04:00:00.000Z",
        //         "openingQty": 0,
        //         "openingCost": 0,
        //         "openingComm": 0,
        //         "openOrderBuyQty": 0,
        //         "openOrderBuyCost": 0,
        //         "openOrderBuyPremium": 0,
        //         "openOrderSellQty": 0,
        //         "openOrderSellCost": 0,
        //         "openOrderSellPremium": 0,
        //         "execBuyQty": 2000,
        //         "execBuyCost": 39260000,
        //         "execSellQty": 0,
        //         "execSellCost": 0,
        //         "execQty": 2000,
        //         "execCost": 39260000,
        //         "execComm": 26500,
        //         "currentTimestamp": "2022-05-21T04:35:16.397Z",
        //         "currentQty": 2000,
        //         "currentCost": 39260000,
        //         "currentComm": 26500,
        //         "realisedCost": 0,
        //         "unrealisedCost": 39260000,
        //         "grossOpenCost": 0,
        //         "grossOpenPremium": 0,
        //         "grossExecCost": 39260000,
        //         "isOpen": true,
        //         "markPrice": 1964.195,
        //         "markValue": 39283900,
        //         "riskValue": 39283900,
        //         "homeNotional": 0.02,
        //         "foreignNotional": -39.2839,
        //         "posState": "",
        //         "posCost": 39260000,
        //         "posCost2": 39260000,
        //         "posCross": 0,
        //         "posInit": 13086667,
        //         "posComm": 39261,
        //         "posLoss": 0,
        //         "posMargin": 13125928,
        //         "posMaint": 435787,
        //         "posAllowance": 0,
        //         "taxableMargin": 0,
        //         "initMargin": 0,
        //         "maintMargin": 13149828,
        //         "sessionMargin": 0,
        //         "targetExcessMargin": 0,
        //         "varMargin": 0,
        //         "realisedGrossPnl": 0,
        //         "realisedTax": 0,
        //         "realisedPnl": -26500,
        //         "unrealisedGrossPnl": 23900,
        //         "longBankrupt": 0,
        //         "shortBankrupt": 0,
        //         "taxBase": 0,
        //         "indicativeTaxRate": null,
        //         "indicativeTax": 0,
        //         "unrealisedTax": 0,
        //         "unrealisedPnl": 23900,
        //         "unrealisedPnlPcnt": 0.0006,
        //         "unrealisedRoePcnt": 0.0018,
        //         "simpleQty": null,
        //         "simpleCost": null,
        //         "simpleValue": null,
        //         "simplePnl": null,
        //         "simplePnlPcnt": null,
        //         "avgCostPrice": 1963,
        //         "avgEntryPrice": 1963,
        //         "breakEvenPrice": 1964.35,
        //         "marginCallPrice": 1328.5,
        //         "liquidationPrice": 1328.5,
        //         "bankruptPrice": 1308.7,
        //         "timestamp": "2022-05-21T04:35:16.397Z",
        //         "lastPrice": 1964.195,
        //         "lastValue": 39283900
        //     }
        //
        market = this.safeMarket(this.safeString(position, "symbol"), market);
        object symbol = getValue(market, "symbol");
        object datetime = this.safeString(position, "timestamp");
        object crossMargin = this.safeValue(position, "crossMargin");
        object marginMode = ((bool) isTrue((isEqual(crossMargin, true)))) ? "cross" : "isolated";
        object notional = null;
        if (isTrue(isTrue(isTrue(isEqual(getValue(market, "quote"), "USDT")) || isTrue(isEqual(getValue(market, "quote"), "USD"))) || isTrue(isEqual(getValue(market, "quote"), "EUR"))))
        {
            notional = Precise.stringMul(this.safeString(position, "foreignNotional"), "-1");
        } else
        {
            notional = this.safeString(position, "homeNotional");
        }
        object maintenanceMargin = this.safeNumber(position, "maintMargin");
        object unrealisedPnl = this.safeNumber(position, "unrealisedPnl");
        object contracts = this.omitZero(this.safeNumber(position, "currentQty"));
        return new Dictionary<string, object>() {
            { "info", position },
            { "id", this.safeString(position, "account") },
            { "symbol", symbol },
            { "timestamp", this.parse8601(datetime) },
            { "datetime", datetime },
            { "hedged", null },
            { "side", null },
            { "contracts", this.convertValue(contracts, market) },
            { "contractSize", null },
            { "entryPrice", this.safeNumber(position, "avgEntryPrice") },
            { "markPrice", this.safeNumber(position, "markPrice") },
            { "notional", notional },
            { "leverage", this.safeNumber(position, "leverage") },
            { "collateral", null },
            { "initialMargin", this.safeNumber(position, "initMargin") },
            { "initialMarginPercentage", this.safeNumber(position, "initMarginReq") },
            { "maintenanceMargin", this.convertValue(maintenanceMargin, market) },
            { "maintenanceMarginPercentage", this.safeNumber(position, "maintMarginReq") },
            { "unrealizedPnl", this.convertValue(unrealisedPnl, market) },
            { "liquidationPrice", this.safeNumber(position, "liquidationPrice") },
            { "marginMode", marginMode },
            { "marginRatio", null },
            { "percentage", this.safeNumber(position, "unrealisedPnlPcnt") },
        };
    }

    public virtual object convertValue(object value, object market = null)
    {
        if (isTrue(isTrue((isEqual(value, null))) || isTrue((isEqual(market, null)))))
        {
            return value;
        }
        object resultValue = null;
        value = this.numberToString(value);
        if (isTrue(isTrue((isEqual(getValue(market, "quote"), "USD"))) || isTrue((isEqual(getValue(market, "quote"), "EUR")))))
        {
            resultValue = Precise.stringMul(value, "0.00000001");
        } else if (isTrue(isEqual(getValue(market, "quote"), "USDT")))
        {
            resultValue = Precise.stringMul(value, "0.000001");
        } else
        {
            object currency = null;
            object quote = getValue(market, "quote");
            if (isTrue(!isEqual(quote, null)))
            {
                currency = this.currency(getValue(market, "quote"));
            }
            if (isTrue(!isEqual(currency, null)))
            {
                resultValue = Precise.stringMul(value, this.numberToString(getValue(currency, "precision")));
            }
        }
        resultValue = ((bool) isTrue((!isEqual(resultValue, null)))) ? parseFloat(resultValue) : null;
        return resultValue;
    }

    public virtual object isFiat(object currency)
    {
        if (isTrue(isEqual(currency, "EUR")))
        {
            return true;
        }
        if (isTrue(isEqual(currency, "PLN")))
        {
            return true;
        }
        return false;
    }

    public async override Task<object> withdraw(object code, object amount, object address, object tag = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#withdraw
        * @description make a withdrawal
        * @param {string} code unified currency code
        * @param {float} amount the amount to withdraw
        * @param {string} address the address to withdraw to
        * @param {string|undefined} tag
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} a [transaction structure]{@link https://docs.ccxt.com/#/?id=transaction-structure}
        */
        parameters ??= new Dictionary<string, object>();
                var tagparametersVariable = this.handleWithdrawTagAndParams(tag, parameters);
        tag = ((List<object>)tagparametersVariable)[0];
        parameters = ((List<object>)tagparametersVariable)[1];
        this.checkAddress(address);
        await this.loadMarkets();
        // let currency = this.currency (code);
        if (isTrue(!isEqual(code, "BTC")))
        {
            throw new ExchangeError ((string)add(this.id, " supoprts BTC withdrawals only, other currencies coming soon...")) ;
        }
        object currency = this.currency(code);
        object request = new Dictionary<string, object>() {
            { "currency", "XBt" },
            { "amount", amount },
            { "address", address },
        };
        object response = await this.privatePostUserRequestWithdrawal(this.extend(request, parameters));
        return this.parseTransaction(response, currency);
    }

    public async override Task<object> fetchFundingRates(object symbols = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchFundingRates
        * @description fetch the funding rate for multiple markets
        * @param {[string]|undefined} symbols list of unified market symbols
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} a dictionary of [funding rates structures]{@link https://docs.ccxt.com/#/?id=funding-rates-structure}, indexe by market symbols
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object response = await this.publicGetInstrumentActiveAndIndices(parameters);
        //
        //    [
        //        {
        //            "symbol": "LTCUSDT",
        //            "rootSymbol": "LTC",
        //            "state": "Open",
        //            "typ": "FFWCSX",
        //            "listing": "2021-11-10T04:00:00.000Z",
        //            "front": "2021-11-10T04:00:00.000Z",
        //            "expiry": null,
        //            "settle": null,
        //            "listedSettle": null,
        //            "relistInterval": null,
        //            "inverseLeg": "",
        //            "sellLeg": "",
        //            "buyLeg": "",
        //            "optionStrikePcnt": null,
        //            "optionStrikeRound": null,
        //            "optionStrikePrice": null,
        //            "optionMultiplier": null,
        //            "positionCurrency": "LTC",
        //            "underlying": "LTC",
        //            "quoteCurrency": "USDT",
        //            "underlyingSymbol": "LTCT=",
        //            "reference": "BMEX",
        //            "referenceSymbol": ".BLTCT",
        //            "calcInterval": null,
        //            "publishInterval": null,
        //            "publishTime": null,
        //            "maxOrderQty": 1000000000,
        //            "maxPrice": 1000000,
        //            "lotSize": 1000,
        //            "tickSize": 0.01,
        //            "multiplier": 100,
        //            "settlCurrency": "USDt",
        //            "underlyingToPositionMultiplier": 10000,
        //            "underlyingToSettleMultiplier": null,
        //            "quoteToSettleMultiplier": 1000000,
        //            "isQuanto": false,
        //            "isInverse": false,
        //            "initMargin": 0.03,
        //            "maintMargin": 0.015,
        //            "riskLimit": 1000000000000,
        //            "riskStep": 1000000000000,
        //            "limit": null,
        //            "capped": false,
        //            "taxed": true,
        //            "deleverage": true,
        //            "makerFee": -0.0001,
        //            "takerFee": 0.0005,
        //            "settlementFee": 0,
        //            "insuranceFee": 0,
        //            "fundingBaseSymbol": ".LTCBON8H",
        //            "fundingQuoteSymbol": ".USDTBON8H",
        //            "fundingPremiumSymbol": ".LTCUSDTPI8H",
        //            "fundingTimestamp": "2022-01-14T20:00:00.000Z",
        //            "fundingInterval": "2000-01-01T08:00:00.000Z",
        //            "fundingRate": 0.0001,
        //            "indicativeFundingRate": 0.0001,
        //            "rebalanceTimestamp": null,
        //            "rebalanceInterval": null,
        //            "openingTimestamp": "2022-01-14T17:00:00.000Z",
        //            "closingTimestamp": "2022-01-14T18:00:00.000Z",
        //            "sessionInterval": "2000-01-01T01:00:00.000Z",
        //            "prevClosePrice": 138.511,
        //            "limitDownPrice": null,
        //            "limitUpPrice": null,
        //            "bankruptLimitDownPrice": null,
        //            "bankruptLimitUpPrice": null,
        //            "prevTotalVolume": 12699024000,
        //            "totalVolume": 12702160000,
        //            "volume": 3136000,
        //            "volume24h": 114251000,
        //            "prevTotalTurnover": 232418052349000,
        //            "totalTurnover": 232463353260000,
        //            "turnover": 45300911000,
        //            "turnover24h": 1604331340000,
        //            "homeNotional24h": 11425.1,
        //            "foreignNotional24h": 1604331.3400000003,
        //            "prevPrice24h": 135.48,
        //            "vwap": 140.42165,
        //            "highPrice": 146.42,
        //            "lowPrice": 135.08,
        //            "lastPrice": 144.36,
        //            "lastPriceProtected": 144.36,
        //            "lastTickDirection": "MinusTick",
        //            "lastChangePcnt": 0.0655,
        //            "bidPrice": 143.75,
        //            "midPrice": 143.855,
        //            "askPrice": 143.96,
        //            "impactBidPrice": 143.75,
        //            "impactMidPrice": 143.855,
        //            "impactAskPrice": 143.96,
        //            "hasLiquidity": true,
        //            "openInterest": 38103000,
        //            "openValue": 547963053300,
        //            "fairMethod": "FundingRate",
        //            "fairBasisRate": 0.1095,
        //            "fairBasis": 0.004,
        //            "fairPrice": 143.811,
        //            "markMethod": "FairPrice",
        //            "markPrice": 143.811,
        //            "indicativeTaxRate": null,
        //            "indicativeSettlePrice": 143.807,
        //            "optionUnderlyingPrice": null,
        //            "settledPriceAdjustmentRate": null,
        //            "settledPrice": null,
        //            "timestamp": "2022-01-14T17:49:55.000Z"
        //        }
        //    ]
        //
        object filteredResponse = new List<object>() {};
        for (object i = 0; isLessThan(i, getArrayLength(response)); postFixIncrement(ref i))
        {
            object item = getValue(response, i);
            object marketId = this.safeString(item, "symbol");
            object market = this.safeMarket(marketId);
            object swap = this.safeValue(market, "swap", false);
            if (isTrue(swap))
            {
                ((List<object>)filteredResponse).Add(item);
            }
        }
        return this.parseFundingRates(filteredResponse, symbols);
    }

    public override object parseFundingRate(object contract, object market = null)
    {
        //
        //    {
        //        "symbol": "LTCUSDT",
        //        "rootSymbol": "LTC",
        //        "state": "Open",
        //        "typ": "FFWCSX",
        //        "listing": "2021-11-10T04:00:00.000Z",
        //        "front": "2021-11-10T04:00:00.000Z",
        //        "expiry": null,
        //        "settle": null,
        //        "listedSettle": null,
        //        "relistInterval": null,
        //        "inverseLeg": "",
        //        "sellLeg": "",
        //        "buyLeg": "",
        //        "optionStrikePcnt": null,
        //        "optionStrikeRound": null,
        //        "optionStrikePrice": null,
        //        "optionMultiplier": null,
        //        "positionCurrency": "LTC",
        //        "underlying": "LTC",
        //        "quoteCurrency": "USDT",
        //        "underlyingSymbol": "LTCT=",
        //        "reference": "BMEX",
        //        "referenceSymbol": ".BLTCT",
        //        "calcInterval": null,
        //        "publishInterval": null,
        //        "publishTime": null,
        //        "maxOrderQty": 1000000000,
        //        "maxPrice": 1000000,
        //        "lotSize": 1000,
        //        "tickSize": 0.01,
        //        "multiplier": 100,
        //        "settlCurrency": "USDt",
        //        "underlyingToPositionMultiplier": 10000,
        //        "underlyingToSettleMultiplier": null,
        //        "quoteToSettleMultiplier": 1000000,
        //        "isQuanto": false,
        //        "isInverse": false,
        //        "initMargin": 0.03,
        //        "maintMargin": 0.015,
        //        "riskLimit": 1000000000000,
        //        "riskStep": 1000000000000,
        //        "limit": null,
        //        "capped": false,
        //        "taxed": true,
        //        "deleverage": true,
        //        "makerFee": -0.0001,
        //        "takerFee": 0.0005,
        //        "settlementFee": 0,
        //        "insuranceFee": 0,
        //        "fundingBaseSymbol": ".LTCBON8H",
        //        "fundingQuoteSymbol": ".USDTBON8H",
        //        "fundingPremiumSymbol": ".LTCUSDTPI8H",
        //        "fundingTimestamp": "2022-01-14T20:00:00.000Z",
        //        "fundingInterval": "2000-01-01T08:00:00.000Z",
        //        "fundingRate": 0.0001,
        //        "indicativeFundingRate": 0.0001,
        //        "rebalanceTimestamp": null,
        //        "rebalanceInterval": null,
        //        "openingTimestamp": "2022-01-14T17:00:00.000Z",
        //        "closingTimestamp": "2022-01-14T18:00:00.000Z",
        //        "sessionInterval": "2000-01-01T01:00:00.000Z",
        //        "prevClosePrice": 138.511,
        //        "limitDownPrice": null,
        //        "limitUpPrice": null,
        //        "bankruptLimitDownPrice": null,
        //        "bankruptLimitUpPrice": null,
        //        "prevTotalVolume": 12699024000,
        //        "totalVolume": 12702160000,
        //        "volume": 3136000,
        //        "volume24h": 114251000,
        //        "prevTotalTurnover": 232418052349000,
        //        "totalTurnover": 232463353260000,
        //        "turnover": 45300911000,
        //        "turnover24h": 1604331340000,
        //        "homeNotional24h": 11425.1,
        //        "foreignNotional24h": 1604331.3400000003,
        //        "prevPrice24h": 135.48,
        //        "vwap": 140.42165,
        //        "highPrice": 146.42,
        //        "lowPrice": 135.08,
        //        "lastPrice": 144.36,
        //        "lastPriceProtected": 144.36,
        //        "lastTickDirection": "MinusTick",
        //        "lastChangePcnt": 0.0655,
        //        "bidPrice": 143.75,
        //        "midPrice": 143.855,
        //        "askPrice": 143.96,
        //        "impactBidPrice": 143.75,
        //        "impactMidPrice": 143.855,
        //        "impactAskPrice": 143.96,
        //        "hasLiquidity": true,
        //        "openInterest": 38103000,
        //        "openValue": 547963053300,
        //        "fairMethod": "FundingRate",
        //        "fairBasisRate": 0.1095,
        //        "fairBasis": 0.004,
        //        "fairPrice": 143.811,
        //        "markMethod": "FairPrice",
        //        "markPrice": 143.811,
        //        "indicativeTaxRate": null,
        //        "indicativeSettlePrice": 143.807,
        //        "optionUnderlyingPrice": null,
        //        "settledPriceAdjustmentRate": null,
        //        "settledPrice": null,
        //        "timestamp": "2022-01-14T17:49:55.000Z"
        //    }
        //
        object datetime = this.safeString(contract, "timestamp");
        object marketId = this.safeString(contract, "symbol");
        object fundingDatetime = this.safeString(contract, "fundingTimestamp");
        return new Dictionary<string, object>() {
            { "info", contract },
            { "symbol", this.safeSymbol(marketId, market) },
            { "markPrice", this.safeNumber(contract, "markPrice") },
            { "indexPrice", null },
            { "interestRate", null },
            { "estimatedSettlePrice", this.safeNumber(contract, "indicativeSettlePrice") },
            { "timestamp", this.parse8601(datetime) },
            { "datetime", datetime },
            { "fundingRate", this.safeNumber(contract, "fundingRate") },
            { "fundingTimestamp", this.iso8601(fundingDatetime) },
            { "fundingDatetime", fundingDatetime },
            { "nextFundingRate", this.safeNumber(contract, "indicativeFundingRate") },
            { "nextFundingTimestamp", null },
            { "nextFundingDatetime", null },
            { "previousFundingRate", null },
            { "previousFundingTimestamp", null },
            { "previousFundingDatetime", null },
        };
    }

    public async virtual Task<object> fetchFundingRateHistory(object symbol = null, object since = null, object limit = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchFundingRateHistory
        * @description Fetches the history of funding rates
        * @param {string|undefined} symbol unified symbol of the market to fetch the funding rate history for
        * @param {int|undefined} since timestamp in ms of the earliest funding rate to fetch
        * @param {int|undefined} limit the maximum amount of [funding rate structures]{@link https://docs.ccxt.com/en/latest/manual.html?#funding-rate-history-structure} to fetch
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @param {int|undefined} params.until timestamp in ms for ending date filter
        * @param {bool|undefined} params.reverse if true, will sort results newest first
        * @param {int|undefined} params.start starting point for results
        * @param {string|undefined} params.columns array of column names to fetch in info, if omitted, will return all columns
        * @param {string|undefined} params.filter generic table filter, send json key/value pairs, such as {"key": "value"}, you can key on individual fields, and do more advanced querying on timestamps, see the [timestamp docs]{@link https://www.bitmex.com/app/restAPI#Timestamp-Filters} for more details
        * @returns {[object]} a list of [funding rate structures]{@link https://docs.ccxt.com/en/latest/manual.html?#funding-rate-history-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object request = new Dictionary<string, object>() {};
        object market = null;
        if (isTrue(((Dictionary<string,object>)this.currencies).ContainsKey(toStringOrNull(symbol))))
        {
            object code = this.currency(symbol);
            ((Dictionary<string, object>)request)["symbol"] = getValue(code, "id");
        } else if (isTrue(!isEqual(symbol, null)))
        {
            object splitSymbol = ((string)symbol).Split((string)":").ToList<object>();
            object splitSymbolLength = getArrayLength(splitSymbol);
            object timeframes = new List<object>() {"nearest", "daily", "weekly", "monthly", "quarterly", "biquarterly", "perpetual"};
            if (isTrue(isTrue((isGreaterThan(splitSymbolLength, 1))) && isTrue(this.inArray(getValue(splitSymbol, 1), timeframes))))
            {
                object code = this.currency(getValue(splitSymbol, 0));
                symbol = add(add(getValue(code, "id"), ":"), getValue(splitSymbol, 1));
                ((Dictionary<string, object>)request)["symbol"] = symbol;
            } else
            {
                market = this.market(symbol);
                ((Dictionary<string, object>)request)["symbol"] = getValue(market, "id");
            }
        }
        if (isTrue(!isEqual(since, null)))
        {
            ((Dictionary<string, object>)request)["startTime"] = this.iso8601(since);
        }
        if (isTrue(!isEqual(limit, null)))
        {
            ((Dictionary<string, object>)request)["count"] = limit;
        }
        object until = this.safeInteger2(parameters, "until", "till");
        parameters = this.omit(parameters, new List<object>() {"until", "till"});
        if (isTrue(!isEqual(until, null)))
        {
            ((Dictionary<string, object>)request)["endTime"] = this.iso8601(until);
        }
        object response = await this.publicGetFunding(this.extend(request, parameters));
        //
        //    [
        //        {
        //            "timestamp": "2016-05-07T12:00:00.000Z",
        //            "symbol": "ETHXBT",
        //            "fundingInterval": "2000-01-02T00:00:00.000Z",
        //            "fundingRate": 0.0010890000000000001,
        //            "fundingRateDaily": 0.0010890000000000001
        //        }
        //    ]
        //
        return this.parseFundingRateHistories(response, market, since, limit);
    }

    public override object parseFundingRateHistory(object info, object market = null)
    {
        //
        //    {
        //        "timestamp": "2016-05-07T12:00:00.000Z",
        //        "symbol": "ETHXBT",
        //        "fundingInterval": "2000-01-02T00:00:00.000Z",
        //        "fundingRate": 0.0010890000000000001,
        //        "fundingRateDaily": 0.0010890000000000001
        //    }
        //
        object marketId = this.safeString(info, "symbol");
        object datetime = this.safeString(info, "timestamp");
        return new Dictionary<string, object>() {
            { "info", info },
            { "symbol", this.safeSymbol(marketId, market) },
            { "fundingRate", this.safeNumber(info, "fundingRate") },
            { "timestamp", this.parse8601(datetime) },
            { "datetime", datetime },
        };
    }

    public async override Task<object> setLeverage(object leverage, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#setLeverage
        * @description set the level of leverage for a market
        * @param {float} leverage the rate of leverage
        * @param {string} symbol unified market symbol
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} response from the exchange
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " setLeverage() requires a symbol argument")) ;
        }
        if (isTrue(isTrue((isLessThan(leverage, 0.01))) || isTrue((isGreaterThan(leverage, 100)))))
        {
            throw new BadRequest ((string)add(this.id, " leverage should be between 0.01 and 100")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        if (isTrue(isTrue(!isEqual(getValue(market, "type"), "swap")) && isTrue(!isEqual(getValue(market, "type"), "future"))))
        {
            throw new BadSymbol ((string)add(this.id, " setLeverage() supports future and swap contracts only")) ;
        }
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "leverage", leverage },
        };
        return await this.privatePostPositionLeverage(this.extend(request, parameters));
    }

    public async virtual Task<object> setMarginMode(object marginMode, object symbol = null, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#setMarginMode
        * @description set margin mode to 'cross' or 'isolated'
        * @param {string} marginMode 'cross' or 'isolated'
        * @param {string} symbol unified market symbol
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @returns {object} response from the exchange
        */
        parameters ??= new Dictionary<string, object>();
        if (isTrue(isEqual(symbol, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " setMarginMode() requires a symbol argument")) ;
        }
        marginMode = ((string)marginMode).ToLower();
        if (isTrue(isTrue(!isEqual(marginMode, "isolated")) && isTrue(!isEqual(marginMode, "cross"))))
        {
            throw new BadRequest ((string)add(this.id, " setMarginMode() marginMode argument should be isolated or cross")) ;
        }
        await this.loadMarkets();
        object market = this.market(symbol);
        if (isTrue(isTrue((!isEqual(getValue(market, "type"), "swap"))) && isTrue((!isEqual(getValue(market, "type"), "future")))))
        {
            throw new BadSymbol ((string)add(this.id, " setMarginMode() supports swap and future contracts only")) ;
        }
        object enabled = ((bool) isTrue((isEqual(marginMode, "cross")))) ? false : true;
        object request = new Dictionary<string, object>() {
            { "symbol", getValue(market, "id") },
            { "enabled", enabled },
        };
        return await this.privatePostPositionIsolate(this.extend(request, parameters));
    }

    public async override Task<object> fetchDepositAddress(object code, object parameters = null)
    {
        /**
        * @method
        * @name bitmex#fetchDepositAddress
        * @description fetch the deposit address for a currency associated with this account
        * @see https://www.bitmex.com/api/explorer/#!/User/User_getDepositAddress
        * @param {string} code unified currency code
        * @param {object} params extra parameters specific to the bitmex api endpoint
        * @param {string} params.network deposit chain, can view all chains via this.publicGetWalletAssets, default is eth, unless the currency has a default chain within this.options['networks']
        * @returns {object} an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}
        */
        parameters ??= new Dictionary<string, object>();
        await this.loadMarkets();
        object networkCode = this.safeStringUpper(parameters, "network");
        if (isTrue(isEqual(networkCode, null)))
        {
            throw new ArgumentsRequired ((string)add(this.id, " fetchDepositAddress requires params[\"network\"]")) ;
        }
        object currency = this.currency(code);
        object currencyId = getValue(currency, "id");
        object networkId = this.networkCodeToId(networkCode, getValue(currency, "code"));
        object idLength = getArrayLength(currencyId);
        currencyId = add(((string)currencyId).Substring((int)0, (int)subtract(idLength, 1)), ((string)((string)currencyId).Substring((int)subtract(idLength, 1), (int)idLength)).ToLower()); // make the last letter lowercase
        parameters = this.omit(parameters, "network");
        object request = new Dictionary<string, object>() {
            { "currency", currencyId },
            { "network", networkId },
        };
        object response = await this.privateGetUserDepositAddress(this.extend(request, parameters));
        //
        //    '"bc1qmex3puyrzn2gduqcnlu70c2uscpyaa9nm2l2j9le2lt2wkgmw33sy7ndjg"'
        //
        return new Dictionary<string, object>() {
            { "currency", code },
            { "address", ((string)((string)response).Replace((string)"\"", (string)"")).Replace((string)"\"", (string)"") },
            { "tag", null },
            { "network", ((string)this.networkIdToCode(networkId)).ToUpper() },
            { "info", response },
        };
    }

    public override object calculateRateLimiterCost(object api, object method, object path, object parameters, object config = null, object context = null)
    {
        config ??= new Dictionary<string, object>();
        context ??= new Dictionary<string, object>();
        object isAuthenticated = this.checkRequiredCredentials(false);
        object cost = this.safeValue(config, "cost", 1);
        if (isTrue(!isEqual(cost, 1)))
        {
            if (isTrue(isAuthenticated))
            {
                return cost;
            } else
            {
                return 20;
            }
        }
        return cost;
    }

    public override object handleErrors(object code, object reason, object url, object method, object headers, object body, object response, object requestHeaders, object requestBody)
    {
        if (isTrue(isEqual(response, null)))
        {
            return null;
        }
        if (isTrue(isEqual(code, 429)))
        {
            throw new DDoSProtection ((string)add(add(this.id, " "), body)) ;
        }
        if (isTrue(isGreaterThanOrEqual(code, 400)))
        {
            object error = this.safeValue(response, "error", new Dictionary<string, object>() {});
            object message = this.safeString(error, "message");
            object feedback = add(add(this.id, " "), body);
            this.throwExactlyMatchedException(getValue(this.exceptions, "exact"), message, feedback);
            this.throwBroadlyMatchedException(getValue(this.exceptions, "broad"), message, feedback);
            if (isTrue(isEqual(code, 400)))
            {
                throw new BadRequest ((string)feedback) ;
            }
            throw new ExchangeError ((string)feedback) ;
        }
        return null;
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
        object query = add(add(add("/api/", this.version), "/"), path);
        if (isTrue(isEqual(method, "GET")))
        {
            if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)parameters).Keys))))
            {
                query = add(query, add("?", this.urlencode(parameters)));
            }
        } else
        {
            object format = this.safeString(parameters, "_format");
            if (isTrue(!isEqual(format, null)))
            {
                query = add(query, add("?", this.urlencode(new Dictionary<string, object>() {
    { "_format", format },
})));
                parameters = this.omit(parameters, "_format");
            }
        }
        object url = add(getValue(getValue(this.urls, "api"), api), query);
        object isAuthenticated = this.checkRequiredCredentials(false);
        if (isTrue(isTrue(isEqual(api, "private")) || isTrue((isTrue(isEqual(api, "public")) && isTrue(isAuthenticated)))))
        {
            this.checkRequiredCredentials();
            object auth = add(method, query);
            object expires = this.safeInteger(this.options, "api-expires");
            headers = new Dictionary<string, object>() {
                { "Content-Type", "application/json" },
                { "api-key", this.apiKey },
            };
            expires = ((object)this.sum(this.seconds(), expires)).ToString();
            auth = add(auth, expires);
            ((Dictionary<string, object>)headers)["api-expires"] = expires;
            if (isTrue(isTrue(isTrue(isEqual(method, "POST")) || isTrue(isEqual(method, "PUT"))) || isTrue(isEqual(method, "DELETE"))))
            {
                if (isTrue(getArrayLength(new List<string>(((Dictionary<string,object>)parameters).Keys))))
                {
                    body = this.json(parameters);
                    auth = add(auth, body);
                }
            }
            ((Dictionary<string, object>)headers)["api-signature"] = this.hmac(this.encode(auth), this.encode(this.secret), sha256);
        }
        return new Dictionary<string, object>() {
            { "url", url },
            { "method", method },
            { "body", body },
            { "headers", headers },
        };
    }
}
