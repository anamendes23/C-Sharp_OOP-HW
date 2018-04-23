using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public class Box : RectangularShape
    {

        //constructor
        public Box(double l, double w, double h) : base(l, w, h) { }
        //method
        public override double Area()
        {
            return 2 * (L * W + W * H + L * H);
        }
        public override double Volume()
        {
            return L * W * H;
        }
    }
}
