/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 8
 */
using System;

namespace Chuong3_Bai8
{
    class Chuong3_Bai8
    {
        static void Main(string[] args)
        {
            // Nhap vao so nguyen duong n
            Console.WriteLine("Nhap vao so n bat ki: ");
            int n = Convert.ToInt32(Console.ReadLine());
            // Tang giam chang le
            Console.WriteLine(n % 2 == 0 ? $"{++n}" : $"{--n}");

            Console.ReadKey();
        }
    }
}
