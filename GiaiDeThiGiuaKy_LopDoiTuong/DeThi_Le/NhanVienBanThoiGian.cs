using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi_Le
{
    class NhanVienBanThoiGian:NhanVien
    {
        private double soGioLamViec;
        public static double DonGia;

        public double SoGioLamViec
        {
            get
            {
                return soGioLamViec;
            }

            set
            {
                soGioLamViec = value;
            }
        }

        public override double TinhLuongThang()
        {
            return SoGioLamViec * DonGia;
        }

        public NhanVienBanThoiGian(string line)
        {
            string[] str = line.Split(',');
            this.HoTen = str[1];
            this.NgayThangNamSinh = str[2];
            this.SoGioLamViec = double.Parse(str[4]);
            this.Thang = int.Parse(str[4]);           
        }

        public override string ToString()
        {           
            return string.Format("|{0, -6}|{1, -20}|{2, -12}|{3, -6}|{4, -12}|{5, -12}|{6, -12}|",
                                "NVBTG", this.HoTen, this.NgayThangNamSinh, this.Thang, this.soGioLamViec, DonGia, TinhLuongThang());
        }
    }
}
