
// ----------------------------------------------------------------------------

import bitoproRest from '../bitopro.js';
import { ExchangeError } from '../base/errors.js';
import { ArrayCache, ArrayCacheBySymbolById } from '../base/ws/Cache.js';
import { sha384 } from '../static_dependencies/noble-hashes/sha512.js';
import type { Int, OrderBook, Trade, Ticker, Balances, Str, Order } from '../base/types.js';
import Client from '../base/ws/Client.js';

// ----------------------------------------------------------------------------

export default class bitopro extends bitoproRest {
    describe () {
        return this.deepExtend (super.describe (), {
            'has': {
                'ws': true,
                'watchBalance': true,
                'watchMyTrades': false,
                'watchOHLCV': false,
                'watchOrderBook': true,
                'watchOrders': true,
                'watchTicker': true,
                'watchTickers': false,
                'watchTrades': true,
            },
            'urls': {
                'ws': {
                    'public': 'wss://stream.bitopro.com:443/ws/v1/pub',
                    'private': 'wss://stream.bitopro.com:443/ws/v1/pub/auth',
                },
            },
            'requiredCredentials': {
                'apiKey': true,
                'secret': true,
                'login': true,
            },
            'options': {
                'tradesLimit': 1000,
                'ordersLimit': 1000,
                'ws': {
                    'options': {
                        // headers is required for the authentication
                        'headers': {},
                    },
                },
            },
        });
    }

    async watchPublic (path, messageHash, marketId) {
        const url = this.urls['ws']['public'] + '/' + path + '/' + marketId;
        return await this.watch (url, messageHash, undefined, messageHash);
    }

    async watchOrderBook (symbol: string, limit: Int = undefined, params = {}): Promise<OrderBook> {
        /**
         * @method
         * @name bitopro#watchOrderBook
         * @description watches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
         * @param {string} symbol unified symbol of the market to fetch the order book for
         * @param {int} [limit] the maximum amount of order book entries to return
         * @param {object} [params] extra parameters specific to the exchange API endpoint
         * @returns {object} A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols
         */
        if (limit !== undefined) {
            if ((limit !== 5) && (limit !== 10) && (limit !== 20) && (limit !== 50) && (limit !== 100) && (limit !== 500) && (limit !== 1000)) {
                throw new ExchangeError (this.id + ' watchOrderBook limit argument must be undefined, 5, 10, 20, 50, 100, 500 or 1000');
            }
        }
        await this.loadMarkets ();
        const market = this.market (symbol);
        symbol = market['symbol'];
        const messageHash = 'ORDER_BOOK' + ':' + symbol;
        let endPart = undefined;
        if (limit === undefined) {
            endPart = market['id'];
        } else {
            endPart = market['id'] + ':' + limit;
        }
        const orderbook = await this.watchPublic ('order-books', messageHash, endPart);
        return orderbook.limit ();
    }

    handleOrderBook (client: Client, message) {
        //
        //     {
        //         "event": "ORDER_BOOK",
        //         "timestamp": 1650121915308,
        //         "datetime": "2022-04-16T15:11:55.308Z",
        //         "pair": "BTC_TWD",
        //         "limit": 5,
        //         "scale": 0,
        //         "bids": [
        //             { price: "1188178", amount: '0.0425', count: 1, total: "0.0425" },
        //         ],
        //         "asks": [
        //             {
        //                 "price": "1190740",
        //                 "amount": "0.40943964",
        //                 "count": 1,
        //                 "total": "0.40943964"
        //             },
        //         ]
        //     }
        //
        const marketId = this.safeString (message, 'pair');
        const market = this.safeMarket (marketId, undefined, '_');
        const symbol = market['symbol'];
        const event = this.safeString (message, 'event');
        const messageHash = event + ':' + symbol;
        let orderbook = this.safeValue (this.orderbooks, symbol);
        if (orderbook === undefined) {
            orderbook = this.orderBook ({});
        }
        const timestamp = this.safeInteger (message, 'timestamp');
        const snapshot = this.parseOrderBook (message, symbol, timestamp, 'bids', 'asks', 'price', 'amount');
        orderbook.reset (snapshot);
        client.resolve (orderbook, messageHash);
    }

