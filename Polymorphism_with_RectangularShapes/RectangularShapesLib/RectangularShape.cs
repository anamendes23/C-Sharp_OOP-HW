using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularShapesLib
{
    public abstract class RectangularShape
    {
        //Fields
        private double l;
        private double w;
        private double h;
        //Constructor
        public RectangularShape(double l, double w, double h)
        {
            this.l = l;
            this.w = w;
            this.h = h;
        }
        public RectangularShape(double l, double w)
        {
            this.l = l;
            this.w = w;
        }
        //Properties
        public virtual double L { get { return this.l; } }
        public virtual double W { get { return this.w; } }
        public virtual double H { get { return this.h; } }
        //Methods
        public virtual double Perimeter()
        {
            return 2 * (l + w);
        }
        public virtual double Area()
        {
            return l * w;
        }
        public abstract double Volume();
    }
}
