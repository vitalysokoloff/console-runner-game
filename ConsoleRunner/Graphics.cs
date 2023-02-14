using System;

namespace ConsoleRunner
{
    public class Graphics
    {
        public GraphicsContext Context { get; }
        public char BackGroundChar { get; set; }

        public Graphics(int width, int height, char background)
        {
            Context = new GraphicsContext(width, height);
            BackGroundChar = background;
            Reset();
        }

        private void Reset()
        {
            Context.Reset(BackGroundChar);
        }

        public void Begin()
        {
            Reset();
            Console.SetCursorPosition(0, 0);
        }

        public void End()
        {
            Console.WriteLine(Context.Buffer);
        }
    }
}
