using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassifiedAd cgr1 = new ClassifiedAd();
            cgr1.category = "Cocacola";
            cgr1.numWords = 100;

            ClassifiedAd cgr2 = new ClassifiedAd();
            cgr2.category = "Pepsi";
            cgr2.numWords = 150;

            Console.WriteLine("The classicfield ad with {0} words in category [{1}] costs: ${2:F2}", cgr1.numWords, cgr1.category, cgr1.Price);
            Console.WriteLine("The classicfield ad with {0} words in category [{1}] costs: ${2:F2}", cgr2.numWords, cgr2.category, cgr2.Price);
            Console.ReadKey();
        }
    }
}
