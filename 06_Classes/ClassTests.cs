using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {
            Vehicle airplane = new Vehicle();
            //parentheses invoke the constructor method
            airplane.BodyColor = "Hot Pink";
            airplane.Make = "Boeing";
            airplane.Model = "737 Max";
            airplane.Mileage = 0.1;

            Console.WriteLine("{0} {1}", airplane.Make, airplane.Model);
            Console.WriteLine(airplane.Make + " " + airplane.Model);

            airplane.TypeOfVehicle = VehicleType.Plane;

            Vehicle myCar = new Vehicle();

            myCar.BodyColor = "Silver";
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Mileage = 177000.1;
            myCar.TypeOfVehicle = VehicleType.Car;

            Vehicle anotherCar = new Vehicle("Red", "Yaris", "Toyota", 177563.08, VehicleType.Car);

            Console.WriteLine(anotherCar.Make + " " + anotherCar.Model);
              
        }

        [TestMethod]
        public void PersonTests()
        {
            Person firstPerson = new Person();
            firstPerson.FirstName = "Konrad";
            Console.WriteLine(firstPerson.FirstName);

            firstPerson.LastName = "Haight";

            Person blankPerson = new Person();
            blankPerson.FirstName = "Kevin";
            blankPerson.LastName = "     ";
            Console.WriteLine("Blank name:" + blankPerson.FullName);

            blankPerson.DateOfBirth = new DateTime(1987, 3, 23);

            Console.WriteLine(blankPerson.Age);
            Console.WriteLine(firstPerson.Age);
        }
    }
}
