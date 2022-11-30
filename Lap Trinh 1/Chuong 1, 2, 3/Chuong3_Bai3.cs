/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 3
 */
using System;

namespace Chuong3_Bai3
{
    class Chuong3_Bai3
    {
        static void Main(string[] args)
        {
            // Nhap diem toan
            Console.Write("Nhap vao diem Toan: ");
            double a = Convert.ToInt32(Console.ReadLine());
            // Nhap diem ly
            Console.Write("Nhap vao diem Ly: ");
            double b = Convert.ToInt32(Console.ReadLine());
            // Nhap diem hoa
            Console.Write("Nhap vao diem Hoa: ");
            double c = Convert.ToInt32(Console.ReadLine());
            // Tinh diem trung binh
            double diemTB = (a + b + c) / 3;
            diemTB = Math.Round(diemTB, 2);
            Console.WriteLine("Diem trung binh la: " + diemTB);

            Console.ReadKey();
        }
    }
}
