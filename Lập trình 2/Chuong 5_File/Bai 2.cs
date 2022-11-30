using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = DocMang(@"D:\\Thanh\\MangNguyen.txt");
            XuatMang(arr);
            //TinhTBC(arr, @"D:\\Thanh\\TinhTBC.txt");
            Console.ReadKey();
            //GhiTongSNT(arr, @"D:\\Thanh\\TongSNT.txt");
        }
        // Ham ghi ra file TinhTBC.txt gia tri trung binh cong cua mang.
        static void TinhTBC (int[] arr)
        {
            try
            {
                using (StreamWriter sW = new StreamWriter("TinhTBC.txt"))
                {
                    double count = 0.0, sum = 0.0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sum += arr[i];
                    }
                    count = sum / arr.Length;
                    sW.WriteLine("Trung binh cong: " + count);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        // Ham ghi ra file TongSNT.txt gia tri tong cac SNT cua mang
        static void GhiTongSNT (int[] arr, string path)
        {
            int tongSNT = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraSNT(arr[i]) == true)
                {
                    tongSNT += arr[i];
                }
            }
            try
            {
                using (StreamWriter sW = new StreamWriter(path))
                {
                    sW.Write($"Tong so nguyen to la: {tongSNT}");
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Mo file that bai!!!");
                throw;
            }
        }
        static bool KiemTraSNT (int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if( num %i==0)
                {
                    return false;
                }
            }
            return true;
        }
        // Ham xuat mang so nguyen
        static void XuatMang (int[] arr)
        {
            Console.WriteLine("Xuat mang: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($" {arr[i]} ");
            }
        }
        // Ham doc mang so nguyen to file
        static int[] DocMang (string path)
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

        // Ham Ghi
    }
}
