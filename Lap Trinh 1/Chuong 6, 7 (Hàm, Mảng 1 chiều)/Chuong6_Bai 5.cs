/*
Bui Duy Thanh
20211tt0660
Chuong6 _Bai 5
 */
using System;

namespace Chuong6_Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen duong n
            int n = NhapSoNguyen();

            // Kiem tra 1 so co phai la so chinh phuong
            KiemTra(n);
        }

        // Ham nhap so nguyen
            static int NhapSoNguyen()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n <0);
            return n;
        }

        // Ham kiem tra so chinh phuong
        static bool KiemTraSoChinhPhuong (int n)
        {
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                if (i * i == n)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        // Kiem tra 1 so co phai la so chinh phuong
        static void KiemTra(int n)
        {
            if (KiemTraSoChinhPhuong(n) == true)
            {
                Console.WriteLine($"{n} la so chinh phuong");
            }
            else
            {
                Console.WriteLine($"{n} KHONG la so chinh phuong");
            }
        }
    }
}
