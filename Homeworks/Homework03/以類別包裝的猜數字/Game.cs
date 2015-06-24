using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 以類別包裝的猜數字
{
    internal class Game
    {
        private short[] userInput = new short[4];

        public short[] UserInput
        {
            get { return userInput; }
        }

        private short[] answerNumber = new short[4];

        public short[] AnswerNumber
        {
            get { return answerNumber; }
        }

        private string result;

        public string Result
        {
            get { return result; }
        }

        public Game()
        {
            answerNumber = new short[4];
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                int error = 0;
                do
                {
                    answerNumber[i] = (short)rand.Next(0, 10);
                    error = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (answerNumber[i] == answerNumber[j]) error = 1;
                    }
                } while (error == 1);
            }
        }

        public void GetUserInput()
        {
            char[] inputChars;
            int error;
            do
            {
                do
                {
                    Console.Write("請輸入要猜的數字(四位、不重複)：");
                    inputChars = Console.ReadLine().ToArray();
                } while (inputChars.Length != 4);

                error = 0;
                for (int i = 1; i < inputChars.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (inputChars[i] == inputChars[j]) error = 1;
                    }
                    if (Convert.ToUInt16(inputChars[i]) < 48 || Convert.ToUInt16(inputChars[i]) > 57) error = 1;
                }
            } while (error == 1);
            for (int i = 0; i < 4; i++) userInput[i] = short.Parse(Convert.ToString(inputChars[i]));
        }

        public void Compare()
        {
            int aNo = 0;
            int bNo = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (userInput[i] == answerNumber[j] && i != j) bNo++;
                    else if (userInput[i] == answerNumber[j] && i == j) aNo++;
                }
            }
            result = string.Format("{0}A{1}B", aNo, bNo);
        }
    }
}