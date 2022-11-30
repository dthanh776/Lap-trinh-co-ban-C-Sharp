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
            Console.Write(e(n));
            Console.ReadKey();
        }
        //Đảo ngược chuỗi
        static string e(string n)
        {
            string newStr = String.Empty;
            for (int i = n.Length - 1; i >= 0; i--)
                newStr += n[i];
            return newStr;
        }
    }
}
