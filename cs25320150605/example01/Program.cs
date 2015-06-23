using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Moveforward(100);
            TurnRight(90);
            Moveforward(100);
            TurnRight(90); 
            Moveforward(100);
            TurnRight(90);
            Moveforward(100);
            TurnRight(90);
            Console.Read();
        }
            public static void Moveforward(int pixel)
            {
                Console.WriteLine("Elsa向前走了{0}像素", pixel);
            }

            public static void TurnRight(int degree)
            {
                Console.WriteLine("Elsa向右轉了{0}度", degree);
            }

            public static void TurnLeft(int degree)
            {
                Console.WriteLine("Elsa向左轉了{0}度", degree);
            }

        
    }
}
