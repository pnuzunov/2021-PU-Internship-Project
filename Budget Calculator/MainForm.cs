using BudgetCalculator.BackEnd;
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
            //numericUpDownSum.Controls[0].Visible = false;
            numericUpDownSum.Controls.RemoveAt(0);
            ConnectionManager connectionManager = new ConnectionManager();
            numericUpDownSum.Text = connectionManager.CalcBalance().ToString();
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
            //AddIncomeForm addIncomeForm = new AddIncomeForm(FundsAlterationTypes.INCOME);
            //this.Hide();
            //addIncomeForm.Show();

            AddForm form = new AddForm(FundsAlterationTypes.INCOME);
            this.Hide();
            form.Show();

        }

        private void ButtonAddCostForm_Click(object sender, EventArgs e)
        {
            //AddCostForm addCostForm = new AddCostForm(FundsAlterationTypes.EXPENSE);
            //this.Hide();
            //addCostForm.Show();

            AddForm form = new AddForm(FundsAlterationTypes.EXPENSE);
            this.Hide();
            form.Show();
        }

        private void ButtonEditForm_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            this.Hide();
            editForm.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

      
    }
}
