using System;

namespace ConsoleApp2
{
    class Cau1
    {
        static void Main(string[] args)
        {
            int[,] arrA = new int[3,4];
            NhapMang(arrA);
            XuatMang(arrA);
            TimMaxCot(arrA);
            Console.ReadKey();
        }
        static void TimMaxCot (int[,] arrA)
        {
            for (int j = 0; j < arrA.GetLength(1); j++)
            {
                int max = arrA[0, j];
                for (int i = 0; i < arrA.GetLength(0); i++)
                {
                    if (arrA[i,j] > max)
                    {
                        max = arrA[i, j];
                    }
                }
                Console.WriteLine($"Gia tri lon nhat cua cot {j + 1} la {max}");
            }
        }
        static void XuatMang(int[,] arrA)
        {
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrA.GetLength(1); j++)
                {
                    Console.Write($"{arrA[i,j], 5}");
                }
                Console.WriteLine();
            }
        }
        static void NhapMang(int[,] arrA)
        {
            Random rd = new Random();
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrA.GetLength(1); j++)
                {
                    arrA[i, j] = rd.Next(1, 20);
                    //Console.WriteLine($"Nhap [{i},{j}]");
                    //arrA[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
