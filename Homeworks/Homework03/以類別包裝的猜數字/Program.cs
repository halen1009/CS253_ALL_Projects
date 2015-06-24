using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 以類別包裝的猜數字
{
    internal class Program
    {
        private static Game game = new Game();

        private static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            int i = 0;
            do
            {
                i++;
                Console.Write("第{0}次，", i);
                game.GetUserInput();
                game.Compare();
                Console.WriteLine(game.Result);
            } while (game.Result != "4A0B");

            Console.WriteLine("Bingo!" + " 共猜了{0}次", i);
        }
    }
}