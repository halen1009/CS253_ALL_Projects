using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(number1TextBox.Text);
            int n2 = int.Parse(number2TextBox.Text);
            int total = n1 + n2;
            totalTextBox.Text = string.Format("{0}", total);
        }
    }
}