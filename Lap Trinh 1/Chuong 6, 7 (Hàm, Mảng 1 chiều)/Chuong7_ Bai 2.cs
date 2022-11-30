/*
 *Bùi Duy Thanh
 *20211TT0660
 */
using System;

namespace Bai2_Chuong7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] arrA = new int[1];
            int n = 0;
            int x;
            Console.WriteLine("Nhập -1 để xuất các phần tử vừa nhập");
            while (true)
            {

                Console.Write($"Số thứ {n+1}: ");
                x = int.Parse(Console.ReadLine());
                    if (x == -1) 
                        break;
                    if (n == arrA.Length)
                    {
                        int[] arrB = new int[arrA.Length + 1];
                        for (int i = 0; i < arrA.Length; i++)
                        {
                            arrB[i] = arrA[i];
                        }
                        arrA = arrB;
                    }
                    arrA[n] = x;
                    n++;
            }
            Console.WriteLine("Mảng vừa nhập là: ");
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{arrA[j], -5}");
            }
            Console.ReadKey();
        }
    }
}
