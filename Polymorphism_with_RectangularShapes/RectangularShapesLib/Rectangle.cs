using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public class Rectangle : RectangularShape
    {
        //constructor
        public Rectangle(double l, double w) : base(l, w, 0) { }
        //methods
        public override double Volume()
        {
            return 0;
        }
    }
}
