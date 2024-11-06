using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomGraphControl_Assignment2
{
    public  class PieChartControl : Control
    {
        public List<float> Data { get; set; } = new List<float>();

        private List<Color> sliceColors = new List<Color>
        {
            Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Purple
        };

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Data == null || Data.Count == 0)
                return;

            float total = Data.Sum();
            float startAngle = 0;

            for (int i = 0; i < Data.Count; i++)
            {
                // Calculate the sweep angle for the current slice
                float sweepAngle = (Data[i] / total) * 360;

                //Draw the slice 
                e.Graphics.FillPie(
                    new SolidBrush(sliceColors[i % sliceColors.Count]),
                    new Rectangle(10, 10, Width - 20, Height - 20),
                    startAngle,
                    sweepAngle);

                // calculate the position for the slice label
                float midAngle = startAngle + sweepAngle / 2;
                float labelX = Width / 2 + (Width / 4) * (float)Math.Cos(midAngle * Math.PI / 180);
                float labelY = Height / 2 + (Height / 4) * (float)Math.Sin(midAngle * Math.PI / 180);

                // Draw the slice label
                e.Graphics.DrawString($"{Data[i]}", Font, Brushes.Black, labelX, labelY);

                startAngle += sweepAngle;
            }
        }
    }
}
