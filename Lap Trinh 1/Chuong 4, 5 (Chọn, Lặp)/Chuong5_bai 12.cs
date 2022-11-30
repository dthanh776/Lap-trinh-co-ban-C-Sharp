/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong__5__Bai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao n
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());


            int i;
            int j;
            int dem = 0;
            // Kiem tra so nguyen to
            for (i = 2; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        dem++;

                }

                if (dem == 2)
                    Console.Write($" {i} ");
                dem = 0;
            }
            Console.ReadKey();
        }
    }
}
