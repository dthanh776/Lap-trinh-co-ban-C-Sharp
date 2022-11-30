using System;

namespace Bai_6
{
    class Program
    {
        static void Main(string[] args)
        {

            // Nhap so nguyen
            int n = NhapSoNguyen();

            // Khai bao mang
            int[] arrA = new int[n];

            // Nhap mang
            NhapMang(arrA);

            //Xuat mang
            XuatMang(arrA);

            // Menu
            char tiepTuc;
            do
            {
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
                        Console.WriteLine($"Phan tu lon nhat trong mang la: {kqMax}");
                        break;
                    case 'H':
                        int kqMin = TimMin(arrA);
                        Console.WriteLine($"Phan tu nho nhat trong mang la {kqMin}");
                        break;
                    case 'I':
                        KiemTraTang(arrA);
                        break;
                    default:
                        Console.WriteLine("Chon sai, vui long chon lai: ");
                        break;
                }
                Console.WriteLine("\nBan co muon tiep tuc khong: ");
                tiepTuc = char.Parse(Console.ReadLine());
            } while (tiepTuc == 'Y' || tiepTuc == 'y');
            // Dung mang hinh
            Console.ReadKey();
        }
        // Ham nhap so phan tu mang
        static int NhapSoNguyen()
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so phan tu: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        static char Menu()
        {
            char chon;
            Console.WriteLine("\nA: Xuat cac so chan trong mang");
            Console.WriteLine("B: Xuat cac so nguyen to trong mang");
            Console.WriteLine("C: Tinh trung binh cong cac phan tu trong mang");
            Console.WriteLine("D: Dem so luong so hoan thien trong mang");
            Console.WriteLine("E: Tim vi tri cuoi cung cua X trong mang");
            Console.WriteLine("F: Tim vi tri so nguyen to dau tien trong mang");
            Console.WriteLine("G: Tim phan tu lon nhat trong mang");
            Console.WriteLine("H: Tim so nho nhat trong mang");
            Console.WriteLine("I: Kiem tra mang co tang hay khong");
            chon = char.Parse(Console.ReadLine());
            return chon;
        }
        // Ham nhap mang
        static void NhapMang(int[]arrA)
        {
            Random rd = new Random();
            for (int i = 0; i < arrA.Length; i++)
            {
                //Console.WriteLine($"Nhap phan tu thu {i + 1}");             
                //arrA[i] = int.Parse(Console.ReadLine());
                arrA[i] = rd.Next(1, 30);
            }
        }
        // Ham xuat mang
        static void XuatMang(int[] arrA)
        {
            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write($"{arrA[i], - 5}");
            }
        }
        // Xuat cac so chan trong mang
        static void SoChan (int[] arrA)
        {
            Console.WriteLine("Cac so chan trong mang la: ");
            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] % 2 == 0)
                {
                    Console.Write($"{arrA[i], -5}");
                }
            }
        }
        // Kiem tra so nguyen to
        static bool KTSNT (int n)
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
        // Xuat so nguyen to
        static void SoNguyenTo(int[] arrA)
        {
            Console.Write("Cac so nguyen to trong mang la: ");
            for (int i = 0; i < arrA.Length; i++)
            {
                if (KTSNT(i) == true)
                {
                    Console.Write($"{arrA[i] , -5}");
                }
            }
        }
        // So  nguyen to dau tien
        static void SNTFirst(int[] arrA)
        {
            int viTri = -1;
            for (int i = 0; i < arrA.Length; i++)
            {
                if (KTSNT(arrA[i]) == true)
                {
                    viTri = i;
                    break;
                }
            }
            if (viTri == -1)
            {
                Console.WriteLine("Ham khong co so nguyen to");
            }
            else
            {
                Console.WriteLine($"Xuat hien tai vi tri: {viTri}");
            }
        }

        // Tinh trung binh cong
        static void TrungBinhCong(int[] arrA)
        {
            double sum = 0;
            double tbc = 0;

            for (int i = 0; i < arrA.Length; i++)
            {
                sum += arrA[i];
                tbc = sum / arrA.Length;
            }
            Console.Write($"Trung binh cong cua mang la: {Math.Round(tbc,2)} ");
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
                }
            }
            Console.WriteLine($"Co {dem} so hoan thien trong mang");
        }
        // Ham tim vi tri
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
        // Tim vi tri X cuoi cung tron gmang
        static void ViTriX(int[] arrA)
        {
            Console.WriteLine("Nhap gia tri X can tim: ");
            int x = int.Parse(Console.ReadLine());
            int kqTim = TimViTriX(arrA, x);
            if (kqTim == -1)
            {
                Console.Write($"Khong co {x} trong mang");
            }
            else
            {
                Console.Write($"Tim thay {x} tại vi tri {kqTim}");
            }
        }
        // Tim phan tu lon nhat
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
        // Tim phan tu nho nhat
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
        // Kiem tra mang co thu tu tang hay khong
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
                Console.WriteLine("Cac phan tu tang dan");
            else
                Console.WriteLine("Cac phan tu KHONG tang dan");
        }

    }
}
