using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example01
{
    public partial class Form1 : Form
    {
        public int[] status = new int[9];
        //1.4.2拉到這裡來

        public Form1()
        {
            InitializeComponent();
            InitializeSeat();
            //1.2呼叫初始化
        }

        //1.初始化座位，先在Form1.cs[設計]裡，拉第一個PictureBox要用的圖，然後抄Form1.Designer.cs裡的
        private void InitializeSeat()
        {
            //this.pictureBox1.Image = global::example01.Properties.Resources.seat_unavail;
            //this.pictureBox2.Image = global::example01.Properties.Resources.seat_unavail;
            //this.pictureBox3.Image = global::example01.Properties.Resources.seat_unavail;
            //this.pictureBox4.Image = global::example01.Properties.Resources.seat_unavail;
            //this.pictureBox5.Image = global::example01.Properties.Resources.seat_unavail;
            //this.pictureBox6.Image = global::example01.Properties.Resources.seat_unavail;
            //this.pictureBox7.Image = global::example01.Properties.Resources.seat_unavail;
            //this.pictureBox8.Image = global::example01.Properties.Resources.seat_unavail;
            //this.pictureBox9.Image = global::example01.Properties.Resources.seat_unavail;
            //1.2但是仍沒東西，要再Form1()裡呼叫他一次
            //1.3用GetSeatImage(0)來改寫

            Random random = new Random();
            //int[] status = new int[9];
            //1.4.2要存下各椅子的狀態，用Status陣列來記錄。但為了日後使用，拉到class裡面去

            //1.4.1做成隨機狀態，並且用新方法GetSeatImage(0);來代替一長串東西
            for (int index = 0; index < 9; index++)
            {
                status[index] = random.Next(0, 2);
            }
            //this.pictureBox1.Image = GetSeatImage(status[0]);
            //this.pictureBox2.Image = GetSeatImage(status[1]);
            //this.pictureBox3.Image = GetSeatImage(status[2]);
            //this.pictureBox4.Image = GetSeatImage(status[3]);
            //this.pictureBox5.Image = GetSeatImage(status[4]);
            //this.pictureBox6.Image = GetSeatImage(status[5]);
            //this.pictureBox7.Image = GetSeatImage(status[6]);
            //this.pictureBox8.Image = GetSeatImage(status[7]);
            //this.pictureBox9.Image = GetSeatImage(status[8]);

            //1.5之後有了SetSeatImages()後，用SetSeatImages()來取代那9行
            SetSeatImages();
        }

        //2.2找到三連座椅吼，要重設椅子圖片
        public void SetSeatImages()
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

        //1.4.1用新方法GetSeatImage(0);來代替一長串東西
        private Image GetSeatImage(int type)
        {
            if (type == 0)
            {
                return global::example01.Properties.Resources.seat_unavail;
            }
            else if (type == 1)
            {
                return global::example01.Properties.Resources.seat_avail;
            }
            else
            {
                return global::example01.Properties.Resources.seat_select;
            }
        }

        //2.用ChooseSeat()來找有連三空位的地方
        public void ChooseSeat()
        {
            //2.1最牆邊確定不會有連3座位，所以只到0-6號，也就是status.Length-3 = 9-3 = 6
            for (int seatNumber = 0; seatNumber <= status.Length - 3; seatNumber++)
            {
                if (status[seatNumber] == 1 && status[seatNumber + 1] == 1 && status[seatNumber + 2] == 1)
                {
                    status[seatNumber] = 2;
                    status[seatNumber + 1] = 2;
                    status[seatNumber + 2] = 2;
                    SetSeatImages();
                    break;
                    //2.1找到就跳出for loop，不用再找下一組
                }
            }
        }

        //3.做出選椅子、重設椅子的按鈕
        private void chooseButton_Click(object sender, EventArgs e)
        {
            ChooseSeat();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            InitializeSeat();
        }
    }
}