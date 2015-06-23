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
        private int currentScene = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void ChangeScene(int choice)
        {
            switch (currentScene)
            {
                case 0:
                    currentScene = 1;
                    scenePictureBox.Image = WindowsFormsApplication1.Properties.Resources.scene1;
                    break;

                case 1:
                    switch (choice)
                    {
                        case 1:
                            currentScene = 2;
                            scenePictureBox.Image =
                                WindowsFormsApplication1.Properties.Resources.scene2;
                            break;

                        case 2:
                            currentScene = 3;
                            scenePictureBox.Image =
                                WindowsFormsApplication1.Properties.Resources.scene3;
                            break;
                    }
                    break;

                case 2:
                    if (choice == 1)
                    {
                        currentScene = 4;
                        scenePictureBox.Image =
                            WindowsFormsApplication1.Properties.Resources.scene4;
                    }
                    else if (choice == 2)
                    {
                        currentScene = 5;
                        scenePictureBox.Image =
                            WindowsFormsApplication1.Properties.Resources.scene5;
                        messageLabel.Text = "Game Over!";
                    }
                    break;

                case 3:
                    if (choice == 1)
                    {
                        currentScene = 6;
                        scenePictureBox.Image =
                            WindowsFormsApplication1.Properties.Resources.scene6;
                        messageLabel.Text = "Game Over!";
                    }
                    else if (choice == 2)
                    {
                        currentScene = 7;
                        scenePictureBox.Image =
                            WindowsFormsApplication1.Properties.Resources.scene7;
                    }
                    break;

                case 4:
                    if (choice == 1)
                    {
                        currentScene = 8;
                        scenePictureBox.Image =
                            WindowsFormsApplication1.Properties.Resources.scene8;
                        messageLabel.Text = "Game Over!";
                    }
                    else if (choice == 2)
                    {
                        currentScene = 5;
                        scenePictureBox.Image =
                            WindowsFormsApplication1.Properties.Resources.scene5;
                        messageLabel.Text = "To be continued...";
                    }
                    break;

                case 7:
                    if (choice == 1)
                    {
                        currentScene = 6;
                        scenePictureBox.Image =
                            WindowsFormsApplication1.Properties.Resources.scene6;
                        messageLabel.Text = "Game Over!";
                    }
                    else if (choice == 2)
                    {
                        currentScene = 9;
                        scenePictureBox.Image =
                            WindowsFormsApplication1.Properties.Resources.scene9;
                        messageLabel.Text = "To be continued...";
                    }
                    break;
            }
        }

        private void inputButton1_Click(object sender, EventArgs e)
        {
            ChangeScene(1);
        }

        private void inputButton2_Click(object sender, EventArgs e)
        {
            ChangeScene(2);
        }
    }
}