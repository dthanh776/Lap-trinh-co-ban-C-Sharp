/*
 * Bùi Duy Thanh
 * 20211TT0660
 * Bai 3
 */
using System;

namespace Bai3
{
    class Bai3
    {
        static void Main(string[] args)
        {
            // Khai bao bien tiep tuc va n
            char tiepTuc;
            int n = 0;
            do
            { 
                // Xoa man hinh
                Console.Clear();
                // Nhap va kiem tra dieu kien cac so nguyen trong mang (1<=n<=100)
                do
                {
                    Console.Write("Nhap so phan tu ");
                    n = int.Parse(Console.ReadLine());
                } while (n < 1 || n >100);

                // Khai báo mảng
                int[] arrA = new int[n];

                // Nhap mang
                NhapMang(arrA, n);

                // Xuat mang
                Console.WriteLine("Cac phan tu vua nhap la: ");
                XuatMang(arrA, n);

                //Chon cau de thuc hien
                char chon = Menu();
                switch (chon)
                {
                    //Tong cac so nguyen to co trong mang
                    case 'A':
                        TongSoSNT(arrA, n);
                        break;

                    // Tim phan tu X xuat hien dau tien trong mang
                    case 'B':
                        Console.WriteLine($"Tim thay gia tri can tim o vi tri {TimX(arrA)}");
                        break;

                    // Chen X vao giua mang
                    case 'C':
                        ChenX(ref arrA, n);
                        break;

                    // Xoa vi tri bat ki trong mang
                    case 'D':
                        Console.Write("Nhap vi tri can xoa: ");
                        int viTri = int.Parse(Console.ReadLine());
                        XoaViTri(arrA, viTri, ref n);
                        break;

                    //Sap xep mang theo thu tu tang dan"
                    case 'E':
                        SapXepTang(arrA, n);
                        break;

                    //Tong cac so chan co trong mang
                    case 'F':
                        TongSoChan(arrA, n);
                        break;

                    default:
                        Console.WriteLine("Ban nhap khong dung");
                        break;
                }
                Console.WriteLine("\nBan co muon tiep tuc ko (Y/N)?");
                tiepTuc = char.Parse(Console.ReadLine());
            } while (tiepTuc == 'Y' || tiepTuc == 'y'); // Nguoi dung nhap y hoac Y de tiep tuc
        }
        // Ham menu
        static char Menu()
        {
            // Khai bao bien chon
            char chon;
            Console.WriteLine("\n--- Moi ban chon ---");
            Console.WriteLine("A: Tong cac so nguyen to co trong mang");
            Console.WriteLine("B: Tim phan tu X xuat hien dau tien trong mang");
            Console.WriteLine("C: Chen them gia tri X vao giua mang");
            Console.WriteLine("D: Xoa vi tri bat ki trong mang");
            Console.WriteLine("E: Sap xep mang theo thu tu tang dan");
            Console.WriteLine("F: Tong cac so chan co trong mang");

            chon = char.Parse(Console.ReadLine());
            return chon;
        }
        // Ham nhap mang
        static void NhapMang(int[] arrA, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i}: ");
                arrA[i] = int.Parse(Console.ReadLine());
            }
        }
        // Ham xuat mang
        static void XuatMang(int[] arrA, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arrA[i],-10}");
            }
        }

        // Ham kiem tra so nguyen to
        static bool KiemTraSNT(int n)
        {
            if (n < 2)
            {
                return false; //Khong phai SNT tra ve false
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false; //Khong phai SNT tra ve false
                }
            }
            return true; //La SNT tra ve false
        }       
        // Ham tinh tong cac so nguyen to co trong mang
        static void TongSoSNT(int[] arrA, int n)
        {
            //Khai bao bien tong
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (KiemTraSNT(arrA[i]) == true) // kiem tra so nguyen to
                {
                    tong += arrA[i];
                }
                // tinh tong
            }
            Console.Write($"\nTong cac so nguyen to co trong mang la: {tong}");
        }

        // Ham tim phan tu X xuat hien dau tien trong mang
        static int TimX (int[] arrA)
        {
            Console.WriteLine("Nhap X can tim: ");
            int so = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] == so)
                {
                    return i;
                }
            }
            return -1;
        }

        // Ham chen X vao giua mang
        static void ChenX (ref int[] arrA, int n)
        {
            int[] arrB = new int[arrA.Length + 1];
            for (int i = 0; i < arrA.Length; i++)
            {
                arrB[i] = arrA[i];
            }
            arrA = arrB; 

            //Nhap so can chen vao giua mang
            Console.WriteLine("\nNhap so can chen");
            int soChen = int.Parse(Console.ReadLine());

            for (int i = arrA.Length - 1 ;i >= arrA.Length / 2; i--)
            {
                arrA[i] = arrA[i - 1];

                if (i == arrA.Length / 2)
                {
                    arrA[i] = soChen; 
                }
            }
            // tang do dai mang them 1
            n++;

            //Xuất mảng
            XuatMang(arrA,n);
        }

        // Ham tinh tong cac so chan trong mang
        static void TongSoChan(int[] arrA, int n)
        {
            // Khai bao bien tong
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (arrA[i] % 2 == 0) // Kiem tra so chan
                {
                    // tinh tong
                    tong += arrA[i];
                }
            }
            Console.Write($"\nTong cac so chan trong mang la: {tong} ");
        }

        // Xoa phan tu tri vi tri bat ki
        static void XoaViTri(int[] arrA, int viTri, ref int n)
        {
            for (int i = viTri + 1; i < n; i++)
            {
                arrA[i - 1] = arrA[i];
            }
            // giam do dai mang di 1
            n--;
            // Xuat mang sau khi xoa
            Console.WriteLine("Mang sau khi xoa");
            XuatMang(arrA, n);
        }

            // Ham sap xep tang dan
            static void SapXepTang(int[] arrA, int n)
        {
            // Khai bao bien temp
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arrA[i] > arrA[j])
                    {
                        temp = arrA[i];     //gán temp = arr[i]
                        arrA[i] = arrA[j];  //gán arr[i] = arr[j]
                        arrA[j] = temp;     //gán arr[j] = temp
                    }
                }
            }
            // Xuat mang sau khi sap xep
            Console.WriteLine("Mang sau khi sap xep");
            XuatMang(arrA, n);
        }
    }
}
