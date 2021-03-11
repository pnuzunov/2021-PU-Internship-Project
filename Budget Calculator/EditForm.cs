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
    public partial class EditForm : Form
    {
        private Form parent;
        public EditForm(Form parent)
        {
            InitializeComponent();

            this.parent = parent;
            ConnectionManager connectionManager = new ConnectionManager();
            this.ListBoxEdit.Items.Clear();
            ListBoxEdit.DataSource = connectionManager.GetAlterations();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            UpdateForm form = new UpdateForm(this, (FundsAlteration)ListBoxEdit.SelectedItem);
            form.Show();
            this.Hide();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var alter = (FundsAlteration) ListBoxEdit.SelectedItem;
            var prompt = MessageBox.Show("Сигурни ли сте, че искате да изтриете избрания запис?", "Изтриване на запис", MessageBoxButtons.YesNo);
            if(prompt.Equals(DialogResult.Yes))
            {
                ConnectionManager connectionManager = new ConnectionManager();
                String result = connectionManager.DeleteAlteration(alter.Id);
                var box = MessageBox.Show(result);
                if(box.Equals(DialogResult.OK))
                    ListBoxEdit.DataSource = connectionManager.GetAlterations();
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            this.VisibleChanged += EditForm_ListBoxRefresh;
        }

        private void EditForm_ListBoxRefresh(Object sender, EventArgs e)
        {
            ConnectionManager connectionManager = new ConnectionManager();
            ListBoxEdit.DataSource = connectionManager.GetAlterations();
        }
    }
}
