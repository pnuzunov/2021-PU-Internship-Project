
namespace Budget_Calculator
{
    partial class MainForm
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
            this.ButtonAddCostForm = new System.Windows.Forms.Button();
            this.ButtonAddIncomeForm = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAddCostForm
            // 
            this.ButtonAddCostForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonAddCostForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddCostForm.Location = new System.Drawing.Point(12, 151);
            this.ButtonAddCostForm.Name = "ButtonAddCostForm";
            this.ButtonAddCostForm.Size = new System.Drawing.Size(150, 40);
            this.ButtonAddCostForm.TabIndex = 0;
            this.ButtonAddCostForm.Text = "Добави разход";
            this.ButtonAddCostForm.UseVisualStyleBackColor = false;
            this.ButtonAddCostForm.Click += new System.EventHandler(this.ButtonAddCostForm_Click);
            // 
            // ButtonAddIncomeForm
            // 
            this.ButtonAddIncomeForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonAddIncomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddIncomeForm.Location = new System.Drawing.Point(270, 151);
            this.ButtonAddIncomeForm.Name = "ButtonAddIncomeForm";
            this.ButtonAddIncomeForm.Size = new System.Drawing.Size(150, 40);
            this.ButtonAddIncomeForm.TabIndex = 1;
            this.ButtonAddIncomeForm.Text = "Добави приход";
            this.ButtonAddIncomeForm.UseVisualStyleBackColor = false;
            this.ButtonAddIncomeForm.Click += new System.EventHandler(this.ButtonAddIncomeForm_Click);
            // 
            // textBoxSum
            // 
            this.textBoxSum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSum.Enabled = false;
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSum.Location = new System.Drawing.Point(12, 69);
            this.textBoxSum.MaxLength = 10;
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(408, 30);
            this.textBoxSum.TabIndex = 2;
            this.textBoxSum.Text = "0";
            this.textBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(123, 24);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(172, 20);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Вие разполагате с:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 203);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.ButtonAddIncomeForm);
            this.Controls.Add(this.ButtonAddCostForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бюджетен калкулатор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddCostForm;
        private System.Windows.Forms.Button ButtonAddIncomeForm;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label labelInfo;
    }
}

