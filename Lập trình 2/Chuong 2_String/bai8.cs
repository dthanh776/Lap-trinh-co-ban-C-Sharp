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
            Console.Write(g(n));
            Console.ReadKey();
        }
        //Xóa khoảng trắng và thêm "@tdc.edu.vn"
        static string g(string n)
        {
            string s = string.Empty;
            for (int i = 0; i < n.Length; i++)
                if (n[i] != ' ') s += n[i];
            return s + "@tdc.edu.vn";
        }
    }
}
