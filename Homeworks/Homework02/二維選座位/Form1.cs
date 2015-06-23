using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 二維選座位
{
    public partial class Form1 : Form
    {
        private Seat[,] seat;
        private int x = 9, y = 3;

        public Form1()
        {
            seat = new Seat[x, y];
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            this.ClientSize = new System.Drawing.Size(24 + 93 * x, 74 + 131 * y);

            Random rnd = new Random();
            for (int indexY = 0; indexY < y; indexY++)
            {
                for (int indexX = 0; indexX < x; indexX++)
                {
                    seat[indexX, indexY] = new Seat();
                    seat[indexX, indexY].PictureBox = new System.Windows.Forms.PictureBox();
                    //((System.ComponentModel.ISupportInitialize)(seat[indexX, indexY].PictureBox)).BeginInit();
                    seat[indexX, indexY].PictureBox.Location = new System.Drawing.Point(12 + indexX * 93, 62 + indexY * 131);
                    seat[indexX, indexY].PictureBox.Name = string.Format("pictureBox{0}_{1}", indexX, indexY);
                    seat[indexX, indexY].PictureBox.Size = new System.Drawing.Size(87, 125);
                    seat[indexX, indexY].PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                    seat[indexX, indexY].PictureBox.TabIndex = 0;
                    seat[indexX, indexY].PictureBox.TabStop = false;

                    //this.SuspendLayout();
                    this.Controls.Add(seat[indexX, indexY].PictureBox);
                    //((System.ComponentModel.ISupportInitialize)(seat[indexX, indexY].PictureBox)).EndInit();
                }
            }
            InitializeImages();
        }

        public void InitializeImages()
        {
            Random rnd = new Random();

            for (int indexY = 0; indexY < y; indexY++)
            {
                for (int indexX = 0; indexX < x; indexX++)
                {
                    seat[indexX, indexY].Status = rnd.Next(0, 2);
                    seat[indexX, indexY].SetSeatImage();
                }
            }
        }

        public void ChooseSeat()
        {
            for (int indexY = 0; indexY < y; indexY++)
            {
                bool found = false;
                for (int indexX = 0; indexX < x - 2; indexX++)
                {
                    if (seat[indexX, indexY].Status == 1 && seat[indexX + 1, indexY].Status == 1 && seat[indexX + 2, indexY].Status == 1)
                    {
                        seat[indexX, indexY].Status = 2;
                        seat[indexX, indexY].SetSeatImage();
                        seat[indexX + 1, indexY].Status = 2;
                        seat[indexX + 1, indexY].SetSeatImage();
                        seat[indexX + 2, indexY].Status = 2;
                        seat[indexX + 2, indexY].SetSeatImage();
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            InitializeImages();
        }

        private void chooseSeatButton_Click(object sender, EventArgs e)
        {
            ChooseSeat();
        }
    }
}