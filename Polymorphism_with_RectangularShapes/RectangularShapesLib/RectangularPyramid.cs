using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public class RectangularPyramid : Box
    {
        //constructor
        public RectangularPyramid(double l, double w, double h) : base(l, w, h) { }
        //method
        public override double Area()
        {
            return L * W + L * Math.Sqrt(Math.Pow((W / 2), 2) + Math.Pow(H, 2)) + 
                    W * Math.Sqrt(Math.Pow((L / 2), 2) + Math.Pow(H, 2));
        }
        public override double Volume()
        {
            return base.Volume() / 3;
        }
    }
}
