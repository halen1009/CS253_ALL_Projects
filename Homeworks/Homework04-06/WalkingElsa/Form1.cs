using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkingElsa
{
    public partial class Form1 : Form
    {
        private Person elsa;

        public Form1()
        {
            InitializeComponent();
            elsa = new Person()
                {
                    Name = "Elsa",
                    Velocity = 50.0f,
                };
            elsa.StartPosition.X = 12;
            elsa.StartPosition.Y = 12;
            elsa.elsaTrack.graphic = CreateGraphics();
            InitializeForm();
        }

        public void InitializeForm()
        {
            //Image
            //elsa = new Person();
            //elsa.ElsaImagePictureBox = new PictureBox();
            //elsa.elsaImagePictureBox.Image = global::WalkingElsa.Properties.Resources.tumblr_muexn83y6t1s0h0fgo1_500;
            //elsa.elsaImagePictureBox.Location = new System.Drawing.Point(12, 12);
            //elsa.elsaImagePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            //elsa.elsaImagePictureBox.Name = "elsaImagePictureBox";
            //elsa.elsaImagePictureBox.Size = new System.Drawing.Size(80, 111);
            //elsa.elsaImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //elsa.elsaImagePictureBox.TabIndex = 0;
            //elsa.elsaImagePictureBox.TabStop = false;
            this.Controls.Add(elsa.elsaImagePictureBox);

            ////Timer
            //elsa.animationTimer = new Timer(components);
            elsa.animationTimer.Tick += new System.EventHandler(elsa.animationTimer_Tick);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            elsa.EndPosition.X = elsa.StartPosition.X + int.Parse(forwardDistanceComboBox.Text);
            elsa.EndPosition.Y = elsa.StartPosition.Y + int.Parse(forwardDistanceComboBox.Text);

            elsa.animationTimer.Enabled = !elsa.animationTimer.Enabled;
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            for (int i = 0; i <= elsa.elsaTrack.points.Count - 2; i++) // points.Count - 2 因為兩兩連線少1，還有index減1
            {
                if (elsa.elsaTrack.points[i].X != -1 && elsa.elsaTrack.points[i + 1].X != -1) // 檢查並非滑鼠放開的斷點，才畫
                {
                    elsa.elsaTrack.graphic.DrawLine(elsa.elsaTrack.pen, elsa.elsaTrack.points[i], elsa.elsaTrack.points[i + 1]);
                }
            }
        }
    }
}