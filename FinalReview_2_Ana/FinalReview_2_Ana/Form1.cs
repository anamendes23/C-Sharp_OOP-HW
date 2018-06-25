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

namespace FinalReview_2_Ana
{
    public partial class Form1 : Form
    {
        //1. Define an abstract class, using your own words and provide a complete statement(for full credit)
        //       an abstract class has at least one abstract method that must be implemented by a child of the abstract class
        //       in the abstract class, the abstract methods cannot have a body.
        //2. What is the difference between an abstract class and an interface. Use your own words and 
        //provide complete statements(for full credit)
        //       Other classes inherit from an abstract class and implement an interface. Interfaces don't have fields
        //       or constructor, only properties and methods and they are all public and abstract. The child MUST implement
        //       ALL methods and propeties. An interface can't create an instance of an object.


        //-------------------------------GLOBAL VARIABLES----------------------------------------
        List<_2DShape> shapes = new List<_2DShape>();
        Queue<int> queue = new Queue<int>(20);
        Stack<int> stack = new Stack<int>(20);
        Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();

        static List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
           new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
           new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
           new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
           new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
           new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
           new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
           new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
           new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
           new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
           new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91} }
        };

        //-------------------------------FORM 1--------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            InitializeShapes();
            InitializeDic();
        }
        //-------------------------------INITIALIZE SHAPES---------------------------------------
        public void InitializeShapes()
        {
            //create 3 squares
            Square s1 = new Square(0, 0, 30, 30, Color.Aquamarine);
            Square s2 = new Square(60, 60, 20, 20, Color.Red);
            Square s3 = new Square(100, 100, 10, 10, Color.Olive);
            shapes.Add(s1);
            shapes.Add(s2);
            shapes.Add(s3);
            //create 3 circles
            Circle c1 = new Circle(0, 200, 30, 30, Color.Navy);
            Circle c2 = new Circle(60, 180, 20, 20, Color.Orange);
            Circle c3 = new Circle(100, 160, 10, 10, Color.Green);
            shapes.Add(c1);
            shapes.Add(c2);
            shapes.Add(c3);
        }
        //-------------------------------INITIALIZE STUDENT DICTIONARY---------------------------
        private void InitializeDic()
        {
            foreach (Student s in students)
            {
                studentDictionary.Add(s.ID, s);
            }
        }
        //-------------------------------DISPLAY SHAES MEHOTD------------------------------------
        private void Display(List<_2DShape> shapes, PaintEventArgs e)
        {
            foreach (_2DShape s in shapes)
            {
                Bitmap bmap = s.Fill();
                Image image = (Image)bmap;
                e.Graphics.DrawImage(image, panel1.Location.X, panel1.Location.Y);
            }
        }
        //-------------------------------PAINT EVENT--------------------------------------------
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Display(shapes, e);
        }
        //-------------------------------REVERSE QUEUE METHOD----------------------------------
        private void ReverseQueue(Queue<int> queue)
        {
            //int temp;
            //int inter;
            //int counter = 0;
            //for (int i = 0; i < queue.Count - 1; i++)
            //{
            //    for (int j = 0; j < queue.Count - 1; j++)
            //    {
            //        temp = queue.Dequeue();
            //        queue.Enqueue(temp);                    
            //        for (int k = 0; k < counter; k++)
            //        {
            //            inter = queue.Dequeue();
            //            temp = queue.Dequeue();
            //            queue.Enqueue(temp);
            //        }
            //        queue.Enqueue(inter);
            //    }
            //    counter++;             
            //}

            if(queue.Count != 0)
            {
                int temp = queue.Dequeue();
                ReverseQueue(queue);
                queue.Enqueue(temp);
            }
        }
        //-------------------------------DISPLAY QUEUE METHOD----------------------------------
        private void Display(Queue<int> queue)
        {
            richTextBox1.AppendText("Queue: ");
            foreach (int x in queue)
                richTextBox1.AppendText(x + " ");
        }
        //-------------------------------DISPLAY STACK METHOD----------------------------------
        private void Display(Stack<int> stack)
        {
            richTextBox1.AppendText("Stack: ");
            foreach (int x in stack)
                richTextBox1.AppendText(x + " ");
        }
        //-------------------------------BUTTON DISPLAY STUFF--------------------------------
        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            Display(queue);
            ReverseQueue(queue);
            richTextBox1.AppendText("\nReverse\n");
            Display(queue);
            richTextBox1.AppendText("\n");
            Display(stack);
            ReverseStack(stack);
            richTextBox1.AppendText("\nReverse\n");
            Display(stack);
        }
        //-------------------------------FORM LOAD -------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(rand.Next(10, 50));
                stack.Push(rand.Next(10, 50));
            }
        }
        //-------------------------------REVERSE STACK METHOD----------------------------------
        private void ReverseStack(Stack<int> stack)
        {
            int[] tempArray = new int[stack.Count];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = stack.Pop();
            }
            foreach (int item in tempArray)
            {
                stack.Push(item);
            }
        }
        //-------------------------------DISPLAY ODDS METHOD----------------------------------
        private void DisplayOdds(int num)
        {
            //clear
            richTextBox1.Clear();
            //display odds  
            for (int i = 0; i < 10; i++)
            {
                //check if number is even
                if (num % 2 == 0)
                {
                    num++;
                    richTextBox1.AppendText(num + " ");
                }                    
                num += 2;
                richTextBox1.AppendText(num + " ");
            }                
        }
        //-------------------------------RECURSIVE DISPLAY ODDS METHOD--------------------------
        private void RecursiveDisplayOdds(int num, int counter)
        {
            if(num % 2 == 0)
            {
                num++;
                richTextBox1.AppendText(num + " ");
                RecursiveDisplayOdds(num + 2, counter + 1);
            }
            else
            {
                if (counter > 10)
                    return;
                if(counter != 0)
                {
                    richTextBox1.AppendText(num + " ");
                    RecursiveDisplayOdds(num + 2, counter + 1);
                }
                else
                    RecursiveDisplayOdds(num + 2, counter + 1);
            }

            //listbox.Items.Add(value);
            //
            //if(counter != 10)
            //{
            //      if(value % 2 == 0) RecursiveOdd(value + 1, ++counter)
            //      else RecursiveOdd(value + 2, ++counter);
            //}
        }
        //-------------------------------BUTTON DISPLAY ODDS------------------------------------
        private void BtnDisplayOdds_Click(object sender, EventArgs e)
        {
            DisplayOdds(2);
            RecursiveDisplayOdds(2, 0);
        }
        //-------------------------------BUTTON TO SEARCH STUDENT BY ID------------------------
        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBox1.Text);
                Student s = new Student();
                studentDictionary.TryGetValue(ID, out s);
                string message = $"Name: {s.First} {s.Last} ID: {s.ID}";
                MessageBox.Show(message);
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}
