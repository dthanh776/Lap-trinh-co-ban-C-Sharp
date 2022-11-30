using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void NhapMang (int[,] arr)
        {
            Random rd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rd.Next(1, 100);
                }
            } 
        }
        static void XuatMang (int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j],5}");
                }
                Console.WriteLine("\n");

            }
        }
        static void XuatDuongCheoChinhTren(int[,] arr)
        {
            Console.WriteLine("Xuat nua tren duong cheo chinh TREN \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i <= j)
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                    {
                        Console.Write($"{"-",5}");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static void XuatDuongCheoChinhDuoi(int[,] arr)
        {
            Console.WriteLine("Xuat nua tren duong cheo chinh DUOI \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                    {
                        Console.Write($"{"-",5}");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static void XuatDuongCheoPhuTren(int[,] arr)
        {
            Console.WriteLine("Xuat nua tren duong cheo phu TREN \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j <= arr.GetLength(0) -1 )
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                    {
                        Console.Write($"{"-",5}");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static void XuatDuongCheoPhuDuoi(int[,] arr)
        {
            Console.WriteLine("Xuat nua tren duong cheo phu DUOI \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j >= arr.GetLength(0) - 1)
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                    {
                        Console.Write($"{"-",5}");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static void XuatDuongCHeo(int[,] arr)
        {
            Console.WriteLine("Xuat duong cheo \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j ||  i + j == arr.GetLength(0) - 1)
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                    {
                        Console.Write($"{"-",5}");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static void Xuat4Bien(int[,] arr)
        {
            Console.WriteLine("Xuat 4 bien \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0 || i == arr.GetLength(0) - 1 || j == 0 || j == arr.GetLength(1) - 1 )
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                    {
                        Console.Write($"{"-",5}");
                    }
                }
                Console.WriteLine("\n");
            }
        }
        static bool KiemTraSoNguyenTo (int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)

                    dem++;
            }
            if (dem == 2)
            {
                return true;
            }
                return false;

        
        }
        static void SoNguyentTo (int[,] arr)
        {
            Console.WriteLine("So nguyen to \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (KiemTraSoNguyenTo(arr[i, j]) == true)
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                        Console.Write($"{"-",5}");
                }
                Console.WriteLine("\n");
            }
        }
        static bool KiemTraSoHoanHao(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)

                    sum = sum +i;
            }
            if (sum == n)
            {
                return true;
            }
            return false;


        }
        static void SoHoanHao(int[,] arr)
        {
            Console.WriteLine("So hoan hao \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (KiemTraSoHoanHao(arr[i, j]) == true)
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                        Console.Write($"{"-",5}");
                }
                Console.WriteLine("\n");
            }
        }
        static bool KiemTraSoDoiXung(int n)
        {
            int m = 0;
            int a = n;
            while (a != 0)
            {
                m = m * 10 + a % 10;
                a = a / 10;
            }
            if (m == n)
            {
                return true;
            }
            return false;
        }
        static void SoDoiXung(int[,] arr)
        {
            Console.WriteLine("So doi xung \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (KiemTraSoDoiXung(arr[i, j]) == true)
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                        Console.Write($"{"-",5}");
                }
                Console.WriteLine("\n");
            }
        }
        static bool KiemTraHopSo (int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if ( n % i == 0)
                {
                    dem++;
                }
            }
            if (dem > 2)
            {
                return true;
            }
            return false;
        }
        static void HopSo (int [,] arr)
        {
            Console.WriteLine("Hop so nam tren 2 duong cheo chinh \n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == j || i + j == arr.GetLength(0) - 1) && KiemTraHopSo(arr[i, j]) == true)
                    {
                        Console.Write($"{arr[i, j],5}");
                    }
                    else
                    {
                        Console.Write($"{"-",5}");
                    }
                }
                Console.WriteLine("\n");
            }

        }
        static void Main(string[] args)
        {

            // Nhap do dai canh hinh vuong
            //Console.WriteLine("Nhap canh hinh vuong");
            //int d = int.Parse(Console.ReadLine());
            int[,] arr = new int[5, 5];
            // goi ham
            NhapMang(arr);
            XuatMang(arr);
            XuatDuongCheoChinhTren(arr);
            XuatDuongCheoChinhDuoi(arr);

            XuatDuongCheoPhuTren(arr);
            XuatDuongCheoPhuDuoi(arr);
            XuatDuongCHeo(arr);
            Xuat4Bien(arr);
            SoNguyentTo(arr);
            SoHoanHao(arr);
            SoDoiXung(arr);
            HopSo(arr);
            Console.ReadKey();
            
        }
    }
}
