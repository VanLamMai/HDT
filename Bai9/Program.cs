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
            double moveMoney = 200,
                jobMoney = 150,
                mileMoney = 2;

            double timeForJob,
                mileMove,
                totalMovingFee;

            Console.WriteLine("==================  MoveEstimator  ==================\n");
            Console.WriteLine("Money Per Move: ${0}", moveMoney);
            Console.WriteLine("Job's Money Per Hour: ${0}", jobMoney);
            Console.WriteLine("Money Per Mile: ${0}", mileMoney);
            Console.WriteLine("\n=====================================================\n");

            Console.Write("Input Time For Job: ");
            timeForJob = double.Parse(Console.ReadLine());
            Console.Write("Input Mile Move: ");
            mileMove = double.Parse(Console.ReadLine());
            Console.WriteLine("\n=====================================================\n");

            totalMovingFee = moveMoney + (jobMoney * timeForJob) + (mileMoney * mileMove);

            Console.WriteLine("Total Moving Fee Is: ${0}", totalMovingFee);
            Console.ReadKey();
        }
    }
}
