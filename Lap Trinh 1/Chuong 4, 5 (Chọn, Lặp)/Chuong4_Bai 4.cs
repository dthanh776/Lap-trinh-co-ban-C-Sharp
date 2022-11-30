/*
 20211tt0660
Bùi Duy Thanh
Chương 4_Bài 4
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Chuong4_Bai4
    {
        static void Main(string[] args)
        {
            nhaplai:
            // Khai bao cho nguoi dung nhap vao so nguyeen
            Console.WriteLine("Nhap vao so nguyen 1 -> 100");
            int n = Convert.ToInt32(Console.ReadLine());

            // Kiem tra dieu kien
            if (n >= 1 && n <= 100 )
            {
                if (n % 2 == 0 && n % 3 == 0 )
                    Console.WriteLine("La so chan chia het cho 3");
                else
                    Console.WriteLine("Khong thoa dieu kien");
            }
            else
            {
                Console.WriteLine("Vui long nhap lai: ");
                goto nhaplai;
            }
            Console.ReadKey();
        }
    }
}
