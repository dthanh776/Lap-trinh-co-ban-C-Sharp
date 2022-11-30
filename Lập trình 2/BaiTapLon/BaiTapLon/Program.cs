/*
 Bùi Duy Thanh
 Bài tập lớn Đề 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    // tao struct sinh vien
    struct SinhVien
    {
        public string maSinhVien;
        public string hoTen;
        public DateTime ngaySinh;
        public double diemTrungBinh;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Khai báo biến số lượng sinh viên
            int soLuongSV = 0;
            // Nhập số lượng sinh viên
            Console.Write("Nhap so luong sinh vien: ");
            int.TryParse(Console.ReadLine(), out soLuongSV);

            // Tạo mảng sinh viên
            SinhVien[] arrSV;
            // Hàm nhập mảng sinh viên
            arrSV = NhapMangSinhVien(soLuongSV);
            //Hàm xuất mảng sinh viên
            Console.WriteLine();
            XuatMangSinhVien(arrSV);
            //Hàm ghi file có thông tin số lớn nhất
            GhiFileSoLonNhat(arrSV);
            //Hàm nhập mảng struct
            NhapMangStruct();
            // Dừng màn hình
            Console.ReadKey();
        }
        /// <summary>
        /// Hàm nhập thông tin sinh viên
        /// </summary>
        /// <param name="SV"></param>
        static void NhapThongTinSinhVien(ref SinhVien SV)
        {
            // Nhap mã số, nếu nhập sai điều kiện sẽ nhập lại
            do
            {
                Console.Write("Nhap ma so: ");
                SV.maSinhVien = Console.ReadLine();
            } while (KiemTraMaSinhVien(SV.maSinhVien) == false);
            // Nhập họ tên , nếu nhập sai điều kiện sẽ nhập lại
            do
            {
                Console.Write("Nhap ho ten: ");
                SV.hoTen = Console.ReadLine();
            } while (KiemTraHoTen(SV.hoTen) == false);

            // Nhập ngày sinh
            Console.Write("Nhap ngay sinh: ");
            SV.ngaySinh = DateTime.Parse(Console.ReadLine());
            // Nhập điểm trung bính, nếu nhập sai điều kiện sẽ nhập lại
            do
            {
                Console.Write("Nhap diem trung binh: ");
                SV.diemTrungBinh = double.Parse(Console.ReadLine());
            } while (SV.diemTrungBinh < 0 || SV.diemTrungBinh > 10);

        }
        /// <summary>
        /// Hàm xuất thông tin sinh viên
        /// </summary>
        /// <param name="SV"></param>
        static void XuatThongTinSinhVien(ref SinhVien SV)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // In danh sách sinh viên theo dạng bảng          
            Console.WriteLine($"{SV.maSinhVien,-15} {SV.hoTen,-15} {SV.ngaySinh.ToString("dd/MM/yyyy"),-15} {SV.diemTrungBinh,-15}");
        }
        /// <summary>
        /// Hàm nhập mảng sinh viên
        /// </summary>
        /// <param name="soLuongSV"></param>
        /// <returns></returns>
        static SinhVien[] NhapMangSinhVien(int soLuongSV)
        {
            // Khai báo mảng sinh viên
            SinhVien[] arrSV = new SinhVien[soLuongSV];
            for (int i = 0; i < soLuongSV; i++)
            {
                // Nhập thông tin các sinh viên
                Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}");
                NhapThongTinSinhVien(ref arrSV[i]);
            }
            return arrSV;
        }
        /// <summary>
        /// Hàm xuất mảng sinh viên
        /// </summary>
        /// <param name="arrSV"></param>
        static void XuatMangSinhVien(SinhVien[] arrSV)
        {
            // In danh sách sinh viên theo dạng bảng      

            Console.WriteLine($"{"Ma sinh vien",-15} {"Ho ten",-15} {"Ngay sinh",-15} {"Diem trung binh",-15}");
            for (int i = 0; i < arrSV.Length; i++)
            {
                XuatThongTinSinhVien(ref arrSV[i]);
            }
        }
        /// <summary>
        /// Hàm kiểm tra điều kiện nhập mã sinh viên
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static bool KiemTraMaSinhVien(string s)
        {

            for (int i = 0; i < s.Length - 1; i++)
            {
                // Kiêm tra nhập có khoảng trắng đầu-cuối, khoảng trắng thừa giữa chuỗi, độ dài chuỗi trên 30 
                if (s[i] == ' ' || s[i + 1] == ' ' || s.Length >= 30 || s[0] == ' ' || s[s.Length - 1] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Hàm kiểm tra điều kiện nhập họ tên sinh viên
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static bool KiemTraHoTen(string s)
        {
            //Kiêm tra nhập có khoảng trắng đầu - cuối, khoảng trắng thừa giữa chuỗi, độ dài chuỗi trên 30
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == ' ' && s[i + 1] == ' ' || s.Length >= 30 || s[0] == ' ' || s[s.Length - 1] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Tìm số lớn nhất
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        static SinhVien TimSoLonNhat(SinhVien[] sv)
        {
            //khai báo sinhVienMax = giá trị đầu tiên của mảng
            SinhVien sinhVienMax = sv[0];

            for (int i = 0; i < sv.Length; i++)
            {
                if (sv[i].diemTrungBinh > sinhVienMax.diemTrungBinh)
                {
                    // gán sinhVienMax sv[i]
                    sinhVienMax = sv[i];
                }
            }
            // trả về sinh viên lớn nhất
            return sinhVienMax;
        }
        /// <summary>
        /// Hàm ghi vào file số lớn nhất
        /// </summary>
        static void GhiFileSoLonNhat(SinhVien[] SV)
        {
            // Khai báo biến sinhVien
            SinhVien sinhVien = TimSoLonNhat(SV);
            // Tạo đường dẫn lưu file
            String path = @"D:Cau2c.txt";
            try
            {
                StreamWriter myWriter = new StreamWriter(path);
                using (myWriter)
                {
                    myWriter.WriteLine($"{"Ma sinh vien",-15} {"Ho ten",-15} {"Ngay sinh",-15} {"Diem trung binh",-15}");
                    myWriter.WriteLine($"{sinhVien.maSinhVien,-15} {sinhVien.hoTen,-15} {sinhVien.ngaySinh.ToString("dd/MM/yyyy"),-15} {sinhVien.diemTrungBinh,-15}");

                }
                Console.WriteLine("Ghi file thanh cong");
            }
            catch (IOException)
            {
                Console.WriteLine("Khong the ghi file");
            }
        }
        /// <summary>
        /// Nhập mảng struct
        /// </summary>
        static void NhapMangStruct()
        {
            Console.Write("Nhap do dai mang: ");
            int n = int.Parse(Console.ReadLine());
            SinhVien[,] sv = new SinhVien[n, n];

            for (int i = 0; i < sv.GetLength(0); i++)
            {
                for (int j = 0; j < sv.GetLength(1); j++)
                {
                    // Nhap mã số, nếu nhập sai điều kiện sẽ nhập lại
                    do
                    {
                        Console.Write("Nhap ma so: ");
                        sv[i, j].maSinhVien = Console.ReadLine();
                    } while (KiemTraMaSinhVien(sv[i, j].maSinhVien) == false);
                    // Nhập họ tên , nếu nhập sai điều kiện sẽ nhập lại
                    do
                    {
                        Console.Write("Nhap ho ten: ");
                        sv[i, j].hoTen = Console.ReadLine();
                    } while (KiemTraHoTen(sv[i, j].hoTen) == false);

                    // Nhập ngày sinh
                    Console.Write("Nhap ngay sinh: ");
                    sv[i, j].ngaySinh = DateTime.Parse(Console.ReadLine());
                    // Nhập điểm trung bình, nếu nhập sai điều kiện sẽ nhập lại
                    do
                    {
                        Console.Write("Nhap diem trung binh: ");
                        sv[i, j].diemTrungBinh = double.Parse(Console.ReadLine());
                    } while (sv[i, j].diemTrungBinh < 0 || sv[i, j].diemTrungBinh > 10);
                }
            }
            // Gọi hàm xuát mảng struct
            XuatMangStruct(sv);
            // Gọi hàm tính tổng strct
            TinhTongStruct(sv);
        }
        /// <summary>
        /// Xuất mảng struct
        /// </summary>
        /// <param name="SV"></param>
        static void XuatMangStruct(SinhVien[,] SV)
        {
            for (int i = 0; i < SV.GetLength(0); i++)
            {
                for (int j = 0; j < SV.GetLength(1); j++)
                {
                    // In thông tin sinh viên
                    Console.WriteLine($"{SV[i,j].maSinhVien,-15} {SV[i, j].hoTen,-15} {SV[i, j].ngaySinh.ToString("dd/MM/yyyy"),-15} {SV[i, j].diemTrungBinh,-15}");
                }
            }
        }
        /// <summary>
        /// Hàm tính tổng mảng là các só trong struct
        /// </summary>
        /// <param name="SV"></param>
        /// <returns></returns>
        static double[] TinhTongStruct(SinhVien[,] SV)
        {
            // Khỏi tạo chiều dài mảng 1 chiều
            double[] tongArr = new double[SV.GetLength(0)];

            for (int i = 0; i < SV.GetLength(0); i++)
            {
                // Khai báo biến tổng - 0
                double tong = 0;
                // Tính tổng điêm trung bình
                for (int j = 0; j < SV.GetLength(1); j++)
                {
                    tong += SV[i, j].diemTrungBinh;
                }
                //In tổng điếm của từng hàng
                Console.WriteLine($"Tong diem cua hang thu {i + 1} la: " + tong);
            }
            //Trả về giá trị tổng của mỗi hàng
            return tongArr;
        }

    }
}
