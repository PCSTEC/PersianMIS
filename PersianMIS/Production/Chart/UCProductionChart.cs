using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersianMIS.Production.Chart
{
    public partial class UCProductionChart : UserControl
    {
        public UCProductionChart()
        {
            InitializeComponent();
        }

        private void MainChart_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new Frm_SelectChartOptions();
            frm.ShowDialog();
           


        }

        private void MainChart_Click(object sender, EventArgs e)
        {

        }
    }
}
