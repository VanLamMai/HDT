using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi_Chan
{
    class NhanVienHopDong:NhanVien
    {
        private double soNgayLamViec;
        public static double DonGia;

        public double SoNgayLamViec
        {
            get
            {
                if (this.Thang == 2)
                {
                    if (soNgayLamViec < 0 || soNgayLamViec > 29)
                        soNgayLamViec = 0;
                }
                else
                {
                    if (soNgayLamViec < 0 || soNgayLamViec > 31)
                        soNgayLamViec = 0;
                }
                return soNgayLamViec;
            }

            set
            {
                soNgayLamViec = value;
            }
        }

        public NhanVienHopDong(string line)
        {
            string[] str = line.Split(',');
            this.HoTen = str[1];
            this.NgayThangNamSinh = str[2];
            this.SoNgayLamViec = double.Parse(str[3]);
            this.Thang = int.Parse(str[4]);
        }

        public override double TinhLuongThang()
        {
            return this.SoNgayLamViec * DonGia;
        }

        public override string ToString()
        {
            return string.Format("|{0, -6}|{1, -20}|{2, -12}|{3, -6}|{4, -12}|{5, -12}|{6, -12}|",
                                "NVHD", this.HoTen, this.NgayThangNamSinh, this.Thang, this.SoNgayLamViec, DonGia, TinhLuongThang());
        }
    }
}
