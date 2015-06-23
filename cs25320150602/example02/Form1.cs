using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string message = "Hello World!";
            //string name = "John";
            string name = inputNameTextBox.Text;
            //String name2 = "John";
            messageLabel.Text = string.Format("跟{0}打個招呼吧", name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void inputNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            inputNameTextBox.Text = "";
        }
    }
}