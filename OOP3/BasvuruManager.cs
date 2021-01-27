using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)       // IKrediManager bir interface ve tanımladığımız 3 krediyi de zaten tutuyor. Bu yüzden bu 3 krd'den hangisini seçsek kredi parametresine aktarılacak.
        {                                                                                      // ve o kredinin bellekteki Hesapla kodları çalışacak. Hatırlayalım; Interface'ler de implemente edildikleri class'ların referansını tutardı.
            krediManager.Hesapla();
            loggerService.Log();
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();               

            }
        
        }

    }
}
