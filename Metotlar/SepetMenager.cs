﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetMenager
    {
        //naming convention 
        public void Ekle(Urun urun)
        {
            
            Console.WriteLine(" Tebrikler . Sepete Eklendi :"+ urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int StokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi: "+ urunAdi);

        }
    }
}
