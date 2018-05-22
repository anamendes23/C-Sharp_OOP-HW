using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_IComparer
{
    public class Box : IComparable<Box>
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Volume()
        {
            return Lenght * Width * Height;
        }

        public double Area()
        {
            return 2 * (Lenght * Width + Lenght * Height + Width * Height);
        }

        public int CompareTo(Box other)
        {
            if (this.Volume() > other.Volume())
                return 1;
            if (this.Volume() < other.Volume())
                return -1;
            return 0;
        }
    }
}
