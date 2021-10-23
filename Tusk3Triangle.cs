using System;
using System.Collections.Generic;
using System.Text;

namespace Triangles
{
    abstract class Triangle
    {
        protected double a;
        protected double b;
        protected double gamma;

        public Triangle(double a, double b, double gamma)
        {
            this.a = a;
            this.b = b;
            this.gamma = gamma;
        }
        public virtual double area()
        {
            return Math.Round((a * b * Math.Sin((Math.PI / 180) * gamma))/2, 2);
        }
        public virtual double perimeter()
        {
            double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos((Math.PI / 180) * gamma));
            return Math.Round(a + b + c, 2);
        }
    }

    class RightTriangle : Triangle
    {
        public RightTriangle(double side1, double side2) : base(side1, side2, 90)
        {

        }
        public override double area()
        {
            return Math.Round((a * b) / 2, 2);
        }

        public override double perimeter()
        {
            double c = Math.Sqrt(a * a + b * b);
            return Math.Round(a + b + c, 2);
        }
    }

    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double side, double gam) : base(side, side, gam)
        {

        }
        public override double area()
        {
            return Math.Round((a * a * Math.Sin((Math.PI / 180) * gamma))/2, 2);
        }
        public override double perimeter()
        {
            return Math.Round(2 * a + Math.Sqrt(2 * a * a - 2 *a*a* Math.Cos((Math.PI / 180) * gamma)), 2);
        }
    }
}
