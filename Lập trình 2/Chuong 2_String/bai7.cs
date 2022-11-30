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
            string n = Console.ReadLine();
            Console.Write(f(n));
            Console.ReadKey();
        }
        //Hàm đếm số từ trong chuỗi
        static int f(string n)
        {
            int i = 0; int count = 0;
            while (i < n.Length)
            {
                while (n[i] == ' ' && i < n.Length - 1) i++;
                if (i == n.Length - 1) break;
                count++;
                while (n[i] != ' ' && i < n.Length - 1) i++;
            }
            return count;
        }
    }
}
