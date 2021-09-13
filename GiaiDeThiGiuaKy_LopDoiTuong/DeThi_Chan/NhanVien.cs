using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi_Chan
{
    public abstract class NhanVien
    {
        private string hoTen;
        private string ngayThangNamSinh;
        private int thang;

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string NgayThangNamSinh
        {
            get
            {
                return ngayThangNamSinh;
            }

            set
            {
                ngayThangNamSinh = value;
            }
        }

        public int Thang
        {
            get
            {
                if (thang <= 0 || thang > 12)
                    thang = 1;
                return thang;
            }

            set
            {
                thang = value;
            }
        }

        public NhanVien()
        {
            HoTen = "";
            NgayThangNamSinh = "";
            Thang = 1;
        }

        public NhanVien(string hoTen, string ngayThang, int thang)
        {
            this.HoTen = hoTen;
            this.NgayThangNamSinh = ngayThang;
            this.Thang = thang;
        }

        public abstract double TinhLuongThang();
    }
}
