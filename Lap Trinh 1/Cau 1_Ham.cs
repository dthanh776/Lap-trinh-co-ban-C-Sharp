/*
 *Bùi Duy Thanh
 *20211TT0660
 *Kiem Tra Ham
 */
using System;

namespace KiemTraHam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen
            int n = NhapSoNguyen();
            
            // Kiem tra n co phai la SNT
            KiemTraSNT(n);

            // In ra cac SNT <= n
            InSNT(n);

            // Dem SNT <= n
            DemSNT(n);

            // Tong cac SNT <=n
            TongSNT(n);

            // Dung man hinh
            Console.ReadKey();
        }
        // Ham nhap so nguyen 
        static int NhapSoNguyen ()
        {
            // Khai bao bien n
            int n;
            // Nhap n va kiem tra dieu kien (neu sai nhap lai)
            do
            {
                Console.WriteLine("Nhap so nguyen n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        // Ham kiem tra so nguyen to
        static bool KiemTraSNT (int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        // Ham kiem tra N co phai la SNT khong
        static void KiemTraN (int n)
        {
            if (KiemTraSNT(n) == true)
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
                Console.WriteLine($"{n} KHONG la so nguyen to");
        }
        // Ham in ra cac SNT <= N
        static void InSNT (int n)
        {
            Console.Write($"Cac so nguyen to <= n la: ");
            for (int i = 2; i <= n; i++)
            {
                if (KiemTraSNT(i) == true)
                {
                    Console.Write($"{i,-5}");
                }
            }
        }
        // Ham dem so luong SNT <= N
        static void DemSNT(int n)
        {
            // Khai bao bien dem
            int dem = 0;
            for (int i = 2; i <= n; i++)
            {
                if (KiemTraSNT(i) == true)
                {
                    dem++;
                }
            }
            // In ra ket qua
            Console.WriteLine($"\nCo {dem} SNT <= n");
        }
        // Ham tinh tong SNT
        static void TongSNT (int n)
        {
            // Khai bao bien tong
            int tong = 0;
            for (int i = 2; i <= n; i++)
            {
                if (KiemTraSNT(i) == true)
                {
                    tong += i;
                }
            }
            // In ra ket qua
            Console.WriteLine($"Tong cac so nguyen to <= n la: {tong}");
        }
    }
}
