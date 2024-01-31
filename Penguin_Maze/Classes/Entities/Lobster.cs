using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class Lobster : Food
    {
        public Lobster(int row, int column) : base(row, column, 40)
        {
            this.foodImage = "Lobster.png";
        }
    }
}
