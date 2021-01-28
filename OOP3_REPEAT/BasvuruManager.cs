using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_REPEAT
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) 
        {
            krediManager.Hesapla();     // krediManager'e hangi kredi yollanırsa burada onun Hesapla() operasyonu çalışır.
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                
            }
        
        }


    }
}
