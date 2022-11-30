using System;

namespace Chuong7__Bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap so luong phan tu trong mang
            Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());
            
            // Khai bao mang
            int[] arrA = new int[n];

            //Nhap xuat mang
            NhapMang(arrA);
            XuatMang(arrA, n);

            // Xoa phan tu
            Console.Write($"\nNhap SO can xoa: ");
            int x = int.Parse(Console.ReadLine());
            XoaPhanTu(arrA, x, ref n);

            // Them phan tu
            Console.Write($"\nNhap SO can them: ");
            int soThem = int.Parse(Console.ReadLine());
            Console.Write($"\nNhap VI TRI them: ");
            int viTriThem = int.Parse(Console.ReadLine());
            ThemPhanTu(arrA, ref n, viTriThem, soThem);


            Console.ReadKey();
        }
        // Ham nhap mang
        static void NhapMang(int[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                Random rd = new Random();
                //Console.Write($"Nhap phan tu thu {i + 1}: ");
                //arrA[i] = int.Parse(Console.ReadLine());
                arrA[i] = rd.Next(1, 10);
            }
        }
        // Ham xuat mang
        static void XuatMang(int[] arrA, int n)
        {

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}\t", arrA[i]);
            }
        }
        // Ham xoa phan tu
        static void XoaPhanTu(int[] arrA, int x, ref int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (x == arrA[i])
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        arrA[j] = arrA[j + 1];
                    }
                    n--;
                }
            }

        // Xuat mang sau khi xoa
            Console.WriteLine("Mang sau khi xoa");
            XuatMang(arrA, n);
        }

        // Ham chen phan tu vao mang
        static void ThemPhanTu(int[] arrA, ref int n, int viTriThem, int soThem)
        {
            for (int i = n; i >= viTriThem; i--)
            {
                arrA[i] = arrA[i - 1];
            }
            arrA[viTriThem] = soThem;
            n++;

            // Xuat mang sau khi chen
            Console.WriteLine("Mang sau khi chen la: ");
            XuatMang(arrA, n);
        }

    }
}
