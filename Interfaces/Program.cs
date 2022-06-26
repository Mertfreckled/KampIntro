using System;

namespace Interfaces
{

    class Program
    {
        static void Main(String[] args)
        {
            //InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerdal(),
                new OracleCustomerDal(),
                new MySqlDal()
            };


            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerdal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            manager.Add(new Customer { Id = 1, Firstname = "mert", LastName = "benli", Adress = "maltepe" });

            Student student = new Student
            {
                Id = 2,
                Firstname = "özge",
                LastName = "benli"


            };
            manager.Add(student);
        }
    }



    interface IPerson
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; } // IPerson olmak zorunda ek olarak nesnelere özellik eklenebilir.

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Firstname);
            Console.WriteLine(person.Id);
        }

    }




}
