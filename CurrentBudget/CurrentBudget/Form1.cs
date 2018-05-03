using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetLib;

namespace CurrentBudget
{
    public partial class Form1 : Form
    {
        //**************************GLOBAL***********************************
        List<Budget> budgetList = new List<Budget>();
        //budget dictionary where the key is BudgetCode and the value is Balance
        Dictionary<string, decimal> budgetDictionary = new Dictionary<string, decimal>();
        //list of transactions
        List<ITransaction> transList = new List<ITransaction>();
        //**************************FORM***********************************
        public Form1()
        {
            InitializeComponent();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFormLoad();
            budgetList.Sort((x, y) => x.Balance.CompareTo(y.Balance));
            PopulateTransactions();
            PopulateCombobox();
        }
        //**************************METHODS***********************************
        private void PopulateFormLoad()
        {
            Random rand = new Random();
            //create 3 BusinessBudgets
            BusinessBudget bb1 = new BusinessBudget(rand.Next(1000, 10001), rand.Next(1000, 10000).ToString(), new DateTime(2019,08,27), "VFX");
            BusinessBudget bb2 = new BusinessBudget(rand.Next(1000, 10001), rand.Next(1000, 10000).ToString(), new DateTime(2020, 04, 10), "Art");
            BusinessBudget bb3 = new BusinessBudget(rand.Next(1000, 10001), rand.Next(1000, 10000).ToString(), new DateTime(2021, 05, 24), "Level Design");
            //add to list
            budgetList.Add(bb1);
            budgetList.Add(bb2);
            budgetList.Add(bb3);
            //add to dictionary
            budgetDictionary.Add(bb1.BudgetCode, bb1.Balance);
            budgetDictionary.Add(bb2.BudgetCode, bb2.Balance);
            budgetDictionary.Add(bb3.BudgetCode, bb3.Balance);
            //create 3 HomeBudgets
            HomeBudget hb1 = new HomeBudget(rand.Next(1000, 10001), rand.Next(1000, 10000).ToString(), new DateTime(2019, 08, 27), Category.Cleaning);
            HomeBudget hb2 = new HomeBudget(rand.Next(1000, 10001), rand.Next(1000, 10000).ToString(), new DateTime(2020, 04, 10), Category.Clothing);
            HomeBudget hb3 = new HomeBudget(rand.Next(1000, 10001), rand.Next(1000, 10000).ToString(), new DateTime(2021, 05, 24), Category.Food);
            //add to list
            budgetList.Add(hb1);
            budgetList.Add(hb2);
            budgetList.Add(hb3);
            //add to dictionary
            budgetDictionary.Add(hb1.BudgetCode, hb1.Balance);
            budgetDictionary.Add(hb2.BudgetCode, hb2.Balance);
            budgetDictionary.Add(hb3.BudgetCode, hb3.Balance);
        }
        private void DisplayBudgets()
        {
            richTextBox1.Clear();

            foreach (Budget obj in budgetList)
            {
                richTextBox1.AppendText(obj.GetBudgetData() + "\n");
            }
        }
        private void PopulateCombobox()
        {
            foreach (Budget obj in budgetList)
            {
                comboBox1.Items.Add(obj.BudgetCode);
            }

            foreach (Transaction obj in transList)
            {
                comboBox2.Items.Add(obj.TCode);
            }
        }

        private void PopulateTransactions()
        {
            Random rand = new Random();

            Transaction t1 = new Transaction(rand.Next(1000, 10000).ToString(), new DateTime(2018, 04, 30), rand.Next(100, 1000));
            Transaction t2 = new Transaction(rand.Next(1000, 10000).ToString(), new DateTime(2018, 04, 28), rand.Next(100, 1000));
            Transaction t3 = new Transaction(rand.Next(1000, 10000).ToString(), new DateTime(2018, 04, 17), rand.Next(100, 1000));
            Transaction t4 = new Transaction(rand.Next(1000, 10000).ToString(), new DateTime(2018, 04, 04), rand.Next(100, 1000));
            Transaction t5 = new Transaction(rand.Next(1000, 10000).ToString(), new DateTime(2018, 04, 01), rand.Next(100, 1000));
            transList.Add(t1);
            transList.Add(t2);
            transList.Add(t3);
            transList.Add(t4);
            transList.Add(t5);
        }
        //**************************EVENTS***********************************
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayBudgets();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //get index from combobox
            int index = comboBox1.SelectedIndex;
            //get Budget object from list
            Budget obj = budgetList[index];
            richTextBox1.AppendText($"BudgetCode: {obj.BudgetCode} Balance: {budgetDictionary[obj.BudgetCode]:c} \n");
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            byte n = 0;
            List<byte> bytes = new List<byte>();
            byte remainder;
            string binary = String.Empty;
            if (byte.TryParse(textBox1.Text, out n))
            {
                binary = $"The binary of {n} is ";

                do
                {
                    remainder = (byte)(n % 2);
                    bytes.Add(remainder);
                    n /= 2;
                }
                while (n != 0);

                if (bytes.Count < 4)
                {
                    for (int i = 0; i <= 4 - bytes.Count; i++)
                    {
                        bytes.Add(0);
                    }
                }

                for (int i = (bytes.Count - 1); i >= 0; i--)
                {
                    binary += $"{bytes[i]}";
                }

                MessageBox.Show(binary);

                if (bytes[4] == 1)
                    MessageBox.Show("bit4 is 1");
                else
                    MessageBox.Show("bit4 is 0");
            }
            else
                MessageBox.Show("Enter a number between 0 and 255");
        }

        private void btnGetBits_Click(object sender, EventArgs e)
        {
            byte[] bits = { 0, 0, 0, 0, 0, 0 };

            string message = "Original binary: ";

            foreach (byte b in bits)
            {
                message += b;
            }

            message += $"\nbit3 = 1: ";
            bits[bits.Length - 3] = 1;

            foreach (byte b in bits)
            {
                message += b;
            }

            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 1;
            }

            message += "\nOriginal binary: ";

            foreach (byte b in bits)
            {
                message += b;
            }

            message += $"\nbit5 = 0: ";
            bits[bits.Length - 5] = 0;

            foreach (byte b in bits)
            {
                message += b;
            }

            MessageBox.Show(message);
        }
        private void btnDisplayTrans_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            foreach (Transaction obj in transList)
            {
                richTextBox1.AppendText($"{obj.ShowTransaction()} \n");
            }
        }
        //btn to Update Transaction
        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;
            decimal newAmount = Convert.ToDecimal(textBox2.Text);

            transList[index].UpdateAmount(newAmount);

            btnDisplayTrans_Click(sender, e);
        }


    }
}
