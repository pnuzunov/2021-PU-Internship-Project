using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BudgetCalculator.BackEnd.Models;

namespace BudgetCalculator.BackEnd.DB
{
    class SystemDbContext : DbContext
    {

        public DbSet<FundsAlteration> FundsAlterations { get; set; }

        public SystemDbContext()
        {

        }

    }
}
