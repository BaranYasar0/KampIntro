using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
        MyDictionary<string> isimler1=new MyDictionary<string>();
            Console.WriteLine(isimler1.Count);
            isimler1.Add("Deneme");
            Console.WriteLine(isimler1.Count);

            isimler1.Add("yeter");
            Console.WriteLine(isimler1.Count);

            foreach (var temp in isimler1.Items)
            {
                Console.WriteLine(temp);
            }
        
        
        }
    }
}
