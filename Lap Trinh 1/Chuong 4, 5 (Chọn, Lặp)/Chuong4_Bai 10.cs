/*
 Bui Duy Thanh
 20211tt0660    
 Chuong 4_Bai 10
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_4_Bai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Khai bao va nhap a
            Console.Write("Nhap vao so a: ");
            double a = double.Parse(Console.ReadLine());

            // Khai bao va nhap b
            Console.Write("Nhap vao so b: ");
            double b = double.Parse(Console.ReadLine());

            // Khai bao va nhap c
            Console.Write("Nhap vao so c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            //Xet va tinh cac truong hop

                if (delta == 0)
                {
                    Console.Write("Phuong trinh co nghiem kep: x1 = x2 = {0}", -b / 2 * a);
                }
                else if (delta > 0)
                {
                    Console.Write("Phuong trinh co 2 nghiem: x1 = {0} va x2 = {1}", ((-b + Math.Sqrt(delta)) / 2 * a), ((-b - Math.Sqrt(delta)) / 2 * a));
                }
                else
                {
                    Console.Write("Phuong trinh vo nghiem");
                }


            Console.ReadKey();
        }
    }
}
