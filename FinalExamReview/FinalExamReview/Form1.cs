/* Ana Mendes
 * anamendes23@gmail.com
 * github.com/anamendes23
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        /* What is an Interface?
         * An interface contains only the signatures of methods, properties, events or indexers.
         * A class or struct that implements the interface MUST implement the members of the interface 
         * that are specified in the interface definition. 
         * */
        string lionFileName = "Lion.jpg";
        string elephantFileName = "Elephant.jpg";
        string whaleFileName = "Whale.jpg";

        public Form1()
        {
            InitializeComponent();            
        }

        private void BtnLion_Click(object sender, EventArgs e)
        {
            Lion lion = new Lion(lionFileName, $"Picture of a Lion");
            pictureBox1.Image = lion.GetImage(lionFileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            richTextBox1.Text = lion.GetDescription();
        }

        private void BtnElephant_Click(object sender, EventArgs e)
        {
            Elephant elephant = new Elephant(elephantFileName, $"Picture of an Elephant");
            pictureBox1.Image = elephant.GetImage(elephantFileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            richTextBox1.Text = elephant.GetDescription();
        }

        private void BtnWhale_Click(object sender, EventArgs e)
        {
            Whale whale = new Whale(whaleFileName, $"Picture of a Whale");
            pictureBox1.Image = whale.GetImage(whaleFileName);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            richTextBox1.Text = whale.GetDescription();
        }
    }
}
