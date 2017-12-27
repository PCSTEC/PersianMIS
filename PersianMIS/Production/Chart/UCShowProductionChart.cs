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
    public partial class UCShowProductionChart : UserControl
    {
        public UCShowProductionChart()
        {
            InitializeComponent();
        }

        private void Btn_Week_Click(object sender, EventArgs e)
        {

            ChangeDatePeriod(-7);
        }



        private void ChangeDatePeriod(int Day)
        {
            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = (DateTime)MskStartDate.Value.Value.AddDays(Day);
            MskEndDate.Value = DateTime.Now;


            this.Cursor = Cursors.Default;
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            ChangeDatePeriod(-30);
        }

        private void Btn_Year_Click(object sender, EventArgs e)
        {
            ChangeDatePeriod(-365);
        }

        private void Mnu_AddChart_Click(object sender, EventArgs e)
        {
            UCProductionChart UcChart = new UCProductionChart();

            MainPnl.Controls.Add (UcChart);
        }
    }
}
