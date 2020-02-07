using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void CheckFloorArea()
        {
            Room classRoom = new Room
            {
                Length = 10,
                Width = 10,
                Height = 10,
            };

            double floorArea = classRoom.CalculateFloorArea();
            Console.WriteLine($"The floor area is: {floorArea}");

            Assert.AreEqual(100d, floorArea);
        }
        [TestMethod]
        public void CheckFloorAreaFraction()
        {
            Room classRoom = new Room
            {
                Length = 10,
                Width = 10,
                Height = 10,
            };
            //avoid using formulas like this in our asserts because it complicates the code required to reject 0

            int denominator = 0;
            double actual = classRoom.CalculateFloorArea(denominator);
            double expected = classRoom.Length * classRoom.Width / denominator;

            Console.WriteLine($"Half the floor area is: {actual}");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckLatSurfArea()
        {
            Room classRoom = new Room
            {
                Length = 10,
                Width = 10,
                Height = 10,
            };

            double actual = classRoom.CalcLatSurfArea();
            double expected = 400;

            Assert.AreEqual(expected, actual);
        }
    }
}
