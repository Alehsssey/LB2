using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Point
    {
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
        public int X { get; }
        public int Y { get; }
        public string Name { get; }
    }
}
