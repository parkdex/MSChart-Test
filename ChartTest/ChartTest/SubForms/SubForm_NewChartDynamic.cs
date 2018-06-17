<<<<<<< HEAD
﻿using System;
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
    public partial class SubForm_NewChartDynamic : Form
    {
        public SubForm_NewChartDynamic(Chart _chart)
        {
            InitializeComponent();

            chart1.Series.Clear();
            foreach (var series in _chart.Series)
            {
                chart1.Series.Add(series);
            }

        }

        private void SubForm_NewChartDynamic_Load(object sender, EventArgs e)
        {

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartTest.SubForms
{
    public partial class SubForm_NewChartDynamic : Form
    {
        public SubForm_NewChartDynamic()
        {
            InitializeComponent();
        }

        private void SubForm_NewChartDynamic_Load(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> b4366bc9fcd4cafd0d5e41194f973f903a7c8cfe
