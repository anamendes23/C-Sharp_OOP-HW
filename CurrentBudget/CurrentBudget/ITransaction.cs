using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentBudget
{
    public interface ITransaction
    {
        string ShowTransaction();
        decimal UpdateAmount(decimal newAmount);
    }
}
