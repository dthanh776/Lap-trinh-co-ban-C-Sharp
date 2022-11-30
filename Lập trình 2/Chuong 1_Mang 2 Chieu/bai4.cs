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
            string[,] Cell =
            {
                { "   ", "   ", "   " },
                { "   ", "   ", "   " },
                { "   ", "   ", "   " },
            };
            int i = 0; int j = 0; int count = 0;
            Output(Cell);
            while (true)
            {
                if(count == Cell.Length - 1)
                {
                    Console.WriteLine("Hoa, choi lai");
                    break;
                }

                while (true)
                {
                Console.WriteLine("Nhap vao toa do o ma playerX chon:");
                i = int.Parse(Console.ReadLine());
                j = int.Parse(Console.ReadLine());
                    if (Cell[i, j] != " X " && Cell[i, j] != " O ")
                    {
                        Console.Clear();
                        Player1(Cell, i, j);
                        Output(Cell);
                        count++;
                        break;
                    }
                    else Console.WriteLine("O da danh roi, vui long chon o khac");
                }
                if (Gamex(Cell) == 0)
                { 
                    Console.Write("Congratulation PlayerX");
                    break;
                }
                Console.WriteLine("Nhap vao toa do o ma playerO chon:");
                while (true)
                {
                    Console.WriteLine("Nhap vao toa do o ma playerX chon:");
                    i = int.Parse(Console.ReadLine());
                    j = int.Parse(Console.ReadLine());
                    if (Cell[i, j] != " X " && Cell[i, j] != " O ")
                    {
                        Console.Clear();
                        Player2(Cell, i, j);
                        Output(Cell);
                        count++;
                        break;

                    }
                    else Console.WriteLine("O da danh roi, vui long chon o khac");
                }
                if (Gamex(Cell) == 1)
                {
                    Console.Write("Congratulation PlayerO");
                    break;
                }
            }
            
           
            Console.ReadKey();
        }
        static void Output(string[,] n)
        {
            for(int i = 0; i < n.GetLength(0); i++)
            {
                Console.Write(" |");
                for(int j = 0; j < n.GetLength(1); j++)
                {
                    Console.Write("{0}|", n[i,j]);
                }
                Console.WriteLine();
                Console.WriteLine(" -------------");
            }
        }
        static void Player1(string[,] n, int i , int j)
        {
            Console.WriteLine("\tPlayerX turn");
            do
            {
                n[i, j] = "X";
            } while (n[i, j] != "X");
            if (n[i, j] == "X") n[i, j] = " X ";  
        }
        static void Player2(string[,] n, int i, int j)
        {
            Console.WriteLine("\tPlayerX turn");
            do
            {
                n[i, j] = "O";
            } while (n[i, j] != "O");
            if (n[i, j] == "O") n[i, j] = " O ";
        }
        static int Gamex(string[,] n)
        {
            for (int i = 0; i < n.GetLength(0); i++)
            {
                if (n[i, 0] == " X " && n[i, 1] == " X " && n[i, 2] == " X ") return 0;
                else if (n[i, 0] == " O " && n[i, 1] == " O " && n[i, 2] == " O ") return 1;
            }
            for (int i = 0; i < n.GetLength(1); i++)
            {
                if (n[0, i] == " X " && n[1, i] == " X " && n[2, i] == " X ") return 0;
                else if (n[0, i] == " O " && n[1, i] == " O " && n[2, i] == " O ") return 1;
            }
            if (n[0, 0] == " X " && n[1, 1] == " X " && n[2, 2] == " X ") return 0;
            else if (n[0, 0] == " O " && n[1, 1] == " O " && n[2, 2] == " O ") return 1;
            else if (n[0, 2] == " X " && n[1, 1] == " X " && n[2, 0] == " X ") return 0;
            else if (n[0, 2] == " O " && n[1, 1] == " O " && n[2, 0] == " O ") return 1;
            else return 2;
        }
    } 
}
