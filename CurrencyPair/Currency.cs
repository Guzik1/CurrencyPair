using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyPair
{
    /// <summary>
    /// List of real/fiat and crypto currency.
    /// </summary>
    public enum Currency
    {
        // Fiat
        /// <summary>United States dollar</summary>
        USD,
        /// <summary>Euro</summary>
        EURO,
        /// <summary>Pound sterling</summary>
        GBP,
        /// <summary>Polish zloty</summary>
        PLN,

        // Crypto
        /// <summary>Bitcoin</summary>
        BTC,
        /// <summary>Etherum</summary>
        ETH,
        /// <summary>Etherum clasic</summary>
        ETC,
        /// <summary>Dash</summary>
        DASH,
        /// <summary>Ripple</summary>
        XRP,
        /// <summary>Zcash</summary>
        ZEC,
        /// <summary>Bitcoin cash</summary>
        BCC,
        /// <summary>Litecoin</summary>
        LTC,
        /// <summary>Lisk</summary>
        LSK,
        /// <summary>Game credits</summary>
        GAME,
        /// <summary>Bitcoin gold</summary>
        BTG,
        /// <summary>KzCash</summary>
        KZC,
        /// <summary>Infinty economics</summary>
        XIN,
        /// <summary>Golem</summary>
        GNT,
        /// <summary>OmiseGO</summary>
        OMG,
        /// <summary>FuturoCoin</summary>
        FTO,
        /// <summary>Augur</summary>
        REP,
        /// <summary>0x</summary>
        ZRX,
        /// <summary>TenX</summary>
        PAY,
        /// <summary>Basic Attention Token</summary>
        BAT,
        /// <summary>Neumark</summary>
        NEU,
        /// <summary>Tron</summary>
        TRX,
        /// <summary>AMLT</summary>
        AMLT,
        /// <summary>Experty</summary>
        EXY,
        /// <summary>Bob's repair</summary>
        BOB,
        /// <summary>Lisk machine learning</summary>
        LML,
        /// <summary>Bitcoin SV</summary>
        BSV,
        /// <summary>Blockchain poland</summary>
        BCP,
        /// <summary>Bitex global XBX coin</summary>
        XBX,
        /// <summary>Stellar</summary>
        XLM,
        /// <summary>Algory</summary>
        ALG,
        /// <summary>Chainlink</summary>
        LINK,
        /// <summary>Maker</summary>
        MKR,        
        /// <summary>Pundi X</summary>
        NPXS,
        /// <summary>Sirin Labs</summary>
        SRN,
        /// <summary>Global game coin</summary>
        GGC,
        /// <summary>USD coin</summary>
        USDC,

        // TODO: Add more currency.
    }

    /// <summary>
    /// Extension method to Currency enum.
    /// </summary>
    public static class CurrencyExtension
    {
        /// <summary>
        /// Parse string name to Currency enum.
        /// </summary>
        /// <param name="name">String to parse.</param>
        /// <returns>Currency enumeration.</returns>
        public static Currency Parse(string name)
        {
            return CurrencyParser.Parse<Currency>(name);
        }
    }
}
