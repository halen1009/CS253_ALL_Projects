using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            game();
        }

        public static int GetUserInput()
        {
            Console.WriteLine("請出招：1.剪刀、2.石頭、3.布");
            return int.Parse(Console.ReadLine());
        }

        public static void GetResult(int p1, int p2)
        {
            string message = "第一個人出{0}，第二個人出{1}；結果：{2}";
            string result;
            if (p1 == p2)
            {
                result = "平手";
            }
            else if ((p1 == 1 && p2 == 2) || (p1 == 2 && p2 == 1))
            {
                result = "石頭贏了";
            }
            else if ((p1 == 2 && p2 == 3) || (p1 == 3 && p2 == 2))
            {
                result = "布贏了";
            }
            else result = "剪刀贏了";
            message = string.Format(message, ConvertToText(p1), ConvertToText(p2), result);
            Console.WriteLine(message);
        }

        public static string ConvertToText(int userInput)
        {
            string inputText = "";
            switch (userInput)
            {
                case 1:
                    inputText = "剪刀";
                    break;

                case 2:
                    inputText = "石頭";
                    break;

                case 3:
                    inputText = "布";
                    break;
            }
            return inputText;
        }

        public static int GetNpcInput()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        private static void game()
        {
            int p1 = GetUserInput();
            int p2 = GetUserInput();
            //int p2 = GetNpcInput();
            GetResult(p1, p2);
        }
    }
}