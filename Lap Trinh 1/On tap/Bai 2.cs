/*
 *Bui Duy Thanh
 *202110660
 */
using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien diem trung binh (dTB) va diem ren luyen (dRL)
            double dTB = 0;
            int dRL = 0;

            // Nhap vao diem trung binh va kiem tra dieu kien nhap (neu nhap sai nhap lai)
            do
            {
                Console.Write("Nhap vao diem trung binh: ");
                dTB = double.Parse(Console.ReadLine());
            } while (dTB < 0 || dTB > 10);

            // Nhap vao diem ren luyen va kiem tra dieu kien nhap (neu nhap sai nhap lai)
            do
            {
                Console.Write("Nhap vao diem ren luyen: ");
                dRL = int.Parse(Console.ReadLine());
            } while (dRL < 0 || dRL > 100);

            // In ra xep loai kem
            if (dTB >= 0 && dTB < 3)
                Console.WriteLine("Xep loai kem ");
            // In ra xep loai yeu
            if (dTB >= 3 && dTB < 5)
                Console.WriteLine("Xep loai yeu ");

            // In ra xep loai trung binh kha
            if (dTB >= 5 && dTB < 6.5)
                Console.WriteLine("Xep loai trung binh kha ");

            // In ra xep loai kha va hoc bong
            if (dTB >= 6.5 && dTB < 8 && dRL < 70)
                Console.WriteLine("Xep loai kha ");
            else if (dTB >= 6.5 && dTB < 8 && dRL >= 70)
                Console.WriteLine("Xep loai kha \nCo hoc bong la 2500000 ");

            // In ra xep loai gioi va hoc bong
            if (dTB >= 8 && dTB < 9 && dRL < 70)
                Console.WriteLine("Xep loai gioi ");
            else if (dTB >= 8 && dTB < 9 && dRL >= 70)
                Console.WriteLine("Xep loai gioi \nCo hoc bong la 3000000 ");

            // In ra xep loai xuat sac va hoc bong
            if (dTB >= 9 && dTB <= 10 && dRL < 70)
                Console.WriteLine("Xep loai xuat sac ");
            else if (dTB >= 9 && dTB <= 10 && dRL >= 70)
                Console.WriteLine("Xep loai xuat sac \nCo hoc bong la 4500000 ");

            // Dung man hinh
            Console.ReadKey();
        }
    }
}
