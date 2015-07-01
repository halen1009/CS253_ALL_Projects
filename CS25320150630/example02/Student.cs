using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02
{
    internal class Student : IComparable<Student>
    {
        public string Name { get; set; }

        private string _比哪科;

        public string 比哪科
        {
            get { return _比哪科; }
            set { _比哪科 = value; }
        }

        private int _國文;

        public int 國文
        {
            get { return _國文; }
            set { _國文 = value; }
        }

        private int _英文;

        public int 英文
        {
            get { return _英文; }
            set { _英文 = value; }
        }

        private int _數學;

        public int 數學
        {
            get { return _數學; }
            set { _數學 = value; }
        }

        private int _社會;

        public int 社會
        {
            get { return _社會; }
            set { _社會 = value; }
        }

        private int _自然;

        public int 自然
        {
            get { return _自然; }
            set { _自然 = value; }
        }

        public int CompareTo(Student other)
        {
            switch (比哪科)
            {
                case "國文":
                    if (this._國文 > other._國文)
                        return 1;
                    else if (this._國文 > other._國文)
                        return 0;
                    else return -1;

                case "英文":
                    if (this._英文 > other._英文)
                        return 1;
                    else if (this._英文 > other._英文)
                        return 0;
                    else return -1;

                case "數學":
                    if (this._數學 > other._數學)
                        return 1;
                    else if (this._數學 > other._數學)
                        return 0;
                    else return -1;

                case "社會":
                    if (this._社會 > other._社會)
                        return 1;
                    else if (this._社會 > other._社會)
                        return 0;
                    else return -1;

                case "自然":
                    if (this._自然 > other._自然)
                        return 1;
                    else if (this._自然 > other._自然)
                        return 0;
                    else return -1;
            }
            return 0;
        }
    }
}