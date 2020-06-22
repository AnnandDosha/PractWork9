using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_9
{
    public partial class MainForm : Form
    {
        public int ballSpeedX;//поле отображающее скорость по Х
        public int ballSpeedY;//поле отображающее скорость по У
        public int lostball;//переменна для условия при потори мяча
        public int score=0;// переменная при подсчёте очков 
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        { // изменение контура панели мяча на круглую
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(ball.ClientRectangle);
            ball.Region = new Region(path);
            //код размещающий на форме панели-кирпичи и их цвет
            int cellSize = 30;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Panel cell = new Panel();
                    cell.Width = this.Left/10;
                    cell.Height = cellSize;
                    cell.Location = new Point(x * cell.Size.Width, y * cellSize);
                    cell.BorderStyle = BorderStyle.FixedSingle;
                    if(y==0)
                    {
                        cell.BackColor = Color.DarkRed;
                    }
                    if (y == 1)
                    {
                        cell.BackColor = Color.Orange;
                    }
                    if (y == 2)
                    {
                        cell.BackColor = Color.YellowGreen;
                    }
                    if (y == 3)
                    {
                        cell.BackColor = Color.DarkGreen;
                    }
                    this.Controls.Add(cell);
                }
            }
            //код изменяющий положение мяча и его скорость
            Random random = new Random();
            Point randompoint = new Point(random.Next(this.Width),random.Next(this.Height/4)+this.Height/2 - ball.Height);
            ball.Location = randompoint;
            ballSpeedX = random.Next(6) - 3;
            ballSpeedY = -(random.Next(2) + 2);
        }
        //обработчик движения мыши
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            int racketCenterX = racket.Width / 2;
            if(e.X > racketCenterX && e.X < this.ClientSize.Width - racketCenterX)
            {
                racket.Location = new Point(e.X - racketCenterX, racket.Top);
            }
        }
        //код реализующий отскакивание мяча от стенок 
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if(ball.Left<=0)
            {
                ballSpeedX = -ballSpeedX;
            }
            if (ball.Right >= this.ClientSize.Width)
            {
                ballSpeedX = -ballSpeedX;
            }
            if (ball.Top <= 0)
            {
                ballSpeedY = -ballSpeedY;
            }
            //код реализующий отскакивание мяча от ракетки
            int X = (ball.Right - ball.Left)/2 + ball.Left;
            int Y = ball.Bottom;
            if(Y>=racket.Top && X>racket.Left && X<racket.Right)
            {
                ball.Top = racket.Top - ball.Size.Height + 1;
                ballSpeedY = -ballSpeedY;

            }
            if (ball.Bottom >= this.ClientSize.Height)
            {
                gameTimer.Stop();
                lostball++;
                ballLabel.Text = "Потеряно мячей: "+lostball.ToString();
                MessageBox.Show("Мяч потерян");
                Random random = new Random();
                Point randompoint = new Point(random.Next(this.Width), random.Next(this.Height / 4) + this.Height / 2 - ball.Height);
                ball.Location = randompoint;
                ballSpeedX = random.Next(6) - 3;
                ballSpeedY = -(random.Next(2) + 2);
                gameTimer.Start();
            }
            //код отображающий счёт,увеличение очков в зависимомти от ряда кирпичей и отскакивания мяча от них
            Rectangle ballRectangle = ball.Bounds;
            for(int i = this.Controls.Count -1; i>= 0; i--)
            {
                Control item = this.Controls[i];
                if(item is Panel && item != ball && item != racket)
                {
                    if(ballRectangle.IntersectsWith(item.Bounds))
                    {
                        ballRectangle.Intersect(item.Bounds);

                        if(ballRectangle.Height<ballRectangle.Width)
                        {
                            ballSpeedY = -ballSpeedY;
                        }
                        else
                        {
                            ballSpeedX = -ballSpeedX;
                        }
                        this.Controls.Remove(item);
                        score += 100;
                        scoreLabel.Text = "Счёт: "+score.ToString();
                    }
                }
            }
            int panelcount=0;
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control item = this.Controls[i];
                if (item is Panel && item != ball && item != racket)
                {
                    panelcount++;
                }
            }
            if(panelcount==0)
            {
                gameTimer.Stop();
                MessageBox.Show("Вы победили!");
            }
            ball.Location = new Point(ball.Location.X+ballSpeedX, ball.Location.Y + ballSpeedY);
        }
        // код для отображения на форме об остановке игры и её продолжении
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
               if(gameTimer.Enabled==true)
               {
                    gameTimer.Stop();
                    label2.Visible = true;
               }
                else
                {
                    gameTimer.Start();
                    label2.Visible = false;
                }
            }
        }
    }
}
