//1. Viết chương trình file MangNguyen.txt bao gồm các thông tin
//Dòng 1: số phần từ mảng
//Dòng 2 trở đi: giá trị các phần từ mảng

//4. Viết chương trình đọc nội dung từ file HangHoa.txt
//  Mat Hang | Ten Hang | So luong ban | Don gia | Thanh Tien
using System;
using System.IO;

namespace File1
{
    struct HangHoa
    {
        public string MaHang;
        public string TenHang;
        public int SoLuong;
        public int DonGia;
        public int thanhtien;
    }
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"D:\test.txt";
            //StreamWriter myWriter = new StreamWriter(path);

            //int a = int.Parse(Console.ReadLine());
            //myWriter.WriteLine(a);
            //for (int i = 0; i < a; i++)
            //{
            //    string matHang = Console.ReadLine();
            //    myWriter.Write(matHang + "#");

            //    string tenHang = Console.ReadLine();
            //    myWriter.Write(tenHang + "#");

            //    int soLuongBan = int.Parse(Console.ReadLine());
            //    myWriter.Write(soLuongBan + "#");

            //    int donGia = int.Parse(Console.ReadLine());
            //    myWriter.Write(donGia + "#");

            //    int thanhTien = int.Parse(Console.ReadLine());
            //    myWriter.WriteLine(thanhTien + "#");
            //}

            //myWriter.Close();

            StreamReader myReader = new StreamReader(path);
            int b = int.Parse(myReader.ReadLine());

            HangHoa [] dsHangHoa = new HangHoa[b];
            string[] c;
            for (int i = 0; i < b; i++)
            {
                c = myReader.ReadLine().Split("#");
                dsHangHoa[i].MaHang = c[0];
                dsHangHoa[i].TenHang = c[1];
                dsHangHoa[i].SoLuong = int.Parse(c[2]);
                dsHangHoa[i].DonGia =int.Parse( c[3]);
                dsHangHoa[i].thanhtien = int.Parse( c[4]);
            }
            for (int i = 0; i < b; i++)
            {
                Console.Write(dsHangHoa[i].MaHang + "\t");
                Console.Write(dsHangHoa[i].TenHang+ "\t");
                Console.Write(dsHangHoa[i].SoLuong +"\t");
            }
        }
    }
}
