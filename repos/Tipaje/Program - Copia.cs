using System;

namespace Tipaje
{
    class Program
    {
        public class Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y) => (X, Y) = (x, y);
            
        
        }
        static int Main(string[] args)
        {
            string[] nombres = { "elena", "pablo", "alboran" };

            int  x = 1;
            
            
            Console.WriteLine($"x = {nombres[0]}");
            var p1 = new Point(2, 0);
            var p2 = new Point(10, 20);
            int  res = p1.X * p2.Y;
            Console.WriteLine(res);
            return p1.X;

        }
    }
}
