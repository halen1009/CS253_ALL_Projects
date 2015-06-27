using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {   // 定義Employee員工類別
        //private int _salary;   // Employee員工類別，有Salary薪水屬性
        //1.為了把需要在Sales、Manager做微調判斷，所以_salary的改成protected
        protected int _salary;

        //public int Salary       // 薪水介於20000~40000之間

        //1.1並且把存取子改成virtua，讓l繼承者有權力修改
        virtual public int Salary
        {
            get { return _salary; }
            set
            {
                if (value < 20000) // 薪水最少20000
                    _salary = 20000;
                else if (value > 40000)// 薪水最多40000
                    _salary = 40000;
                else
                    _salary = value;
            }
        }

        //2.1把ShowTotal()重複的部分移到父類別來(virtual、底薪、去Bonus)
        //virtual public void ShowTotal()
        //{
        //    Console.WriteLine("底薪：{0}" + Salary);
        //}

        //4.3簡化後丟回來的ShowTotal()，但是不需要virtual、及override，因為大家都一樣
        public void ShowTotal()
        {
            Console.WriteLine(this.ToString());
        }

        //5.1ToString()共同的部分丟到父類別裡
        public override string ToString()               //5.2就算是附類別，也要記得用override，因為ToString()已經存在了
        {
            string s = string.Empty;
            s += string.Format("薪水：{0}/ ", Salary);
            return s;
        }
    }
}