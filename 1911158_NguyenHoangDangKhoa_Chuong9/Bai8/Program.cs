using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static Conference[] conferences = new Conference[5];
        static void Main(string[] args)
        {
            Input();
            Array.Sort(conferences);
            Output();          
            Console.ReadKey();
        }

        static void Input()
        {
            string groupName;
            string startDate;
            int numAttendees;

            for (int i = 0; i < conferences.Length; i++)
            {
                Console.Write("Enter the name of the conference group: ");
                groupName = Console.ReadLine();
                Console.Write("Enter the start date of the conference: ");
                startDate = Console.ReadLine();
                Console.Write("Enter the number of expected attendees: ");
                numAttendees = int.Parse(Console.ReadLine());

                conferences[i] = new Conference(groupName, startDate, numAttendees);
            }
        }

        static void Output()
        {
            foreach (Conference aConference in conferences)
            {
                Console.WriteLine(aConference + "\n");
            }
        }
    }
}
