/*
 20211tt0660
Bùi Duy Thanh
Chương 4_Bài 7
 */
using System;

namespace Chuong4_Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien thang
            int thang;
            Console.Write("Nhap vao thang (1 -> 12): ");
            thang = int.Parse(Console.ReadLine());

            // Kiem tra thang nhap vao co hop le
            while(thang < 0 || thang > 12)
            {
                Console.Write("Nhap sai thang, vui long nhap lai: ");
                thang = int.Parse(Console.ReadLine());
            }

            // Thang vua nhap thuoc quy nao
            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    Console.Write("thang {0} la quy 1", thang);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.Write("thang {0} la quy 2", thang);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.Write("thang {0} la quy 3", thang);
                    break;
                case 10:
                case 11:
                case 12:
                    Console.Write("thang {0} la quy 4", thang);
                    break;
            }
            Console.ReadKey();
        }
    }
}
