using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace hello
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //This is a test program.
            string str1;
            int price = 120, qty = 50;
            //印出資料後游標往下一行移
            Console.WriteLine();
            Console.WriteLine(" 碩博點腦圖書廣場");
            Console.WriteLine("=======================");
            Console.Write("1. 書名：");
            str1 = Console.ReadLine();
            Console.Write("2. 售價：");
            price = int.Parse(Console.ReadLine());
            Console.Write("3. 數量：");
            qty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=======================");
            Console.Write("4. 金額：{0}", price * qty);
            Console.Read();
        }
    }
}