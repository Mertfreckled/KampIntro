using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention  E si büyük olur
        //syntax yazım şekli 
        //Urun tipi   ne olduğu urun ise isimlendirme aşağısı için
         // metot bir parametre oldu                
        public void Ekle(Urun urun) //doğrusu bu çünkü ilerde özellik eklemek istersek urun clasına eklememiz yeterlidir.
        {
            Console.WriteLine("değiştirildi.Sepete eklendi:"+ urun.Adi);
        }

        public void Ekle2 (string urunAdi,string urunAciklamasi,double fiyat,int urunAdet) //bu ilerde özellik eklemek istersek class kullanmadığımız için bütün sayfalar patlar.
        {

            Console.WriteLine("sepete eklendi : " + urunAdi);
        }

    }
}
