using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.Charting;
using Telerik.WinControls;
using System.Windows.Forms.DataVisualization.Charting;
using DevExpress.XtraCharts;

namespace PersianMIS.CurrentState
{
    public partial class UCShowCurrentStateWithChart : UserControl
    {
        ChartControl char2t;

        BLL.Cls_Station BllStation = new BLL.Cls_Station();

        public UCShowCurrentStateWithChart()
        {

            InitializeComponent();



            BLL.Cls_PublicOperations.Dt = BllStation.GetAllStationData("2017/07/19", "2017/07/26", "1");

            //  chart.Series[0].DataSource = BLL.Cls_PublicOperations.Dt;
            //chart.Series[0].ArgumentDataMember = "ProductLineDesc";
            //chart.Series[0].ValueDataMembers[0] = "MiladiStartDateTime";
            chart.DataSource = BLL.Cls_PublicOperations.Dt;

            int x;

            chart.SeriesDataMember = "ProductLineDesc";
            chart.SeriesTemplate.ArgumentDataMember = "MiladiStartDateTime";
            chart.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Duration" });

            chart.SeriesTemplate.ArgumentScaleType = ScaleType.DateTime;
            chart.SeriesTemplate.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
            chart.Diagram.Clone();
            XYDiagram diagram = (XYDiagram)chart.Diagram;
            diagram.AxisX.DateTimeMeasureUnit = DateTimeMeasurementUnit.Minute;
            diagram.AxisX.DateTimeGridAlignment = DateTimeMeasurementUnit.Hour;
            diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.ShortDate;

            diagram.AxisX.Label.Staggered = true;
            diagram.AxisX.GridLines.Visible = true;
            diagram.AxisX.Range.SideMarginsEnabled = true;
            diagram.AxisX.Interlaced = true;

            diagram.AxisX.DateTimeOptions.Format = DateTimeFormat.Custom;  //ADDED LINE
            diagram.AxisX.DateTimeOptions.FormatString = "MMMM/dd hh:mm:ss";                   //ADDED LINE
            diagram.AxisY.Title.Text = "US Dollars";
            diagram.AxisY.Title.Visible = true;
            diagram.AxisY.Range.Auto = false;


        }

    }

}
 
