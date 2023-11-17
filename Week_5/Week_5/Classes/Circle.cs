using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Classes
{
    class Circle : GeometricFigure
    {
        public double Radius { get; set; }
        
        public Circle(double radius) 
        {
            Radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
