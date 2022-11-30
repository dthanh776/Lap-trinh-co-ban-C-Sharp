using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Console.Write(DemKyTu(n));
            Console.ReadKey();
        }
        //Đếm số ký tự có trong chuỗi
        static int DemKyTu(string n)
        {                       
            return n.Length;
        }
    }
}
