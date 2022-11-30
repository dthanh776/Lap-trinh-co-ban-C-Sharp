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
            if (i(n)) Console.WriteLine("Hop le");
            else Console.WriteLine("Khong hop le");
            Console.ReadKey();
        }
        //Đảo ngược chuỗi
        //Kiểm tra xem chuỗi có hợp lệ không
        static bool i(string n)
        {
            if (n[0] == ' ' || n[n.Length - 1] == ' ' || n[0] < 'A' || n[0] > 'Z') return false;
            return true;
        }
    }
}
