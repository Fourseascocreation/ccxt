
import assert from 'assert';
import testSharedMethods from './base/test.sharedMethods.js';
import testTrade from './base/test.trade.js';
import Precise from '../../base/Precise.js';


async function testFetchTrades (exchange, skippedProperties, symbol) {
    const method = 'fetchTrades';
    const trades = await exchange.fetchTrades (symbol, undefined, 12000); // lets test with unrealistically high amount
    await testFetchTrades_Structure (exchange, skippedProperties, symbol, method, trades);
    await testFetchTrades_ArrayValues (exchange, skippedProperties, symbol, method, trades);
    await testFetchTrades_Side (exchange, skippedProperties, symbol, method, trades);
}

async function testFetchTrades_Structure (exchange, skippedProperties, symbol, method, trades) {
    const logText = testSharedMethods.logTemplate (exchange, method, trades);
    assert (Array.isArray (trades), 'Returned respone is not an array' + logText);
    // check trades length (any normal exchange should be tested against this. If there are any crappy exchange that doesn't have trades, that exchange should be added into skips )
    if (!('emptyResponse' in skippedProperties)) {
        assert (trades.length > 0, 'Returned trades should not be empty' + logText);
    }
    const now = exchange.milliseconds ();
    for (let i = 0; i < trades.length; i++) {
        testTrade (exchange, skippedProperties, method, trades[i], symbol, now);
    }
    if (!('timestamp' in skippedProperties)) {
        testSharedMethods.assertTimestampOrder (exchange, method, symbol, trades);
    }
}

async function testFetchTrades_ArrayValues (exchange, skippedProperties, symbol, method, trades) {
    //
    // address accuracy issues: https://github.com/ccxt/ccxt/issues/18986
    //
    const sidesArray = [ 'buy', 'sell' ];
    const collectedSides = {};
    for (let i = 0; i < trades.length; i++) {
        const trade = trades[i];
        testSharedMethods.assertInArray (exchange, skippedProperties, method, trade, 'takerOrMaker', [ 'taker', undefined ]);
        testSharedMethods.assertInArray (exchange, skippedProperties, method, trade, 'side', sidesArray);
        collectedSides[trade['side']] = true;
    }
    // ensure both 'buy' & 'sell' are returned
    // (if trades are more than 100, it should be happening in most cases)
    if (trades.length >= 100) {
        if (!('side' in skippedProperties)) {
            const msg = 'side of trades are not being returned, if this error happens consistently, then it might be an implementation issue';
            for (let i = 0; i < sidesArray.length; i++) {
                const side = sidesArray[i];
                const hasSide = (side in collectedSides);
                assert (hasSide, side + ' ' + msg + testSharedMethods.logTemplate (exchange, method, trades));
            }
        }
    }
}

async function testFetchTrades_Side (exchange, skippedProperties, symbol, method, trades) {
    if (('timestamp' in skippedProperties) || ('side' in skippedProperties)) {
        return;
    }
    // Check whether side is correct. This can be found out deterministically,
    // by checking an order that has been filled with multiple trades at the
    // same time (but on different prices). The price between first and last
    // trade will definitely be directional. for example, an order with 3 fills:
    //     - 1600000000073 : ...
    //     - 1600000000111 : 0.4 ETH at 1750.40
    //     - 1600000000111 : 0.9 ETH at 1750.41
    //     - 1600000000111 : 0.33 ETH at 1750.42
    //     - 1600000000252 : ...
    // here it's definitely visible that the trades have been `buy` as it happened
    // on same timestamp and trades are increasing in price. if it was `sell` the
    // prices would have been in decreasing order. it's nearly impossible to happen
    // otherwie (if such rare event happens ever, the test can be restarted and
    // the new run would not meet such exceptional case)
    let lastTs = undefined;
    let lastPrice = undefined;
    let lastSide = undefined;
    for (let i = 0; i < trades.length; i++) {
        const trade = trades[i];
        const ts = trade['timestamp'];
        const price = exchange.safeString (trade, 'price');
        const side = trade['side'];
        //
        const isSameTs = ts === lastTs;
        lastTs = ts;
        const isSamePrice = Precise.stringEq (price, lastPrice);
        lastPrice = price;
        const isSameSide = side === lastSide;
        lastSide = side;
        //
        // we are only interested in trades, that have: same timestamp, same side but different price
        if (!isSameTs || !isSameSide || isSamePrice) {
            continue;
        }
        //
        const priceIncreasing = Precise.stringGt (price, lastPrice);
        const priceDecreasing = Precise.stringLt (price, lastPrice);
        if (priceIncreasing) {
            assert (side === 'buy', 'Side should be `buy` if price is increasing' + testSharedMethods.logTemplate (exchange, method, trade));
        } else if (priceDecreasing) {
            assert (side === 'sell', 'Side should be `sell` if price is decreasing' + testSharedMethods.logTemplate (exchange, method, trade));
        }
    }
}

export default testFetchTrades;
