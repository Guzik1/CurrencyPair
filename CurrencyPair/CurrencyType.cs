using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyPair
{
    /// <summary>
    /// Currency type enumerator.
    /// </summary>
    public enum CurrencyType
    {
        /// <summary> Crypto currency </summary>
        CRYPTO,
        /// <summary> Real/fiat currency  </summary>
        FIAT
    }

    /// <summary>
    /// Extension method to CurrencyType enum.
    /// </summary>
    public static class CurrencyTypeExtension
    {
        /// <summary>
        /// Parse string name to CurrencyType
        /// </summary>
        /// <param name="name">String to parse.</param>
        /// <returns>Currency type.</returns>
        public static CurrencyType Parse(string name)
        {
            return CurrencyParser.Parse<CurrencyType>(name);
        }
    }
}
