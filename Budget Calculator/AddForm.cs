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
        private Form parent;
        public decimal Amount { get { return numericUpDownAmount.Value; } set { numericUpDownAmount.Value = value; } }
        public bool Repeated { get { return radioButtonRepeated.Checked; } set { radioButtonRepeated.Checked = value; } }
        public DateTime Date { get { return dateTimePickerDate.Value; } set { dateTimePickerDate.Value = value; } }
        public Button ConfirmButton { get { return ButtonAdd; } }
        public Button BackButton { get { return ButtonBack; } }

        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(Form parent, String type)
        {
            InitializeComponent();

            this.parent = parent;
            this.type = type;
            ButtonAdd.Text = $"Добави {type}";
            ButtonAdd.Click += ButtonAdd_Click;
            ButtonBack.Click += ButtonBack_Click;
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
