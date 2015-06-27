using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class Employee
    {// 定義Employee員工類別
        protected int _salary;   // Employee員工類別，有Salary薪水屬性

        virtual public int Salary       // 薪水介於20000~40000之間
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
    }
}