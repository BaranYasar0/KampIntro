using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        IKrediManager ihtiyackrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();


            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService=new FileLoggerService();
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,databaseloggerService);
            basvuruManager.BasvuruYap(ihtiyackrediManager, fileLoggerService);

            List<IKrediManager>krediler=new List<IKrediManager>() { ihtiyackrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
