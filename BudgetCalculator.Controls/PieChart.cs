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

        private Rectangle pieRect;

        private Brush incomesBrush;
        private Brush expensesBrush;

        private Rectangle text1Rect;
        private Rectangle text2Rect;

        private Font font;
        private Color fontColor;
        private Brush textBrush;

        private Pen pen;

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

            pieRect = new Rectangle(chartPanel.Location, chartPanel.Size);

            incomesBrush = new SolidBrush(availableColors[0]);
            expensesBrush = new SolidBrush(availableColors[1]);

            incomesColorRect = new Rectangle(incomesColorPanel.Location, incomesColorPanel.Size);
            expensesColorRect = new Rectangle(expensesColorPanel.Location, expensesColorPanel.Size);

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
    }
}



