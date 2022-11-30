/*
Bui Duy Thanh
20211tt0660
Chuong6 _Bai 6
 */
using System;

namespace Chuong_6_Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ham nhap so nguyen n
            int n = NhapSoNguyen();

            // Kiem tra so hoan hao
            if (KiemTraSHH(n) == true)
            {
                Console.WriteLine($"{n} La so hoan hao");
            }
            else
            {
                Console.WriteLine($"{n} Khong la so hoan hao");
            }
            // In so hoan hao
            InSoHoanHao();
        }

        // Nhap so nguyen duong
        static int NhapSoNguyen()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        //kiem tra so hoan hao
        static bool KiemTraSHH(int n)
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
            else
                return false;
        }

        // In cac so hoan hao < 1000
        static void InSoHoanHao()
        {
            Console.Write("Cac so hoan hao < 1000 la: ");
            for (int i = 1; i < 1000; i++)
            {
                if (KiemTraSHH(i) == true)
                {
                    Console.Write($"{i}\t");
                }
            }
        }
    }
}
