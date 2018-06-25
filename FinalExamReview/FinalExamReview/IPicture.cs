using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Exercise_1
{
    interface IPicture
    {
        Image GetImage(string fileName);
        string GetDescription();
    }
}
