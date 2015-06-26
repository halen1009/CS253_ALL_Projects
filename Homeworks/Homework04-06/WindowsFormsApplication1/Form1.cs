using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // 放這裡大家可以用
        private Graphics graph1;

        private Pen pen1;

        //Font font1;   // 寫文字才用到
        //Brush brush1; // 寫文字才用到
        private bool isMouseDown = false;               // 紀錄滑鼠是否按下

        private List<Point> points = new List<Point>(); // 紀錄滑鼠軌跡點，使用 List 資料結構

        public Form1()
        {
            InitializeComponent();

            graph1 = this.CreateGraphics();

            // Creating objects 建立物件
            pen1 = new Pen(Color.Black, 3);
            //font1 = new Font("標楷體", 16);
            //brush1 = new SolidBrush(Color.Black);
        }

        // _Load 第一次! Load視窗
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // _Paint 每次! 視窗重繪
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i <= points.Count - 2; i++) // points.Count - 2 因為兩兩連線少1，還有index減1
            {
                if (points[i].X != -1 && points[i + 1].X != -1) // 檢查並非滑鼠放開的斷點，才畫
                {
                    graph1.DrawLine(pen1, points[i], points[i + 1]);
                }
            }

            /*
            // 這裡是其他繪畫練習：插入圖片、畫直線、畫長方形、貼上文字
            // (先畫的會被後畫的覆蓋)
            Image image = Image.FromFile("c:/pic.jpg");
            graph1.DrawImage(image, new Point(20, 20));

            graph1.DrawLine(pen1, new Point(1, 1), new Point(300, 100));

            graph1.DrawRectangle(pen1, new Rectangle(50, 50, 100, 100));

            graph1.DrawString("Hello! 你好！", font1, brush1, new PointF(100.0F, 150.0F));
            */
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            //points.Add(new Point(e.X, e.Y)); // e.Location 另一種寫法
            points.Add(e.Location);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                points.Add(e.Location);
                this.Invalidate(); // 在滑鼠移動的時候，不斷的即時更新畫面
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            points.Add(new Point(-1, -1)); // 紀錄-1,-1在滑鼠軌跡點，表示滑鼠放開
            isMouseDown = false;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            points.Clear();    // 清空 滑鼠軌跡點
            this.Invalidate(); // 必須更新畫面
        }
    }
}