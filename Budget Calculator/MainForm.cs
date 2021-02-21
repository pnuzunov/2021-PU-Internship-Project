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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ConnectionManager connectionManager = new ConnectionManager();
            textBoxSum.Text = connectionManager.CalcBalance().ToString();
        }

        private void ButtonAddCostForm_Click(object sender, EventArgs e)
        {
            AddCostForm addCostForm = new AddCostForm();
            this.Hide();
            addCostForm.Show();
        }

        private void ButtonAddIncomeForm_Click(object sender, EventArgs e)
        {
            AddIncomeForm addIncomeForm = new AddIncomeForm();
            this.Hide();
            addIncomeForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
