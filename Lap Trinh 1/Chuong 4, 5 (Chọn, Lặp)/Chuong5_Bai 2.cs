/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_5_Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao n
            Console.WriteLine("Nhap vao so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            //Kiem tra uoc so
            Console.Write("Cac uoc so la: ");
            for (int i = 1; i <= n ; i++)
            {
                if ( n % i == 0)
                    Console.Write("{0}\t" , i);
            }
            Console.ReadKey();
        }
    }
}
