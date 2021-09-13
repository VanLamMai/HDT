using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numYearSchool = 3; //Năm học ở một trường không thể vượt quá 127
            float finalGrade = 8.1f; //Điểm cuối kì của một lớp không thể nhiều hơn 127
            long populationChina = 2700000000; // Dân số có thể lên đến hàng tỷ người nên chọn kiểu long
            short pasFlight = 930; // Số hành khách trên máy bay không thể chứa đến 30 000 hành khách
            ushort scoreScrab = 1000; // Số điểm của một vài game không thể lên đến 100 000 điểm
            int votePre = 1000000; // Số phiếu bầu không thể đến hơn 2 tỷ người
            byte numBelowZero = 100; // Số ngày dưới 0 độ C không thể vượt quá 255 ngày
            byte scoreBaseball = 30; // Số điểm của bộ môn này không thể vượt quá 255 điểm
        }
    }
}
