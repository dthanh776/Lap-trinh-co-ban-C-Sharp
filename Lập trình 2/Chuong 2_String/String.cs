using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        //Cau 2
        static int DemChuHoa(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    dem++;
                }
            }
            return dem;
        }
        // Cau 3
        static int DemChuSo(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    dem++;
                }
            }
            return dem;
        }
        // Cau 4
        static int KiemTraChar(string s, char kiTu)
        {

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == kiTu)
                    return i;
            }
            return -1;
        }
        // Cau 5
        static void DaoNguocChuoi(string s)
        {
            string[] arr = s.Split(' ');
            for (int i = arr.Length - 1; i >= 0; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        // Cau 6
        static int DemSoTu(string s, string key)
        {
            string[] arr = s.Split(' ');
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    dem++;
                }
            }
            return dem;
        }
        // Cau 7
        static bool SoSanhChuoi(string s1, string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            if (s1 == s2)
            {
                return true;
            }
            return false;
        }
        //Cau 8
        static void TaoEmail()
        {
            Console.WriteLine("Nhap email bat ki: ");
            string str = Console.ReadLine();
            string email;

            str = str.Replace(" ", "");
            str = str.ToLower();
            email = str + "@gmail.com";
            Console.WriteLine($"Email la: " + email);
        }

        //Cau 9
        static bool KiemTraEmail(string s)
        {

            char[] arr = { ' ', '#', '$', '%', '^', '&' };
            if (s.IndexOf('@') != -1 && s.IndexOfAny(arr) == -1)
                return true;
            return false;
        }

        // Cau 10
        static bool KiemTraChuoi(string s)
        {
            if (s[0] == ' ' || s[s.Length - 1] == ' ' || s[0] < 'A' || s[0] > 'Z' || s.IndexOf("  ") != -1)
                return false;
            return true;
        }

        // Cau 11
        static void TaoUserPass(string s)
        {
            // Tao user
            string[] arr = s.Split(' ');
            string user = arr[arr.Length - 1] + arr[0];

            Console.WriteLine("UserName: {0}", user);

            string pass = null;
            for (int i = 0; i < arr.Length; i++)
            {
                pass = pass + arr[i][0];
            }
            Random rd = new Random();
            pass = pass + rd.Next(100000, 999999);
            Console.WriteLine("Password: {0}", pass.ToLower());
        }

        // Cau 12
        static bool KiemTraChuoiHopLe(string s)
        {
            char[] so = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                if (s.IndexOfAny(so) != -1 || s[0] == ' ' || s[s.Length - 1] == ' ' || s[0] < 'A' || s[0] > 'Z' || s.IndexOf("  ") != -1)
                return false;
            return true;
        }
        static void XuatDanhSach(string [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void NhapDanhSach(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Nhap ho va ten thu {i + 1}: ");
                    arr[i] = Console.ReadLine();
                } while (KiemTraChuoiHopLe(arr[i]) == false);
            }
        }
        static void Main(string[] args)
        {

            // Console.WriteLine("Nhap chuoi bat ki: ");
            //string s = Console.ReadLine();

            //// Cau 2
            //Console.WriteLine($"(Co {DemChuHoa(s)} ki tu IN HOA trong chuoi" );

            ////Cau 3
            //Console.WriteLine($"(Co {DemChuSo(s)} ki tu Chu so trong chuoi");

            //// Cau 4 
            //Console.WriteLine("Nhap vao ki tu" );
            //char kiTu = char.Parse(Console.ReadLine());
            //int kq = KiemTraChar(s, kiTu);
            //if (kq != -1)
            //{
            //    Console.WriteLine($"Co ton tai ki tu {kiTu}, tai vi tri {kq}");
            //}
            //else
            //{
            //    Console.WriteLine($"Khong ton tai ki tu {kiTu} ");
            //}

            ///// Cau 5
            //DaoNguocChuoi(s);

            //// Cau 6
            //Console.WriteLine("Nhap vao tu can dem: ");
            //string key = Console.ReadLine();
            //Console.WriteLine($"So tu {key} co trong chuoi la {DemSoTu(s,key)}");

            //// Cau 7 
            //Console.Write("Nhap chuoi 1: ");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Nhap chuoi 2: ");
            //string s2 = Console.ReadLine();
            //if (SoSanhChuoi(s1,s2) == true)
            //{
            //    Console.WriteLine("Hai chuoi giong nhau");
            //}
            //else
            //{
            //    Console.WriteLine("Hai chuoi KHAC nhau"); 
            //}

            //Cau 8
            //TaoEmail();

            // Cau 9
            //Console.WriteLine("Nhap email: ");
            //string s3 = Console.ReadLine();
            //if (KiemTraEmail(s3) == true)
            //{
            //    Console.Write("Email hop le");
            //}
            //else
            //{
            //    Console.Write("Email khong hop le");
            //}

            // Cau 10
            //Console.WriteLine("Nhap chuoi bat ki: ");
            //string s = Console.ReadLine();
            //if(KiemTraChuoi(s) == true )
            //{
            //    Console.WriteLine($"Chuoi {s} la chuoi hop le");
            //}
            //else
            //{
            //    Console.WriteLine($"Chuoi {s} la chuoi KHONG hop le");
            //}

            // Cau 11
            //Console.WriteLine("Nhap vao ho va ten: ");
            //string s = Console.ReadLine();
            //TaoUserPass(s);


            // Cau 12
            //Console.WriteLine("Nhap so luong ho ten trong danh sach: " );
            //int n = int.Parse(Console.ReadLine());
            //string[] arr = new string[n];
            //NhapDanhSach(arr);
            //Array.Sort(arr);
            //XuatDanhSach(arr);

            Console.ReadKey();
        }
    }
}
