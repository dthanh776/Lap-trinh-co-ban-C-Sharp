/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 2
 */
using System;

namespace Chuong1_Bai2
{
    class Chuong3_Bai2
    {
        static void Main(string[] args)
        {
            // Nhap vao do F
            Console.Write("Nhap vao do F: ");
            int f = Convert.ToInt32(Console.ReadLine());

            // Tinh do C
            int c = ((f - 32) * 5) / 9;
            Console.WriteLine($"{f} do F bang {c} do C");

            Console.ReadKey();
        }
    }
}
