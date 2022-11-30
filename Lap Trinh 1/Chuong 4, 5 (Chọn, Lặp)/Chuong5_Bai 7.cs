/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 7
 */
using System;

namespace Chuong5_Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien a, b
            int a, b;

            // Nhac nguoi dung nhap a, b
            Console.Write("nhap vao a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("nhap vao b = ");
            b = int.Parse(Console.ReadLine());

            int a1 = a, b1 = b;
            int ucln, bcnn;

            while (a1 * b1 != 0)
            {
                if (a1 >= b1) a1 = a1 % b1;
                else b1 = b1 % a1;
            }
            ucln = a1;
            Console.WriteLine("ucln cua {0} va {1} la {2}", a, b, ucln);
            bcnn = (a * b) / ucln;

            Console.Write("bcnn cua {0} va {1} la {2}", a, b, bcnn);
            Console.ReadKey();
        }
    }
}
