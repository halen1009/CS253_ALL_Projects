using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    internal class Position
    {
        //public float x;
        //public float y;

        private float x;
        private float y;

        public float GetX()
        {
            return this.x;
        }

        public void SetX(float value)
        {
            if (this.x <= -200)
                this.x = -200;
            else if (this.x >= 200)
                this.x = 200;
            else this.x = value;
        }

        public float Y
        {
            get { return this.y; }
            set
            {
                if (value <= -200)
                    this.y = -200;
                else if (value >= y)
                    this.y = 200;
                else this.y = value;
            }
        }
    }
}