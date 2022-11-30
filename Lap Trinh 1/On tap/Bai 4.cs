/*
 *Bui Duy Thanh
 *202110660
 */
using System;

namespace Bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien thang va nam
            int thang = 1;
            int nam = 0;
            // Nhap nam
            Console.WriteLine("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
            // Nhap thang va kiem tra dieu kien
            do
            {
                Console.WriteLine("Nhap vao thang: ");
                thang = int.Parse(Console.ReadLine());
            } while (thang <= 0 || thang > 12);



            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine($"Thang {thang} la mua xuan");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine($"Thang {thang} la mua ha");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine($"Thang {thang} la mua thu");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine($"Thang {thang} la mua dong");
                    break;
                default:
                    Console.WriteLine("Thang khong phu hop");
                    break;
            }
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Thang {thang} co 31 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Thang {thang} co 30 ngay");
                    break;
                case 2:
                    if (nam % 400 == 0 || nam % 4 == 0 )
                    {
                        Console.WriteLine($"Nam nhuan va thang {thang} co 29 ngay");
                    }
                    else
                    {
                        Console.WriteLine($"Nam KHONG nhuan thang {thang} co 28 ngay");
                    }
                    break;
                default:
                    Console.WriteLine("Thang khong phu hop");
                    break;
            }
        }
    }
}
