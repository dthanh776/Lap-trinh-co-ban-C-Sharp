/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 3_Bai 7
 */
using System;

namespace Chuong3_Bai7
{
    class Chuong3_Bai7
    {
        static void Main(string[] args)
        {
            int gio;
            int phut;
            int ngay;
            Console.WriteLine("Nhap bao nhieu giay cung duoc");
            int giay = int.Parse(Console.ReadLine());
            ngay = giay / 86400;
            giay = giay % 86400;
            gio = giay / 3600; //7261 / 3600 = 2 gio
            giay = giay % 3600; // 7261 % 3600 = 61 giay
            phut = giay / 60; // 61 / 60 = 1 phut
            giay = giay % 60; // 61 % 60 = 1 giay
            Console.WriteLine("{0:00} ngay {1:00} gio {2:00} phut {3:00} giay", ngay, gio, phut, giay);

            Console.ReadKey();
        }
    }
}
