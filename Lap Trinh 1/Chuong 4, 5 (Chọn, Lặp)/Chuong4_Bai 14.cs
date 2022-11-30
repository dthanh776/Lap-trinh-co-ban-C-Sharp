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

            switch (ott)
            {
                case 'K':
                    Console.Write("Keo thang Giay, thua Bua");
                    break;
                case 'B':
                    Console.Write("Bua thang Keo, thua Giay");
                    break;
                case 'G':
                    Console.Write("Giay thang bua, thua keo");
                    break;
            }
            Console.ReadKey();
        }
    }
}
