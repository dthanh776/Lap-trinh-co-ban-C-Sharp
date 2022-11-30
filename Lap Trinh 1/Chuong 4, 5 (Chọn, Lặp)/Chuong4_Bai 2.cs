/*
 20211tt0660
Bùi Duy Thanh
Chương 4_Bài 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Bai2_Chuong4
    {
        static void Main(string[] args)
        {
            // Nhap vao diem trung binh
            do
            {
                // Nhap vao diem trung binh
                Console.Write("Nhap vao diem trung binh: ");
                int DTB = int.Parse(Console.ReadLine());
                // in ra xep loai
                if (DTB >=0 && DTB < 3)
                Console.WriteLine("Xep loai kem ");
            if (DTB >= 3 && DTB < 5)
                Console.WriteLine("Xep loai yeu ");
            if (DTB >= 5 && DTB < 6.5)
                Console.WriteLine("Xep loai trung binh kha ");
            if (DTB >= 6.5 && DTB < 8)
                Console.WriteLine("Xep loai kha ");
            if (DTB >= 8 && DTB < 9)
                Console.WriteLine("Xep loai gioi ");
            if (DTB >= 9 && DTB <= 10)
                Console.WriteLine("Xep loai xuat sac ");
            else
                Console.WriteLine("Nhap sai, yeu cau nhap lai");
            } while (dtb <= 10);

            Console.ReadKey();
        }
    }
}
