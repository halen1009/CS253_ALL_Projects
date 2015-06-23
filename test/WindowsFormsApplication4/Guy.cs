using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    internal class Guy
    {
        private string name;
        private int cash;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                if (value < 0)
                    cash = 0;
                else
                    cash = value;
            }
        }

        public int GiveCash(int coin)
        {
            if (this.cash >= coin)
            {
                this.cash -= coin;
                return coin;
            }
            else
                return 0;
        }

        public int ReceiveCash(int coin)
        {
            if (coin > 0)
                this.cash += coin;
            return coin > 0 ? coin : 0;
        }
    }
}