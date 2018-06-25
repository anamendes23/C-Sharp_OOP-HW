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

namespace Exercise_3
{
    public partial class Form1 : Form
    {
        //**************************GLOBAL VARIABLES***************************************

        Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();

        //*********************************FORM1*******************************************

        public Form1()
        {
            InitializeComponent();
            InitializeStudents();
        }

        //*************************METHOD - INITIALIZE STUDENTS****************************

        private void InitializeStudents()
        {
            Random rand = new Random();

            List<Student> students = new List<Student>();
            //create 10 students
            Student s1 = new Student("Jensine", rand.Next(1111, 9999).ToString());
            Student s2 = new Student("Ryan", rand.Next(1111, 9999).ToString());
            Student s3 = new Student("Lane", rand.Next(1111, 9999).ToString());
            Student s4 = new Student("Katie", rand.Next(1111, 9999).ToString());
            Student s5 = new Student("Vincent", rand.Next(1111, 9999).ToString());
            Student s6 = new Student("Omar", rand.Next(1111, 9999).ToString());
            Student s7 = new Student("Kris", rand.Next(1111, 9999).ToString());
            Student s8 = new Student("Rob", rand.Next(1111, 9999).ToString());
            Student s9 = new Student("Cornell", rand.Next(1111, 9999).ToString());
            Student s10 = new Student("Eric", rand.Next(1111, 9999).ToString());
            //add to the list
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);
            //add 5 grades
            for (int i = 0; i < students.Count(); i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    students[i].AddGrade(rand.Next(40, 100));
                }
                //add students to dictionary
                studentDictionary.Add(students[i]._id, students[i]);
            }            
        }

        //***************************DISPLAY METHODS/EVENTS***********************************

        public void Display(Dictionary<string, Student> dictionary)
        {
            listView1.Items.Clear();
            ListViewItem lvi = new ListViewItem();

            foreach(KeyValuePair<string, Student> kvp in dictionary)
            {
                Student s = kvp.Value;
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

        private void Display(Student s)
        {
            listView1.Items.Clear();

            double[] grades = s.Grades;
            List<string> row = new List<string> { s._id, s._name, s.GetAverageGrade().ToString("f2") };
            double[] gradesArray = s.Grades;
            foreach (double g in gradesArray)
            {
                row.Add(g.ToString());
            }
            ListViewItem lvi = new ListViewItem(row.ToArray());
            listView1.Items.Add(lvi);
        }

        private void BtnDisplayAllStudents_Click(object sender, EventArgs e)
        {
            Display(studentDictionary);
        }

        //*************************************GetStudentById*********************************

        private Student GetStudentById(string id)
        {
            Student s;

            try
            {
                if(studentDictionary.TryGetValue(id, out s))
                    return s;
                else
                {
                    MessageBox.Show("Student not found under id");
                    return null;
                }
            }
            catch(FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return null;
            }
        }

        private void BtnGetStudentById_Click(object sender, EventArgs e)
        {
            //get id
            string id = textBox1.Text;
            //call method
            Student s = GetStudentById(id);
            //display
            Display(s);
        }

        //****************************REMOVE STUDENT*********************************

        private bool RemoveStudentById(string id)
        {
            try
            {
                if (studentDictionary.ContainsKey(id))
                {
                    //add messagebox to send confirmation question
                    DialogResult result =
                        MessageBox.Show(this, $"Are you sure you want to delete student with id {id}?", 
                                                "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        studentDictionary.Remove(id);

                    return true;
                }
                else
                    return false;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
                return false;
            }
        }

        private void BtnRemoveStudentById_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            bool remove = RemoveStudentById(id);
            if (remove)
                MessageBox.Show($"Student of id {id} was removed");
            else
                MessageBox.Show("Student not found under id");

            Display(studentDictionary);
        }

        //****************************BUTTON EVENT - ADD GRADE*********************************

        int counterGrade = 5;
        private void BtnAddGrade_Click(object sender, EventArgs e)
        {            
            try
            {
                if(listView1.SelectedItems.Count > 0)
                {
                    int index = listView1.SelectedIndices[0];
                    string id = listView1.Items[index].SubItems[0].Text;
                    Student s = studentDictionary[id];
                    double grade = double.Parse(textBox2.Text);

                    if (grade >= 0 && grade <= 100)
                        s.AddGrade(grade);

                    if(counterGrade < s.GradeListSize)
                    {
                        counterGrade++;
                        //add column in listview
                        listView1.Columns.Add($"Grade {counterGrade}");                        
                    }                   

                    Display(studentDictionary);
                }           
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
        }

        //*********************BUTTON EVENT - ADD 10 POINTS TO LOWEST GRADE***********************

        private void Btn10Points_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //get selected student
                int index = listView1.SelectedIndices[0];
                string id = listView1.Items[index].SubItems[0].Text;
                Student s = studentDictionary[id];
                //set variables for comparison
                double lowestGrade = 100;
                int lowestIndex = 0;
                //get list of grades
                double[] grades = s.Grades;
                //get lowest grade
                for (int i = 0; i < grades.Length; i++)
                {
                    if (grades[i] < lowestGrade)
                    {
                        lowestGrade = grades[i];
                        lowestIndex = i;
                    }                        
                }
                //add 10 points
                lowestGrade += 10;
                if (lowestGrade <= 100)
                    s.ReplaceGrade(lowestIndex, lowestGrade);
                else
                    s.ReplaceGrade(lowestIndex, 100);

                Display(s);
            }
        }

        //*************************METHOD REMOVE LAST ITEM FROM QUEUE*******************

        private int RemoveLastItemFromQueue(Queue<int> queue)
        {
            //created Queue type int for simplicity
            //can't use additional queue or collection
            int nOfItems = queue.Count();
            int queueItem;

            //loop through Queue nOfItems - 1 times
            for (int i = 0; i < nOfItems - 1; i++)
            {
                //remove first item
                queueItem = queue.Dequeue();
                //add it to end
                queue.Enqueue(queueItem);
            }
            //remove last item, which is the first now
            return queue.Dequeue();            
        }

        private void Display(Queue<int> queue)
        {
            richTextBox1.AppendText("Queue: ");
            foreach (int x in queue)
                richTextBox1.AppendText(x + " ");
        }

        private void BtnRemoveLastFromQueue_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Queue<int> queue = new Queue<int>(20);
            Random rand = new Random();
            //populate queue
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next(100);
                queue.Enqueue(x);
            }
            //display original queue
            Display(queue);
            //remove last
            int lastItem = RemoveLastItemFromQueue(queue);
            MessageBox.Show($"Last item {lastItem} was removed");
            //display new queue
            Display(queue);
        }

        //**********************METHOD REMOVE BOTTOM ITEM FROM STACK*********************

        private void RemoveBottomItemFromStack(Stack<int> stack)
        {
            //may use additional queue or collection
            int[] array = stack.ToArray();
            stack.Clear();

            for (int i = array.Length - 2; i >= 0 ; i--)
            {
                stack.Push(array[i]);
            }

            MessageBox.Show($"Bottom item {array[array.Length - 1]} was removed.");
        }

        private void Display(Stack<int> stack)
        {
            richTextBox1.AppendText("Stack: ");
            foreach (int x in stack)
                richTextBox1.AppendText(x + " ");
        }

        private void BtnRemoveBottomFromStack_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Stack<int> stack = new Stack<int>(20);
            Random rand = new Random();
            //populate stack
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next(100);
                stack.Push(x);
            }
            //display original stack
            Display(stack);
            //remove bottom item
            RemoveBottomItemFromStack(stack);
            //display new stack
            Display(stack);
        }

        //**********************METHOD TAKES QUEUE AND RETURN STACK**********************

        private Stack<int> ConvertQueueToStack(Queue<int> queue)
        {
            //Element at the top of the stack should be the first element in the queue
            Stack<int> stack = new Stack<int>(queue.Count*2);
            int[] array = queue.ToArray();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                stack.Push(array[i]);
            }
            return stack;
        }

        private void BtnConvertQueueToStack_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Queue<int> queue = new Queue<int>(20);
            Random rand = new Random();
            //populate queue
            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next(100);
                queue.Enqueue(x);
            }

            Stack<int> stack = ConvertQueueToStack(queue);
            //display queue and stack to compare
            Display(queue);
            richTextBox1.AppendText("\n");
            Display(stack);
        }

        //**********************METHOD COPY DICTIONARY TO OTHER DICTIONARY***************

        private Dictionary<string, Student> CopyDictionary(Dictionary<string, Student> thisDictionary)
        {
            //could have used kvp, but wanted to try KeyCollection 
            Dictionary<string, Student> otherDictionary = new Dictionary<string, Student>();
            Dictionary<string, Student>.KeyCollection keyColl = thisDictionary.Keys;
            Student s;

            foreach (string id in keyColl)
            {
                if (thisDictionary.TryGetValue(id, out s))
                {
                    otherDictionary.Add(id, s);
                }
            }

            return otherDictionary;
        }

        private void BtnCopyDicToOtherDic_Click(object sender, EventArgs e)
        {
            Dictionary<string, Student> newDic = CopyDictionary(studentDictionary);
            Form2 f2 = new Form2();
            f2.DisplayForm2(newDic);
            f2.ShowDialog();
        }

        //**********************METHOD COPY DICTIONARY TO QUEUE**************************

        private Queue<Student> CopyToQueue(Dictionary<string, Student> studentDictionary)
        {
            //Remove students from dictionary and add to queue
            Queue<Student> queue = new Queue<Student>(studentDictionary.Count*2);
            Dictionary<string, Student>.KeyCollection keyColl = studentDictionary.Keys;
            Student s;

            foreach (string id in keyColl)
            {
                if (studentDictionary.TryGetValue(id, out s))
                {
                    queue.Enqueue(s);
                }
            }

            return queue;
        }

        private void BtnCopyDicToQueue_Click(object sender, EventArgs e)
        {
            Queue<Student> queue = CopyToQueue(studentDictionary);
            Form2 f2 = new Form2();
            f2.DisplayForm2(queue);
            f2.ShowDialog();
        }

        //*******************BUTTON EVENT - COPY DICTIONARY TO QUEUE*********************

        private void BtnCopyDictionaryToQueue_Click(object sender, EventArgs e)
        {
            //call CopyDictionary
            Dictionary<string, Student> newDict = CopyDictionary(studentDictionary);
            //call CopyToQueue
            Queue<Student> queue = CopyToQueue(newDict);
            //display returned queue
            Form2 f2 = new Form2();
            f2.DisplayForm2(queue);
            f2.ShowDialog();
        }
    }
}
