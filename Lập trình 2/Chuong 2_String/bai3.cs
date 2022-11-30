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
            Console.Write(c(n));
            Console.ReadKey();
        }
        //Đếm số ký tự là số trong chuỗi
        static int c(string n)
        {
            int count = 0;
            int len = n.Length;
            for (int i = 0; i < n.Length; i++)
                if (n[i] >= '0' && n[i] < '9') count++;
            return count;
        }
    }
}
