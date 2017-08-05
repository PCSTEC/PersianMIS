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

namespace PersianMIS.CurrentState
{
    public partial class UCShowCurrentStateWithChart : UserControl
    {
        BLL.Cls_Station BllStation = new BLL.Cls_Station();

        public UCShowCurrentStateWithChart()
        {
            InitializeComponent();
            Theme theme = Theme.ReadCSSText(@"
                                            theme
                                            {
                                               name: ControlDefault;
                                               elementType: Telerik.WinControls.UI.RadChartElement; 
                                               controlType: Telerik.WinControls.UI.RadChartView; 
                                            }

                                            Bar
                                            {    
                                                HeightAspectRatio
                                                {
                                                    Value: 0.9;
                                                    EndValue: 1;
                                                    MaxValue: 1;
                                                    Frames: 30;
                                                    Interval: 20;
                                                    EasingType: InOutCubic;
                                                    RandomDelay: 200;
                                                    RemoveAfterApply: true; 
                                                }
                                            }
                                            ");

            ThemeRepository.Add(theme, false);
            FillChartData();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            BLL.Cls_PublicOperations.Dt = BllStation.GetAllStationData("2017/07/19", "2017/07/26", "1");

            CartesianArea area = this.MainChart.GetArea<CartesianArea>();
            area.ShowGrid = true;


            CartesianGrid grid = this.MainChart.GetArea<CartesianArea>().GetGrid<CartesianGrid>();
            this.MainChart.GetArea<CartesianArea>().Orientation = Orientation.Horizontal;
            grid.DrawVerticalStripes = true;
            grid.DrawHorizontalStripes = false;

            BarSeries bar = new BarSeries();

            bar.CategoryMember = "LineDesc";
            bar.ValueMember = "Duration";
            bar.DataSource = BLL.Cls_PublicOperations.Dt;
            this.MainChart.Series.Add(bar);

            //MyFormatProvider myFormatter = new MyFormatProvider();
            //myFormatter.Start = new DateTime(2013, 6, 5, 8, 0, 0);
            //bar.VerticalAxis.LabelFormatProvider = myFormatter;




        }
        private void FillChartData()
        {

        }


    }
}
