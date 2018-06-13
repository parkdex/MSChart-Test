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
    public partial class SubForm_SeriesCount : Form
    {
        public Action<int> SettingSeries;

        public SubForm_SeriesCount()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //예외처리 즐~
            int seriesCount = int.Parse(txtBox_SeriesCount.Text);

            SettingSeries(seriesCount);
            this.Close();
        }
    }
}
