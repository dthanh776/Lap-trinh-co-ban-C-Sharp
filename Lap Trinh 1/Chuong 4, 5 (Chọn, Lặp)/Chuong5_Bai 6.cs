/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 6
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;

            int a = 0;
            int b = 1;

            Console.Write("Day fibonaci la: ");
            for (int i = 1; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.Write("{0} ",c);
            }
            Console.ReadKey();
        }
    }
}
