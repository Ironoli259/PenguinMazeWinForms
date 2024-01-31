using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public abstract class Abstract_Entity
    {
        private int row;
        private int column;
        private int score;
        private Color entity_color;

        protected Abstract_Entity(int row, int column, int score, Color entity_color)
        {
            this.row = row;
            this.column = column;
            this.score = score;
            this.entity_color = entity_color;
        }
        #region Properties
        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public int Score { get => score; set => score = value; }
        public Color Entity_color { get => entity_color; set => entity_color = value; }
        #endregion

        public abstract void Draw(Graphics graphics);

        public Rectangle GetRectangle()
        {
            int pointX = this.column * Map.Tile_Size;
            int pointY = this.row * Map.Tile_Size;
            int width = Map.Tile_Size;
            int height = Map.Tile_Size;

            return new Rectangle(pointX, pointY, width, height);
        }

        public void Draw_Background(Graphics graphics)
        {
            Rectangle myRectangle = this.GetRectangle();
            Brush myBrush = new SolidBrush(Map.Background_Color);
            graphics.FillRectangle(myBrush, myRectangle);

            myBrush.Dispose();
        }
    }
}
