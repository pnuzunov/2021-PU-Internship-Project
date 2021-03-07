
namespace Budget_Calculator
{
    partial class AddIncomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncomeForm));
            this.ButtonAddIncome = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.radioButtonRepeated = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dateTimePickerIncome = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownIncome = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncome)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAddIncome
            // 
            this.ButtonAddIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ButtonAddIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ButtonAddIncome.Location = new System.Drawing.Point(12, 238);
            this.ButtonAddIncome.Name = "ButtonAddIncome";
            this.ButtonAddIncome.Size = new System.Drawing.Size(180, 50);
            this.ButtonAddIncome.TabIndex = 5;
            this.ButtonAddIncome.Text = "Добави приход";
            this.ButtonAddIncome.UseVisualStyleBackColor = false;
            this.ButtonAddIncome.Click += new System.EventHandler(this.ButtonAddIncome_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.Color.White;
            this.ButtonBack.Location = new System.Drawing.Point(308, 238);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(180, 50);
            this.ButtonBack.TabIndex = 6;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // radioButtonRepeated
            // 
            this.radioButtonRepeated.AutoSize = true;
            this.radioButtonRepeated.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRepeated.ForeColor = System.Drawing.Color.White;
            this.radioButtonRepeated.Location = new System.Drawing.Point(269, 21);
            this.radioButtonRepeated.Name = "radioButtonRepeated";
            this.radioButtonRepeated.Size = new System.Drawing.Size(219, 38);
            this.radioButtonRepeated.TabIndex = 4;
            this.radioButtonRepeated.TabStop = true;
            this.radioButtonRepeated.Text = "Повтарящ се";
            this.radioButtonRepeated.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNormal.ForeColor = System.Drawing.Color.White;
            this.radioButtonNormal.Location = new System.Drawing.Point(72, 21);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(167, 38);
            this.radioButtonNormal.TabIndex = 3;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Единичен";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.labelInfo.Location = new System.Drawing.Point(50, 36);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(287, 30);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Въведете сума и дата:";
            // 
            // dateTimePickerIncome
            // 
            this.dateTimePickerIncome.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerIncome.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerIncome.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePickerIncome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerIncome.Location = new System.Drawing.Point(138, 29);
            this.dateTimePickerIncome.Name = "dateTimePickerIncome";
            this.dateTimePickerIncome.Size = new System.Drawing.Size(234, 32);
            this.dateTimePickerIncome.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(55, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 17;
            // 
            // numericUpDownIncome
            // 
            this.numericUpDownIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.numericUpDownIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownIncome.DecimalPlaces = 2;
            this.numericUpDownIncome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIncome.ForeColor = System.Drawing.Color.White;
            this.numericUpDownIncome.Location = new System.Drawing.Point(279, 33);
            this.numericUpDownIncome.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownIncome.Name = "numericUpDownIncome";
            this.numericUpDownIncome.Size = new System.Drawing.Size(170, 37);
            this.numericUpDownIncome.TabIndex = 1;
            this.numericUpDownIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIncome.ThousandsSeparator = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.numericUpDownIncome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 79);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePickerIncome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 67);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButtonNormal);
            this.panel4.Controls.Add(this.radioButtonRepeated);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 86);
            this.panel4.TabIndex = 22;
            // 
            // AddIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonAddIncome);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddIncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на приход";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddIncomeForm_FormClosing);
            this.Load += new System.EventHandler(this.AddIncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddIncome;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.RadioButton radioButtonRepeated;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownIncome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}