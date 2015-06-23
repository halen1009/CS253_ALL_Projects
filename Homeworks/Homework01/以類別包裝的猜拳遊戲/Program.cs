using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 以類別包裝的猜拳遊戲
{
    internal class Program
    {
        private static int people = 0;
        private static Player[] player;

        private static void Main(string[] args)
        {
            do
            {
                Console.Write("請輸入參加人數: ");
                people = int.Parse(Console.ReadLine());
            } while (people < 2);

            player = new Player[people];

            for (int index = 0; index < people; index++)
            {
                player[index] = new Player() { PlayerNo = index, Hand = 0 };
                player[index].PlayerInput();
            }

            Compete();
        }

        public static void Compete()                 //回傳winner為陣列第i人，-1表示平手
        {
            int winner = -1;
            for (int index = 0; index < people; index++)
            {
                bool iWin = true;
                for (int index2 = 0; index2 < people; index2++)
                {
                    if (player[index2].Hand >= player[index].Hand && index2 != index)
                        iWin = false;
                    else if (player[index2].Hand == 1 && player[index].Hand == 3)
                        iWin = false;
                    if (player[index].Hand == 1 && player[index2].Hand == 3)
                        iWin = true;
                }
                if (iWin == true) winner = index;
            }

            for (int index = 0; index < people; index++)
            {
                Console.WriteLine("{0}號選手出{1}", player[index].PlayerNo + 1, player[index].ConvertToChinese(player[index].Hand));
            }

            if (winner > -1)
                Console.WriteLine("\n{0}號參賽者勝出!", winner + 1);
            else Console.WriteLine("\n平手!");
        }
    }
}