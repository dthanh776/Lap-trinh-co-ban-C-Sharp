using System;
/*
 Bui Duy Thanh
 Bai tap Struct: cau 1
 20211TT0660
 */
namespace Struct_cau1
{
    struct GoiCuoc
    {
        public string tenGoi;
        public int chuKy;
        public double giaGoi;
        public int vuotGoi;
    }
    class Struct_cau1
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong goi cuoc ");
            int soPT = int.Parse(Console.ReadLine());

            GoiCuoc[] gc = NhapMangGoiCuoc(soPT);
            XuatMangGoiCuoc(gc);
        }


        static GoiCuoc[] NhapMangGoiCuoc(int soPT)
        {
            GoiCuoc[] gc = new GoiCuoc[soPT];
            for (int i = 0; i < soPT; i++)
            {
                Console.WriteLine($"Nhap thong tin goi cuoc thu {i + 1}");
                NhapGoiCuoc(ref gc[i]);
            }
            return gc;
        }

        static void XuatMangGoiCuoc(GoiCuoc[] gc)
        {
            for (int i = 0; i < gc.Length; i++)
            {
                Console.WriteLine();
                HienThiGoiCuoc(gc[i]);
            }
        }

        static void NhapGoiCuoc(ref GoiCuoc gc)
        {
            do
            {
                Console.Write("Nhap ten goi cuoc: ");
                gc.tenGoi = Console.ReadLine();
            } while (gc.tenGoi.Length > 10);
            gc.chuKy = (gc.tenGoi[gc.tenGoi.Length - 1] - 48) * 30;
            do
            {
                Console.Write("Nhap gia goi: ");
                gc.giaGoi = double.Parse(Console.ReadLine());
            } while (gc.giaGoi < 0 || gc.giaGoi > 999999);

            do
            {
                Console.Write("Nhap vuot goi: ");
                gc.vuotGoi = int.Parse(Console.ReadLine());
            } while (gc.vuotGoi != 0 && gc.vuotGoi != 1);   
        }
        static void HienThiGoiCuoc(GoiCuoc gc)
        {

            Console.WriteLine($"{"Ten goi",-10} {"Chu ky",-10} {"gia goi",-10} {"Vuot goi",-10}");
            Console.WriteLine($"{gc.tenGoi,-10} {gc.chuKy,-10} {gc.giaGoi,-10} {gc.vuotGoi,-10}");
        }
    }
}

