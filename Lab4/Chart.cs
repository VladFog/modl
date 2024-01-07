using ScottPlot.Palettes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Chart : Form
    {
        double[] FValues;
        double[] PredictedValues;
        double[] XValues;
        public Chart(double[] FValues, double[] predictedValues)
        {
            InitializeComponent();
            this.FValues = FValues;
            this.PredictedValues = predictedValues;
            XValues = new double[FValues.Length];
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < FValues.Length; i++)
            {
                XValues[i] = i;
            }
            formsPlot1.Plot.AddScatter(XValues, FValues, Color.Purple, lineWidth: 3, markerSize: 5, label: "Введені дані");
            var predictScatter = formsPlot1.Plot.AddScatter(XValues, PredictedValues, Color.YellowGreen, lineWidth: 3, markerSize: 5, label: "Зпрогнозовані дані");
            predictScatter.OnNaN = ScottPlot.Plottable.ScatterPlot.NanBehavior.Ignore;
            formsPlot1.Plot.Legend();           
            formsPlot1.Refresh();
        }
    }
}
