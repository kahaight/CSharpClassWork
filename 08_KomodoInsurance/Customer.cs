using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KomodoInsurance
{
    //    Komodo Insurance needs a program that will allow to easily track their customers.
    //For now they only require some basics: a unique customer id number, last name, age, enrollment date, and number of years using Komodo Insurance.
    //Komodo wants to be able to store and manipulate our customers on a list.
    //KI also requires that any methods built are unit tested.
    //We also want to send a message to customers based on their years of subscribing.
    //If they’ve been part of a plan for 1-5 years, we send them a thank you note.
    //If they have been a customer for more than 5 years, we send them a note that says: “Thank you for being a Gold member.”   
    //Write unit tests to ensure your methods are working properly and use the repository pattern.
    public class Customer
    {
        public int IDNumber
        {
            get
            {
                return IDNumber;
            }
            set
            {

            }
        }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int YearsOfPatronage
        {
            get
            {
                return Convert.ToInt32(Math.Floor((DateTime.Now - EnrollmentDate).Days / 365.25));
            }
        }

        public Customer() { }

        public Customer(int iDNumber, string lastName, int age, DateTime enrollmentDate)
        {
            IDNumber = iDNumber;
            LastName = lastName;
            Age = age;
            EnrollmentDate = enrollmentDate;
        }



    }
}
