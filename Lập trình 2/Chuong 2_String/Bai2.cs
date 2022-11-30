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
            Console.Write(b(n));
            Console.ReadKey();
        }
        //Đếm số ký tự hoa có trong chuỗi
        static int b(string n)
        {
            int count = 0;
            int len = n.Length;
            for (int i = 0; i < n.Length; i++)
                if (n[i] >= 'A' && n[i] < 'Z') count++;
            return count;
        }
    }
}
