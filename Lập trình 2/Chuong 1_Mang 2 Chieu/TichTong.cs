using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhâp số dòng: ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Nhập số cột ");
            int c = int.Parse(Console.ReadLine());

            int[,] arrA = new int[r, c];

            NhapMang(arrA);
            XuatMang(arrA);
            TongSoDuong(arrA,r,c);
            TichSoDuong(arrA);
        }
        static void NhapMang(int [,] arrA)
        {
            Random rd = new Random();
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrA.GetLength(1); j++)
                {
                    arrA[i,j] = rd.Next(-3, 5);
                }
            }
        }
        static void XuatMang(int[,] arrA)
        {
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrA.GetLength(1); j++)
                {
                    Console.Write($"{ arrA[i,j], -5}");
                }
                Console.WriteLine("\n") ;
            }
        }
        static int TongSoDuong (int [,] arrA, int r, int c)
        {
            Console.Write("Tổng các số dương trong mảng là: ");
            int sum = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (arrA[i,j] >= 0)
                    {
                    sum += arrA[i,j];
                    }
                }
                
            }
            Console.Write($"{sum}");
            return sum;
        }
        static int TichSoDuong (int[,] arrA)
        {
            Console.Write("\nTích các số âm trong mảng là: ");
            int product = 1;
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrA.GetLength(1); j++)
                {
                    if (arrA[i,j] < 0)
                    {
                        product *= arrA[i, j];
                    }
                }
            }
            Console.Write("{0}", product);
            return product;
        }
    }
}
