using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ana_AnimalLib
{
    public abstract class Animal : IAnimal
    {
        //fields
        private double _weight; /* lb */
        private string _imageFileName;
        private string _soundFile;
        private string _id;
        //constructor
        public Animal(double weight, string imageFileName, string soundFile, string id)
        {
            _weight = weight;
            _imageFileName = imageFileName;
            _soundFile = soundFile;
            _id = id;
        }
        //properties
        public double Weight { get => _weight; }

        public string ImageFileName { get => _imageFileName; }

        public string SoundFile { get => _soundFile; }

        public string ID { get => _id; }
        //methods
        public abstract void Voice();

        public abstract bool IsCarnivore();

        public abstract bool IsHerbivore();

        public abstract bool IsOmnivore();

        public virtual Image GetPicture()
        {
            return Image.FromFile(_imageFileName);
        }
    }
}
