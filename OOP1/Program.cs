using System;

namespace OOP1
{

    class Program
    {
        static void Main(string[] args)
        {
           Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStocks = 3;


            //bu şekilde de yazılabilir
           Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStocks=5, ProductName = "kalem", UnitPrice =35};


            //case sensitive büyük küçük harf duyarlı
            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


           // int toplaSonucu = productManager.topla(8, 6);  
            //Console.WriteLine(toplaSonucu*2);// burada return sayesinde değerimizi döndürebiliriz.


            
            

        }
    }



}

