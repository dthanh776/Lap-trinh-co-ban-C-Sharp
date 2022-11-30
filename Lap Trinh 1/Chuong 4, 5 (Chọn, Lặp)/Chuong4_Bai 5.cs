/*
 20211tt0660
Bùi Duy Thanh
Chương 4_Bài 5
 */
using System;

namespace Chuong4_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien gio, phut, giay
            int gio, phut, giay;
            Console.Write("Nhap gio: ");
            gio = int.Parse(Console.ReadLine());

            Console.Write("Nhap phut: ");
            phut = int.Parse(Console.ReadLine());

            Console.Write("Nhap giay: ");
            giay = int.Parse(Console.ReadLine());

            // Khai bao bien nhapThem
            int nhapThem;
            Console.Write("Nhap them giay: ");
            nhapThem = int.Parse(Console.ReadLine());

            giay = giay + nhapThem;

            
            if (giay >= 60)
            {
                phut = phut + giay / 60;
                giay = giay % 60;
                if (phut >= 60)
                {
                    gio = gio + phut / 60;
                    phut = phut % 60;
                }
                if (gio >= 60)
                {
                    gio = gio % 24;
                }
            }
            Console.WriteLine("Thoi gian sau khi da them vao la: {0:00} : {1:00} : {2:00}", gio, phut, giay);
            Console.ReadKey();
        }
    }
}
