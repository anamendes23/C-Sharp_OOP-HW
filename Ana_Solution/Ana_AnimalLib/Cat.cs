using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ana_AnimalLib
{
    public abstract class Cat : Animal
    {
        //constructor
        public Cat(double weight, string imageFileName, string soundFile, string id) : 
            base(weight, imageFileName, soundFile, id) { }
        //methods
        public override abstract void Voice();

        public override bool IsCarnivore()
        {
            return true;
        }

        public override bool IsHerbivore()
        {
            return false;
        }

        public override bool IsOmnivore()
        {
            return false;
        }

        public override abstract Image GetPicture();
    }
}
