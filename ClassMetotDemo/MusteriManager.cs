using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
   public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Eklendi"+musteri.Isim);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Silindi"+musteri.Isim);
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Lİst methodu cagırıldı."+musteri.Isim);
        }
    }


}
