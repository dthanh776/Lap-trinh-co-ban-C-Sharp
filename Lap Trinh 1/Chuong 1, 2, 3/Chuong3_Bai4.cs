/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 3
 */
using System;

namespace Chuong3_Bai4
{
    class Chuong3_Bai4
    {
        static void Main(string[] args)
        {
            //Nhap vao so n bat ki
            Console.WriteLine("Nhap vao mot so n bat ki: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //In chan le
            Console.WriteLine(n % 2 == 0 ? $"{n} La so chan" : $"{n} La so le");

            Console.ReadKey();
        }
    }
}
