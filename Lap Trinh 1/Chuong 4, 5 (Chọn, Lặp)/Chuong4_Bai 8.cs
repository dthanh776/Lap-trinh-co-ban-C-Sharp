/*
 20211tt0660
Bùi Duy Thanh
Chương 4_Bài 14
 */
using System;

namespace Chuong4_Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien ott
            char ott;
            ott = char.Parse(Console.ReadLine());
            char kk;
            kk = char.Parse(Console.ReadLine());
            char bb;
            bb = char.Parse(Console.ReadLine());
            char gg;
            gg = char.Parse(Console.ReadLine());

            switch (ott)
            {
                case 'K':
                    switch (kk)
                    {
                        case 'B':
                            Console.Write("Thua");
                            break;
                        case 'G':
                            Console.Write("Thang");
                            break;
                        case 'K':
                            Console.Write("Hoa");
                            break;
                        default:
                            Console.Write("Nhap sai");
                            break;
                    }

                case 'B':
                    switch (bb)
                    {
                    case 'B':
                        Console.Write("Hoa");
                        break;
                    case 'G':
                        Console.Write("Thua");
                        break;
                    case 'K':
                        Console.Write("Thang");
                        break;
                    default:
                        Console.Write("Nhap sai");
                        break;
                    }

                case 'G':
                    switch (gg)
                    {
                        case 'B':
                            Console.Write("Thang");
                            break;
                        case 'G':
                            Console.Write("Hoa");
                            break;
                        case 'K':
                            Console.Write("Thua");
                            break;
                        default:
                            Console.Write("Nhap sai");
                            break;
                    }

            }
            
            Console.ReadKey();
        }
    }
}
