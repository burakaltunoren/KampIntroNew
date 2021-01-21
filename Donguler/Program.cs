using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.85;
            double dolarBugun = 7.85;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar düştü");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Dolar yükseldi");
            }
            else
            {
                Console.WriteLine("Değişim yok");
            }

        }
    }
}
