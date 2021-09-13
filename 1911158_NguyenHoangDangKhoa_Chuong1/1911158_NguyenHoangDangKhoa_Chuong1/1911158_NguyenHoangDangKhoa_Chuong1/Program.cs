using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Chuong1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nguyen Hoang Dang Khoa",
                birthdate = "14-08-2001",
                workPhoneNum = "092548XXXX",
                cellPhoneNum = "091793XXXX";

            Console.WriteLine("================= BAI 4 =================");
            Console.WriteLine("============== PersonalInfo =============");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Birthdate: " + birthdate);
            Console.WriteLine("Work Phone Number: " + workPhoneNum);
            Console.WriteLine("Cell Phone Number: " + cellPhoneNum);
            Console.WriteLine("=========================================");
            Console.ReadKey();
        }
    }
}
