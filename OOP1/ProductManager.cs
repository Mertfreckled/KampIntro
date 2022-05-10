using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager
    {
        //encapsulation tek tek özellik yazmadık
        public void Add(Product product)//Product türünde bir şey gödereceksin ben onu product adıyla tutucam
        {

            Console.WriteLine( product.ProductName+"eklendi");

        }

        public void Update(Product product)

        {

            Console.WriteLine(product.ProductName + "güncellendi");


        }


           public int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2; // return ile sonucu başka bir yerde kullanabiliriz. üzerinde çalışmak istersek.
        } 

            public void topla2(int sayi1, int sayi2)  // burada void git şunu yap demektir yani tekrardan program csde kullanılamaz.
        {
            Console.WriteLine(sayi1 + sayi2);   
        }

    }
}
