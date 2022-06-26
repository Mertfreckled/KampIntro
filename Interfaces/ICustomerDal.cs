using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{/*burada kodu ınterface ile yazdığımız için kodda hangi veri tabanı olursa olsun biz ona göre hazırladığımızda
 tekrardan ona göre yapmaya gerek yok.*/
    interface ICustomerDal // Dal= data access layer  veri işlerini yapmak için kullanılan sınıf anlamına gelir.
    {
        void Add();
        void Delete();
        void Update();



    }

    class SqlServerCustomerdal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle added");

        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("oracke updated");

        }


    }
    class MySqlDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");

        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");

        }


    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

       
    }





}
