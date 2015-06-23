using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintWelcomeMessage();
            string name = GetUserName();
            ShowMessage(name);
            //或ShowMessage(string name = GetUserName());
            //Console.Read();

            GetUserGender();
        }

        //印出歡迎訊息的功能
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("歡迎大家加入地獄C#班");
        }

        //要使用者輸入名子，以string當作輸出
        public static string GetUserName()
        {
            Console.Write("請輸入您的大名：");
            return Console.ReadLine();
        }

        //輸出包含名子的訊息，以string當作輸入
        public static void ShowMessage(string name)
        {
            Console.WriteLine("{0}, 您好", name);
            Console.WriteLine("我猜{0}您一定是個女生", name);
        }

        //練習IF的使用
        public static void GetUserGender()
        {
            Console.Write("請問我猜對了嗎?(yes/no)");
            string ans = Console.ReadLine();
            //存你輸入的答覆
            ////1.
            //if (ans == "yes" || ans == "Yes" || ans == "Y" || ans == "y")

            ////2. 用包好的
            //if(IsYes(ans))
            //    Console.WriteLine("我猜對了，爽!");
            //else
            //    Console.WriteLine("其實我故意猜錯的");

            //3. 用三元運算子
            //Console.WriteLine(IsYes(ans) ? "我猜對了，爽!" : "其實我故意猜錯的");
            //或
            string bingo = IsYes(ans) ? "爽!" : "我故意的";
            Console.WriteLine("{0}", bingo);
        }

        //包起來
        public static bool IsYes(string ans)
        {
            return ans == "yes" || ans == "Yes" || ans == "Y" || ans == "y";
        }
    }
}