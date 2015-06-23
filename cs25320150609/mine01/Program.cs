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
            game();
        }

        public static int GetUserChoice()
        {
            Console.Write("請選擇：(1).剪刀、(2).石頭、(3).布： ");
            return int.Parse(Console.ReadLine());
        }

        public static void Compete(int user1, int user2)
        {
            int winner = 0;
            string message = "";
            if (user1 == 1 && user2 == 2)
                winner = 2;
            else if (user1 == 1 && user2 == 3)
                winner = 1;
            else if (user1 == 2 && user2 == 1)
                winner = 1;
            else if (user1 == 2 && user2 == 3)
                winner = 2;
            else if (user1 == 3 && user2 == 1)
                winner = 2;
            else if (user1 == 3 && user2 == 2)
                winner = 1;
            else
                winner = 0;
            if (winner == 0)
                message = string.Format("1號選手出{0}、2號選手出{1}，平手", ConvertToChinese(user1), ConvertToChinese(user2));
            else
                message = string.Format("1號選手出{0}、2號選手出{1}，{2}號選手勝出", ConvertToChinese(user1), ConvertToChinese(user2), winner);
            Console.WriteLine("\n" + message);
        }

        public static string ConvertToChinese(int number)
        {
            string chinese = "";
            if (number == 1)
                chinese = "剪刀";
            if (number == 2)
                chinese = "石頭";
            if (number == 3)
                chinese = "布";
            return chinese;
        }

        public static int GetNpcChoice()
        {
            Console.Write("請選擇：(1).剪刀、(2).石頭、(3).布： ");
            Random random = new Random();
            int npcChoice = random.Next(1, 4);
            Console.WriteLine(npcChoice);
            Console.ReadKey();
            return npcChoice;
        }

        public static void game()
        {
            int user1 = GetUserChoice();
            //int user2 = GetUserChoice();
            int user2 = GetNpcChoice();
            Compete(user1, user2);
        }
    }
}