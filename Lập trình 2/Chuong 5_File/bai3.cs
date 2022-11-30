/* Nguyen thi my phuong
 * cd20tt3
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bai4
{
    class bai3

    {
        struct HangHoa
        {
            public string maHang, tenHang;
            public int soLuong, donGia;
        }
        static void Main(string[] args)
        {
            //Khai bao nhap do dai mang:
            int n = 0;
            Console.Write("Nhap so hang hoa: ");
            int.TryParse(Console.ReadLine(), out n);
            //Khai bao, cap phat mang:
            HangHoa[] arr = new HangHoa[n];
            //Goi ham nhap/ghi:
            NhapMangHH(arr);
            GhiMangHH(arr, "D:\\P\\HangHoa.txt");
        }
        static void  GhiMangHH(HangHoa[]arr, string filename)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.WriteLine(arr.Length);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sw.WriteLine($"{arr[i].maHang},{arr[i].tenHang},{arr[i].soLuong},{arr[i].donGia}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ghi file that bai");
                throw;
            }
        }
        static void NhapMangHH (HangHoa[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\t Nhap ma hang hoa : ");
                arr[i].maHang = Console.ReadLine();
                Console.Write("\t Nhap ten hang hoa : ");
                arr[i].tenHang = Console.ReadLine();
                Console.Write("\t Nhap so luong hang hoa: ");
                int.TryParse(Console.ReadLine(), out arr[i].soLuong);
                Console.Write("\t Nhap don gia hang hoa: ");
                int.TryParse(Console.ReadLine(), out arr[i].donGia);
               
            }
        }
    }
}
