using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyChangerBC;

namespace MoneyChanger.Tests
{
    [TestFixture]
    public class MoneyChangerTest
    {
        [Test]
        public void BuyCurrencyZeroAmount()
        {
            ExchangeBC bc = new ExchangeBC();
            var result = bc.SellCurrecy(0, "USD");

            Assert.AreEqual(0, result.ExchangeRate);
            Assert.AreEqual("Please enter correct amount", result.Message);
        }

        [Test]
        public void SellCurrencyZeroAmount()
        {
            ExchangeBC bc = new ExchangeBC();
            var result = bc.SellCurrecy(0, "USD");

            Assert.AreEqual(0, result.ExchangeRate);
            Assert.AreEqual("Please enter correct amount", result.Message);
        }
    }
}
