using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numUser;
            int numRandom;

            Random ranNumberGenerator = new Random();
            numRandom = ranNumberGenerator.Next(1, 11);

            Console.WriteLine("====================== GuessingGame ======================\n");
            Console.WriteLine("Random Number in [1...10]!");
            Console.WriteLine("\n----------------------------------------------------------\n");           
            Console.Write("Input Your Guess Number: ");
            numUser = int.Parse(Console.ReadLine());
            Console.WriteLine("\n==========================================================\n");

            if (numUser > numRandom)
            {
                Console.WriteLine("Too High!");
                Console.WriteLine("Random Number Is: {0}", numRandom);

            }                
            else if (numUser < numRandom)
            {
                Console.WriteLine("Too Low!");
                Console.WriteLine("Random Number Is: {0}", numRandom);
            }               
            else
            {
                Console.WriteLine("Correct!");
                Console.WriteLine("Random Number Is: {0}", numRandom);
            }               

            Console.ReadKey();
        }
    }
}
