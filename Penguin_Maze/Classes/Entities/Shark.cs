using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class Shark : Enemy
    {
        public Shark(int row, int column) : base(row, column, 25)
        {
            this.enemyImage = "Shark.png";
        }
    }
}
