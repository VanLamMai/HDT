using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price;
            price = new int[] { 200, 180, 160, 145 };

            double numOfDay;
            int totalPrice;

            Console.WriteLine("========================= ResortPrices =========================");

            do
            {
                Console.Write("\nEnter The Number Of Days For A Resort Stay: ");
                numOfDay = double.Parse(Console.ReadLine());
                if (numOfDay <= 0 || (numOfDay - (int)numOfDay != 0))
                    Console.WriteLine("{0} Is Invalid!!! Plaease Enter Again!!!", numOfDay);

            } while (numOfDay <= 0 || (numOfDay - (int)numOfDay != 0));
            Console.WriteLine("\n----------------------------------------------------------------\n");

            if (numOfDay <= 2)
            {
                Console.WriteLine("The price per night is: ${0}", price[0]);
                totalPrice = (int)numOfDay * price[0];
                Console.WriteLine("The total price for {0} nights is: ${1}", numOfDay, totalPrice);
            }
            else if (numOfDay >= 3 && numOfDay <= 4)
            {
                Console.WriteLine("The price per night is: ${0}", price[1]);
                totalPrice = (int)numOfDay * price[1];
                Console.WriteLine("The total price for {0} nights is: ${1}", numOfDay, totalPrice);
            }
            else if (numOfDay >= 5 && numOfDay <= 7)
            {
                Console.WriteLine("The price per night is: ${0}", price[2]);
                totalPrice = (int)numOfDay * price[2];
                Console.WriteLine("The total price for {0} nights is: ${1}", numOfDay, totalPrice);
            }
            else
            {
                Console.WriteLine("The price per night is: ${0}", price[3]);
                totalPrice = (int)numOfDay * price[3];
                Console.WriteLine("The total price for {0} nights is: ${1}", numOfDay, totalPrice);
            }

            Console.WriteLine("\n================================================================\n");

            Console.ReadKey();
        }
    }
}
