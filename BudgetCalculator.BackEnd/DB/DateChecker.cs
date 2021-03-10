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
        private Thread runningThread;
        private int period;

        public DateChecker()
        {
            period = 1000 * 60 * 60 * 24;
        }

        public void Start()
        {
            runningThread = new Thread(new ThreadStart(() => {

                ConnectionManager connectionManager = new ConnectionManager();

                while (connectionManager.IsChecked(DateTime.Now)) {
                    Thread.Sleep(period / 24);
                }

                var periodicAlterations = connectionManager.GetAlterations().Where(x => x.Periodic).ToList();
                foreach (var item in periodicAlterations)
                {
                    List<DateTime?> missedChecks = new List<DateTime?>();
                    if(DateTime.Now.Month > item.Date.Value.Month)
                    {
                        if (item.Date.Value.Day == DateTime.Now.Day)
                        {
                            connectionManager.AddAlteration(item.Amount, item.Type, false, DateTime.Now);
                        }
                        else if (item.Date.Value.Day < DateTime.Now.Day &&
                            !connectionManager.IsChecked(DateTime.Now.AddDays(item.Date.Value.Day - DateTime.Now.Day)))
                        {
                            DateTime? missedDate = DateTime.Now.AddDays(item.Date.Value.Day - DateTime.Now.Day);

                            connectionManager.AddAlteration(item.Amount, item.Type, false, DateTime.Now);
                            if(!missedChecks.Contains(missedDate)) missedChecks.Add(missedDate);
                        }
                    }
                    foreach(var date in missedChecks)
                    {
                        connectionManager.MarkChecked(date);
                    }
                }
                connectionManager.MarkChecked(DateTime.Now);
                Thread.Sleep(period);
            }));
            runningThread.Start();
        }

        public void Stop()
        {
            this.runningThread.Abort();
        }
    }
}
