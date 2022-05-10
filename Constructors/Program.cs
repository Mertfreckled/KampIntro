using System;

namespace Constructors


{

    class Program
    {
        static void Main(string[] args)
        {
            //bu parametre boş olanla çalışır.
            Customer customer1 = new Customer { Id = 1, FirsName = "Mert", LastName = "Benli",City="istanbul" };//bununla
            
            //buda parametre boş olanla çalışır 
            Customer customer3 = new Customer();//1
            customer3.Id = 3;                   //2 bu ikisi aynı yazılımı farklı.
            
            //parametresi (... ) dolu olanla çalışır 
            Customer customer2 = new Customer(2,"Özge","Balta","istanbul");

            Console.WriteLine(customer2.FirsName);

        }

        
    }

  class Customer
    {
        public Customer()//içi boş olan
        {

        }
        //default constructor çalışır, parametresi dolu olan 
        public Customer(int id, string firstName,string lastName,string city) // void yada herhangi bir şey yoktur.
                                                                              // method parametreleri camelcase yazılır.
        {
            Id = id;
           FirsName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}



