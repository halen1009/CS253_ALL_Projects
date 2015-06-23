using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace example03
{
    public class Guy
    {
        private int cash;
        private string name;

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

        public int GiveCash(int coin)
        {
            if (this.cash >= coin)
            {
                this.cash -= coin;
                return coin;
            }
            else return 0;              //return是送出的錢
        }

        public int ReceiveCash(int coin)
        {
            if (coin > 0)
            {
                this.cash += coin;
                //    return coin;
            }
            //else return 0;                  //return是報告收到的錢
            return coin > 0 ? coin : 0;       //用三元運算子判斷是要傳回0還是coin
        }
    }
}