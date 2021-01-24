using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil", "ben" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];        //bunu yaptığımızda new kull. için bellekte heap alanında yeni bir referans adresi oluştu. 5 elemanlı boş bir dizi.
            //isimler[4] = "Ceren";           //  bu komut artık o boş diziye şunu yapar. [ , , , ,ceren]    
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //List<string> isimler2 = new List<string>();
            //isimler2.Add("engin");


            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            List<int> liste = new List<int> {};
            Console.WriteLine(liste.Count);

            List<string> liste1 = new List<string> { };
            Console.WriteLine(liste1.Count);











        }   
    }
}
