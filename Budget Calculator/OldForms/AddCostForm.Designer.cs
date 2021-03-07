
namespace Budget_Calculator
{
    partial class AddCostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCostForm));
            this.ButtonAddCost = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.dateTimePickerCost = new System.Windows.Forms.DateTimePicker();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonRepeated = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAddCost
            // 
            this.ButtonAddCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.ButtonAddCost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ButtonAddCost.Location = new System.Drawing.Point(12, 238);
            this.ButtonAddCost.Name = "ButtonAddCost";
            this.ButtonAddCost.Size = new System.Drawing.Size(180, 50);
            this.ButtonAddCost.TabIndex = 5;
            this.ButtonAddCost.Text = "Добави Разход";
            this.ButtonAddCost.UseVisualStyleBackColor = false;
            this.ButtonAddCost.Click += new System.EventHandler(this.ButtonAddCost_Click);
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
            // dateTimePickerCost
            // 
            this.dateTimePickerCost.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCost.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePickerCost.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePickerCost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCost.Location = new System.Drawing.Point(138, 29);
            this.dateTimePickerCost.Name = "dateTimePickerCost";
            this.dateTimePickerCost.Size = new System.Drawing.Size(234, 32);
            this.dateTimePickerCost.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.labelInfo.Location = new System.Drawing.Point(50, 36);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(287, 30);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Въведете сума и дата:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(55, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.numericUpDownCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownCost.DecimalPlaces = 2;
            this.numericUpDownCost.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCost.ForeColor = System.Drawing.Color.White;
            this.numericUpDownCost.Location = new System.Drawing.Point(279, 33);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(176, 37);
            this.numericUpDownCost.TabIndex = 1;
            this.numericUpDownCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCost.ThousandsSeparator = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelInfo);
            this.panel2.Controls.Add(this.numericUpDownCost);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 79);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePickerCost);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 67);
            this.panel3.TabIndex = 12;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButtonRepeated);
            this.panel4.Controls.Add(this.radioButtonNormal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 86);
            this.panel4.TabIndex = 13;
            // 
            // AddCostForm
            // 
            this.AcceptButton = this.ButtonAddCost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.CancelButton = this.ButtonBack;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonAddCost);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddCostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на разход";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCostForm_FormClosing);
            this.Load += new System.EventHandler(this.AddCostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonAddCost;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerCost;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonRepeated;
        private System.Windows.Forms.Panel panel4;
    }
}