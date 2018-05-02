using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLib
{
    public enum Category { Food, Clothing, Cleaning, Entertainment};
    public class HomeBudget : Budget
    {
        //fields
        private Category _category;
        //constructor
        public HomeBudget(decimal balance, string budgetCode, DateTime dateItExpires, Category category) : base(balance, budgetCode, dateItExpires)
        {
            _category = category;
        }
        //properties
        public Category Category { get => _category; }
        //methods
        public override string GetBudgetData()
        {
            return $"Balance: {Balance:c} BudgetCode: {BudgetCode} Expiration Date: {DateItExpires} Category: {Category}";
        }
    }
}
