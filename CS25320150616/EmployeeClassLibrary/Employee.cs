using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    internal class Employee
    {
        //private int baseSalary;
        //private int salary;
        //private int benefit;

        //public int BaseSalary
        //{
        //    get { return baseSalary; }
        //    set { baseSalary = value; }
        //}

        //public int Salary
        //{
        //    get { return salary = baseSalary + benefit; }
        //}

        //public int Benefit
        //{
        //    get { return benefit; }
        //    set { benefit = value; }
        //}
        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// </summary>

        protected int benefit;                      //宣告成protected，在子類別.cs裡看的到，但在program.cs看不到

        public int Benefit
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
                if (value <= 22000)
                    baseSalary = 22000;
                if (value >= 50000)
                    baseSalary = 50000;
                else
                    baseSalary = value;
            }
        }

        //Salary用方法(屬性)就好
        public int Salary
        {
            get
            {
                return baseSalary + benefit;
            }
        }
    }
}