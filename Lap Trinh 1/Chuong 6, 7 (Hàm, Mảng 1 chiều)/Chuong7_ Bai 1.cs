/*
 *Bùi Duy Thanh
 *20211TT0660
 *Kiem Tra Mang
 */
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo biến tiepTuc và n
            char tiepTuc;
            int n = 0;
            do
            {
                Console.Clear();
                // Nhập và kiểm tra số phần tử
                do
                {
                    Console.Write("Nhập số phần tử: ");
                    n = int.Parse(Console.ReadLine());
                } while (n < 0);

                // Khai báo mảng
                int[] arrA = new int[n];
                // Nhập mảng
                NhapMang(arrA);

                // Xuất mảng
                Console.WriteLine("Các phần tử vừa nhập là: ");
                XuatMang(arrA);

                // Chọn câu để thực hiện
                char chon = Menu();
                switch (chon)
                {
                    case 'A':
                        SoChan(arrA);
                        break;
                    case 'B':
                        SoNguyenTo(arrA);
                        break;
                    case 'C':
                        TrungBinhCong(arrA);
                        break;
                    case 'D':
                        DemSoHoanThien(arrA);
                        break;
                    case 'E':
                        ViTriX(arrA);
                        break;
                    case 'F':
                        SNTFirst(arrA);
                        break;
                    case 'G':
                        int kqMax = TimMax(arrA);
                        Console.WriteLine($"Phần tử lớn nhất trong mảng là: {kqMax}");
                        break;
                    case 'H':
                        int kqMin = TimMin(arrA);
                        Console.WriteLine($"Phần tử nhỏ nhất trong mảng là: {kqMin}");
                        break;
                    case 'I':
                        Console.Write("Mảng sắp xếp theo thứ tự tăng dần là: ");
                        SapXepTang(arrA);
                        break;
                    case 'J':
                        Final(arrA);
                        break;
                    case 'K':
                        KiemTraTang(arrA);
                        break;
                    default:
                        Console.WriteLine("Bạn nhập không đúng");
                        break;
                }
                Console.WriteLine("\nBạn có muốn tiếp tục không? (Y or N)");
                tiepTuc = char.Parse(Console.ReadLine());
            } while (tiepTuc == 'Y' || tiepTuc == 'y');
        }
        // Ham menu
        static char Menu()
        {
            char chon;
            Console.WriteLine("\n--- Mời bạn chọn??? ---");
            Console.WriteLine("A: Xuất các số chẵn trong mảng");
            Console.WriteLine("B: Xuất các số nguyên tố trong mảng");
            Console.WriteLine("C: Tính trung bình cộng các số trong mảng");
            Console.WriteLine("D: Đếm số hoàn thiện trong mảng");
            Console.WriteLine("E: Tìm vị trí cuối cùng của phần tử X trong mảng");
            Console.WriteLine("F: Tìm vị trí số nguyên tố đầu tiên trong mảng");
            Console.WriteLine("G: Tìm phần tử lớn nhất trong mảng");
            Console.WriteLine("H: Tìm phẩn tử nhỏ nhất trong mảng");
            Console.WriteLine("I: Sắp xếp theo thứ tự tăng dần");
            Console.WriteLine("J: Phần tử cuối cùng trong mảng");
            Console.WriteLine("K: Kiểm tra mảng có thứ tự tăng hay không?");
            chon = char.Parse(Console.ReadLine());
            return chon;
        }
        // Ham nhap mang
        static void NhapMang(int[] arrA)
        {
            Random rd = new Random();
            for (int i = 0; i < arrA.Length; i++)
            {
                //Console.WriteLine($"Nhap phan tu thu {i}");
                //arrA[i] = int.Parse(Console.ReadLine());
                arrA[i] = rd.Next(1, 30);
            }
        }
        // Ham xuat mang
        static void XuatMang(int[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write($"{arrA[i],-10}");
            }
        }
        // Ham xuat so chan
        static void SoChan(int[] arrA)
        {
            Console.Write("\nCác số chẵn trong mảng là: ");
            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] % 2 == 0)
                {
                    Console.Write($"{arrA[i],-5} ");
                }
            }
        }
        // Ham kiem tra so nguyen to
        static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        // Ham xuat so nguyen to
        static void SoNguyenTo(int[] arrA)
        {
            Console.Write("\nCác số nguyên tố trong mảng là: ");
            for (int i = 0; i < arrA.Length; i++)
            {
                if (KiemTraSoNguyenTo(arrA[i]) == true)
                {
                    Console.Write($"{arrA[i],-5}");
                }
            }
        }
        // Tìm vị trí số nguyên tố đầu tiên trong mảng
        static void SNTFirst(int[] arrA)
        {
            int viTri = -1;
            for (int i = 0; i < arrA.Length; i++)
            {
                if (KiemTraSoNguyenTo(arrA[i]) == true)
                {
                    viTri = i;
                    break;
                }
            }
            if (viTri == -1)
            {
                Console.WriteLine("Hàm không có số nguyên tố");
            }
            else
            {
                Console.WriteLine($"Số nguyên tố đầu tiên xuất hiện tại vị trí thứ: {viTri}");
            }
        }
        // Tinh trung binh cong
        static void TrungBinhCong(int[] arrA)
        {
            //Khai báo biến tong và tbc
            double tong = 0;
            double tbc = 0;

            for (int i = 0; i < arrA.Length; i++)
            {
                tong += arrA[i];
                tbc = tong / arrA.Length;
            }
            Console.Write($"\nTrung bình cộng của mảng là: {Math.Round(tbc, 2)}");
        }
        // Ham kiem tra so hoan thien
        static bool KiemTraSoHoanThien(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
                return true;
            else
                return false;
        }
        // Ham dem so hoan thien
        static void DemSoHoanThien(int[] arrA)
        {
            int dem = 0;
            for (int i = 0; i < arrA.Length; i++)
            {
                if (KiemTraSoHoanThien(arrA[i]) == true)
                {
                    dem++;
                    Console.Write($"{dem}");
                }
            }
            Console.WriteLine($"\nCó {dem} số hoàn thiện trong mảng");
        }

        // Tìm vị trí cuối cùng của phần tử x trong mảng
        static int TimViTriX(int[] arrA, int x)
        {
            int viTri = -1;
            for (int i = 0; i < arrA.Length; i++)
            {
                // Kiem tra gia tri thu i co bang x
                if (arrA[i] == x)
                {
                    viTri = i;
                }
            }
            return viTri;

        }
        // Tìm vị trí x cần tìm 
        static void ViTriX(int[] arrA)
        {
            Console.WriteLine("Nhập giá trị X cần tìm: ");
            int x = int.Parse(Console.ReadLine());
            int kqTim = TimViTriX(arrA, x);
            if (kqTim == -1)
            {
                Console.Write($"Không có {x} trong mảng");
            }
            else
            {
                Console.Write($"Tìm thấy giá trị cuối cùng {x} tại {kqTim}");
            }
        }

        // Tìm phần tử lớn nhất trong mảng
        static int TimMax(int[] arrA)
        {
            // Khai bao bien 
            int max = arrA[0];

            // duyet mang
            for (int i = 0; i < arrA.Length; i++)
            {
                if (max < arrA[i]) // so sanh gia tri lon nhat voi mang
                {
                    max = arrA[i]; // gan lai gia tri lon nhat
                }
            }
            return max;
        }
        // Tìm phẩn tử nhỏ nhất trong mảng
        static int TimMin(int[] arrA)
        {
            int min = arrA[0];

            for (int i = 0; i < arrA.Length; i++)
            {
                if (min > arrA[i]) // so sanh gia tri nho nhat voi mang
                {
                    min = arrA[i]; // gan lai gia tri nho nhat
                }
            }
            return min;
        }
        // Săp xếp phần tử tăng dần
        static void SapXepTang(int[] arrA)
        {
            int gan;
            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = i + 1; j < arrA.Length; j++)
                {
                    if (arrA[i] > arrA[j])
                    {
                        gan = arrA[i];
                        arrA[i] = arrA[j];
                        arrA[j] = gan;
                    }
                }
            }
            XuatMang(arrA);
        }
        // Phần tử cuối cùng trong mảng
        static void Final(int[] arrA)   
        {
         Console.WriteLine($"Phần tử cuối cùng trong mảng là {arrA[arrA.Length-1]} ");           
        }
        // Kiểm tra mảng có thứ tự tăng hay không?
        static bool KTTang(int[] arrA)
        {

            for (int i = 0; i < arrA.Length - 1; i++)
            {
                if (arrA[i] > arrA[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void KiemTraTang(int[] arrA)
        {
            if (KTTang(arrA) == true)
                Console.WriteLine("Các phần tử tăng dần");
            else
                Console.WriteLine("Các phần tử không tăng dần");
        }
    }
}
