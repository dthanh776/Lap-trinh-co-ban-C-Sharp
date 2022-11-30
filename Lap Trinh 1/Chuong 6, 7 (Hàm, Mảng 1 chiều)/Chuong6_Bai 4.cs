/*
Bui Duy Thanh
20211tt0660
Chuong6 _Bai 4
 */
using System;

namespace Chuong6_Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ham nhap so nguyen n
            int n = NhapSoNguyen();

            if (KiemTraSNT(n) == true)
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
                Console.WriteLine($"{n} khong la so nguyen to");
        }
        // Ham nhap so nguyen
        static int NhapSoNguyen ()
        {
            int n;
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
    }
}
