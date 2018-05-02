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
        //**************************FORM***********************************
        public Form1()
        {
            InitializeComponent();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFormLoad();
            budgetList.Sort((x, y) => x.Balance.CompareTo(y.Balance));
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

        }
    }
}
