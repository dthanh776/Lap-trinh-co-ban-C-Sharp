using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baitap
{
    class bai4
    {
        static void Main(string[] args)
        {
             int x = 1;
            int i2 = 1;
            string i = string.Empty;
            string i1 = string.Empty;
            do
            {
                                            
                Console.Write("Nhap Ho ten nhan vien {0} ",i2++);
                string Hoten = Console.ReadLine();
                Console.WriteLine("Nhap vao ngay thang nam ");
                int ngay = int.Parse(Console.ReadLine());
                int thang = int.Parse(Console.ReadLine());
                int nam = int.Parse(Console.ReadLine());
                DateTime datetime = new DateTime(nam, thang, ngay);
                Console.Write("Nhap vao luong co ban ");
                double LuongCB = double.Parse(Console.ReadLine());
                Console.Write("Nhap he so luong ");
                double HSL = double.Parse(Console.ReadLine());
                i += Hoten +"-"+ datetime.Day +"/"+ datetime.Month+"/"+ datetime.Year+"-"+ LuongCB +"-"+ HSL + "\n";
                if (datetime.Month > 0 && datetime.Month < 4)
                {
                    i1 += Hoten + "-" + datetime.Day + "/" + datetime.Month + "/" + datetime.Year + "-" + LuongCB + "-" + HSL + "\n";
                }
                Console.WriteLine("Nhap so bat ky de tiep tuc");
                Console.WriteLine("Nhap 0 de thoat");
                x = int.Parse(Console.ReadLine());

            } while (x != 0);
            Console.Write(i);
            Console.WriteLine("Nhan vien thuoc quy 1 ");
            Console.Write(i1);
            Console.ReadKey();
        }
    }
}
