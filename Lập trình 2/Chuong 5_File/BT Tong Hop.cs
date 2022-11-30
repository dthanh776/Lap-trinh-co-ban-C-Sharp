using System;
using System.IO;


namespace ConsoleApp4
{
    struct SinhVien
    {
        public string maSV, tenSV;
        public DateTime ngaySinh;
        public double diemTB;
        public double[,] bangDTB;
    }
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = NhapDSSV();
            Xuat(sv);
            InBangDiem(sv);

            // Nhap diem
            for (int i = 0; i < sv.bangDTB.GetLength(0); i++)
            {
                for (int j = 0; j < sv.bangDTB.GetLength(1); j++)
                {
                    NhapDiem(sv, i, j);
                }

                InBangDiem(sv);
                TinhDTBNam(sv);
                GhiFile(sv);

                SinhVien[] arr = DocMangSV("DiemSinhVien.txt");
                XuatDS(arr);
                Console.WriteLine("Sinh vien co DTB tot nghiep lon nhat: ");
                Xuat(TimSVDiemMax(arr));
            }

            // Cau a: Nhap danh sach sinh vien
            static SinhVien NhapDSSV()
            {
                SinhVien sv = new SinhVien();
                do
                {
                    Console.Write("Nhap ma sinh vien: ");
                    sv.maSV = Console.ReadLine();
                } while (KiemTraMaSV(sv.maSV) == false);

                do
                {
                    Console.Write("Nhap ten sinh vien: ");
                    sv.tenSV = Console.ReadLine();
                } while (KiemTraMaSV(sv.tenSV) == false);

                do
                {
                    Console.Write("Nhap ngay sinh: ");
                    DateTime.TryParse(Console.ReadLine(), out sv.ngaySinh);
                } while (sv.ngaySinh.Year <= 1900);

                sv.bangDTB = new double[3, 2];
                sv.diemTB = TinhDTBC(sv);
                return sv;
            }
            static bool KiemTraMaSV(string s)
            {
                if (s.Length != 11)
                {
                    return false;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] < '0' && s[i] > '9' || s[i] < 'a' || s[i] > 'z' || s[i] < 'A' || s[i] > 'Z' || s[i] == ' ')
                    {
                        return false;
                    }
                }
                return true;

            }
            static bool KiemTraTen(string s)
            {
                if (s.Length > 30)
                {
                    return false;
                }
                if (s[0] == ' ' || s[s.Length - 1] == ' ' || s[0] < 'A' || s[0] > 'Z')
                {
                    return false;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        if (s[i + 1] < 'A' || s[i + 1] > 'Z')
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            static void Xuat(SinhVien sv)
            {
                Console.Write($"{"- Ma sinh vien: ",-15}{sv.maSV,-15}");
                Console.Write($"{"- Ten sinh vien: ",-15}{sv.tenSV,-15}");
                Console.Write($"{"- Ngay sinh ",-15}{sv.ngaySinh.ToString("dd/mm/yyyy"),-15}");
            }

            // Cau c
            static void InBangDiem(SinhVien sv)
            {
                Console.WriteLine("-----Xuat bang diem-----");
                Console.WriteLine($"Ma Sinh Vien: {sv.maSV}");
                Console.WriteLine("Bang diem: ");
                for (int i = 0; i < sv.bangDTB.GetLength(0); i++)
                {
                    Console.WriteLine($"Nam{i + 1}");
                    for (int j = 0; j < sv.bangDTB.GetLength(1); j++)
                    {
                        Console.Write($"{sv.bangDTB[i, j],5}");
                    }
                    Console.WriteLine("\n");
                }
            }

            // Cau d
            static void NhapDiem(SinhVien sv, int nam, int hocKy)
            {
                do
                {
                    Console.Write(" Nhap diem: ");
                    double.TryParse(Console.ReadLine(), out sv.bangDTB[nam - 1, hocKy - 1]);
                } while (sv.bangDTB[nam - 1, hocKy - 1] < 0 || sv.bangDTB[nam - 1, hocKy - 1] > 10);
            }

            // Cau e
            static void TinhDTBNam(SinhVien sv)
            {
                for (int i = 0; i < sv.bangDTB.GetLength(0); i++)
                {
                    double dTB = 0.0d;
                    for (int j = 0; j < sv.bangDTB.GetLength(1); j++)
                    {
                        dTB += sv.bangDTB[i, j];
                    }
                    Console.WriteLine($"Diem Trung Binh nam{i} la: {dTB / 2}");
                }
            }

            // Cau f
            static double TinhDTBC (SinhVien sv)
            {
                return (TinhDTB_Nam(sv, 1) + TinhDTB_Nam(sv, 2) + TinhDTB_Nam(sv, 3)) / 3;
            }
            static double TinhDTB_Nam (SinhVien sv, int nam)
            {
                return (sv.bangDTB[nam - 1, 0] + sv.bangDTB[nam - 1, 1]) / 2;
            }

            // Cau g
            static string XepLoai (SinhVien sv)
            {
                
                if (sv.diemTB < 5)
                {
                    return "Yeu";
                }
                else if (sv.diemTB < 7)
                {
                    return "Trung Binh";
                }
                else if (sv.diemTB < 8)
                {
                    return "Kha";
                }
                else
                {
                    return "Gioi";
                }
            }
            // Cau h
            static void  GhiFile (SinhVien sv)
            {
                try
                {
                    using (StreamWriter sW = new StreamWriter("bangdiem.txt", true))
                    {
                        sW.WriteLine("**************");
                        sW.WriteLine("BANG DIEM TONG KET");
                        sW.WriteLine("**************");
                        sW.WriteLine($"{"MaSV: " , -20}{sv.maSV, - 20}");
                        sW.WriteLine($"{"Ho Ten: ",-20}{sv.tenSV,-20}");
                        sW.WriteLine($"{"Ngay Sinh: ",-20}{sv.ngaySinh.ToString(),-20}");
                        sW.WriteLine($"{"Diem Trung Binh: ",-20}{TinhDTBC(sv), -20}");
                        sW.WriteLine($"{"Xep Loai ",-20}{XepLoai(sv),-20}");
                        sW.WriteLine("Bang diem chi tiet: ");
                        for (int i = 0; i < sv.bangDTB.GetLength(0); i++)
                        {
                            for (int j = 0; j < sv.bangDTB.GetLength(1); j++)
                            {
                                sW.Write($"{sv.bangDTB[i, j],-10}");
                            }
                            sW.Write("\n");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Duong dan sai");
                    throw;
                }
            }

            // Cau i
            static SinhVien[] DocMangSV(string nameFile)
            {
                int n = 0;
                SinhVien[] arr;
                try
                {
                    using(StreamReader sR = new StreamReader(nameFile))
                    {
                        int.TryParse(sR.ReadLine(), out n);
                        arr = new SinhVien[n];
                        for (int i = 0; i < n; i++)
                        {
                            string[] s = sR.ReadLine().Split('#');
                            arr[i].maSV = s[0];
                            arr[i].tenSV = s[1];
                            arr[i].ngaySinh = DateTime.ParseExact(s[2], "dd/MM/yyyy", null);

                            string[] t = s[3].Split(' ');
                            int m = 0;
                            arr[i].bangDTB = new double[3, 2];

                            for (int j = 0; j < 3; j++)
                            {
                                for (int k = 0; k < 2; k++)
                                {
                                    double.TryParse(t[m++], out arr[i].bangDTB[j, k]);
                                }
                            }
                            arr[i].diemTB = TinhDTBC(arr[i]);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Mo file that bai!!!");
                    throw;
                }
                return arr;
            }
            static void XuatDS(SinhVien[]arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("**************");
                    Console.WriteLine("BANG DIEM TONG KET");
                    Console.WriteLine("**************");
                    Console.WriteLine($"{"MaSV: ",-20}{arr[i].maSV,-20}");
                    Console.WriteLine($"{"Ho Ten: ",-20}{arr[i].tenSV,-20}");
                    Console.WriteLine($"{"Ngay Sinh: ",-20}{arr[i].ngaySinh.ToString(),-20}");
                    Console.WriteLine($"{"Diem Trung Binh: ",-20}{TinhDTBC(arr[i]),-20}");
                    Console.WriteLine($"{"Xep Loai ",-20}{XepLoai(arr[i]),-20}");
                    Console.WriteLine("Bang diem chi tiet: ");
                    for (int k = 0; k < arr[i].bangDTB.GetLength(0); k++)
                    {
                        for (int j = 0; j < arr[i].bangDTB.GetLength(1); j++)
                        {
                            Console.Write($"{arr[k].bangDTB[i, j],-10}");
                        }
                        Console.Write("\n");
                    }
                }

            }

            // Cau j
            static SinhVien TimSVDiemMax(SinhVien[]arr)
            {
                SinhVien max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (TinhDTBC(max) < TinhDTBC(arr[i]))
                    {
                        max = arr[i];
                    }
                }
                return max;
            }
        }
    }
}
        

