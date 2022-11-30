/*
 20211tt0660
Bùi Duy Thanh
Chương 4_Bài 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Bai1_Chuong4
    {
        static void Main(string[] args)
        {
            int max = 0;
            // Nhap so thu 1:  
            Console.Write("Nhap so thu 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            // Nhap so thu 2:
            Console.Write("Nhap so thu 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            // Nhap so thu 3:
            Console.Write("Nhap so thu 3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            // Nhap so thu 4:
            Console.Write("Nhap so thu 4: ");
            int d = Convert.ToInt32(Console.ReadLine());

            // gan max = a;
            max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (max < d)
            {
                max = d;
            }
            
            // in ra so lon nhat
            Console.WriteLine($"{max} la so lon nhat");
            Console.ReadKey();
        }
    }
}
