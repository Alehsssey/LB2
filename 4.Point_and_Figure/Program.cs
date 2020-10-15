using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(
                            new Point(8, 1, "A"),
                            new Point(3, 2, "B"),
                            new Point(21, 32, "C"),
                            new Point(48, 177, "D"),
                            new Point(-498, 174, "E"));
            figure.Perimeter();
        }
    }
}
