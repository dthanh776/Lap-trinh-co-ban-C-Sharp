/*
Bui Duy Thanh
20211tt0660
Chuong6 _Bai 3
 */

using System;

namespace Bai3
{
    class bai3
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen n
            int n = NhapSoNguyen();
            
            // Tong cac uoc so
            int kqTong = TongUocSo(n);
            Console.WriteLine($"Tong uoc so cua {n} la: {kqTong} ");

            // Dem uoc so
            int kqDem = DemUocSo(n);
            Console.WriteLine($"So luong uoc so cua {n} la: {kqDem} ");
        }

        // Ham nhap vao so nguyen duong n
        static int NhapSoNguyen()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so nguyen duong n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }

        // Tong cac uoc so
        static int TongUocSo(int n)
        {
            int Tong = 0;
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Tong += i;
                }
            }
            return Tong;
        }

        // Dem so luong uoc so
        static int DemUocSo(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem ++;
                }
            }
            return dem;

        }
    }
}
