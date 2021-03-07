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
    public partial class PieChart<T> : UserControl
    {
        private Color[] availableColors;

        public PieChart(ICollection<T> data, Func<T, object> whichGroup, object[] groups)
        {
            InitializeComponent();

            availableColors = new Color[]
            {
                Color.Red,
                Color.Blue,
                Color.Yellow,
                Color.Green,
                Color.Magenta,
                Color.Cyan
            };

            int total = data.Count;
            int[] dataGroups = new int[groups.Length];
            foreach (var item in data)
            {
                for (int i = 0; i < groups.Length; i++)
                {
                    if (whichGroup(item) == groups[i])
                    {
                        dataGroups[i] += 1;
                    }
                }
            }

            Graphics g = this.CreateGraphics();
            float[] angles = new float[groups.Length];
            for (int i = 0; i < dataGroups.Length; i++)
            {
                angles[i] = (dataGroups[i] / (float)total) * 360;
            }

            Pen p = new Pen(Color.Black, 2);
            Rectangle rect = this.DisplayRectangle;

            Brush[] brushes = new Brush[groups.Length];
            for (int i = 0; i < brushes.Length; i++)
            {
                brushes[i] = new SolidBrush(availableColors[i]);
                g.DrawPie(p, rect, (i == 0 ? i : angles[i - 1]), angles[i]);
                g.FillPie(brushes[i], rect, (i == 0 ? i : angles[i - 1]), angles[i]);
            }
        }
    }
}
