using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài 1: Xuất ngày giờ hiện tại
            DateTime now = DateTime.Now;
            Console.WriteLine($"{now.DayOfWeek}, {now.Day}, {now.Month}, {now.Year}, {now.TimeOfDay}");
            //2
            b();
            Console.ReadKey();
            //3
            c();
            Console.ReadKey();
        }
            //Bài 2. Tính ngày trước và ngày sau của 1 ngày
        static void b()
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            TimeSpan m = new TimeSpan(0,24,0,0,0);
            DateTime n = new DateTime(year, month, day);
            DateTime dateAfter = n.Date + m;
            Console.WriteLine($"Day after: {dateAfter}");

            DateTime dateBefore = n.Date - m;
            Console.WriteLine($"Day before: {dateBefore}");
        }
        //3. Tính số ngày mượn sách trễ
        static void c()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            
            DateTime N1 = new DateTime(year, month, day);
            TimeSpan n = new TimeSpan(60,0,0,0);
            DateTime N2 = N1.Date  + n;

            int day1 = int.Parse(Console.ReadLine());
            int month1 = int.Parse(Console.ReadLine());
            int year1 = int.Parse(Console.ReadLine());
            
            DateTime N3 = new DateTime(year1, month1, day1);
            if (N3 <= N2) Console.WriteLine("Khong tre");
            else
            Console.Write($"So ngay tra sach tre la: {(N3 - N2).TotalDays} ngay");
        }
    }
}
