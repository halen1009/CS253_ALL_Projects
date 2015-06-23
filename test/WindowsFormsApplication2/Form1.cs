using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int[] status = new int[9];

        public Form1()
        {
            InitializeComponent();
            InitializeSeat();
        }

        public void InitializeSeat()
        {
            //this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
            //this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
            //this.pictureBox3.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
            //this.pictureBox4.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
            //this.pictureBox5.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
            //this.pictureBox6.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
            //this.pictureBox7.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
            //this.pictureBox8.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
            //this.pictureBox9.Image = global::WindowsFormsApplication2.Properties.Resources.seat_unavail;

            Random random = new Random();

            for (int i = 0; i < 9; i++)
            {
                status[i] = random.Next(0, 2);
            }
            SetSeatImage();
        }

        public void SetSeatImage()
        {
            this.pictureBox1.Image = GetSeatImage(status[0]);
            this.pictureBox2.Image = GetSeatImage(status[1]);
            this.pictureBox3.Image = GetSeatImage(status[2]);
            this.pictureBox4.Image = GetSeatImage(status[3]);
            this.pictureBox5.Image = GetSeatImage(status[4]);
            this.pictureBox6.Image = GetSeatImage(status[5]);
            this.pictureBox7.Image = GetSeatImage(status[6]);
            this.pictureBox8.Image = GetSeatImage(status[7]);
            this.pictureBox9.Image = GetSeatImage(status[8]);
        }

        public Image GetSeatImage(int status)
        {
            switch (status)
            {
                case 0:
                    {
                        return global::WindowsFormsApplication2.Properties.Resources.seat_avail;
                        //break;
                    }
                case 1:
                    {
                        return global::WindowsFormsApplication2.Properties.Resources.seat_unavail;
                        //break;
                    }
                case 2:
                    {
                        return global::WindowsFormsApplication2.Properties.Resources.seat_select;
                        //break;
                    }
            }
            return global::WindowsFormsApplication2.Properties.Resources.seat_avail;
        }

        public void ChooseSeat()
        {
            for (int i = 0; i <= status.Length - 3; i++)
            {
                if (status[i] == 0 && status[i + 1] == 0 && status[i + 2] == 0)
                {
                    status[i] = 2;
                    status[i + 1] = 2;
                    status[i + 2] = 2;
                    SetSeatImage();
                    break;
                }
            }
        }

        private void chooseSeatButton_Click(object sender, EventArgs e)
        {
            ChooseSeat();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            InitializeSeat();
        }
    }
}