using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("a / b = {0}", Divide(1.0f, 3f));\
            double a = 10.00000000001;
            double b = 10.00000000000001;
            double c = 100.00000000000001;
            double d = 100.00000000000000001;
            Console.WriteLine((a - b) / (c - d));
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static float Divide(float a, float b)
        {
            return a / b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}