/*
 * Bùi Duy Thanh
 * 20211tt0660
 * Chuong 6 _ Bai 12
 */
using System;

namespace Chuong6__Bai_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen n
            int n = NhapSoNguyen();

            // In day fibonacci
            Console.WriteLine("In fibonaci");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Fibonacci(i)}\t");
            }
        }
        // Ham nhap so nguyen
        static int NhapSoNguyen()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen duong: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }

        // Ham in day Fibonacci
        static  int Fibonacci (int n)
        {

            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
