
namespace Maze2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitGame = new Maze2.RoundButton();
            this.ExitGameAndOpenMenu = new Maze2.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1251, 605);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(539, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "уровень";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(29, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitGame
            // 
            this.ExitGame.BackColor = System.Drawing.Color.DarkRed;
            this.ExitGame.BackColor2 = System.Drawing.Color.Red;
            this.ExitGame.ButtonBorderColor = System.Drawing.Color.Black;
            this.ExitGame.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.ExitGame.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.ExitGame.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.ExitGame.ButtonPressedColor = System.Drawing.Color.Red;
            this.ExitGame.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.ExitGame.ButtonPressedForeColor = System.Drawing.Color.White;
            this.ExitGame.ButtonRoundRadius = 20;
            this.ExitGame.ForeColor = System.Drawing.Color.White;
            this.ExitGame.Location = new System.Drawing.Point(1150, 4);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(109, 28);
            this.ExitGame.TabIndex = 5;
            this.ExitGame.TabStop = false;
            this.ExitGame.Text = "Выйти из игры";
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // ExitGameAndOpenMenu
            // 
            this.ExitGameAndOpenMenu.BackColor = System.Drawing.Color.DarkRed;
            this.ExitGameAndOpenMenu.BackColor2 = System.Drawing.Color.Red;
            this.ExitGameAndOpenMenu.ButtonBorderColor = System.Drawing.Color.Black;
            this.ExitGameAndOpenMenu.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.ExitGameAndOpenMenu.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.ExitGameAndOpenMenu.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.ExitGameAndOpenMenu.ButtonPressedColor = System.Drawing.Color.Red;
            this.ExitGameAndOpenMenu.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.ExitGameAndOpenMenu.ButtonPressedForeColor = System.Drawing.Color.White;
            this.ExitGameAndOpenMenu.ButtonRoundRadius = 20;
            this.ExitGameAndOpenMenu.ForeColor = System.Drawing.Color.White;
            this.ExitGameAndOpenMenu.Location = new System.Drawing.Point(1035, 4);
            this.ExitGameAndOpenMenu.Name = "ExitGameAndOpenMenu";
            this.ExitGameAndOpenMenu.Size = new System.Drawing.Size(109, 28);
            this.ExitGameAndOpenMenu.TabIndex = 4;
            this.ExitGameAndOpenMenu.TabStop = false;
            this.ExitGameAndOpenMenu.Text = "Выйти в меню";
            this.ExitGameAndOpenMenu.Click += new System.EventHandler(this.ExitGameAndOpenMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 650);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.ExitGameAndOpenMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private RoundButton ExitGameAndOpenMenu;
        private RoundButton ExitGame;
        private System.Windows.Forms.Button button1;
    }
}

