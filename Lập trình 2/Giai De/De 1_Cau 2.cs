using System;
using System.IO;

namespace ConsoleApp1
{
    class Cau2_De1cs
    {
        struct DiaChi
        {
            public string soNha, quan;
        }
        struct NhanVien
        {
            public string ten;
            public DateTime date;
            public DiaChi diaChi;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            NhanVien[] arrA = new NhanVien[n];
            NhapDSNV(arrA);
            XuatDSNV(arrA);

        }
        // Ham xuat
        static void XuatDSNV(NhanVien[] arrA)
        {
            Console.WriteLine($"{"Ten",-10}{"Ngay sinh",-10}{"So nha",-10}{"Quan",-10}");
        }
        // Nhap danh sach nhan vien
        static void NhapDSNV(NhanVien[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Nhap ten: ");
                arrA[i].ten = Console.ReadLine();
                Console.Write("Nhap date ");
                DateTime.TryParse(Console.ReadLine(), out arrA[i].date);
                Console.Write("Nhap dia chi: ");
                Console.Write("Nhap ten: ");
                arrA[i].diaChi.soNha = Console.ReadLine();
                Console.Write("Nhap quan: ");
                arrA[i].diaChi.quan = Console.ReadLine();
            }
        }
        // Kiem tra ho ten
        static bool ktraTen(string s)
        {
            if (s.Length > 30 || s.Contains("  ") || s[0] == ' ' || s[s.Length - 1] == ' ' || s.ToUpper() != s)
            {
                return false;
            }
            return true;
        }
        static void InFile(NhanVien[] arr, string key)
        {
            try
            {
                using (StreamWriter sW = new StreamWriter("BuiDuyThanh_Output.txt", true))
                {
                    sW.WriteLine(key);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (key == arr[i].diaChi.quan)
                        {
                            sW.WriteLine($"{arr[i].ten}#{arr[i].date.ToString("dd/MM/yyyy")}#{arr[i].diaChi.soNha}#{arr[i].diaChi.quan}");
                        }
                    }
                }
            }
            catch (IOException)
            {
                throw new Exception("Ghi file that bai!!!");
            }

        }
    }
}

