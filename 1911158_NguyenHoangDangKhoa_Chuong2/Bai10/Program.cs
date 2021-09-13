using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int beforeMinutes,
                afterMinutes;
            int hours;

            Console.WriteLine("==================  HoursAndMinutes  ==================\n");
            Console.Write("Input Minutes: ");
            beforeMinutes = int.Parse(Console.ReadLine());
            hours = beforeMinutes / 60;
            afterMinutes = beforeMinutes % 60;
            Console.WriteLine("\n=======================================================\n");
            Console.WriteLine("{0} minutes becomes {1} hours and {2} minutes.", beforeMinutes, hours, afterMinutes);
            Console.ReadKey();
        }
    }
}
