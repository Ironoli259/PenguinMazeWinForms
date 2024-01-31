using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class Crab : Food
    {
        public Crab(int row, int column) : base(row, column, 30)
        {
            this.foodImage = "Crab.png";
        }       
    }
}
