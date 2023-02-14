using System;

namespace ConsoleRunner
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static Point operator *(Point a, int b)
        {
            return new Point(a.X * b, a.Y * b);
        }

        public static Point Up = new Point(0, -1);
        public static Point Down = new Point(0, 1);
        public static Point Right = new Point(1, 0);
        public static Point Left = new Point(-1, 0);
        public static Point Zero =  new Point(0, 0);
    }    
}
