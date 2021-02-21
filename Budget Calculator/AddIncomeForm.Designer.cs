
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
            this.ButtonAddIncome = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.radioButtonRepeated = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.dateTimePickerIncome = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ButtonAddIncome
            // 
            this.ButtonAddIncome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonAddIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddIncome.Location = new System.Drawing.Point(12, 201);
            this.ButtonAddIncome.Name = "ButtonAddIncome";
            this.ButtonAddIncome.Size = new System.Drawing.Size(150, 40);
            this.ButtonAddIncome.TabIndex = 6;
            this.ButtonAddIncome.Text = "Добави приход";
            this.ButtonAddIncome.UseVisualStyleBackColor = false;
            this.ButtonAddIncome.Click += new System.EventHandler(this.ButtonAddIncome_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Location = new System.Drawing.Point(270, 201);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(150, 40);
            this.ButtonBack.TabIndex = 7;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // radioButtonRepeated
            // 
            this.radioButtonRepeated.AutoSize = true;
            this.radioButtonRepeated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRepeated.Location = new System.Drawing.Point(230, 150);
            this.radioButtonRepeated.Name = "radioButtonRepeated";
            this.radioButtonRepeated.Size = new System.Drawing.Size(119, 22);
            this.radioButtonRepeated.TabIndex = 5;
            this.radioButtonRepeated.TabStop = true;
            this.radioButtonRepeated.Text = "Повтарящ се";
            this.radioButtonRepeated.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNormal.Location = new System.Drawing.Point(100, 150);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(96, 22);
            this.radioButtonNormal.TabIndex = 4;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Единичен";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(110, 20);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(205, 20);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Въведете сума и дата:";
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIncome.Location = new System.Drawing.Point(170, 55);
            this.textBoxIncome.MaxLength = 5;
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(80, 28);
            this.textBoxIncome.TabIndex = 1;
            // 
            // dateTimePickerIncome
            // 
            this.dateTimePickerIncome.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerIncome.Location = new System.Drawing.Point(110, 100);
            this.dateTimePickerIncome.Name = "dateTimePickerIncome";
            this.dateTimePickerIncome.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerIncome.TabIndex = 3;
            // 
            // AddIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.dateTimePickerIncome);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.radioButtonRepeated);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonAddIncome);
            this.MaximizeBox = false;
            this.Name = "AddIncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на приход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddIncomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddIncome;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.RadioButton radioButtonRepeated;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncome;
    }
}