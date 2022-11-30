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
            if (h(n)) Console.WriteLine("Hop le");
            else Console.WriteLine("Khong hop le");
            Console.ReadKey();
        }
        //Kiểm tra chuỗi không có các ký tự @#$%,^
        static bool h(string n)
        {
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '#' && n[i] == '%' && n[i] == '$' && n[i] == '&' && n[i] == '^') return false;
                if (n[i] == '@') count++;
            }
            if (count != 1) return false;
            return true;
        }
    }
}
