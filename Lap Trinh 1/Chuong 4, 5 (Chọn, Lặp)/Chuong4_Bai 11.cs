/*
 Bui Duy Thanh
 20211tt0660    
 Chuong 4_Bai 11
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong_4_Bai_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai bao va nhap vao chi so cu
            Console.Write("Nhap vao chi so dien moi: ");
            int chiSoMoi = int.Parse(Console.ReadLine());

            // Khai bao va nhap vao chi so moi
            Console.Write("Nhap vao chi so dien cu: ");
            int chiSoCu = int.Parse(Console.ReadLine());

            // Tinh muc dien tieu thu
            int mucDienTieuThu = chiSoMoi - chiSoCu;

            // Tinh phan vuot dinh muc
            int vuotDinhMuc = mucDienTieuThu - 50;

            // Khai bao dinh muc
            int dinhMuc = 50;

            // Khai bao tong tien
            int tongTien = 0;

            // Tinh tien 
            if (mucDienTieuThu < 50)
            {
                tongTien = 1000 * mucDienTieuThu;
                Console.Write("Tong tien dien la: " + tongTien);
            }
            else if (vuotDinhMuc <= 50)
            {
                tongTien = 1500 * vuotDinhMuc + 1000 * dinhMuc ;
                Console.Write("Tong tien dien la: " + tongTien);
            }
            else if (vuotDinhMuc > 50 && vuotDinhMuc <= 100)
            {
                tongTien = 1800 * vuotDinhMuc + 1000 * dinhMuc;
                Console.Write("Tong tien dien la: " + tongTien);
            }
            else if (vuotDinhMuc > 100)
            {
                tongTien = 2500 * vuotDinhMuc + 1000 * dinhMuc;
                Console.Write("Tong tien dien la: " + tongTien);
            }
            Console.ReadKey();
        }
    }
}
