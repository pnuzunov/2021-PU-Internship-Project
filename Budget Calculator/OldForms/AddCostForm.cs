﻿using BudgetCalculator.BackEnd;
using BudgetCalculator.BackEnd.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Calculator
{
    public partial class AddCostForm : Form
    {
        public AddCostForm(string type)
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(FundsAlterationTypes.EXPENSE);
            this.Hide();
            mainForm.Show();
        }

        private void AddCostForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAddCost_Click(object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();
            double amount = (double) numericUpDownCost.Value;
            connectionManager.AddAlteration(
                amount,
                FundsAlterationTypes.EXPENSE,
                radioButtonRepeated.Checked,
                dateTimePickerCost.Value
                );
            ButtonBack.PerformClick();
        }

        private void AddCostForm_Load(object sender, EventArgs e)
        {

        }
    }
}
