using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _09_Interfaces_WorkingWithDI
{
    [TestClass]
    public class TransactionTests
    {

        private decimal _debt;
        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You paid {payment.Value} towards your debt");
        }
        [TestInitialize]
        public void Arrange()
        {
            _debt = 9080.30m;
        }
        [TestMethod]
        public void PayDebtTest()
        {
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(450m));
            decimal expected = 9080.30m - 451m;
            Assert.AreEqual(expected, _debt);
        }
        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(123.4m);
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);
            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());
            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());
            Assert.AreEqual(123.4m, secondTransaction.GetAmount());
        }

        [TestMethod]
        public void MoreExamples()
        {
            var list = new List<Transaction>
            {
                new Transaction(new Dollar()),
                new Transaction(new ElectronicPayment(231.95m)),
                new Transaction(new Penny()),
                new Transaction(new Nickel())
            };

            foreach (var transaction in list)
            {
                var type = transaction.GetTransactionType();
                var amount = transaction.GetAmount();
                Console.WriteLine($"{type} {amount} {transaction.DateOfTransaction}");
            }
        }
    }
}
