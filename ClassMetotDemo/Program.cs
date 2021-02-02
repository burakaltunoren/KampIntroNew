using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerNumber = "1236";
            customer1.FirstName = "Nihal";
            customer1.LastLastName = "Karataş";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerNumber = "6321";
            customer2.FirstName = "Barış";
            customer2.LastLastName = "Karataş";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerNumber = "8569";
            customer3.FirstName = "Hasan";
            customer3.LastLastName = "Karataş";

            Customer customer4 = new Customer();
            customer4.CustomerId = 4;
            customer4.CustomerNumber = "4585";
            customer4.FirstName = "Başar";
            customer4.LastLastName = "Karataş";

            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(customer1);

            //CustomerManager customerManager2 = new CustomerManager();
            //customerManager2.Delete(customer1);



            Customer[] customers = new Customer[] {customer1, customer2, customer3, customer4 };

            foreach (var custom in customers)
            {
                customerManager.CustomerList(custom);
                
            }

        }
    }
}
