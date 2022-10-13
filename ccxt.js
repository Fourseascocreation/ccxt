/*

MIT License

Copyright (c) 2017 Igor Kroitor

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

*/

//-----------------------------------------------------------------------------

import { Exchange }  from './js/base/Exchange.js'
import { Precise }   from './js/base/Precise.js'
import * as functions from './js/base/functions.js'
import * as errors   from './js/base/errors.js'
import wsExchange from './js/pro/base/Exchange.js'

//-----------------------------------------------------------------------------
// this is updated by vss.js when building

const version = '2.0.7'

Exchange.ccxtVersion = version

//-----------------------------------------------------------------------------

import aax from  './js/aax.js'
import alpaca from  './js/alpaca.js'
import ascendex from  './js/ascendex.js'
import bequant from  './js/bequant.js'
import bibox from  './js/bibox.js'
import bigone from  './js/bigone.js'
import binance from  './js/binance.js'
import binancecoinm from  './js/binancecoinm.js'
import binanceus from  './js/binanceus.js'
import binanceusdm from  './js/binanceusdm.js'
import bit2c from  './js/bit2c.js'
import bitbank from  './js/bitbank.js'
import bitbay from  './js/bitbay.js'
import bitbns from  './js/bitbns.js'
import bitcoincom from  './js/bitcoincom.js'
import bitfinex from  './js/bitfinex.js'
import bitfinex2 from  './js/bitfinex2.js'
import bitflyer from  './js/bitflyer.js'
import bitforex from  './js/bitforex.js'
import bitget from  './js/bitget.js'
import bithumb from  './js/bithumb.js'
import bitmart from  './js/bitmart.js'
import bitmex from  './js/bitmex.js'
import bitopro from  './js/bitopro.js'
import bitpanda from  './js/bitpanda.js'
import bitrue from  './js/bitrue.js'
import bitso from  './js/bitso.js'
import bitstamp from  './js/bitstamp.js'
import bitstamp1 from  './js/bitstamp1.js'
import bittrex from  './js/bittrex.js'
import bitvavo from  './js/bitvavo.js'
import bkex from  './js/bkex.js'
import bl3p from  './js/bl3p.js'
import blockchaincom from  './js/blockchaincom.js'
import btcalpha from  './js/btcalpha.js'
import btcbox from  './js/btcbox.js'
import btcex from  './js/btcex.js'
import btcmarkets from  './js/btcmarkets.js'
import btctradeua from  './js/btctradeua.js'
import btcturk from  './js/btcturk.js'
import buda from  './js/buda.js'
import bw from  './js/bw.js'
import bybit from  './js/bybit.js'
import bytetrade from  './js/bytetrade.js'
import cex from  './js/cex.js'
import coinbase from  './js/coinbase.js'
import coinbaseprime from  './js/coinbaseprime.js'
import coinbasepro from  './js/coinbasepro.js'
import coincheck from  './js/coincheck.js'
import coinex from  './js/coinex.js'
import coinfalcon from  './js/coinfalcon.js'
import coinmate from  './js/coinmate.js'
import coinone from  './js/coinone.js'
import coinspot from  './js/coinspot.js'
import crex24 from  './js/crex24.js'
import cryptocom from  './js/cryptocom.js'
import currencycom from  './js/currencycom.js'
import delta from  './js/delta.js'
import deribit from  './js/deribit.js'
import digifinex from  './js/digifinex.js'
import eqonex from  './js/eqonex.js'
import exmo from  './js/exmo.js'
import flowbtc from  './js/flowbtc.js'
import fmfwio from  './js/fmfwio.js'
import ftx from  './js/ftx.js'
import ftxus from  './js/ftxus.js'
import gate from  './js/gate.js'
import gateio from  './js/gateio.js'
import gemini from  './js/gemini.js'
import hitbtc from  './js/hitbtc.js'
import hitbtc3 from  './js/hitbtc3.js'
import hollaex from  './js/hollaex.js'
import huobi from  './js/huobi.js'
import huobijp from  './js/huobijp.js'
import huobipro from  './js/huobipro.js'
import idex from  './js/idex.js'
import independentreserve from  './js/independentreserve.js'
import indodax from  './js/indodax.js'
import itbit from  './js/itbit.js'
import kraken from  './js/kraken.js'
import kucoin from  './js/kucoin.js'
import kucoinfutures from  './js/kucoinfutures.js'
import kuna from  './js/kuna.js'
import latoken from  './js/latoken.js'
import lbank from  './js/lbank.js'
import lbank2 from  './js/lbank2.js'
import liquid from  './js/liquid.js'
import luno from  './js/luno.js'
import lykke from  './js/lykke.js'
import mercado from  './js/mercado.js'
import mexc from  './js/mexc.js'
import mexc3 from  './js/mexc3.js'
import ndax from  './js/ndax.js'
import novadax from  './js/novadax.js'
import oceanex from  './js/oceanex.js'
import okcoin from  './js/okcoin.js'
import okex from  './js/okex.js'
import okex5 from  './js/okex5.js'
import okx from  './js/okx.js'
import paymium from  './js/paymium.js'
import phemex from  './js/phemex.js'
import poloniex from  './js/poloniex.js'
import probit from  './js/probit.js'
import qtrade from  './js/qtrade.js'
import ripio from  './js/ripio.js'
import stex from  './js/stex.js'
import therock from  './js/therock.js'
import tidebit from  './js/tidebit.js'
import tidex from  './js/tidex.js'
import timex from  './js/timex.js'
import tokocrypto from  './js/tokocrypto.js'
import upbit from  './js/upbit.js'
import wavesexchange from  './js/wavesexchange.js'
import wazirx from  './js/wazirx.js'
import whitebit from  './js/whitebit.js'
import woo from  './js/woo.js'
import yobit from  './js/yobit.js'
import zaif from  './js/zaif.js'
import zb from  './js/zb.js'
import zipmex from  './js/zipmex.js'
import zonda from  './js/zonda.js'


