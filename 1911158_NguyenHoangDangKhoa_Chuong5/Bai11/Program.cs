using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinnerPrice; 
            double tipRate; 
            double tip;

            double LOWRATE; 
            double MAXRATE; 
            const double TIPSTEP = 0.05; 
            double MAXDINNER; 
            const double DINNERSTEP = 10.00;

            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("======================== TippingTable3 ========================\n");
                    Console.Write("Input the lowest tipping percentage [0,...,1]: ");
                    LOWRATE = double.Parse(Console.ReadLine());
                    if (LOWRATE > 1 || LOWRATE < 0)
                    {
                        Console.WriteLine("{0} is invalid !!! Please input again !!!", LOWRATE);
                        Console.ReadKey();
                    }

                } while (LOWRATE > 1 || LOWRATE < 0);

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("======================== TippingTable3 ========================\n");
                        Console.Write("Input the highest tipping percentage [0,...,1]: ");
                        MAXRATE = double.Parse(Console.ReadLine());
                        if (MAXRATE > 1 || MAXRATE < 0)
                        {
                            Console.WriteLine("{0} is invalid !!! Please input again !!!", MAXRATE);
                            Console.ReadKey();
                        }

                } while (MAXRATE > 1 || MAXRATE < 0);

                if (LOWRATE >= MAXRATE)
                {
                    Console.WriteLine("{0} is LOWRATE > {1} is MAXRATE", LOWRATE, MAXRATE);
                    Console.WriteLine("Please input again !!!");
                    Console.ReadKey();
                }                  

            } while (LOWRATE >= MAXRATE);

            do
            {
                Console.Clear();
                Console.WriteLine("======================== TippingTable3 ========================\n");
                Console.Write("Input the lowest possible restaurant bill: ");
                dinnerPrice = double.Parse(Console.ReadLine());
                if (dinnerPrice <= 0)
                {
                    Console.WriteLine("{0} is invalid !!! Please input again !!!", dinnerPrice);
                    Console.ReadKey();
                }

            } while (dinnerPrice <= 0);

            do
            {
                Console.Clear();
                Console.WriteLine("======================== TippingTable3 ========================\n");
                Console.Write("Input the highest restaurant bill: ");
                MAXDINNER = double.Parse(Console.ReadLine());
                if (MAXDINNER <= 0 || MAXDINNER <= dinnerPrice)
                {
                    Console.WriteLine("{0} is invalid !!! Please input again !!!", MAXDINNER);
                    Console.ReadKey();
                }

            } while (MAXDINNER <= 0 || MAXDINNER <= dinnerPrice);

            Console.WriteLine("\n===============================================================\n");
            Console.Write("   Price"); 
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP) 
                Console.Write("{0, 8}", tipRate.ToString("F"));
            Console.WriteLine("\n\n---------------------------------------------------------------\n");
            tipRate = LOWRATE;

            do
            {
                Console.Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Console.Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                Console.WriteLine();
            } while (dinnerPrice <= MAXDINNER);


            Console.WriteLine("\n===============================================================\n");
            Console.ReadKey();
        }
    }
}
