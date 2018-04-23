using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RectangularShapesLib;

namespace Polymorphism_with_RectangularShapes
{
    public partial class Form1 : Form
    {
        List<RectangularShape> rsList = new List<RectangularShape>();
        public Form1()
        {
            InitializeComponent();
        }
        //*****************************EVENTS************************************
        private void btnCreateRectangle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double length = rand.Next(2, 20) + rand.NextDouble();
            double width = rand.Next(2, 20) + rand.NextDouble();
            //create a Circle
            Rectangle r = new Rectangle(length, width);
            //save
            rsList.Add(r);
            //display
            Display(r);
        }

        private void btnCreateSquare_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double length = rand.Next(2, 20) + rand.NextDouble();
            //create a Circle
            Square s = new Square(length);
            //save
            rsList.Add(s);
            //display
            Display(s);
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double length = rand.Next(2, 20) + rand.NextDouble();
            double width = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(2, 20) + rand.NextDouble();
            //create a Circle
            Box b = new Box(length, width, height);
            //save
            rsList.Add(b);
            //display
            Display(b);
        }

        private void btnCreateCube_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double length = rand.Next(2, 20) + rand.NextDouble();
            //create a Circle
            Cube c = new Cube(length);
            //save
            rsList.Add(c);
            //display
            Display(c);
        }

        private void btnCreateRectPyramid_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double length = rand.Next(2, 20) + rand.NextDouble();
            double width = rand.Next(2, 20) + rand.NextDouble();
            double height = rand.Next(2, 20) + rand.NextDouble();
            //create a Circle
            RectangularPyramid rp = new RectangularPyramid(length, width, height);
            //save
            rsList.Add(rp);
            //display
            Display(rp);
        }
        //*****************************METHODS***********************************
        private void Display(RectangularShape rs)
        {
            string[] items = {rs.GetType().Name,
                                rs.L.ToString("f3"),                                
                                rs.H.ToString("f3"),
                                rs.Perimeter().ToString("f3"),
                                rs.Area().ToString("f3"),
                                rs.Volume().ToString("f3"),
                                rs.W.ToString("f3")};
            ListViewItem lvi = new ListViewItem(items);
            //add the row to the listview
            listView1.Items.Add(lvi);
            //cause the listview1 to scroll down automatically
            //by making the last item visible
            listView1.EnsureVisible(listView1.Items.Count - 1);
        }
    }
}
