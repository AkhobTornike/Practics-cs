using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Classes
{
    internal class Samkutxedi : Figura
    {
        public Samkutxedi(int side1, int side2, int side3) : base()
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public int trianglePerimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
