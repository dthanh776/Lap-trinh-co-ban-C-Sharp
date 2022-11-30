using System;

namespace Bai_3__Chuong_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrA = new int[n];
            int[] arrB = new int[n];
            int[] arrC = new int[n];
            // Nhập xuất mảng A
            Console.WriteLine("Các phần tử mảng A: ");
            NhapMang(arrA);
            XuatMang(arrA);

            // Nhập xuất mảng B
            Console.WriteLine("Các phần tử mảng B: ");
            NhapMang(arrB);
            XuatMang(arrB);
            // Tổng A + B
            Console.WriteLine("Tổng 2 mảng A và B là: ");
            TongMangAB(arrA, arrB, arrC);
        }
        // Hàm nhập mảng
        static void NhapMang(int[] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine($"Nhập phần tử thứ {i}");
                //arrA[i] = int.Parse(Console.ReadLine());
                arr[i] = rd.Next(1, 30);
            }
        }
        // Hàm xuất mảng
        static void XuatMang(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i], -10}");
            }
            Console.WriteLine();
        }
        // Tỉnh tổng 2 mảng
        static void TongMangAB (int[] arrA, int[] arrB, int []arrC)
        {
            for (int i = 0; i < arrC.Length; i++)
            {
                arrC[i] = arrA[i] + arrB[i];
            }
            // Xuất mảng C
            XuatMang(arrC);
        }
    }
}
