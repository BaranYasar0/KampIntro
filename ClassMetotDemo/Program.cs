using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2=new Musteri();
            MusteriManager musteriManager=new MusteriManager();

            musteri1.Isim = "omer";
            musteri1.Id = "31";
            musteri1.TcNo = "62";

            musteri2.Isim = "baran";
            musteri2.Id = "93";
            musteri2.TcNo = "101";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            foreach (var temp in musteriler)
            {
                musteriManager.MusteriListele(temp);    
            }
            musteriManager.MusteriSil(musteri1);
        }

        
    
    }
}
