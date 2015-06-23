using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    internal class Car
    {
        private string _車主姓名;

        public string 車主姓名
        {
            get { return _車主姓名; }
            set { _車主姓名 = value; }
        }

        private string _出廠年月;

        public string 出廠年月
        {
            get { return _出廠年月; }
            set { _出廠年月 = value; }
        }

        private int _排氣量;

        public int 排氣量
        {
            get { return _排氣量; }
            set
            {
                if (value < 50)
                    _排氣量 = 50;
                else if (value > 5000)
                    _排氣量 = 5000;
                else
                    _排氣量 = value;
            }
        }
    }
}