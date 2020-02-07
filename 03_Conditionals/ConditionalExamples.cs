using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void IfStatement()
        {
            bool userIsHungry = true;

            if (userIsHungry)
            {
                Console.WriteLine("Eat something");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }
            else
            {
                Console.WriteLine("You will pass");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Liar!");
            }
            else
            {
                Console.WriteLine("At least you're honest");
            }

        }

        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    break;
                case 3:
                    Console.WriteLine("What?");
                    break;
                default:
                    Console.WriteLine("This is default");
                    break;
            }
        }
        [TestMethod]
        public void Ternaries()
        {
            int age = 42;
            bool isAdult = (age > 17) ? true: false;
            Console.WriteLine($"Age is over 17: {isAdult}");

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            bool isTuesday = DateTime.Now.DayOfWeek.ToString() == "Tuesday";
            Console.WriteLine("Today is " + (isTuesday ? "Tuesday" : "Not Tuesday"));
        }
    }
}
