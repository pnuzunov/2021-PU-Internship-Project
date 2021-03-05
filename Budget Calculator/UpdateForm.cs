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
    public partial class UpdateForm : AddForm
    {
        private FundsAlteration fundsAlteration;
        public UpdateForm(FundsAlteration fundsAlteration)
        {
            InitializeComponent();

            this.fundsAlteration = fundsAlteration;
            this.Amount = (decimal) fundsAlteration.Amount;
            this.Repeated = fundsAlteration.Periodic;
            this.Date = fundsAlteration.Date.Value;
            this.ConfirmButton.Text = "Редактирай";

            this.ConfirmButton.Click += ButtonUpdate_Click;
            this.BackButton.Click += ButtonBack_Click;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();

            String result = connectionManager.UpdateAlteration(this.fundsAlteration.Id, new FundsAlteration()
            {
                Amount = (double)Amount,
                Type = fundsAlteration.Type,
                Periodic = Repeated,
                Date = Date
            });
            MessageBox.Show(result);
            if (result.Equals(ConnectionManager.ROW_UPDATED_SUCCESSFULLY))
            {
                BackButton.PerformClick();
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            this.Hide();
            editForm.Show();
        }
    }
}
