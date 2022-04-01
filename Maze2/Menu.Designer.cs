
namespace Maze2
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new Maze2.RoundButton();
            this.Play = new Maze2.RoundButton();
            this.exit = new Maze2.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Silver;
            this.SettingsButton.BackColor2 = System.Drawing.Color.Black;
            this.SettingsButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.SettingsButton.ButtonHighlightColor = System.Drawing.Color.Lime;
            this.SettingsButton.ButtonHighlightColor2 = System.Drawing.Color.LawnGreen;
            this.SettingsButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.SettingsButton.ButtonPressedColor = System.Drawing.Color.Lime;
            this.SettingsButton.ButtonPressedColor2 = System.Drawing.Color.LawnGreen;
            this.SettingsButton.ButtonPressedForeColor = System.Drawing.Color.White;
            this.SettingsButton.ButtonRoundRadius = 30;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(48, 260);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(361, 98);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Black;
            this.Play.BackColor2 = System.Drawing.Color.Silver;
            this.Play.ButtonBorderColor = System.Drawing.Color.Black;
            this.Play.ButtonHighlightColor = System.Drawing.Color.LawnGreen;
            this.Play.ButtonHighlightColor2 = System.Drawing.Color.Lime;
            this.Play.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.Play.ButtonPressedColor = System.Drawing.Color.LawnGreen;
            this.Play.ButtonPressedColor2 = System.Drawing.Color.Lime;
            this.Play.ButtonPressedForeColor = System.Drawing.Color.White;
            this.Play.ButtonRoundRadius = 30;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.Location = new System.Drawing.Point(48, 107);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(361, 124);
            this.Play.TabIndex = 5;
            this.Play.Text = "Играть";
            this.Play.Click += new System.EventHandler(this.Play_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Gray;
            this.exit.BackColor2 = System.Drawing.Color.Maroon;
            this.exit.ButtonBorderColor = System.Drawing.Color.Black;
            this.exit.ButtonHighlightColor = System.Drawing.Color.Orange;
            this.exit.ButtonHighlightColor2 = System.Drawing.Color.OrangeRed;
            this.exit.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.exit.ButtonPressedColor = System.Drawing.Color.Red;
            this.exit.ButtonPressedColor2 = System.Drawing.Color.Maroon;
            this.exit.ButtonPressedForeColor = System.Drawing.Color.White;
            this.exit.ButtonRoundRadius = 30;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(345, 383);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 40);
            this.exit.TabIndex = 4;
            this.exit.Text = "выход";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(445, 435);
            this.ControlBox = false;
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundButton exit;
        private RoundButton Play;
        private RoundButton SettingsButton;
    }
}