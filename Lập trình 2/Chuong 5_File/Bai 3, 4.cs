using System;
using System;
using System.IO;

namespace ConsoleApp3
{
    struct HangHoa
    {
        public string maHang, tenHang;
        public int soLuong, donGia;
    }

    class Program
    {
        static void Main(string[] args)
        {
            HangHoa[] arr = DocFile("D:\\Thanh\\HangHoa.txt");
            XuatHangHoa(arr);
            GhiTungFile(arr);
        }

        // Doc Hang Hoa
        static HangHoa[] DocFile(string path)
        {
            int n = 0;
            HangHoa[] arr;
            try
            {
                using (StreamReader sR = new StreamReader(path))
                {
                    int.TryParse(sR.ReadLine(), out n);
                    arr = new HangHoa[n];
                    for (int i = 0; i < n; i++)
                    {
                        string[] s = sR.ReadLine().Split(',');
                        arr[i].maHang = s[0];
                        arr[i].tenHang = s[1];
                        int.TryParse(s[2], out arr[i].soLuong);
                        int.TryParse(s[3], out arr[i].donGia);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file that bai!!!");
                throw;
            }
            return arr;
        }

        // Xuat Hang Hoa
        static void XuatHangHoa(HangHoa[] arr)
        {
            Console.WriteLine($"{"maHang",-15}|{"TenHang",-15}|{"SoLuong",-15}|{"ThanhTien",-15}|{"DonGia",-15}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i].maHang,-15}|{arr[i].tenHang,-15}|{arr[i].soLuong,-15}|{arr[i].donGia,-15}|{arr[i].soLuong * arr[i].donGia,-15}");
            }
        }

        // Tinh tong tien
        static int TinhTongTien(HangHoa[] arr)
        {
            int tongTien = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tongTien += arr[i].soLuong * arr[i].donGia;
            }
            return tongTien;
        }

        static int[] DocMang(string path)
        {
            int n = 0;
            int[] arr;
            try
            {
                using (StreamReader sR = new StreamReader(path))
                {
                    int.TryParse(sR.ReadLine(), out n);
                    arr = new int[n];

                    string s = sR.ReadLine();
                    string[] t = s.Split(',');

                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = int.Parse(t[i]);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doc file that bai!!!");
                throw;
            }
            return arr;
        }
        //Ham Ghi
        static void GhiTungFile(HangHoa[] arr)
        {
            foreach (HangHoa item in arr)
            {
                try
                {
                    using (StreamWriter sW = new StreamWriter(@"D:\\Thanh\\HangHoa_" + item.maHang + ".txt"))
                    {
                        sW.WriteLine($"{item.maHang},{item.tenHang}{item.soLuong}{item.tenHang}");
                    }
                }
                catch (IOException)
                {
                    throw new Exception("Ghi file that bai");
                }
            }

        }
    }
}

