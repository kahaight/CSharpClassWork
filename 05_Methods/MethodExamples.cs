using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        //1    //2  //3
        public void SayHello(string name)
        {
            //1 - public = access modifier
            //2 - void = return type
            //3 - method signature Name/parameter

            Console.WriteLine($"Hello, {name}!");

        }

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;

            // also correct
            // return numOne + numTwo;
        }


        public int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public int Remainder(int numOne, int numTwo)
        {
            return numOne % numTwo;
        }

        public double Divide(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }
        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public int Factor(int numOne)
        {
            int i, fact = 1;
            for (i = 1; i <= numOne; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        private int CalculateAge(DateTime birthday)
        {

            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }

        [TestMethod]
        public void MethodExecution()
        {
            SayHello("George");
            SayHello("Fredrico");

            //If you build a method to require an argument then it only works if you give it an argument of the type you selected when you built it

            int sum = Add(5, 6);
            Console.WriteLine(sum);

            int difference = Subtract(10, 20);
            Console.WriteLine(difference);

            int remainder = Remainder(10, 20);
            Console.WriteLine(remainder);

            double quotient = Divide(10d, 20d);
            Console.WriteLine(quotient);

            int product = Multiply(10, 20);
            Console.WriteLine(product);

            int Factorial = Factor(5);
            Console.WriteLine(Factorial);

            Add(1, 2);


            DateTime birthdate = new DateTime(1987, 3, 23);
            int age = CalculateAge(birthdate);
            Console.WriteLine(age);


            //overloaded methods, two methods of the same name, different parameters//
        }

        [TestMethod]
        public double Quotient(int intOne, int intTwo) 
        {
            double doubleOne = Convert.ToDouble(intOne);
            double doubleTwo = Convert.ToDouble(intTwo);


            return doubleOne / doubleTwo; 
        }
        [TestMethod]
        public void DoubleTestMethod()
        {
        double quotient = Quotient(1, 2);

            Console.WriteLine(quotient);

        }

    }
}
