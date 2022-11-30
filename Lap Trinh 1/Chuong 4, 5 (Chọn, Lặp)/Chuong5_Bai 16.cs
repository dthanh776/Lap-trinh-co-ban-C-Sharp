using System;

namespace Chuong5_Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 99;
            int a, b;
            int i = 10;
            while (i <= n)
            {

                a = i / 10 + i % 10;
                b = (i % 10) * (i / 10);
                if (a * 2 == b)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
