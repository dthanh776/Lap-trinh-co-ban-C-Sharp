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
        //Tạo tk và mk từ tên người dùng
        static void j(string n)
        {
            int a = n.Length;
            string User = n.Substring(n.LastIndexOf(' ')) + n.Substring(0, n.IndexOf(' '));
            Random y = new Random();
            string pass = string.Empty;
            for (int i = 0; i < n.Length; i++)
                if (n[i] != ' ')
                {
                    pass += n[i];
                    while (i < n.Length && n[i] != ' ') i++;
                }
            pass += y.Next(100000, 999999);
            pass = pass.ToLower();
            Console.Write(User);
            Console.Write(pass);
        }
    }
}
