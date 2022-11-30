/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 15
 */
using System;

namespace Chuong5_Bai15
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                n = int.Parse(Console.ReadLine());
            }
            int a = n;
            while (n != 0)
            {

                S = S * 10 + n % 10;
                n = n / 10;

            }

            Console.WriteLine(S);
            if (a == S)
            {
                Console.Write("n la so doi xung");
            }
            else Console.Write("n ko la so doi xung");
            Console.ReadKey();
        }
    }
}
