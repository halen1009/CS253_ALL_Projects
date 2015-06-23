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
        private Person Elsa;            //宣告Elsa是一個Person類別
        private float velocity = 50.0f;
        //7存速度用的，用來代表50像素/毫秒

        private int StartX;
        //10.限制Elsa最遠位置用的始位置

        public Form1()
        {
            //3.新增一個欄位，是Person
            InitializeComponent();
            Elsa = new Person();        //3.1宣告Elsa是一種Person後，用new Person()來做初始化，類別要初始化(new)之後才可用
            Elsa.name = "Elsa";         //3.2設定Elsa的資料
            Elsa.position.SetX(0.0f);     //float要用數字加f
            //9.2改用屬性方法來存取position.Y
            Elsa.position.Y = 0.0f;

            //10.限制Elsa最遠距離用的起始值
            StartX = elsaImagePictureBox.Location.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //5.在Load的時候，傳值給Elsa圖片
            //5.1但是要把浮點數轉成整數，要加(int)
            //elsaImagePictureBox.Location.X = (int)Elsa.position.x;
            //elsaImagePictureBox.Location.Y = (int)Elsa.position.y;
            //5.2但是Location不能直接改值，要用裡面的屬性來改它...

            //6. 重新寫成：在Load的時候，把Elsa圖片的位置傳給Elsa.position當作初始值
            //Elsa.position.x = elsaImagePictureBox.Location.X;
            //Elsa.position.y = elsaImagePictureBox.Location.Y;

            //9.1重寫成用封裝後的GetX
            //9.2改用屬性方法存取position.Y
            Elsa.position.SetX(elsaImagePictureBox.Location.X);
            Elsa.position.Y = elsaImagePictureBox.Location.Y;
        }

        //7.1做移動位置，每次更新的位移dx是時間間隔x速度
        private Position UpdateElsaPosition()
        {
            //10.1 用下拉選單的值當作最遠可去的距離限制
            int EndX = StartX + int.Parse(forwardDistanceComboBox.Text);    //.SelectedText不行?

            //velocity = int.Parse(forwardDistanceComboBox.SelectedText);
            float dx = velocity * animationTimer.Interval / 1000.0f;
            //return Elsa.Moveforward(dx);
            //7.2移動後的x位置，會用Elsa.MoveForward(dx)來修改Elsa.position的內容

            //10.2 改用三元運算子判斷
            return Elsa.Moveforward(Elsa.position.GetX() >= EndX ? 0 : dx);
        }

        //8.啟動Timer後，可以開始移動
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Position position = UpdateElsaPosition();
            //8.1新增宣告一個position，除了移動Elsa.position的值以外，也存下用來顯示在messageRichTextBox用
            //elsaImagePictureBox.Location = new Point((int)Elsa.position.x, (int)Elsa.position.y);
            //messageRichTextBox.Text = string.Format("Elsa的位置x = {0}, y = {1}", position.x, position.y);

            //9.1改用封裝後的GetX
            //9.2改用屬性方法存取position.Y
            elsaImagePictureBox.Location = new Point((int)Elsa.position.GetX(), (int)Elsa.position.Y);
            messageRichTextBox.Text = string.Format("Elsa的位置x = {0}, y = {1}", position.GetX(), position.Y);
        }

        //9.按下後，開始Timer做
        private void button1_Click(object sender, EventArgs e)
        {
            animationTimer.Enabled = !animationTimer.Enabled;
            //9.1用!AnimationTimer.Enabled;來把開切換成關、把關切換成開
        }
    }
}