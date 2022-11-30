using System;

namespace Bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien n va tiepTuc
            int n = 0;
            char tiepTuc;
            
            do
            {
                // Nhap n va kiem tra dieu kien
                do
                {
                    Console.WriteLine("Nhap vao so nguyen duong: ");
                    n = int.Parse(Console.ReadLine());
                } while (n < 0 || n > 1000);

                char chon = Menu();
                switch (chon)
                {
                    case 'A':
                        KiemTraSNT(n);
                        break;
                    case 'B':
                        KTSCP(n);
                        break;
                    case 'C':
                        SHH(n);
                        break;
                    case 'D':
                        DoiXung(n);
                        break;
                    default:
                        Console.WriteLine("Chon sai, vui long chon lai: ");
                        break;
                }
                // Hoi nguoi dung muon tiep tuc khong
                Console.WriteLine("Ban co muon tiep tuc khong: ");
                tiepTuc = char.Parse(Console.ReadLine());
            } while (tiepTuc == 'Y' || tiepTuc == 'y');

            // Ham menu
            static char Menu()
            {
                char chon;
                Console.WriteLine("---MOI BAN CHON---");
                Console.WriteLine("A: Kiem tra so vua nhap co phai la so nguyen to");
                Console.WriteLine("B: Kiem tra so vua nhap co phai la so chinh phuong");
                Console.WriteLine("C: Kiem tra so vua nhap co phai la so hoan hao");
                Console.WriteLine("D: Kiem tra so vua nhap co phai la so doi xung");
                chon = char.Parse(Console.ReadLine());
                return chon;
            }
            // Ham Kiem tra SNT
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
            // Kiem tra co phai la SNT khong
            static void KiemTraSNT(int n)
            {
                if (KTSNT(n) == true)
                {
                    Console.WriteLine($"{n} la so nguyen to");
                }
                else
                {
                    Console.WriteLine($"{n} KHONG la so nguyen to");
                }
            }
            // Kiem tra co phai la SHH khong
            static void SHH (int n)
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
                {
                    Console.WriteLine($"{n} la so hoan hao");
                }
                else
                {
                    Console.WriteLine($"{n} KHONG la so hoan hao");
                }
            }
            // Kiem tra co phai la so chinh phuong khong
           static void KTSCP (int n)
            {
                int flag = 0;
                for (int i = 0; i < n ; i++)
                {
                    if (i * i == n)
                    {
                        flag++;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine($"{n} la so chinh phuong");
                else
                    Console.WriteLine($"{n} KHONG la so chinh phuong");
            }

            // Ham kiem tra so doi xung
            static void DoiXung (int n)
            {
                int sum = 0;
                int temp = n;
                while (n != 0)
                {
                    sum = sum * 10 + n % 10;
                    n = n / 10;
                }
                if (temp == sum)
                {
                    Console.WriteLine($"{n} la so doi xung");
                }
                else
                {
                    Console.WriteLine($"{n} KHONG la so doi xung");
                }
            }
        }

    }
}
