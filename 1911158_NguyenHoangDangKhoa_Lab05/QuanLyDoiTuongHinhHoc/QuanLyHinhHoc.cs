using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    enum KieuSapXep
    {
        TangTheoChuVi,
        GiamTheoChuVi,
        TangTheoDienTich,
        GiamTheoDienTich
    }

    enum KieuHienThi
    {
        TangDienTich,
        GiamDienTich,
        TangChuVi,
        GiamChuVi
    }

    enum LoaiHinh
    {
        HinhChuNhat,
        HinhTron,
        HinhVuong,
    }

    class QuanLyHinhHoc
    {
        DanhSachHinhChuNhat dsHCN = new DanhSachHinhChuNhat();
        DanhSachHinhVuong dsHV = new DanhSachHinhVuong();
        DanhSachHinhTron dsHT = new DanhSachHinhTron();

        public void NhapTuFile()
        {
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(' ');
                if (str[0] == "HV")
                {
                    dsHV.Them(new HinhVuong(double.Parse(str[1])));
                }
                else if (str[0] == "HCN")
                {
                    dsHCN.Them(new HinhChuNhat(double.Parse(str[1]), double.Parse(str[2])));
                }
                else if (str[0] == "HT")
                {
                    dsHT.Them(new HinhTron(double.Parse(str[1])));
                }
            }
            sr.Close();
        }

        public void NhapBangTay()
        {
            string kyHieu = " ";
            do
            {
                Console.Clear();
                Console.WriteLine("1. Nhap du lieu bang tay.");
                Console.Write("Nhap ky hieu (HCN, HV, HT) hoac E de thoat: ");
                kyHieu = Console.ReadLine();

                if (kyHieu.ToUpper() == "HCN")
                {
                    HinhChuNhat hcn = new HinhChuNhat();
                    hcn.Nhap();
                    dsHCN.Them(hcn);
                }
                else if (kyHieu.ToUpper() == "HV")
                {
                    HinhVuong hv = new HinhVuong();
                    hv.Nhap();
                    dsHV.Them(hv);
                }
                else if (kyHieu.ToUpper() == "HT")
                {
                    HinhTron ht = new HinhTron();
                    ht.Nhap();
                    dsHT.Them(ht);
                }
            } while (kyHieu != "E" && kyHieu != "e");
        }

        public void XuatDanhSachHinhHoc()
        {
            Console.WriteLine(dsHT);
            Console.WriteLine(dsHCN);
            Console.WriteLine(dsHV);
        }

        public void XuatDanhSachTheoLoaiHinh(LoaiHinh lh)
        {
            if (lh == LoaiHinh.HinhChuNhat)
                Console.WriteLine(dsHCN);
            if (lh == LoaiHinh.HinhVuong)
                Console.WriteLine(dsHV);
            if (lh == LoaiHinh.HinhTron)
                Console.WriteLine(dsHT);
        }

        public void TimHinhVuong_DT_Max()
        {
            int vt;
            vt = dsHV.TimHinhVuong_MaxDT();
            Console.WriteLine("Hinh vuong co dien tich lon nhat la: ");
            Console.WriteLine(dsHV.dsHV[vt]);
        }

        public void TimHinhChuNhat_DT_Min()
        {
            int vt;
            vt = dsHCN.TimHinhChuNhat_MinDT();
            Console.WriteLine("Hinh chu nhat co dien tich nho nhat la: ");
            Console.WriteLine(dsHCN.dsHCN[vt]);
        }

        public void TimHinhTron_BK_Max()
        {
            int vt;
            vt = dsHT.TimHinhTron_BK_Max();
            Console.WriteLine("Hinh tron co ban kinh lon nhat la: ");
            Console.WriteLine(dsHT.dsHT[vt]);
        }

        public void SapXepTangChuVi(LoaiHinh lh)
        {
            KieuSapXep kieu = KieuSapXep.TangTheoChuVi;
            if (lh == LoaiHinh.HinhVuong)
                dsHV.SapXep_ChuVi(kieu);
            if (lh == LoaiHinh.HinhChuNhat)
                dsHCN.SapXep_ChuVi(kieu);
            if (lh == LoaiHinh.HinhTron)
                dsHT.SapXep_ChuVi(kieu);
        }

        public void SapXepGiamChuVi(LoaiHinh lh)
        {
            KieuSapXep kieu = KieuSapXep.GiamTheoChuVi;
            if (lh == LoaiHinh.HinhVuong)
                dsHV.SapXep_ChuVi(kieu);
            if (lh == LoaiHinh.HinhChuNhat)
                dsHCN.SapXep_ChuVi(kieu);
            if (lh == LoaiHinh.HinhTron)
                dsHT.SapXep_ChuVi(kieu);
        }

        public void SapXepTangDienTich(LoaiHinh lh)
        {
            KieuSapXep kieu = KieuSapXep.TangTheoDienTich;
            if (lh == LoaiHinh.HinhVuong)
                dsHV.SapXep_DienTich(kieu);
            if (lh == LoaiHinh.HinhChuNhat)
                dsHCN.SapXep_DienTich(kieu);
            if (lh == LoaiHinh.HinhTron)
                dsHT.SapXep_DienTich(kieu);
        }

        public void SapXepGiamDienTich(LoaiHinh lh)
        {
            KieuSapXep kieu = KieuSapXep.GiamTheoDienTich;
            if (lh == LoaiHinh.HinhVuong)
                dsHV.SapXep_DienTich(kieu);
            if (lh == LoaiHinh.HinhChuNhat)
                dsHCN.SapXep_DienTich(kieu);
            if (lh == LoaiHinh.HinhTron)
                dsHT.SapXep_DienTich(kieu);
        }

        #region Comment
        //public void TimHinh_Max_DT()
        //{
        //    int vtHCN = dsHCN.TimHinhChuNhat_MaxDT();
        //    int vtHV = dsHV.TimHinhVuong_MaxDT();
        //    int vtHT = dsHT.TimHinhTron_MaxDT();

        //    Console.WriteLine("Cac hinh co dien tich lon nhat la: ");
        //    Console.WriteLine(dsHCN.dsHCN[vtHCN]);
        //    Console.WriteLine(dsHV.dsHV[vtHV]);
        //    Console.WriteLine(dsHT.dsHT[vtHT]);
        //}

        //public void TimHinh_Min_DT()
        //{
        //    int vtHCN = dsHCN.TimHinhChuNhat_MinDT();
        //    int vtHV = dsHV.TimHinhVuong_MinDT();
        //    int vtHT = dsHT.TimHinhTron_MinDT();

        //    Console.WriteLine("Cac hinh co dien tich nho nhat la: ");
        //    Console.WriteLine(dsHCN.dsHCN[vtHCN]);
        //    Console.WriteLine(dsHV.dsHV[vtHV]);
        //    Console.WriteLine(dsHT.dsHT[vtHT]);
        //}

        //public void TimHinh_Max_CV()
        //{
        //    int vtHCN = dsHCN.TimHinhChuNhat_MaxCV();
        //    int vtHV = dsHV.TimHinhVuong_MaxCV();
        //    int vtHT = dsHT.TimHinhTron_MaxCV();

        //    Console.WriteLine("Cac hinh co chu vi lon nhat la: ");
        //    Console.WriteLine(dsHCN.dsHCN[vtHCN]);
        //    Console.WriteLine(dsHV.dsHV[vtHV]);
        //    Console.WriteLine(dsHT.dsHT[vtHT]);
        //}

        //public void TimHinh_Min_CV()
        //{
        //    int vtHCN = dsHCN.TimHinhChuNhat_MinCV();
        //    int vtHV = dsHV.TimHinhVuong_MinCV();
        //    int vtHT = dsHT.TimHinhTron_MinCV();

        //    Console.WriteLine("Cac hinh co chu vi nho nhat la: ");
        //    Console.WriteLine(dsHCN.dsHCN[vtHCN]);
        //    Console.WriteLine(dsHV.dsHV[vtHV]);
        //    Console.WriteLine(dsHT.dsHT[vtHT]);
        //}
        #endregion

        private List<double> TimDS_DT_Max()
        {
            List<double> dsMaxDT = new List<double>();
            dsMaxDT.Add(dsHCN.TimDienTichMax());
            dsMaxDT.Add(dsHT.TimDienTichMax());
            dsMaxDT.Add(dsHV.TimDienTichMax());
            return dsMaxDT;
        }

        private List<double> TimDS_DT_Min()
        {
            List<double> dsMinDT = new List<double>();
            dsMinDT.Add(dsHCN.TimDienTichMin());
            dsMinDT.Add(dsHT.TimDienTichMin());
            dsMinDT.Add(dsHV.TimDienTichMin());
            return dsMinDT;
        }

        private List<double> TimDS_CV_Max()
        {
            List<double> dsMaxCV = new List<double>();
            dsMaxCV.Add(dsHCN.TimChuViMax());
            dsMaxCV.Add(dsHT.TimChuViMax());
            dsMaxCV.Add(dsHV.TimChuViMax());
            return dsMaxCV;
        }

        private List<double> TimDS_CV_Min()
        {
            List<double> dsMinCV = new List<double>();
            dsMinCV.Add(dsHCN.TimChuViMin());
            dsMinCV.Add(dsHT.TimChuViMin());
            dsMinCV.Add(dsHV.TimChuViMin());
            return dsMinCV;
        }

        private void XuatDSHinh_DT(double dt)
        {
            foreach (var hcn in dsHCN.dsHCN)
            {
                if (hcn.TinhDienTich() == dt)
                {
                    Console.WriteLine(hcn);
                    break;
                }
            }

            foreach (var hv in dsHV.dsHV)
            {
                if (hv.TinhDienTich() == dt)
                {
                    Console.WriteLine(hv);
                    break;
                }
            }

            foreach (var ht in dsHT.dsHT)
            {
                if (ht.TinhDienTich() == dt)
                {
                    Console.WriteLine(ht);
                    break;
                }
            }
        }

        private void XuatDSHinh_CV(double cv)
        {
            foreach (var hcn in dsHCN.dsHCN)
            {
                if (hcn.TinhChuVi() == cv)
                {
                    Console.WriteLine(hcn);
                    break;
                }
            }

            foreach (var hv in dsHV.dsHV)
            {
                if (hv.TinhChuVi() == cv)
                {
                    Console.WriteLine(hv);
                    break;
                }
            }

            foreach (var ht in dsHT.dsHT)
            {
                if (ht.TinhChuVi() == cv)
                {
                    Console.WriteLine(ht);
                    break;
                }
            }
        }
        public void HienThiHinhMaxDT()
        {
            List<double> dsMaxDT = TimDS_DT_Max();
            double maxDT = dsMaxDT.Max();
            Console.WriteLine("Cac hinh co dien tich lon nhat la: ");
            XuatDSHinh_DT(maxDT);
        }

        public void HienThiHinhMinDT()
        {
            List<double> dsMinDT = TimDS_DT_Min();
            double minDT = dsMinDT.Min();
            Console.WriteLine("Cac hinh co dien tich nho nhat la: ");
            XuatDSHinh_DT(minDT);
        }

        public void HienThiHinhMaxCV()
        {
            List<double> dsMaxCV = TimDS_CV_Max();
            double maxCV = dsMaxCV.Max();
            Console.WriteLine("Cac hinh co chu vi lon nhat la: ");
            XuatDSHinh_CV(maxCV);
        }

        public void HienThiHinhMinCV()
        {
            List<double> dsMinCV = TimDS_CV_Min();
            double minCV = dsMinCV.Min();
            Console.WriteLine("Cac hinh co chu vi nho nhat la: ");
            XuatDSHinh_CV(minCV);
        }

        private void SapXepAll(KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangTheoDienTich)
            {
                SapXepTangDienTich(LoaiHinh.HinhChuNhat);
                SapXepTangDienTich(LoaiHinh.HinhVuong);
                SapXepTangDienTich(LoaiHinh.HinhTron);
            }

            if (kieu == KieuSapXep.GiamTheoDienTich)
            {
                SapXepGiamDienTich(LoaiHinh.HinhChuNhat);
                SapXepGiamDienTich(LoaiHinh.HinhVuong);
                SapXepGiamDienTich(LoaiHinh.HinhTron);
            }

            if (kieu == KieuSapXep.TangTheoChuVi)
            {
                SapXepTangChuVi(LoaiHinh.HinhChuNhat);
                SapXepTangChuVi(LoaiHinh.HinhVuong);
                SapXepTangChuVi(LoaiHinh.HinhTron);
            }

            if (kieu == KieuSapXep.GiamTheoChuVi)
            {
                SapXepGiamChuVi(LoaiHinh.HinhChuNhat);
                SapXepGiamChuVi(LoaiHinh.HinhVuong);
                SapXepGiamChuVi(LoaiHinh.HinhTron);
            }
        }

        public void HienThiSapXep(KieuHienThi kieuHT)
        {
            if (kieuHT == KieuHienThi.TangDienTich)
                SapXepAll(KieuSapXep.TangTheoDienTich);
            if (kieuHT == KieuHienThi.GiamDienTich)
                SapXepAll(KieuSapXep.GiamTheoDienTich);
            if (kieuHT == KieuHienThi.TangChuVi)
                SapXepAll(KieuSapXep.TangTheoChuVi);
            if (kieuHT == KieuHienThi.GiamChuVi)
                SapXepAll(KieuSapXep.GiamTheoChuVi);

            XuatDanhSachHinhHoc();
        }

        private void XoaAllHinh_DT(double dt)
        {
            dsHCN.dsHCN.RemoveAll(x => x.TinhDienTich() == dt);
            dsHT.dsHT.RemoveAll(x => x.TinhDienTich() == dt);
            dsHV.dsHV.RemoveAll(x => x.TinhDienTich() == dt);
        }

        private void XoaAllHinh_CV(double cv)
        {
            dsHCN.dsHCN.RemoveAll(x => x.TinhChuVi() == cv);
            dsHT.dsHT.RemoveAll(x => x.TinhChuVi() == cv);
            dsHV.dsHV.RemoveAll(x => x.TinhChuVi() == cv);
        }

        public void XoaHinhCo_DT_Max()
        {
            List<double> dsMaxDT = TimDS_DT_Max();
            double maxDT = dsMaxDT.Max();

            HienThiHinhMaxDT();
            XoaAllHinh_DT(maxDT);
           
        }

        public void XoaHinhCo_DT_Min()
        {
            List<double> dsMinDT = TimDS_DT_Min();
            double minDT = dsMinDT.Min();

            HienThiHinhMinDT();
            XoaAllHinh_DT(minDT);
        }

        public void XoaHinhCo_CV_Max()
        {
            List<double> dsMaxCV = TimDS_CV_Max();
            double maxCV = dsMaxCV.Max();

            HienThiHinhMaxCV();
            XoaAllHinh_CV(maxCV);
        }

        public void XoaHinhCo_CV_Min()
        {
            List<double> dsMinCV = TimDS_CV_Min();
            double minCV = dsMinCV.Min();

            HienThiHinhMinCV();
            XoaAllHinh_CV(minCV);
        }
    }
}
