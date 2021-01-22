using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();  //101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Yukarıdaki yapı aşağıdaki formatta da kurulabilirdi

            Product product2 = new Product {Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5 };

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();  //102
            productManager.Add(product1);

            productManager.Update(product1);

            productManager.Topla(5, 6);
            productManager.Topla2(10, 15);

            int toplamaSonucu = productManager.Topla(5, 6);
            Console.WriteLine(toplamaSonucu*2);


            int sayi = 100;                     //değer tip'e örnek sorusu
            productManager.BiseyYap(sayi);
            Console.WriteLine(sayi);


            



        }
        

        
    }       
}
