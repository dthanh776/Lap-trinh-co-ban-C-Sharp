/*
 * Bùi Duy Thanh
 * 20211tt0660
 * Chuong 6 _ Bai 10
 */
using System;

namespace Chuong6_Bai_10
{
    class Chuong6_Bai10
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen n
            int n = NhapSoNguyen();

            // Dem so hoan hao
            int dem = DemSoHoanHao(n);
            Console.WriteLine($"Tong so hoan hao <= n: {dem}");

            // In so hoan hao
            InSoHoanHao(n);
        }

        // Ham nhap n
        static int NhapSoNguyen ()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so nguyen duong n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        // Kiem tra so hoan hao
        static bool KiemTraSoHoanHao(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
                return true;
            return false;
        }
        // Dem so hoan hao <= n
        static int DemSoHoanHao(int n)
        {
            int dem = 0;
            for ( int i = 1; i <= n; i++)
            {
                if (KiemTraSoHoanHao(i) == true)
                {
                    dem ++;
                }
            }
            return dem;
        }
        // Liet ke so hoan hao
        static int InSoHoanHao(int n)
        {
            Console.Write("Cac so hoan hao <= n la: ");
            for (int i = 1; i <= n; i++)
            {
                if (KiemTraSoHoanHao(i) == true)
                {
                    Console.Write($"{i}\t");
                }
            }
            return n;
        }
    }
}
