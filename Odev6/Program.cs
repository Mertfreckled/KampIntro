using System;
/*Genellikle bir e-ticaret sistemine girdiğinizde ürünler listelenir. Siz de Urun (Product) isimli bir class oluşturup, 
 * oluşturduğunuz bir kaç ürünü bir diziye ekleyiniz.

Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz.*/


class Product
{
    public string Product_Name { get; set; }
    public string Product_Category { get; set; }
    public int Product_Price { get; set; }
}

namespace Odev6
{

    class Program
    {
        static void Main(String[] args)
        {

            Product product1 = new Product();

            product1.Product_Name = "ayakkabı";
            product1.Product_Category = "Giyim";
            product1.Product_Price = 100;


            Product product2 = new Product();

            product2.Product_Name = "Hırka";
            product2.Product_Category = "Giyim";
            product2.Product_Price = 150;

            Product product3 = new Product();
            product3.Product_Name = "kolye";
            product3.Product_Category = "Takı";
            product3.Product_Price = 500;


            Product[] products = new Product[] { product1, product2 ,product3};

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine   (products[i].Product_Category+products[i].Product_Name+"  "++"   "+ products[i].Product_Price);
            }


             

        }

    }
}

