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
            int i, n = 9;
            double []testScore;
            testScore = new double[n];
            int sumScore = 0, 
                avg;
            Console.WriteLine("=========================== TestScoreList ===========================");            
            for (i = 1; i < testScore.Length; i++)
            {
                do
                {
                    Console.Write("Enter Test Score #{0}: ", i);
                    testScore[i] = double.Parse(Console.ReadLine());
                    if (testScore[i] - (int)testScore[i] != 0)
                    {
                        Console.WriteLine("\n{0} is invalid!!! Please Enter Again!!!\n", testScore[i]);
                        Console.ReadKey();
                    }
                        
                } while (testScore[i] - (int)testScore[i] != 0);
                sumScore += (int)testScore[i];
            }

            avg = sumScore / n;

            Console.WriteLine("---------------------------------------------------------------------\n");
            Console.WriteLine("The Average Is: {0}", avg);
            for(i =1; i<testScore.Length; i++)
            {
                Console.WriteLine("\nTest Score #" + i + ": " + testScore[i] + " From Average " + (testScore[i] - avg));
            }

            Console.WriteLine("=====================================================================\n");

            Console.ReadKey();
        }
    }
}
