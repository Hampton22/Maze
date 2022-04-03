using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze2
{
    public partial class Form1 : Form
    {
        Menu menu;
        Graphics graphics;
        Pen pen;
        Ball ball;
        MazeLevel mazeLevel;
        MazeLevel1 mazeLevel1;
        MazeLevel2 mazeLevel2;

        public Form1(Menu menu)
        {
            InitializeComponent();

            this.menu = menu;
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(this.ForeColor, 5);

            ball = new Ball();
            InitLevel();

            DrawBall();

            pictureBox1.Image = bitmap;
            pictureBox1.Invalidate();
            
        }

        private void DrawBall()
        {
            graphics.FillRectangle(Brushes.Black, ball.boundingBox);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.W)
            {
    
                ball.boundingBox.Location = new Point(ball.boundingBox.X, ball.boundingBox.Y - 10);
            }
            if (e.KeyCode == Keys.S)
            {
                ball.boundingBox.Location = new Point(ball.boundingBox.X, ball.boundingBox.Y + 10);
            }
            if (e.KeyCode == Keys.A)
            {

                ball.boundingBox.Location = new Point(ball.boundingBox.X - 10, ball.boundingBox.Y);
            }
            if (e.KeyCode == Keys.D)
            {
                ball.boundingBox.Location = new Point(ball.boundingBox.X + 10, ball.boundingBox.Y);
            }
        }
        
        private void DrawAllObjects()
        {
            graphics.Clear(Color.White);
            DrawBall();
            DrawMaze();
            pictureBox1.Invalidate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DrawAllObjects();
            CheckBorders();
            CheckFinish();
           
        }

        private void DrawMaze()
        {
            if (menu.level == 1)
            {
                mazeLevel.DrawMaze(graphics);
            }
            if (menu.level == 2)
            {
                mazeLevel1.DrawMaze(graphics);
            }
            if (menu.level == 3)
            {
                mazeLevel2.DrawMaze(graphics);
            }

        }
        private void InitLevel()
        {
            timer1.Start();
            if (menu.level == 1)
            {
                label1.Text = "Уровень 1";
                mazeLevel = new MazeLevel();
                ball.boundingBox = new Rectangle(25, 513, 15, 15);
            }
            if (menu.level == 2)
            {
                label1.Text = "Уровень 2";            
                mazeLevel1 = new MazeLevel1();
                ball.boundingBox = new Rectangle(70, 70, 15, 15);
            }
            if (menu.level == 3)
            {
                label1.Text = "Уровень 3";
                mazeLevel2 = new MazeLevel2();
                ball.boundingBox = new Rectangle(30, 30, 15, 15);
            }
            DrawMaze();
        }

        private void CheckFinish()
        {
            if (IsTouchFinish())
            {
                timer1.Stop();
                menu.level++;
                if (menu.level > 3)
                {
                    MessageBox.Show("Вы прошли всю игру! Поздравляем!");
                    this.Close();
                    menu.Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                    "Вы выйграли." +
                    " Хотите ли вы перейти на следующий уровень?",
                    "предложение века",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                        menu.Show();
                    }

                    if (result == DialogResult.Yes)
                    { 
                        InitLevel();
                    }
                }

            }
        }

        private bool IsTouchFinish()
        {
            if (menu.level == 1) 
            {
                return mazeLevel.IsTouchFinish(ball);
            }
            if (menu.level == 2)
            {
                return mazeLevel1.IsTouchFinish(ball);
            }

            if (menu.level == 3)
            {
                return mazeLevel2.IsTouchFinish(ball);
            }

            return false;
        }

        private void CheckBorders()
        {
            if (menu.level == 1)
            {
                if (mazeLevel.IsTouchBorders(ball))
                {

                    ball.boundingBox = new Rectangle(25, 513, 15, 15);
                    MessageBox.Show("Вы проиграли");
                }

            }

            if (menu.level == 2)
            {
                if (mazeLevel1.IsTouchBorders(ball))
                {
                    ball.boundingBox = new Rectangle(70, 70, 15, 15);
                    MessageBox.Show("Вы проиграли");
                }
            }

            if (menu.level == 3)
            {
                if (mazeLevel2.IsTouchBorders(ball))
                {
                    ball.boundingBox = new Rectangle(30, 30, 15, 15);
                    MessageBox.Show("Вы проиграли");
                }
            }
        }

        private void ExitGameAndOpenMenu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
            menu.Show();
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тест");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Show();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            button1.Hide();
        }
    }
}
