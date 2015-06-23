using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example03
{
    public partial class Form1 : Form
    {
        private Guy Joy;
        private Guy Bob;

        public Form1()
        {
            InitializeComponent();
            Joy = new Guy() { Cash = 2500, Name = "Joy" };     //給初始值
            Bob = new Guy() { Cash = 3000, Name = "Bob" };     //C#2008後新增內容，不需要使用多型建構子，以{}即可給欄位初始值
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            this.joyCashLabel.Text = Joy.Cash.ToString();     //Bob.Cash是int，可呼叫ToString轉為字串
            this.bobCashLabel.Text = Bob.Cash.ToString();
        }

        private void joyGiveCashButton_Click(object sender, EventArgs e)
        {
            Bob.ReceiveCash(Joy.GiveCash(100));                 //直接用Joy給出的回傳值Give100，當作Bob輸入值Receive100
            UpdateLabels();                                     //記得更新螢幕上的數字
        }

        private void bobGiveCashButton_Click(object sender, EventArgs e)
        {
            Joy.ReceiveCash(Bob.GiveCash(200));
            UpdateLabels();
        }
    }
}