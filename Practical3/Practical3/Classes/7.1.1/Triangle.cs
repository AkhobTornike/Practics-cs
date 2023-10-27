using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Classes
{
    internal class Triangle
    {
        #region private fields

        private int side_1;
        private int side_2;
        private int side_3;

        #endregion

        #region constructor

        public Triangle(int side1, int side2, int side3)
        {
            side_1 = side1;
            side_2 = side2;
            side_3 = side3;
        }

        #endregion

        #region public fields

        public int side1
        {
            get { return side_1; } 
            set { side_1 = value; }
        }

        public int side2
        { 
            get { return side_2; }
            set { side_2 = value; }
        }

        public int side3
        {
            get { return side_3; }
            set { side_3 = value; }
        }

        #endregion
    }
}
