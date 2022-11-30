/*
Bui Duy Thanh
20211tt0660
Chuong6 _Bai 7
 */
using System;

namespace Chuong6__Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = NhapSoNguyenDuong();

            // Kiem tra so doi xung
            if (KiemTraSoDoiXung(n) == true)
            {
                Console.WriteLine($"{n} là số đối xứng");
            }
            else
            {
                Console.WriteLine($"{n} không là số đối xứng");
            }
            InSoDoiXung();
        }

        // Nhap so nguyen duonng
        static int NhapSoNguyenDuong()
        {
            int n;
            do
            {
                Console.Write("Nhập số nguyên dương n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }

        // Kiem tra so doi xung
        static bool KiemTraSoDoiXung (int n)
        {
            int a, sum = 0, b;
            b = n;
            while (n >0)
            {
                a = n % 10;
                sum = sum * 10 + a;
                n = n / 10;
            }
            if (b == sum)
                return true;
            else
                return false;
        }
        // Ham in so doi xung
        static void InSoDoiXung ()
        {
            int dem = 0;
            Console.WriteLine("Các số đối xứng là: ");
            for (int i = 1; i < 500; i++)
            {
                if (KiemTraSoDoiXung(i) == true)
                {
                    dem++;
                    Console.Write($"{i,-5}\t");
                }
            }
            Console.WriteLine($"\nSố lượng các số đối xứng là: {dem}");
        }

    }
}
