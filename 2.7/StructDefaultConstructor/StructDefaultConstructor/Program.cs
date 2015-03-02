using System;

namespace StructDefaultConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point();
            var p2 = default(Point);

            Console.WriteLine($"P1  X: {p1.X}   Y: {p1.Y}");
            Console.WriteLine($"P2  X: {p2.X}   Y: {p2.Y}");

            Console.ReadKey();
        }
    }

    struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point Add(Point p1) 
            => new Point(p1.X + X, p1.Y + Y);

        public Point() 
            : this(5, 5)
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
}
