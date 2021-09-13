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
            //Rock: 1
            //Paper: 2
            //Scissors: 3

            int comChoiceNum;

            Random randomGenerator = new Random();
            comChoiceNum = randomGenerator.Next(1, 4);

            char userChoice;

            Console.WriteLine("====================== RockPaperScissors ======================\n");
            Console.WriteLine("Enter a character, r, p, or s to choose one of three choices\n");
            Console.WriteLine("\t'r' is Rock");
            Console.WriteLine("\t'p' is Paper");
            Console.WriteLine("\t's' is Scissors");
            Console.WriteLine("\n===============================================================\n");

            Console.Write("Input Your Choice ('r' or 'p' or 's'): ");
            userChoice = char.Parse(Console.ReadLine());
            Console.Write('\n');

            if (userChoice != 'r' && userChoice != 'p' && userChoice != 's')
                Console.WriteLine("\n{0} is invalid!!! STOP PROGRAM !!!", userChoice);
            else
            {
                if ((userChoice == 'r' && comChoiceNum == 1) || 
                    (userChoice == 'p' && comChoiceNum == 2) || 
                    (userChoice == 's' && comChoiceNum == 3))
                {
                    if (comChoiceNum == 1)
                    {
                        Console.WriteLine("Computer choose Rock.\n");
                        Console.WriteLine("Tie!!!");
                    }
                    else if (comChoiceNum == 2)
                    {
                        Console.WriteLine("Computer choose Paper.\n");
                        Console.WriteLine("Tie!!!");
                    }
                    else if (comChoiceNum == 3)
                    {
                        Console.WriteLine("Computer choose Scissors.\n");
                        Console.WriteLine("Tie!!!");
                    }                  
                }                   

                else if ((userChoice == 'r' && comChoiceNum == 3) || 
                        (userChoice == 'p' && comChoiceNum == 1) ||
                        (userChoice == 's' && comChoiceNum == 2))
                {
                    if (comChoiceNum == 1)
                    {
                        Console.WriteLine("Computer choose Rock.\n");
                        Console.WriteLine("Congratulation!!! You Win.");
                    }
                    else if (comChoiceNum == 2)
                    {
                        Console.WriteLine("Computer choose Paper.\n");
                        Console.WriteLine("Congratulation!!! You Win.");
                    }
                    else if (comChoiceNum == 3)
                    {
                        Console.WriteLine("Computer choose Scissors.\n");
                        Console.WriteLine("Congratulation!!! You Win.");
                    }
                    
                }                  
                else if ((userChoice == 's' && comChoiceNum == 1) || 
                        (userChoice == 'r' && comChoiceNum == 2) ||
                        (userChoice == 'p' && comChoiceNum == 3))
                {
                    if (comChoiceNum == 1)
                    {
                        Console.WriteLine("Computer choose Rock.\n");
                        Console.WriteLine("Computer Win!!!");
                    }
                    else if (comChoiceNum == 2)
                    {
                        Console.WriteLine("Computer choose Paper.\n");
                        Console.WriteLine("Computer Win!!!");
                    }
                    else if (comChoiceNum == 3)
                    {
                        Console.WriteLine("Computer choose Scissors.\n");
                        Console.WriteLine("Computer Win!!!");
                    }
                }                   
            }

            Console.ReadKey();
        }
    }
}