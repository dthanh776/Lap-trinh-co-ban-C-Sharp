/*
 20211tt0660
Bùi Duy Thanh
Chương 4_Bài 6
 */
using System;

namespace Chuong4_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien toan, ly, hoa, tongDiem
            double toan, ly, hoa, tongDiem;
            Console.Write("Nhap diem Toan: ");
            toan = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Ly: ");
            ly = double.Parse(Console.ReadLine());

            Console.Write("Nhap diem Hoa: ");
            hoa = double.Parse(Console.ReadLine());

            // Tinh tong diem
            tongDiem = toan + ly + hoa;

            // Kiem tra dieu kien 
            if (tongDiem >= 15 && toan > 4 && ly > 4 && hoa > 4)
            {
                Console.Write("Dau");
            }
            if (toan >= 5 && ly >= 5 && hoa >= 5)
            {
                Console.Write("Hoc deu cac mon");
            }
            else if (toan > 4 && toan < 5 && ly > 4 && ly < 5 && hoa > 4 && hoa < 5)
            {
                Console.Write("Hoc chua deu cac mon");
            }
            if (toan < 4 && ly < 4 && hoa < 4)
                Console.Write("Thi Hong");

            Console.ReadKey();

            
        }
    }
}
