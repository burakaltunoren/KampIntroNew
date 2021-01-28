using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3_REPEAT
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager) 
        {
            krediManager.Hesapla();     // krediManager'e hangi kredi yollanırsa burada onun Hesapla() operasyonu çalışır.
        
        }
    }
}