// pro exchanges
import aaxPro from  './js/pro/aax.js'
import ascendexPro from  './js/pro/ascendex.js'
import bequantPro from  './js/pro/bequant.js'
import binancePro from  './js/pro/binance.js'
import binancecoinmPro from  './js/pro/binancecoinm.js'
import binanceusPro from  './js/pro/binanceus.js'
import binanceusdmPro from  './js/pro/binanceusdm.js'
import bitcoincomPro from  './js/pro/bitcoincom.js'
import bitfinexPro from  './js/pro/bitfinex.js'
import bitfinex2Pro from  './js/pro/bitfinex2.js'
import bitmartPro from  './js/pro/bitmart.js'
import bitmexPro from  './js/pro/bitmex.js'
import bitoproPro from  './js/pro/bitopro.js'
import bitstampPro from  './js/pro/bitstamp.js'
import bittrexPro from  './js/pro/bittrex.js'
import bitvavoPro from  './js/pro/bitvavo.js'
import bybitPro from  './js/pro/bybit.js'
import coinbaseprimePro from  './js/pro/coinbaseprime.js'
import coinbaseproPro from  './js/pro/coinbasepro.js'
import coinexPro from  './js/pro/coinex.js'
import cryptocomPro from  './js/pro/cryptocom.js'
import currencycomPro from  './js/pro/currencycom.js'
import exmoPro from  './js/pro/exmo.js'
import ftxPro from  './js/pro/ftx.js'
import ftxusPro from  './js/pro/ftxus.js'
import gatePro from  './js/pro/gate.js'
import gateioPro from  './js/pro/gateio.js'
import hitbtcPro from  './js/pro/hitbtc.js'
import hollaexPro from  './js/pro/hollaex.js'
import huobiPro from  './js/pro/huobi.js'
import huobijpPro from  './js/pro/huobijp.js'
import huobiproPro from  './js/pro/huobipro.js'
import idexPro from  './js/pro/idex.js'
import krakenPro from  './js/pro/kraken.js'
import kucoinPro from  './js/pro/kucoin.js'
import mexcPro from  './js/pro/mexc.js'
import ndaxPro from  './js/pro/ndax.js'
import okcoinPro from  './js/pro/okcoin.js'
import okexPro from  './js/pro/okex.js'
import okxPro from  './js/pro/okx.js'
import phemexPro from  './js/pro/phemex.js'
import ripioPro from  './js/pro/ripio.js'
import upbitPro from  './js/pro/upbit.js'
import whitebitPro from  './js/pro/whitebit.js'
import zbPro from  './js/pro/zb.js'
import zipmexPro from  './js/pro/zipmex.js'


