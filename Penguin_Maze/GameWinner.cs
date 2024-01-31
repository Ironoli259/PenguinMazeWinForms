using Penguin_Maze.Classes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penguin_Maze
{
    public partial class GameWinner : Form
    {
        public GameWinner()
        {
            InitializeComponent();
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            GameManager.currentLevel = 0;
            GameManager.lives = 3;
            GameManager.Start_Game();
            this.Close();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
