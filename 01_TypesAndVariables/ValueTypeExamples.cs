using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;

            // use is... naming convention for boolean variables

            
        }
        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '&';
            char number = '9';

            char space = ' ';

            char specialCharacter = '\n';

            // \n is a new line

        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32767;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = -9223372036854775808;
            Int64 longMax = 9223372036854775807;

            int a = 15;
            int b = 22;
            int c = 37;
            byte age = 254;




        }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.2578907289045789789789789787897f;
            double doubleExample = 1.2578907289045789789789789787897d;
            decimal decimalExample = 1.2578907289045789789789789787897m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);

            // equals (=) is also called the assignment operator

        }

        enum PastryType {Cake, Danish, Doughnut, Scone, Cupcake, Croissant}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Doughnut;

            PastryType mySecondPastry = PastryType.Cake;

            Console.WriteLine(myPastry);
            Console.WriteLine(mySecondPastry);


        }
        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;
            DateTime today = DateTime.MinValue;
            Console.WriteLine(today);
            DateTime birthday = new DateTime(1987,03,23);
            Console.WriteLine(birthday.ToShortDateString());

        }

        enum IceCreamFlavor { ButterPecan, RockyRoad, CookiesNCream, MooseTracks };

        [TestMethod]
        public void Challenges()
        {
            bool isBoolOne;
            bool isBoolTwo = true;

            int intOne;
            int intTwo = 42;

            decimal decimalOne;
            decimal decimalTwo = 3.1415926535897932384626m;

            char exclamation = '!';
            char question = '?';

            string myName = "Konrad";
            string myFullName = "Konrad A Haight";

            IceCreamFlavor myFavoriteIceCream = IceCreamFlavor.MooseTracks;

            Console.WriteLine(isBoolTwo);
            Console.WriteLine(intTwo);
            Console.WriteLine(decimalTwo);
            Console.WriteLine(exclamation);
            Console.WriteLine(question);
            Console.WriteLine(myName);
            Console.WriteLine(myFullName);
            Console.WriteLine(myFavoriteIceCream);




        }
    }
}
