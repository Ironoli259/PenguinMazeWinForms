using Penguin_Maze.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public class Penguin : Living_Entity
    {
        private static readonly string[] imageFiles = { "PenguinNone.png", "PenguinUp.png", "PenguinDown.png", "PenguinLeft.png", "PenguinRight.png", "PenguinFight.png" };
        private List<Node> path = new List<Node>();

        private int health;
        private readonly int maxHealth;
        private int numHammer;

        public int Health { get => health; set => health = value; }
        public int NumHammer { get => numHammer; set => numHammer = value; }

        public Penguin(int row, int column) : base(row, column)
        {
            this.maxHealth = 50 + (50 * GameManager.currentLevel);
            this.health = this.maxHealth;
            this.numHammer = 3;
        }

        public override void Draw(Graphics graphics)
        {
            base.Draw_Background(graphics);
            Rectangle myRectangle = base.GetRectangle();

            int index = (int)base.Current_Direction;
            string myFileName = imageFiles[index];

            using (Image myImage = Image.FromFile(Map.Path + myFileName))
            {
                graphics.DrawImage(myImage, myRectangle);
            }
        }

        //------------------------------ MOVEMENT CLASSES ------------------------------//
        public override void Move()
        {
            Point velocity = this.GetVelocity();
            int next_Row = base.Row + velocity.Y;
            int next_Column = base.Column + velocity.X;
            bool hasMoved = !(base.Row == next_Row && base.Column == next_Column);
            Abstract_Entity next_Entity = Map.abstract_Entities[next_Row, next_Column];

            if (this.CanPassThrough(next_Entity))
            {
                this.Row = next_Row;
                this.Column = next_Column;

                Enemy enemy = Check_Enemy_Collision();
                if (enemy != null)
                {
                    enemy.Eat(this);
                }

                Food food = Check_Food_Collision();
                if (food != null)
                {
                    this.Eat(food);
                }
                if (hasMoved)
                {
                    this.health -= 2;
                }

                if (!IsAlive())
                {
                    GameManager.Lost_life();
                }
                ///////
            }
            this.Update_Path();
        }

        public void BreakWall()
        {
            Console.WriteLine("BreakWall");
            Point velocity = this.GetVelocity();
            int next_Row = base.Row + velocity.Y;
            int next_Column = base.Column + velocity.X;
            Abstract_Entity next_Entity = Map.abstract_Entities[next_Row, next_Column];

            if (next_Entity is Wall)
            {
                Empty_Tile floor = new Empty_Tile(next_Entity.Row, next_Entity.Column);
                Map.abstract_Entities[next_Entity.Row, next_Entity.Column] = floor;
                this.numHammer--;
            }
        }

        public override bool CanPassThrough(Abstract_Entity entity)
        {
            return !(entity is Wall || entity is OutOfBounds);
        }

        public Enemy Check_Enemy_Collision()
        {
            foreach (Enemy obj in GameManager.enemies_list)
            {
                if (obj.Row == this.Row && obj.Column == this.Column)
                {
                    return obj;
                }
            }
            return null;
        }


        //------------------------------ EAT CLASSES ------------------------------//
        public Food Check_Food_Collision()
        {
            foreach (Food obj in GameManager.food_list)
            {
                if (obj.Row == this.Row && obj.Column == this.Column)
                {
                    return obj;
                }
            }
            return null;
        }

        public override bool CanEat(Abstract_Entity entity)
        {
            return (entity is Food);
        }

        public override void Eat(Abstract_Entity entity)
        {
            this.health += entity.Score;
            if(this.health > this.maxHealth)
                this.health = this.maxHealth;

            Empty_Tile floor = new Empty_Tile(entity.Row, entity.Column);
            Map.abstract_Entities[entity.Row, entity.Column] = floor;
            GameManager.food_list.Remove((Food)entity);
        }

        //------------------------------ MISC CLASSES ------------------------------//

        public bool IsAlive()
        {
            return this.Health > 0;
        }

        public void Update_Path()
        {
            this.path = GameManager.Find_path();
            if(this.path.Count > 0)
            {
                this.path.RemoveAt(0);
            }
        }

        public void Draw_Path(Graphics graphics)
        {
            for (int i = 0; i < this.path.Count - 1; i++)
            {
                Node startNode = this.path[i];
                Node endNode = this.path[i + 1];

                int startX = (startNode.Column * Map.Tile_Size) + (Map.Tile_Size / 2);
                int startY = (startNode.Row * Map.Tile_Size) + (Map.Tile_Size / 2);
                Point startPoint = new Point(startX, startY);

                int endX = (endNode.Column * Map.Tile_Size) + (Map.Tile_Size / 2);
                int endY = (endNode.Row * Map.Tile_Size) + (Map.Tile_Size / 2);
                Point endPoint = new Point(endX, endY);

                Pen myPen = new Pen(Color.Red, 5);
                graphics.DrawLine(myPen, startPoint, endPoint);

                myPen.Dispose();
            }
        }
    }
}
