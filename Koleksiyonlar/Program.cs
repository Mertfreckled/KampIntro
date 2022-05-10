using System;

namespace Koleksiyonlar

{

    class Program
    {
        static void Main(string[] args)
        {
            //String[] isimler = new String[] { "Mert", "Özge", "Umut", "Limon" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //// array e 5. eleman eklemek istersek ekleyemeyiz.

            //isimler = new string[5];

            //// burada aslında yeni bir array açmış oluyoruz adresi farklı ve sadece 4. bit yazılı diğerleri boş
            //isimler[4] = "sümbül";
            ////aşağıdaki kodu boş yazdıracak çünkü ilk bitlerde isimlerin adresi değiştiği için ilk yazılanlar yok. 
            //Console.WriteLine(isimler[0]);
            ////bunun için listeler kullanılır.

            //***********List***************

            List<string> isimler2 = new List<string> { "Mert", "Özge", "Umut", "Limon" };

            Console.WriteLine(isimler2[0]);

            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine("**************************");
            //isimler2 listesine isim ekleyip eski isimleride okutabiliyoruz.
            isimler2.Add("Sümbül");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[4]);

            

        }
    }



}

