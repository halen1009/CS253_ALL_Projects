using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            short[] answer = GetRandomNumber();
            short[] userInput;
            int i = 0;
            do
            {
                i++;
                Console.Write("第{0}次，", i);
                userInput = GetUserInput();
                Console.WriteLine(GetResult(userInput, answer));
                //Console.WriteLine(string.Format("{0}{1}{2}{3}", userInput[0], userInput[1], userInput[2], userInput[3]));                          //////
                //Console.WriteLine(string.Format("{0}{1}{2}{3}", answer[0], answer[1], answer[2], answer[3]));                          //////
            } while (GetResult(userInput, answer) != "4A0B");
            Console.WriteLine("Bingo!" + " 共猜了{0}次", i);
        }

        public static short[] GetRandomNumber()
        {
            short[] randomNumber = { 0, 0, 0, 0 };
            Random rand = new Random();
            randomNumber[0] = (short)rand.Next(0, 10);
            for (int i = 1; i < 4; i++)
            {
                int error = 0;
                do
                {
                    randomNumber[i] = (short)rand.Next(0, 10);
                    error = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (randomNumber[i] == randomNumber[j]) error = 1;
                    }
                } while (error == 1);
            }
            return randomNumber;
        }

        public static short[] GetUserInput()
        {
            string inputString;
            char[] inputChars;
            short[] inputIntegers = { 0, 0, 0, 0 };
            int error = 1;
            do
            {
                Console.Write("請輸入要猜的數字(四位、不重複)：");
                inputString = Console.ReadLine();
                inputChars = inputString.ToArray();

                error = 0;
                if (inputChars.Length != 4) error = 1;
                for (int i = 1; i < inputChars.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (inputChars[i] == inputChars[j]) error = 1;
                    }
                    if (Convert.ToUInt16(inputChars[i]) < 48 || Convert.ToUInt16(inputChars[i]) > 57) error = 1;
                }
            } while (error == 1);
            for (int i = 0; i < 4; i++) inputIntegers[i] = short.Parse(Convert.ToString(inputChars[i]));
            return inputIntegers;
        }

        public static string GetResult(short[] user, short[] answer)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (user[i] == answer[j] && i != j) b++;
                    else if (user[i] == answer[j] && i == j) a++;
                }
            }
            return string.Format("{0}A{1}B", a, b);
        }
    }
}