/*
 *Bùi Duy Thanh
 *20211TT0660
 *Kiem Tra Ham
 */

using System;

namespace KiemTraMang
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien n
            int n;
            // Nhap n va kiem tra dieu kien (neu sai nhap lai)
            do
            {
                Console.Write("Nhap vao so phan tu: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 50);

            //Khai bao mang
            int[] arrA = new int[n];

            // Nhap mang
            NhapMang(arrA);

            // Xuat mang
            Console.WriteLine("\nCac phan tu vua nhap la: ");
            XuatMang(arrA);

            // Tinh trung binh cong cua cac phan tu
            TBC(arrA);

            // Dem SCP
            DemSCP(arrA);

            // Sap xep giam dan
            SapXepGiam(arrA);

            // Tim so duong nho nhat trong mang
            SoNhoNhat(arrA);
        }
        // Ham nhap mang
        static void NhapMang(int[] arrA)
        {


            // Khai bao ramdom de nhap so ngau nhien cho mang
            Random rd = new Random();
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = rd.Next(1, 10);
            }
        }
        // Ham xuat mang
        static void XuatMang(int[] arrA)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write($"{arrA[i],-5}");
            }
        }
        // Ham tinh trung binh cong
        static void TBC(int [] arrA)
        {
            // Khai bao bien tong va tbc
            double tong = 0;
            double tbc = 0;

            for (int i = 0; i < arrA.Length; i++)
            {
                tong += arrA[i];
                tbc = tong / arrA.Length;
            }
            Console.WriteLine($"\n\nTrung binh cong cua cac phan tu la: {Math.Round(tbc,2)} ");
        }
        // Ham kiem tra SCP
        static bool KiemTraSCP (int n)
        {
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (i * i == n )
                {
                    flag++;
                    break;
                }
            }
            if (flag == 1)
            {
                return true;
            }
            return false;
        }
        // Ham dem SCP trong mang
        static void DemSCP (int [] arrA)
        {
            // Khai bao bien dem
            int dem = 0;
            for (int i = 0; i < arrA.Length; i++)
            {
                if (KiemTraSCP(i) == true)
                {
                    dem++;
                }
            }
            Console.WriteLine($"\nCo {dem} SCP trong mang");

        }
        // Ham sap xep giam dan
        static void SapXepGiam(int[] arrA)
        {
            // Khai bao bien gan;
            int gan;
            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = i + 1; j < arrA.Length; j++)
                {
                    if (arrA[i] < arrA[j])
                    {
                        gan = arrA[i];
                        arrA[i] = arrA[j];
                        arrA[j] = gan;
                    }
                }
            }
            Console.WriteLine("\nMang sau khi sap xep giam dan la: ");
            // Xuat mang
            XuatMang(arrA);
        }
        // Ham tim so nho nhat trong mang
        static void SoNhoNhat (int[] arrA)
        {
            int min = arrA[0];
            for (int i = 0; i < arrA.Length; i++)
            {
                if (min > arrA[i]) // so sanh gia tri nho nhat voi mang
                {
                    min = arrA[i]; // gan lai gia tri nho nhat
                }
            }
            // In ra ket qua
            Console.WriteLine($"\n\nSo nho nhat trong mang la: {min} ");

        }
    }
}
