/*
 * Bùi Duy Thanh
 * 20211tt0660
 * Chuong 6 _ Bai 11
 */
using System;

namespace Chuong6__Bai_10
{
    class Chuong6_Bai11
    {
        static void Main(string[] args)
        {
            // Ham nhap so nguyen n
            int n = NhapSoNguyen();
            
            // Kiem tra 1 so co phai la so chinh phuong
            KiemTra(n);

            // In so chinh phuong
            InSoChinhPhuong(n);
        }

        // Ham nhap so nguyen n
        static int NhapSoNguyen()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
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
        // Ham in so chinh phuong
        static int InSoChinhPhuong (int n)
        {
            Console.Write("\nDay so chinh phuong la: ");
            for (int i = 1; i <= n; i++)
            {
                if (KiemTraSoChinhPhuong(i) == true)
                {
                    Console.Write($"{i, -5}");
                }
            }
            return n;
        }
        // Ham Kiem tra 1 so co phai la so chinh phuong
        static void KiemTra (int n)
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
