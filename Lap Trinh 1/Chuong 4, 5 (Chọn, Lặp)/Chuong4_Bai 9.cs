/*
 20211tt0660
Bùi Duy Thanh
Chương 4_Bài 9
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_4__Bai_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao va nhap so nguyen x
            Console.WriteLine("Nhap vao so nguyen x: ");
            double x = double.Parse(Console.ReadLine());

            // Khai bao va nhap so nguyen y
            Console.WriteLine("Nhap vao so nguyen y: ");
            double y = double.Parse(Console.ReadLine());

            // Chon phep tinh
            Console.WriteLine("Chon mot trong cac phep tinh sau: + , - , * , / ");

            char a;
            char.TryParse(Console.ReadLine(),out a);

            // Sai nhap lai
            if (a != '+' && a!= '-' && a!= '*' && a!= '/')
            {
                Console.Write("Chon sai, yeu cau chon lai: ");
                char.TryParse(Console.ReadLine(), out a);
            }

            // Thuc hien phep tinh
            switch (a)
            {
                case '+':
                    Console.Write($"{x} + {y} = {x+y}");
                    break;
                case '-':
                    Console.Write($"{x} - {y} = {x - y}");
                    break;
                case '*':
                    Console.Write($"{x} * {y} = {x * y}");
                    break;
                case '/':
                    Console.Write($"{x} / {y} = {x / y}");
                    break;
                    
            }

            Console.ReadKey();
        }
    }
}
