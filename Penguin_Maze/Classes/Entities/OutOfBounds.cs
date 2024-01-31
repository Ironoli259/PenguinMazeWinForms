using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class OutOfBounds: Abstract_Entity
    {
        public OutOfBounds(int row, int column) : base(row, column, 0, Map.Background_Color)
        {

        }
        public override void Draw(Graphics graphics)
        {
            Rectangle myRectangle = this.GetRectangle();
            Brush myBrush = new SolidBrush(Color.LightCyan);
            graphics.FillRectangle(myBrush, myRectangle);

            myBrush.Dispose();
        }
    }
}
