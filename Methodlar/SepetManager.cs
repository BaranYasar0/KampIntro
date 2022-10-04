using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    internal class SepetManager
    {
        //naming convention
        public void ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi); ;
        }
    
        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("tebrikler" + urunAdi);
        }


    }
}
