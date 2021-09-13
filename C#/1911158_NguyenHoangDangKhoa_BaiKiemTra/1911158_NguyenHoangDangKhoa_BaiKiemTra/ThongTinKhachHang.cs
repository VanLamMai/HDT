using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_BaiKiemTra
{
    class ThongTinKhachHang
    {
        private string soCM;

        public string SoCM
        {
            get { return soCM; }
            set { soCM = value; }
        }

        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value.Trim(); }
        }

        private string tinh;

        public string Tinh
        {
            get { return tinh; }
            set { tinh = value; }
        }

        private string thanhPho;

        public string ThanhPho
        {
            get { return thanhPho; }
            set { thanhPho = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value.Trim(); }
        }

        public ThongTinKhachHang()
        {

        }

        public ThongTinKhachHang(string line)
        {
            string[] str = line.Split(',');
            this.SoCM = str[0];
            this.hoTen = str[1];
            this.Tinh = str[2];
            this.ThanhPho = str[3];
            this.DiaChi = str[4];
        }

        public override string ToString()
        {
            return string.Format("|{0,-6}|{1,-15}|{2,-12}|{3,-12}|{4}", soCM, HoTen, Tinh, ThanhPho, DiaChi);
        }
    }
}
