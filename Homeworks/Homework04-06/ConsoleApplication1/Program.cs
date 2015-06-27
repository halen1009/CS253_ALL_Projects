using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double face, cosx, sinx;
            face = int.Parse(Console.ReadLine());
            cosx = Math.Cos((int)(Math.PI / 180 * face));
            sinx = Math.Sin((int)(Math.PI / 180 * face));
            Console.WriteLine("cos({0}) = {1}", face, cosx);
            Console.WriteLine("sin({0}) = {1}", face, sinx);
            Console.ReadKey();
        }
    }
}