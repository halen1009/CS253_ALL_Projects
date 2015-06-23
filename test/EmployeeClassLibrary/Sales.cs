using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    internal class Sales : Employee
    {
        public int 業績 { get; set; }

        public void SetBenefit(int money)
        {
            this.Benefit = money;
        }
    }
}