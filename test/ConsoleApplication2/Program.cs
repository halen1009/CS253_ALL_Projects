using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car 寶馬 = new Car() { 車主姓名 = "我", 出廠年月 = "19801009", 排氣量 = 9999 };
            Console.WriteLine("這部車的車主是\"{0}\"，出廠年月\"{1}\"，排氣量\"{2}cc.\"。", 寶馬.車主姓名, 寶馬.出廠年月, 寶馬.排氣量);
        }
    }
}