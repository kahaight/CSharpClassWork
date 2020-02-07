using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }

        public int YearsOfService { get
            {
                TimeSpan timeServed = DateTime.Now - HireDate;
                return Convert.ToInt32(Math.Floor(timeServed.Days / 365.25));
            } 
        }
    }

    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
    }

}
