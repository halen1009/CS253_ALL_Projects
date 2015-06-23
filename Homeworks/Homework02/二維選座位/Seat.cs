using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二維選座位
{
    internal class Seat
    {
        private System.Windows.Forms.PictureBox pictureBox;

        public System.Windows.Forms.PictureBox PictureBox
        {
            get { return pictureBox; }
            set { pictureBox = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public void SetSeatImage()
        {
            switch (this.status)
            {
                case 0:
                    this.PictureBox.Image = global::二維選座位.Properties.Resources.seat_unavail;
                    break;

                case 1:
                    this.PictureBox.Image = global::二維選座位.Properties.Resources.seat_avail;
                    break;

                case 2:
                    this.PictureBox.Image = global::二維選座位.Properties.Resources.seat_select;
                    break;
            }
        }
    }
}