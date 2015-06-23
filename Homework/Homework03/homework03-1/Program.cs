using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintSquareX();
            PrintHollowSquareX();
            PrintPatternSquareX();
            PrintCrossX();
        }

        //1. 邊長X的正方形
        public static void PrintSquareX()
        {
            int squareLong = 0;
            Console.Write("1. 請輸入正方形邊長X：");
            squareLong = int.Parse(Console.ReadLine());
            for (int i = 1; i <= squareLong; i++)
            {
                for (int j = 1; j <= squareLong; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //2. 空心正方形
        public static void PrintHollowSquareX()
        {
            int squareLong = 0;
            Console.Write("2. 請輸入空心正方形邊長X：");
            squareLong = int.Parse(Console.ReadLine());
            for (int i = 1; i <= squareLong; i++)
            {
                for (int j = 1; j <= squareLong; j++)
                {
                    if ((i > 1 && i < squareLong) && (j > 1 && j < squareLong)) Console.Write(" ");
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //3. 格紋正方形
        public static void PrintPatternSquareX()
        {
            int squareLong = 0;
            do
            {
                Console.Write("3. 請輸入格紋正方形邊長X(奇數)：");
                squareLong = int.Parse(Console.ReadLine());
            } while (squareLong % 2 == 0);
            for (int i = 1; i <= squareLong; i++)
            {
                for (int j = 1; j <= squareLong; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0) Console.Write(" ");
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //4. 十字架
        public static void PrintCrossX()
        {
            int squareLong = 0;
            do
            {
                Console.Write("4. 請輸入十字架長X(奇數)：");
                squareLong = int.Parse(Console.ReadLine());
            } while (squareLong % 2 == 0);
            for (int i = 1; i <= squareLong; i++)
            {
                for (int j = 1; j <= squareLong; j++)
                {
                    if (i == (squareLong + 1) / 2 || j == (squareLong + 1) / 2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}