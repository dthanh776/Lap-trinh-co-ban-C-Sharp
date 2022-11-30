/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 9
 */
using System;

namespace Chuong3_Bai9
{
    class Chuong3_Bai9
    {
        static void Main(string[] args)
        {
            // Khai bao nhap vao so nguyen duong 
            Console.WriteLine("Nhap vao so nguyen duong co 3 chu so :");
            int n = Convert.ToInt32(Console.ReadLine());

            // Khai bao bien sum va sum 1
            int sum;
            int sum1;

            // Dao nguoc 
            sum = n % 10; //321 % 10 = 1
            n = n / 10; // 321 /10 = 32
            sum1 = n % 10; // 32 % 10 = 2
            n = n / 10; // 32 / 10 = 3 
            sum = sum * 100 + sum1 * 10 + n;

            // In so dao nguoc
            Console.WriteLine("So dao nguoc la: " + sum);

            Console.ReadKey();
        }
    }
}
