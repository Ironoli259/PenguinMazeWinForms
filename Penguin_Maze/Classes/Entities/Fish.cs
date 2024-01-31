using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class Fish : Food
    {
        public Fish(int row, int column) : base(row, column, 20)
        {
            this.foodImage = "Fish.png";
        }        
    }
}
