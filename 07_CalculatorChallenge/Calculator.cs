using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_CalculatorChallenge
{
    /*Calculator w/ Tests Challenge
Create a Calculator class that has the ability to complete all of the following processes:
    Add
    Subtract
    Multiply
    Divide
Write Unit Tests for all of your calculator's functionalities.*/



    public class Calculator
    {
        public double AddTwoNumbers(double terms, double addends)
        {
            return terms + addends;
        }

        public double SubtractTwoNumbers(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }
        public double MultiplyTwoNumbers(double multiplier, double multiplicand)
        {
            return multiplier * multiplicand;
        }
        public double DivideTwoNumbers(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        /*Allow the calculator to take in as many numbers as the user provides*/
        public double AddMultipleNumbers(List<double> listOfAddends)
        {
            double terms = listOfAddends[0];
            for (int i = 1; i <= listOfAddends.Count() - 1; i++)
            {
                terms = terms + listOfAddends[i];
            }
            return terms;

        }

        public double SubtractMultipleNumbers(List<double> listOfSubtrahends)
        {
            double minuend = listOfSubtrahends[0];
            for (int i = 1; i <= listOfSubtrahends.Count() - 1; i++)
            {
                minuend = minuend - listOfSubtrahends[i];
            }
            return minuend;
        }
        public double MultiplyMultipleNumbers(List<double> listOfMultipliers)
        {
            double multiplicand = listOfMultipliers[0];
            for (int i = 1; i <= listOfMultipliers.Count() - 1; i++)
            {
                multiplicand = multiplicand * listOfMultipliers[i];
            }
            return multiplicand;
        }
        public double DivideMultipleNumbers(List<double> listOfDivisors)
        {
            double dividend = listOfDivisors[0];
            for (int i = 1; i <= listOfDivisors.Count() - 1; i++)
            {
                dividend = dividend / listOfDivisors[i];
            }
            return dividend;
        }
        /*Have the ability to return fractions instead of percentages*/
        public string DivideTwoNumsReturnSimplifiedFraction(int intOne, int intTwo)
        {
            int remainderNumerator;
            if (intOne <= intTwo)
            {
                remainderNumerator = intOne;
            }
            else
            {
                remainderNumerator = intOne % intTwo;
            }
            int wholeNumber = intOne / intTwo;
            int remainderDenominator = intTwo;

            for (int i = 2; i <= 9; i++)
            {
                if (remainderNumerator % i == 0 && remainderDenominator % i == 0)
                {
                    do
                    {
                        remainderNumerator = remainderNumerator / i;
                        remainderDenominator = remainderDenominator / i;
                    }
                    while (remainderNumerator % i == 0 && remainderDenominator % i == 0);
                }
                else
                {
                    continue;
                }
            }
            string answer = $"The answer is {wholeNumber} and {remainderNumerator} out of {remainderDenominator}";
            return answer;
        }

        public static string DivideReturnMixedNumber(int num, int numTwo)
        {
            int wholeNumber = num / numTwo;
            int remainder = num % numTwo;
            int gcd = GCD(remainder, numTwo);
            int numerator = remainder / gcd;
            int denominator = numTwo / gcd;
            if (numTwo > num && gcd == 1)
            {
                return $"{num}/{numTwo}";
            }
            else if (numTwo > num && gcd != 1)
            {
                return $"{num / gcd}/{numTwo / gcd}";
            }
            else if (remainder == 0)
            {
                return $"{wholeNumber}";
            }
            else if (gcd == 1)
            {
                return $"{wholeNumber} {remainder}/{numTwo}";
            }
            else
            {
                return $"{wholeNumber} {numerator}/{denominator}";
            }
        }

        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            if (a == 0)
                return b;
            else
                return a;
        }
    }
}
