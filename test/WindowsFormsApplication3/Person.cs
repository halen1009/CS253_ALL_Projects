using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    internal class Person
    {
        public String name;

        //public float positionX, positionY;
        public Position position;

        public Person()
        {
            this.position = new Position();         //??
        }

        public Position MoveForward(float dx)
        {
            this.position.SetX(this.position.GetX() + dx);
            return this.position;                   //??
        }
    }
}