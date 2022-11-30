using System;
/*
 Bui Duy Thanh
 Bai tap Struct: cau 2
 20211TT0660
 */
namespace Struct_cau2
{
    struct GoiCuoc
    {
        public string tenGoi;
        public int chuKy;
        public double giaGoi;
        public int vuotGoi;
    }
    struct ThueBao
    {
        public string hoTen;
        public string soCMND;
        public GoiCuoc goiCuoc;
    }
    class Struct_cau2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong goi cuoc ");
            int soPT = int.Parse(Console.ReadLine());

            ThueBao[] thueBao = NhapMangThueBao(soPT);
            XuatMangThueBao(thueBao);
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

        static void NhapThueBao(ref ThueBao thueBao)
        {
            do
            {
                Console.Write("Nhap ten goi cuoc: ");
                thueBao.goiCuoc.tenGoi = Console.ReadLine();
            } while (thueBao.goiCuoc.tenGoi.Length > 10);
            thueBao.goiCuoc.chuKy = (thueBao.goiCuoc.tenGoi[thueBao.goiCuoc.tenGoi.Length - 1] - 48) * 30;
            do
            {
                Console.Write("Nhap gia goi: ");
                thueBao.goiCuoc.giaGoi = double.Parse(Console.ReadLine());
            } while (thueBao.goiCuoc.giaGoi < 0 || thueBao.goiCuoc.giaGoi > 999999);

            do
            {
                Console.Write("Nhap vuot goi: ");
                thueBao.goiCuoc.vuotGoi = int.Parse(Console.ReadLine());
            } while (thueBao.goiCuoc.vuotGoi != 0 && thueBao.goiCuoc.vuotGoi != 1);
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

        }
        static void HienThiThueBao(ThueBao thueBao)
        {
            Console.WriteLine("Thong tin thue bao");
            Console.WriteLine($"{"Ho ten",-10} {"So CMND",-10}");
            Console.WriteLine($"{thueBao.hoTen,-10} {thueBao.soCMND,-10}");

            Console.WriteLine("Thong tin goi cuoc");
            Console.WriteLine($"{"Ten goi",-10} {"Chu ky",-10} {"gia goi",-10} {"Vuot goi",-10}");
            Console.WriteLine($"{thueBao.goiCuoc.tenGoi,-10} {thueBao.goiCuoc.chuKy,-10} {thueBao.goiCuoc.giaGoi,-10} {thueBao.goiCuoc.vuotGoi,-10}");
        }
        static bool KiemTraHoten(string hoTen)
        {
            if (hoTen[0] == ' ' || hoTen[hoTen.Length - 1] == ' ' || hoTen[0] < 'A' || hoTen[0] > 'Z')
            {
                return false; 
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
    }
}
