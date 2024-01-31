using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class Igloo : Abstract_Entity
    {
        private string igloo_Image = "Igloo.png";

        public Igloo(int row, int column) : base(row, column, 0, Map.Background_Color)
        {

        }

        public override void Draw(Graphics graphics)
        {
            //Draw Igloo Image
            using (Image myImage = Image.FromFile(Map.Path + this.igloo_Image))
            {
                Rectangle myRectangle = base.GetRectangle();
                graphics.DrawImage(myImage, myRectangle);
            }
        }
    }
}
