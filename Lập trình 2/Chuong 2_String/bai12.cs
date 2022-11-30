using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] list = new string[n];
            Input(list);
            
            string[] list1 = sort(list);
            Out(list1);
            Console.ReadKey();
        }
        static void Input(string[] n)
        {
            int length = n.Length;
            for (int i = 0; i < length; i++)
            {
                n[i] = Console.ReadLine();
            }
        }
        static string[] sort(string[] list)
        {
            int length = list.Length;
            string temp;
            for (int i = 0; i < length; i++)
            {
                 
                for (int j = i+1; j < length-1; j++)
                {
                    if(list[i][list[i].LastIndexOf(' ')+1] > list[j][list[j].LastIndexOf(' ') + 1])
                    {
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list; 
        }
        static void Out(string[] n)
        {
            int length = n.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
