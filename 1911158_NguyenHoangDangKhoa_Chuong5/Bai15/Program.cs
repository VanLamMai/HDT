using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numUser = -1;
            int numRandom, numTemp1 = -1,
                numTemp2 = -1;

            Random ranNumberGenerator = new Random();
            numRandom = ranNumberGenerator.Next(1, 11);

            Console.WriteLine("====================== GuessingGame3 =====================\n");
            Console.WriteLine("Random Number in [1...10]!");
            Console.WriteLine("\n----------------------------------------------------------\n");

            while (numUser != numRandom)
            {
                Console.Write("\nInput Your Guess Number: ");
                numUser = int.Parse(Console.ReadLine());               

                if (numUser > numRandom)
                {                   
                    if (numUser > numTemp1 && numTemp1 != -1)
                        Console.WriteLine("You don't need to input guess number higher than {0}", numTemp1);
                    else                       
                        Console.WriteLine("Too High!");
                    numTemp1 = numUser;
                }
                else if (numUser < numRandom)
                {
                    if (numUser < numTemp2 && numTemp2 != -1)
                        Console.WriteLine("You don't need to input guess number lower than {0}", numTemp2);
                        
                    else
                        Console.WriteLine("Too Low!");
                    numTemp2 = numUser;
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
