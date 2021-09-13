using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class HinhChuNhat
    {
        private double rong;

        public double Rong
        {
            get { return rong; }
            set { rong = value; }
        }

        private double dai;

        public double Dai
        {
            get { return dai; }
            set { dai = value; }
        }

        public HinhChuNhat()
        {

        }

        public HinhChuNhat(double rong, double dai)
        {
            if (rong > dai)
            {
                this.Dai = rong;
                this.Rong = dai;
            }
            else
            {
                this.Dai = dai;
                this.Rong = rong;
            }
        }

        public void Nhap()
        {
            do
            {
                Console.Write("Nhap chieu dai: ");
                this.Dai = double.Parse(Console.ReadLine());
            } while (this.Dai < 0);

            do
            {
                Console.Write("Nhap chieu rong: ");
                this.Rong = double.Parse(Console.ReadLine());
            } while (this.Rong < 0 || this.Rong >= this.Dai);
        }

        public double TinhDienTich()
        {
            return Dai * Rong;
        }

        public double TinhChuVi()
        {
            return (Dai + Rong) * 2;
        }

        public override string ToString()
        {
            return string.Format("HCN (Dai: {0}, Rong: {1}), CV = {2}, DT = {3}", Dai, Rong, TinhChuVi(), TinhDienTich());
        }
    }
}
