using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator.BackEnd.Models
{
    public class PeriodicCheck
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }

        public PeriodicCheck()
        {

        }

        public PeriodicCheck(DateTime? date)
        {
            this.Date = date;
        }

    }
}
