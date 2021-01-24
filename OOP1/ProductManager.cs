using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) 
        {
            product.ProductName = "kamera";


            Console.WriteLine(product.ProductName + " Eklendi");
        
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " Güncellendi");    
        
        }

        public int Topla(int sayi1, int sayi2)   // bunun anlamıu; bu metodu kullanırsan ben sana -int- tipinde birşey veririm demektir.
        {
            return sayi1 + sayi2;
        }





        public void Topla2(int sayi1, int sayi2)   
        {
            //int sonuc = sayi1 + sayi2;
            Console.WriteLine(sayi1 + sayi2);



        }

        
        public void BiseyYap(int sayi)       //parantez içindeki sayi parametresinin sayi1 = 100 'deki sayi değişkeni ile ilgisi yok. Bu sadece oradan gelen 100 değerini tutan bir parametre
        {
            sayi = 98;
            int sayi2 = sayi + 1;
            Console.WriteLine(sayi2);
            Console.WriteLine("bu pmden gelen sayı : " + sayi);
        }

        

        
    }
}
