using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Classes
{
    internal class Kvadrati : Figura
    {
        public Kvadrati(int Height, int Width) : base() 
        {
            Height = height;
            Width = width;
        }

        public int rectangleArea()
        {
            return Height * Width;
        }
    }
}
