using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Urun urun1= new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";


            Urun urun2=new Urun();
            urun2.Fiyati = 80;
            urun2.Adi = "karpuz";
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
            }

            Console.WriteLine("-----methodlar----");
            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);
            sepetManager.Ekle2("armut", "yeşil", 12);


        }
    }
}
