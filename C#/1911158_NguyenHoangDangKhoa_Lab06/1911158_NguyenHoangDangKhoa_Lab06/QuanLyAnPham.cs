using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911158_NguyenHoangDangKhoa_Lab06
{
    enum KieuNhap
    {
        NhapTay,
        NhapFile
    }

    enum KieuTimKiem
    {
        DaiNhat,
        NganNhat,
        NhieuNhat,
        ItNhat
    }

    enum KieuSapXep
    {
        SapTang,
        SapGiam
    }

    class QuanLyAnPham
    {
        #region initialize
        DanhSachSach dsSach = new DanhSachSach();
        DanhSachBao dsBao = new DanhSachBao();
        DanhSachTapChi dsTapchi = new DanhSachTapChi();
        #endregion

        #region private
        private void TaoDanhSach(string line, KieuNhap kn)
        {
            if (kn == KieuNhap.NhapTay)
            {
                if (line == "S")
                {
                    Sach sach = new Sach();
                    sach.Nhap();
                    dsSach.Them(sach);
                }

                if (line == "B")
                {
                    Bao bao = new Bao();
                    bao.Nhap();
                    dsBao.Them(bao);
                }

                if (line == "TC")
                {
                    TapChi tapChi = new TapChi();
                    tapChi.Nhap();
                    dsTapchi.Them(tapChi);
                }
            }

            if (kn == KieuNhap.NhapFile)
            {
                string[] str = line.Split(';');
                if (str[0] == "S")
                {
                    Sach sach = new Sach(str[1], int.Parse(str[2]), str[3]);
                    dsSach.Them(sach);
                }
                else if (str[0] == "B")
                {
                    Bao bao = new Bao(int.Parse(str[1]), str[2]);
                    dsBao.Them(bao);
                }
                else if (str[0] == "TC")
                {
                    TapChi tapChi = new TapChi(str[1], int.Parse(str[2]), str[3], int.Parse(str[4]));
                    dsTapchi.Them(tapChi);
                }
            }
        }

        private int TimDoDai_TieuDe(KieuTimKiem ktk)
        {
            int doDai = 0;
            List<int> list = new List<int>();
            list.Add(dsSach.TimDoDaiTieuDe(ktk));
            list.Add(dsTapchi.TimDoDaiTieuDe(ktk));
            if (ktk == KieuTimKiem.DaiNhat)
                doDai = list.Max();
            else if (ktk == KieuTimKiem.NganNhat)
                doDai = list.Min();
            return doDai;
        }

        private int TimDoDai_Trang(KieuTimKiem ktk)
        {
            int soTrang = 0;
            List<int> list = new List<int>();
            list.Add(dsSach.TimSoTrang(ktk));
            list.Add(dsBao.TimSoTrang(ktk));
            list.Add(dsTapchi.TimSoTrang(ktk));
            if (ktk == KieuTimKiem.DaiNhat)
                soTrang = list.Max();
            else if (ktk == KieuTimKiem.NganNhat)
                soTrang = list.Min();
            return soTrang;
        }

        private List<string> LayDanhSachNXB()
        {
            List<string> listNXB = new List<string>();
            foreach (var sach in dsSach.dsSach)
            {
                if (!listNXB.Contains(sach.NhaXuatBan))
                    listNXB.Add(sach.NhaXuatBan);
            }
            foreach (var bao in dsBao.dsBao)
            {
                if (!listNXB.Contains(bao.NhaXuatBan))
                    listNXB.Add(bao.NhaXuatBan);
            }
            foreach (var tapChi in dsTapchi.dsTapChi)
            {
                if (!listNXB.Contains(tapChi.NhaXuatBan))
                    listNXB.Add(tapChi.NhaXuatBan);
            }
            return listNXB;
        }

        private int DemSoLanXuatHien_MotNXB(string nxb)
        {
            int dem = 0;
            foreach (var sach in dsSach.dsSach)
            {
                if (nxb.CompareTo(sach.NhaXuatBan) == 0)
                    dem += 1;
            }
            foreach (var bao in dsBao.dsBao)
            {
                if (nxb.CompareTo(bao.NhaXuatBan) == 0)
                    dem += 1;
            }
            foreach (var tapChi in dsTapchi.dsTapChi)
            {
                if (nxb.CompareTo(tapChi.NhaXuatBan) == 0)
                    dem += 1;
            }
            return dem;
        }

        private int TimSoLanXuatHienNXB(KieuTimKiem kieuTK)
        {
            List<string> listNXB = LayDanhSachNXB();
            List<int> listSoLan = new List<int>();

            int soLanXuatHien;

            foreach (var nxb in listNXB)
                listSoLan.Add(DemSoLanXuatHien_MotNXB(nxb));

            if (kieuTK == KieuTimKiem.NhieuNhat)
                soLanXuatHien = listSoLan.Max();
            else
                soLanXuatHien = listSoLan.Min();
            return soLanXuatHien;
        }

        private List<string> TimNXBXuatHien(KieuTimKiem kieuTK)
        {
            int soLanXuatHien = 0;
            if (kieuTK == KieuTimKiem.NhieuNhat)
                soLanXuatHien = TimSoLanXuatHienNXB(kieuTK);
            else
                soLanXuatHien = TimSoLanXuatHienNXB(kieuTK);

            List<string> listNXB = LayDanhSachNXB();
            List<string> kq = new List<string>();

            foreach (var nxb in listNXB)
            {
                if (DemSoLanXuatHien_MotNXB(nxb) == soLanXuatHien && !kq.Contains(nxb))
                    kq.Add(nxb);
            }
            return kq;
        }

        private void HienThiAnPham_MotNXB(string nxb)
        {
            foreach (var sach in dsSach.dsSach)
            {
                if (nxb.CompareTo(sach.NhaXuatBan) == 0)
                    Console.WriteLine(sach);
            }
            foreach (var bao in dsBao.dsBao)
            {
                if (nxb.CompareTo(bao.NhaXuatBan) == 0)
                    Console.WriteLine(bao);
            }
            foreach (var tapChi in dsTapchi.dsTapChi)
            {
                if (nxb.CompareTo(tapChi.NhaXuatBan) == 0)
                    Console.WriteLine(tapChi);
            }
        }

        private void XuatNgangDoi(int soNgangDoi)
        {
            for (int i = 0; i < soNgangDoi; i++)
                Console.Write("=");
            Console.WriteLine();
        }

        private string NhapNXB()
        {
            string nxb;
            Console.Write("\nNhap NXB (Viet hoa chu cai dau tien): ");
            nxb = Console.ReadLine().Trim();
            return nxb;
        }
        #endregion

        #region public
        public void NhapBangTay()
        {
            string luaChon = " ";
            do
            {
                Console.Clear();
                Console.WriteLine("1. Nhap du lieu bang tay.");
                Console.Write("Nhap ky hieu S, B, TC de chon (e hoac E de thoat): ");
                luaChon = Console.ReadLine().ToUpper();
                TaoDanhSach(luaChon, KieuNhap.NhapTay);

            } while (luaChon != "E" && luaChon != "e");
        }

        public void NhapTuFile()
        {
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line = sr.ReadLine()) != null)
            {
                TaoDanhSach(line, KieuNhap.NhapFile);
            }
        }

        public void TimAnPhamTieuDe(KieuTimKiem ktk)
        {
            int doDaiTieuDe = 0;
            string daiNgan = " ";

            if (ktk == KieuTimKiem.DaiNhat)
            {
                doDaiTieuDe = TimDoDai_TieuDe(ktk);
                daiNgan = "dai";
            }
            else if (ktk == KieuTimKiem.NganNhat)
            {
                doDaiTieuDe = TimDoDai_TieuDe(ktk);
                daiNgan = "ngan";
            }

            Console.WriteLine("An pham co tua de {0} nhat la: ", daiNgan);
            foreach (var sach in dsSach.dsSach)
            {
                if (sach.TuaDe.Length == doDaiTieuDe)
                    Console.WriteLine(sach);
            }
            foreach (var tapChi in dsTapchi.dsTapChi)
            {
                if (tapChi.TuaDe.Length == doDaiTieuDe)
                    Console.WriteLine(tapChi);
            }
        }

        public void TimAnPhamSoTrang(KieuTimKiem ktk)
        {
            int doDaiTrang = 0;
            string daiNgan = " ";

            if (ktk == KieuTimKiem.DaiNhat)
            {
                doDaiTrang = TimDoDai_Trang(ktk);
                daiNgan = "dai";
            }
                
            else
            {
                doDaiTrang = TimDoDai_Trang(ktk);
                daiNgan = "ngan";
            }

            Console.WriteLine("An pham co so trang {0} nhat la: ", daiNgan);
            foreach (var sach in dsSach.dsSach)
            {
                if (sach.SoTrang == doDaiTrang)
                    Console.WriteLine(sach);
            }
            foreach (var bao in dsBao.dsBao)
            {
                if (bao.SoTrang == doDaiTrang)
                    Console.WriteLine(bao);
            }
            foreach (var tapChi in dsTapchi.dsTapChi)
            {
                if (tapChi.SoTrang == doDaiTrang)
                    Console.WriteLine(tapChi);
            }
        }

        public void HienThiAnPhamSapXepSoTrang(KieuSapXep kieuSX)
        {
            string tangGiam = " ";
            dsSach.SapXep_SoTrang(kieuSX);
            dsBao.SapXep_SoTrang(kieuSX);
            dsTapchi.SapXep_SoTrang(kieuSX);
            if (kieuSX == KieuSapXep.SapTang)
                tangGiam = "tang";
            else
                tangGiam = "giam";
            Console.WriteLine("Danh sach cac an pham sau khi sap xep {0} theo so trang", tangGiam);
            XuatDSAnPham();
        }

        public void TimTapChiTheoSoBaiViet(KieuTimKiem kieuTK)
        {
            List<TapChi> kq = new List<TapChi>();
            string nhieuIt = " ";
            if (kieuTK == KieuTimKiem.NhieuNhat)
            {
                kq = dsTapchi.TimTapChi_SoBaiViet(kieuTK);
                nhieuIt = "nhieu";
            }            
            else
            {
                kq = dsTapchi.TimTapChi_SoBaiViet(kieuTK);
                nhieuIt = "it";
            }

            Console.WriteLine("Tap chi co so luong bai viet {0} nhat la: ", nhieuIt);
            foreach (var tapChi in kq)
            {
                Console.WriteLine(tapChi);
            }
        }

        public void TimNXBXuatBanAnPham(KieuTimKiem kieuTK)
        {
            List<string> kq;
            int soLanXuatHien;
            string nhieuIt;
            if (kieuTK == KieuTimKiem.NhieuNhat)
            {
                kq = TimNXBXuatHien(kieuTK);
                soLanXuatHien = TimSoLanXuatHienNXB(kieuTK);
                nhieuIt = "nhieu";
            }
            else
            {
                kq = TimNXBXuatHien(kieuTK);
                soLanXuatHien = TimSoLanXuatHienNXB(kieuTK);
                nhieuIt = "it";
            }

            Console.WriteLine("Nha xuat ban xuat ban {0} an pham nhat la: ", nhieuIt);
            foreach (var nxb in kq)
            {
                Console.WriteLine(nxb);
            }
            Console.WriteLine("\nSo an pham xuat ban {0} nhat la: {1}", nhieuIt, soLanXuatHien);
        }

        public void HienThiAnPhamTheoNXB()
        {
            List<string> listNXB = LayDanhSachNXB();
            foreach (var nxb in listNXB)
            {
                Console.WriteLine("\nNXB: {0}", nxb);
                XuatNgangDoi(65);
                HienThiAnPham_MotNXB(nxb);  
            }
        }

        public void TimAllAnPhamTheoNXB()
        {
            string nxb;
            List<string> listNXB = LayDanhSachNXB();
            nxb = NhapNXB();
            if (listNXB.Contains(nxb))
            {
                Console.WriteLine("\nNXB: {0}", nxb);
                HienThiAnPham_MotNXB(nxb);
            }
            else
                Console.WriteLine("Khong co NXB nao trong danh sach co ten la: {0}", nxb);
        }

        public void XoaAllAnPhamTheoNXB()
        {
            string nxb;
            List<string> listNXB = LayDanhSachNXB();
            nxb = NhapNXB();
            if (listNXB.Contains(nxb))
            {
                Console.WriteLine("Da xoa cac an pham cua NXB: {0}", nxb);
                dsSach.dsSach.RemoveAll(x => x.NhaXuatBan.CompareTo(nxb) == 0);
                dsBao.dsBao.RemoveAll(x => x.NhaXuatBan.CompareTo(nxb) == 0);
                dsTapchi.dsTapChi.RemoveAll(x => x.NhaXuatBan.CompareTo(nxb) == 0);
            }
            else
                Console.WriteLine("Khong co NXB nao trong danh sach co ten la: {0}", nxb);
        }

        public void XuatDSAnPham()
        {
            Console.WriteLine("\nDanh sach hien hanh: ");
            Console.WriteLine(dsSach);
            Console.WriteLine(dsBao);
            Console.WriteLine(dsTapchi);
        }
        #endregion

    }
}
