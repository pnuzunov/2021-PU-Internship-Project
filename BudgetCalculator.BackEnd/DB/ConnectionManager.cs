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
        #region CRUD strings
        private static String CREATE = "create";
        private static String READ = "read";
        private static String UPDATE = "update";
        private static String DELETE = "delete";
        #endregion

        #region return strings
        public static String ROW_ADDED_SUCCESSFULLY
        {
            get { return "Успешно добавен запис."; }
            private set { }
        }

        public static String ROW_UPDATED_SUCCESSFULLY
        {
            get { return "Успешно редактиран запис."; }
            private set { }
        }

        public static String ROW_DELETED_SUCCESSFULLY
        {
            get { return "Успешно изтрит запис."; }
            private set { }
        }

        public static String INSUFFICIENT_FUNDS
        {
            get { return "Недостатъчни средства!"; }
            private set { }
        }

        public static String INVALID_DATA
        {
            get { return "Грешка! Невалидни данни."; }
            private set { }
        }

        public static String GENERIC_ERROR
        {
            get { return "Грешка!"; }
            private set { }
        }

        #endregion return strings

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

                var fundsAlterations = context.Set<FundsAlteration>();
                DateTime? dt = (dateTime != null ? dateTime : DateTime.Now);

                String msg = "";
                FundsAlteration fa = new FundsAlteration(amount, type, dt, isPeriodic);
                if (IsValid(fa, CREATE, out msg))
                {
                    fundsAlterations.Add(fa);
                    context.SaveChanges();
                }
                return msg;
            }

        }

        public String UpdateAlteration(int id, FundsAlteration newAlteration)
        {
            using (var context = new SystemDbContext())
            {
                String msg = "";
                if (!IsValid(newAlteration, UPDATE, out msg))
                    return msg;

                var fundsAlterations = context.Set<FundsAlteration>();
                var fundsAlteration = fundsAlterations.Where(x => x.Id == id).FirstOrDefault();
                fundsAlteration.Amount = newAlteration.Amount;
                fundsAlteration.Comment = newAlteration.Comment;
                fundsAlteration.Date = newAlteration.Date;
                fundsAlteration.Type = newAlteration.Type;
                fundsAlteration.Periodic = newAlteration.Periodic;

                if (!IsValid(fundsAlteration, UPDATE, out msg))
                    return msg;

                context.SaveChanges();
                return msg;
            }
        }

        public String DeleteAlteration(int id)
        {
            using (var context = new SystemDbContext())
            {
                String msg = "";
                var fundsAlterations = context.Set<FundsAlteration>();
                FundsAlteration fundsAlteration = fundsAlterations
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
                if (fundsAlteration != null && IsValid(fundsAlteration, DELETE, out msg))
                {
                    fundsAlterations.Remove(fundsAlteration);
                }
                context.SaveChanges();
                return msg;
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

        private bool IsValid(FundsAlteration fundsAlteration, String type, out String msg)
        {
            if (fundsAlteration.Amount <= 0 ||
                   (!fundsAlteration.Type.Equals(FundsAlterationTypes.INCOME) && !fundsAlteration.Type.Equals(FundsAlterationTypes.EXPENSE)))
            {
                msg = INVALID_DATA;
                return false;
            }

            //if (fundsAlteration.Periodic)
            //{
            //    msg = GENERIC_ERROR; //to be implemented
            //    return false;
            //}

            if (fundsAlteration.Type.Equals(FundsAlterationTypes.EXPENSE))
            {
                double balance = this.CalcBalance();
                if (fundsAlteration.Amount > balance)
                {
                    msg = INSUFFICIENT_FUNDS;
                    return false;
                }
            }

            switch (type)
            {
                case "create": msg = ROW_ADDED_SUCCESSFULLY; return true;
                case "update": msg = ROW_UPDATED_SUCCESSFULLY; return true;
                case "delete": msg = ROW_DELETED_SUCCESSFULLY; return true;
                default: msg = "null";  return true;
            }

            // msg = ROW_ADDED_SUCCESSFULLY;
            // return true;
        }

        public bool IsChecked(DateTime? date)
        {
            using(var context = new SystemDbContext())
            {
                var checks = context.Set<PeriodicCheck>();
                var checkToday = checks
                    .Where(x => x.Date.Value.Year == date.Value.Year
                                && x.Date.Value.Month == date.Value.Month
                                && x.Date.Value.Day == date.Value.Day)
                    .FirstOrDefault();
                if (checkToday != null) return true;
                return false;
            }
        }

        public void MarkChecked(DateTime? date)
        {
            using (var context = new SystemDbContext())
            {
                var checks = context.Set<PeriodicCheck>();
                checks.Add(new PeriodicCheck(date));
                context.SaveChanges();
            }
        }
    }
}
