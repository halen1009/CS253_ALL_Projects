using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private Person Elsa;
        private float velocity = 50.0f;
        private int StartX;

        public Form1()
        {
            InitializeComponent();
            Elsa = new Person();
            Elsa.name = "Elsa";
            Elsa.position.SetX(0.0f);
            Elsa.position.Y = 0.0f;
            StartX = imagePictureBox.Location.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Elsa.position.SetX(imagePictureBox.Location.X);
            Elsa.position.Y = imagePictureBox.Location.Y;
        }

        private Position UpdateElsaPosition()
        {
            int EndX = StartX + int.Parse(velocityComboBox.Text);
            float dx = velocity * timer1.Interval / 1000.0f;
            return Elsa.MoveForward(Elsa.position.GetX() >= EndX ? 0 : dx);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Position position = UpdateElsaPosition();
            imagePictureBox.Location = new Point((int)Elsa.position.GetX(), (int)Elsa.position.Y);
            messageRichTextBox.Text = string.Format("Elsa的位置 = {0}, {1}", position.GetX(), position.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}