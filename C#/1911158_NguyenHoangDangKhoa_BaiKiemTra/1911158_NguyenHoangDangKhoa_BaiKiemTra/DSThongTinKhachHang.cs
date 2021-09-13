using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_BaiKiemTra
{
    class DSThongTinKhachHang
    {
        List<ThongTinKhachHang> ds = new List<ThongTinKhachHang>();

        public void ThemKhachHang(ThongTinKhachHang kh)
        {
            ds.Add(kh);
        }

        public void NhapTuFile()
        {
            string fileName = "data.txt";
            string line = "";
            StreamReader sr = new StreamReader(fileName);
            while ((line = sr.ReadLine()) != null)
            {
                ds.Add(new ThongTinKhachHang(line));
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n============================================================================");
            sb.Append("\n|So CM".PadLeft(1) + "|Ho va ten".PadLeft(11) + "|Tinh".PadLeft(11) + "|Thanh pho".PadLeft(18)
                + "|Dia chi".PadLeft(11));
            sb.Append("\n============================================================================");
            foreach (var kh in ds)
            {
                sb.Append("\n" + kh);
            }
            return sb.ToString();
        }

        private string LayPhuong(string diaChi)
        {
            string[] str = diaChi.Split('-');
            return str[1];
        }

        private List<string> LayDanhSachThanhPho()
        {
            List<string> kq = new List<string>();
            foreach (var kh in ds)
            {
                if (!kq.Contains(kh.ThanhPho))
                    kq.Add(kh.ThanhPho);
            }
            return kq;
        }

        private List<string> LayDanhSachPhuong()
        {
            List<string> kq = new List<string>();
            foreach (var kh in ds)
            {
                if (!kq.Contains(LayPhuong(kh.DiaChi)))
                    kq.Add(LayPhuong(kh.DiaChi));
            }
            return kq;
        }

        private int DemSoDTMotThanhPho(string tp)
        {
            int dem = 0;
            foreach (var kh in ds)
            {
                if (kh.ThanhPho.CompareTo(tp) == 0)
                    dem++;
            }
            return dem;
        }

        private int DemSoDTMotPhuong(string p)
        {
            int dem = 0;
            foreach (var kh in ds)
            {
                if (LayPhuong(kh.DiaChi).CompareTo(p) == 0)
                    dem++;
            }
            return dem;
        }

        private int TimSoDTNhieuNhat()
        {
            int max = int.MinValue, 
                dem;
            List<string> dsTP = LayDanhSachThanhPho();
            foreach (var item in dsTP)
            {
                dem = DemSoDTMotThanhPho(item);
                if (max < dem)
                    max = dem;
            }
            return max;
        }

        private int TimSoDTItNhat()
        {
            int min = int.MaxValue,
                dem;
            List<string> dsPhuong = LayDanhSachPhuong();
            foreach (var item in dsPhuong)
            {
                dem = DemSoDTMotPhuong(item);
                if (min > dem)
                    min = dem;
            }
            return min;
        }

        public List<string> TimThanhPhoCoNhieuSoDTNhat()
        {
            int max = TimSoDTNhieuNhat();
            List<string> dsTP = LayDanhSachThanhPho();
            List<string> kq = new List<string>();
            foreach (var tp in dsTP)
            {
                if (DemSoDTMotThanhPho(tp) == max)
                    kq.Add(tp);
            }
            return kq;
        }

        public List<string> TimPhuongCoItSoDTNhat()
        {
            int min = TimSoDTItNhat();
            List<string> dsPhuong = LayDanhSachPhuong();
            List<string> kq = new List<string>();
            foreach (var p in dsPhuong)
            {
                if (DemSoDTMotPhuong(p) == min)
                    kq.Add(p);
            }
            return kq;
        }
    }
}
