using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze2
{
    public partial class Settings : Form
    {
        Menu menu;
        public Settings(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            
            if (menu.level == 1)
            {
                roundButton1.BackColor = Color.SpringGreen;
                roundButton1.BackColor2 = Color.Aquamarine;
            }

            if (menu.level == 2)
            {
                roundButton2.BackColor = Color.SpringGreen;
                roundButton2.BackColor2 = Color.Aquamarine;
            }

            if (menu.level == 3)
            {
                roundButton3.BackColor = Color.SpringGreen;
                roundButton3.BackColor2 = Color.Aquamarine;
            }
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            menu.level = 2;
            roundButton1.BackColor = Color.White;
            roundButton1.BackColor2 = Color.White;
            roundButton2.BackColor = Color.SpringGreen;
            roundButton2.BackColor2 = Color.Aquamarine;
            roundButton3.BackColor = Color.White;
            roundButton3.BackColor2 = Color.White;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            menu.level = 1;
            roundButton1.BackColor = Color.SpringGreen;
            roundButton1.BackColor2 = Color.Aquamarine;
            roundButton2.BackColor = Color.White;
            roundButton2.BackColor2 = Color.White;
            roundButton3.BackColor = Color.White;
            roundButton3.BackColor2 = Color.White;
        }

        private void roundButton13_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.Text = "Настройки";
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            menu.level = 3;
            roundButton1.BackColor = Color.White;
            roundButton1.BackColor2 = Color.White;
            roundButton2.BackColor = Color.White;
            roundButton2.BackColor2 = Color.White;
            roundButton3.BackColor = Color.SpringGreen;
            roundButton3.BackColor2 = Color.Aquamarine;
        }
    }
}
