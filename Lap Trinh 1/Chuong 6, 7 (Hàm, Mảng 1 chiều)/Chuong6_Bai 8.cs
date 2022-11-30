/*
Bui Duy Thanh
20211tt0660
Chuong6 _Bai 8
 */
using System;

namespace Chuong6_Bai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen n
            int n = NhapSoNguyen();

            // In so Fibonacci
            Fibonacci(n);
        }
        // Ham nhap so nguyen n
        static int NhapSoNguyen()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        // Ham in day so Fibonacci
        static void Fibonacci (int n)
        {
            int a = 0;
            int b = 1;
            Console.Write("Day so Fibonaci <= n la: ");
            for (int i = 1; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.Write($"{c}\t");
            }
        }
    }
}
