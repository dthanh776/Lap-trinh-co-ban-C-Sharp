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
            int[,] Matrix = new int[,]
            {
                { 0, 0, 2, 1 },
                { 0, 0, 2, 1 },
                { 2, 2, 0, 1 },
                { 1, 1, 1, 0 }
            };
            Output(Matrix);
            /// Check Matrix
            if (Check(Matrix) == true) Console.WriteLine("This is multi-graph ");
            else Console.WriteLine("This isn't multi-graph ");
            /// Total value of array
            Total(Matrix);
            //Xét xem đồ thị có chu trình con hay ko
            if (graphReview(Matrix) == true) Console.WriteLine("Yes");
            else Console.WriteLine("False");
            Console.ReadKey();
        }
        static void Output(int[,] n)
        {
            Console.WriteLine("The matrix: ");
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    Console.Write("{0,5}", n[i, j]);
                }
                Console.WriteLine("\n");
            }
            
           
        }
        static bool Check(int[,] n)
        {
            int count1 = 0, count2 = 0;
            Console.WriteLine("Check matrix is Multi-graph ???");
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        if (n[i, j] != 0) count1++;
                    }
                    if (n[i, j] == n[j, i]) count2++;
                }
            }
            if (count1 == 0 && count2 > 0) return true;
            else return false;
        }
        static void Total(int[,] n)
        {
            int S = 0;
            Console.WriteLine("Total value of Array ???");
            for (int i = 0; i < n.GetLength(1); i++)
            {
                for (int j = 0; j < n.GetLength(0); j++)
                {
                    S = S + 1;
                }
            }
            Console.WriteLine("Total value of Array = {0}", S);
        }
        static bool graphReview(int[,] n)
        {
            
            for (int i = 0; i < n.GetLength(1); i++)
            {
                int S = 0;
                for (int j = 0; j < n.GetLength(0); j++)
                {
                    S = S + n[i, j];
                }
                if (S % 2 != 0) return false;
            }
            return true;
        }
    }
}