    async watchTrades (symbol: string, since: Int = undefined, limit: Int = undefined, params = {}): Promise<Trade[]> {
        /**
         * @method
         * @name bitopro#watchTrades
         * @description get the list of most recent trades for a particular symbol
         * @param {string} symbol unified symbol of the market to fetch trades for
         * @param {int} [since] timestamp in ms of the earliest trade to fetch
         * @param {int} [limit] the maximum amount of trades to fetch
         * @param {object} [params] extra parameters specific to the exchange API endpoint
         * @returns {object[]} a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}
         */
        await this.loadMarkets ();
        const market = this.market (symbol);
        symbol = market['symbol'];
        const messageHash = 'TRADE' + ':' + symbol;
        const trades = await this.watchPublic ('trades', messageHash, market['id']);
        if (this.newUpdates) {
            limit = trades.getLimit (symbol, limit);
        }
        return this.filterBySinceLimit (trades, since, limit, 'timestamp', true);
    }

    handleTrade (client: Client, message) {
        //
        //     {
        //         "event": "TRADE",
        //         "timestamp": 1650116346665,
        //         "datetime": "2022-04-16T13:39:06.665Z",
        //         "pair": "BTC_TWD",
        //         "data": [
        //             {
        //                 "event": '',
        //                 "datetime": '',
        //                 "pair": '',
        //                 "timestamp": 1650116227,
        //                 "price": "1189429",
        //                 "amount": "0.0153127",
        //                 "isBuyer": true
        //             },
        //         ]
        //     }
        //
        const marketId = this.safeString (message, 'pair');
        const market = this.safeMarket (marketId, undefined, '_');
        const symbol = market['symbol'];
        const event = this.safeString (message, 'event');
        const messageHash = event + ':' + symbol;
        const rawData = this.safeValue (message, 'data', []);
        const trades = this.parseTrades (rawData, market);
        let tradesCache = this.safeValue (this.trades, symbol);
        if (tradesCache === undefined) {
            const limit = this.safeInteger (this.options, 'tradesLimit', 1000);
            tradesCache = new ArrayCache (limit);
        }
        for (let i = 0; i < trades.length; i++) {
            tradesCache.append (trades[i]);
        }
        this.trades[symbol] = tradesCache;
        client.resolve (tradesCache, messageHash);
    }

    async watchTicker (symbol: string, params = {}): Promise<Ticker> {
        /**
         * @method
         * @name bitopro#watchTicker
         * @description watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
         * @param {string} symbol unified symbol of the market to fetch the ticker for
         * @param {object} [params] extra parameters specific to the exchange API endpoint
         * @returns {object} a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}
         */
        await this.loadMarkets ();
        const market = this.market (symbol);
        symbol = market['symbol'];
        const messageHash = 'TICKER' + ':' + symbol;
        return await this.watchPublic ('tickers', messageHash, market['id']);
    }

    handleTicker (client: Client, message) {
        //
        //     {
        //         "event": "TICKER",
        //         "timestamp": 1650119165710,
        //         "datetime": "2022-04-16T14:26:05.710Z",
        //         "pair": "BTC_TWD",
        //         "lastPrice": "1189110",
        //         "lastPriceUSD": "40919.1328",
        //         "lastPriceTWD": "1189110",
        //         "isBuyer": true,
        //         "priceChange24hr": "1.23",
        //         "volume24hr": "7.2090",
        //         "volume24hrUSD": "294985.5375",
        //         "volume24hrTWD": "8572279",
        //         "high24hr": "1193656",
        //         "low24hr": "1179321"
        //     }
        //
        const marketId = this.safeString (message, 'pair');
        const market = this.safeMarket (marketId, undefined, '_');
        const symbol = market['symbol'];
        const event = this.safeString (message, 'event');
        const messageHash = event + ':' + symbol;
        const result = this.parseTicker (message);
        const timestamp = this.safeInteger (message, 'timestamp');
        const datetime = this.safeString (message, 'datetime');
        result['timestamp'] = timestamp;
        result['datetime'] = datetime;
        this.tickers[symbol] = result;
        client.resolve (result, messageHash);
    }

    authenticate (url) {
        if ((this.clients !== undefined) && (url in this.clients)) {
            return;
        }
        this.checkRequiredCredentials ();
        const nonce = this.milliseconds ();
        const rawData = this.json ({
            'nonce': nonce,
            'identity': this.login,
        });
        const payload = this.stringToBase64 (rawData);
        const signature = this.hmac (this.encode (payload), this.encode (this.secret), sha384);
        const defaultOptions = {
            'ws': {
                'options': {
                    'headers': {},
                },
            },
        };
        this.options = this.extend (defaultOptions, this.options);
        const originalHeaders = this.options['ws']['options']['headers'];
        const headers = {
            'X-BITOPRO-API': 'ccxt',
            'X-BITOPRO-APIKEY': this.apiKey,
            'X-BITOPRO-PAYLOAD': payload,
            'X-BITOPRO-SIGNATURE': signature,
        };
        this.options['ws']['options']['headers'] = headers;
        // instantiate client
        this.client (url);
        this.options['ws']['options']['headers'] = originalHeaders;
    }

