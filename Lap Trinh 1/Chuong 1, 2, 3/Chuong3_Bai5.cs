/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 5
 */
using System;

namespace Chuong3_Bai5
{
    class Chuong3_Bai5
    {
        static void Main(string[] args)
        {
            // Nhap vao so thu 1
            Console.WriteLine("Nhap vao so a bat ki: ");
            int a = Convert.ToInt32(Console.ReadLine());
            // Nhap vao so thu 2
            Console.WriteLine("Nhap vao so b bat ki: ");
            int b = Convert.ToInt32(Console.ReadLine());
            // Tim so lon nhat
            Console.WriteLine(a > b ? "a la so lon nhat" : "b la so lon nhat");

            Console.ReadKey();
        }
    }
}
