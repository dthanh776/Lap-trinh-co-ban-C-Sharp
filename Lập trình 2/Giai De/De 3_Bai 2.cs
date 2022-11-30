using System;
using System.IO;

namespace Bai2
{
    struct DiaChi
    {
        public string Quan, thanhPho;
    }
    struct SinhVien
    {
        public string maSV, tenSV;
        public DiaChi diaChi;
        public double diemTB;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien n = ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] arrA = new SinhVien[n];
            NhapSD(arrA);
            XuatSD(arrA);

            // Cập nhập diem trung binh
            Console.WriteLine("Moi nhap ma sinh vien: ");
            string key = Console.ReadLine();
            CapNhap(arrA, key);
            XuatSD(arrA);

            Console.ReadKey();
        }
        // Nhập danh sách nhân viên
        static void NhapSD(SinhVien[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("1. Nhap maSV: ");
                arrA[i].maSV = Console.ReadLine();
                Console.Write("2. Nhap tenSV: ");
                arrA[i].tenSV = Console.ReadLine();
                Console.Write("3. Nhap diemTB: ");
                double.TryParse(Console.ReadLine(), out arrA[i].diemTB);
                Console.WriteLine("4. Nhap DiaChi: ");
                Console.Write($"- Nhap Quan: ");
                arrA[i].diaChi.Quan = Console.ReadLine();
                Console.Write($"- Nhap Thanh Pho: ");
                arrA[i].diaChi.thanhPho = Console.ReadLine();
            }
        }
        // Xuất danh sách nhân viên
        static void XuatSD(SinhVien[] arrA)
        {
            Console.WriteLine($"{"Ma Sinh Vien",-20}{"Ten Sinh Vien",-20}{"Diem Trung Binh",-20}{"Quan",-20}{"Thanh Pho",-20}");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.WriteLine($"{arrA[i].maSV,-20}{arrA[i].tenSV,-20}{arrA[i].diemTB,-20}{arrA[i].diaChi.Quan,-20}{arrA[i].diaChi.thanhPho,-20}");
            }
        }

        //c) Cập nhập diem trung binh
        static void CapNhap(SinhVien[] arrA, string key)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                if (key == arrA[i].maSV)
                {
                    Console.Write("Nhap vao diem trung binh moi: ");
                    arrA[i].diemTB = double.Parse(Console.ReadLine());
                }
            }
        }
        //d) Điểm trung bình >= điểm
        static void InSinhVien(SinhVien[] arr)
        {
            double diem;
            do
            {
                Console.Write("Nhap diem: ");
                double.TryParse(Console.ReadLine(), out diem);
            } while (diem < 0 || diem > 10);

            try
            {
                StreamWriter wr = new StreamWriter("D:\\GiaiBai3.txt");
                using (wr)
                {
                    int count = 0;
                    wr.WriteLine("Danh sach sinh vien co diem >= 0" + diem + ":");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].diemTB >= diem)
                        {
                            wr.WriteLine(arr[i].ToString());
                            count++;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Tim thay {count} sinh vien co diem >= {diem}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            catch (Exception)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("Khong ghi duoc fle");
            }

        }
    }
}
