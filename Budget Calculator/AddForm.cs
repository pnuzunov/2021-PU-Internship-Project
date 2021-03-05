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
    public partial class AddForm : Form
    {
        private String type;
        private FundsAlteration fundsAlteration;

        public AddForm(string type)
        {
            InitializeComponent();
        }

        public AddForm(FundsAlteration fundsAlteration, String type)
        {
            InitializeComponent();
            if(fundsAlteration != null)
            {
                this.type = fundsAlteration.Type;
                this.fundsAlteration = fundsAlteration;
                numericUpDownAmount.Value = (decimal) fundsAlteration.Amount;
                dateTimePickerDate.Value = (DateTime) fundsAlteration.Date;
                radioButtonRepeated.Checked = fundsAlteration.Periodic;
                ButtonAddUpdate.Text = "Редактирай";
                ButtonAddUpdate.Click += ButtonUpdate_Click;
            }
            else
            {
                this.type = type;
                ButtonAddUpdate.Text = $"Добави {type}";
                ButtonAddUpdate.Click += ButtonAdd_Click;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();
            String result = connectionManager.AddAlteration(
                (double)numericUpDownAmount.Value,
                this.type,
                radioButtonRepeated.Checked,
                dateTimePickerDate.Value
                );
            MessageBox.Show(result);
            ButtonBack.PerformClick();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();

            String result = connectionManager.UpdateAlteration(this.fundsAlteration.Id, new FundsAlteration()
            {
                Amount = (double) numericUpDownAmount.Value,
                Type = type,
                Periodic = radioButtonRepeated.Checked,
                Date = dateTimePickerDate.Value
            });
            MessageBox.Show(result);
            if(result.Equals(ConnectionManager.ROW_UPDATED_SUCCESSFULLY))
            {
                ButtonBack.PerformClick();
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(FundsAlterationTypes.EXPENSE);
            this.Hide();
            mainForm.Show();
        }

        private void AddUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
