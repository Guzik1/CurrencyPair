using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;

namespace Example
{
    public class CurrecyParse
    {
        public void Example()
        {
            string currencyType = "Fiat";

            CurrencyType type = CurrencyTypeExtension.Parse(currencyType);
        }
    }
}
