using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class BasvuruManager
    {
        //method injektion bu metodun kullanacığı kredimanegerın ne olacağını ve hangi loglayıcı olacağını işliyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) // ıkredi ile hesapladıktan sonra 
                                                                           //ıloggerservice yi de kaydetmek için yapılır.
        {
            //Başvuru bilgilerini değerlendirme

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }


        }
    }
}
