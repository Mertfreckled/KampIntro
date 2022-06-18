using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class KonutKrediManager : IKrediManager // üzerinde ki ampule gelip implament inteface diyince aşağıdaki kod çıkar.
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("konut kredisi ödeme planı hesaplandı");
        }
    }
}
