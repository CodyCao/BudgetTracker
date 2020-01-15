using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    class BudgetApp
    {
        Dictionary<DateTime, PayStub> PayStubs; // Key is pay date
        Decimal Total_Balance;

        public BudgetApp()
        {
            // Empty Contructor
        }
        public BudgetApp(Decimal init_Balance)
        {
            Total_Balance = init_Balance;
        }
    }
}
