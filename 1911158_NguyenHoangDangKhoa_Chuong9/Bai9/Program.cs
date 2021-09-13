using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativesList
{
    class Program
    {
        static void Main(string[] args)
        {
            Relative[] relatives = new Relative[12];
            string name;
            string relationship;
            int month;
            int day;
            int year;

            for (int i = 0; i < relatives.Length; i++)
            {
                Console.Write("Please enter the relative's name: ");
                name = Console.ReadLine();

                relationship = ((Relationship)(GenerateRandomNumber(0, 2))).ToString();
                month = GenerateRandomNumber(1, 12);
                day = GenerateRandomNumber(1, 31);
                year = GenerateRandomNumber(DateTime.Now.Year - 100, DateTime.Now.Year + 1);

                relatives[i] = new Relative(name, relationship, month, day, year);
            }

            Array.Sort(relatives);

            Console.WriteLine("RELATIVES SORTED IN ALPHABETICAL ORDER BY NAME ++++++++++++++++++++++++++");

            foreach (Relative r in relatives)
            {
                Console.WriteLine(r);
                Console.WriteLine();
            }

            Console.WriteLine("SEARCHING FROM THE RELATIVES LIST ++++++++++++++++++++++++++");
            Console.Write("Please enter a relative's name: ");
            string searchName = Console.ReadLine();
            DisplayRelativeDetails(searchName, relatives);

        }

        public static void DisplayRelativeDetails(string name, Relative[] relatives)
        {
            foreach (Relative relative in relatives)
            {
                if (relative.Name == name)
                {
                    Console.WriteLine("Relationship: " + relative.Relationship);
                    Console.WriteLine("Birthdate: " + relative.DisplayBirthday());
                    return;
                }
            }

            Console.WriteLine("There are no relatives in the list which have a name of: " + name);
            return;
        }

        public static int GenerateRandomNumber(int min, int max)
        {
            Random ranNumGenerator = new Random();

            return ranNumGenerator.Next(min, max + 1);
        }
    }
}