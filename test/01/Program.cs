using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MoveForward(100);
            TurnLight(90);
            MoveForward(100);
            TurnLight(90);
        }

        public static void MoveForward(int pixel)
        {
            Console.WriteLine("Elsa向前走了{0}像素", pixel);
        }

        public static void TurnRight(int degree)
        {
            Console.WriteLine("Elsa巷右轉了{0}度", degree);
        }

        public static void TurnLight(int degree)
        {
            Console.WriteLine("Elsa巷左轉了{0}度", degree);
        }
    }
}