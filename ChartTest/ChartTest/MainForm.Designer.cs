namespace ChartTest
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_SeriesCount = new System.Windows.Forms.Button();
            this.btn_ShowLegend = new System.Windows.Forms.Button();
            this.btn_DrawChart = new System.Windows.Forms.Button();
            this.btn_SeriesType = new System.Windows.Forms.Button();
            this.btn_SeriesBold = new System.Windows.Forms.Button();
            this.btn_SeriesColor = new System.Windows.Forms.Button();
            this.btn_AxisX = new System.Windows.Forms.Button();
            this.btn_MinMax = new System.Windows.Forms.Button();
            this.btn_NewChart = new System.Windows.Forms.Button();
            this.btn_NewChartDynamic = new System.Windows.Forms.Button();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_main)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.chart_main, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 761);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chart_main
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_main.ChartAreas.Add(chartArea1);
            this.chart_main.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_main.Legends.Add(legend1);
            this.chart_main.Location = new System.Drawing.Point(3, 3);
            this.chart_main.Name = "chart_main";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_main.Series.Add(series1);
            this.chart_main.Size = new System.Drawing.Size(879, 755);
            this.chart_main.TabIndex = 0;
            this.chart_main.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_SeriesCount, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_ShowLegend, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_DrawChart, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_SeriesType, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_SeriesBold, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_SeriesColor, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btn_AxisX, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn_MinMax, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btn_NewChart, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btn_NewChartDynamic, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(888, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(93, 755);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_SeriesCount
            // 
            this.btn_SeriesCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SeriesCount.Location = new System.Drawing.Point(3, 3);
            this.btn_SeriesCount.Name = "btn_SeriesCount";
            this.btn_SeriesCount.Size = new System.Drawing.Size(87, 69);
            this.btn_SeriesCount.TabIndex = 0;
            this.btn_SeriesCount.Text = "Series 갯수 설정";
            this.btn_SeriesCount.UseVisualStyleBackColor = true;
            this.btn_SeriesCount.Click += new System.EventHandler(this.btn_SeriesCount_Click);
            // 
            // btn_ShowLegend
            // 
            this.btn_ShowLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ShowLegend.Location = new System.Drawing.Point(3, 78);
            this.btn_ShowLegend.Name = "btn_ShowLegend";
            this.btn_ShowLegend.Size = new System.Drawing.Size(87, 69);
            this.btn_ShowLegend.TabIndex = 1;
            this.btn_ShowLegend.Text = "LegendText 보기 안보기";
            this.btn_ShowLegend.UseVisualStyleBackColor = true;
            this.btn_ShowLegend.Click += new System.EventHandler(this.btn_ShowLegend_Click);
            // 
            // btn_DrawChart
            // 
            this.btn_DrawChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DrawChart.Location = new System.Drawing.Point(3, 153);
            this.btn_DrawChart.Name = "btn_DrawChart";
            this.btn_DrawChart.Size = new System.Drawing.Size(87, 69);
            this.btn_DrawChart.TabIndex = 2;
            this.btn_DrawChart.Text = "차트 그리기 멈추기 (series 갯수 만큼)";
            this.btn_DrawChart.UseVisualStyleBackColor = true;
            this.btn_DrawChart.Click += new System.EventHandler(this.btn_DrawChart_Click);
            // 
            // btn_SeriesType
            // 
            this.btn_SeriesType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SeriesType.Location = new System.Drawing.Point(3, 228);
            this.btn_SeriesType.Name = "btn_SeriesType";
            this.btn_SeriesType.Size = new System.Drawing.Size(87, 69);
            this.btn_SeriesType.TabIndex = 3;
            this.btn_SeriesType.Text = "차트 모양 바꾸기";
            this.btn_SeriesType.UseVisualStyleBackColor = true;
            this.btn_SeriesType.Click += new System.EventHandler(this.btn_SeriesType_Click);
            // 
            // btn_SeriesBold
            // 
            this.btn_SeriesBold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SeriesBold.Location = new System.Drawing.Point(3, 303);
            this.btn_SeriesBold.Name = "btn_SeriesBold";
            this.btn_SeriesBold.Size = new System.Drawing.Size(87, 69);
            this.btn_SeriesBold.TabIndex = 4;
            this.btn_SeriesBold.Text = "홀수번 Series 굵기 바꾸기";
            this.btn_SeriesBold.UseVisualStyleBackColor = true;
            this.btn_SeriesBold.Click += new System.EventHandler(this.btn_SeriesBold_Click);
            // 
            // btn_SeriesColor
            // 
            this.btn_SeriesColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SeriesColor.Location = new System.Drawing.Point(3, 378);
            this.btn_SeriesColor.Name = "btn_SeriesColor";
            this.btn_SeriesColor.Size = new System.Drawing.Size(87, 69);
            this.btn_SeriesColor.TabIndex = 5;
            this.btn_SeriesColor.Text = "짝수번 Series 색상 변경하기";
            this.btn_SeriesColor.UseVisualStyleBackColor = true;
            this.btn_SeriesColor.Click += new System.EventHandler(this.btn_SeriesColor_Click);
            // 
            // btn_AxisX
            // 
            this.btn_AxisX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AxisX.Location = new System.Drawing.Point(3, 453);
            this.btn_AxisX.Name = "btn_AxisX";
            this.btn_AxisX.Size = new System.Drawing.Size(87, 69);
            this.btn_AxisX.TabIndex = 6;
            this.btn_AxisX.Text = "X축 간격 설정하기";
            this.btn_AxisX.UseVisualStyleBackColor = true;
            this.btn_AxisX.Click += new System.EventHandler(this.btn_AxisX_Click);
            // 
            // btn_MinMax
            // 
            this.btn_MinMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_MinMax.Location = new System.Drawing.Point(3, 528);
            this.btn_MinMax.Name = "btn_MinMax";
            this.btn_MinMax.Size = new System.Drawing.Size(87, 69);
            this.btn_MinMax.TabIndex = 7;
            this.btn_MinMax.Text = "Y축 MIN MAX 설정하기";
            this.btn_MinMax.UseVisualStyleBackColor = true;
            this.btn_MinMax.Click += new System.EventHandler(this.btn_MinMax_Click);
            // 
            // btn_NewChart
            // 
            this.btn_NewChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NewChart.Location = new System.Drawing.Point(3, 603);
            this.btn_NewChart.Name = "btn_NewChart";
            this.btn_NewChart.Size = new System.Drawing.Size(87, 69);
            this.btn_NewChart.TabIndex = 8;
            this.btn_NewChart.Text = "현 차트 복사하기 (정적)";
            this.btn_NewChart.UseVisualStyleBackColor = true;
            this.btn_NewChart.Click += new System.EventHandler(this.btn_NewChart_Click);
            // 
            // btn_NewChartDynamic
            // 
            this.btn_NewChartDynamic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NewChartDynamic.Location = new System.Drawing.Point(3, 678);
            this.btn_NewChartDynamic.Name = "btn_NewChartDynamic";
            this.btn_NewChartDynamic.Size = new System.Drawing.Size(87, 74);
            this.btn_NewChartDynamic.TabIndex = 9;
            this.btn_NewChartDynamic.Text = "현 차트 복사하기 (다이나믹)";
            this.btn_NewChartDynamic.UseVisualStyleBackColor = true;
            this.btn_NewChartDynamic.Click += new System.EventHandler(this.btn_NewChartDynamic_Click);
            // 
            // timer_main
            // 
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "ChartTest";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_main)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_SeriesCount;
        private System.Windows.Forms.Button btn_ShowLegend;
        private System.Windows.Forms.Button btn_DrawChart;
        private System.Windows.Forms.Button btn_SeriesType;
        private System.Windows.Forms.Button btn_SeriesBold;
        private System.Windows.Forms.Button btn_SeriesColor;
        private System.Windows.Forms.Button btn_AxisX;
        private System.Windows.Forms.Button btn_MinMax;
        private System.Windows.Forms.Button btn_NewChart;
        private System.Windows.Forms.Button btn_NewChartDynamic;
        private System.Windows.Forms.Timer timer_main;
    }
}

