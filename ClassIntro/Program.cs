using System;

namespace KampIntro
{

    class Program
    {
        static void Main(String[] args)
        {
            
            
            Kurs kurs1 = new Kurs();// kurs1 in tipi kurs oldu yani bir int gibi string gibi kurs özelliklerini taşıyacak.

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "mert";
            kurs1.IzlenmeOrani = 12; 
        

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "python";
            kurs2.Egitmen = "Özge";
            kurs2.IzlenmeOrani = 15;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "java";
            kurs3.Egitmen = "engin demiroğ";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();

            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Umut BENLİ";
            kurs3.IzlenmeOrani = 100;

            // Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3,kurs4 };
            Console.WriteLine("------------foreach ile ------------------");
            foreach (var takmaad in kurslar)
            {
                Console.WriteLine   (takmaad.KursAdi+" :"+takmaad.Egitmen);  
            }
            Console.WriteLine("------------for ile ------------------");
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine (kurslar[i].KursAdi); 
            }


            //ternary operatörü excel deki eğer gibi çalışır ?:  şart ? doğruysa : yanlışssa
 
            bool medeniHal = true;


            string mesaj = medeniHal==true ? "evlilere kampanya ":"bekarlara kampanya ";

            Console.WriteLine (mesaj);
        
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string  Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

        
    }
}
