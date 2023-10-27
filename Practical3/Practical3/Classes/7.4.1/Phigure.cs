using System;

namespace Practical3.Classes
{
    public class Phigure : Shape
    {
        protected double a, b, c, d;
        
        public Phigure(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override double Perimeter()
        {
            return a + b + c + d;
        }
    }
}
