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
        private int currentScene = 0;
        //1. private只在class Form1裡可用

        public Form1()
        {
            InitializeComponent();
        }

        //2. 選擇場景的功能，是動態的所以不加static
        public void changeScene(int choice)
        {
            //currencScene = 0
            if (currentScene == 0)
            {
                //2.1 用來換圖片
                scenePictureBox.Image =
                example02.Properties.Resources.scene1;
                currentScene = 1;
            }

            //4. 到下一條叉路時
            //currencScene = 1
            else if (currentScene == 1)
            {
                if (choice == 1)
                {
                    scenePictureBox.Image =
                  example02.Properties.Resources.scene2;
                    currentScene = 2;
                }
                else
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene3;
                    currentScene = 3;
                }
            }

            //currencScene = 2
            else if (currentScene == 2)
            {
                if (choice == 1)
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene4;
                    currentScene = 4;
                }
                else
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene5;
                    currentScene = 5;
                    messageLabel.Text = "Game Over!";
                }
            }

            //currencScene = 3
            else if (currentScene == 3)
            {
                if (choice == 1)
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene6;
                    currentScene = 6;
                    messageLabel.Text = "Game Over!";
                }
                else
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene7;
                    currentScene = 7;
                }
            }

            //currencScene = 4
            else if (currentScene == 4)
            {
                if (choice == 1)
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene8;
                    currentScene = 8;
                    messageLabel.Text = "To be continued...";
                }
                else
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene5;
                    currentScene = 5;
                    messageLabel.Text = "Game Over!";
                }
            }

            //currencScene = 7
            else if (currentScene == 7)
            {
                if (choice == 1)
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene6;
                    currentScene = 6;
                    messageLabel.Text = "Game Over!";
                }
                else
                {
                    scenePictureBox.Image =
                    example02.Properties.Resources.scene9;
                    currentScene = 9;
                    messageLabel.Text = "To be continued...";
                }
            }
        }

        //3. 在button啟動功能
        private void button1_Click(object sender, EventArgs e)
        {
            changeScene(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeScene(2);
        }
    }
}