'use strict';

//  ---------------------------------------------------------------------------

const Exchange = require ('./base/Exchange');
const { ExchangeError, InvalidAddress, DuplicateOrderId, ArgumentsRequired, InsufficientFunds, InvalidOrder, InvalidNonce, AuthenticationError, RateLimitExceeded, PermissionDenied, BadRequest, BadSymbol } = require ('./base/errors');
//  ---------------------------------------------------------------------------

module.exports = class lbank2 extends Exchange {
    describe () {
        return this.deepExtend (super.describe (), {
            'id': 'lbank2',
            'name': 'LBank',
            'countries': [ 'CN' ],
            'version': 'v2',
            // 50 per second for making and cancelling orders 1000ms / 50 = 20
            // 20 per second for all other requests, cost = 50 / 20 = 2.5
            'rateLimit': 20,
            'has': {
                'CORS': false,
                'spot': true,
                'margin': false,
                'swap': false,
                'future': false,
                'option': false,
                'addMargin': false,
                'cancelOrder': false,
                'createOrder': true,
                'createReduceOnlyOrder': false,
                'fetchBalance': true,
                'fetchBorrowRate': false,
                'fetchBorrowRateHistories': false,
                'fetchBorrowRateHistory': false,
                'fetchBorrowRates': false,
                'fetchBorrowRatesPerSymbol': false,
                'fetchClosedOrders': false,
                'fetchFundingFees': true,
                'fetchFundingHistory': false,
                'fetchFundingRate': false,
                'fetchFundingRateHistory': false,
                'fetchFundingRates': false,
                'fetchIndexOHLCV': false,
                'fetchIsolatedPositions': false,
                'fetchLeverage': false,
                'fetchLeverageTiers': false,
                'fetchMarkets': true,
                'fetchMarkOHLCV': false,
                'fetchOHLCV': true,
                'fetchOpenOrders': true,
                'fetchOrder': true,
                'fetchOrderBook': true,
                'fetchOrders': true,
                'fetchPosition': false,
                'fetchPositions': false,
                'fetchPositionsRisk': false,
                'fetchPremiumIndexOHLCV': false,
                'fetchTicker': true,
                'fetchTickers': false,
                'fetchTrades': true,
                'fetchTradingFees': true,
                'reduceMargin': false,
                'setLeverage': false,
                'setMarginMode': false,
                'setPositionMode': false,
                'withdraw': false,
            },
            'timeframes': {
                '1m': 'minute1',
                '5m': 'minute5',
                '15m': 'minute15',
                '30m': 'minute30',
                '1h': 'hour1',
                '2h': 'hour2',
                '4h': 'hour4',
                '6h': 'hour6',
                '8h': 'hour8',
                '12h': 'hour12',
                '1d': 'day1',
                '1w': 'week1',
            },
            'urls': {
                'logo': 'https://user-images.githubusercontent.com/1294454/38063602-9605e28a-3302-11e8-81be-64b1e53c4cfb.jpg',
                'api': 'https://api.lbank.info',
                'api2': 'https://api.lbkex.com',
                'www': 'https://www.lbank.info',
                'doc': 'https://github.com/LBank-exchange/lbank-official-api-docs',
                'fees': 'https://lbankinfo.zendesk.com/hc/en-gb/articles/360012072873-Trading-Fees',
                'referral': 'https://www.lbex.io/invite?icode=7QCY',
            },
            'api': {
                'public': {
                    'get': {
                        'currencyPairs': 2.5,
                        'accuracy': 2.5,
                        'usdToCny': 2.5,
                        'withdrawConfigs': 2.5,
                        'timestamp': 2.5,
                        'ticker/24h': 2.5, // down
                        'ticker': 2.5,
                        'depth': 2.5,
                        'incrDepth': 2.5,
                        'trades': 2.5,
                        'kline': 2.5,
                        // TODO new quote endpoints
                        'supplement/system_ping': 2.5,
                        'supplement/incrDepth': 2.5,
                        'supplement/trades': 2.5,
                        'supplement/ticker/price': 2.5,
                        'supplement/ticker/bookTicker': 2.5,
                    },
                    'post': {
                        'supplement/system_status': 2.5,
                    },
                },
                'private': {
                    'post': {
                        // account
                        'user_info': 2.5,
                        'subscribe/get_key': 2.5,
                        'subscribe/refresh_key': 2.5,
                        'subscribe/destroy_key': 2.5,
                        'get_deposit_address': 2.5,
                        'deposit_history': 2.5,
                        // order
                        'create_order': 1,
                        'batch_create_order': 1,
                        'cancel_order': 1,
                        'cancel_clientOrders': 1,
                        'orders_info': 2.5,
                        'orders_info_history': 2.5,
                        'order_transaction_detail': 2.5,
                        'transaction_history': 2.5,
                        'orders_info_no_deal': 2.5,
                        // withdraw
                        'withdraw': 2.5,
                        'withdrawCancel': 2.5,
                        'withdraws': 2.5,
                        // TODO new wallet endpoints
                        'supplement/user_info': 2.5,
                        'supplement/withdraw': 2.5, // TODO Withdraw (last)
                        'supplement/deposit_history': 2.5, // TODO fetchDeposits
                        'supplement/withdraws': 2.5, // TODO fetchWithdrawals
                        'supplement/get_deposit_address': 2.5,
                        'supplement/asset_detail': 2.5,
                        'supplement/customer_trade_fee': 2.5,
                        'supplement/api_Restrictions': 2.5,
                        // new quote endpoints
                        'supplement/system_ping': 2.5,
                        // new order endpoints
                        'supplement/create_order_test': 1,
                        'supplement/create_order': 1, // TODO createOrder (redo update)
                        'supplement/cancel_order': 1, // TODO cancelOrder (redo update)
                        'supplement/cancel_order_by_symbol': 1, // TODO cancelAllOrders (redo update)
                        'supplement/orders_info': 2.5, // TODO fetchOrder (redo update)
                        'supplement/orders_info_no_deal': 2.5, // TODO fetchOpenOrders (redo update)
                        'supplement/orders_info_history': 2.5, // TODO fetchOrders (investigate)
                        'supplement/user_info_account': 2.5,
                        'supplement/transaction_history': 2.5, // TODO fetchMyTrades (investigate)
                    },
                },
            },
            'fees': {
                'trading': {
                    'maker': this.parseNumber ('0.001'),
                    'taker': this.parseNumber ('0.001'),
                },
                'funding': {
                    'withdraw': {},
                },
            },
            'commonCurrencies': {
                'VET_ERC20': 'VEN',
                'PNT': 'Penta',
            },
            'options': {
                'cacheSecretAsPem': true,
                'fetchTrades': {
                    'method': 'publicGetTrades', // or 'publicGetTradesSupplement'
                },
                'fetchFundingFees': {
                    'method': 'fetchPrivateFundingFees', // or 'fetchPublicFundingFees'
                },
                'fetchDepositAddress': {
                    'method': 'fetchDepositAddressDefault', // or fetchDepositAddressSupplement
                },
                'createOrder': {
                    'method': 'privatePostSupplementCreateOrder', // or privatePostCreateOrder
                },
                'fetchOrder': {
                    'method': 'fetchOrderSupplement', // or fetchOrderDefault
                },
                'fetchBalance': {
                    'method': 'privatePostSupplementUserInfo', // or privatePostSupplementUserInfoAccount or privatePostUserInfo
                },
                'networks': {
                    'ERC20': 'erc20',
                    'ETH': 'erc20',
                    'TRC20': 'trc20',
                    'TRX': 'trc20',
                    'OMNI': 'omni',
                    'ASA': 'asa',
                    'BEP20': 'bep20(bsc)',
                    'BSC': 'bep20(bsc)',
                    'HT': 'heco',
                    'BNB': 'bep2',
                    'BTC': 'btc',
                    'DOGE': 'dogecoin',
                    'MATIC': 'matic',
                    'POLYGON': 'matic',
                    'OEC': 'oec',
                    'BTCTRON': 'btctron',
                    'XRP': 'xrp',
                    // other unusual chains with number of listed currencies supported
                    //     'avax c-chain': 1,
                    //     klay: 12,
                    //     bta: 1,
                    //     fantom: 1,
                    //     celo: 1,
                    //     sol: 2,
                    //     zenith: 1,
                    //     ftm: 5,
                    //     bep20: 1, (single token with mis-named chain) SSS
                    //     bitci: 1,
                    //     sgb: 1,
                    //     moonbeam: 1,
                    //     ekta: 1,
                    //     etl: 1,
                    //     arbitrum: 1,
                    //     tpc: 1,
                    //     ptx: 1
                    // }
                },
                'inverse-networks': {
                    'erc20': 'ERC20',
                    'trc20': 'TRC20',
                    'omni': 'OMNI',
                    'asa': 'ASA',
                    'bep20(bsc)': 'BSC',
                    'bep20': 'BSC',
                    'heco': 'HT',
                    'bep2': 'BNB',
                    'btc': 'BTC',
                    'dogecoin': 'DOGE',
                    'matic': 'MATIC',
                    'oec': 'OEC',
                    'btctron': 'BTCTRON',
                    'xrp': 'XRP',
                },
            },
        });
    }

    async fetchMarkets (params = {}) {
        // needs to return a list of unified market structures
        const response = await this.publicGetAccuracy ();
        const data = this.safeValue (response, 'data');
        //      [
        //          {
        //              symbol: 'snx3s_usdt',
        //              quantityAccuracy: '2',
        //              minTranQua: '0.01',
        //              priceAccuracy: '6'
        //          }
        //     ]
        const result = [];
        for (let i = 0; i < data.length; i++) {
            const market = data[i];
            const marketId = this.safeString (market, 'symbol');
            const parts = marketId.split ('_');
            const baseId = parts[0];
            const quoteId = parts[1];
            const base = baseId.toUpperCase ();
            const quote = quoteId.toUpperCase ();
            let symbol = base + '/' + quote;
            const productTypes = {
                '3l': true,
                '5l': true,
                '3s': true,
                '5s': true,
            };
            const ending = baseId.slice (-2);
            const isLeveragedProduct = this.safeValue (productTypes, ending, false);
            if (isLeveragedProduct) {
                symbol += ':' + quote;
            }
            let linear = undefined;
            if (isLeveragedProduct === true) {
                linear = true;
            }
            result.push ({
                'id': marketId,
                'symbol': symbol,
                'base': base,
                'quote': quote,
                'settle': undefined,
                'baseId': baseId,
                'quoteId': quoteId,
                'settleId': undefined,
                'type': 'spot',
                'spot': true,
                'margin': false,
                'swap': isLeveragedProduct,
                'future': false,
                'option': false,
                'active': true,
                'contract': isLeveragedProduct,
                'linear': linear, // all leveraged ETF products are in USDT
                'inverse': undefined,
                'contractSize': undefined,
                'expiry': undefined,
                'expiryDatetime': undefined,
                'strike': undefined,
                'optionType': undefined,
                'precision': {
                    'amount': this.safeInteger (market, 'quantityAccuracy'),
                    'price': this.safeInteger (market, 'priceAccuracy'),
                },
                'limits': {
                    'leverage': {
                        'min': undefined,
                        'max': undefined,
                    },
                    'amount': {
                        'min': this.safeInteger (market, 'minTranQua'),
                        'max': undefined,
                    },
                    'price': {
                        'min': undefined,
                        'max': undefined,
                    },
                    'cost': {
                        'min': undefined,
                        'max': undefined,
                    },
                },
                'info': market,
            });
        }
        return result;
    }

    parseTicker (ticker, market = undefined) {
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
        const marketId = this.safeString (ticker, 'symbol');
        const symbol = this.safeSymbol (marketId, market);
        const timestamp = this.safeString (ticker, 'timestamp');
        const tickerData = this.safeValue (ticker, 'ticker');
        return this.safeTicker ({
            'symbol': symbol,
            'timestamp': timestamp,
            'datetime': this.iso8601 (timestamp),
            'high': this.safeString (tickerData, 'high'),
            'low': this.safeString (tickerData, 'low'),
            'bid': undefined,
            'bidVolume': undefined,
            'ask': undefined,
            'askVolume': undefined,
            'vwap': undefined,
            'open': undefined,
            'close': undefined,
            'last': this.safeString (tickerData, 'latest'),
            'previousClose': undefined,
            'change': undefined,
            'percentage': this.safeString (tickerData, 'change'),
            'average': undefined,
            'baseVolume': this.safeString (tickerData, 'vol'),
            'quoteVolume': this.safeString (tickerData, 'turnover'),
            'info': ticker,
        }, market, false);
    }

    async fetchTicker (symbol, params = {}) {
        await this.loadMarkets ();
        const market = this.market (symbol);
        const request = {
            'symbol': market['id'],
        };
        // preferred ticker/24h endpoint is down
        const response = await this.publicGetTicker (this.extend (request, params));
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
        const result = this.safeValue (response, 'data')[0];
        return this.parseTicker (result, market);
    }

    async fetchOrderBook (symbol, limit = undefined, params = {}) {
        await this.loadMarkets ();
        const market = this.market (symbol);
        const request = {
            'symbol': market['id'],
        };
        if (limit !== undefined) {
            request['limit'] = limit;
        }
        const response = await this.publicGetSupplementIncrDepth (this.extend (request, params));
        const orderbook = response['data'];
        const timestamp = this.milliseconds ();
        return this.parseOrderBook (orderbook, symbol, timestamp);
    }

    parseTrade (trade, market = undefined) {
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
        const timestamp = this.safeInteger2 (trade, 'date_ms', 'time');
        const amountString = this.safeString2 (trade, 'amount', 'qty');
        const priceString = this.safeString (trade, 'price');
        const costString = this.safeString (trade, 'quoteQty');
        const side = this.safeString (trade, 'type');
        const id = this.safeString2 (trade, 'tid', 'id');
        const symbol = this.safeSymbol (undefined, market);
        return this.safeTrade ({
            'timestamp': timestamp,
            'datetime': this.iso8601 (timestamp),
            'symbol': symbol,
            'id': id,
            'order': undefined,
            'type': undefined,
            'takerOrMaker': undefined,
            'side': side,
            'price': priceString,
            'amount': amountString,
            'cost': costString,
            'fee': undefined,
            'info': trade,
        }, market);
    }

    async fetchTrades (symbol, since = undefined, limit = undefined, params = {}) {
        await this.loadMarkets ();
        if (limit === undefined) {
            throw new ArgumentsRequired (this.id + 'fetchTrades () requires a limit argument');
        }
        const market = this.market (symbol);
        const request = {
            'symbol': market['id'],
            'size': limit, // max
        };
        if (since !== undefined) {
            request['time'] = since;
        }
        let method = this.safeString (params, 'method');
        params = this.omit (params, 'method');
        if (method === undefined) {
            const options = this.safeValue (this.options, 'fetchTrades', {});
            method = this.safeString (options, 'method', 'publicGetTrades');
        }
        const response = await this[method] (this.extend (request, params));
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
        const trades = this.safeValue (response, 'data', []);
        return this.parseTrades (trades, market, since, limit);
    }

    parseOHLCV (ohlcv, market = undefined) {
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
        return [
            this.safeTimestamp (ohlcv, 0), // timestamp
            this.safeNumber (ohlcv, 1), // open
            this.safeNumber (ohlcv, 2), // high
            this.safeNumber (ohlcv, 3), // low
            this.safeNumber (ohlcv, 4), // close
            this.safeNumber (ohlcv, 5), // volume
        ];
    }

    async fetchOHLCV (symbol, timeframe = '1m', since = undefined, limit = undefined, params = {}) {
        // endpoint doesnt work
        await this.loadMarkets ();
        const market = this.market (symbol);
        if (since === undefined) {
            throw new ArgumentsRequired (this.id + ' fetchOHLCV () requires a since argument');
        }
        if (limit === undefined) {
            limit = 100;
        }
        const request = {
            'symbol': market['id'],
            'type': this.timeframes[timeframe],
            'time': parseInt (since / 1000),
            'size': limit, // max 2000
        };
        const response = await this.publicGetKline (this.extend (request, params));
        const ohlcvs = this.safeValue (response, 'data', []);
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
        return this.parseOHLCVs (ohlcvs, market, timeframe, since, limit);
    }

    parseBalance (response) {
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
        const timestamp = this.safeInteger (response, 'ts');
        const result = {
            'info': response,
            'timestamp': timestamp,
            'datetime': this.iso8601 (timestamp),
        };
        const data = this.safeValue (response, 'data');
        // from privatePostUserInfo
        const toBtc = this.safeValue (data, 'toBtc');
        if (toBtc !== undefined) {
            const used = this.safeValue (data, 'freeze', {});
            const free = this.safeValue (data, 'free', {});
            const currencies = Object.keys (free);
            for (let i = 0; i < currencies.length; i++) {
                const currencyId = currencies[i];
                const code = this.safeCurrencyCode (currencyId);
                const account = this.account ();
                account['used'] = this.safeString (used, currencyId);
                account['free'] = this.safeString (free, currencyId);
                result[code] = account;
            }
            return this.safeBalance (result);
        }
        // from privatePostSupplementUserInfoAccount
        const balances = this.safeValue (data, 'balances');
        if (balances !== undefined) {
            for (let i = 0; i < balances.length; i++) {
                const item = balances[i];
                const currencyId = this.safeString (item, 'asset');
                const code = this.safeCurrencyCode (currencyId);
                const account = this.account ();
                account['free'] = this.safeString (item, 'free');
                account['used'] = this.safeString (item, 'locked');
                result[code] = account;
            }
            return this.safeBalance (result);
        }
        // from privatePostSupplementUserInfo
        const isArray = Array.isArray (data);
        if (isArray === true) {
            for (let i = 0; i < data.length; i++) {
                const item = data[i];
                const currencyId = this.safeString (item, 'coin');
                const code = this.safeCurrencyCode (currencyId);
                const account = this.account ();
                account['free'] = this.safeString (item, 'usableAmt');
                account['used'] = this.safeString (item, 'freezeAmt');
                result[code] = account;
            }
            return this.safeBalance (result);
        }
    }

    async fetchBalance (params = {}) {
        // TODO add support for default method
        await this.loadMarkets ();
        let method = this.safeString (params, 'method');
        if (method === undefined) {
            const options = this.safeValue (this.options, 'fetchBalance', {});
            method = this.safeString (options, 'method', 'privatePostSupplementUserInfo');
        }
        const response = await this[method] ();
        return this.parseBalance (response);
    }

    parseTradingFee (fee, market = undefined) {
        //
        //      {
        //          "symbol":"skt_usdt",
        //          "makerCommission":"0.10",
        //          "takerCommission":"0.10"
        //      }
        //
        const marketId = this.safeString (fee, 'symbol');
        const symbol = this.safeSymbol (marketId);
        return {
            'info': fee,
            'symbol': symbol,
            'maker': this.safeNumber (fee, 'makerCommission'),
            'taker': this.safeNumber (fee, 'takerCommission'),
        };
    }

    async fetchTradingFee (symbol, params = {}) {
        const market = this.market (symbol);
        const result = await this.fetchTradingFees (this.extend (params, { 'category': market['id'] }));
        return result;
    }

    async fetchTradingFees (params = {}) {
        await this.loadMarkets ();
        const request = {};
        const response = await this.privatePostSupplementCustomerTradeFee (this.extend (request, params));
        const fees = this.safeValue (response, 'data', []);
        const result = {};
        for (let i = 0; i < fees.length; i++) {
            const fee = this.parseTradingFee (fees[i]);
            const symbol = fee['symbol'];
            result[symbol] = fee;
        }
        return result;
    }

    parseOrderStatus (status) {
        const statuses = {
            '-1': 'cancelled', // cancelled
            '0': 'open', // not traded
            '1': 'open', // partial deal
            '2': 'closed', // complete deal
            '3': 'closed', // filled partially and cancelled
            '4': 'closed', // disposal processing
        };
        return this.safeString (statuses, status);
    }

    async createOrder (symbol, type, side, amount, price = undefined, params = {}) {
        await this.loadMarkets ();
        const market = this.market (symbol);
        const clientOrderId = this.safeString2 (params, 'custom_id', 'clientOrderId');
        const postOnly = this.safeString (params, 'postOnly', false);
        const timeInForce = this.safeStringUpper (params, 'timeInForce');
        params = this.omit (params, [ 'custom_id', 'clientOrderId', 'timeInForce', 'postOnly' ]);
        if (type === 'limit') {
            type = side;
            if (side === 'sell') {
                if (timeInForce === 'FOK') {
                    type = 'sell_fok';
                }
                if (timeInForce === 'IOC') {
                    type = 'sell_ioc';
                }
                if (postOnly || (timeInForce === 'PO')) {
                    type = 'sell_maker';
                }
            }
            if (side === 'buy') {
                if (timeInForce === 'FOK') {
                    type = 'buy_fok';
                }
                if (timeInForce === 'IOC') {
                    type = 'buy_ioc';
                }
                if (postOnly || (timeInForce === 'PO')) {
                    type = 'buy_maker';
                }
            }
        }
        if (type === 'market') {
            if (side === 'sell') {
                type = 'sell_market';
            }
            if (side === 'buy') {
                type = 'buy_market';
            }
        }
        const request = {
            'symbol': market['id'],
            'amount': this.amountToPrecision (symbol, amount),
            'type': type,
        };
        if (price !== undefined) {
            request['price'] = this.priceToPrecision (symbol, price);
        } else {
            request['price'] = 1; // required unused number > 0 even for market orders
        }
        if (clientOrderId !== undefined) {
            request['custom_id'] = clientOrderId;
        }
        let method = undefined;
        method = this.safeString (params, 'method');
        params = this.omit (params, 'method');
        if (method === undefined) {
            const options = this.safeValue (this.options, 'createOrder', {});
            method = this.safeString (options, 'method', 'privatePostSupplementCreateOrder');
        }
        const response = await this[method] (this.extend (request, params));
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
        const result = this.safeValue (response, 'data', {});
        return {
            'id': this.safeString (result, 'order_id'),
            'info': result,
        };
    }

    parseOrder (order, market = undefined) {
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
        //          "symbol":"doge_usdt",
        //          "amount":18,
        //          "create_time":1647455223186,
        //          "price":0,
        //          "avg_price":0.113344,
        //          "type":"sell_market",
        //          "order_id":"d4ca1ddd-40d9-42c1-9717-5de435865bec",
        //          "custom_id": "007" // field id only present if custom Id exists
        //          "deal_amount":18,
        //          "status":2
        //      }
        //
        return this.safeOrder ({
            'id': undefined,
            'clientOrderId': undefined,
            'datetime': undefined,
            'timestamp': undefined,
            'lastTradeTimestamp': undefined,
            'status': undefined,
            'symbol': undefined,
            'type': undefined,
            'timeInForce': undefined,
            'postOnly': undefined,
            'side': undefined,
            'price': undefined,
            'stopPrice': undefined,
            'cost': undefined,
            'amount': undefined,
            'filled': undefined,
            'remaining': undefined,
            'trades': undefined,
            'fee': undefined,
            'info': order,
            'average': undefined,
        }, market);
    }

    async fetchOrder (id, symbol = undefined, params = {}) {
        await this.loadMarkets ();
        let method = this.safeString (params, 'method');
        if (method === undefined) {
            const options = this.safeValue (this.options, 'fetchOrder', {});
            method = this.safeString (options, 'method', 'fetchOrderSupplement');
        }
        const result = await this[method] (id, symbol, params);
        return result;
    }

    async fetchOrderSupplement (id, symbol = undefined, params = {}) {
        await this.loadMarkets ();
        if (symbol === undefined) {
            throw new ArgumentsRequired (this.id + ' fetchOrder () requires a symbol argument');
        }
        const market = this.market (symbol);
        const request = {
            'symbol': market['id'],
            'orderId': id,
        };
        const response = await this.privatePostSupplementOrdersInfo (this.extend (request, params));
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
        const result = this.safeValue (response, 'data', {});
        return this.parseOrder (result);
    }

    async fetchOrderDefault (id, symbol = undefined, params = {}) {
        // Id can be a list of ids delimited by a comma
        await this.loadMarkets ();
        if (symbol === undefined) {
            throw new ArgumentsRequired (this.id + ' fetchOrder () requires a symbol argument');
        }
        const market = this.market (symbol);
        const request = {
            'symbol': market['id'],
            'order_id': id,
        };
        const response = await this.privatePostOrdersInfo (this.extend (request, params));
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
        const result = this.safeValue (response, 'data', []);
        const numOrders = result.length;
        if (numOrders === 1) {
            return this.parseOrder (result[0]);
        } else {
            const parsedOrders = [];
            for (let i = 0; i < numOrders; i++) {
                const parsedOrder = this.parseOrder (result[i]);
                parsedOrders.push (parsedOrder);
            }
            return parsedOrders;
        }
    }

    async fetchOrders (symbol = undefined, since = undefined, limit = undefined, params = {}) {
        if (symbol === undefined) {
            throw new ArgumentsRequired (this.id + ' fetchOrders() requires a symbol argument');
        }
        await this.loadMarkets ();
        const market = this.market (symbol);
        if (limit === undefined) {
            limit = 100;
        }
        const request = {
            'symbol': market['id'],
            'current_page': 1,
            'page_length': limit,
            // 'status': -1：Cancelled, 0：on trading, 1：filled partially, 2：Filled totally, 3：filled partially and cancelled, 4：Cancelling
        };
        // this endpoint does not return open orders
        const response = await this.privatePostOrdersInfoHistory (this.extend (request, params));
        const result = this.safeValue (response, 'data', {});
        const orders = this.safeValue (result, 'orders', []);
        return this.parseOrders (orders, market, since, limit);
    }

    async fetchClosedOrders (symbol = undefined, since = undefined, limit = undefined, params = {}) {
        await this.loadMarkets ();
        const market = this.market (symbol);
        const orders = await this.fetchOrders (market['symbol'], since, limit, params);
        const closed = this.filterBy (orders, 'status', 'closed');
        const canceled = this.filterBy (orders, 'status', 'cancelled'); // cancelled orders may be partially filled
        const allOrders = this.arrayConcat (closed, canceled);
        return this.filterBySymbolSinceLimit (allOrders, market['symbol'], since, limit);
    }

    async fetchOpenOrders (symbol = undefined, since = undefined, limit = undefined, params = {}) {
        await this.loadMarkets ();
        if (symbol === undefined) {
            throw new ArgumentsRequired (this.id + ' fetchOpenOrders() requires a symbol argument');
        }
        const market = this.market (symbol);
        if (limit === undefined) {
            limit = 100;
        }
        const request = {
            'symbol': market['id'],
            'current_page': 1,
            'page_length': limit,
        };
        const response = await this.privatePostOrdersInfoNoDeal (this.extend (request, params));
        const result = this.safeValue (response, 'data', {});
        const orders = this.safeValue (result, 'orders', []);
        const openOrders = this.parseOrders (orders);
        return this.filterBySymbolSinceLimit (openOrders, market['symbol'], since, limit);
    }

    async cancelOrder (id, symbol = undefined, params = {}) {
        await this.loadMarkets ();
        if (symbol === undefined) {
            throw new ArgumentsRequired (this.id + ' fetchOpenOrders() requires a symbol argument');
        }
        const market = this.market (symbol);
        const clientOrderId = this.safeString2 (params, 'customer_id', 'clientOrderId');
        params = this.omit (params, [ 'customer_id', 'clientOrderId' ]);
        const request = {
            'symbol': market['id'],
        };
        let method = undefined;
        if (clientOrderId !== undefined) {
            method = 'privatePostCancelClientOrders';
            request['customer_id'] = clientOrderId;
        } else {
            method = 'privatePostCancelOrder';
            request['order_id'] = id;
        }
        const response = await this[method] (this.extend (request, params));
        return response;
    }

    async fetchDepositAddress (code, params = {}) {
        await this.loadMarkets ();
        let method = this.safeString (params, 'method');
        params = this.omit (params, 'method');
        if (method === undefined) {
            const options = this.safeValue (this.options, 'fetchDepositAddress', {});
            method = this.safeString (options, 'method', 'fetchPrivateTradingFees');
        }
        return await this[method] (code, params);
    }

    async fetchDepositAddressDefault (code, params = {}) {
        await this.loadMarkets ();
        const currency = this.currency (code);
        const request = {
            'assetCode': currency['id'],
        };
        const networks = this.safeValue (this.options, 'networks');
        let network = this.safeStringUpper (params, 'network');
        network = this.safeString (networks, network, network);
        if (network !== undefined) {
            request['netWork'] = network; // ... yes, really lol
            params = this.omit (params, 'network');
        }
        const response = await this.privatePostGetDepositAddress (this.extend (request, params));
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
        const result = this.safeValue (response, 'data');
        const address = this.safeString (result, 'address');
        const tag = this.safeString (result, 'memo');
        const networkId = this.safeString (result, 'netWork');
        const inverseNetworks = this.safeValue (this.options, 'inverse-networks', {});
        const networkCode = this.safeStringUpper (inverseNetworks, networkId, networkId);
        return {
            'currency': code,
            'address': address,
            'tag': tag,
            'network': networkCode,
            'info': response,
        };
    }

    async fetchDepositAddressSupplement (code, params = {}) {
        // returns the address for whatever the default network is...
        await this.loadMarkets ();
        const currency = this.currency (code);
        const request = {
            'coin': currency['id'],
        };
        const networks = this.safeValue (this.options, 'networks');
        let network = this.safeStringUpper (params, 'network');
        network = this.safeString (networks, network, network);
        if (network !== undefined) {
            request['networkName'] = network;
            params = this.omit (params, 'network');
        }
        const response = await this.privatePostSupplementGetDepositAddress (this.extend (request, params));
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
        const result = this.safeValue (response, 'data');
        const address = this.safeString (result, 'address');
        const tag = this.safeString (result, 'memo');
        const inverseNetworks = this.safeValue (this.options, 'inverse-networks', {});
        const networkCode = this.safeStringUpper (inverseNetworks, network, network);
        return {
            'currency': code,
            'address': address,
            'tag': tag,
            'network': networkCode, // will be undefined if not specified in request
            'info': response,
        };
    }

    async fetchFundingFees (params = {}) {
        // private only returns information for currencies with non-zero balance
        await this.loadMarkets ();
        const isAuthorized = this.checkRequiredCredentials (false);
        let result = undefined;
        if (isAuthorized === true) {
            let method = this.safeString (params, 'method');
            params = this.omit (params, 'method');
            if (method === undefined) {
                const options = this.safeValue (this.options, 'fetchFundingFees', {});
                method = this.safeString (options, 'method', 'fetchPrivateFundingFees');
            }
            result = await this[method] (params);
        } else {
            result = await this.fetchPublicFundingFees (params);
        }
        return result;
    }

    async fetchPrivateFundingFees (params = {}) {
        // complete response
        // incl. for coins which undefined in public method
        await this.loadMarkets ();
        const response = await this.privatePostSupplementUserInfo ();
        const result = this.safeValue (response, 'data', []);
        const withdrawFees = {};
        for (let i = 0; i < result.length; i++) {
            const entry = result[i];
            const currencyId = this.safeString (entry, 'coin');
            const code = this.safeCurrencyCode (currencyId);
            const networkList = this.safeValue (entry, 'networkList', []);
            withdrawFees[code] = {};
            for (let j = 0; j < networkList.length; j++) {
                const networkEntry = networkList[j];
                const networkId = this.safeString (networkEntry, 'name');
                const networkCode = this.safeString (this.options['inverse-networks'], networkId, networkId);
                const fee = this.safeNumber (networkEntry, 'withdrawFee');
                if (fee !== undefined) {
                    withdrawFees[code][networkCode] = fee;
                }
            }
        }
        return {
            'withdraw': withdrawFees,
            'deposit': {},
            'info': response,
        };
    }

    async fetchPublicFundingFees (params = {}) {
        // extremely incomplete response
        // vast majority fees undefined
        await this.loadMarkets ();
        const code = this.safeString2 (params, 'coin', 'assetCode');
        params = this.omit (params, [ 'coin', 'assetCode' ]);
        const request = {};
        if (code !== undefined) {
            const currency = this.currency (code);
            request['assetCode'] = currency['id'];
        }
        const response = await this.publicGetWithdrawConfigs (this.extend (request, params));
        const result = this.safeValue (response, 'data', []);
        const withdrawFees = {};
        for (let i = 0; i < result.length; i++) {
            const item = result[i];
            const canWithdraw = this.safeString (item, 'canWithDraw');
            if (canWithdraw === 'true') {
                const currencyId = this.safeString (item, 'assetCode');
                const code = this.safeCurrencyCode (currencyId);
                const chain = this.safeString (item, 'chain');
                let network = this.safeString (this.options['inverse-networks'], chain, chain);
                if (network === undefined) {
                    network = code;
                }
                const fee = this.safeString (item, 'fee');
                if (withdrawFees[code] === undefined) {
                    withdrawFees[code] = {};
                }
                withdrawFees[code][network] = fee;
            }
        }
        return {
            'withdraw': withdrawFees,
            'deposit': {},
            'info': response,
        };
    }

    sign (path, api = 'public', method = 'GET', params = {}, headers = undefined, body = undefined) {
        let query = this.omit (params, this.extractParams (path));
        let url = this.urls['api'] + '/' + this.version + '/' + this.implodeParams (path, params);
        // Every endpoint ends with ".do"
        url += '.do';
        if (api === 'public') {
            if (Object.keys (query).length) {
                url += '?' + this.urlencode (this.keysort (query));
            }
        } else {
            this.checkRequiredCredentials ();
            const timestamp = this.milliseconds ().toString ();
            const echostr = this.uuid22 () + this.uuid16 ();
            query = this.extend ({
                'api_key': this.apiKey,
            }, query);
            let signatureMethod = undefined;
            if (this.secret.length > 32) {
                signatureMethod = 'RSA';
            } else {
                signatureMethod = 'HmacSHA256';
            }
            const auth = this.rawencode (this.keysort (this.extend ({
                'echostr': echostr,
                'signature_method': signatureMethod,
                'timestamp': timestamp,
            }, query)));
            const hash = this.hash (auth).toUpperCase ();
            let sign = undefined;
            if (signatureMethod === 'RSA') {
                // TODO fix RSA signing
                const cacheSecretAsPem = this.safeValue (this.options, 'cacheSecretAsPem', true);
                let pem = undefined;
                if (cacheSecretAsPem) {
                    pem = this.safeValue (this.options, 'pem');
                    if (pem === undefined) {
                        pem = this.convertSecretToPem (this.secret);
                        this.options['pem'] = pem;
                    }
                } else {
                    pem = this.convertSecretToPem (this.secret);
                }
                sign = this.binaryToBase64 (this.rsa (hash, this.encode (pem), 'RS256'));
                // TODO fix RSA signing
            } else if (signatureMethod === 'HmacSHA256') {
                sign = this.hmac (this.encode (hash), this.secret);
            }
            body = this.urlencode (this.keysort (query)) + '&sign=' + sign;
            headers = {
                'Content-Type': 'application/x-www-form-urlencoded',
                'timestamp': timestamp,
                'signature_method': signatureMethod,
                'echostr': echostr,
            };
        }
        return { 'url': url, 'method': method, 'body': body, 'headers': headers };
    }

    convertSecretToPem (secret) {
        const lineLength = 64;
        const secretLength = secret.length - 0;
        let numLines = parseInt (secretLength / lineLength);
        numLines = this.sum (numLines, 1);
        let pem = "-----BEGIN PRIVATE KEY-----\n"; // eslint-disable-line
        for (let i = 0; i < numLines; i++) {
            const start = i * lineLength;
            const end = this.sum (start, lineLength);
            pem += this.secret.slice (start, end) + "\n"; // eslint-disable-line
        }
        return pem + '-----END PRIVATE KEY-----';
    }

    handleErrors (httpCode, reason, url, method, headers, body, response, requestHeaders, requestBody) {
        if (response === undefined) {
            return;
        }
        const success = this.safeString (response, 'result');
        if (success === 'false') {
            const errorCode = this.safeString (response, 'error_code');
            const message = this.safeString ({
                '10000': 'Internal error',
                '10001': 'The required parameters can not be empty',
                '10002': 'Validation failed',
                '10003': 'Invalid parameter',
                '10004': 'Request too frequent',
                '10005': 'Secret key does not exist',
                '10006': 'User does not exist',
                '10007': 'Invalid signature',
                '10008': 'Invalid Trading Pair',
                '10009': 'Price and/or Amount are required for limit order',
                '10010': 'Price and/or Amount must be less than minimum requirement',
                // '10011': 'Market orders can not be missing the amount of the order',
                // '10012': 'market sell orders can not be missing orders',
                '10013': 'The amount is too small',
                '10014': 'Insufficient amount of money in the account',
                '10015': 'Invalid order type',
                '10016': 'Insufficient account balance',
                '10017': 'Server Error',
                '10018': 'Page size should be between 1 and 50',
                '10019': 'Cancel NO more than 3 orders in one request',
                '10020': 'Volume < 0.001',
                '10021': 'Price < 0.01',
                '10022': 'Invalid authorization',
                '10023': 'Market Order is not supported yet',
                '10024': 'User cannot trade on this pair',
                '10025': 'Order has been filled',
                '10026': 'Order has been cancelld',
                '10027': 'Order is cancelling',
                '10028': 'Wrong query time',
                '10029': 'from is not in the query time',
                '10030': 'from do not match the transaction type of inqury',
                '10031': 'echostr length must be valid and length must be from 30 to 40',
                '10033': 'Failed to create order',
                '10036': 'customID duplicated',
                '10100': 'Has no privilege to withdraw',
                '10101': 'Invalid fee rate to withdraw',
                '10102': 'Too little to withdraw',
                '10103': 'Exceed daily limitation of withdraw',
                '10104': 'Cancel was rejected',
                '10105': 'Request has been cancelled',
                '10106': 'None trade time',
                '10107': 'Start price exception',
                '10108': 'can not create order',
                '10109': 'wallet address is not mapping',
                '10110': 'transfer fee is not mapping',
                '10111': 'mount > 0',
                '10112': 'fee is too lower',
                '10113': 'transfer fee is 0',
                '10600': 'intercepted by replay attacks filter, check timestamp',
                '10601': 'Interface closed unavailable',
                '10701': 'invalid asset code',
                '10702': 'not allowed deposit',
            }, errorCode, this.json (response));
            const ErrorClass = this.safeValue ({
                '10001': BadRequest,
                '10002': AuthenticationError,
                '10003': BadRequest,
                '10004': RateLimitExceeded,
                '10005': AuthenticationError,
                '10006': AuthenticationError,
                '10007': AuthenticationError,
                '10008': BadSymbol,
                '10009': InvalidOrder,
                '10010': InvalidOrder,
                '10013': InvalidOrder,
                '10014': InsufficientFunds,
                '10015': InvalidOrder,
                '10016': InsufficientFunds,
                '10017': ExchangeError,
                '10018': BadRequest,
                '10019': BadRequest,
                '10020': BadRequest,
                '10021': InvalidOrder,
                '10022': PermissionDenied, // 'Invalid authorization',
                '10023': InvalidOrder, // 'Market Order is not supported yet',
                '10024': PermissionDenied, // 'User cannot trade on this pair',
                '10025': InvalidOrder, // 'Order has been filled',
                '10026': InvalidOrder, // 'Order has been cancelled',
                '10027': InvalidOrder, // 'Order is cancelling',
                '10028': BadRequest, // 'Wrong query time',
                '10029': BadRequest, // 'from is not in the query time',
                '10030': BadRequest, // 'from do not match the transaction type of inqury',
                '10031': InvalidNonce, // 'echostr length must be valid and length must be from 30 to 40',
                '10033': ExchangeError, // 'Failed to create order',
                '10036': DuplicateOrderId, // 'customID duplicated',
                '10100': PermissionDenied, // 'Has no privilege to withdraw',
                '10101': BadRequest, // 'Invalid fee rate to withdraw',
                '10102': InsufficientFunds, // 'Too little to withdraw',
                '10103': ExchangeError, // 'Exceed daily limitation of withdraw',
                '10104': ExchangeError, // 'Cancel was rejected',
                '10105': ExchangeError, // 'Request has been cancelled',
                '10106': BadRequest, // 'None trade time',
                '10107': BadRequest, // 'Start price exception',
                '10108': ExchangeError, // 'can not create order',
                '10109': InvalidAddress, // 'wallet address is not mapping',
                '10110': ExchangeError, // 'transfer fee is not mapping',
                '10111': BadRequest, // 'mount > 0',
                '10112': BadRequest, // 'fee is too lower',
                '10113': BadRequest, // 'transfer fee is 0',
                '10600': BadRequest, // 'intercepted by replay attacks filter, check timestamp',
                '10601': ExchangeError, // 'Interface closed unavailable',
                '10701': BadSymbol, // 'invalid asset code',
                '10702': PermissionDenied, // 'not allowed deposit',
            }, errorCode, ExchangeError);
            throw new ErrorClass (message);
        }
    }
};
