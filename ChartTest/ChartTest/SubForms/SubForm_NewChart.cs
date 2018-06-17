using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartTest.SubForms
{
    public partial class SubForm_NewChart : Form
    {
        private MemoryStream stream;

        public SubForm_NewChart(MemoryStream _stream)
        {
            stream = _stream;

            InitializeComponent();
        }

        private void SubForm_NewChart_Load(object sender, EventArgs e)
        {
            //chart1.Series.Clear();

            chart1.Serializer.Load(stream);
        }
    }
}
