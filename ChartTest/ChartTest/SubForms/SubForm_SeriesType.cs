using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartTest.SubForms
{
    public partial class SubForm_SeriesType : Form
    {
        public Action<SeriesChartType> SettingSeriesType;

        public SubForm_SeriesType()
        {
            InitializeComponent();
        }

        private void SubForm_SeriesType_Load(object sender, EventArgs e)
        {
            cbx_SeriesType.Items.Add(SeriesChartType.Area);
            cbx_SeriesType.Items.Add(SeriesChartType.Bar);
            cbx_SeriesType.Items.Add(SeriesChartType.BoxPlot);
            cbx_SeriesType.Items.Add(SeriesChartType.Bubble);
            cbx_SeriesType.Items.Add(SeriesChartType.Candlestick);
            cbx_SeriesType.Items.Add(SeriesChartType.Column);
            cbx_SeriesType.Items.Add(SeriesChartType.Doughnut);
            cbx_SeriesType.Items.Add(SeriesChartType.ErrorBar);
            cbx_SeriesType.Items.Add(SeriesChartType.FastLine);
            cbx_SeriesType.Items.Add(SeriesChartType.FastPoint);
            cbx_SeriesType.Items.Add(SeriesChartType.Funnel);
            cbx_SeriesType.Items.Add(SeriesChartType.Kagi);
            cbx_SeriesType.Items.Add(SeriesChartType.Line);
            cbx_SeriesType.Items.Add(SeriesChartType.Pie);
            cbx_SeriesType.Items.Add(SeriesChartType.Point);
            cbx_SeriesType.Items.Add(SeriesChartType.PointAndFigure);
            cbx_SeriesType.Items.Add(SeriesChartType.Polar);
            cbx_SeriesType.Items.Add(SeriesChartType.Pyramid);
            cbx_SeriesType.Items.Add(SeriesChartType.Radar);
            cbx_SeriesType.Items.Add(SeriesChartType.Range);
            cbx_SeriesType.Items.Add(SeriesChartType.RangeBar);
            cbx_SeriesType.Items.Add(SeriesChartType.RangeColumn);
            cbx_SeriesType.Items.Add(SeriesChartType.Renko);
            cbx_SeriesType.Items.Add(SeriesChartType.Spline);
            cbx_SeriesType.Items.Add(SeriesChartType.SplineArea);
            cbx_SeriesType.Items.Add(SeriesChartType.SplineRange);
            cbx_SeriesType.Items.Add(SeriesChartType.StackedArea);
            cbx_SeriesType.Items.Add(SeriesChartType.StackedArea100);
            cbx_SeriesType.Items.Add(SeriesChartType.StackedBar);
            cbx_SeriesType.Items.Add(SeriesChartType.StackedBar100);
            cbx_SeriesType.Items.Add(SeriesChartType.StackedColumn);
            cbx_SeriesType.Items.Add(SeriesChartType.StackedColumn100);
            cbx_SeriesType.Items.Add(SeriesChartType.StepLine);
            cbx_SeriesType.Items.Add(SeriesChartType.Stock);
            cbx_SeriesType.Items.Add(SeriesChartType.ThreeLineBreak);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SeriesChartType chartType = (SeriesChartType)cbx_SeriesType.SelectedItem;

            SettingSeriesType(chartType);
            this.Close();
        }
    }
}
