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
        public int Id { get; set; }
        public double Amount { get; set; }
        public String Type { get; set; }
        public DateTime? Date { get; set; }
        public bool Periodic { get; set; }
        public String Comment { get; set; }

        public FundsAlteration()
        {

        }
        public FundsAlteration(double amount, String type, DateTime? date, bool periodic = false, String comment = null)
        {
            this.Amount = amount;
            this.Type = type;
            this.Date = date;
            this.Periodic = periodic;
            this.Comment = comment;
        }

        public override string ToString()
        {
            String periodic = "";
            if (this.Periodic) periodic = "(повтарящ се)";
            return $"{periodic}{this.Type}: {this.Amount}лв, {this.Date}";
        }
    }
}
