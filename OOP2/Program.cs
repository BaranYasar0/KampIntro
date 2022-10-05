using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
GercekMusteri musteri1=new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "baran";
            musteri1.Soyadi = "yasar";
            musteri1.Id = 1;

            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo="123456";


            Musteri musteri3=new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            
            CustomerManager customerManager1=new CustomerManager();

        }

    }
}
