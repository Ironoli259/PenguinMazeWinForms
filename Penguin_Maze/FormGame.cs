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
    public partial class FormGame : Form
    {
        public bool DISPLAY_PATH = false;

        public FormGame()
        {
            InitializeComponent();   
            
            GameManager.Start_Game();

            Resize_Window();
        }

        private void pictureBox_Map_Paint(object sender, PaintEventArgs e)
        {
            //Drawing the Tiles : Walls, Floors, Dots, Boosters, Fruits
            foreach (Abstract_Entity obj in Map.abstract_Entities)
            {
                obj.Draw(e.Graphics);
            }

            if (DISPLAY_PATH)
            {
                GameManager.penguin.Draw_Path(e.Graphics);
            }

            //Drawing Penguin
            GameManager.penguin.Draw(e.Graphics);

            this.label_Lives.Text = GameManager.lives.ToString();
            this.label_Hammers.Text = GameManager.penguin.NumHammer.ToString();
            this.label_Energy.Text = GameManager.penguin.Health.ToString();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            this.timer_Penguin.Enabled = GameManager.lives > 0;
            this.timer_Penguin.Enabled = !GameManager.gameWinner;
            this.Refresh();
        }

        private void timer_Penguin_Tick(object sender, EventArgs e)
        {
            GameManager.penguin.Move();
            if (GameManager.penguin.Row == GameManager.igloo.Row && GameManager.penguin.Column == GameManager.igloo.Column)
                this.Level_Up();
            
            this.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    GameManager.penguin.Current_Direction = Direction.UP;
                    break;
                case Keys.Down:
                case Keys.S:
                    GameManager.penguin.Current_Direction = Direction.DOWN;
                    break;
                case Keys.Left:
                case Keys.A:
                    GameManager.penguin.Current_Direction = Direction.LEFT;
                    break;
                case Keys.Right:
                case Keys.D:
                    GameManager.penguin.Current_Direction = Direction.RIGHT;
                    break;
                case Keys.Space:
                    if(GameManager.penguin.NumHammer > 0)
                        GameManager.penguin.BreakWall();
                    break;
            }
        }

        //IF ICE ISLANDS ARE IMPLEMENTED
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                case Keys.Down:
                case Keys.S:
                case Keys.Left:
                case Keys.A:
                case Keys.Right:
                case Keys.D:
                    //GameManager.penguin.Current_Direction = Direction.NONE;
                    break;
            }
        }

        private void HintButton_Click(object sender, EventArgs e)
        {
            DISPLAY_PATH = !DISPLAY_PATH;
        }

        private void Resize_Window()
        {
            this.pictureBox_Map.Width = Map.Max_Columns * Map.Tile_Size;
            this.pictureBox_Map.Height = Map.Max_Rows * Map.Tile_Size;

            int width = this.pictureBox_Map.Width;
            int height = this.pictureBox_Map.Height + this.pictureBox_Map.Location.Y;
            this.ClientSize = new Size(width, height);
        }

        private void Level_Up()
        {
            if (GameManager.currentLevel < 3)
            {
                GameManager.currentLevel++;
                GameManager.lives = 3;
                GameManager.Start_Game();
                Resize_Window();
            }
            else
            {
                GameManager.gameWinner = true;
                GameWinner gameWinnerForm = new GameWinner();
                gameWinnerForm.Show();
            }
        }        
    }
}
