/*/*Bùi Duy Thanh//
 * 20211TT660
 * Chương 2 bài 7
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap vao ki tu bat ki
            Console.WriteLine("Nhap vao mot ki tu bat ki: ");

            int ch;
            ch = Console.Read();

            // Xuat ra ki tu ma Ascii vua nhap
            Console.WriteLine("Ma Ascii la {0} " , ch);

            // Xuat ra ki tu ke tiep vua nhap
            Console.WriteLine("Ma Ascii ke tiep la {0}" , (char)(ch + 1));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
