using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; int m = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());
            } while (n == m);
            int[,] hcn = new int[n, m];
            int[,] hv;
            if (n < m) hv = new int[n, n];
            else hv = new int[m, m];

            Input(hv);
            Output(hv);

            char choose;
            while (char.TryParse(Console.ReadLine(), out choose))
            {
                switch (choose)
                {
                    case 'a':
                        Tich(hv);
                        break;
                    case 'b':
                        TichDC(hv);
                        break;
                    case 'c':
                        Console.WriteLine($"Tong cac so nguyen to la {TongPrime(hv)}");
                        break;
                    case 'd':
                        Console.WriteLine($"TBC so chan la {TBCEven(hv)}");
                        break;
                    case 'e':
                        Console.WriteLine($"la {Maxodd(hv)} ");
                        break;
                    case 'f':
                        Console.Write("Nhap x = ");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"So lan {x} xuat trong {X(hv, x)}");
                        break;
                    case 'g':
                        Sapxep(hv);
                        break;
                    case 'h':
                        sapxep2(hv);
                        break;
                }
            }
            Console.ReadKey();
        }
        static void Input(int[,] n)
        {
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    n[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Output(int[,] n)
        {
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    Console.Write($"{n[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Tich(int[,] n)
        {
            for (int i = 0; i < n.GetLength(0); i++)
            {
                int tich = 1;
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    tich = tich * n[j, i];
                }
                Console.WriteLine($"tich cua cot {i} = {tich}");
            }
        }
        static void TichDC(int[,] n)
        {
            int t1 = 1, t2 = 1;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(0); j++)
                {
                    if (i == j) t1 = t1 * n[i, j];
                    if (j == n.GetLength(0) - 1 - i) t2 = t2 * n[i, j];
                }
            }
            Console.WriteLine($"tich cua duong cheo chinh = {t1}");
            Console.WriteLine($"tich cua duong cheo phu = {t2}");
        }
        static bool checkPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n / 2 + 1; i++)
                if (n % i == 0) return false;
            return true;
        }
        static int TongPrime(int[,] n)
        {
            int S = 0;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (checkPrime(n[i, j])) S += n[i, j];
                }
            }
            return S;
        }
        static double TBCEven(int[,] n)
        {
            int S = 0, count = 0;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (n[i, j] % 2 == 0)
                    {
                        S += n[i, j];
                        count++;
                    }
                }
            }
            return S / count;
        }
        static int Maxodd(int[,] n)
        {
            int max = 0;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (n[i, j] % 2 != 0 && n[i, j] > max) max = n[i, j];
                }
            }
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (n[i, j] == max) Console.WriteLine($"hv[{i}][{j}] la phan tu le lon nhat");
                }
            }
            return max;
        }
        static int X(int[,] n, int x)
        {
            int count = 0;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (x == n[i, j]) count++;
                }
            }
            return count;
        }
        static void Sapxep(int[,] n)
        {
            int[] temp = new int[n.Length];
            int a = 0;
            for(int i = 0; i< n.GetLength(0); i++)
            {
                for(int j = 0; j< n.GetLength(1); j++)
                {
                    temp[a] = n[i, j];
                    a++;
                }
            }
            Array.Sort(temp);
            a = 0;
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    n[i, j] = temp[a];
                    a++;
                }
            }
            Output(n);
        }
        static void sapxep2(int[,] n)
        {
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    int temp;
                    for(int k = j + 1; k < n.GetLength(1); k++)
                    {

                        if (n[i, j] > n[i, k])
                        {
                            temp = n[i, j];
                            n[i, j] = n[i, k];
                            n[i, k] = temp;
                        }
                    }
                }
            }
            Output(n);
        }
    }
}
