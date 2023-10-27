using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3.Classes
{
    internal class TriangleChild : TriangleParrent
    {
        #region private fields

        public new int Side1 { get; set; }
        public new int Side2 { get; set; }
        public new int Side3 { get; set; }

        #endregion

        #region count perimeter of parrent

        public int ParrentPerimeter()
        {
            return base.Side1 + base.Side2 + base.Side3;
        }

        public int ChildPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        #endregion
    }
}
