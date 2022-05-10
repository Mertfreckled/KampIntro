using System;

namespace Metotlar
{

    class Program
    {
        static void Main(string[] args)
        {
           Urun urun1= new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati =15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati =80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };



            foreach (var urun/*x desekde olur*/  in urunler)
            {
                Console.WriteLine   (urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
                 
            }
            //encapsulation parametreyi class kullanmazsak nolur.

            Console.WriteLine("---------metotlar-------------");

            SepetManager sepetmanager = new SepetManager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("karpuz","diyarbakır karpuzu",25,12);//bunlar sıkıntıya girdi çünkü parametre kısmımız class kullanılmadığı için.
            sepetmanager.Ekle2("elma", "amasya elması", 15,30);//elle tek tek hepsine ürün adedi girmek gerekir
            sepetmanager.Ekle2("muz", "ithal muz",20,5);

        }
    }


   
}

