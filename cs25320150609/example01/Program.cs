using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game();
        }

        public static int GetUserInput()
        {
            Console.Write("請輸入你要出的招：(1).剪刀、(2).石頭、(3).布： ");
            return int.Parse(Console.ReadLine());
        }

        public static void GetResult(int 第一個人出的招, int 第二個人出的招)
        {
            //if (第一個人出的招 == 第二個人出的招)
            //    Console.WriteLine("第一個人出{0}，第二個人出{1}，平手", 第一個人出的招, 第二個人出的招);
            //else if (第一個人出的招 == 1 && 第二個人出的招 == 2)
            //    Console.WriteLine("第一個人出{0}，第二個人出{1}，第二個人贏了", 第一個人出的招, 第二個人出的招);
            ////1. 但是onsole.WriteLine("第一個人出{0}，第二個人出{1}，重複了，所以可以檢討修改程式為：

            string message = "第一個人出{0}，第二個人出{1}，結果：{2}";
            //1.1做出結果的模板

            string result;
            if (第一個人出的招 == 第二個人出的招)
            {
                result = "平手";
            }
            else if ((第一個人出的招 == 1 && 第二個人出的招 == 2) || (第一個人出的招 == 2 && 第二個人出的招 == 1))
            {
                result = "石頭贏了";
            }
            else if ((第一個人出的招 == 1 && 第二個人出的招 == 3) || (第一個人出的招 == 3 && 第二個人出的招 == 1))
            {
                result = "剪刀贏了";
            }
            else
            {
                result = "布贏了";
            }

            message = string.Format(message, ConvertToChinese(第一個人出的招), ConvertToChinese(第二個人出的招), result);
            //1.2套入模板

            Console.WriteLine(message);
        }

        public static string ConvertToChinese(int 數字的招)
        {
            string chinese = "";
            if (數字的招 == 1)
                chinese = "剪刀";
            if (數字的招 == 2)
                chinese = "石頭";
            if (數字的招 == 3)
                chinese = "布";
            return chinese;
        }

        public static int GetNpcInput()
        {
            Random random = new Random();
            //2. 用隨機工廠Random製造一個亂數random；new Random()就像是宣告int後的 = 1
            return random.Next(1, 4);
            //2.1 限制隨機範圍1-4 (但不含4)
        }

        public static void Game()
        {
            int person1 = GetUserInput();
            int person2 = GetUserInput();
            //3. 第二個人改用隨機方式
            //int person2 = GetNpcInput();
            GetResult(person1, person2);
        }
    }
}