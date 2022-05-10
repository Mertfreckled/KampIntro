using System;

namespace Donguler
{ 
 
    class Program
    {
        static void Main(String[] args)
        {

            /* string kurs1 = "yazılım geliştiricisi yetiştirme kampı";
             string kurs2 = "programlamaya başlangıç temel kursu";
             string kurs3 = " java ";*/
            string[] kurslar = new string[] { "yazılım geliştiricisi yetiştirme kampı",
                "programlamaya başlangıç temel kursu" , " java ", "python","c#"};


           
            for (int i = 0; i<kurslar.Length; i++)  // i<kurslar.Length kurslar dizesinin sayısını verir.  
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("-----------------for bitti-------------------");
            foreach ( string kurs in kurslar) // dizi temelli yapıları tek tek ele alır.
            { 
                Console.WriteLine(kurs);
            }
            Console.WriteLine("-------------foreach bitti--------------------");



            Console.WriteLine("sayfa sonu-footer");
        }



    }





}
    
