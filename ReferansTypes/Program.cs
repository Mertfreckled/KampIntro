using System;

namespace ReferansTypes


{

    class Program
    {
        static void Main(string[] args)
        {
            ////int decimal float enum value === types geri kalan referance stack ve heap bellekleri hatırla

            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;
            //Console.WriteLine(sayi1);   

            //Console.WriteLine("************");

            //int[] sayilar1 = { 1,2,3 };

            //int[] sayilar2 = { 10,20,30 };

            //sayilar1 = sayilar2;    

            //sayilar2[0] = 100;

            //Console.WriteLine("sayilar1[0]:"+sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "mert";

            person2 = person1;
            person2.FirstName = "özge";

            Console.WriteLine(person2.FirstName);




            Customer customer = new Customer();
            customer.FirstName = "umut";
            customer.CreditCardNumber = "12341546";

            Employee employee = new Employee();
            //base class = Person yani ebeveyn gibi persona customer ve employee adresini atanabilir.
            Person person3 = customer;
            customer.FirstName = "limon";
            // Console.WriteLine(((Customer)person3).CreditCardNumber);

           PersonelManager personelManager = new PersonelManager();




            personelManager.Add(person3);// buraya personal customer employee de gönderebilirim
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }


    class PersonelManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
    
}



