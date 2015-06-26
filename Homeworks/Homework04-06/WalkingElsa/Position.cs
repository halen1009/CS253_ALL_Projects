using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingElsa
{
    internal class Position
    {
        private int x;

        public int X
        {
            get { return x; }
            set
            {
                if (value <= 12)
                    x = 12;
                if (value >= 2000)
                    x = 2000;
                else x = value;
            }
        }

        private int y;

        public int Y
        {
            set
            {
                if (value <= 12)
                    this.y = 12;
                if (value >= 2000)
                    this.y = 2000;
                else this.y = value;
            }
            get { return this.y; }
        }
    }
}