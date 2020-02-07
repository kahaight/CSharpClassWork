using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void PennyTests()
        {
            ICurrency penny = new Penny();
            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }
        [TestMethod]
        public void NickelTests()
        {
            ICurrency nickel = new Nickel();
            Assert.AreEqual(0.05m, nickel.Value);
            Assert.AreEqual("Nickel", nickel.Name);
        }

        [DataTestMethod]
        [DataRow(100.2d)]
        [DataRow(37.12d)]
        [DataRow(2319.18d)]
        [DataRow(1408.09d)]
        public void EPaymentTest(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }


    }
}
