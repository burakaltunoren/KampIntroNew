using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "elma";
            urun1.urunFiyati = 20;
            urun1.urunAciklama = "Amasya Elma";

            Urun urun2 = new Urun();
            urun2.urunAdi = "Karpuz";
            urun2.urunFiyati = 35;
            urun2.urunAciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.urunAdi = "İncir";
            urun3.urunFiyati = 15;
            urun3.urunAciklama = "Yerli";

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            Console.WriteLine(urunler.Length);

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + "  " + urunler[i].urunFiyati + " " + urunler[i].urunAciklama);

            }

            foreach (Urun x in urunler)
            {
                Console.WriteLine(x.urunAdi + "   " + x.urunFiyati + "   " + x.urunAciklama);
            }





        }
    }
}
