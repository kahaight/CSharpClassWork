using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodsChallenges
    {
        public string CharPrinter(string name)
        {
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
                return name;
        }

        [TestMethod]
        public void MyTestMethod()
        {
            CharPrinter("Konrad");
        }
    }
}
