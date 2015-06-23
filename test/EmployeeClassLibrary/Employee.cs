using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    internal class Employee
    {
        private int benefit;

        protected int Benefit
        {
            get { return benefit; }
            set
            {
                if (value < 0)
                    benefit = 0;
                else
                    benefit = value;
            }
        }

        private int baseSalary;

        public int BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value < 20000)
                    baseSalary = 20000;
                else if (value > 50000)
                    baseSalary = 50000;
                else
                    baseSalary = value;
            }
        }

        public int Salary
        {
            get { return baseSalary + benefit; }
        }
    }
}