export interface Dictionary<T> {
    [key: string]: T;
}
/** Request parameters */
// type Params = Dictionary<string | number | boolean | string[]>;

export type PreciseNumber = string | number;

export interface MinMax {
    min: PreciseNumber | undefined;
    max: PreciseNumber | undefined;
}

export interface Fee {
    type?: 'taker' | 'maker' | string;
    currency: string;
    rate?: PreciseNumber;
    cost: PreciseNumber;
}

export interface Market {
    id: string;
    symbol: string;
    base: string;
    quote: string;
    baseId: string;
    quoteId: string;
    active?: boolean | undefined;
    type?: string;
    spot?: boolean;
    margin?: boolean;
    swap?: boolean;
    future?: boolean;
    option?: boolean;
    contract?: boolean;
    settle?: string | undefined;
    settleId?: string | undefined;
    contractSize?: number | undefined;
    linear?: boolean | undefined;
    inverse?: boolean | undefined;
    expiry?: number | undefined;
    expiryDatetime?: string | undefined;
    strike?: number | undefined;
    optionType?: string | undefined;
    taker?: PreciseNumber | undefined;
    maker?: PreciseNumber | undefined;
    percentage?: boolean | undefined;
    tierBased?: boolean | undefined;
    feeSide?: string | undefined;
    precision: {
        amount: number | undefined,
        price: number | undefined
    };
    limits: {
        amount?: MinMax,
        cost?: MinMax,
        leverage?: MinMax,
        price?: MinMax,
    };
    info: any;
}

export interface Trade {
    amount: PreciseNumber;                  // amount of base currency
    datetime: string;                // ISO8601 datetime with milliseconds;
    id: string;                      // string trade id
    info: any;                        // the original decoded JSON as is
    order?: string;                  // string order id or undefined/None/null
    price: PreciseNumber;                   // float price in quote currency
    timestamp: number;               // Unix timestamp in milliseconds
    type?: string;                   // order type, 'market', 'limit', ... or undefined/None/null
    side: 'buy' | 'sell' | string;            // direction of the trade, 'buy' or 'sell'
    symbol: string;                  // symbol in CCXT format
    takerOrMaker: 'taker' | 'maker' | string; // string, 'taker' or 'maker'
    cost: PreciseNumber;                    // total cost (including fees), `price * amount`
    fee: Fee;
}

export interface Order {
    id: string;
    clientOrderId: string;
    datetime: string;
    timestamp: number;
    lastTradeTimestamp: number;
    lastUpdateTimestamp?: number;
    status: 'open' | 'closed' | 'canceled' | string;
    symbol: string;
    type: string;
    timeInForce?: string;
    side: 'buy' | 'sell' | string;
    price: PreciseNumber;
    average?: PreciseNumber;
    amount: PreciseNumber;
    filled: PreciseNumber;
    remaining: PreciseNumber;
    stopPrice?: PreciseNumber;
    takeProfitPrice?: PreciseNumber;
    stopLossPrice?: PreciseNumber;
    cost: PreciseNumber;
    trades: Trade[];
    fee: Fee;
    info: any;
}

export interface OrderBook {
    asks: [PreciseNumber, PreciseNumber][];
    bids: [PreciseNumber, PreciseNumber][];
    datetime: string;
    timestamp: number;
    nonce: number;
}

export interface Ticker {
    symbol: string;
    info: any;
    timestamp: number;
    datetime: string;
    high: PreciseNumber;
    low: PreciseNumber;
    bid: PreciseNumber;
    bidVolume?: PreciseNumber;
    ask: PreciseNumber;
    askVolume?: PreciseNumber;
    vwap?: PreciseNumber;
    open?: PreciseNumber;
    close?: PreciseNumber;
    last?: PreciseNumber;
    previousClose?: PreciseNumber;
    change?: PreciseNumber;
    percentage?: PreciseNumber;
    average?: PreciseNumber;
    quoteVolume?: PreciseNumber;
    baseVolume?: PreciseNumber;
}

export interface Transaction {
    info: any;
    id: string;
    txid?: string;
    timestamp: number;
    datetime: string;
    address: string;
    type: 'deposit' | 'withdrawal' | string;
    amount: PreciseNumber;
    currency: string;
    status: 'pending' | 'ok' | string;
    updated: PreciseNumber;
    fee: Fee;
}

export interface Tickers extends Dictionary<Ticker> {
    info: any;
}

export interface Currency {
    id: string;
    code: string;
    numericId?: number;
    precision: number;
}

export interface Balance {
    free: PreciseNumber;
    used: PreciseNumber;
    total: PreciseNumber;
}

export interface PartialBalances extends Dictionary<number> {
}

export interface Balances extends Dictionary<Balance> {
    info: any;
}

export interface DepositAddress {
    currency: string;
    address: string;
    status: string;
    info: any;
}

export interface WithdrawalResponse {
    info: any;
    id: string;
}

export interface DepositAddressResponse {
    currency: string;
    address: string;
    info: any;
    tag?: string;
}

export interface Position {
    symbol: string;
    id: string;
    timestamp?: number;
    datetime: string;
    contracts?: number;
    contractsSize?: number;
    side: string;
    notional?: PreciseNumber;
    leverage?: number;
    unrealizedPnl?: PreciseNumber;
    realizedPnl?: PreciseNumber;
    collateral?: PreciseNumber;
    entryPrice?: PreciseNumber;
    markPrice?: PreciseNumber;
    liquidationPrice?: PreciseNumber;
    hedged?: boolean;
    maintenanceMargin?: PreciseNumber;
    maintenanceMarginPercentage?: PreciseNumber;
    initialMargin?: PreciseNumber;
    initialMarginPercentage?: PreciseNumber;
    marginMode: string;
    marginRatio?: number;
    lastUpdateTimestamp?: number;
    lastPrice?: PreciseNumber;
    percentage?: PreciseNumber;
    info: any;
}

/** [ timestamp, open, high, low, close, volume ] */
export type OHLCV = [number, PreciseNumber, PreciseNumber, PreciseNumber, PreciseNumber, PreciseNumber];

/** [ timestamp, open, high, low, close, volume, count ] */
export type OHLCVC = [number, PreciseNumber, PreciseNumber, PreciseNumber, PreciseNumber, PreciseNumber, PreciseNumber];

export type implicitReturnType = any;

// must be an integer in other langs
export type IndexType = number | string;

export type Int = number;

export type OrderSide = 'buy' | 'sell' | string;

export type OrderType = 'limit' | 'market' | string;
