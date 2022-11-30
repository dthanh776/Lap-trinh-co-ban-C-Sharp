/*/*Bùi Duy Thanh
 * 20211TT660
 * Chương 2 bài 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2_Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhap sale 1
            Console.WriteLine("Nhap sale 1: ");
            int sale1 = int.Parse(Console.ReadLine());

            // Nhap sale 2
            Console.WriteLine("Nhap sale 2: ");
            int sale2= int.Parse(Console.ReadLine());

            // Nhap commissionRate
            Console.WriteLine("Nhap commissionRate : ");
            int commissionRate = int.Parse(Console.ReadLine());

            // Tinh totalSale va commission
            int totalSale = sale1  + sale1 ;
            int commission = totalSale * commissionRate;

            // In ra commission
            Console.WriteLine("commission = {0}",commission);
            Console.ReadKey();
        }
    }
}
