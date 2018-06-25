using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void DisplayForm2(Dictionary<string, Student> dictionary)
        {
            listView1.Items.Clear();
            label1.Text = "New Dictionary";
            ListViewItem lvi = new ListViewItem();

            foreach (KeyValuePair<string, Student> kpv in dictionary)
            {
                Student s = kpv.Value;
                double[] grades = s.Grades;
                List<string> row = new List<string> { s._id, s._name, s.GetAverageGrade().ToString("f2") };
                double[] gradesArray = s.Grades;
                foreach (double g in gradesArray)
                {
                    row.Add(g.ToString());
                }
                lvi = new ListViewItem(row.ToArray());
                listView1.Items.Add(lvi);
            }
        }

        public void DisplayForm2(Queue<Student> queue)
        {
            listView1.Items.Clear();
            label1.Text = "Queue from Dictionary";
            ListViewItem lvi = new ListViewItem();

            foreach (Student s in queue)
            {
                double[] grades = s.Grades;
                List<string> row = new List<string> { s._id, s._name, s.GetAverageGrade().ToString("f2") };
                double[] gradesArray = s.Grades;
                foreach (double g in gradesArray)
                {
                    row.Add(g.ToString());
                }
                lvi = new ListViewItem(row.ToArray());
                listView1.Items.Add(lvi);
            }
        }
    }
}
