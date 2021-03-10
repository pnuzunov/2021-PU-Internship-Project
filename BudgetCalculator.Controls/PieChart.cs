using BudgetCalculator.BackEnd;
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

namespace BudgetCalculator.Controls
{
    public partial class PieChart : UserControl
    {
        private Color[] availableColors;
        List<FundsAlteration> rawData;
        List<FundsAlteration> data;

        private float incomes;
        private float expenses;

        private float angleIncomes;
        private float angleExpenses;

        private Point piePoint;
        private Size pieSize;
        private Rectangle pieRect;

        private Brush incomesBrush;
        private Brush expensesBrush;

        private Size textSize;
        private Point text1Point;
        private Point text2Point;
        private Rectangle text1Rect;
        private Rectangle text2Rect;

        private Font font;
        private Color fontColor;
        private Brush textBrush;

        private Pen pen;

        private Size colorRectSize;
        private Rectangle incomesColorRect;
        private Rectangle expensesColorRect;

        public PieChart()
        {
            InitializeComponent();

            availableColors = new Color[]
            {
                Color.FromArgb(113, 169, 238),
                Color.FromArgb(231, 210, 114),
                Color.Yellow,
                Color.Green,
                Color.Magenta,
                Color.Cyan
            };

            pieSize = new Size(this.Width / 3, this.Height);
            piePoint = new Point(this.Width - this.Width / 4, 0);
            //pieRect = new Rectangle(piePoint, pieSize);
            pieRect = new Rectangle(chartPanel.Location, chartPanel.Size);

            incomesBrush = new SolidBrush(availableColors[0]);
            expensesBrush = new SolidBrush(availableColors[1]);

            colorRectSize = new Size(20, 20);
            //incomesColorRect = new Rectangle(new Point(5, 5), colorRectSize);
            //expensesColorRect = new Rectangle(new Point(5, this.Height / 2), colorRectSize);
            incomesColorRect = new Rectangle(incomesColorPanel.Location, incomesColorPanel.Size);
            expensesColorRect = new Rectangle(expensesColorPanel.Location, expensesColorPanel.Size);

            text1Point = new Point(5 + incomesColorRect.Right, incomesColorRect.Top);
            text2Point = new Point(5 + expensesColorRect.Right, expensesColorRect.Top);
            textSize = new Size(this.Width, this.Height / 2);
            //text1Rect = new Rectangle(text1Point, textSize);
            //text2Rect = new Rectangle(text2Point, textSize);

            text1Rect = new Rectangle(incomesPanel.Location, incomesPanel.Size);
            text2Rect = new Rectangle(expensesPanel.Location, expensesPanel.Size);

            font = new Font("Century Gothic", 10.0f);
            fontColor = Color.FromArgb(78, 184, 206);

            pen = new Pen(Color.Black, 3);

            textBrush = new SolidBrush(fontColor);
        }

        public void DrawFromData(List<FundsAlteration> data)
        {
            this.data = data;
            this.rawData = data.ToList();
            this.Redraw();
        }

        private void Redraw()
        {
            incomes = data.Where(x => x.Type == FundsAlterationTypes.INCOME).Count();
            expenses = data.Where(x => x.Type == FundsAlterationTypes.EXPENSE).Count();
            float total = data.Count;

            angleIncomes = (incomes / total) * 360;
            angleExpenses = (expenses / total) * 360;

            this.Update();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawPie(pen, pieRect, 0, angleIncomes);
            e.Graphics.FillPie(incomesBrush, pieRect, 0, angleIncomes);
            e.Graphics.DrawPie(pen, pieRect, angleIncomes, angleExpenses);
            e.Graphics.FillPie(expensesBrush, pieRect, angleIncomes, angleExpenses);

            e.Graphics.DrawRectangle(pen, incomesColorRect);
            e.Graphics.FillRectangle(incomesBrush, incomesColorRect);
            e.Graphics.DrawRectangle(pen, expensesColorRect);
            e.Graphics.FillRectangle(expensesBrush, expensesColorRect);

            e.Graphics.DrawString("Приходи за избрания период: " + incomes, font, textBrush, text1Rect);
            e.Graphics.DrawString("Разходи за избрания период: " + expenses, font, textBrush, text2Rect);
        }

        private void buttonThisMonth_Click(object sender, EventArgs e)
        {
            this.data = rawData.Where(x => x.Date.Value.Month == DateTime.Now.Month).ToList();
            this.Redraw();
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            this.data = this.rawData.ToList();
            this.Redraw();
        }
    }
}



