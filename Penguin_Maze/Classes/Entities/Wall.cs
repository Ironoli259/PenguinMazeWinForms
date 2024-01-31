using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class Wall : Abstract_Entity
    {
        private string wall_Image = "Wall.png";
        public Wall(int row, int column) : base(row, column, 0, Map.Background_Color)
        {

        }

        public override void Draw(Graphics graphics)
        {
            //Draw Wall Image
            using (Image myImage = Image.FromFile(Map.Path + this.wall_Image))
            {
                Rectangle myRectangle = base.GetRectangle();
                graphics.DrawImage(myImage, myRectangle);
            }
        }
    }
}
