using System;

namespace Chuong5_Bai14
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
            Console.ReadKey();
        }
    }
}
