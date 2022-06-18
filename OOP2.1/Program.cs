namespace OOP2_1

{

    class Program
    {
        static void Main(string[] args)
        {

         GercekMusteri musteri1 = new GercekMusteri();
         musteri1.Id = 1;
         musteri1.MusteriNo = "12345";
         musteri1.Adi = "Mert";
         musteri1.Soyadi = "Benli";
         musteri1.TcNo = "1235467890";

         TuzelMusteri musteri2 = new TuzelMusteri();
         musteri2.Id = 2;
         musteri2.MusteriNo = "54321";
         musteri2.SirketAdi = "WOM";
         musteri2.VergiNo = "1234567890";


         Musteri musteri3 = new GercekMusteri();  // new yazan yer referans numarası alır.
         Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);




        
    }


    }
     
   

}

