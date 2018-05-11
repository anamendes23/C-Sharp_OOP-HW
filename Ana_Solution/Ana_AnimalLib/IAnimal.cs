using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mime;
using System.Drawing;

namespace Ana_AnimalLib
{
    public interface IAnimal
    {
        //methods
        void Voice();
        bool IsCarnivore();
        bool IsHerbivore();
        bool IsOmnivore();
        Image GetPicture();
    }
}
