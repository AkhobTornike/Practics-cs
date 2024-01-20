using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10.Classes
{
    // 9.4.1
    public class ShapeCalculator
    {
        public virtual double CalculateArea1(double baseLengt, double height)
        {
            return 0.5 * baseLengt * height;
        }
    }
}
