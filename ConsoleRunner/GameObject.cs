using System;

namespace ConsoleRunner
{
    public class GameObject
    {
        public Point Position { get; private set; }
        public Point Size { get; private set; }

        private char[] sprite;

        public GameObject(Point position, Point size, char[] sprite)
        {
            Position = position;
            Size = size;
            this.sprite = sprite;
        }

        public void Move(Point delta)
        {
            Position += delta;
        }

        public void SetPosition(Point position)
        {
            Position = position;
        }

        virtual public void Update(){}

        public void Draw(GraphicsContext context)
        {
            context.Draw(sprite, Size, Position);
        }

        public bool Intersect(GameObject go)
        {
            bool aLeftOfB = Position.X + Size.X < go.Position.X;
            bool aRightOfB = Position.X > go.Position.X + go.Size.X;
            bool aAboveB = Position.Y > go.Position.Y + go.Size.Y;
            bool aBelowB = Position.Y + Size.Y < go.Position.Y;

            return !(aLeftOfB || aRightOfB || aAboveB || aBelowB);
        }
    }
}
