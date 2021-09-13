using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeThi_Le
{
    class QuanLyNhanVien
    {
        List<NhanVien> listNV = new List<NhanVien>();

        private string XuatNgangDoi()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 88; i++)
            {
                sb.Append('=');
            }
            return sb.ToString();
        }

        private List<NhanVien> LayDanhSachNhanVienHopDongTheoThang(int thang)
        {
            List<NhanVien> kq = new List<NhanVien>();
            foreach (var nv in listNV)
            {
                if (nv.Thang == thang && nv is NhanVienHopDong)
                    kq.Add(nv);
            }
            return kq;
        }

        private bool KiemTraThangTonTai(int thang, List<NhanVien> list)
        {
            foreach (var nv in list)
            {
                if (nv.Thang == thang)
                    return true;
            }
            return false;
        }

        public void Them(NhanVien nv)
        {
            listNV.Add(nv);
        }

        public void NhapDonGia()
        {
            Console.Write("Nhap don gia cua nhan vien hop dong: ");
            NhanVienHopDong.DonGia = double.Parse(Console.ReadLine());
            Console.Write("Nhap don gia cua nhan vien ban thoi gian: ");
            NhanVienBanThoiGian.DonGia = double.Parse(Console.ReadLine());
        }

        public void NhapTuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(',');
                if (str[0] == "NVHD")
                    Them(new NhanVienHopDong(line));
                else if (str[0] == "NVBTG")
                    Them(new NhanVienBanThoiGian(line));
            }
            sr.Close();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            //Tao Tieu De Cho Bang
            string str = string.Format("|{0, -6}|{1, -20}|{2, -12}|{3, -6}|{4, -12}|{5, -12}|{6, -12}|",
                                      "", "Ho ten", "NTNSinh", "Thang", "So Ngay/Gio", "Don gia", "Luong thang");
            sb.Append(XuatNgangDoi() + "\n");
            sb.Append(str.ToString() + "\n");
            sb.Append(XuatNgangDoi() + "\n");
            //Ket Thuc Tao Tua De

            foreach (var nv in listNV)
            {
                sb.Append(nv + "\n");
            }

            sb.Append(XuatNgangDoi() + "\n");
            return sb.ToString();
        }

        public void TimNVHopDongMaxLuongThangX()
        {
            Console.Write("Nhap thang muon tim: ");
            int thang = int.Parse(Console.ReadLine());
            List<NhanVien> listNVHD = LayDanhSachNhanVienHopDongTheoThang(thang);
            QuanLyNhanVien kq = new QuanLyNhanVien();
            if (KiemTraThangTonTai(thang, listNVHD))            
            {
                double maxLuong = listNVHD.Max(x => x.TinhLuongThang());                
                foreach (var nv in listNVHD)
                {
                    if (nv.TinhLuongThang() == maxLuong && nv.Thang == thang)
                        kq.Them(nv);
                }
                Console.WriteLine("Nhan vien hop dong co luong cao nhat trong thang {0}", thang);
                Console.WriteLine(kq);        
            }
            else
                Console.WriteLine("Khong co nhan vien hop dong nao trong danh sach lam trong thang {0}", thang);
        }

        public void TimThangTraMaxLuongNV()
        {
            List<int> kq = new List<int>();
            double maxLuong = listNV.Max(x => x.TinhLuongThang());
            foreach (var nv in listNV)
            {
                if (nv.TinhLuongThang() == maxLuong)
                    kq.Add(nv.Thang);
            }
            Console.Write("Thang tra luong cho nhan vien cao nhat la: ");
            foreach (var item in kq)
            {
                Console.Write(item + ", ");
            }           
        }

        public void TimNVMaxLuong()
        {
            QuanLyNhanVien kq = new QuanLyNhanVien();
            double maxLuong = listNV.Max(x => x.TinhLuongThang());
            foreach (var nv in listNV)
            {
                if (nv.TinhLuongThang() == maxLuong)
                    kq.Them(nv);
            }
            Console.WriteLine("\n\nNhan vien co luong cao nhat la: ");
            Console.WriteLine(kq);
        }
    }
}
