using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[][] Pascal = new int[n][];
            for(int i = 0; i < Pascal.Length; i++)
            {
                Pascal[i] = new int[i+1];
                for( int j = 0;  j < Pascal[i].Length ; j++)
                {
                    if (j == 0 || j == i) Pascal[i][j] = 1;
                    else Pascal[i][j] = Pascal[i - 1][j - 1] + Pascal[i - 1][j];
                    Console.Write($"{Pascal[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
