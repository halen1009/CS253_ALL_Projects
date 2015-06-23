using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintWelcomeMessage();
            string name = GetUserName();
            ShowMessage(name);
            GetUserGender();
        }

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("歡迎加入C#地獄程式設計班");
        }

        public static string GetUserName()
        {
            Console.Write("請輸入姓名：");
            return Console.ReadLine();
        }

        public static void ShowMessage(string name)
        {
            Console.WriteLine("您好{0}", name);
            Console.WriteLine("我猜{0}一定是個女生", name);
        }

        public static void GetUserGender()
        {
            Console.Write("請問我猜對了嗎 ? (Y/ N)");
            string ans = Console.ReadLine();
            //if (IsYes(ans))
            //  Console.WriteLine("爽");
            //else
            //  Console.WriteLine("哼");
            string bg = IsYes(ans) ? "爽" : "哼";
            Console.WriteLine("555{0}", bg);
        }

        public static bool IsYes(string ans)
        {
            return (ans == "Yes" || ans == "yes" || ans == "y" || ans == "Y");
        }
    }
}