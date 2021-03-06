﻿using BudgetCalculator.BackEnd.DB;
using BudgetCalculator.BackEnd;
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
    public partial class AddIncomeForm : Form
    {
        public AddIncomeForm(String type)
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(FundsAlterationTypes.INCOME);
            this.Hide();
            mainForm.Show();
        }

        private void AddIncomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAddIncome_Click(object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();
            double amount = (double) numericUpDownIncome.Value;
            connectionManager.AddAlteration(
                amount,
                FundsAlterationTypes.INCOME,
                radioButtonRepeated.Checked,
                dateTimePickerIncome.Value
                );
            ButtonBack.PerformClick();
        }

        private void AddIncomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
