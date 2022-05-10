using System;

namespace KampIntro
{
    
    class Program
    {
        static void Main(String[] args)
        {
            //type safety = tip güvenliği 
            //do not repeat yourself-kendini tekrarlama
          String   kategoriEtiketi = "kategori1";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;  // burada ki true bir veri kaynağından gelir biz yazmayız 
            double dolarDun = 7.45;
            double dolarbugun = 7.45;

            if (dolarDun<dolarbugun)
            {
                Console.WriteLine("artış butonu");
            }
            else if (dolarDun>dolarbugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else
            {
                Console.WriteLine("eşittir oku");
            }






            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

        }
    } 
}