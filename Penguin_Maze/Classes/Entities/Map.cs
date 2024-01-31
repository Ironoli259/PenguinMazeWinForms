using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public static class Map
    {
        public static int Tile_Size = 40;
        public static Color Background_Color = Color.White;        
        public static string Path = "../../Classes/Resources/";
        public static string[] Map_File = { "Level0.txt", "Level1.txt", "Level2.txt", "Level3.txt" };

        public static Abstract_Entity[,] abstract_Entities = null;
        public static List<Empty_Tile> empty_Tiles = new List<Empty_Tile>();

        public static int Max_Rows = 0;
        public static int Max_Columns = 0;

        public static void Load_Data()
        {
            
            string[] lines = File.ReadAllLines(Map.Path + Map_File[GameManager.currentLevel]);

            Map.Max_Rows = lines.Length;
            Map.Max_Columns = lines[0].Length;
            Map.abstract_Entities = new Abstract_Entity[Map.Max_Rows, Map.Max_Columns];

            int row = 0;
            int randomValue;

            foreach (string line in lines)
            {
                char[] chars = line.ToCharArray();
                int column = 0;

                foreach (char character in chars)
                {
                    Abstract_Entity obj = null;
                    switch (character)
                    {
                        case 'O': //Create Out of Bounds
                            obj = new OutOfBounds(row, column);
                            break;
                        case '#': //Create a Wall
                            obj = new Wall(row, column);
                            break;
                        case '.': //Create an Empty Tile
                            obj = new Empty_Tile(row, column);
                            break;
                        case 'P': //Create Penguin
                            obj = new Empty_Tile(row, column);
                            GameManager.penguin = new Penguin(row, column);
                            break;
                        case 'E': //Create an Enemy
                            randomValue = RNG.Get_Instance().Next(10);
                            if(randomValue < 7)
                                obj = new Shark(row, column);
                            else
                                obj = new Orca(row, column);
                            GameManager.enemies_list.Add(obj as Enemy);
                            break;
                        case 'F': //Create a Food Item
                            randomValue = RNG.Get_Instance().Next(10);
                            if(randomValue < 5)
                                obj = new Fish(row, column);
                            else if(randomValue < 8)
                                obj = new Crab(row, column);
                            else
                                obj = new Lobster(row, column);
                            GameManager.food_list.Add(obj as Food);
                            break;
                        case 'I': //Create an Igloo
                            obj = new Igloo(row, column);
                            GameManager.igloo = obj as Igloo;
                            break;
                        default:
                            obj = new Empty_Tile(row, column);
                            break;
                    }
                    Map.abstract_Entities[row, column] = obj;
                    column++;
                }//End of chars array
                row++;
            }//End of lines array
        }//End of Method Load

        public static bool Is_Valid_Tile(int row, int column)
        {
            int maxRows = Map.abstract_Entities.GetUpperBound(0);
            int maxColumns = Map.abstract_Entities.GetUpperBound(1);

            if (row >= 0 && column >= 0 && row < maxRows && column < maxColumns)
            {
                Abstract_Entity tile = Map.abstract_Entities[row, column];
                return !(tile is Wall);
            }
            return false;
        }
    }
}
