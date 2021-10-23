using System;
using System.Collections.Generic;
using System.Text;


namespace WinFormsApp1
{
    class Triangle
    {
        public double side_1;
        public double side_2;
        public double side_3;

        public static bool checkSides(double a, double b, double c)
        {
            if(a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Triangle(double a, double b, double c)
        {
            try
            {
                if(!checkSides(a, b, c))
                {
                    throw new Exception();
                }
                else
                {
                    side_1 = a;
                    side_2 = b;
                    side_3 = c;
                }
            }
            catch(Exception e)
            {

            }
        }
        public List<double> determineAngles()
        {
            List<double> angles = new List<double>();
            double angle_1 = Math.Round(Math.Acos((side_1 * side_1 + side_2 * side_2 - side_3 * side_3) / (2 * side_1 * side_2))*(180/Math.PI), 2);
            angles.Add(angle_1);
            double angle_2 = Math.Round(Math.Acos((side_1 * side_1 + side_3 * side_3 - side_2 * side_2) / (2 * side_1 * side_3)) * (180 / Math.PI), 2);
            angles.Add(angle_2);
            double angle_3 = Math.Round(Math.Acos((side_3 * side_3 + side_2 * side_2 - side_1 * side_1) / (2 * side_3 * side_2)) * (180 / Math.PI), 2);
            angles.Add(angle_3);
            return angles;
        }

        public double determinePerimeter()
        {
            return Math.Round(side_1 + side_2 + side_3, 2);
        }
    }

    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle (double a, double b, double c) : base (a, b, c)
        {

        }

        public double determineArea()
        {
            return Math.Round((side_1 * side_1 * Math.Sqrt(3)) / 4, 2);
        }
    }
}
