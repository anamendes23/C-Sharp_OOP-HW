using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalReview_2_Ana
{
    public class Square : _2DShape
    {
        //constructor
        public Square(int x, int y, int width, int height, Color color) : base(x, y, width, height, color) { }

        public override void DrawShape(Graphics g, SolidBrush brush, int x1, int x2, int y1, int y2)
        {
            g.FillRectangle(brush, x1, y1, x2, y2);
        }
    }
}
