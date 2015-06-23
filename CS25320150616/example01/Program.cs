using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Car car = new Car();
            //Console.Write("請輸入車牌號碼：");
            //car.Id = Console.ReadLine();
            //Console.Write("請輸入製造日期：");
            //car.ProducedDate = Console.ReadLine();

            //Console.WriteLine("車牌號碼：{0}； 製造日期：{1}", car.Id, car.ProducedDate);
            ////////////////////////////////////////////////////////////////////////////////////

            Car 寶馬 = new Car();
            寶馬.車主姓名 = "我";
            寶馬.排氣量 = 10000;
            Console.WriteLine("這部車的車主是：{0}，排氣量是：{1}", 寶馬.車主姓名, 寶馬.排氣量);
        }
    }
}