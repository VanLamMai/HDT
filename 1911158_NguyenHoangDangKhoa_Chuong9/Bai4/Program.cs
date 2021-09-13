using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static List<Room> listRoom = new List<Room>();
        static int ammountRoom = 8;
        static void Main(string[] args)
        {
            int numRoom;
            Console.WriteLine("====================== PAINT DEMO ======================");
            CreateRoom();
            Console.Write("Enter number of room (0->7): ");
            numRoom = int.Parse(Console.ReadLine());
            Console.WriteLine(listRoom[numRoom]);
            Console.ReadKey();
        }

        static void CreateRoom()
        {
            Room a;
            for (int i = 0; i < ammountRoom; i++)
            {
                a = new Room();
                listRoom.Add(a);
			}
        }
    }
}
