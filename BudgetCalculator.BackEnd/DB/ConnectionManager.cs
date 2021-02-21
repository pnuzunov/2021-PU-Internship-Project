using BudgetCalculator.BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.BackEnd.DB
{
    public class ConnectionManager
    {

        public ConnectionManager()
        {
            
        }

        public List<FundsAlteration> GetAlterations()
        {
            using (var context = new SystemDbContext())
            {
                var fundsAlterations = context.Set<FundsAlteration>();
                return fundsAlterations.ToList();
            }
        }

        public String AddAlteration(double amount, String type, bool isPeriodic, DateTime? dateTime, String comment = null)
        {

            using(var context = new SystemDbContext())
            {
                if(amount <= 0 ||
                   (!type.Equals(FundsAlterationTypes.INCOME) && !type.Equals(FundsAlterationTypes.EXPENSE)))
                {
                    return "Грешка! Невалидни данни.";
                }

                if(isPeriodic)
                {
                    return "Грешка!"; //to be implemented
                }

                if(type.Equals(FundsAlterationTypes.EXPENSE)) {
                    double balance = this.CalcBalance();
                    if(amount > balance)
                    {
                        return "Недостатъчни средства!";
                    }
                }

                var fundsAlterations = context.Set<FundsAlteration>();
                DateTime? dt = (dateTime != null ? dateTime : DateTime.Now);
                fundsAlterations.Add(new FundsAlteration(amount, type, dt, isPeriodic));
                
                context.SaveChanges();
                return "Успешно добавен запис.";
            }

        }

        public void DeleteAlteration(int id)
        {
            using (var context = new SystemDbContext())
            {
                var fundsAlterations = context.Set<FundsAlteration>();
                FundsAlteration fundsAlteration = fundsAlterations
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
                if(fundsAlteration != null)
                    fundsAlterations.Remove(fundsAlteration);
            }
        }

        public double CalcBalance()
        {
            double balance = 0;

            using (var context = new SystemDbContext())
            {
                var fundsAlterations = context.Set<FundsAlteration>();
                List<Double> income = fundsAlterations
                    .Where(x => x.Type == FundsAlterationTypes.INCOME)
                    .Select(x => x.Amount)
                    .ToList();

                List<Double> expense = fundsAlterations
                    .Where(x => x.Type == FundsAlterationTypes.EXPENSE)
                    .Select(x => x.Amount)
                    .ToList();

                foreach (var item in income)
                {
                    balance += item;
                }

                foreach (var item in expense)
                {
                    balance -= item;
                }

                return balance;
            }
        }
    }
}
