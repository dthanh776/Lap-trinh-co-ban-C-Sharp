/*/*Bùi Duy Thanh
 * 20211TT660
 * Chương 2 bài 3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap nam sinh
            Console.WriteLine("Nhap vao nam sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            //Khai bao nam hien tai
            int namHienTai = 2021;

            // Tinh va xuat tuoi hien tai
            int tuoiHienTai = namHienTai - namSinh;
            Console.WriteLine($"Tuoi hien tai = {tuoiHienTai}");

            //Tinh va xuat nam ve huu
            int namVeHuu = 60 - tuoiHienTai + namHienTai;
            Console.WriteLine($"Nam ve huu la: {namVeHuu}");

            Console.ReadKey();

        }
    }
}
