/*
Bui Duy Thanh
20211tt0660
Chuong6 _Bai 9
 */
using System;

namespace Chuong6_Bai_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap so nguyen a
            Console.WriteLine("Nhap so nguyen a: ");
            int a = int.Parse(Console.ReadLine());

            // Nhap so nguyen b
            Console.WriteLine("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());

            // In ra uoc chung lon nhat
            Console.WriteLine("UCLN = " + UCLN(a, b));

            // In ra boi chung nho nhat
            Console.WriteLine("BCNN = " + BCNN(a, b));

            Console.ReadKey();
        }
        // Nhap so nguyen

        // Ham tim UCLN
        static int UCLN(int a, int b)
        {
            while (a * b != 0)
            {
                if (a >= b) 
                    a = a % b;
                else 
                    b = b % a;
            }
            return a + b;
        }
        // Ham tim BCNN
        static int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
    }
}
