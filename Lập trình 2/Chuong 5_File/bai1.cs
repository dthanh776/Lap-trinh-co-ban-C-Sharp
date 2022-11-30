/*NTMP
 * cd20tt3
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace th5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Nhap n = ");
            int.TryParse(Console.ReadLine(), out n);
            int[] arrA = new int[n];
            try
            {
                using (StreamWriter sw = new StreamWriter("D:\\P\\mangNguyen.txt"))
                {
                    sw.WriteLine(arrA.Length);
                    Random rd = new Random();
                    for (int i = 0; i < arrA.Length; i++)
                    {
                        arrA[i] = rd.Next(0, 50);
                        sw.Write(arrA[i] + ",");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mo file that bai");
                throw;
            }

        }
    }
}
