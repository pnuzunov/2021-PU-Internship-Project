using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.BackEnd.Models
{
    public class PeriodicFundsAlteration : FundsAlteration
    {
        public PeriodicFundsAlteration()
        {

        }

        public PeriodicFundsAlteration(double amount, String type, DateTime date): base(amount, type, date)
        {

        }
    }
}
