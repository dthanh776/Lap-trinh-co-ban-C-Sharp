/*/*Bùi Duy Thanh
 * 20211TT660
 * Chương 2 bài 6
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
            // Nhap dolla My
            Console.WriteLine("Nhap gia tri Dolla My can quy doi: ");
            double dollaMy = double.Parse(Console.ReadLine());

            // Quy doi va in Dolla My -> Bang Anh
            double bangAnh = dollaMy * 0.8144;
            Console.WriteLine("So tien quy doi tu Dolla My -> Bang Anh la: {0}" , bangAnh);

            // Quy doi va in Dolla My -> Yen Nhat
            double yenNhat = dollaMy * 105.407;
            Console.WriteLine("So tien quy doi tu Dolla My -> Yen Nhat la: {0}", yenNhat);

            // Quy doi va in Dolla My -> Viet Nam Dong
            double vietNamDong = dollaMy * 23160;
            Console.WriteLine("So tien quy doi tu Dolla My -> Viet Nam Dong la: {0}", vietNamDong);
            Console.ReadKey();
        }
    }
}
