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
            char x = char.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            Console.Write(d(n, x));
            Console.ReadKey();
        }
        //Đếm số ký tự trùng với ký tự char nhập vào từ bàn phím
        static int d(string n, char m)
        {
            int count = 0;
            int len = n.Length;
            for (int i = 0; i < n.Length; i++)
                if (n[i] == m) count++;
            return count;
        }
    }
}
