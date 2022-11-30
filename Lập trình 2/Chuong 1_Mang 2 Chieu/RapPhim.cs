using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so hang n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so ghe m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] rap = new int[n, m];
            XuatRap(rap);
            DatCho(rap,n, m);
        }
        // Xuat cho ngoi trong rap
        static void XuatRap (int[,] Rap )
        {
            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                for (int j = 0; j < Rap.GetLength(1); j++)
                {
                    Console.Write($"{Rap[i,j], 5}");
                }
                Console.WriteLine();
            }
        }
        // Đặt chỗ
        static void DatCho(int[,] Rap, int n, int m)
        {

            while (true)
            {
                Console.Write("Nhap hang muon dat: ");
                n = int.Parse(Console.ReadLine());

                Console.Write("Nhap ghe muon dat: ");
                m = int.Parse(Console.ReadLine());

                if (Rap[n, m] == 0)
                {
                    Console.WriteLine("Dat cho thanh cong");
                    Rap[n, m] = 1;
                }
                else
                {
                    Console.WriteLine("Dat cho that bai");
                }
                // Bam -1 de ket thuc dat cho
                if (n == -1 || m == -1)
                {
                    Console.Write("Ket thuc dat cho");
                    break;
                }
                // In chỗ ngồi trong rạp
                XuatRap(Rap);
                // Tổng chỗ ngồi còn trống trong rạp                
                TongGheTrongRap(Rap);
                // Số lượng chỗ trống từng hàng
                SoLuongGheTrongHang(Rap);
                Console.WriteLine();
                // Số lượng chỗ trống từng dãy
                SoLuongGheTrongDay(Rap);
                // Số cặp ghế trống từng hàng
                Console.WriteLine();
                SoCapGheTrong(Rap);
                HangMax(Rap);
            }
        }

        // Tổng chỗ ngồi còn trống trong rạp
        static void TongGheTrongRap (int[,] Rap )
        {
            int sum = 0;
            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                for (int j = 0; j < Rap.GetLength(1); j++)
                {
                    if (Rap[i,j] == 0)
                    {
                        sum += 1;
                    }
                }
            }
            Console.Write($"Co {sum} cho trong trong rap \n" );
        }

        // Số lượng chỗ trống từng hàng
        static void SoLuongGheTrongHang (int[,] Rap)
        {
            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < Rap.GetLength(1); j++)
                {
                    if (Rap[i,j] == 0)
                    {
                        sum += 1;
                    }                   
                }
            Console.Write($"Co {sum} cho trong o hang thu {i + 1} \n");
            }
        }
        // Số lượng chỗ trống từng dãy
        static void SoLuongGheTrongDay(int[,] Rap)
        {
            for (int j = 0; j < Rap.GetLength(1); j++)
            {
                int sum = 0;
                for (int i = 0; i < Rap.GetLength(0); i++)
                {
                    if (Rap[i,j] == 0)
                    {
                        sum += 1;
                    }
                }
                Console.Write($"Co {sum} cho trong o day thu {j + 1} \n");
            }
        }
        // Số cặp ghế trống theo hàng
        static void SoCapGheTrong(int[,] Rap)
        {
            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < Rap.GetLength(1) - 1; j++)
                {
                    if (Rap[i,j] == 0 && Rap[i,j + 1] == 0)
                    {
                        sum += 1;
                        j++;
                    }
                }
                Console.Write($"Co {sum} cap ghe trong o hang {i + 1} \n");
            }
        }
        // Hàng có nhiều ghế trống nhất
        static void HangMax (int[,] Rap)
        {
            int max = 0;
            int viTri = 0;
            for (int i = 0; i < Rap.GetLength(0); i++)
            {
                int dem = 0;
                for (int j = 0; j < Rap.GetLength(1); j++)
                {
                    if (Rap[i,j] == 0)
                        dem++;
                }
                if (dem > max)
                {
                    max = dem;
                    viTri = i;
                }
            }
            Console.Write($"Hang {viTri} co so ghe trong nhieu nhat \n");
        }
    }
}
