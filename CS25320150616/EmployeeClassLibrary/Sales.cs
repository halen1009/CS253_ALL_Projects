using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    internal class Sales : Employee
    {
        public int 業績 { get; set; }                 //public欄位不受保護，所以有特別的簡易存取子

        //可以看到父類別的protected欄位benefit
        //但是看不到父類別的private欄位baseSalary
    }
}