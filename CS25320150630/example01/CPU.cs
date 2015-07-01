using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    public class CPU : Product
    {
        public double Frequency { get; set; }

        public CPU(string name, double price, double frequency)
            : base(name, price)                                             //2.1建構子：繼承父類別的建構子，把name、price丟回父類別建構子，用來簡化重複的建構動作
        {
            this.Frequency = frequency;                                     //2.2所以內容只需要初始化自己特有的Frequency
        }

        //public override void SaySomething()                                 //4.2子類別的SaySomething()
        //{
        //    Console.WriteLine(this.Name);
        //    Console.WriteLine("這是CPU類別的SaySomething()");
        //    base.SaySomething();                                            //4.3以下是子類別的SaySomething()特有內容
        //    Console.WriteLine("這是CPU類別的SaySomething()的結尾");
        //}

        //6.2把override拿掉的話，anotherCPU的SaySomething()就會變回Product的SaySomething()了
        public new void SaySomething()                                        //6.2但是這時CPU的SaySomething()會跟Product的SaySomething()衝突，所以這裡CPU的要加上new
        {
            Console.WriteLine(this.Name);
            Console.WriteLine("這是CPU類別的SaySomething()");
            base.SaySomething();                                              //4.3以下是子類別的SaySomething()特有內容
            Console.WriteLine("這是CPU類別的SaySomething()的結尾");
        }
    }
}