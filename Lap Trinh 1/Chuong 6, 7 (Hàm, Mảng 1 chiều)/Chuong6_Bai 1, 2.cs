
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char tiepTuc;
            char chon;
            do
            {
                Menu();
                Console.WriteLine("Chon A -> E");
                chon = char.Parse(Console.ReadLine());

                // Ham so vua nhap
                int n;
                n = NhapVaoSoNguyen();

                switch (chon)
                {
                    case 'A':
                        // Goi ham tinh tong le <= n
                        int kqTongLe = TinhTong(n);
                        Console.WriteLine("Tổng các số lẻ <= n: " + kqTongLe);
                        break;

                    case 'B':
                        // Goi ham tinh tich boi so
                        double kqTichBoiSo = TinhTichBoiSo(n);
                        Console.WriteLine("Tich các bội số của 3 <= n: " + kqTichBoiSo);
                        break;

                    case 'C':
                       
                        // Goi ham tinh tong 1 + 1/n-1
                        double kqTongPhanSo = TongPhanSo(n);
                        Console.WriteLine("Tổng phân số là: " + kqTongPhanSo);
                        break;

                    case 'D':
                        // Goi ham tich cac so chan
                        int kqTichSoChan = TichSoChan(n);
                        Console.WriteLine("Tích các số chẵn là: " + kqTichSoChan);
                        break;

                    case 'E':
                        // Goi ham
                        int kqGiaiThua = GiaiThua(n);
                        Console.WriteLine("n! = " + kqGiaiThua);
                        break;

                    default:
                        Console.WriteLine("Nhập sai, yêu cầu nhập lại: ");
                        break;
                }

                Console.WriteLine("Bạn có muốn tiếp tục không? (Y/N)");
                tiepTuc = char.Parse(Console.ReadLine());
            } while (tiepTuc == 'y' || tiepTuc == 'Y');

            Console.ReadKey();
        }

        // Ham nhap vao mot so nguyen
        static int NhapVaoSoNguyen()
        {
            // Khai bao bien so nguyen
            int n;
            do
            {
                Console.Write("Nhập vào số nguyên dương n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 );

            return n;
        }
        // Ham tinh tong n
        static int TinhTong(int n)
        {
            int tong = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }
            return tong;
        }

        // Ham tich cac boi so cua 3 < n
        static double TinhTichBoiSo (double n)
        {
            int tich = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    tich *= i;
                }
            }
            return tich;
        }

        // Ham tong 1 + ... +1/n -1
        static double TongPhanSo (int n)
        {
            double tong = 0;
            for (int i = 1; i < n; i++)
            {
                tong += 1.0 / i;
            }
            tong = Math.Round(tong, 2);
            return tong;
        }

        // Ham tich cac so chan <= n
        static int TichSoChan (int n)
        {
            int tich = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    tich *= i;
            }
            return tich;
        }

        // Ham tinh n!
        static int GiaiThua (int n)
        {
            int tich = 1;
            for (int i = 1; i <= n ; i++)
            {
                tich *= i;
            }
            return tich;
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CHƯƠNG TRÌNH VIẾT BẰNG HÀM");
            Console.WriteLine("A = Tổng các số lẻ <= n");
            Console.WriteLine("B = Tích các bội số của 3 <= n");
            Console.WriteLine("C = 1+ 1/2 + 1/3 + ... + 1/n -1");
            Console.WriteLine("D = 2 * 4 * 6 * ... 2n");
            Console.WriteLine("E = N!");
        }


        
    }
}
