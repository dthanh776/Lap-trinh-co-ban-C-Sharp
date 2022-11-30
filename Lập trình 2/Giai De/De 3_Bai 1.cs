using System;
using System.IO;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];
            Nhap(arr);
            Xuat(arr);
            TimMaxCheoChinh(arr);
            TongTungDong(arr);
        }
        static void Nhap(int[,] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rd.Next(1, 20);
                }
            }
        }
        static void Xuat(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j], 5}");
                }
                Console.WriteLine("\n");
            }
        }
        static void TimMaxCheoChinh (int[,] arr)
        {
            int max = 0;
            // CACH 1
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i == j && arr[i,j] >= max)
            //        {
            //            max = arr[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"So lon nhat tren duong cheo chinh la: {max}");
            // CACH 2
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i,i] > max)
                {
                    max = arr[i, i];
                }
            }
            Console.WriteLine($"So lon nhat tren duong cheo chinh la: {max}");
        }
        static void TongTungDong (int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int tong = 0;
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    tong += arr[i, j];
                }
                Console.WriteLine($"Tong cua dong thu {i+1}: {tong}");
            }
        }
    }
}
