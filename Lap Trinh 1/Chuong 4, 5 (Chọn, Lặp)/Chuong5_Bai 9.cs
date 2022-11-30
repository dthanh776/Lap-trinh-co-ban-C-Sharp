using System;

namespace Chuong5_Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            h = int.Parse(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
