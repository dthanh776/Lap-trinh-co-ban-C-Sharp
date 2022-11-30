using System;
/*
 Bui Duy Thanh
 Bai tap Struct: cau 3
 20211TT0660
 */
namespace Struct_cau3
{
    struct GoiCuoc
    {
        public string tenGoi;
        public int tocDo;
        public double giaGoi;
        public double phiHoaMang;
    }
    struct ThueBao
    {
        public string hoTen;
        public string soCMND;
        public string quan;
        public GoiCuoc goiCuoc;
    }
    class Struct_cau3
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong thue bao: ");
            int soPT = int.Parse(Console.ReadLine());

            ThueBao[] thueBao = NhapMangThueBao(soPT);
            XuatMangThueBao(thueBao);
        }
        static void NhapThueBao(ref ThueBao thueBao)
        {
            do
            {
                Console.Write("Nhap ho ten: ");
                thueBao.hoTen = Console.ReadLine();
            } while (KiemTraHoten(thueBao.hoTen) == false);

            do
            {
                Console.Write("Nhap so CMND: ");
                thueBao.soCMND = Console.ReadLine();
            } while (KiemTraCMND(thueBao.soCMND) == false);

            do
            {
                Console.Write("Nhap quan: ");
                thueBao.quan = Console.ReadLine();
            } while (thueBao.quan.Length > 10);

            do
            {
                Console.Write("Nhap ten goi: ");
                thueBao.goiCuoc.tenGoi = Console.ReadLine();
            } while (thueBao.goiCuoc.tenGoi.Length > 4);

            string tocDo = null;
            tocDo = tocDo + thueBao.goiCuoc.tenGoi[0] + thueBao.goiCuoc.tenGoi[1] + "(Mbps)";
            int.TryParse(tocDo, out thueBao.goiCuoc.tocDo);

            do
            {
                Console.Write("Nhap gia goi: ");
                thueBao.goiCuoc.giaGoi = double.Parse(Console.ReadLine());
            } while (thueBao.goiCuoc.giaGoi > 999999 || thueBao.goiCuoc.giaGoi < 0);

            thueBao.goiCuoc.phiHoaMang = TinhPhiHoaMang(thueBao.quan);
        }

        static void HienThiThueBao(ThueBao thueBao)
        {
            Console.WriteLine("Thong tin thue bao");
            Console.WriteLine($"{"Ho ten",-10} {"So CMND",-10} {"Quan",-10}");
            Console.WriteLine($"{thueBao.hoTen,-10} {thueBao.soCMND,-10} {thueBao.quan,-10}");

            Console.WriteLine("Thong tin goi cuoc");
            Console.WriteLine($"{"Ten goi",-10} {"Toc do",-10} {"Gia goi",-10}  {"Phi hoa mang",-10}");
            Console.WriteLine($"{thueBao.goiCuoc.tenGoi,-10} {thueBao.goiCuoc.tocDo,-10} {thueBao.goiCuoc.giaGoi,-10} {thueBao.goiCuoc.phiHoaMang,-10}");
        }

        static ThueBao[] NhapMangThueBao(int soPT)
        {
            ThueBao[] thueBao = new ThueBao[soPT];
            for (int i = 0; i < soPT; i++)
            {
                Console.WriteLine($"Nhap thong tin goi thue bao {i + 1}");
                NhapThueBao(ref thueBao[i]);
            }
            return thueBao;
        }

        static void XuatMangThueBao(ThueBao[] thueBao)
        {
            for (int i = 0; i < thueBao.Length; i++)
            {
                Console.WriteLine();
                HienThiThueBao(thueBao[i]);
            }
        }

        static bool KiemTraHoten(string hoTen)
        {
            for (int i = 0; i < hoTen.Length; i++)
            {
                if (hoTen[i] == ' ' && hoTen[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        static bool KiemTraCMND(string cmnd)
        {
            if (cmnd.Length != 9)
            {
                return false;
            }
            for (int i = 0; i < cmnd.Length; i++)
            {
                if (cmnd[i] < '0' || cmnd[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
        static double TinhPhiHoaMang(string quan)
        {
            if (quan[quan.Length - 1] == '1' || quan[quan.Length - 1] == '3' || quan[quan.Length - 1] == '5' || quan[quan.Length - 1] == '7')
            {
                return 700000;
            }
            else
            {
                return 0;
            }
        }
    }
}
