using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Id = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "16967851254";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "56945825";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "4635463543";

            // Şimdi iki müşteri daha oluşturalım ama instance oluşturma kısmına dikkat edelim

            Musteri musteri3 = new GercekMusteri();
            
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();

            
            
            
            




;
            


        }
    }
}
