using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Nhap vao so hang n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so ghe o moi hang m = ");
            int m = int.Parse(Console.ReadLine());

            int[,] Rap = new int[n, m];

            Xuat(Rap);
            //Chọn ghế
            chon(Rap, n, m);

            Xuat(Rap);
            // tổng số ghê
            T(Rap);
            //Tổng số ghế ngồi còn trống từng hàng 
            HangTrong(Rap);
            // tổng số cặp ghế trống
            Cap(Rap);
            // Hàng có số ghế tróng nhiều nhất
            Trong(Rap);
            // Hàng hết chỗ
            hetcho(Rap);
            // kt ghế ở biên
            BIen(Rap);
            Console.ReadKey();
        }
        // Câu 1
        static void chon(int[,] Rap, int n, int m)
        {
            int count = 0;
            while (true)
            {
                if (count == n * m)
                {
                    Console.WriteLine("het cho");
                    break;
                }
                Console.Write("Nhap vao so hang chon: ");
                int i = int.Parse(Console.ReadLine());
                if (i == -1)
                {
                    Console.WriteLine("Ket thuc dat cho");
                    break;
                }
                Console.Write("Nhap vao so ghe chon: ");
                int j = int.Parse(Console.ReadLine());


                if ((Rap[i, j] == 0))
                {
                    Console.Clear();
                    Rap[i, j] = 1;
                    Console.WriteLine("Dat cho thanh cong");
                    count++;
                }
                else Console.WriteLine("Cho da co nguoi, vui long nhap lai");
                Xuat(Rap);
            }
        }
        // Xuất mảng
        static void Xuat(int[,] Rap)
        {
            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                for (int j = 0; j < Rap.GetLength(1); j++)
                {
                    Console.Write("{0,5}", Rap[i, j]);
                }
                Console.WriteLine();
            }
        }
        // tổng chỗ ngồi
        static void T(int[,] Rap)
        {
            int S = 0;
            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                for (int j = 0; j < Rap.GetLength(1); j++)
                {
                    S = S + 1;
                }
            }
            Console.WriteLine("Tong cho ngoi = {0}", S);
        }
        static void HangTrong(int[,] Rap)
        {

            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                int S = 0;
                for (int j = 0; j < Rap.GetLength(1); j++)
                {
                    if (Rap[i, j] == 0)
                    {
                        S = S + 1;
                    }

                }
                Console.WriteLine("Co {0} cho trong o hang thu {1}", S, i);
            }

        }

        static void Cap(int[,] Rap)
        {
            Console.WriteLine("\tSo cap ghe trong:");
            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                int S = 0;
                for (int j = 0; j < Rap.GetLength(1) - 1; j++)
                {
                    if (Rap[i, j] == 0 && Rap[i, j + 1] == 0)
                    {
                        S = S + 1;
                        j++;
                    }
                }
                Console.WriteLine("Co {0} cap ghe trong o hang thu {1}", S, i);
            }
        }
        static void Trong(int[,] n)
        {
            int max = 0;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                int S = 0;
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (n[i, j] == 0) S++;
                }
                if (S > max) max = S;
            }
            for (int i = 0; i < n.GetLength(0); i++)
            {
                int S = 0;
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (n[i, j] == 0) S++;
                }
                if (S == max && S != 0) Console.WriteLine("Hang {0} con so ghe trong nhieu nhat", i);
            }
        }
        static void hetcho(int[,] n)
        {
            Console.WriteLine("Hang da het cho");
            for (int i = 0; i < n.GetLength(0); i++)
            {
                int count = 0;
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (n[i, j] == 1) count++;
                }
                if (count == n.GetLength(1)) Console.WriteLine("Hang {0} da het cho", i);
            }
        }
        static void BIen(int[,] n)
        {
            int count = 0;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (n[0, j] == 0 || n[j, 0] == 0) break;
                    if (n[0, j] == 1 || n[i,0] == 1) count++;
                }
            }
            if (count == n.GetLength(0) * n.GetLength(1)) Console.Write("Het ghe trong o bien");
            else Console.Write("con ghe trong o bien");
        }
    }
}
