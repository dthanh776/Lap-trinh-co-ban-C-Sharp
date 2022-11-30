/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 10
 */
using System;

namespace Chuong5_Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            h = int.Parse(Console.ReadLine());


            for (int i = 1; i <= h; i++)
            {
                for (int k = 1; k <= h - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
