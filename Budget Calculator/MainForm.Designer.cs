
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonAddCostForm = new System.Windows.Forms.Button();
            this.ButtonAddIncomeForm = new System.Windows.Forms.Button();
            this.ButtonEditForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBot = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericUpDownSum = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pieChart = new BudgetCalculator.Controls.PieChart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonExit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ButtonAddCostForm);
            this.panel1.Controls.Add(this.ButtonAddIncomeForm);
            this.panel1.Controls.Add(this.ButtonEditForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 523);
            this.panel1.TabIndex = 3;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Image = global::Budget_Calculator.Properties.Resources.exit;
            this.ButtonExit.Location = new System.Drawing.Point(0, 420);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(173, 100);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Изход";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 93);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Budget_Calculator.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonAddCostForm
            // 
            this.ButtonAddCostForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ButtonAddCostForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonAddCostForm.FlatAppearance.BorderSize = 0;
            this.ButtonAddCostForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCostForm.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddCostForm.ForeColor = System.Drawing.Color.White;
            this.ButtonAddCostForm.Image = global::Budget_Calculator.Properties.Resources.addCost;
            this.ButtonAddCostForm.Location = new System.Drawing.Point(0, 207);
            this.ButtonAddCostForm.Name = "ButtonAddCostForm";
            this.ButtonAddCostForm.Size = new System.Drawing.Size(173, 100);
            this.ButtonAddCostForm.TabIndex = 2;
            this.ButtonAddCostForm.Text = "Добави Разход";
            this.ButtonAddCostForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonAddCostForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonAddCostForm.UseVisualStyleBackColor = true;
            this.ButtonAddCostForm.Click += new System.EventHandler(this.ButtonAddCostForm_Click);
            // 
            // ButtonAddIncomeForm
            // 
            this.ButtonAddIncomeForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ButtonAddIncomeForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonAddIncomeForm.FlatAppearance.BorderSize = 0;
            this.ButtonAddIncomeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddIncomeForm.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddIncomeForm.ForeColor = System.Drawing.Color.White;
            this.ButtonAddIncomeForm.Image = global::Budget_Calculator.Properties.Resources.addIncome;
            this.ButtonAddIncomeForm.Location = new System.Drawing.Point(0, 100);
            this.ButtonAddIncomeForm.Name = "ButtonAddIncomeForm";
            this.ButtonAddIncomeForm.Size = new System.Drawing.Size(173, 100);
            this.ButtonAddIncomeForm.TabIndex = 1;
            this.ButtonAddIncomeForm.Text = "Добави Приход";
            this.ButtonAddIncomeForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonAddIncomeForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonAddIncomeForm.UseVisualStyleBackColor = true;
            this.ButtonAddIncomeForm.Click += new System.EventHandler(this.ButtonAddIncomeForm_Click);
            // 
            // ButtonEditForm
            // 
            this.ButtonEditForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ButtonEditForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonEditForm.FlatAppearance.BorderSize = 0;
            this.ButtonEditForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditForm.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditForm.ForeColor = System.Drawing.Color.White;
            this.ButtonEditForm.Image = global::Budget_Calculator.Properties.Resources.edit;
            this.ButtonEditForm.Location = new System.Drawing.Point(0, 314);
            this.ButtonEditForm.Name = "ButtonEditForm";
            this.ButtonEditForm.Size = new System.Drawing.Size(173, 100);
            this.ButtonEditForm.TabIndex = 3;
            this.ButtonEditForm.Text = "Редактиране";
            this.ButtonEditForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonEditForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonEditForm.UseVisualStyleBackColor = true;
            this.ButtonEditForm.Click += new System.EventHandler(this.ButtonEditForm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pieChart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(173, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 191);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(193, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вие разполагате с:";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panelLeft.Location = new System.Drawing.Point(176, 100);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(5, 425);
            this.panelLeft.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(189, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = "Бюджетен калкулатор";
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.White;
            this.panelBot.Location = new System.Drawing.Point(199, 126);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(500, 1);
            this.panelBot.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(717, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 137);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.numericUpDownSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownSum.DecimalPlaces = 2;
            this.numericUpDownSum.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSum.ForeColor = System.Drawing.Color.White;
            this.numericUpDownSum.InterceptArrowKeys = false;
            this.numericUpDownSum.Location = new System.Drawing.Point(434, 87);
            this.numericUpDownSum.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownSum.Name = "numericUpDownSum";
            this.numericUpDownSum.ReadOnly = true;
            this.numericUpDownSum.Size = new System.Drawing.Size(277, 40);
            this.numericUpDownSum.TabIndex = 10;
            this.numericUpDownSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSum.ThousandsSeparator = true;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(690, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 40);
            this.panel4.TabIndex = 11;
            // 
            // pieChart
            // 
            this.pieChart.BackColor = System.Drawing.Color.Transparent;
            this.pieChart.Location = new System.Drawing.Point(26, 28);
            this.pieChart.Margin = new System.Windows.Forms.Padding(4);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(632, 150);
            this.pieChart.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(844, 523);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.numericUpDownSum);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бюджетен Калкулатор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddCostForm;
        private System.Windows.Forms.Button ButtonAddIncomeForm;
        private System.Windows.Forms.Button ButtonEditForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownSum;
        private System.Windows.Forms.Panel panel4;
        private BudgetCalculator.Controls.PieChart pieChart;
    }
}

