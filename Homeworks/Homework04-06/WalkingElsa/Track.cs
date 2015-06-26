using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingElsa
{
    internal class Track
    {
        public Graphics graphic;
        public Pen pen = new Pen(Color.Cyan, 2);
        public List<Point> points = new List<Point>();
    }
}