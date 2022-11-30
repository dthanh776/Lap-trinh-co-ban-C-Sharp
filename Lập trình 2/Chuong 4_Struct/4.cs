using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    struct NhanVien
    {
        public string ten;
        public DateTime ngaySinh;
        public double luongCoBan;
        public double heSoLuong;

        public void NhapNV()
        {
            Console.WriteLine("Nhap ten nhan vien");
            ten = Console.ReadLine();

            Console.WriteLine("Nhap ngay sinh");
            DateTime.TryParse(Console.ReadLine(), out ngaySinh);

            Console.WriteLine("Nhap luong co ban");
            double.TryParse(Console.ReadLine(), out luongCoBan);

            Console.WriteLine("Nhap he so luong");
            double.TryParse(Console.ReadLine(), out heSoLuong);
        }
        public string XuatNV()
        {
            return($"Ten: {ten}, Ngay Sinh: {ngaySinh},Luong co ban: {luongCoBan},He so luong: { heSoLuong}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So luong nhan vien: ");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            NhanVien[] arr = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                arr[i].NhapNV();
            }
            foreach (NhanVien i in arr)
            {
                if(i.ngaySinh.Month >= 1 && i.ngaySinh.Month <=3)
                {
                    Console.WriteLine($"Nhan vien co thang sinh quy 1 la: {i.XuatNV()}" );
                }
            }
        }
    }
}
