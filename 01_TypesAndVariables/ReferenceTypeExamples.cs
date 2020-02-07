using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            //Reference type vs value type 
            string firstName = "Konrad";
            string lastName = "Haight";

            string concatenatedFullName = firstName + " " + lastName;


            Console.WriteLine(concatenatedFullName);

            string compositedFullName = string.Format("I am {0} {1}", firstName, lastName);

            Console.WriteLine(compositedFullName);

            string interpolatedFullName = $"{firstName} {lastName}";

            Console.WriteLine(interpolatedFullName);

        }

        [TestMethod]
        public void Collections()
        {
            //Array
            string stringExample = "Hello World";
            string[] stringArray = { "Hello", "World", "!", "Why", "is", "it", "always", stringExample, "?" };
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            stringArray[0] = "Goodbye";
            Console.WriteLine(stringArray[0]);

            //List
            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();
            listOfStrings.Add("First string in our list");
            listOfInts.Add(32);
            listOfStrings.AddRange(stringArray);

            //Queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next in line");
            string firstDequeue = firstInFirstOut.Dequeue();

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(22, "string");
            string value22 = keyAndValue[22];
            Console.WriteLine(value22);

            //other collections
            SortedList<int, string> sortedKeyAndValuePair = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();

            



        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();
            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);
        }

    }
}
