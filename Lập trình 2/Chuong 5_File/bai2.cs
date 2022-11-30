/* Nguyen thi my phuong
 * cd20tt3
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            try
            {
                using (StreamReader sr = new StreamReader("D:\\P\\TinhTong.txt"))
                {
                    int.TryParse(sr.ReadLine(), out n);
                    int[] arrA = new int[n];
                    for (int i = 0; i < arrA.Length; i++)
                    {
                            int.TryParse(sr.ReadLine(), out arrA[i]);
                    }
                    Console.WriteLine($"Tong cac pt tai vi tri chan la: {TinhTong(arrA)}");
                    Console.WriteLine($"Tomg cac pt la snt: {TinhTongSNT(arrA)}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mo file that bai ");
                throw;
            }
        }
        // 
        static int TinhTongSNT(int [] arrA)
        {
            int s = 0;
            for (int i = 0; i < arrA.Length; i++)
            {
                if(KtraSNT(arrA[i]) == true)
                {
                    s += arrA[i];
                }
            }
            return s;
        }
        static bool KtraSNT(int a)
        {
            if (a < 2)
                return false;
            for (int i = 2; i < a; i++)
            {
                if ( a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int TinhTong( int []arrA)
        {
            int tong = 0;
            for (int i = 0; i < arrA.Length; i++)
            {
                if ( i % 2 == 0)
                {
                    tong += arrA[i];
                }
            }
            return tong;
        }
       
    }
}
