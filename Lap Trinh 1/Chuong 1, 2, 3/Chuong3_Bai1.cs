/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 1
 */
using System;

namespace ConsoleApp2
{
    class Chuong3_Bai1
    {
        static void Main(string[] args)
        {
            
         // Nhap a
         Console.Write("Nhap vao so nguyen a: ");
         double a = double.Parse(Console.ReadLine());
         // Nhap b
         Console.Write("Nhap vao so nguyen b: ");
         double b = double.Parse(Console.ReadLine());
         // Tinh Tong             
         Console.WriteLine($"{a} + {b} = {a + b}");
         // Tinh Hieu
         Console.WriteLine($"{a} - {b} = {a - b}");
         // Tinh Tich
          Console.WriteLine($"{a} * {b} = {a * b}");
         // Tinh Thuong
          Console.WriteLine($"{a} / {b} = {a / b}");

         Console.ReadKey();
        }
    }
}
