namespace PR_9
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.ballLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.racket = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(25, 10);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(41, 14);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Счёт: 0";
            // 
            // ballLabel
            // 
            this.ballLabel.AutoSize = true;
            this.ballLabel.Location = new System.Drawing.Point(493, 10);
            this.ballLabel.Name = "ballLabel";
            this.ballLabel.Size = new System.Drawing.Size(101, 14);
            this.ballLabel.TabIndex = 1;
            this.ballLabel.Text = "Потеряно мячей: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.racket.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.racket.Location = new System.Drawing.Point(207, 306);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(188, 26);
            this.racket.TabIndex = 2;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ball.Location = new System.Drawing.Point(281, 227);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(36, 40);
            this.ball.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пауза";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(628, 335);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.racket);
            this.Controls.Add(this.ballLabel);
            this.Controls.Add(this.scoreLabel);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Арканоид";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label ballLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel racket;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Label label2;
    }
}

