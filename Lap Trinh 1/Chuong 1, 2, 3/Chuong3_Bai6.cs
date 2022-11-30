/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 6
 */
using System;

namespace Chuong3_Bai6
{
    class Chuong3_Bai6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen duong co 2 chu so :");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = n % 10; // 81 % 10 = 1
            n = n / 10; // 81 / 10  = 8
            sum = sum * 10 + n; // 1 * 10 + 8 = 18
            Console.WriteLine("So dao nguoc la: " + sum);

            Console.ReadKey();
        }
    }
}
