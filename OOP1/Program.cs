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

            Product product2 = new Product {Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5 };  //102

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();  //103
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

            productManager.Update(product1);

            productManager.Topla2(3, 6);    //void ile kullanılan

            
            
            int toplamaSonucu = productManager.Topla(3, 6);   //void yerine -int- ile kullanılan fonksiyon -     productManager.Topla(3, 6) kısmı da zaten return'de verilen değerdir.
            int x = toplamaSonucu * 2;                        // burada toplamaSonucu return'ün tuttuğu değerdir.
            Console.WriteLine(x);







            int sayi = 100;                                                     //değer tip'e örnek sorusu
            productManager.BiseyYap(sayi);                                      
            Console.WriteLine("program cs den gelen sayı" + sayi);


            



        }
        

        
    }       
}
