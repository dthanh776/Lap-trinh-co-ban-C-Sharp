using System;

namespace Chuong5_Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int f = 1, gtk = 1, gtn = 1, gtnk = 1;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= i; k++)
                {
                    if (k == 0 || i == 0)
                    {
                        f = 1;
                        Console.Write(f + " ");
                    }
                    else
                    {
                        for (int i1 = i; i1 >= 1; i1--)
                        {
                            gtn = gtn * i1;
                        }
                        for (int k1 = k; k1 >= 1; k1--)
                        {
                            gtk = gtk * k1;
                        }
                        for (int ik = i - k; ik >= 1; ik--)
                        {
                            gtnk = gtnk * ik;
                        }
                        f = (gtn / (gtnk * gtk));
                        Console.Write(f + " ");
                        gtn = 1; gtnk = 1; gtk = 1;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
