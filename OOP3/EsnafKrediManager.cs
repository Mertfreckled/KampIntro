﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class EsnafKrediManager : IKrediManager
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("esnaf kredisi hesaplandı");
        }
    }
}
