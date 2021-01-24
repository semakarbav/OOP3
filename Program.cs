using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterface onu implemente eden classın referans değerini tutabilir:

            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediBaseManager konutKredi = new KonutKredi();
            IKrediBaseManager tasitKrediManager = new TasitKrediManager();

            ILoggerService databaseloggerservice = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,fileloggerService);


           List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
