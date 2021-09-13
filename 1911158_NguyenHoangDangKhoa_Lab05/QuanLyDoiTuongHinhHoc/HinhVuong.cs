using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class HinhVuong
    {
        private double canh;

        public double Canh
        {
            get { return canh; }
            set { canh = value; }
        }

        public HinhVuong()
        {

        }

        public HinhVuong(double canh)
        {
            this.Canh = canh;
        }

        public void Nhap()
        {
            do
            {
                Console.Write("Nhap do dai canh (canh > 0): ");
                this.Canh = double.Parse(Console.ReadLine());
            } while (this.Canh < 0);
        }

        public double TinhDienTich()
        {
            return Canh * Canh;
        }

        public double TinhChuVi()
        {
            return Canh * 4;
        }

        public override string ToString()
        {
            return string.Format("HV (Canh: {0}), CV = {1}, DT = {2}", Canh, TinhChuVi(), TinhDienTich());
        }
    }
}
