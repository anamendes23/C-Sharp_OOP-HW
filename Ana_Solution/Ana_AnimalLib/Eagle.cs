using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ana_AnimalLib
{
    public class Eagle : Animal
    {
        //constructor
        public Eagle(double weight, string imageFileName, string soundFile, string id) : 
            base(weight, imageFileName, soundFile, id) { }
        //methods
        public override void Voice()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
        }

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
    }
}
