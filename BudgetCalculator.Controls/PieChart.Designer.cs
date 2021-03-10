
namespace BudgetCalculator.Controls
{
    partial class PieChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartPanel = new System.Windows.Forms.Panel();
            this.incomesPanel = new System.Windows.Forms.Panel();
            this.expensesPanel = new System.Windows.Forms.Panel();
            this.buttonThisMonth = new System.Windows.Forms.Button();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.incomesColorPanel = new System.Windows.Forms.Panel();
            this.expensesColorPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // chartPanel
            // 
            this.chartPanel.Location = new System.Drawing.Point(592, 3);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(193, 144);
            this.chartPanel.TabIndex = 0;
            // 
            // incomesPanel
            // 
            this.incomesPanel.Location = new System.Drawing.Point(29, 3);
            this.incomesPanel.Name = "incomesPanel";
            this.incomesPanel.Size = new System.Drawing.Size(337, 35);
            this.incomesPanel.TabIndex = 1;
            // 
            // expensesPanel
            // 
            this.expensesPanel.Location = new System.Drawing.Point(29, 42);
            this.expensesPanel.Name = "expensesPanel";
            this.expensesPanel.Size = new System.Drawing.Size(337, 35);
            this.expensesPanel.TabIndex = 2;
            // 
            // buttonThisMonth
            // 
            this.buttonThisMonth.BackColor = System.Drawing.Color.Transparent;
            this.buttonThisMonth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThisMonth.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonThisMonth.Location = new System.Drawing.Point(3, 83);
            this.buttonThisMonth.Name = "buttonThisMonth";
            this.buttonThisMonth.Size = new System.Drawing.Size(140, 32);
            this.buttonThisMonth.TabIndex = 3;
            this.buttonThisMonth.Text = "този месец";
            this.buttonThisMonth.UseVisualStyleBackColor = false;
            this.buttonThisMonth.Click += new System.EventHandler(this.buttonThisMonth_Click);
            // 
            // buttonTotal
            // 
            this.buttonTotal.BackColor = System.Drawing.Color.Transparent;
            this.buttonTotal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTotal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonTotal.Location = new System.Drawing.Point(149, 83);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(140, 32);
            this.buttonTotal.TabIndex = 4;
            this.buttonTotal.Text = "общо";
            this.buttonTotal.UseVisualStyleBackColor = false;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // incomesColorPanel
            // 
            this.incomesColorPanel.Location = new System.Drawing.Point(3, 3);
            this.incomesColorPanel.Name = "incomesColorPanel";
            this.incomesColorPanel.Size = new System.Drawing.Size(20, 20);
            this.incomesColorPanel.TabIndex = 5;
            // 
            // expensesColorPanel
            // 
            this.expensesColorPanel.Location = new System.Drawing.Point(3, 42);
            this.expensesColorPanel.Name = "expensesColorPanel";
            this.expensesColorPanel.Size = new System.Drawing.Size(20, 20);
            this.expensesColorPanel.TabIndex = 6;
            // 
            // PieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expensesColorPanel);
            this.Controls.Add(this.incomesColorPanel);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.buttonThisMonth);
            this.Controls.Add(this.expensesPanel);
            this.Controls.Add(this.incomesPanel);
            this.Controls.Add(this.chartPanel);
            this.Name = "PieChart";
            this.Size = new System.Drawing.Size(788, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Panel incomesPanel;
        private System.Windows.Forms.Panel expensesPanel;
        private System.Windows.Forms.Button buttonThisMonth;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Panel incomesColorPanel;
        private System.Windows.Forms.Panel expensesColorPanel;
    }
}
