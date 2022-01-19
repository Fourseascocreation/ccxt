'use strict'

// ----------------------------------------------------------------------------

const assert = require ('assert')

// ----------------------------------------------------------------------------

module.exports = (exchange, market, method) => {

    const format = {
        'id':      'btcusd',   // string literal for referencing within an exchange
        'symbol':  'BTC/USD',  // uppercase string literal of a pair of currencies
        'base':    'BTC',      // unified uppercase string, base currency, 3 or more letters
        'quote':   'USD',      // unified uppercase string, quote currency, 3 or more letters
        'taker':   0.0011,     // taker fee, for example, 0.0011 = 0.11%
        'maker':   0.0009,     // maker fee, for example, 0.0009 = 0.09%
        //---------------------------------------------------------------------
        // commented temporarily to bring markets to consistency first
        'baseId':  'btc',     // exchange-specific base currency id
        'quoteId': 'usd',     // exchange-specific quote currency id
        'active': true,       // boolean, market status
        // uncomment these lines to test the futures keys
        'type': 'spot',
        'linear': undefined,
        'inverse': undefined,
        'spot': true,
        'swap': false,     // doesn't exist on binance...
        'future': false,   // doesn't exist on binance...
        'option': false,
        'margin': false,
        'contract': false,
        'contractSize': 0.001,
        'expiry': 1656057600000,
        'expiryDatetime': '2022-06-24T08:00:00.000Z',
        'optionType': 'put',
        'strike': 56000,
        'settle': undefined,
        'settleId': undefined,
        'precision': {        // number of decimal digits "after the dot"
             'price': 8,       // integer
             'amount': 8,      // integer
             'cost': 8,        // integer
         },
        'limits': {           // value limits when placing orders on this market
             'amount': {
                 'min': 0.01,  // order amount should be > min
                 'max': 1000,  // order amount should be < max
             },
             'price': {
                 'min': 0.01,  // order price should be > min
                 'max': 1000,  // order price should be < max
             },
             'cost':  { // order cost = price * amount
                 'min': 0.01,  // order cost should be > min
                 'max': 1000,  // order cost should be < max
             },
        },
        'info': {}, // the original unparsed market info from the exchange
        //---------------------------------------------------------------------
    }

    const keys = Object.keys (format);
    for (let i = 0; i < keys.length; i++) {
        const key = keys[i]
        assert (key in market, key + JSON.stringify (market));
    }
    assert ((market['taker'] === undefined) || (typeof market['taker'] === 'number'));
    assert ((market['maker'] === undefined) || (typeof market['maker'] === 'number'));
    if (market['contract']) {
        assert (market['linear'] === !market['inverse']);
    } else {
        assert ((market['linear'] === undefined) && (market['inverse'] === undefined))
    }
    if (market['option']) {
        assert (market['strike'] !== undefined);
        assert (market['optionType'] !== undefined);
    }
    const validTypes = {
        'spot': true,
        'margin': true,
        'swap': true,
        'future': true,
        'option': true,
    };
    const type = market['type'];
    assert (type in validTypes);
    const types = Object.keys (validTypes);
    for (let i = 0; i < types.length; i++) {
        const entry = types[i];
        const value = market[entry];
        assert ((value === false) || (value === true));
    }
    if (market['future']) {
        assert ((market['swap'] === false) && (market['option'] === false));
    } else if (market['swap']) {
        assert ((market['future'] === false) && (market['option'] === false));
    } else if (market['option']) {
        assert ((market['future'] === false) && (market['swap'] === false));
    }
    if (market['linear']) {
        assert (market['inverse'] === false);
    } else if (market['inverse']) {
        assert (market['linear'] === false);
    }
    if (market['future']) {
        assert (market['expiry'] !== undefined);
        assert (market['expiryDatetime'] !== undefined);
    }
}
