/*
 * 20211TT0660
 * Bùi Duy Thanh
 * Bài 1
 */
using System;

namespace Bai1
{
    class Bai1
    {
        static void Main(string[] args)
        {
            // Khai báo biến a, b, c
            int a, b, c;
            // Kiem tra dieu kien nhap cua a, b, c (a, b, c > 0)
            do
            {
                Console.WriteLine("Nhap vao so thu 1");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao so thu 2");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao so thu 3");
                c = int.Parse(Console.ReadLine());
            } while (a <0 || b < 0 || c < 0);

            // Kiem tra 3 so vua nhap co phai tat ca la so chan ko
            if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0) // kiem tra a,b,c chia het cho 2
            {
                Console.WriteLine("Ca ba so deu la so chan");
            }
            // Kiem tra 3 so vua nhap co phai tat ca la so le ko
            else if (a % 2 != 0 && b % 2 != 0 && c % 2 != 0) // kiem tra a,b,c khong chia het cho 2
            {
                Console.WriteLine("ca ba so deu la so le");
            }
            else
            {
                // khai bao bien chan va le
                int chan = 0; int le = 0;
                if (a % 2 == 0) // Kiem tra a chia het cho 2
                {
                    chan++; // tang bien chan len 1 don vi
                }
                else
                {
                    le++; // tang bien le len 1 don vi
                }
                if (b % 2 == 0)
                {
                    chan++;
                }
                else
                {
                    le++;
                }
                if (c % 2 == 0)
                {
                    chan++;
                }
                else
                {
                    le++;
                }
                Console.WriteLine($"co {chan} so chan va {le} so le");
            }
            // cho max = a
            int max = a;
            if (a < b)
            {
                max = b; // so sanh max voi b
            }
            if (max < c)
            {
                max = c; // so sanh max voi c
            }
            // in ra so lon nhat cua 3 so vua nhap
            Console.WriteLine("so lon nhat la: " + max);

            // Dung man hinh
            Console.ReadKey();
        }
    }
}
