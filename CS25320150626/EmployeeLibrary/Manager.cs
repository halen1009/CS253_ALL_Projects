using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    //Manager經理類別繼承自Employee員工類別
    public class Manager : Employee
    {
        public int Bonus { get; set; }     //加入Bonus獎金屬性

        //1.2讓Manager可Override
        public override int Salary
        {
            get
            {
                return base.Salary;
            }
            set
            {
                if (value < 50000) // 薪水最少20000
                    _salary = 50000;
                else if (value > 100000)// 薪水最多40000
                    _salary = 100000;
                else
                    _salary = value;
            }
        }

        ////2.把ShowTotal()相同的部分移到父類別Employee中，再用base來存取
        //public void ShowTotal()
        //{
        //    Console.WriteLine("實領薪水：{0}", Bonus + Salary);
        //}

        ////2.2改寫自己的ShowTotal()
        //override public void ShowTotal()                      //2.2.1注意要override
        //{
        //    base.ShowTotal();                                 //2.2.2用base.ShowTotal()來使用父類別中的方法
        //    Console.WriteLine("獎金：{0}", Bonus);            //2.2.3Manager自己特有增加的部分
        //    Console.WriteLine("實領薪水：{0}", Bonus + Salary);
        //}

        //5.5Manager裡也使用共通的ToString，並定義自己特殊的地方
        public override string ToString()
        {
            string s = base.ToString();
            s += string.Format("獎金：{0}/ ", Bonus);
            s += string.Format("實領薪水：{0}", Bonus + Salary);
            return s;
        }

        //5.6Manager的ShowTotal()也可以拿掉了，直接繼承父類別的來用
    }
}