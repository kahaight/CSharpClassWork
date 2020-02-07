using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{

    public enum VehicleType { Car, Truck, Plane, Boat, Bike, Spaceship, Train }
    public class Vehicle
    {
        public Vehicle()//constructor
        {
            BodyColor = "Magenta"; //this references what you're inside but is not necessary
        }

        public Vehicle(string bodyColor, string model, string make, double mileage, VehicleType type)
        {
            Make = make;
            BodyColor = bodyColor;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }

        //properties

        //access - type - name - get and set allow you to get values and set values
        public string BodyColor { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }


    }

    public class Person
    {
        //we can still call Person because theres an implicit constructor, we do not have to have a constructor method
        public string FirstName { get; set; }

        //above is shorthand for a property, below is the full

        // _ indicates a private field

        private string _lastName;//myVar = a backing field, it's where the value is stored

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }//you can have othe functionality built in between these curly braces
        }

        //another property  below
        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {LastName}"; 
                if (string.IsNullOrWhiteSpace(fullName))
                {
                    return "Unnamed";
                }
                else if (string.IsNullOrWhiteSpace(FirstName))
                {
                    return $"First Name Missing {LastName}";
                }
                else if (string.IsNullOrWhiteSpace(LastName))
                {
                    return $"{FirstName} Last Name Missing";
                }
                return fullName;
                //without a setter it's a read only property
            }
        }

        public DateTime DateOfBirth { get; set; }
        public string Age
        {
            get
            {
                if (DateOfBirth == new DateTime())
                {
                    return "No Date of Birth Entered";
                }

                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return $"{years.ToString()}";
            }
        }
    }





}
