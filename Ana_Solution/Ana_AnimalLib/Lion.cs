using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ana_AnimalLib
{
    public class Lion : Cat
    {
        //constructor
        public Lion(double weight, string imageFileName, string soundFile, string id) : 
            base(weight, imageFileName, soundFile, id) { }
        //methods
        public override void Voice()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
        }

        public override Image GetPicture()
        {
            return Image.FromFile(ImageFileName);
        }
    }
}
