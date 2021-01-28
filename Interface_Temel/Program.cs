using System;

namespace Interface_Temel
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            
            //Customer customer = new Customer        //class'ı kullanmak için new'lemek gereklidir.
            //{
            //    Id = 1,
            //    FirstName = "engin",
            //    LastName = "demiroğ",
            //    Address = "ankara"
            //};

            //Student student = new Student();        //class'ı kullanmak için new'lemek gereklidir.
            //student.Id = 1;
            //student.FirstName = "derin";
            //student.LastName = "demiroğ";
            //student.Department = "fizik";

            //Worker worker = new Worker();
            //worker.Id = 5;
            //worker.FirstName = "başar";
            //worker.LastName = "karataş";
            //worker.City = "Adana";

            //PersonManager manager = new PersonManager();        //class'ı kullanmak için new'lemek gereklidir.

            //manager.Add(student);
            //manager.Add(customer);
            //manager.Add(worker);

        }


        

        interface IPerson                   //Soyut Nesnedir. Tek başına anlam ifade etmez.
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : IPerson                      //Somut Nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson                      //Somut nesne
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }

        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
        }


        class PersonManager 
        {
            public void Add(IPerson person) 
            {
                Console.WriteLine(person.FirstName + " eklendi");
            
            }

            
        
        
        }

        

        
        


    }
}
