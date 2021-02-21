
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
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.ButtonAddCost = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.dateTimePickerCost = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonRepeated = new System.Windows.Forms.RadioButton();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCost
            // 
            this.textBoxCost.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.Location = new System.Drawing.Point(170, 55);
            this.textBoxCost.MaxLength = 5;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(80, 27);
            this.textBoxCost.TabIndex = 1;
            // 
            // ButtonAddCost
            // 
            this.ButtonAddCost.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonAddCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCost.Location = new System.Drawing.Point(12, 201);
            this.ButtonAddCost.Name = "ButtonAddCost";
            this.ButtonAddCost.Size = new System.Drawing.Size(150, 40);
            this.ButtonAddCost.TabIndex = 5;
            this.ButtonAddCost.Text = "Добави разход";
            this.ButtonAddCost.UseVisualStyleBackColor = false;
            this.ButtonAddCost.Click += new System.EventHandler(this.ButtonAddCost_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.Location = new System.Drawing.Point(270, 201);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(150, 40);
            this.ButtonBack.TabIndex = 6;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // dateTimePickerCost
            // 
            this.dateTimePickerCost.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCost.Location = new System.Drawing.Point(110, 100);
            this.dateTimePickerCost.Name = "dateTimePickerCost";
            this.dateTimePickerCost.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerCost.TabIndex = 2;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNormal.Location = new System.Drawing.Point(100, 150);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(96, 22);
            this.radioButtonNormal.TabIndex = 3;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Единичен";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonRepeated
            // 
            this.radioButtonRepeated.AutoSize = true;
            this.radioButtonRepeated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRepeated.Location = new System.Drawing.Point(230, 150);
            this.radioButtonRepeated.Name = "radioButtonRepeated";
            this.radioButtonRepeated.Size = new System.Drawing.Size(119, 22);
            this.radioButtonRepeated.TabIndex = 4;
            this.radioButtonRepeated.TabStop = true;
            this.radioButtonRepeated.Text = "Повтарящ се";
            this.radioButtonRepeated.UseVisualStyleBackColor = true;
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
            // AddCostForm
            // 
            this.AcceptButton = this.ButtonAddCost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonBack;
            this.ClientSize = new System.Drawing.Size(432, 253);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.radioButtonRepeated);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.dateTimePickerCost);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonAddCost);
            this.Controls.Add(this.textBoxCost);
            this.MaximizeBox = false;
            this.Name = "AddCostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на разход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCostForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Button ButtonAddCost;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.DateTimePicker dateTimePickerCost;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonRepeated;
        private System.Windows.Forms.Label labelInfo;
    }
}