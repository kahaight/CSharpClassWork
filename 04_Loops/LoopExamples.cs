using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false");
            }
            while (false);
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 34;
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Craig", "Justin", "Isaiah" };
            int x = 1;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class {students[i]}!");
            }

        }
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);
                total++;
            }


            Random rand = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    //keepLooping = false;
                    break;
                }

            }


        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Nick", "Craig", "Justin", "Isaiah", "Tom", "Un Yon", "Josh" };

            foreach (string student in students)
            {
                Console.WriteLine(student + "is a child");
            }

            string myName = "Konrad Avery Haight";

            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void PasswordChallenge()
        {
            //Your client needs a secure key for their website's customers. You need to write the code that generates a string that has 10 random alphanumeric characters. Your client would like the each code to not include any vowels. He also hates the number 13, so make sure none of your codes include the number 13!

            Random randOne = new Random();
            Random randTwo = new Random();
            Random randThree = new Random();

            string[] letters = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            int intOne = 0;


            for (int i = 0; i < 100; i++)
            {
                string customerKey = "";
                int intTracker = 0;
                while (intTracker < 10)
                {
                    int randNumber = randOne.Next(0, 10);
                    int randLetter = randTwo.Next(0, 21);
                    int coinFlip = randThree.Next(0, 2);

                    if (coinFlip == 0)
                    {
                        if (intOne != 1)
                        {
                            intOne = randNumber;
                            intTracker++;
                            string number = randNumber.ToString();
                            customerKey = $"{customerKey}{number}";
                        }
                        else if (intOne == 1 && randNumber == 3)
                        {
                            continue;
                        }
                        else
                        {
                            intOne = randNumber;
                            intTracker++;
                            string number = randNumber.ToString();
                            customerKey = $"{customerKey}{number}";
                        }
                    }
                    else if (coinFlip == 1)
                    {
                        string letter = letters[randLetter];
                        intTracker++;
                        customerKey = $"{customerKey}{letter}";
                    }
                    else
                    {
                        Console.WriteLine("Something is wrong");
                    }
                }
                Console.WriteLine(customerKey);

            }

        }

        [TestMethod]
        public void InstructorChallenge()
        {
            List<string> allKeys = new List<string>();
            List<string> duplicates = new List<string>();
            Random rand = new Random();

            for (int i = 0; i < 10000; i++)
            {
                string customerKey = "";
                string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                while (customerKey.Length < 5)
                {
                    int randomNumber = rand.Next(0, characters.Length);
                    char nextCharacter = characters[randomNumber];

                    if (customerKey.EndsWith("1") && nextCharacter == '3')
                    {
                        continue;
                    }

                    customerKey = customerKey + nextCharacter;
                }

                if (allKeys.Contains(customerKey))
                {
                    duplicates.Add(customerKey);
                    continue;
                }

                else
                {
                    allKeys.Add(customerKey);
                    Console.WriteLine(allKeys[allKeys.Count-1]);
                }
            }
                    Console.WriteLine(duplicates.Count);
        }
    }
}
