using System;
using CurrencyPair;

namespace Example
{
    public class SimplePair
    {
        public void Example()
        {
            Pair pair = new Pair(Currency.USD, Currency.EURO);

            Console.WriteLine(pair.ToString());  // get string format firstsecond
            Console.WriteLine(pair.ToStringWithDash());  // get string format first-second
            Console.WriteLine(pair.ToStringWithLowerDash());  // get string format first_second

            Currency first = pair.GetFirstCurrency;
            Currency second = pair.GetSecondCurrency;
        }
    }
}
