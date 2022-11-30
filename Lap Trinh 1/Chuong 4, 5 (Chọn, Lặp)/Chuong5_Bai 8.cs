/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 8
 */
using System;

namespace Chuong5_Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bang cuu chuong");

            // In bang cuu chuong
            for (int a = 2; a <= 9; a++)
            {
                Console.WriteLine();
                for (int b = 1; b <= 10; b++)
                {
                    Console.WriteLine("{0} * {1} = {2}", a, b, (a * b));

                }
            }
            Console.ReadKey();
        }
    }
}
