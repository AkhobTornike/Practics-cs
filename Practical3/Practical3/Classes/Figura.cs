using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Classes
{
    internal class Figura
    {
        #region private fields

        #region triangle

        protected int Side1;
        protected int Side2;
        protected int Side3;

        #endregion

        #region rectangle

        protected int height;
        protected int width;

        #endregion

        #endregion

        #region public fields

        public int side1
        {
            get => Side1;
            set => Side1 = value;
        }

        public int side2
        {
            get => Side2;
            set => Side2 = value;
        }

        public int side3
        {
            get => Side3;
            set => Side3 = value;
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }

        #endregion

    }
}
