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
    public partial class EditingForm : Form
    {
        private FundsAlteration fundsAlteration;
        public EditingForm(string objectref)
        {
            InitializeComponent();
            //numericUpDownEdit.Value = objectref.Value...
            //dateTimePickerEdit.Value = objectref.Date...
            //if (objectref.Type == Normal) radioButton.Normal.Checked...
        }

        public EditingForm(FundsAlteration fundsAlteration)
        {
            InitializeComponent();
            this.fundsAlteration = fundsAlteration;
            this.numericUpDownEdit.Value = (decimal) fundsAlteration.Amount;
            this.radioButtonRepeated.Checked = fundsAlteration.Periodic;
            this.dateTimePickerEdit.Value = (DateTime) fundsAlteration.Date;
        }

        private void ButtonEditConfirm_Click(object sender, EventArgs e)
        {
            fundsAlteration.Amount = (double) this.numericUpDownEdit.Value;
            fundsAlteration.Periodic = this.radioButtonRepeated.Checked;
            fundsAlteration.Date = fundsAlteration.Date;

            ConnectionManager connectionManager = new ConnectionManager();
            String result = connectionManager.UpdateAlteration(fundsAlteration.Id, fundsAlteration);
            MessageBox.Show(result);
            if(result.Equals(ConnectionManager.ROW_UPDATED_SUCCESSFULLY))
            {
                this.ButtonBack.PerformClick();
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
