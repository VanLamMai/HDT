using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class HinhTron
    {
        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }

        public HinhTron()
        {

        }

        public HinhTron(double banKinh)
        {
            this.BanKinh = banKinh;
        }

        public void Nhap()
        {
            do
            {
                Console.Write("Nhap ban kinh (R > 0) R = ");
                this.BanKinh = double.Parse(Console.ReadLine());
            } while (this.BanKinh < 0);            
        }

        public double TinhDienTich()
        {
            return Math.Round(BanKinh * BanKinh * Math.PI, 2); 
        }

        public double TinhChuVi()
        {
            return Math.Round(BanKinh * 2 * Math.PI, 2);
        }

        public override string ToString()
        {
            return string.Format("HT (R = {0}), CV = {1}, DT = {2}", BanKinh, TinhChuVi(), TinhDienTich());
        }
    }
}
