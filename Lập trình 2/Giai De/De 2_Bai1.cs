using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrA = new int[3, 4];
            NhapMang(arrA);
            XuatMang(arrA);
            TinhTBCDong(arrA);
            Console.ReadKey();

        }

        //cau c :Ham tinh trung binh cong tren tung dong cua mang
        static void TinhTBCDong(int[,] arrA)
        {
            double Tong = 0;
            double Tbc = 0;
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                Tong = 0;
                Tbc = 0;
                for (int j = 0; j < arrA.GetLength(1); j++)
                {
                    Tong += arrA[i, j];
                    Tbc = Tong / arrA.GetLength(1);
                }

                Console.WriteLine($"TBC cua dong {i+1} la : {Math.Round(Tbc, 2)}");
            }
        }
        static void XuatMang(int[,] arrA)
        {
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrA.GetLength(1); j++)
                {
                    Console.Write($"{arrA[i, j],5}");
                }
                Console.WriteLine();
            }
        }
        static void NhapMang(int[,] arrA)
        {
            Random rd = new Random();
            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrA.GetLength(1); j++)
                {
                    arrA[i, j] = rd.Next(1, 20);
                    //Console.WriteLine($"Nhap [{i},{j}]");
                    //arrA[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

    }
}
