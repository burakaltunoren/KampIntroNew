﻿using System;
using System.Collections.Generic;

namespace OOP3_REPEAT
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // yukarıdaki gibi yazarsak her krediyi tek tek hesaplatmış olurduk. Bu hesaplanacak her kredi için ayrı bir "x kredi hesapla" butonu demek.


            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();   // ihtiyacKrediManager 'i yollarsın.
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            // Bu yazımda da farklı buton gerek ancak burada fark şu ki; Interface'ler o interface'i implemente eden class'ın referans nuımarasını tutabilir.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);  
            
            List<IKrediManager> krediler = new List<IKrediManager>{ihtiyacKrediManager, tasitKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


           
           



            
            
        }
    }
}
