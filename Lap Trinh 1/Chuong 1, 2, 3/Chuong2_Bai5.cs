/*/*Bùi Duy Thanh
 * 20211TT660
 * Chương 2 bài 5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap vao so nguyen duong n
            Console.WriteLine("Nhap vao n: ");
            int n = int.Parse(Console.ReadLine());

            // Tinh va in bang cuu chuong
            for (int i = n; i <=n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}" ,i,j,i*j );
                }
            }

            Console.ReadKey();
        }
    }
}
