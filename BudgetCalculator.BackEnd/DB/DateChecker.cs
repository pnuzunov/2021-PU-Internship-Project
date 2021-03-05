using BudgetCalculator.BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetCalculator.BackEnd.DB
{
    public class DateChecker
    {
        public DateChecker()
        {

            Thread newThread = new Thread(() =>
            {
                ConnectionManager connectionManager = new ConnectionManager();
                for (; ; )
                {
                    var periodicAlterations = connectionManager.GetAlterations().Where(x => x.Periodic).ToList();
                    foreach (var item in periodicAlterations)
                    {
                        if (item.Date.Value.Day == DateTime.Now.Day)
                        {
                            connectionManager.AddAlteration(item.Amount, item.Type, false, DateTime.Now);
                        }
                    }
                    Thread.Sleep(1000 * 60 * 60 * 24);
                }
            });

            newThread.Start();
        }
    }
}
