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
    public partial class Menu : Form
    {
        public int level = 3;
        public Menu()
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Play_Click_1(object sender, EventArgs e)
        {
            Form1 game = new Form1(this);
            game.Show();
            this.Hide();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Меню";
        }
    }
}
