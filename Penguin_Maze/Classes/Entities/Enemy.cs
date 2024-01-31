using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public abstract class Enemy : Living_Entity
    {
        protected string enemyImage;

        protected Enemy(int row, int column, int damage) : base(row, column)
        {
            base.Score = damage;
        }

        public override void Draw(Graphics graphics)
        {
            //Draw Background
            base.Draw_Background(graphics);

            //Draw Image
            using (Image myImage = Image.FromFile(Map.Path + this.enemyImage))
            {
                Rectangle myRectangle = base.GetRectangle();
                graphics.DrawImage(myImage, myRectangle);
            }
        }
        public override bool CanPassThrough(Abstract_Entity entity)
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override bool CanEat(Abstract_Entity entity)
        {
            throw new NotImplementedException();
        }

        public override void Eat(Abstract_Entity entity)
        {
            if(entity is Penguin)
            {
                (entity as Penguin).Health -= this.Score;
                Console.WriteLine((entity as Penguin).Health);
            }
        }

    }
}
