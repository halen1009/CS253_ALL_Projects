using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        private Guy Joe;
        private Guy Bob;

        public Form1()
        {
            InitializeComponent();
            Joe = new Guy() { Name = "Joe", Cash = 2000 };
            Bob = new Guy() { Name = "Bob", Cash = 3000 };
        }

        public void UpdateLabels()
        {
            this.joeCashLabel.Text = Joe.Cash.ToString();
            this.bobCashLabel.Text = Bob.Cash.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void joeGiveCashButton_Click(object sender, EventArgs e)
        {
            Bob.ReceiveCash(Joe.GiveCash(100));
            UpdateLabels();
        }

        private void bobGiveCashButton_Click(object sender, EventArgs e)
        {
            Joe.ReceiveCash(Bob.GiveCash(200));
            UpdateLabels();
        }
    }
}