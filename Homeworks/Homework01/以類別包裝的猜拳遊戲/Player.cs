using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 以類別包裝的猜拳遊戲
{
    internal class Player
    {
        private int playerNo;

        public int PlayerNo
        {
            get { return playerNo; }
            set { playerNo = value; }
        }

        private int hand;           //hand: 1.剪刀、2.石頭、3.布

        public int Hand
        {
            get { return hand; }
            set
            {
                if (value <= 3) hand = value;
                else hand = 0;
            }
        }

        public void PlayerInput()
        {
            Console.Write("請{0}號選手選擇(0.隨機、1.剪刀、2.石頭、3.布): ", playerNo + 1);
            do
            {
                int userSelection = int.Parse(Console.ReadLine());
                if (userSelection < 0 || userSelection > 3)
                {
                    Console.Write("輸入錯誤，請重新選擇(0.隨機、1.剪刀、2.石頭、3.布): ");
                    continue;
                }
                if (userSelection == 0)
                {
                    Random rnd = new Random();
                    userSelection = rnd.Next(1, 4);
                }
                hand = userSelection;
                break;
            } while (true);
        }

        public string ConvertToChinese(int number)
        {
            switch (number)
            {
                case 1: return "剪刀";
                case 2: return "石頭";
                case 3: return "布";
            }

            return "";
        }
    }
}