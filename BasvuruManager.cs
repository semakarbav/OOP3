using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {//Method Injection
        public void BasvuruYap(IKrediBaseManager krediBaseManager,ILoggerService loggerService)
        {
            //Basvuran bilgilerini değerlendirme
           // KonutKredi konutKredi = new KonutKredi();//yanlış
            krediBaseManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediBaseManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
            {

            }
        }
    }
}
