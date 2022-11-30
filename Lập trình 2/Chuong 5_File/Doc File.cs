using System;
using System.IO;

// Doc file

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            try
            {
                using (StreamReader sR = new StreamReader("D:\\Thanh\\input.txt"))
                {
                    a = int.Parse(sR.ReadLine());
                    b = int.Parse(sR.ReadLine());
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Doc file that bai: ");
                throw;
            }
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
