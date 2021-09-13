using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_BaiTapLopDoiTuong_Bai2
{
    class SinhVien
    {
        #region Propetis

        public string maSV;
        public string hoTen;
        private string _gioiTinh;
        private string _lop;
        public double dTB;

        public string Lop
        {
          get { return _lop; }
          set { _lop = value; }
        }

        public string GioiTinh
        {
          get { return _gioiTinh; }
          set { _gioiTinh = value.Trim(); }
        }

        #endregion

        #region Initialization

        public SinhVien(string ma, string ho, string gt, string lop, double dTB)
        {
            this.maSV = ma;
            this.hoTen = ho;
            this.GioiTinh = gt;
            this.Lop = lop;
            this.dTB = dTB;
        }

        public SinhVien(string line)
        {
            string[] str = line.Split(',');
            this.maSV = str[0];
            this.hoTen = str[1];
            this.GioiTinh = str[2];
            this.Lop = str[3];
            this.dTB = double.Parse(str[4]);
        }

        public SinhVien()
        {

        }

        #endregion

        #region Methods

        public void Nhap()
        {
            string fileName = "data1.txt";
            StreamWriter sw = new StreamWriter(fileName);
            Console.Write("Nhap ma sinh vien: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhap lop: ");
            Lop = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            dTB = double.Parse(Console.ReadLine());
            sw.WriteLine("{0},{1},{2},{3},{4}", maSV, hoTen, GioiTinh, Lop, dTB);
            sw.Close();
        }

        public override string ToString()
        {
            return string.Format("{0,-5} {1,-25} {2,-9} {3,-6}  {4:F2}", maSV, hoTen, GioiTinh, Lop, dTB);
        }

        #endregion

    }
}
