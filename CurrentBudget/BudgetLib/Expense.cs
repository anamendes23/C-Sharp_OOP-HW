using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLib
{
    public class Expense : IExpense
    {
        //fields
        private decimal _amount;
        private DateTime _dateExpenseMade;
        private string _description;
        //constructor
        public Expense(decimal amount, DateTime dateExpenseMade, string description)
        {
            _amount = amount;
            _dateExpenseMade = dateExpenseMade;
            _description = description;
        }
        //properties
        public decimal Amount { get => _amount; }
        public DateTime DateExpenseMade { get => _dateExpenseMade; }
        public string Description { get => _description; }
        //methods
        public override string ToString()
        {
            return $"Amount: {_amount:c} Date: {_dateExpenseMade} Description: {_description}";
        }

    }
}
