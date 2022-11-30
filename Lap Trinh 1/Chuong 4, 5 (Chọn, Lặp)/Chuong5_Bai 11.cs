
using System;

namespace Chuong5_Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien 
            int x = Convert.ToInt32(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            int i = 1, S = 1;

            while (i <= n)
            {
                int u = 1;
                int j = 1;

                while (j <= i)
                {
                    u = u * x;
                    j++;
                }
                S = S + u;
                i++;
            }
            Console.Write(S);
            Console.ReadKey();
        }
    }
}
