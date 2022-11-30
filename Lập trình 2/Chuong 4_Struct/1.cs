using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    struct GoiCuoc
    {
        public string tenGoi;
        public int chuKi;
        public double giaGoi;
        public int vuotGoi;

        // Nhap
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap ten goi: ");
                tenGoi = Console.ReadLine();
            } while (tenGoi.Length > 10);

            chuKi = (tenGoi[tenGoi.Length - 1] - 48) * 30;

            do
            {
                Console.Write("Nhap gia goi: ");
                double.TryParse(Console.ReadLine(), out giaGoi);
            } while (giaGoi < 0 || giaGoi > 999999);

            do
            {
                Console.WriteLine("Nhap vuot goi: ");
                int.TryParse(Console.ReadLine(), out vuotGoi);
            } while (vuotGoi != 0 && vuotGoi != 1);
        }
        public void Xuat()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Ten goi: {tenGoi}");
            Console.WriteLine($"Chu ki: {chuKi}");
            Console.WriteLine($"Gia goi: {giaGoi}");
            Console.WriteLine($"Vuot goi: {vuotGoi}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void XuatMang(GoiCuoc[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Xuat();
            }
        }
        static void NhapMang(GoiCuoc[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Nhap();
            }
        }
    }
}
