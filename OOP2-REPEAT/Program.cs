using System;

namespace OOP2_REPEAT
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.TcNo = "123456789";
            musteri1.Adi = "engin";
            musteri1.SoyAdi = "demir";
            musteri1.MusteriNo = "12345";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "789456";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234568596";

            Musteri musteri3 = new GercekMusteri();         //Musteri class'ı GercekMusteri'nin referansını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();          //Musteri class'ı TuzelMusteri'nin referansını tutabiliyor.



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
