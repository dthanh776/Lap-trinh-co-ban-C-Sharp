/*
 *Bùi Duy Thanh
 *20211TT0660
 *Bai 5_Chuong 7
 */
using System;

namespace Bai_5_Chuong_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số phần tử mảng: ");
            int n = int.Parse(Console.ReadLine());

            // Khai báo mảng
            int[] arrA = new int[n];

            // Nhập mảng
            NhapMang(arrA);

            // Xuất mảng
            Console.WriteLine("Mảng vừa nhập là: ");
            XuatMang(arrA);

            // Giá trị lớn nhất trong mảng
            TimMax(arrA);

            // Sắp xếp giảm dần
            Console.WriteLine("\nCác phần tử sau khi sắp xếp giảm dần là: ");
            SapXepGiam(arrA);

            //Kiểm tra các phần tử có trùng nhau
            if (KiemTraTrungNhau(arrA) == true)
            {
                Console.WriteLine("\nCó phần tử trùng nhau");
            }
            else
            {
                Console.WriteLine("\n" +
                    "Không có phần tử trùng nhau");
            }
        }
        // Nhập mảng
        static void NhapMang(int[] arrA)
        {
            Random rd = new Random();
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = rd.Next(0, 10);
            }
        }
        // Xuất mảng
        static void XuatMang(int[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write($"{arrA[i],-10 }");
            }
        }
        // Tìm giá trị lớn nhất trong mảng
        static void TimMax(int[] arrA)
        {
            // Khai báo biến
            int max = arrA[0];

            // duyệt mảng
            for (int i = 0; i < arrA.Length; i++)
            {
                if (max < arrA[i]) // so sánh giá trị
                {
                    max = arrA[i]; // gán lại giá trị
                }
            }
            Console.WriteLine($"\n \nGiá trị lớn nhất trong mảng là: {max}");
        }
        // Sắp xếp giảm dần
        static void SapXepGiam(int[] arrA)
        {
            int gan;
            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = i + 1; j < arrA.Length; j++)
                {
                    if (arrA[i] < arrA[j])
                    {
                        gan = arrA[i];
                        arrA[i] = arrA[j];
                        arrA[j] = gan;
                    }
                }
            }
            XuatMang(arrA);
        }
        // Kiểm tra trùng nhau
        static bool KiemTraTrungNhau(int[] arrA)
        {
            for (int i = 1; i < arrA.Length -1; i++)
            {
                for (int j = i + 1; j < arrA.Length; j++)
                {
                    if (arrA[i] == arrA[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
