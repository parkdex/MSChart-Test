using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChartTest.SubForms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace ChartTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chart_main.Series.Clear();
        }

        private void btn_SeriesCount_Click(object sender, EventArgs e)
        {
            SubForm_SeriesCount seriesCountForm = new SubForm_SeriesCount();
            seriesCountForm.SettingSeries += new Action<int>(SeriesCountSetting);
            seriesCountForm.ShowDialog();
        }
        
        private void SeriesCountSetting(int _seriesCount)
        {
            chart_main.Series.Clear();
            for (int i = 0; i < _seriesCount; i++)
            {
                chart_main.Series.Add(i.ToString());
            }
        }

        private void btn_ShowLegend_Click(object sender, EventArgs e)
        {
            bool nowState = chart_main.Series[0].IsVisibleInLegend;
            for (int i = 0; i < chart_main.Series.Count; i++)
            {
                chart_main.Series[i].IsVisibleInLegend = !nowState;
            }
        }

        bool timerIsStop = true;
        private void btn_DrawChart_Click(object sender, EventArgs e)
        {
            if (timerIsStop)
            {
                timer_main.Start();
                timerIsStop = false;
            }
            else
            {
                timer_main.Stop();
                timerIsStop = true;
            }            
        }

        private void timer_main_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < chart_main.Series.Count; i++)
            {
                chart_main.Series[i].Points.AddXY(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                                                  r.Next(0, 100));
            }
        }

        private void btn_SeriesType_Click(object sender, EventArgs e)
        {
            SubForm_SeriesType seriesTypeForm = new SubForm_SeriesType();
            seriesTypeForm.SettingSeriesType += new Action<SeriesChartType>(SeriesTypeSetting);
            seriesTypeForm.ShowDialog();
        }

        private void SeriesTypeSetting(SeriesChartType _seriesType)
        {
            for (int i = 0; i < chart_main.Series.Count; i++)
            {
                chart_main.Series[i].ChartType = _seriesType;
            }
        }

        private void btn_SeriesBold_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < chart_main.Series.Count; i++)
            {
                if (i % 2 == 1)
                {
                    chart_main.Series[i].BorderWidth = r.Next(1, 10);
                }
            }
        }

        private void btn_SeriesColor_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < chart_main.Series.Count; i++)
            {
                if (i % 2 == 0)
                {
                    chart_main.Series[i].Color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
                }
            }
        }

        private void btn_AxisX_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            chart_main.ChartAreas[0].AxisX.Interval = r.Next(1, 5);            
        }


        private void btn_MinMax_Click(object sender, EventArgs e)
        {
            SubForm_MinMax minMaxForm = new SubForm_MinMax();
            minMaxForm.SettingMinMax += new Action<int, int>(MinMaxSetting);
            minMaxForm.ShowDialog();
        }

        private void MinMaxSetting(int _min, int _max)
        {
            chart_main.ChartAreas[0].AxisY.Minimum = _min;
            chart_main.ChartAreas[0].AxisY.Maximum = _max;
        }

        private void btn_NewChart_Click(object sender, EventArgs e)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                chart_main.Serializer.Save(stream);
                //stream.Seek(0, SeekOrigin.Begin);

                SubForm_NewChart newChartForm = new SubForm_NewChart(stream);
                newChartForm.ShowDialog();
            }            
        }

        private void btn_NewChartDynamic_Click(object sender, EventArgs e)
        {
            // 이건 내일하자 
            SubForm_NewChartDynamic dynamicChartForm = new SubForm_NewChartDynamic();
            dynamicChartForm.ShowDialog();
        }
    }
}
