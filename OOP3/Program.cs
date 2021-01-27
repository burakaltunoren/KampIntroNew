using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasitKrediManager = new TasitKrediManager();        //a
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();    //b
            IKrediManager konutKrediManager = new KonutKrediManager();        //c            //***Interface 'ler de onları implemente eden classların referansını tutabiliyor.***
            ILoggerService dataBaseLogger = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService() );   //bu satır aşağıdaki ile aynı yazımdır. Yukarıda new'lemediysek bu satırdaki gibi yazarak da new 'leyebiliyoruz.                
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());                    
                                                                                                           

            List<IKrediManager> krediler = new List<IKrediManager> {konutKrediManager, tasitKrediManager, ihtiyacKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);








        }
    }                                                                         
}                                                                             
