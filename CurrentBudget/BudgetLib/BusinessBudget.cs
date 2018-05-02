using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLib
{
    public class BusinessBudget : Budget
    {
        //fields
        private string _department;
        //constructor
        public BusinessBudget(decimal balance, string budgetCode, DateTime dateItExpires, string department) : base(balance, budgetCode, dateItExpires)
        {
            _department = department;
        }
        //property
        public string Department { get => _department; }
        //methods
        public override string GetBudgetData()
        {
            return $"Balance: {Balance:c} BudgetCode: {BudgetCode} Expiration Date: {DateItExpires} Department: {Department}";
        }
    }
}
