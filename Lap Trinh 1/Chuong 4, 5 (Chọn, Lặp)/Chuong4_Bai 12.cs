/*
 Bui Duy Thanh
 20211tt0660    
 Chuong 4_Bai 12
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_4___Bai_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao bien kyTu
            Console.Write("Nhap ki tu bat ki: ");
            char kyTu;
            char.TryParse(Console.ReadLine(), out kyTu);

            // Kiem tra dieu kien
            if (kyTu >= 'A' && kyTu <= 'Z')
            {
                Console.Write($"{kyTu} la ky tu hoa" );
            }
            else if (kyTu >= 'a' && kyTu <= 'z')
            {
                Console.Write($"{kyTu} la ky tu thuong");
            }
            else if (kyTu >= '0' && kyTu <= '9')
            {
                Console.Write($"{kyTu} la ky tu so");
            }
            else
                Console.WriteLine($"{kyTu} la ky tu khac");

            Console.ReadKey();
        }
    }
}
