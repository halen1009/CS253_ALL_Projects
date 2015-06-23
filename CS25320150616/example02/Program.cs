using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Employee Jack = new Employee();
            //Console.Write("請輸入底薪($)：");
            //Jack.BaseSalary = int.Parse(Console.ReadLine());
            //Console.Write("請輸入獎金($)：");
            //Jack.Benefit = int.Parse(Console.ReadLine());

            //Console.WriteLine("薪水是：${0}", Jack.Salary);
            ///////////////////////////////////////////////////////////////////////////
            Sales sales = new Sales();
            //sales.                        //可看到新舊共四種屬性，但是prvate的欄位，子類別都看不到
        }                                   //若宣告成protected，則在寫子類別時看的到(Sales)，但Form1下看不到
    }
}