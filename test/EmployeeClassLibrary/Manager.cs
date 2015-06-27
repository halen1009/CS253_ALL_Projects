using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class Manager : Employee
    {
        public int Bonus { get; set; }     //加入Bonus獎金屬性

        public void ShowTotal()   // 加入顯示實領獎金方法
        {
            Console.WriteLine("實領薪水：{0}", Bonus + Salary);
        }
    }
}