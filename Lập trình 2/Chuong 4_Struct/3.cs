using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    struct GoiCuoc
    {
        public string tenGoi;
        public int tocDo;
        public double giaGoi;
        public double phiHoaMang;
        // Nhap goi cuoc
        //public void NhapGoiCuoc()
        //{
        //    nhap ten goi cuoc
        //    do
        //    {
        //        Console.Write("Nhap vao ten goi cuoc: ");
        //        tenGoi = Console.ReadLine();
        //    } while (tenGoi.Length > 4);

        //    // toc do
        //    string s = new string(tenGoi[0], tenGoi[1]);
        //    int.TryParse(s, out tocDo);

        //    // gia goi cuoc
        //    do
        //    {
        //        Console.Write("Nhap gia goi cuoc: ");
        //        double.TryParse(Console.ReadLine(), out giaGoi);
        //    } while (giaGoi < 0 || giaGoi > 999999);


        //}
    }
    struct ThueBaoTV
    {
        public string hoTen, soCMND, quan;
        public GoiCuoc gC;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThueBaoTV tb = NhapTB();
            HienThiThongTin(tb);
            Console.ReadKey();
        }
        static void HienThiThongTin(ThueBaoTV tb)
        {
            Console.WriteLine("Thong tin thue bao: ");
            Console.WriteLine($"{"Ho ten: ",-15}{tb.hoTen,-15}");
            Console.WriteLine($"{"So CMND: ",-15}{tb.soCMND,-15}");
            Console.WriteLine($"{"Quan: ",-15}{tb.quan,-15}");

            Console.WriteLine("Thong tin goi cuoc: ");
            Console.WriteLine($"{"Ten goi: ",-15}{tb.gC.tenGoi,-15}");
            Console.WriteLine($"{"Toc do: ",-15}{tb.gC.tocDo,-15}(Mbps) ");
            Console.WriteLine($"{"Gia goi: ",-15}{tb.gC.giaGoi,-15}(VN dong)");
            Console.WriteLine($"{"Phi hoa mang: ",-15}{tb.gC.phiHoaMang,-15}(VN dong)");
        }

        static double TinhPhiHoaMang(string quan)
        {
            if (quan[quan.Length - 1] == '1' && quan[quan.Length - 2] != '1' || quan[quan.Length - 1] == '3' || quan[quan.Length - 1] == '5' || quan[quan.Length - 1] == '7')
            {
                return 700000;
            }
            else
            {
                return 0;
            }
        }
        static ThueBaoTV NhapTB()
        {
            ThueBaoTV tb = new ThueBaoTV();

            // Nhap ho ten
            do { 
            Console.Write("Nhap ho ten: ");
            tb.hoTen = Console.ReadLine();
            }while(KiemTraHoTen(tb.hoTen) == false);
            // Nhap CMND
            do
            {
                Console.Write("Nhap CMND: ");
                tb.soCMND = Console.ReadLine();
            } while (KiemTraCMND(tb.soCMND) == false);

            // Nhap quan
            do
            {
                Console.Write("Nhap quan: ");
                tb.quan = Console.ReadLine();
            } while (tb.quan.Length > 10);

            // Nhap goi cuoc
            do
            {
                Console.Write("Nhap vao ten goi cuoc: ");
                tb.gC.tenGoi = Console.ReadLine();
            } while (tb.gC.tenGoi.Length > 4);

            // Tao toc do tu dong 2 ky tu so dau cua ten goi
            string s = null;
            s = s + tb.gC.tenGoi[0] + tb.gC.tenGoi[1];
            int.TryParse(s, out tb.gC.tocDo);

            // Nhap gia goi cuoc
            do
            {
                Console.Write("Nhap gia goi cuoc: ");
                double.TryParse(Console.ReadLine(), out tb.gC.giaGoi);
            } while (tb.gC.giaGoi > 999999);

            // Tien phi hoa mang
            tb.gC.phiHoaMang = TinhPhiHoaMang(tb.quan);

            return tb;

        }
        static bool KiemTraHoTen(string s)
        {
            if (s[0] == ' ' || s[s.Length - 1] == ' ' || s[0] < 'A' || s[0] > 'Z')
            {
                return false; // Chuoi du khoang trang dau va cuoi
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && (s[i+1] < 'A' || s[i+1] > 'Z' || s[i+1] == ' ' ))
                {
                    return false; // khong in hoa dau tu hoac co 2 khoang trang lien nhau
                }
            }
            return true;
        }
        static bool KiemTraCMND (string s)
        {
            if(s.Length != 9)
            {
                return false; // Chuoi co do dai khac 9 
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    return false; // Chuoi co ky tu chu
                }
            }
            return true;
        }
    }
}
