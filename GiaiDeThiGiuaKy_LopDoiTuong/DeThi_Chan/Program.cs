using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi_Chan
{
    class Program
    {
        static QuanLyNhanVien qlnv = new QuanLyNhanVien();
        static void Main(string[] args)
        {
            qlnv.NhapDonGia();
            qlnv.NhapTuFile();
            Console.WriteLine(qlnv);
            qlnv.TimNVHopDongMinLuongThangX();
            qlnv.TimThangTraMinLuongNV();
            qlnv.TimNVMaxLuong();
            Console.ReadKey();
        }
    }
}
