using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi_Le
{
    class Program
    {
        static QuanLyNhanVien qlnv = new QuanLyNhanVien();
        static void Main(string[] args)
        {
            qlnv.NhapDonGia();
            qlnv.NhapTuFile();
            Console.WriteLine(qlnv);
            qlnv.TimNVHopDongMaxLuongThangX();
            qlnv.TimThangTraMaxLuongNV();
            qlnv.TimNVMaxLuong();
            Console.ReadKey();
        }
    }
}