const exchanges = {
    'aax':                    aax,
    'alpaca':                 alpaca,
    'ascendex':               ascendex,
    'bequant':                bequant,
    'bibox':                  bibox,
    'bigone':                 bigone,
    'binance':                binance,
    'binancecoinm':           binancecoinm,
    'binanceus':              binanceus,
    'binanceusdm':            binanceusdm,
    'bit2c':                  bit2c,
    'bitbank':                bitbank,
    'bitbay':                 bitbay,
    'bitbns':                 bitbns,
    'bitcoincom':             bitcoincom,
    'bitfinex':               bitfinex,
    'bitfinex2':              bitfinex2,
    'bitflyer':               bitflyer,
    'bitforex':               bitforex,
    'bitget':                 bitget,
    'bithumb':                bithumb,
    'bitmart':                bitmart,
    'bitmex':                 bitmex,
    'bitopro':                bitopro,
    'bitpanda':               bitpanda,
    'bitrue':                 bitrue,
    'bitso':                  bitso,
    'bitstamp':               bitstamp,
    'bitstamp1':              bitstamp1,
    'bittrex':                bittrex,
    'bitvavo':                bitvavo,
    'bkex':                   bkex,
    'bl3p':                   bl3p,
    'blockchaincom':          blockchaincom,
    'btcalpha':               btcalpha,
    'btcbox':                 btcbox,
    'btcex':                  btcex,
    'btcmarkets':             btcmarkets,
    'btctradeua':             btctradeua,
    'btcturk':                btcturk,
    'buda':                   buda,
    'bw':                     bw,
    'bybit':                  bybit,
    'bytetrade':              bytetrade,
    'cex':                    cex,
    'coinbase':               coinbase,
    'coinbaseprime':          coinbaseprime,
    'coinbasepro':            coinbasepro,
    'coincheck':              coincheck,
    'coinex':                 coinex,
    'coinfalcon':             coinfalcon,
    'coinmate':               coinmate,
    'coinone':                coinone,
    'coinspot':               coinspot,
    'crex24':                 crex24,
    'cryptocom':              cryptocom,
    'currencycom':            currencycom,
    'delta':                  delta,
    'deribit':                deribit,
    'digifinex':              digifinex,
    'eqonex':                 eqonex,
    'exmo':                   exmo,
    'flowbtc':                flowbtc,
    'fmfwio':                 fmfwio,
    'ftx':                    ftx,
    'ftxus':                  ftxus,
    'gate':                   gate,
    'gateio':                 gateio,
    'gemini':                 gemini,
    'hitbtc':                 hitbtc,
    'hitbtc3':                hitbtc3,
    'hollaex':                hollaex,
    'huobi':                  huobi,
    'huobijp':                huobijp,
    'huobipro':               huobipro,
    'idex':                   idex,
    'independentreserve':     independentreserve,
    'indodax':                indodax,
    'itbit':                  itbit,
    'kraken':                 kraken,
    'kucoin':                 kucoin,
    'kucoinfutures':          kucoinfutures,
    'kuna':                   kuna,
    'latoken':                latoken,
    'lbank':                  lbank,
    'lbank2':                 lbank2,
    'liquid':                 liquid,
    'luno':                   luno,
    'lykke':                  lykke,
    'mercado':                mercado,
    'mexc':                   mexc,
    'mexc3':                  mexc3,
    'ndax':                   ndax,
    'novadax':                novadax,
    'oceanex':                oceanex,
    'okcoin':                 okcoin,
    'okex':                   okex,
    'okex5':                  okex5,
    'okx':                    okx,
    'paymium':                paymium,
    'phemex':                 phemex,
    'poloniex':               poloniex,
    'probit':                 probit,
    'qtrade':                 qtrade,
    'ripio':                  ripio,
    'stex':                   stex,
    'therock':                therock,
    'tidebit':                tidebit,
    'tidex':                  tidex,
    'timex':                  timex,
    'tokocrypto':             tokocrypto,
    'upbit':                  upbit,
    'wavesexchange':          wavesexchange,
    'wazirx':                 wazirx,
    'whitebit':               whitebit,
    'woo':                    woo,
    'yobit':                  yobit,
    'zaif':                   zaif,
    'zb':                     zb,
    'zipmex':                 zipmex,
    'zonda':                  zonda,
}

