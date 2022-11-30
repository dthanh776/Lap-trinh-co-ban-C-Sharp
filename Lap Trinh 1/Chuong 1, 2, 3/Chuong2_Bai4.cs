/*/*Bùi Duy Thanh
 * 20211TT660
 * Chương 2 bài 4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap vao num1
            Console.WriteLine("Nhap vao gia tri num1: ");
            int num1 = int.Parse(Console.ReadLine());
            // Nhap vao num2
            Console.WriteLine("Nhap vao gia tri num2: ");
            int num2 = int.Parse(Console.ReadLine());

            //Hoan vi num1 va num2
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            //In ra hoan vi
            Console.WriteLine($"Hoan vi cua num1 la {num1}, cua num2 la {num2}");
            Console.ReadKey();
        }
    }
}
