using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Rectangle
    {
        double side1, side2, area, perimeter;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            area = side1 * side2;
            return area;
        }
        public double PerimeterCalculator()
        {
            perimeter = 2 * side1 + 2 * side2;
            return perimeter;
        }
        public double Perimeter
        {
            get
            {
                PerimeterCalculator();
                return perimeter;
            }
        }
        public double Area
        {
            get
            {
                AreaCalculator();
                return area;
            }
        }
    }
}