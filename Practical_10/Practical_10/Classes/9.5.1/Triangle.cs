using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10.Classes._9._5._1
{
    public class Triangle : IPerimeterCalculatable2, IAreaCalculatable2
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double a, double b, double c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }

        public double CalculatePerimeter2()
        {
            return sideA + sideB + sideC;
        }

        public double CalculateArea2()
        {
            double s = CalculatePerimeter2() / 2;

            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            return area;
        }
    }
}
