using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class Orca : Enemy
    {
        public Orca(int row, int column) : base(row, column, 50)
        {
            this.enemyImage = "Orca.png";
        }
    }
}
