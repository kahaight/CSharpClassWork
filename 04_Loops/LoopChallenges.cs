using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class LoopChallenges
    {
        [TestMethod]
        public void While()
        {
            int x = 1;
            while (x < 50)
            {
                Console.WriteLine(x);
                x += 2;

            }

        }

        [TestMethod]
        public void For()
        {


            for (int i = 5; i <= 50; i += 5)
            {
                Console.WriteLine(i);
            }

        }

        [TestMethod]
        public void Foreach()
        {
            float[] numbers = { 5, 42, 3, 3, 3, 3, 3, 3.14159f };
            foreach (float number in numbers)
            {
                Console.WriteLine($"{number} is a nice number");
            }

        }
        [TestMethod]
        public void DoWhile()
        {
            int x = 1;
            do
            {
                Console.WriteLine("the loop is finished");
                x++;
            }
            while (x == 1);

        }
    }
}

