using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону прямоугольника:");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону прямоугольника:");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Rectangle Rect = new Rectangle(s1, s2);
            Console.WriteLine("Площадь: " + Rect.Area);
            Console.WriteLine("Периметр: " + Rect.Perimeter);
        }
    }
}