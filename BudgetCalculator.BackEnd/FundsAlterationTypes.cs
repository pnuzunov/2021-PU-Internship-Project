using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.BackEnd
{
    public class FundsAlterationTypes
    {
        public static String INCOME
        {
            get
            {
                return "приход";
            }

            private set { }
        }
        public static String EXPENSE
        {
            get
            {
                return "разход";
            }

            private set { }
        }
    }
}

