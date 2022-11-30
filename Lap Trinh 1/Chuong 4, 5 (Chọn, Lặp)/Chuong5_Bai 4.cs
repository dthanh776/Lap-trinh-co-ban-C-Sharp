/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao n
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            // Kiem tra so chinh phuong
            int flag = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i * i == n)
                {
                    flag++;
                    break;
                }
            }
            if (flag == 1)
                Console.WriteLine($"{n} la so chinh phuong");
            else
                Console.WriteLine($"{n} khong la so chinh phuong");
            Console.ReadKey();
        }
    }
}
