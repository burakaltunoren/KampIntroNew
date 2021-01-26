using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();  //***Interface 'ler de onları implemente eden classların referansını tutabiliyor.***
            konutKrediManager.Hesapla();

        }
    }
}
