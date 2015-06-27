using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class Sales : Employee
    {
        public int Performance { get; set; }

        public int Bonus { get { return (int)(Performance * 0.01); } }     //加入Bonus獎金屬性

        public void ShowTotal()   // 加入顯示實領獎金方法
        {
            Console.WriteLine("實領薪水：{0}", Bonus + Salary);
        }

        public override int Salary
        {
            get
            {
                return base.Salary;
            }
            set
            {
                base.Salary = value;
            }
        }
    }
}