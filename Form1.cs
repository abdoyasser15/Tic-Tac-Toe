using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    enum enPlayer
    {
        Player1 = 1 , Player2 = 2
    }
    public partial class Form1 : Form
    {
        bool flag = false;
        bool player = false;
        bool Win = false;
        byte counter = 0;
        void check(Button bt1)
        {
            if (counter % 2 == 0)
            {
                bt1.Image = Properties.Resources.X;
                bt1.Tag = "X";
                lbGameOver.Text = enPlayer.Player2.ToString();
            }
            else
            {
                bt1.Image = Properties.Resources.O;
                bt1.Tag = "O";
                lbGameOver.Text = enPlayer.Player1.ToString();
            }
            counter++;
        }
        public Form1()
        {
            InitializeComponent();
        }
        void Message()
        {
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        bool Check_Game(Button bt1, Button bt2, Button bt3)
        {
            if (bt1.Tag.ToString() != "?" && bt1.Tag.ToString() == bt2.Tag.ToString() && bt1.Tag.ToString() == bt3.Tag.ToString())
            {
                bt1.BackColor = Color.GreenYellow;
                bt2.BackColor = Color.GreenYellow;
                bt3.BackColor = Color.GreenYellow;
                if (bt1.Tag.ToString() == "X")
                {
                    lbProgress.Text = enPlayer.Player1.ToString();
                    lbGameOver.Text = "Game Over";
                    Message();
                }
                else
                {
                    lbProgress.Text = enPlayer.Player2.ToString();
                    lbGameOver.Text = "Game Over";
                    Message();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        void Draw()
        {
            lbProgress.Text = "Draw";
            lbGameOver.Text = "Game Over";
            Message();
        }
        void ResetTags()
        {
            button1.Tag = "?";
            button2.Tag = "?";
            button3.Tag = "?";
            button4.Tag = "?";
            button5.Tag = "?";
            button6.Tag = "?";
            button7.Tag = "?";
            button8.Tag = "?";
            button9.Tag = "?";
        }
        void ResetImage()
        {
            button1.Image = Properties.Resources.question_mark_96;
            button2.Image = Properties.Resources.question_mark_96;
            button3.Image = Properties.Resources.question_mark_96;
            button4.Image = Properties.Resources.question_mark_96;
            button5.Image = Properties.Resources.question_mark_96;
            button6.Image = Properties.Resources.question_mark_96;
            button7.Image = Properties.Resources.question_mark_96;
            button8.Image = Properties.Resources.question_mark_96;
            button9.Image = Properties.Resources.question_mark_96;
        }
        void Reset_Back_Color()
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button9.BackColor = Color.Black;
        }
        void Restart()
        {
            ResetTags();
            ResetImage();
            Reset_Back_Color();
            lbGameOver.Text = enPlayer.Player1.ToString();
            lbProgress.Text = "InProgress";
            counter = 0;
            flag = false;
            Win = false;
            player = false;
        }
        void Win_Draw()
        {
            if (Check_Game(button1, button2, button3))
                Win = true;

            else if (Check_Game(button4, button5, button6))
                Win = true;
            else if (Check_Game(button7, button8, button9))
                Win = true;
            else if (Check_Game(button1, button4, button7))
                Win = true;
            else if (Check_Game(button2, button5, button8))
                Win = true;
            else if (Check_Game(button3, button6, button9))
                Win = true;
            else if (Check_Game(button1, button5, button9))
                Win = true;
            else if (Check_Game(button3, button5, button7))
                Win = true;
            else if (counter == 9)
            {
                Win = true;
                Draw();
            }
        }
        void Change_Image(Button bt1)
        {
            if (bt1.Tag.ToString() == "?")
            {
                check(bt1);
                Win_Draw();
                bt1.Refresh();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(White);
            pen.Width = 7;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 500, 100, 500, 550);
            e.Graphics.DrawLine(pen, 700, 100, 700, 550);
            e.Graphics.DrawLine(pen, 300, 250, 900, 250);
            e.Graphics.DrawLine(pen, 300, 400, 900, 400);
        }
        void Done()
        {
            if (flag == true && counter % 2 == 1)
            {
                Thread.Sleep(500);
                Easy_Version();
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (Win) MessageBox.Show("Please Restart The Game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (player || flag) Change_Image((Button)sender);
            else MessageBox.Show("Please Check Play With Computer Or With Player Also ? ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (Win == false && flag == true) Done();
        }
        private void btResartGame_Click(object sender, EventArgs e)
        {
            Restart();
            if (Win == false && flag == true) Done();
        }
        int Random_Easy_Version()
        {
            Random random = new Random();
            int randomInt = random.Next(1, 9);
            return randomInt;
        }
        void Easy_Version()
        {
            int x = Random_Easy_Version();
            while (x>0)
            {
                
                if (Random_Easy_Version() == 1)
                {
                    if (button1.Tag.ToString() == "?")
                    {
                        Change_Image(button1);
                        break;
                    }
                }
                if (Random_Easy_Version() == 2)
                {
                    if (button2.Tag.ToString() == "?") {
                        Change_Image(button2);
                        break;
                    }
                }
                if (Random_Easy_Version() == 3)
                {
                    if (button3.Tag.ToString() == "?")
                    {
                        Change_Image(button3);
                        break;
                    }
                }
                if (Random_Easy_Version() == 4)
                {
                    
                    if (button4.Tag.ToString() == "?")
                    {
                        Change_Image(button4);
                        break;
                    }
                }
                if (Random_Easy_Version() == 5)
                {
                    if (button5.Tag.ToString() == "?")
                    {
                        Change_Image(button5);
                        break;
                    }
                }
                if (Random_Easy_Version() == 6)
                {
                    
                    if (button6.Tag.ToString() == "?")
                    {
                        Change_Image(button6);
                        break;
                    }
                }
                if (Random_Easy_Version() == 7)
                {
                    if (button7.Tag.ToString() == "?")
                    {
                        Change_Image(button7);
                        break;
                    }
                }
                if (Random_Easy_Version() == 8)
                {
                    if (button8.Tag.ToString() == "?")
                    {
                        Change_Image(button8);
                        break;
                    }
                }
                if (Random_Easy_Version() == 9)
                {
                    if (button9.Tag.ToString() == "?")
                    {
                        Change_Image(button9);
                        break;
                    }
                }
                x = Random_Easy_Version();
            }
        }
        void play_With_Computer()
        {
            if(!rdEasy.Checked&&!rdHard.Checked)
            {
                MessageBox.Show("Please Choose The Version.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btComputer_Click(object sender, EventArgs e)
        {
            play_With_Computer();
            flag = true;
        }
        private void btPlayer_Click(object sender, EventArgs e)
        {
            player = true;
        }
    }
}
