using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            totalTextBox.Text = number1TextBox.Text + number2TextBox.Text;
            //1. 但是會變成字串相加1+2=12

            int number1 = int.Parse(number1TextBox.Text);
            int number2 = int.Parse(number2TextBox.Text);
            //totalTextBox.Text = (string)number1 + (string)number2;
            //2. 數字轉回字串不能用(string)number1、要用.ToString()

            int total = number1 + number2;
            //totalTextBox.Text = total.ToString();

            //3. 更高階的做法是用string.Format("{0}", total)，也不用再ToString轉換了
            totalTextBox.Text = string.Format("{0}", total);
        }
    }
}