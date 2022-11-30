/*
* Bui Duy Thanh
* 20211tt0660
* Bai 2
 */
using System;

namespace Bai2
{
    class Bai2
    {
        static void Main(string[] args)
        {
            // Khai bao bien tiep tuc
            char tiepTuc;
            do
            {
                // Ham nhap so nguyen
                int n = NhapSoNguyen();

                // Ham kiem tra n co phai la so nguyen to
                if (KiemTraSNT(n) == 1)
                {
                    Console.WriteLine($"{n} la so nguyen to");
                }
                else
                    Console.WriteLine($"{n} khong phai la so nguyen to");

                //Ham in so nguyen to <= n
                InSoSNT(n);

                // Hoi nguoi dung co muon tiep tuc khong
                Console.WriteLine("\nBan co muon tiep tuc ko (Y/N)?");
                tiepTuc = char.Parse(Console.ReadLine());
            } while (tiepTuc == 'y' || tiepTuc == 'Y'); // Nguoi dung nhap y hoac Y de tiep tuc

            // Dung man hinh
            Console.ReadKey();
        }
        // Ham nhap so nguyen
        static int NhapSoNguyen()
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
        static int KiemTraSNT(int n)
        {
            if (n < 2)
            {
                return 0; //Khong phai SNT tra ve 0
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return 0; //Khong phai SNT tra ve 0
                }
            }
            return 1; //la SNT tra ve 1
        }
        static void InSoSNT (int n)
        {
            Console.Write("Cac so nguyen to <= n la: ");
            for (int i = 0; i <= n ; i++)
            {
                // Kiem tra dieu kien so nguyen to
                if (KiemTraSNT(i) == 1)
                {
                    Console.Write($"{i} \t");
                }
            }
        }
    }
}
