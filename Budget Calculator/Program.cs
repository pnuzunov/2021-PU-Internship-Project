﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BudgetCalculator.BackEnd.DB.DateChecker dateChecker = new BudgetCalculator.BackEnd.DB.DateChecker();
            dateChecker.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(dateChecker));
        }
    }
}
