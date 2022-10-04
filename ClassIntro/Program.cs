using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c++";
            kurs1.Egitmen = "baran";
            kurs1.IzlenmeOrani = 6318;


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }


        }
    
     }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen{ get; set; }
        public int IzlenmeOrani{ get; set; }

    }
}
