using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numUser = -1;
            int numRandom;

            Random ranNumberGenerator = new Random();
            numRandom = ranNumberGenerator.Next(1, 11);

            Console.WriteLine("====================== GuessingGame2 =====================\n");
            Console.WriteLine("Random Number in [1...10]!");
            Console.WriteLine("\n----------------------------------------------------------\n");                             

            while (numUser != numRandom)
            {
                Console.Write("\nInput Your Guess Number: ");
                numUser = int.Parse(Console.ReadLine());    

                if (numUser > numRandom)
                {
                    Console.WriteLine("Too High!");                   

                }
                else if (numUser < numRandom)
                {
                    Console.WriteLine("Too Low!");
                }
                else
                {
                    Console.WriteLine("\n----------------------------------------------------------\n"); 
                    Console.WriteLine("Correct!");
                    Console.WriteLine("Random Number Is: {0}", numRandom);
                }
            }           
            Console.WriteLine("\n==========================================================\n");

            Console.ReadKey();
        }
    }
}
