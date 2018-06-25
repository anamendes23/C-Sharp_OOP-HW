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

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        /* What is a recursive method?
         * A recursive function (DEF) is a function which either calls itself or is in a potential cycle of function calls.
         * As the definition specifies, there are two types of recursive functions.
         * Consider a function which calls itself: we call this type of recursion immediate recursion.
         * The second part of the defintion refers to a cycle (or potential cycle if we use conditional statements)
         *      which involves other functions.
         *      
         * What are the two things you have to have to create a recursive method?
         * //base condition to end recursive calls
           //exit this method---> stop recursive calls

           //make a recursive call making sure that you are
           //converging towards the base condition
         * */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test
            int[] array = {0, 1, 2, 3, 4};
            richTextBox1.Text = "array = {0, 1, 2, 3, 4}\n";
            double average = AverageArray(array);
            richTextBox1.AppendText("Average loop: " + average + "\n");

            int index = array.Length;
            richTextBox1.AppendText("Average recursive: " + RecursiveAverage(array, index) + "\n");
            richTextBox1.AppendText("Max value: " + MaxValue(array, index) + "\n");
            richTextBox1.AppendText("No of elements: " + NumberOfElements(array, 2, index, 0) + "\n");
        }
        //calculates the average using loops
        private double AverageArray(int[] array)
        {
            int sum = 0;
            int length = array.Length;
            foreach (int item in array)
            {
                sum += item;
            }
            double average = sum / length;
            return average;
        }
        //calculates the average using recursion
        private double RecursiveAverage(int[] array, int index)
        {
            if (index == 1)
                return array[index - 1];
            else
                return ((RecursiveAverage(array, index - 1) * (index - 1) + array[index - 1]) / index);
        }
        //returns maximum in array
        private int MaxValue(int[] array, int index)
        {
            if (index == 1)
                return array[index - 1];

            return Math.Max(array[index - 1], MaxValue(array, index - 1));
        }
        //find n elements for sorted array[index] <= value
        private int NumberOfElements(int[] array, int value, int length, int index)
        {
            Array.Sort(array);
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= value)
                    counter = i + 1;
            }

            return counter;

            //RECURSION ATTEMPT
            //Array.Sort(array);
            //if(array[index] >= value || index == length)
            //{
            //    return index;
            //}

            //if (array[index] < value)
            //{
            //    if (index - 1 == length)
            //        return index + 1;
            //    return NumberOfElements(array, value, length, index + 1);
            //}

            //return 0;
        }
        //method to compare 2 arrays and display a third one
        private void GoodQuestion(int[] arr1, int[] arr2)
        {
            richTextBox1.Clear();
            
            richTextBox1.Text = "Output: ";

            int number;
            foreach (int item in arr1)
            {
                number = NumberOfElements(arr2, item, arr2.Length, 0);
                richTextBox1.AppendText(number + " ");
            }
        }

        private void BtnGoodQuestion_Click(object sender, EventArgs e)
        {
            int[] arr1 = { 1, 2, 3, 4, 7, 9 };
            int[] arr2 = { 0, 1, 2, 1, 1, 4 };
            GoodQuestion(arr1, arr2);
        }

        private void SortEvenArray(int[] array)
        {
            //variables to hold elements
            int odd;
            int even;
            //check if length even
            if(array.Length % 2 == 0)
            {
                //check if odd > even
                for (int i = 0; i < array.Length; i+=2)
                {
                    if(array[i] > array[i+1])
                    {
                        even = array[i];
                        odd = array[i + 1];
                        array[i] = odd;
                        array[i + 1] = even;
                    }
                }
            }
        }

        private void BtnSortEvenArray_Click(object sender, EventArgs e)
        {
            int[] array = { 6, 5, 11, 4, 2, 3, 7, 12 };
            richTextBox1.Text = "Original array: { 6, 5, 11, 4, 2, 3, 7, 12 } \n";
            SortEvenArray(array);
            richTextBox1.AppendText("Sorted array: ");
            foreach (int item in array)
            {
                richTextBox1.AppendText(item + " ");
            }
        }

        /* Binary search:
         * array {5, 9, 15, 23, 29, 35, 38, 45, 49, 51}
         * Loops to find 49: 9
         * Loops to find 9: 2 
         * */
    }
}
