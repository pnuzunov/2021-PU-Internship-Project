using BudgetCalculator.BackEnd;
using BudgetCalculator.BackEnd.DB;
using BudgetCalculator.BackEnd.Models;
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
        private DateChecker dateChecker;
        public MainForm(DateChecker dateChecker)
        {
            InitializeComponent();
            //numericUpDownSum.Controls[0].Visible = false;
            numericUpDownSum.Controls.RemoveAt(0);

            this.dateChecker = dateChecker;
            ConnectionManager connectionManager = new ConnectionManager();
            
            this.Load += MainForm_CalcBalance;
            this.VisibleChanged += MainForm_CalcBalance;

            budgetPieChart.BringToFront();
            budgetPieChart.AddData(
                connectionManager.GetAlterations(),
                x => x.Type,
                new[] { FundsAlterationTypes.INCOME, FundsAlterationTypes.EXPENSE }
                );
            this.Invalidate();
        }

        public MainForm(String type)
        {
            InitializeComponent();
            //numericUpDownSum.Controls[0].Visible = false;
            numericUpDownSum.Controls.RemoveAt(0);
            ConnectionManager connectionManager = new ConnectionManager();
            numericUpDownSum.Text = connectionManager.CalcBalance().ToString();
        }

        private void ButtonAddIncomeForm_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(this, FundsAlterationTypes.INCOME);
            this.Hide();
            form.Show();

        }

        private void ButtonAddCostForm_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(this, FundsAlterationTypes.EXPENSE);
            this.Hide();
            form.Show();
        }

        private void ButtonEditForm_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            dateChecker.Stop();
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_CalcBalance(object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();
            numericUpDownSum.Text = connectionManager.CalcBalance().ToString();
        }
      
    }
}
