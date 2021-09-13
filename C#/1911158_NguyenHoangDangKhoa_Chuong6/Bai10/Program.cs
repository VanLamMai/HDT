using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static string[] tuDoan = new string[] {"ban", "giuong", "doraemon", "naruto", "songoku", "dog",
                                               "quat", "samsung", "apple", "windows", "lucky", "cat",
                                               "double", "august", "aorus", "vietnam", "letter", "middle"};
        static int demSoTuCanDoan;
        //static int soTuDoanTrung = 0;

        static void Main(string[] args)
        {           
            string tuCanDoan, tuBiAn;
            char kyTuDoan, key;                    

            do
            {
                bool gameOver = false;

                tuCanDoan = ChonTuNgauNhien();
                tuBiAn = AnTuCanDoan(tuCanDoan);
                demSoTuCanDoan = DemSoTuCanDoan(tuCanDoan);

                while (gameOver != true)
                {
                    Console.Clear();
                    XuatTieuDe(tuBiAn, tuCanDoan);
                    kyTuDoan = NhapKyTuDoan(tuBiAn);
                    XuLyTuBiAn(kyTuDoan, tuCanDoan, ref tuBiAn);
                    if (demSoTuCanDoan == 0)
                        gameOver = true;
                }
                XuLyGameOver(tuCanDoan);
                Console.Write("Nhan phim 't' de tiep tuc hoac nhan phim 'k' de thoat: ");
                key = char.Parse(Console.ReadLine());
            } while (key != 'k' && key != 'K');           
      
            //Console.WriteLine("Do dai tuDoan: {0}", tuDoan.Length);
        }

        static void XuatTieuDe(string tuBiAn, string tuCanDoan)
        {
            Console.WriteLine("======================= TroChoiDoanTu =======================\n");           
            Console.WriteLine("Tu bi an la: {0}", tuBiAn);
            Console.WriteLine("So tu can doan la: {0}\n", demSoTuCanDoan);
            Console.WriteLine("-------------------------------------------------------------\n");
        }

        static string ChonTuNgauNhien()
        {
            Random randomGeneration = new Random();
            int numRandom = randomGeneration.Next(tuDoan.Length);            
            return tuDoan[numRandom];
        }

        static string AnTuCanDoan(string tuCanDoan)
        {
            string tuBiAn = tuCanDoan;
            for (int i = 0; i < tuCanDoan.Length; i++)
                tuBiAn = tuBiAn.Replace(tuBiAn[i], '*');           
            return tuBiAn;
        }

        static int DemSoTuCanDoan(string tuCanDoan)
        {
            demSoTuCanDoan = tuCanDoan.Length;           
            return demSoTuCanDoan;
        }

        static char NhapKyTuDoan(string tuBiAn)
        {
            char kyTuDoan;
            Console.Write("Nhap ky tu doan (cac chu cai tu a -> z): ");
            kyTuDoan = char.Parse(Console.ReadLine());                          
            return kyTuDoan;
        }

        static int KiemTraKyTuDaNhap(char kyTuDoan, string tuCanDoan, string tuBiAn)
        {
            int kq = 0; //Khong co trong tu can doan
            tuCanDoan = tuCanDoan.ToLower();
            for (int i = 0; i < tuCanDoan.Length; i++)
            {              
                if (kyTuDoan == tuCanDoan[i] && kyTuDoan != tuBiAn[i])
                {                  
                    demSoTuCanDoan--;
                    kq = 1;
                }
            }
            //Console.WriteLine("Ban da doan trung {0} chu cai!", soTuDoanTrung);
            //Console.WriteLine("So tu can doan la: {0}", demSoTuCanDoan);
            return kq;
        }

        static void XuLyTuBiAn(char kyTuDoan, string tuCanDoan, ref string tuBiAn)
        {
            string kyTuTrungGian;
            tuCanDoan = tuCanDoan.ToLower();
            if (KiemTraKyTuDaNhap(kyTuDoan, tuCanDoan, tuBiAn) == 1)
            {
                for (int i = 0; i < tuCanDoan.Length; i++)
                    if (kyTuDoan == tuCanDoan[i])
                    {                       
                        kyTuTrungGian = tuCanDoan.Substring(i,1);
                        tuBiAn = tuBiAn.Remove(i, 1);
                        tuBiAn = tuBiAn.Insert(i, kyTuTrungGian);
                    }                      
            }
            else
            {
                Console.WriteLine("'{0}' khong co trong tu can doan!!!", kyTuDoan);
                Console.ReadKey();
            }             
        }

        static void XuLyGameOver(string tuCanDoan)
        {
            Console.WriteLine("\n=============================================================\n");            
            Console.WriteLine("Tro choi ket thuc!!!");
            Console.WriteLine("Tu can doan la: {0}", tuCanDoan);
            Console.WriteLine("\n=============================================================\n");            
        }
    }
}
