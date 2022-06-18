using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerSevice : ILoggerService
    {
       public void Log()
        {
            Console.WriteLine("Veri tabanına loglandı.");
        }
    }
}
