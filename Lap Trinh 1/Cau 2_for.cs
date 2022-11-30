/*
 *Bui Duy Thanh
 *202110660
 *Kiem tra chuoong 4,5
 *Bai 2
 */
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien tiep tuc
            char tiepTuc;           
            do
            {

            // Khai bao bien n
            int n = 0;
            // Nhap vao so nguyen duong n va kiem tra dieu kien nhap (neu nhap sai nhap lai)
            do
            {
                Console.Write("Nhap vao nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            // Khai bao bien dem
            int dem = 0;
            // Kiem tra so n co phai la so nguyen to hay khong
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
                Console.WriteLine($"So {n} la so nguyen to");
            else
                Console.WriteLine($"So {n} KHONG phai la so nguyen to");
            
            // Hoi nguoi dung co muon tiep tuc khong
                Console.Write("Ban co muon tiep tuc khong (Nhap Y de tiep tuc)???");
                tiepTuc = char.Parse(Console.ReadLine());

            // Xoa man hinh
                Console.Clear();
            } while (tiepTuc == 'Y' || tiepTuc == 'y');


            // Dung man hinh
            Console.ReadKey();
        }
    }
}
