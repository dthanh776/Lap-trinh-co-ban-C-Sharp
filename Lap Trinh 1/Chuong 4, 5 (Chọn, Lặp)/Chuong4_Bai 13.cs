/*
20211tt0660
Bùi Duy Thanh
Chương 4_Bài 13
 */
using System;

namespace Chuong4_Bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien thang, nam
            string thang;
            int nam;

            // Nguoi dung nhap vao
            Console.Write("Nhap vao thang:");
            thang = Console.ReadLine();
            Console.Write("Nhap vao nam:");
            nam = int.Parse(Console.ReadLine());

            // Kiem tra dieu kien
            if (thang == "thang 1" || thang == "thang 3" || thang == "thang 5" || thang == "thang 7" || thang == "thang 8" || thang == "thang 10" || thang == "thang 12")
            {
                Console.WriteLine(thang + " co 31 ngay");
            }
            else if (thang == "thang 4" || thang == "thang 6" || thang == "thang 9" || thang == "thang 11")
            {
                Console.WriteLine(thang + " co 30 ngay");
            }

            // Kiem tra dieu kien thang 2 (28 hoac 29 ngay)
            else if (thang == "thang 2")
            {
                Console.WriteLine(thang + " co 29 ngay");
                if (nam % 4 == 0 && nam % 400 == 0 && nam % 100 != 0)
                {
                    Console.WriteLine(thang + " co 28 ngay");
                }
            }
        }
    }
}
