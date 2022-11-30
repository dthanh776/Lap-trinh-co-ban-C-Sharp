/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_5_Bai5
{
    class Chuong5_Bai5
    {
        static void Main(string[] args)
        {
            // Khai bao n
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            // Kiem tra so hoan hao
            for (int i = 1; i < n ; i++)
            {
                if ( n % i == 0)
                sum += i;
            }
            if (sum == n)
                Console.WriteLine($"{n} la so hoan hao");
            else
                Console.WriteLine($"{n} khong la so hoan hao");

            Console.ReadKey();
        }
    }
}
