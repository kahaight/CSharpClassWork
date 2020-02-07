using System;
using System.Collections.Generic;
using _07_CalculatorChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_CalculatorChallengeTests
{
    [TestClass]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [TestMethod]
        public void AddTwoNumbers_ShouldReturnSum()
        {
            double sum = calculator.AddTwoNumbers(2d, 2d);
            double expected = 4d;
            Assert.AreEqual(expected, sum);
        }

        [TestMethod]
        public void SubtractTwoNumbers_ShouldReturnDifference()
        {
            double difference = calculator.SubtractTwoNumbers(2d, 2d);
            double expected = 0;
            Assert.AreEqual(expected, difference);
        }

        [TestMethod]
        public void MultiplyTwoNumbers_ShouldReturnProduct()
        {
            double product = calculator.MultiplyTwoNumbers(2d, 2d);
            double expected = 4;
            Assert.AreEqual(expected, product);
        }

        [TestMethod]
        public void DivideTwoNumbers_ShouldReturnQuotient()
        {
            double quotient = calculator.DivideTwoNumbers(2d, 2d);
            double expected = 1;
            Assert.AreEqual(expected, quotient);
        }

        [TestMethod]
        public void AddMultipleNumbers_ShouldReturnSum()
        {
            List<double> listOfAddends = new List<double> { 5d, 6d, 8d };

            double sum = calculator.AddMultipleNumbers(listOfAddends);
            double expected = 19;
            Assert.AreEqual(expected, sum);
        }

        [TestMethod]
        public void SubtractMultipleNumbers_ShouldReturnDifference()
        {
            List<double> listOfSubtrahends = new List<double> { 5d, 6d, 8d };

            double difference = calculator.SubtractMultipleNumbers(listOfSubtrahends);
            double expected = -9d;
            Assert.AreEqual(expected, difference);
        }

        [TestMethod]
        public void MultiplyMultipleNumbers_ShouldReturnProduct()
        {
            List<double> listOfMultipliers = new List<double> { 5d, 6d, 8d };

            double product = calculator.MultiplyMultipleNumbers(listOfMultipliers);
            double expected = 240d;
            Assert.AreEqual(expected, product);
        }

        [TestMethod]
        public void DivideMultipleNumbers_ShouldReturnProduct()
        {
            List<double> listOfDivisors = new List<double> { 5d, 6d, 8d };

            double quotient = calculator.DivideMultipleNumbers(listOfDivisors);
            double expected = 5d/6d/8d;
            Assert.AreEqual(expected, quotient);
        }

        //[TestMethod]
        //public void DivideTwoNumbersReturnSimplifiedFraction_ShouldReturnString()
        //{
        //    string fraction = calculator.DivideTwoNumsReturnSimplifiedFraction(20 , 2);
        //    int wholeNumber = 2;
        //    int remainderNumerator = 0;
        //    int remainderDenominator = 0;
        //    string expected = $"The answer is {wholeNumber} and {remainderNumerator} out of {remainderDenominator}";
        //    Assert.AreEqual(expected, fraction);
        //    Console.WriteLine(fraction);
        //}

        [TestMethod]
        public void DivideReturnMixedNumberTest()
        {
            string actual = Calculator.DivideReturnMixedNumber(100000, 68);
        }
        [TestMethod]
        public void DivideReturnMixedNumberTest2()
        {
            Console.WriteLine(Calculator.DivideReturnMixedNumber(68, 1000000));
        }
    }
}
