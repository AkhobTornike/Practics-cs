using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10.Classes
{
    public class TriangleCalculator : ShapeCalculator, ITrianglePerimeterCalculator
    {
       // 9.4.1
        public double CalculatePerimeter1(double side1, double side2, double side3) 
        {
            return side1 + side2 + side3;
        }

        double ITrianglePerimeterCalculator.CalculatePerimeter1(double side1, double side2, double side3)
        {
            throw new NotImplementedException();
        }
    }
}
