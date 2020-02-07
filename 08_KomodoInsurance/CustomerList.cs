using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KomodoInsurance
{
    public class CustomerList//should call this repository intead of list
    {
        private List<Customer> _listOfCustomers = new List<Customer>();

        public bool AddCustomerToList(Customer customer)
        {
            int listLength = _listOfCustomers.Count();
            _listOfCustomers.Add(customer);
            bool wasAdded = listLength + 1 == _listOfCustomers.Count();
            return wasAdded;
        }

        public List<Customer> GetList()
        {
            return _listOfCustomers;
        }
        public Customer GetCustomerByID(int iDNumber)
        {
            foreach (Customer customer in _listOfCustomers)
            {
                if (customer.IDNumber == iDNumber)
                {
                    return customer;
                }
            }
            return null;
        }

        public string GetThankYou(Customer customer)
        {
            if (customer.YearsOfPatronage <= 5)
            {
                return "Thank you for being a valued customer.";
            }
            else
            {
                return "Thank you for being a gold member.";
            }
        }
    }
}
