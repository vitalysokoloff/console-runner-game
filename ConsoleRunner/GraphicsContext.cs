using System;

namespace ConsoleRunner
{
    public class GraphicsContext
    {
        public char[] Buffer { get; }
        public int Width { get; }
        public int Height { get; }

        public GraphicsContext(int width, int height)
        {
            Width = width;
            Height = height;
            Buffer = new char[Width * Height];
        }

        public void Reset(char bg)
        {
            for (int i = 0; i < Buffer.Length; i++)
            {
                Buffer[i] = bg;
            }
        }

        public void Draw(char[] sprite, Point size, Point position)
        {
            for (int i = 0; i < size.X; i++)
            {
                for (int j = 0; j < size.Y; j++)
                {
                    if (sprite[i + j * size.X] != ' ')
                        Buffer[i  + j * Width + position.X + position.Y * Width] = sprite[i + j * size.X];
                }
            }
        }
    }
}
