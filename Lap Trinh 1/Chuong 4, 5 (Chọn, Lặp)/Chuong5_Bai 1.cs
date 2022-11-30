/*
 * Bui Duy Thanh
 * 20211tt0660
 * Chuong 5_Bai 1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // khai bao n, do nguoi dung nhap vao
            Console.WriteLine("Nhap vao so nguyen duong n bat ki: ");
            double n = double.Parse(Console.ReadLine());
            
            
            Console.WriteLine("A: tong cac so le");
            Console.WriteLine("B: tich boi so cua 3");
            Console.WriteLine("C: tong 1/n");
            Console.WriteLine("D: tich cac so chan");
            Console.WriteLine("E: N!");

            // Tao menu 
            Console.WriteLine("Nhap ky tu 'A', 'B', 'C', 'D', 'E' ");
            char kyTu;
            char.TryParse(Console.ReadLine(), out kyTu);

            // Khai bao bien sum, tich
            double sum = 0;
            int tich = 1;

            // Chon ki tu 
            switch (kyTu)
            {
                // Chon A
                case 'A':
                   // int sum = 0;
                    for (int i = 1; i <= n; i++)
                    {                      
                        if (i % 2 != 0)
                        {
                            sum += i;
                        }
                    }
                    Console.Write("tong cac so le <= n la: {0}", sum);
                    break;
                // Chon B
                case 'B':
                    for (int i = 1; i <= n ; i++)
                    {
                        if (i % 3 == 0)
                        {
                            tich *= i;
                        }
                    }
                    Console.WriteLine("Tich cac boi so cua 3 <= n la : {0}" , tich);
                    break;
                // Chon C
                case 'C':                 
                    for (int i = 1; i < n; i++)
                    {
                        sum += 1.0 / i;
                    }
                    Console.WriteLine("Tong 1/n la : {0}", sum);
                    break;
                // Chon D
                case 'D':
                    for (int i = 1; i <= n ; i++)
                    {
                         if(i % 2 == 0)
                         {
                             tich *= i;
                         }                  
                    }
                    Console.WriteLine("Tich cac so chan la: {0} ", tich);
                    break;
                // Chon E
                case 'E':
                    for (int i = 1; i <= n; i++)
                    {
                          tich *= i;
                    }
                    Console.WriteLine("N! = {0}", tich);
                    break;
                // Thong bao nhap sai
                default:
                    Console.WriteLine("Nhap sai yeu cau: ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
