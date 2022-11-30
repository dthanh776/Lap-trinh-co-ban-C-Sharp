using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 5;
            int c = 3;
            int[,] arr = new int[d, c];
            NhapMang(arr);
            XuatMang(arr);
        }
        static void NhapMang(int[,] arr)
        {
            Random rd = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rd.Next(1, 50);
                }
            }
        }
        static void XuatMang(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j],5}");
                }
                Console.WriteLine();
            }
        }

    }
}
