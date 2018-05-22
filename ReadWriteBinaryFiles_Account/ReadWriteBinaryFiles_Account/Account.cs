using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteBinaryFiles_Account
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateCreated { get; set; }
        public string BankName { get; set; }
    }
}
