using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine( customer.FirstName + " " + customer.LastLastName +  " is Added..!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastLastName + " is Deleted..!");
        }

        public void CustomerList(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + " " + customer.CustomerNumber + " " + customer.FirstName + " " +  customer.LastLastName ); 
        }


    }

}
