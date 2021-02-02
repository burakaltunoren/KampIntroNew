using System;

namespace RefKeywordIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number1;
            //int number2 = 100;

            //int result = Add(out number1, number2);
            //Console.WriteLine(result);      // 30 + 100 = 130 verir
            //Console.WriteLine(number1);     // Hala 20'dir. Çünkü number1 metoda kendisini değil tuttuğu değeri yollar
            Console.WriteLine(Multiply(2,4,5));
        }


        //static int Add(out int number1, int number2)
        //{
        //    //number1 = 70;
        //    //return number1 + number2;

        //    // eğer fonksiyona parametre olarak number1'in değerini değil de kendisini göndermek isteseydik hem fonksiyonu çağırırken program.cs'de     int result = Add(ref number1, number2);
        //    // hem de fonksiyonda     static int Add(ref int number1, int number2)     kısmında number1 için ref keywordunu kullanmamız gerekir.
        //    // böyle bir kullanım sonucunda bu kodun çıktısı toplamı = 130 verirken number1'i de artık 20 değil, 30 olarak verir
        //    // ref keywordu değer tipli değişkenin değerinin kendisin kullanılmasını sağlar. 
        //    // ref yerine out keywordunu kullansak da mantık aynıdır: değer tipi referans tip olarak göndermek. Peki farkı ne?
        //    // ref kullanıldığında ref kullanılan değişken mutlaka set edilmiş olmalıdır. Yani bir değer verilmiş olmalıdır. Ama out bunu gerektirmez. metot içindeki değeri kullanır.
        //}

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3) 
        {
            return number1 * number2 * number3;
        
        }

        // peki fonksiyon aslında 2 parametre alacak şekilde yazılmış fakat bizim bazı yerlerde 3 sayıyı çarpmamız gerekirse ne yapılır?
        // 2. aynı isimli metot'da olduğu gibi aynı ismi kullanıp 3 parametre tanımlayabiliriz. İsim aynı ama parametre sayısı değişik 




    }
}
