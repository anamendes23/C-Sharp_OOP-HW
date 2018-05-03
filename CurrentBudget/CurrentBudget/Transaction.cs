using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentBudget
{
    public class Transaction : ITransaction
    {
        //fields
        private string _tCode;
        private DateTime _date;
        private decimal _amount;
        //constructor
        public Transaction(string tCode, DateTime date, decimal amount)
        {
            _tCode = tCode;
            _date = date;
            _amount = amount;
        }
        //properties
        public string TCode { get => _tCode; }
        public DateTime Date { get => _date; }
        public decimal Amount { get => _amount; }
        //methods
        public string ShowTransaction()
        {
            return $"Transaction Code: {_tCode}  Date: {_date} Amount: {_amount:c}";
        }
        public decimal UpdateAmount(decimal newAmount)
        {
            _amount = newAmount;
            return _amount;
        }
    }
}
