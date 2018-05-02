using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLib
{
    public abstract class Budget
    {
        //fields
        private decimal _balance;
        private string _budgetCode;
        private DateTime _dateItExpires;
        private List<IExpense> _expenses = new List<IExpense>();
        //constructor
        public Budget(decimal balance, string budgetCode, DateTime dateItExpires)
        {
            _balance = balance;
            _budgetCode = budgetCode;
            _dateItExpires = dateItExpires;
        }
        //properties
        public virtual decimal Balance { get => _balance; }
        public virtual string BudgetCode { get => _budgetCode; }
        public virtual DateTime DateItExpires { get => _dateItExpires; }
        public virtual IExpense[] Expenses => _expenses.ToArray();
        //methods
        public virtual void AddExpense(decimal amount)
        {
            if(amount < _balance)
            {
                _balance -= amount;
                string description = "Transaction approved!";
                Expense ex = new Expense(amount, DateTime.Now, description);
                _expenses.Add(ex);
            }
            else
            {
                string description = "Low balance, transaction not approved.";
                Expense ex = new Expense(amount, DateTime.Now, description);
                _expenses.Add(ex);
            }
        }
        public abstract string GetBudgetData();
    }
}
