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
            string m = Console.ReadLine();
            if (soSanh(n, m)) Console.WriteLine("Bang nhau");
            else Console.WriteLine("Khong Bang");
            Console.ReadKey();
        }
        //Hàm só sánh 2 chuỗi không phân biệt hoa thường
        static bool soSanh(string a, string b)
        {
            int c = string.Compare(a, b);
            switch (c)
            {
                case 0: return true;
            }
            return false;
        }
    }
}
