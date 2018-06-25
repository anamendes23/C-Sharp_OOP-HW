using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalReview_2_Ana
{
    public abstract class _2DShape : IFillShape
    {
        //fields
        private int _x;
        private int _y;
        private int _side;
        private Color _color;

        //constructor
        public _2DShape(int x, int y, int width, int height, Color color)
        {
            _x = x;
            _y = y;
            _side = 2 * (width + height);
            _color = color;
        }

        public abstract void DrawShape(Graphics g, SolidBrush brush, int x1, int x2, int y1, int y2);

        public Bitmap Fill()
        {
            Bitmap bmap = new Bitmap(531,464);
            //create graphics object for this bitmap
            Graphics g = Graphics.FromImage(bmap);
            //create pen
            SolidBrush brush = new SolidBrush(_color);
            //get dimentions
            //origin in x
            int x1 = _x;
            //origin in y
            int y1 = _y;
            //width
            int x2 = _side / 2;
            //heigth
            int y2 = _side / 2;
            //call method
            DrawShape(g, brush, x1, x2, y1, y2);
            //return bitmap
            return bmap;
        }
    }
}
