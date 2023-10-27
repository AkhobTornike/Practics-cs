using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Classes
{
    internal class ChildTriangle : Triangle
    {
        #region private fileds
        
        private int Triangle_Perimeter;

        #endregion

        #region public methods

        public int triangleFields 
        {
            get { return triangleFields; }
            set { triangleFields = value; }
        }

        public ChildTriangle(int side1, int side2, int side3) : base(side1, side2, side3)
        {

        }

        public ChildTriangle(int side1, int side2) : base(side1,side2, side2)
        {

        }

        public ChildTriangle(int side1) : base(side1, side1, side1)
        {

        }

        public int CalculatePerimeterOfTriangle()
        {
            return side1 + side2 + side3;
        }

        #endregion
    }
}
