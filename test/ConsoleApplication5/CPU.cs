using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class CPU : Product1
    {
        public double Frequency { get; set; }

        public CPU(string name, double price, double frequency)
            : base(name, price)
        {
            Frequency = frequency;
        }

        new public void SaySomething()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine("這是CPU類別的SaySomething()");
            base.SaySomething();
            Console.WriteLine("這是CPU類別的SaySomething()的結尾");
        }
    }
}