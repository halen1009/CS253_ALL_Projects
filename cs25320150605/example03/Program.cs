using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //1-4.
            Console.WriteLine("a + b = {0}", Add(1.5, 2));

            //2-4.
            Console.WriteLine("a / b = {0}", Divide(1.0, 3));
            //2-5. 小心除法整數除整數，1/3會等於0，要用Divide(1.0, 3);

            /*
            double a = 0.000000001;
            double b = 0.000000000001;
            double c = 0.000000000001;
            double d = 0.000000000000001;
            //4.理論上(a-b) / (c-d)要等於1000
            Console.WriteLine((a - b) / (c - d));
            */
            //但是
            double a = 10.00000000001;
            double b = 10.00000000000001;
            double c = 100.00000000000001;
            double d = 100.00000000000000001;
            Console.WriteLine((a - b) / (c - d));
            //會等於1005，因為c、d很接近，境確度問題，小數點後超過15位是亂數；請用decimal
        }

        //1-1. 加法功能，要在main用(int)1.5+..
        static public int Add(int a, int b)
        {
            return a + b;
        }

        //1-2. float版本，要在main用1.5f
        static public float Add(float a, float b)
        {
            return a + b;
        }

        //1-3. double版本，main連f都不用
        static public double Add(double a, double b)
        {
            return a + b;
        }

        //1-5. 寫三種版本的add，就是多型，會自動選擇適用的

        //2-1. 除法功能，要在main用(int)1.5+..，但會出現1/3 = 0
        static public int Divide(int a, int b)
        {
            return a / b;
        }

        //2-2. float版本的除法
        static public float Divide(float a, float b)
        {
            return a / b;
        }

        //2-3. double版本的除法
        static public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}