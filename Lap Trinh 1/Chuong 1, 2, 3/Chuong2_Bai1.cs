/*Bùi Duy Thanh
 * 20211TT660
 * Chương 2 bài 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Nhap ban kinh
            Console.WriteLine("Nhap ban kinh hinh tron: ");
            int banKinh = int.Parse(Console.ReadLine());

             // Khai bao hang so
            const double PI = 3.14;

            // Tinh chu vi va dien tich hinh tron
            double chuVi = 2 * banKinh * PI;
            double dienTich = PI * banKinh * banKinh;

            // In chu vi va dien tich hinh tron
            Console.WriteLine($"Chi vi hinh tron la {chuVi}: ");
            Console.WriteLine($"Dien tich hinh tron la {dienTich}: ");

            Console.ReadKey();
        }
    }
}
