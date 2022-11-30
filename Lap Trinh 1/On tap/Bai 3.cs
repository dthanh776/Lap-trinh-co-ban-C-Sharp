/*
 *Bui Duy Thanh
 *202110660
 */
using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien gio, phut, giay, ngay
            int gio, phut, giay;
            int ngay = 0;

            // Nhap gio
            Console.Write("Nhap gio: ");
            gio = int.Parse(Console.ReadLine());

            // Nhap phut
            Console.Write("Nhap phut: ");
            phut = int.Parse(Console.ReadLine());

            // Nhap giay
            Console.Write("Nhap giay: ");
            giay = int.Parse(Console.ReadLine());

            

            if (giay >= 60)
            {
                phut = phut + giay / 60;
                giay = giay % 60;

            }
            if (phut >= 60)
            {
                gio = gio + phut / 60;
                phut = phut % 60;
            }
            if (gio >= 24)
            {
                ngay = gio / 24;
                gio = gio % 24;
            }
            Console.WriteLine("Gio, phut, giay vua nhap la: {0} ngay va {1:00} : {2:00} : {3:00}",ngay, gio,phut,giay);

            // Khai bao bien nhap them
            Console.Write("Nhap them giay");
            int nhapThem = int.Parse(Console.ReadLine());

            giay = giay + nhapThem;
            if (giay >= 60)
            {
                phut = phut + giay / 60;
                giay = giay % 60;

            }
            if (phut >= 60)
            {
                gio = gio + phut / 60;
                phut = phut % 60;
            }
            if (gio >= 24)
            {
                ngay = gio / 24;
                gio = gio % 24;
            }
            Console.WriteLine("Gio, phut, giay sau khi them giay: {0} ngay va {1:00} : {2:00} : {3:00}", ngay, gio, phut, giay);
        }
    }
}
