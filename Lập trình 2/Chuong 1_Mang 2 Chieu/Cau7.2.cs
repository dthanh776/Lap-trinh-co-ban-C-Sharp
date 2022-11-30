using System;
/*
Bui Duy Thanh_20211TT0660
Chuong1_Mang2Chieu
Cau 7
 */
namespace Mang2Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Khai bao so dong
            Console.WriteLine("Nhap so dong: ");
            int n = int.Parse(Console.ReadLine());
            //Khai bao so cot
            Console.WriteLine("Nhap so cot: ");
            int m = int.Parse(Console.ReadLine());

            //Khai bao mang hinh chu nhat
            int[,] hcn = new int[n, m];
            // Khai bao mang hinh vuong
            int[,] arrHinhVuong;
            // Chuyen mang tu hinh chu nhat sang vuong
            if (n < m)
            {
                arrHinhVuong = new int[n, n];
            }
            else
            {
                arrHinhVuong = new int[m, m];
            }
            //Ham nhap mang 
            NhapMang(arrHinhVuong);
            //Ham xuat mang
            XuatMang(arrHinhVuong);
            //Tich cac phan tu tren moi cot cua ma tran
            TichMoiCot(arrHinhVuong);
            //Ham tich cac phan tu tren duong cheo chinh va phu
            TichCheoChinhPhu(arrHinhVuong);
            // Ham tong cac so nguyen to trong ma tran
            Console.WriteLine("Tong cac so nguyen to trong ma tran la: " + TongSNT(arrHinhVuong));
            // Ham tinh trung binh cac phan tru la so chan trong ma tran
            Console.WriteLine("Trung binh cac so chan trong ma tran la: " + TBCSoChan(arrHinhVuong));
            // Phan tu le lon nhat
            Console.WriteLine("Phan tu le lon nhat la: ");
            PhanTuLeLonNhat(arrHinhVuong);
            //So lan xuat hien cua phan tu x
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"So lan {x} xuat hien trong mang la: {SoLanXuatHien(arrHinhVuong,x)} ");

            Console.ReadKey();
        }
        // Ham nhap mang
        static void NhapMang(int[,] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    //Console.Write($"Nhap phan tu [{i},{j}]: " );
                    //arr[i,j] = int.Parse(Console.ReadLine());
                    arr[i, j] = rd.Next(1, 5);
                }
            }
        }
        // Ham xuat mang
        static void XuatMang(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}" + "\t");
                }
                Console.WriteLine();
            }
        }
        // Tich cac phan tu tren moi cot cua ma tran
        static void TichMoiCot(int[,] arr)
        {

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int tich = 1;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    tich = tich * arr[i, j];
                }
                Console.WriteLine($"Cot {j + 1} co tich la {tich} ");
            }
        }
        //Ham tich cac phan tu tren duong cheo chinh va phu
        static void TichCheoChinhPhu(int[,] arr)
        {
            int tichChinh = 1, tichPhu = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j == arr.GetLength(1) - 1)
                    {
                        tichPhu *= arr[i, j];
                    }
                    if (i == j)
                    {
                        tichChinh *= arr[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Tich phan tu nam tren duong cheo chinh = {tichChinh}");
            Console.WriteLine($"Tich phan tu nam tren duong cheo phu = {tichPhu}");
        }
        //Ham kiem tra so nguyen to
        static bool KiemTraSNT(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n / 2 + 1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        // Ham tich tong cac phan tu la so nguyen to trong ma tran
        static int TongSNT(int[,] arr)
        {
            int tong = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (KiemTraSNT(arr[i, j]) == true)
                    {
                        tong += arr[i, j];
                    }
                }
            }
            return tong;
        }
        // Ham tinh trung binh cac so chan trong ma tran
        static double TBCSoChan(int[,] arr)
        {
            int tong = 0;
            int dem = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        tong += arr[i, j];
                        dem++;
                    }
                }
            }
            return tong / dem;
        }
        // Ham tim so le lon nhat trong ma tran
        static void PhanTuLeLonNhat(int[,] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 != 0 && arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == max)
                    {
                        Console.WriteLine($"Vi tri [{i}][{j}] la phan tu le lon nhat trong mang");
                    }
                }
            }
        }
        // Dem so lan xuat hien cua x trong ma tran
        static int SoLanXuatHien(int[,] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (x == arr[i, j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
