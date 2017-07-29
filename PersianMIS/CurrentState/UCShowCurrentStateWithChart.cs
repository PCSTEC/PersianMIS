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
         
            //Theme theme = Theme.ReadCSSText(@"
            //                                theme
            //                                {
            //                                   name: ControlDefault;
            //                                   elementType: Telerik.WinControls.UI.RadChartElement; 
            //                                   controlType: Telerik.WinControls.UI.RadChartView; 
            //                                }

            //                                Bar
            //                                {    
            //                                    HeightAspectRatio
            //                                    {
            //                                        Value: 0.9;
            //                                        EndValue: 1;
            //                                        MaxValue: 1;
            //                                        Frames: 30;
            //                                        Interval: 20;
            //                                        EasingType: InOutCubic;
            //                                        RandomDelay: 200;
            //                                        RemoveAfterApply: true; 
            //                                    }
            //                                }
            //                                ");

            //ThemeRepository.Add(theme, false);
            FillChartData();

        }




        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           BLL.Cls_PublicOperations.Dt = BllStation.GetAllStationData("2017/07/19", "2017/07/19", "1");



            //CartesianArea area = this.MainChart.GetArea<CartesianArea>();
            //area.ShowGrid = true;


            //CartesianGrid grid = this.MainChart.GetArea<CartesianArea>().GetGrid<CartesianGrid>();
            //this.MainChart.GetArea<CartesianArea>().Orientation = Orientation.Horizontal;
            //grid.DrawVerticalStripes = true;
            //grid.DrawHorizontalStripes = false;

            //BarSeries bar = new BarSeries();

            //bar.CategoryMember = "LineDesc";
            //bar.ValueMember = "Duration";
            //bar.DataSource = BLL.Cls_PublicOperations.Dt;
            //this.MainChart.Series.Add(bar);

            //MyFormatProvider myFormatter = new MyFormatProvider();
            //myFormatter.Start = new DateTime(2013, 6, 5, 8, 0, 0);
            //bar.VerticalAxis.LabelFormatProvider = myFormatter;

            //   MainChart.DataSource = BLL.Cls_PublicOperations.Dt;

            chart1.DataSource = BLL.Cls_PublicOperations.Dt;
            chart1.DataBind();

            chart1.Series["Group"].XValueMember = "StationDesc";
            chart1.Series["Group"].YValueMembers = "MiladiStartDateTime";

            //chart1.Series["Group"].XValueMember = "MiladiStartDateTime";
            //chart1.Series["Group"].YValueMembers = "Duration";

            chart1.Titles(0).Text = Cmb_IndicatorList.Text

            chart1.Series(3).Points.Remove(chart1.Series(3).Points.FindByValue(0))
            chart1.Series(0).Points.Remove(chart1.Series(0).Points.FindByValue(0))

            chart1.Series(2).Points.Remove(chart1.Series(2).Points.FindByValue(0))


        }
        private void FillChartData()
        {
            //this.MainChart.Series.Clear(); 
            //this.MainChart.Series.Add(new   ChartSeries  { Type = BarSeries });
            //this.MainChart.Series.Add(new Telerik.Charting.ChartSeries() { Type = Telerik.Charting.ChartSeriesType.Spline });
            //this.MainChart.Series.Add(new Telerik.Charting.ChartSeries() { Type = Telerik.Charting.ChartSeriesType.Point });

            //this.MainChart.Series[0].DataXColumn = "ProductId";
            //this.MainChart.Series[1].DataXColumn = "ProductId";
            //this.MainChart.Series[2].DataXColumn = "ProductId";

            //this.MainChart.Series[0].DataYColumn = "Value1";
            //this.MainChart.Series[1].DataYColumn = "Value2";
            //this.MainChart.Series[2].DataYColumn = "Value3";

            //this.MainChart.PlotArea.XAxis.DataLabelsColumn = "Name";
            //this.MainChart.PlotArea.XAxis.Appearance.TextAppearance.TextProperties.Font = new System.Drawing.Font("Ariel", 8);

            //this.MainChart.DataSource = new List<Product>()
            //{
            //    new Product{ ProductId = 1, Name = "silverlight", Value1 = 1, Value2 = 6, Value3 = 11, },
            //    new Product{ ProductId = 2, Name = "wpf", Value1 = 2, Value2 = 8, Value3 = 15, },
            //    new Product{ ProductId = 3, Name = "mvc", Value1 = 3, Value2 = 10, Value3 = 14, },
            //    new Product{ ProductId = 4, Name = "asp", Value1 = 4, Value2 = 9, Value3 = 13, },
            //    new Product{ ProductId = 5, Name = "win forms", Value1 = 4, Value2 = 8, Value3 = 12, },
            //};
            //this.MainChart.DataBind();
        }
        public class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public double Value1 { get; set; }
            public double Value2 { get; set; }
            public double Value3 { get; set; }
        }
        private void radCheckBox1_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            
        }

        //private void FillChartData()
        //    {
        //        BLL.Cls_PublicOperations.Dt = BllStation.GetAllStationData("2017/07/19", "2017/07/26", "1");

        //        //WaterfallSeries series = new WaterfallSeries("Value", "Summary", "Total", "Category");
        //        //series.ShowLabels = true;
        //        //series.DataSource = BLL.Cls_PublicOperations.Dt;


        //        CartesianArea area = this.MainChart.GetArea();
        //        area.ShowGrid = true;
        //        LinearAxis verticalAxis = new LinearAxis();
        //        verticalAxis.LabelFormat = "{0}°C";
        //        verticalAxis.AxisType = AxisType.Second;
        //        DateTimeContinuousAxis horizontalAxis = new DateTimeContinuousAxis();
        //        horizontalAxis.LabelFormat = "{0:MMM}";
        //        WeatherModel model = new WeatherModel();
        //        RangeBarSeries barSeries = new RangeBarSeries("High", "Low", "Time");
        //        barSeries.Name = "Temperature";
        //        barSeries.HorizontalAxis = horizontalAxis; barSeries.VerticalAxis = verticalAxis;
        //        this.radChartView1.Series.Add(barSeries);
        //        this.radChartView1.DataSource = model.GetTemperatureData();
        //        CartesianGridLineAnnotation line2011 = new CartesianGridLineAnnotation(horizontalAxis, new DateTime(2011, 1, 1));
        //        line2011.Label = "2011"; line2011.DrawMode = AnnotationDrawMode.BelowSeries;
        //        CartesianGridLineAnnotation line2012 = new CartesianGridLineAnnotation(horizontalAxis, new DateTime(2012, 1, 1));
        //        line2012.Label = "2012";
        //        line2012.DrawMode = AnnotationDrawMode.BelowSeries;
        //        this.radChartView1.Area.Annotations.Add(line2011);
        //        this.radChartView1.Area.Annotations.Add(line2012);
        //        this.radChartView1.View.Palette = KnownPalette.Metro;
        //        this.MainChart.Series.Add(series);
        //    }

    }
}
