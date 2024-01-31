using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Penguin_Maze.Classes.Pathfinding;

namespace Penguin_Maze.Classes.Entities
{
    public static class GameManager
    {
        public static Penguin penguin;
        public static int lives = 3;
        public static List<Enemy> enemies_list;
        public static List<Food> food_list;
        public static Igloo igloo;
        public static int currentLevel = 0;
        public static bool gameWinner = false;

        public static void Start_Game()
        {
            GameManager.gameWinner = false;
            //Clear the lists when loading a level
            if (GameManager.enemies_list != null)
            {
                GameManager.enemies_list.Clear();
            }
            if (GameManager.food_list != null)
            {
                GameManager.food_list.Clear();
            }
            GameManager.enemies_list = new List<Enemy>();
            GameManager.food_list = new List<Food>();            

            Map.Load_Data();            
        }

        public static void Lost_life()
        {
            if(--lives > 0)
            {
                Start_Game();                    
            }
            else
            {
                FormGameOver gameOverForm = new FormGameOver();
                gameOverForm.Show();
            }
        }

        public static List<Node> Find_path()
        {
            Node goalNode = new Node(row: GameManager.igloo.Row, column: GameManager.igloo.Column, null, null);
            Node startNode = new Node(row: GameManager.penguin.Row, column: GameManager.penguin.Column, goalNode, null);

            return AStar.FindPath(startNode, goalNode);
        }
    }
}
