using NUnit.Framework;
using CurrencyPair;

namespace CurrencyPairTests
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void GetFirstCurrencyTest()
        {
            Pair pair = new Pair(Currency.EURO, Currency.DASH);

            Assert.AreEqual(Currency.EURO, pair.GetFirstCurrency);
        }

        [Test]
        public void GetSecondCurrencyTest()
        {
            Pair pair = new Pair(Currency.USD, Currency.BTC);

            Assert.AreEqual(Currency.BTC, pair.GetSecondCurrency);
        }

        [Test]
        public void PairToStringTest()
        {
            Pair pair = new Pair(Currency.USD, Currency.EURO);

            Assert.AreEqual("USDEURO", pair.ToString());
        }

        [Test]
        public void PairToStringWithDashTest()
        {
            Pair pair = new Pair(Currency.USD, Currency.BTC);

            Assert.AreEqual("USD-BTC", pair.ToStringWithDash());
        }

        [Test]
        public void PairToStringWithLowerDashTest()
        {
            Pair pair = new Pair(Currency.USD, Currency.GBP);

            Assert.AreEqual("USD_GBP", pair.ToStringWithLowerDash());
        }
    }
}