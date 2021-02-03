using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> sehirPlaka = new Dictionary<int, string>();
            sehirPlaka.Add(01, "Adana");
            sehirPlaka.Add(33, "Mersin");
            sehirPlaka.Add(46, "Maraş");
            sehirPlaka.Add(27, "G.Antep");
            sehirPlaka.Add(06, "Ankara");
            sehirPlaka.Add(34, "İstanbul");

            foreach (var deger in sehirPlaka)
            {
                Console.WriteLine(deger);
            }

            




        }
    }
}
