/* Nguyen thi my phuong
 * cd20tt3
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bai4cau4
{
    class Program
    {
        struct HangHoa
        {
            public string maHang, tenHang;
            public int soLuong, donGia;
        }
        static void Main(string[] args)
        {
            HangHoa[] arr = DocMangHH("D:\\P\\HangHoa.txt");
            XuatMangHH(arr);
            GhiTungfile(arr);
        }
        //
        static void GhiTungfile(HangHoa[] arr)
        {
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    using (StreamWriter sW = new StreamWriter($"D:\\P\\HangHoa_{arr[i].maHang}.txt"))
                    {
                        sW.WriteLine($"{arr[i].maHang},{arr[i].tenHang},{arr[i].soLuong},{arr[i].donGia}");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mo file that bai");
                throw;
            }
        }
        //
        static HangHoa[] DocMangHH(string filename)
        {
            int n = 0;
            HangHoa[] arr;
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    int.TryParse(sr.ReadLine(), out n);
                    arr = new HangHoa[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                       string[] s = sr.ReadLine().Split(',');
                        arr[i].maHang = s[0];
                        arr[i].tenHang = s[1];
                        int.TryParse(s[2], out arr[i].soLuong);
                        int.TryParse(s[3], out arr[i].donGia); 
                    }
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Mo file that bai!");
                throw;
            }
            return arr;
        }
        //
        static void XuatMangHH (HangHoa[]arr)
        {
            Console.WriteLine($"{"maHang",-10}{"tenHang",-10}{"soLuong",-10}{"donGia",-10}{"thanhTien",-10}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].maHang,-10}{arr[i].tenHang,-10}{arr[i].soLuong,-10}{arr[i].donGia,-10}{arr[i].soLuong*arr[i].donGia,-10}");
            }
        }
        //
        static void GhiMangHH(HangHoa[] arr, string filename)
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
              
            }
        }
        //static void NhapMangHH(HangHoa[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write("\t Nhap ma hang hoa : ");
        //        arr[i].maHang = Console.ReadLine();
        //        Console.Write("\t Nhap ten hang hoa : ");
        //        arr[i].tenHang = Console.ReadLine();
        //        Console.Write("\t Nhap so luong hang hoa: ");
        //        int.TryParse(Console.ReadLine(), out arr[i].soLuong);
        //        Console.Write("\t Nhap don gia hang hoa: ");
        //        int.TryParse(Console.ReadLine(), out arr[i].donGia);
            
        //    }
        //}
    }
}
