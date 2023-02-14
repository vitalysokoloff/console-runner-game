using System;

namespace ConsoleRunner
{
    public class Player : GameObject
    {
        private bool keyPressed = false;
        private bool playerToUp = false;

        public Player(Point position, Point size, char[] sprite): base (position, size, sprite)
        {
            
        }

        public override void Update()
        {
            if (keyPressed)
            {
                if (Position.Y == 22)
                    playerToUp = true;
            }

            if (playerToUp)
            {
                Move(Point.Up);
                if (Position.Y == 0)
                {
                    playerToUp = false;
                    keyPressed = false;
                }
            }
            else
            {
                if (Position.Y != 22)
                    Move(Point.Down);
            }
        }

        public void KeyControl(ConsoleKey key)
        {
            if (key == ConsoleKey.Spacebar && !keyPressed)
                keyPressed = true;
        }
    }
}
