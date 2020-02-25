using System;
using System.Collections.Generic;
using System.Text;
using CurrencyPair;

namespace Example
{
    public class GetPairFromString
    {
        public void Example()
        {
            string pair1 = "USD-EURO";
            string pair2 = "USDEURO";  // all pair support.
            string pair3 = "USDPLN";

            Pair pair11 = new Pair(pair1);
            Pair pair22 = new Pair(pair2);
            Pair pair33 = new Pair(pair3);

            // Get methods.
        }
    }
}
