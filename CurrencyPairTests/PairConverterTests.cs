using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CurrencyPair;

namespace CurrencyPairTests
{
    [TestFixture]
    public class PairConverterTests
    {
        [Test]
        public void PairWithDashConvertTest()
        {
            string sPair = "USD-PLN";

            Pair pair = new Pair(sPair);

            Assert.AreEqual(Currency.USD, pair.GetFirstCurrency);
            Assert.AreEqual(Currency.PLN, pair.GetSecondCurrency);
        }

        [Test]
        public void PairWithoutDashConvertTest()
        {
            string sPair = "USDPLN";

            Pair pair = new Pair(sPair);

            Assert.AreEqual(Currency.USD, pair.GetFirstCurrency);
            Assert.AreEqual(Currency.PLN, pair.GetSecondCurrency);
        }

        [Test]
        public void PairConvertFourSignInFirstCurrencyTest()
        {
            string sPair = "EUROUSD";

            Pair pair = new Pair(sPair);

            Assert.AreEqual(Currency.EURO, pair.GetFirstCurrency);
            Assert.AreEqual(Currency.USD, pair.GetSecondCurrency);
        }


        [Test]
        public void PairConvertFourSignInScondaryCurrencyTest()
        {
            string sPair = "GBPDASH";

            Pair pair = new Pair(sPair);

            Assert.AreEqual(Currency.GBP, pair.GetFirstCurrency);
            Assert.AreEqual(Currency.DASH, pair.GetSecondCurrency);
        }

        [Test]
        public void PairConvertTwoFourSignCurrencyTest()
        {
            string sPair = "EURODASH";

            Pair pair = new Pair(sPair);

            Assert.AreEqual(Currency.EURO, pair.GetFirstCurrency);
            Assert.AreEqual(Currency.DASH, pair.GetSecondCurrency);
        }
    }
}
