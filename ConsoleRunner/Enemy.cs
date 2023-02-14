using System;

namespace ConsoleRunner
{
    public class Enemy : GameObject
    {
        public Enemy(Point position, Point size, char[] sprite) : base(position, size, sprite)
        {

        }

        public override void Update()
        {
            base.Update();

            Move(Point.Left);

            if (Position.X < 2)
                SetPosition(new Point(77, 24));
        }
    }
}
