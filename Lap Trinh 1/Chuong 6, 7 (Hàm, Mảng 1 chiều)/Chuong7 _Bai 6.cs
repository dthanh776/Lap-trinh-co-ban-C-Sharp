/*
 *Bùi Duy Thanh
 *20211TT0660
 */
using System;


namespace Bai6_Chuong7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;      
            // Khai báo mảng A, B, C
            int[] arrA = new int[10];
            int[] arrB = new int[arrA.Length];
            int[] arrC = new int[arrA.Length];
            //Nhập xuất mảng A 
            Console.WriteLine("Mảng A: ");
            NhapMang(arrA);
            XuatMang(arrA);
            // Tách chẳn lẻ từ mảng A
            TachSo(arrA, arrB, arrC);      
        }
        // Hàm nhập mảng
        static void NhapMang(int[] arrA)
        {
            Random rd = new Random();
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = rd.Next(-10, 10);
            }
        }
        // Hàm xuất mảng
        static void XuatMang(int[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write($"{arrA[i], -5}");
            }
        }
        // Kiểm tra chẳn lẻ 
        static bool KiemTraAmDuong(int n)
        {
            if (n >= 0)
                return true;
            else
                return false;
        }
        // Tách mảng A
        static void TachSo(int[] arrA, int[] arrB, int[] arrC)
        {
            // Khai báo 
            int b = 0, c = 0;
            for (int i = 0; i < arrA.Length; i++)
            {
                if (KiemTraAmDuong(arrA[i]) == true)
                {
                    arrB[b] = arrA[i];
                    b++;
                }
                else
                {
                    arrC[c] = arrA[i];
                    c++;
                }
            }
            // Thay đổi kích thước mảng B và C
            Array.Resize(ref arrB, b);
            Array.Resize(ref arrC, c);
            // Xuất mảng B
            Console.WriteLine("\nMảng B: ");
            XuatMang(arrB);
            // Xuất mảng C
            Console.WriteLine("\nMảng C: ");
            XuatMang(arrC);
        }
    }
}
