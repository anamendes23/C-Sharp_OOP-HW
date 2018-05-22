/* Ana Mendes
 * anamendes23@gmail.com
 * github.com/anamendes23
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box_IComparer
{
    public partial class Form1 : Form
    {
        List<Box> boxList = new List<Box>();

        public Form1()
        {
            InitializeComponent();
            InitializeBoxList();
        }

        private void InitializeBoxList()
        {
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                double l = rand.Next(2, 10);
                double w = rand.Next(2, 10);
                double h = rand.Next((int)l, 20);

                Box box = new Box
                {
                    Lenght = l,
                    Width = w,
                    Height = h
                };

                boxList.Add(box);
            }
        }

        private void Display(List<Box> list)
        {
            listView1.Items.Clear();

            foreach (Box obj in list)
            {
                string[] row = {obj.Lenght.ToString("f2"), obj.Width.ToString("f2"), obj.Height.ToString("f2"),
                                obj.Volume().ToString("f2"), obj.Area().ToString("f2")};
                ListViewItem lvi = new ListViewItem(row);

                listView1.Items.Add(lvi);
            }
        }

        private void BtnSortByVolume_Click(object sender, EventArgs e)
        {
            boxList.Sort();
            Display(boxList);
        }

        private void BtnSortByArea_Click(object sender, EventArgs e)
        {
            BoxAreaComparer comparer = new BoxAreaComparer();
            boxList.Sort(comparer);
            Display(boxList);
        }
    }
}
