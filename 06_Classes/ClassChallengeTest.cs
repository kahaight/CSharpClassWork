using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    [TestClass]
    public class ClassChallengeTest
    {
        [TestMethod]
        public void ChallengeTest()
        {
            Room classRoom = new Room
            {
                Height = 10,
                Width = 20,
                Length = 30
            };

            Console.WriteLine($"The square footage is {classRoom.SquareFootage}");
            Console.WriteLine($"The lateral surface area is {classRoom.LateralSurfaceArea}");
        }
        [TestMethod]
        public void ChallengeTestTwo()
        {
            Room bedRoom = new Room
            {
                Height = 10,
                Width = 15,
                Length = 13
            };

            Console.WriteLine($"The square footage is {bedRoom.SquareFootage}");
            Console.WriteLine($"The lateral surface area is {bedRoom.LateralSurfaceArea}");
        }
    }
}
