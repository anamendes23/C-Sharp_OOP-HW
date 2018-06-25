using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Whale : IPicture
    {
        private string _fileName;
        private string _description;

        public Whale(string fileName, string description)
        {
            _fileName = fileName;
            _description = description;
        }

        public string GetDescription()
        {
            return _description;
        }

        public Image GetImage(string fileName)
        {
            return Image.FromFile(fileName);
        }
    }
}