    async watchOrders (symbol: Str = undefined, since: Int = undefined, limit: Int = undefined, params = {}): Promise<Order[]> {
        /**
         * @method
         * @name bitopro#watchOrders
         * @see https://github.com/bitoex/bitopro-offical-api-docs/blob/master/ws/private/history_orders_stream.md
         * @description watches information on multiple orders made by the user
         * @param {string} symbol unified market symbol of the market orders were made in
         * @param {int} [since] the earliest time in ms to fetch orders for
         * @param {int} [limit] the maximum number of  orde structures to retrieve
         * @param {object} [params] maximum number of orderic to the exchange API endpoint
         * @returns {object[]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
         */
        const openOrders = await this.watchOpenOrders (symbol, since, limit, params);
        const closedOrders = await this.watchClosedOrders (symbol, since, limit, params);
        const result = this.arrayConcat (this.toArray (openOrders), this.toArray (closedOrders));
        return this.filterBySinceLimit (result, since, limit, 'timestamp', true);
    }

    async watchClosedOrders (symbol: Str = undefined, since: Int = undefined, limit: Int = undefined, params = {}): Promise<Order[]> {
        /**
         * @method
         * @name bitopro#watchClosedOrders
         * @see https://github.com/bitoex/bitopro-offical-api-docs/blob/master/ws/private/history_orders_stream.md
         * @description watches information on multiple orders made by the user
         * @param {string} symbol unified market symbol of the market orders were made in
         * @param {int} [since] the earliest time in ms to fetch orders for
         * @param {int} [limit] the maximum number of  orde structures to retrieve
         * @param {object} [params] maximum number of orderic to the exchange API endpoint
         * @returns {object[]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
         */
        this.checkRequiredCredentials ();
        await this.loadMarkets ();
        let messageHash = 'ORDERS';
        if (symbol !== undefined) {
            symbol = this.symbol (symbol);
            messageHash = messageHash + ':' + symbol;
        }
        const url = this.urls['ws']['private'] + '/' + 'orders/histories';
        this.authenticate (url);
        const trades = await this.watch (url, messageHash, undefined, messageHash);
        if (this.newUpdates) {
            limit = trades.getLimit (symbol, limit);
        }
        return this.filterBySinceLimit (trades, since, limit, 'timestamp', true);
    }

    async watchOpenOrders (symbol: Str = undefined, since: Int = undefined, limit: Int = undefined, params = {}): Promise<Order[]> {
        /**
         * @method
         * @name bitopro#watchOpenOrders
         * @see https://github.com/bitoex/bitopro-offical-api-docs/blob/master/ws/private/history_orders_stream.md
         * @description watches information on multiple orders made by the user
         * @param {string} symbol unified market symbol of the market orders were made in
         * @param {int} [since] the earliest time in ms to fetch orders for
         * @param {int} [limit] the maximum number of  orde structures to retrieve
         * @param {object} [params] maximum number of orderic to the exchange API endpoint
         * @returns {object[]} a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}
         */
        this.checkRequiredCredentials ();
        await this.loadMarkets ();
        let messageHash = 'ORDERS';
        if (symbol !== undefined) {
            symbol = this.symbol (symbol);
            messageHash = messageHash + ':' + symbol;
        }
        const url = this.urls['ws']['private'] + '/' + 'orders';
        this.authenticate (url);
        const trades = await this.watch (url, messageHash, undefined, messageHash);
        if (this.newUpdates) {
            limit = trades.getLimit (symbol, limit);
        }
        return this.filterBySinceLimit (trades, since, limit, 'timestamp', true);
    }

