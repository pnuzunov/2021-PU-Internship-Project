using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.BackEnd.Models
{
    public class FundsAlteration
    {
        [Key]
        public int Id { get; private set; }
        public double Amount { get; private set; }
        public String Type { get; private set; }
        public DateTime? Date { get; private set; }
        public bool Periodic { get; private set; }
        public String Comment { get; private set; }

        public FundsAlteration(double amount, String type, DateTime? date, bool periodic = false, String comment = null)
        {
            this.Amount = amount;
            this.Type = type;
            this.Date = date;
            this.Periodic = periodic;
            this.Comment = comment;
        }
    }
}
