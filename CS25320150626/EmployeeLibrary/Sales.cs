using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    ////我的
    //public class Sales : Employee
    //{
    //    private int salesMoney;

    //    public int SalesMoney
    //    {
    //        get { return salesMoney; }
    //        set
    //        {
    //            salesMoney = value;
    //            Bonus = SalesMoney * 5 / 100;
    //        }
    //    }

    //    public int Bonus { get; set; }

    //    public void ShowTotal()   // 加入顯示實領獎金方法
    //    {
    //        Console.WriteLine("實領薪水：{0}", Bonus + Salary);
    //    }
    //}

    public class Sales : Employee
    {
        public int Performance { get; set; }    //匿名變數，暫存

        //0.改Bonus，不需要set所以拿掉；只做get: Bonus = 1% Performance
        public int Bonus
        {
            get { return (int)(Performance * 0.01); }
        }

        //1.3Sales的override底薪
        public override int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = 22000;
            }
        }

        //2.參考Manager的ShowTotal()改法
        //override public void ShowTotal()  //3.1用overrride就不需重打
        //{
        //    //base.ShowTotal();
        //    //Console.WriteLine("業績：{0}", Performance);//3.2
        //    //Console.WriteLine("獎金：{0}", Bonus);//3.3
        //    //Console.WriteLine("實領薪水：{0}", Bonus + Salary);

        //    ////3.3之後用ToString()藏起來後，就可以改成
        //    Console.WriteLine(this.ToString());
        //}

        ////3.反正ShowTotal是顯示一段文字，所以改寫ToString()
        //public override string ToString()
        //{
        //    return base.ToString();
        //}
        //////3.改成:
        //public override string ToString()
        //{
        //    string s = string.Empty;//3.1用空白字串當s的起始值，相當於string s = ""，這是高級寫法
        //    s += string.Format("業績：{0}", Performance);//3.2把剛剛Console.WriteLine()的東西都貼上來，改成string.Format()
        //    s += string.Format("獎金：{0}", Bonus);//3.2
        //    s += string.Format("實領薪水：{0}", Bonus + Salary);//3.2
        //    return s;
        //}
        ////3.3之後的ToString()可以在5.再度改寫簡化

        //4.所以ShowTotal()可以簡化:
        //override public void ShowTotal()  //3.1用overrride就不需重打
        //{
        //    ////4.1之後用ToString()藏起來後，就可以改成
        //    Console.WriteLine(this.ToString());
        //}
        //4.2但是簡化後的ShowTotal()又有重複性，所以丟到父類別Employee裡

        //5.簡化ToString，先複製丟到父類別裡
        public override string ToString()               //5.3記得要overrride
        {
            string s = base.ToString();                 //5.4用base.ToString()來使用父類別裡共通的部分
            s += string.Format("業績：{0}/ ", Performance);
            s += string.Format("獎金：{0}/ ", Bonus);
            s += string.Format("實領薪水：{0}", Bonus + Salary);
            return s;
        }
    }
}