    handleOrders (client: Client, message, subscription = undefined) {
        //
        //     {
        //         "event": "RECENT_HISTORY_ORDERS",
        //         "timestamp": 1639552073346,
        //         "datetime": "2021-12-15T07:07:53.346Z",
        //         "data": {
        //             "sol_usdt": [
        //                 {
        //                     "id": "8917255503",
        //                     "pair": "sol_usdt",
        //                     "price": "107",
        //                     "avgExecutionPrice": "0",
        //                     "action": "SELL",
        //                     "type": "LIMIT",
        //                     "timestamp": 1639386803663,
        //                     "updatedTimestamp": 1639386803663,
        //                     "createdTimestamp": 1639386803663,
        //                     "status": 0,
        //                     "originalAmount": "0.02",
        //                     "remainingAmount": "0.02",
        //                     "executedAmount": "0",
        //                     "fee": "0",
        //                     "feeSymbol": "usdt",
        //                     "bitoFee": "0",
        //                     "total": "0",
        //                     "seq": "SOLUSDT3273528249",
        //                     "timeInForce": "GTC"
        //                 }
        //             ],
        //             "usdc_twd": [
        //                 {
        //                     "id": "3452766477",
        //                     "pair": "usdc_twd",
        //                     "price": "10",
        //                     "avgExecutionPrice": "0",
        //                     "action": "BUY",
        //                     "type": "LIMIT",
        //                     "timestamp": 1638258713957,
        //                     "updatedTimestamp": 1639386803663,
        //                     "createdTimestamp": 1639386803663,
        //                     "status": 0,
        //                     "originalAmount": "0.01",
        //                     "remainingAmount": "0.01",
        //                     "executedAmount": "0",
        //                     "fee": "0",
        //                     "feeSymbol": "usdc",
        //                     "bitoFee": "0",
        //                     "total": "0",
        //                     "seq": "USDCTWD2310459465"
        //                     "timeInForce": "GTC"
        //                 }
        //             ]
        //         }
        //     }
        //
        const allOrders = this.safeValue (message, 'data', {});
        const symbols = Object.keys (allOrders);
        const ordersLength = symbols.length;
        if (ordersLength > 0) {
            const limit = this.safeInteger (this.options, 'ordersLimit', 1000);
            if (this.orders === undefined) {
                this.orders = new ArrayCacheBySymbolById (limit);
            }
            const stored = this.orders;
            const marketIds = {};
            for (let i = 0; i < symbols.length; i++) {
                const symbol = symbols[i];
                const market = this.market (symbol);
                const orders = allOrders[market['id']];
                const parsed = this.parseOrders (orders);
                for (let j = 0; j < parsed.length; j++) {
                    const order = parsed[j];
                    stored.append (order);
                    marketIds[market['symbol']] = true;
                }
            }
            const messageHash = 'ORDERS';
            client.resolve (this.orders, messageHash);
            const keys = Object.keys (marketIds);
            for (let j = 0; j < keys.length; j++) {
                client.resolve (this.orders, messageHash + ':' + keys[j]);
            }
        }
    }

    async watchBalance (params = {}): Promise<Balances> {
        /**
         * @method
         * @name bitopro#watchBalance
         * @description watch balance and get the amount of funds available for trading or funds locked in orders
         * @param {object} [params] extra parameters specific to the exchange API endpoint
         * @returns {object} a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}
         */
        this.checkRequiredCredentials ();
        await this.loadMarkets ();
        const messageHash = 'ACCOUNT_BALANCE';
        const url = this.urls['ws']['private'] + '/' + 'account-balance';
        this.authenticate (url);
        return await this.watch (url, messageHash, undefined, messageHash);
    }

    handleBalance (client: Client, message) {
        //
        //     {
        //         "event": "ACCOUNT_BALANCE",
        //         "timestamp": 1650450505715,
        //         "datetime": "2022-04-20T10:28:25.715Z",
        //         "data": {
        //           "ADA": {
        //             "currency": "ADA",
        //             "amount": "0",
        //             "available": "0",
        //             "stake": "0",
        //             "tradable": true
        //           },
        //         }
        //     }
        //
        const event = this.safeString (message, 'event');
        const data = this.safeValue (message, 'data');
        const timestamp = this.safeInteger (message, 'timestamp');
        const datetime = this.safeString (message, 'datetime');
        const currencies = Object.keys (data);
        const result = {
            'info': data,
            'timestamp': timestamp,
            'datetime': datetime,
        };
        for (let i = 0; i < currencies.length; i++) {
            const currency = this.safeString (currencies, i);
            const balance = this.safeValue (data, currency);
            const currencyId = this.safeString (balance, 'currency');
            const code = this.safeCurrencyCode (currencyId);
            const account = this.account ();
            account['free'] = this.safeString (balance, 'available');
            account['total'] = this.safeString (balance, 'amount');
            result[code] = account;
        }
        this.balance = this.safeBalance (result);
        client.resolve (this.balance, event);
    }

    handleMessage (client: Client, message) {
        const methods = {
            'TRADE': this.handleTrade,
            'TICKER': this.handleTicker,
            'ORDER_BOOK': this.handleOrderBook,
            'ACCOUNT_BALANCE': this.handleBalance,
            'ACTIVE_ORDERS': this.handleOrders,
            'RECENT_HISTORY_ORDERS': this.handleOrders,
        };
        const event = this.safeString (message, 'event');
        const method = this.safeValue (methods, event);
        if (method === undefined) {
            return message;
        } else {
            return method.call (this, client, message);
        }
    }
}
