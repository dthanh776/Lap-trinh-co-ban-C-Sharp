/*
 Ho va Ten: Bui Duy Thanh
 MSSV: 20211tt0660
 Chuong 4_Bai 3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Chuong4
{
    class Bai3_Chuong4
    {
        static void Main(string[] args)
        {
            // Nhap vao so thu 1
            Console.Write("Nhap vao so a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            // Nhap vao so thu 2
            Console.Write("Nhap vao so b: ");
            double b = double.Parse(Console.ReadLine());

            // Tinh va in ra nghiem cua phuong trinh ax + b = 0
            double x = 0;
            if (a != 0)
            {             
                Console.WriteLine($"Nhiem cua phuong la: {x = -b / a}");
                
            }
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            if (a == 0 && b!= 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem" );
            }
            Console.ReadKey();
        }
    }
}
