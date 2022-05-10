using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{   //prop yazmak snippet
     class Product
    {
            //ürünıdsi
        public int Id { get; set; }
        //kategori ıd
        public int CategoryId { get; set; } // kod okunurluğu için bu sıra kullanılır.
        //ürün ismi
        public string ProductName { get; set; }
        //ürünün birim fiyatı
        public double UnitPrice { get; set; }
        //ürün stok adedi
        public int UnitsInStocks { get; set; }


    }
}
