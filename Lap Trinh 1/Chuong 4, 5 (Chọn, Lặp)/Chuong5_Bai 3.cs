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

            // Kiem tra so nguyen to
            int dem = 0;
            for (int i = 1; i <= n ; i++)
            {
                if (n % i == 0)
                    dem++;
            }
            if (dem == 2)
                Console.WriteLine($"So {n} la so nguyen to");
            else
                Console.WriteLine($"So {n} khong phai so nguyen to");
            Console.ReadKey();
        }
    }
}
