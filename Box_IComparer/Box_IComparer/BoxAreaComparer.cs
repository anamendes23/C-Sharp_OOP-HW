using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_IComparer
{
    public class BoxAreaComparer : IComparer<Box>
    {
        public int Compare(Box x, Box y)
        {
            if (x.Area() > y.Area())
                return 1;
            if (x.Area() < y.Area())
                return -1;
            return 0;
        }
    }
}
