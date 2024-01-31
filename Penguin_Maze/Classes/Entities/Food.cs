using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penguin_Maze.Classes.Entities
{
    public abstract class Food : Living_Entity
    {
        protected string foodImage;        

        public Food(int row, int column, int healthValue) : base(row, column)
        {
            base.Score = healthValue;
        }

        public override void Draw(Graphics graphics)
        {
            //Draw Background
            base.Draw_Background(graphics);

            //Draw Image
            using (Image myImage = Image.FromFile(Map.Path + this.foodImage))
            {
                Rectangle myRectangle = base.GetRectangle();
                graphics.DrawImage(myImage, myRectangle);
            }
        }

        public override bool CanEat(Abstract_Entity entity)
        {
            throw new NotImplementedException();
        }

        public override bool CanPassThrough(Abstract_Entity entity)
        {
            throw new NotImplementedException();
        }

        public override void Eat(Abstract_Entity entity)
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

    }
}
