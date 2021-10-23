using System;
using System.Collections.Generic;
using System.Text;

namespace figures
{
    abstract class Figure
    {
        public abstract double determineArea();
        public abstract double determinePerimeter();
    }

    class Circle : Figure
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }
        public override double determineArea()
        {
            return Math.Round(Math.PI * radius * radius, 2);
        }
        public override double determinePerimeter()
        {
            return Math.Round(2 * Math.PI * radius, 2);
        }
    }

    class Diamond : Figure
    {
        private double side;
        private double angle;

        public Diamond(double s, double ang)
        {
            side = s;
            angle = ang;
        }

        public override double determineArea()
        {
            return Math.Round(side * side * Math.Sin((Math.PI/180)*angle), 2);
        }
        public override double determinePerimeter()
        {
            return 4 * side;
        }
    }

    class Triangle : Figure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double a, double b, double c)
        {
            side1 = a;
            side2 = b;
            side3 = c;
        }

        public static bool checkSides(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double determineArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Round(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)), 2);
        }
        public override double determinePerimeter()
        {
            return side1 +  side2 + side3;
        }
    }

    class Square : Figure
    {
        private double side;

        public Square(double s)
        {
            side = s;
        }

        public override double determineArea()
        {
            return side * side;
        }
        public override double determinePerimeter()
        {
            return 4 * side;
        }
    }

    class Rectangle : Figure
    {
        private double side1;
        private double side2;

        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public override double determineArea()
        {
            return side1 * side2;
        }

        public override double determinePerimeter()
        {
            return 2*(side1 + side2);
        }
     }
}
