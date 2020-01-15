using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    class PayStub
    {
        DateTime _payDate;
        DateTime _startDate;
        DateTime _endDate;
        Decimal _balance;


        public PayStub()
        {

        }
        public PayStub(DateTime _payDate, DateTime _startDate, DateTime _endDate, Decimal _balance)
        {
            this._payDate = _payDate;
            this._startDate = _startDate;
            this._endDate = _endDate;
            this._balance = _balance;
        }



    }

}
