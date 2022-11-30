/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 10
 */
using System;

namespace Chuong3_Bai10
{
    class Chuong3_bai10
    {
        static void Main(string[] args)
        {
            // Nhap x1
            Console.Write("Nhap vao so nguyen x1: ");
            double x1 = double.Parse(Console.ReadLine());
            // Nhap y1
            Console.Write("Nhap vao so nguyen y1: ");
            double y1 = double.Parse(Console.ReadLine());
            // Nhap x2
            Console.Write("Nhap vao so nguyen x2: ");
            double x2 = double.Parse(Console.ReadLine());
            // Nhap y2
            Console.Write("Nhap vao so nguyen y2: ");
            double y2 = double.Parse(Console.ReadLine());

            // Tinh khoang cach
            double khoangCach = Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));
            //khoangCach = Math.Round(khoangCach, 2);
            Console.WriteLine("Khoang cach giua hai diem la: " + khoangCach);

            Console.ReadKey();
        }
    }
}
