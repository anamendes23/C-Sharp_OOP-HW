using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public class Cube : Square
    {
        private double h;
        //constructor
        public Cube(double l) : base(l)
        {
            this.h = l;
        }
        //property
        public override double H { get { return this.h; } }
        //method
        public override double Area()
        {
            return base.Area() * 6;
        }
        public override double Volume()
        {
            return Math.Pow(L, 3);
        }
    }
}
