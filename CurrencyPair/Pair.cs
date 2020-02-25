using System;
using System.Text;

namespace CurrencyPair
{
    /// <summary>
    /// Currency pair.
    /// </summary>
    [Serializable]
    public class Pair
    {
        Currency first;
        Currency second;

        /// <summary>
        /// Inicjalize pair from two currency.
        /// </summary>
        /// <param name="first">First currency.</param>
        /// <param name="second">Second currency.</param>
        public Pair(Currency first, Currency second)
        {
            this.first = first;
            this.second = second;
        }

        /// <summary>
        /// Inicjalize pair from marekt string.
        /// </summary>
        /// <param name="marketCode">Code to convert.</param>
        //[JsonConstructor]
        public Pair(string marketCode)
        {
            if (marketCode.Contains('-'))
                ParseFromStringWithDash(marketCode);
            else
                ParseFromStringWithoutDash(marketCode);
        }

        void ParseFromStringWithDash(string marketCode)
        {
            string[] temp = marketCode.Split('-');

            ParseCurrency(temp[0], temp[1]);
        }

        void ParseFromStringWithoutDash(string marketCode)
        {
            if (marketCode.Length == 6)
                SplitEqualLenghtMarketCode(marketCode, 3);
            else if(marketCode.Length == 7)
            {
                TryParseOneFourSignCurrencyCurrency(marketCode, true);
            }
            else
                SplitEqualLenghtMarketCode(marketCode, 4);
        }

        void SplitEqualLenghtMarketCode(string marketCode, int currencyLenght)
        {
            string sFirst = marketCode.Substring(0, currencyLenght);
            string sSecond = marketCode.Substring(currencyLenght, currencyLenght);

            ParseCurrency(sFirst, sSecond);
        }

        void ParseCurrency(string firstString, string secondString)
        {
            first = CurrencyParse.Parse<Currency>(firstString);
            second = CurrencyParse.Parse<Currency>(secondString);
        }

        void TryParseOneFourSignCurrencyCurrency(string marketCode, bool fourSignCurrencyInAFirstPosition)
        {
            try
            {
                string sFirst, sSecond;

                if (fourSignCurrencyInAFirstPosition)
                {
                    sFirst = marketCode.Substring(0, 4);
                    sSecond = marketCode.Substring(4, 3);
                }
                else
                {
                    sFirst = marketCode.Substring(0, 3);
                    sSecond = marketCode.Substring(3, 4);
                }

                ParseCurrency(sFirst, sSecond);
            }
            catch
            {
                if(fourSignCurrencyInAFirstPosition)
                    TryParseOneFourSignCurrencyCurrency(marketCode, false);
            }
        }

        /// <summary>
        /// Get first currency in pair.
        /// </summary>
        public Currency GetFirstCurrency => first;

        /// <summary>
        /// Get second currency in pair.
        /// </summary>
        public Currency GetSecondCurrency => second;

        /// <summary>
        /// Convert pair to string.
        /// </summary>
        /// <returns>Pair string, format first + second (firstsecond)</returns>
        public override string ToString() => first + "" + second;

        /// <summary>
        /// Convert pair to string with dash.
        /// </summary>
        /// <returns>Pair string, format first + "-" + second (first-second)</returns>
        public string ToStringWithDash() => first + "-" + second;

        /// <summary>
        /// Convert pair to string with lower dash.
        /// </summary>
        /// <returns>Pair string, format first + "_" + second (first_second)</returns>
        public string ToStringWithLowerDash() => first + "_" + second;
    }
}
