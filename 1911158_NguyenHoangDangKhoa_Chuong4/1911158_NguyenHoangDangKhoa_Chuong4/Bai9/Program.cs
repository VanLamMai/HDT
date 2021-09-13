using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRandom1,
                numRandom2,
                numRandom3;

            int userNum1,
                userNum2,
                userNum3;

            Random numGenerator = new Random();
            numRandom1 = numGenerator.Next(1, 5);
            numRandom2 = numGenerator.Next(1, 5);
            numRandom3 = numGenerator.Next(1, 5);

            //numRandom1 = 1;
            //numRandom2 = 1;
            //numRandom3 = 3;

            Console.WriteLine("====================== Lottery ======================\n");
            Console.WriteLine("Input Your Guess Number In [1...4]. Total Three-Digit.\n");
            Console.Write("Input Number 1: ");
            userNum1 = int.Parse(Console.ReadLine());          
            Console.Write("Input Number 2: ");
            userNum2 = int.Parse(Console.ReadLine());
            Console.Write("Input Number 3: ");
            userNum3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n-----------------------------------------------------\n");
            Console.WriteLine("Your Guess Number Is: {0}{1}{2}", userNum1, userNum2, userNum3);
            Console.WriteLine("\n-----------------------------------------------------\n");
            Console.WriteLine("Com Number Is: {0}{1}{2}", numRandom1, numRandom2, numRandom3);
            Console.WriteLine("\n=====================================================\n");

            if (numRandom1==numRandom2 && numRandom2==numRandom3)
            {
                if ((numRandom1 == userNum1 && numRandom1 != userNum2 && numRandom1 != userNum3) ||
                    (numRandom1 != userNum1 && numRandom1 == userNum2 && numRandom1 != userNum3) ||
                    (numRandom1 != userNum1 && numRandom1 != userNum2 && numRandom1 == userNum3))
                {
                    Console.WriteLine("Any one matching!!!");
                    Console.WriteLine("You got ${0}", 10);
                }
                else if ((numRandom1 == userNum1 && numRandom1 == userNum2 && numRandom1 != userNum3) ||
                    (numRandom1 != userNum1 && numRandom1 == userNum2 && numRandom1 == userNum3) ||
                    (numRandom1 == userNum1 && numRandom1 != userNum2 && numRandom1 == userNum3))
                {
                    Console.WriteLine("Two matching!!!");
                    Console.WriteLine("You got ${0}", 100);
                }
                else if (numRandom1 != userNum1 && numRandom1 != userNum2 && numRandom1 != userNum3)
                {
                    Console.WriteLine("No matches!!!");
                    Console.WriteLine("You got ${0}", 0);
                }
                else if (numRandom1 == userNum1 && numRandom1 == userNum2 && numRandom1 == userNum3)
                {
                    Console.WriteLine("Three matching!!!");
                    Console.WriteLine("You got ${0}", 10000);
                }
            }
            else
            {
                if (numRandom1 == userNum1 && numRandom2 == userNum2 && numRandom3 == userNum3)
                {
                    Console.WriteLine("Three matching in exact order!!!");
                    Console.WriteLine("You got ${0}", 10000);
                }
                else if ((numRandom1 == userNum1 && numRandom2 == userNum3 && numRandom3 == userNum2) ||
                        (numRandom2 == userNum2 && numRandom1 == userNum3 && numRandom3 == userNum1) || 
                        (numRandom3 == userNum3 && numRandom1 == userNum2 && numRandom2 == userNum1) ||
                        (numRandom1 == userNum2 && numRandom2 == userNum3 && numRandom3 == userNum1) ||
                        (numRandom2 == userNum3 && numRandom1 == userNum2 && numRandom3 == userNum1) ||
                        (numRandom1 == userNum3 && numRandom2 == userNum1 && numRandom3 == userNum2))
                {
                    Console.WriteLine("Three matching, not in order!!!");
                    Console.WriteLine("You got ${0}", 1000);
                }
                else if ((numRandom1 == userNum1 && numRandom2 == userNum2 && numRandom3 != userNum3) ||
                        (numRandom1 == userNum1 && numRandom2 != userNum2 && numRandom3 == userNum3) ||
                        (numRandom1 != userNum1 && numRandom2 == userNum2 && numRandom3 == userNum3))
                        //(numRandom1 == userNum2 && numRandom2 == userNum1 && numRandom3 != userNum3) ||
                        //(numRandom1 != userNum1 && numRandom2 == userNum3 && numRandom3 == userNum2) || 
                        //(numRandom1 == userNum3 && numRandom2 != userNum2 && numRandom3 == userNum1) ||
                        //(numRandom1 == userNum2 && numRandom2 != userNum1 && numRandom3 == userNum1) ||
                        //(numRandom1 != userNum2 && numRandom2 == userNum1 && numRandom3 == userNum3) ||
                        //(numRandom1 == userNum1 && numRandom2 == userNum3 && numRandom3 != userNum2) ||
                        //(numRandom1 == userNum3 && numRandom2 == userNum2 && numRandom3 != userNum1) ||
                        //(numRandom1 != userNum3 && numRandom2 == userNum2 && numRandom3 == userNum1) ||
                        //(numRandom1 == userNum1 && numRandom2 != userNum3 && numRandom3 == userNum2))
                {
                    Console.WriteLine("Two matching!!!");
                    Console.WriteLine("You got ${0}", 100);
                }
                else if ((numRandom1 == userNum1 && numRandom2 != userNum2 && numRandom3 != userNum3) ||
                        (numRandom1 != userNum1 && numRandom2 == userNum2 && numRandom3 != userNum3) ||
                        (numRandom1 != userNum1 && numRandom2 != userNum2 && numRandom3 == userNum3))
                {
                    Console.WriteLine("Any one matching!!!");
                    Console.WriteLine("You got ${0}", 10);
                }
                else
                {
                    Console.WriteLine("No matches!!!");
                    Console.WriteLine("You got ${0}", 0);
                }
            }         

            Console.ReadKey();
        }
    }
}
