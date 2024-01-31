using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class RNG : Random
    {
        private static RNG instance = new RNG();
        private RNG() : base() { }

        public static RNG Get_Instance()
        {
            return instance;
        }
    }
}
