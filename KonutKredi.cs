﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKredi : IKrediBaseManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı");
        }
    }
}