const pro = {
    'aax':                    aaxPro,
    'ascendex':               ascendexPro,
    'bequant':                bequantPro,
    'binance':                binancePro,
    'binancecoinm':           binancecoinmPro,
    'binanceus':              binanceusPro,
    'binanceusdm':            binanceusdmPro,
    'bitcoincom':             bitcoincomPro,
    'bitfinex':               bitfinexPro,
    'bitfinex2':              bitfinex2Pro,
    'bitmart':                bitmartPro,
    'bitmex':                 bitmexPro,
    'bitopro':                bitoproPro,
    'bitstamp':               bitstampPro,
    'bittrex':                bittrexPro,
    'bitvavo':                bitvavoPro,
    'bybit':                  bybitPro,
    'coinbaseprime':          coinbaseprimePro,
    'coinbasepro':            coinbaseproPro,
    'coinex':                 coinexPro,
    'cryptocom':              cryptocomPro,
    'currencycom':            currencycomPro,
    'exmo':                   exmoPro,
    'ftx':                    ftxPro,
    'ftxus':                  ftxusPro,
    'gate':                   gatePro,
    'gateio':                 gateioPro,
    'hitbtc':                 hitbtcPro,
    'hollaex':                hollaexPro,
    'huobi':                  huobiPro,
    'huobijp':                huobijpPro,
    'huobipro':               huobiproPro,
    'idex':                   idexPro,
    'kraken':                 krakenPro,
    'kucoin':                 kucoinPro,
    'mexc':                   mexcPro,
    'ndax':                   ndaxPro,
    'okcoin':                 okcoinPro,
    'okex':                   okexPro,
    'okx':                    okxPro,
    'phemex':                 phemexPro,
    'ripio':                  ripioPro,
    'upbit':                  upbitPro,
    'whitebit':               whitebitPro,
    'zb':                     zbPro,
    'zipmex':                 zipmexPro,
}

for (const exchange in pro) {
    const ccxtExchange = exchanges[exchange]
    const baseExchange = Object.getPrototypeOf (ccxtExchange)
    if (baseExchange.name === 'Exchange') {
        Object.setPrototypeOf (ccxtExchange, wsExchange)
        Object.setPrototypeOf (ccxtExchange.prototype, wsExchange.prototype)
    }
}

pro.exchanges = Object.keys (pro)

//-----------------------------------------------------------------------------

const ccxt = Object.assign ({ version, Exchange, Precise, 'exchanges': Object.keys (exchanges), 'pro': pro}, exchanges, functions, errors)

export {
    version,
    Exchange,
    exchanges,
    pro,
    Precise,
    functions,
    errors,
    aax,
    alpaca,
    ascendex,
    bequant,
    bibox,
    bigone,
    binance,
    binancecoinm,
    binanceus,
    binanceusdm,
    bit2c,
    bitbank,
    bitbay,
    bitbns,
    bitcoincom,
    bitfinex,
    bitfinex2,
    bitflyer,
    bitforex,
    bitget,
    bithumb,
    bitmart,
    bitmex,
    bitopro,
    bitpanda,
    bitrue,
    bitso,
    bitstamp,
    bitstamp1,
    bittrex,
    bitvavo,
    bkex,
    bl3p,
    blockchaincom,
    btcalpha,
    btcbox,
    btcex,
    btcmarkets,
    btctradeua,
    btcturk,
    buda,
    bw,
    bybit,
    bytetrade,
    cex,
    coinbase,
    coinbaseprime,
    coinbasepro,
    coincheck,
    coinex,
    coinfalcon,
    coinmate,
    coinone,
    coinspot,
    crex24,
    cryptocom,
    currencycom,
    delta,
    deribit,
    digifinex,
    eqonex,
    exmo,
    flowbtc,
    fmfwio,
    ftx,
    ftxus,
    gate,
    gateio,
    gemini,
    hitbtc,
    hitbtc3,
    hollaex,
    huobi,
    huobijp,
    huobipro,
    idex,
    independentreserve,
    indodax,
    itbit,
    kraken,
    kucoin,
    kucoinfutures,
    kuna,
    latoken,
    lbank,
    lbank2,
    liquid,
    luno,
    lykke,
    mercado,
    mexc,
    mexc3,
    ndax,
    novadax,
    oceanex,
    okcoin,
    okex,
    okex5,
    okx,
    paymium,
    phemex,
    poloniex,
    probit,
    qtrade,
    ripio,
    stex,
    therock,
    tidebit,
    tidex,
    timex,
    tokocrypto,
    upbit,
    wavesexchange,
    wazirx,
    whitebit,
    woo,
    yobit,
    zaif,
    zb,
    zipmex,
    zonda,    
}

export default ccxt;

//-----------------------------------------------------------------------------
