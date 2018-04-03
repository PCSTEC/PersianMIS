using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace PersianMIS.Production.Chart
{
    public partial class UCProductionChart : UserControl
    {
        private Color color;
        private int b;

        Boolean mouseClicked = false;
        public UCProductionChart()
        {
            InitializeComponent();
        }

        private void MainChart_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new Frm_SelectChartOptions();
            frm.ShowDialog();



        }
        BLL.CLS_Chart Bll_Chart = new BLL.CLS_Chart();
        string[] RandomColor;
        BLL.Cls_PublicOperations Bll_Public = new BLL.Cls_PublicOperations();
        public DateTime StartDate, EndDate, ShiftDate, Shift3beginDate, Shift3Enddate = new DateTime();
        public Boolean IsSHift3 = false;
        public Boolean ISAccumulative = false;
        public string Times, Shift3beginTime, Shift3EndTime = "";
        public string ParameterTSQL;

        IKIDUtility.IKIDUtility.Formating Utility = new IKIDUtility.IKIDUtility.Formating();


        DataTable Dt = new DataTable();

        private void UCProductionChart_Load(object sender, EventArgs e)
        {
            FillData();

        }

        private void Mnu_FullDate_CheckStateChanged(object sender, EventArgs e)
        {
            var x = (System.Windows.Forms.ToolStripMenuItem)sender;

            if (x.Checked)
            {
                Mnu_Month.Checked = false;
                Mnu_Week.Checked = false;
                Mnu_Year.Checked = false;
                FillData();

            }
        }

        private void Mnu_Month_CheckStateChanged(object sender, EventArgs e)
        {
            var x = (System.Windows.Forms.ToolStripMenuItem)sender;

            if (x.Checked)
            {
                Mnu_FullDate.Checked = false;
                Mnu_Week.Checked = false;
                Mnu_Year.Checked = false;
                FillData();
            }
        }

        private void Mnu_Week_CheckStateChanged(object sender, EventArgs e)
        {
            var x = (System.Windows.Forms.ToolStripMenuItem)sender;

            if (x.Checked)
            {
                Mnu_Month.Checked = false;
                Mnu_FullDate.Checked = false;
                Mnu_Year.Checked = false;
                FillData();
            }
        }

        private void Mnu_Year_CheckStateChanged(object sender, EventArgs e)
        {
            var x = (System.Windows.Forms.ToolStripMenuItem)sender;

            if (x.Checked)
            {
                Mnu_Month.Checked = false;
                Mnu_FullDate.Checked = false;
                Mnu_Week.Checked = false;
                FillData();
            }
        }




        private void MainChart_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void MainChart_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void MainChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                this.Height = this.Top + e.Y;
                this.Width = this.Left + e.X;
            }
        }

        private void BtnClosed_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            this.Hide();
        }

        //  BLL.CLS_DeviceLine Bll_DeviceLine = new CLS_DeviceLine();
        public DevComponents.DotNetBar.PanelEx TitleBar
        {
            get { return TopPnl; }
            set { TopPnl = TitleBar; }
        }



        public Timer Maintimer
        {
            get { return MainTimer; }
            set { MainTimer = Maintimer; }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            FillData();
        }

        public DevComponents.DotNetBar.BubbleButton BtnColse
        {
            get { return BtnClosed; }
        }


        public Color Random()
        {
            Random r = new Random();
            b = r.Next(1, 6);
            switch (b)
            {
                case 1:
                    {
                        color = Color.Aqua;
                    }
                    break;
                case 2:
                    {
                        color = Color.LightBlue;
                    }
                    break;
                case 3:
                    {
                        color = Color.LightCyan;
                    }
                    break;
                case 4:
                    {
                        color = Color.LightGreen;
                    }
                    break;


                case 5:
                    {
                        color = Color.LightPink;
                    }
                    break;
                case 6:
                    {
                        color = Color.LightYellow;
                    }
                    break;
                case 7:
                    {
                        color = Color.Maroon;
                    }
                    break;

            }

            return color;
        }

        private static readonly Random rand = new Random();



        private void FillData()
        {

            BLL.Cls_PublicOperations.Dt = Bll_Chart.GetSpecialChartParameterData(this.Tag.ToString());
            MainChart.Series.Clear();
            MainChart.ChartAreas.Clear();
            MainChart.Legends.Clear();
            MainChart.Titles.Clear();
            DataTable DtTrend = new DataTable();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            string TSql = BLL.Cls_PublicOperations.Dt.DefaultView[0]["TSQL"].ToString();

            TSql = TSql.Replace("01/01/2015 00:00:00", StartDate.ToString("MM/dd/yyyy"));

            TSql = TSql.Replace("01/01/2016 00:00:00", EndDate.ToString("MM/dd/yyyy"));
            if (IsSHift3)
            {
                TSql = TSql.Replace("'12/12/2005'", "'" + Shift3beginDate.ToString("MM/dd/yyyy") + "'");
                TSql = TSql.Replace("'12/13/2005'", "'" + Shift3Enddate.ToString("MM/dd/yyyy") + "'");
                TSql = TSql.Replace("01:00:00", Shift3beginTime);
                TSql = TSql.Replace("06:00:00", Shift3EndTime);
                if (IsSHift3 && Times.Length < 5)
                {
                    TSql = TSql.Replace("strtime", "AND (CAST(dbo.Tb_Client.StartTime AS time) BETWEEN '00:00:00' AND  '00:00:00' ");
                }
            }
            TSql = TSql.Replace(" 60 ", " 1 ");
            TSql = TSql.Replace(" 3600 ", " 1 ");


            TSql = TSql.Replace("strtime", Times);



            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["chartAxisXType"].ToString() == "1")
            {
                if (Mnu_FullDate.Checked)
                {
                    TSql = TSql.Replace("strcolumns", ",StartDate ");

                }
                if (Mnu_Month.Checked)
                {
                    TSql = TSql.Replace("strcolumns", ",CalIraniMonthID ");

                }
                if (Mnu_Week.Checked)
                {
                    TSql = TSql.Replace("strcolumns", ",CalIraniWeekNum  ");
                }
                if (Mnu_Year.Checked)
                {
                    TSql = TSql.Replace("strcolumns", ",CalIraniYearID  ");
                }



                if (Mnu_FullDate.Checked)
                {
                    TSql = TSql + "  order by startdate";

                }
                if (Mnu_Month.Checked)
                {
                    TSql = TSql + " order by CalIraniMonthID";

                }
                if (Mnu_Week.Checked)
                {
                    TSql = TSql + " order by CalIraniWeekNum";
                }
                if (Mnu_Year.Checked)
                {
                    TSql = TSql + " order by CalIraniYearID";
                }

            }
            TSql = TSql.Replace("strcolumns", "");
            DataTable TempTable = new DataTable();
            TempTable = Bll_Public.GetDataTableFromTSQL(TSql);
            // TempTable.DefaultView.RowFilter = "Fullname <> '0'";

            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ShowChartPurpose"].ToString() == "True")
            {
                Dt = TempTable.DefaultView.Table.Select("Fullname <> '0'").CopyToDataTable();

                DtTrend = TempTable.DefaultView.Table.Select("Fullname ='0'").CopyToDataTable();
            }
            else
            {
                Dt = TempTable.DefaultView.Table.Select("Fullname <> '0'").CopyToDataTable();
            }
            //   Dt = Bll_Public.GetDataTableFromTSQL(TSql);
            MainChart.DataSource = Dt;
            MainChart.DataBind();
            MainChart.Legends.Add("Default");

            Boolean IsRandomColor = false;
            if (Dt.Rows.Count > 1)
            {
                if (Dt.DefaultView[0]["StateColor"].ToString() == Dt.DefaultView[1]["StateColor"].ToString() && Dt.DefaultView[0]["ProductLineDesc"].ToString() != Dt.DefaultView[1]["ProductLineDesc"].ToString())
                {
                    IsRandomColor = true;
                }
            }
            ColourGenerator generator = new ColourGenerator();

            string LegendField, Xfield, YField, LabelType;
            YField = "Duration";
            Xfield = "";
            LegendField = "";
            LabelType = "";
            try
            {
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["chartAxisXType"].ToString() == "1")
                {

                    if (Mnu_FullDate.Checked)
                    {

                        //  MainChart.DataBindCrossTab(myReader, "Name", "Year", "Sales", "Label=Commissions");
                        /// MainChart.Series[Dt.DefaultView[i]["Fullname"].ToString()].Points.DataBindXY(  Dt.DefaultView[i]["StartDate"].ToString(), "");

                        Xfield = "StartDate";

                    }
                    if (Mnu_Month.Checked)
                    {

                        Xfield = "CalIraniMonthID";

                    }
                    if (Mnu_Week.Checked)
                    {
                        Xfield = "CalIraniWeekNum";

                    }
                    if (Mnu_Year.Checked)
                    {
                        Xfield = "CalIraniYearID";
                    }
                }

                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["chartAxisXType"].ToString() == "2")
                {
                    Xfield = "StateCaption";

                }
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["chartAxisXType"].ToString() == "3")
                {
                    Xfield = "Fullname";

                }
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["chartAxisXType"].ToString() == "7")
                {
                    Xfield = "ProductLineDesc";

                }

                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "1")
                {
                    LegendField = "StateCaption";
                }
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "2")
                {
                    LegendField = "Fullname";
                }
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "3")
                {
                    LegendField = "ProductLineDesc";
                }
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "4")
                {
                    LegendField = "";


                }



                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartTypeDataShow"].ToString() == "1")
                {


                    LabelType = "Label=#VAL";



                }
                else
                {


                    LabelType = "Label=#PERCENT";







                }


                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["IsChartBar"].ToString() == "True")
                {
                    MainChart.DataBindCrossTable(Dt.AsEnumerable(), LegendField, Xfield, YField, "Label=Duration");
                    foreach (Series N in MainChart.Series)
                    {
                        N.AxisLabel = "ProductLineDesc";
                        N.BorderWidth = 2;
                    }


                }
                else
                {

                    MainChart.Series.Add("Default");
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        MainChart.Series["Default"].Points.AddXY(Dt.DefaultView[i][Xfield].ToString(), Convert.ToInt32(Dt.DefaultView[i][YField]));


                    }

                    MainChart.Series[0].Legend = "Default";
                    MainChart.Series[0].IsVisibleInLegend = true;
                    MainChart.Series[0].LegendText = "#VALX";


                }




                try
                {
                    if (IsRandomColor && BLL.Cls_PublicOperations.Dt.DefaultView[0]["IsChartBar"].ToString() == "True")
                    {


                        foreach (Series N in MainChart.Series)
                        {
                            //   N.Color = System.Drawing.ColorTranslator.FromHtml("#" + generator.NextColour());

                            N.Color = System.Drawing.ColorTranslator.FromHtml("#" + generator.NextColour());
                        }

                    }
                    if (IsRandomColor && BLL.Cls_PublicOperations.Dt.DefaultView[0]["IsChartBar"].ToString() == "False")
                    {
                        for (int x = 0; x < MainChart.Series.Count; x++)
                        {
                            for (int i = 0; i < MainChart.Series[x].Points.Count; i++)
                            {
                                foreach (Series N in MainChart.Series)
                                {
                                    //   N.Color = System.Drawing.ColorTranslator.FromHtml("#" + generator.NextColour());

                                    // N.Color = Random();
                                    MainChart.Series[x].Points[i].Color = System.Drawing.ColorTranslator.FromHtml("#" + generator.NextColour());
                                }
                            }
                        }
                    }
                    else
                    {

                        for (int x = 0; x < MainChart.Series.Count; x++)
                        {
                            for (int i = 0; i < MainChart.Series[x].Points.Count; i++)
                            {

                                for (int j = 0; j < Dt.Rows.Count; j++)
                                {
                                    if (Dt.DefaultView[j][LegendField].ToString() == MainChart.Series[x].Points[i].AxisLabel  )
                                    {
                                       
                                        MainChart.Series[x].Points[i].Color = Color.FromArgb(Convert.ToInt32(Dt.DefaultView[j]["StateColor"].ToString()));
                                     //   MainChart.Series[x].Color = Color.Red;// Color.FromArgb(Convert.ToInt32(Dt.DefaultView[j]["StateColor"].ToString()));
                                    }
                                }


                            }

                        }


                       


                    }
                }
                catch
                {

                }
                try
                {
                    foreach (Series N in MainChart.Series)
                    {
                        N.AxisLabel = "ProductLineDesc";
                        N.ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartType"].ToString());// Enum.GetValues (typeof(SeriesChartType), "RangeBar");// System.Windows.Forms.DataVisualization.Charting.SeriesChartType( "System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar") ;


                    }
                }
                catch
                {

                }


                //  MainChart.Series [Dt.DefaultView[i]["Fullname"].ToString()].Legend = "Default";
                //      MainChart.Series [Dt.DefaultView[i]["Fullname"].ToString()].LegendText = "#VALX";
            }

            catch
            {

            }



            try
            {
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "4")
                {
                    foreach (Series N in MainChart.Series)
                    {
                        N.IsVisibleInLegend = false;


                    }


                }
            }



            catch
            {

            }









            //  MainChart.Series[0].LegendText = "StartDate";// "#VALX";





            //if (  BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "1")
            //{
            //    MainChart.Series[0].Legend = "Default";
            //    MainChart.Series[0].LegendText = "#VALX";
            //}









            //   MainChart.Series[0].YValueMembers = "Duration";// نمایش مقدار در قسمت Y

            //  MainChart.Series[0].Points.DataBindXY(, );
            //  MainChart.Series[0].LabelToolTip  = "!StartDate";




            MainChart.ChartAreas.Add("Main Area");
            MainChart.ChartAreas[0].BackColor = Color.Transparent;


            MainChart.Legends[0].BackColor = Color.Transparent;
            MainChart.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ShowChartCaption"].ToString() == "True")
            {
                MainChart.Titles.Add("Default");
                MainChart.Titles[0].Text = BLL.Cls_PublicOperations.Dt.DefaultView[0]["Caption"].ToString();
                MainChart.Titles[0].Visible = true;
            }


            try
            {
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartTypeDataShow"].ToString() == "1")
                {
                    for (int x = 0; x < MainChart.Series.Count; x++)
                    {
                        for (int i = 0; i < MainChart.Series[x].Points.Count; i++)
                        {
                            MainChart.Series[x].Points[i].Label = "#VAL";
                        }

                    }


                }
            }

            catch
            {

            }

            try
            {
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartTypeDataShow"].ToString() == "2")
                {
                    for (int x = 0; x < MainChart.Series.Count; x++)
                    {
                        for (int i = 0; i < MainChart.Series[x].Points.Count; i++)
                        {
                            MainChart.Series[x].Points[i].Label = "#PERCENT";
                        }

                    }


                }
            }
            catch
            {

            }


            try
            {
                if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartTypeDataShow"].ToString() == "3")
                {
                    for (int x = 0; x < MainChart.Series.Count; x++)
                    {
                        for (int i = 0; i < MainChart.Series[x].Points.Count; i++)
                        {
                            MainChart.Series[x].Points[i].Label = "";
                        }

                    }


                }
            }
            catch
            {

            }








            //if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "1")
            //{
            //    MainChart.Series[0].LegendText = "StartDate";// "#VALX";

            //}
            //else
            //{

            //    MainChart.Series[0].LegendText = "StartDate";// "#VALX";

            //}




            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ShowChart3D"].ToString() == "True")
            {
                MainChart.ChartAreas[0].Area3DStyle.Enable3D = true;

            }




            // Set drawing style
            //  MainChart.Series["Default"]["PieDrawingStyle"] = "SoftEdge";
            // MainChart.Series["Default"].IsVisibleInLegend = true;

            //Lbl_ParameterDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            //Lbl_ParameterDesc.Location = new System.Drawing.Point(8, 7);
            //Lbl_ParameterDesc.Name = "Lbl_ParameterDesc";
            //Lbl_ParameterDesc.Size = new System.Drawing.Size(91, 26);
            //Lbl_ParameterDesc.TabIndex = 6;
            //Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;



            //if (Dt.Rows.Count > 0)
            //{
            //    decimal Data = Decimal.Parse(Utility.NZ(Dt.DefaultView[0][0].ToString(), 0).ToString());

            //    // Lbl_ParameterDesc.Text = Decimal.Round(Data, 2).ToString();

            //    if (BLL.Cls_PublicOperations.Dt.DefaultView[i]["ParameterName"].ToString().Trim().Contains("(%)"))
            //    {
            //        Lbl_ParameterDesc.Text = Decimal.Round(Data, 1).ToString();
            //    }
            //    else
            //    {
            //        TimeSpan span = TimeSpan.FromSeconds(Convert.ToDouble(Data));

            //        string label = String.Format("{0:D2}:{1:D2}:{2:D2}:{3}", span.Days, span.Hours, span.Minutes, span.Seconds);// span.ToString(@"hh\:mm\:ss");
            //        Lbl_ParameterDesc.Text = label;

            //    }



            //}
            //else
            //{
            //    Lbl_ParameterDesc.Text = "عدم خروجی دستور ایجاد شده";
            //}

            //Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //Pnl_State.Controls.Add(Lbl_ParameterCaption);
            //Pnl_State.Controls.Add(Lbl_ParameterDesc);

            //   Pnl_Main.Controls.Add(Pnl_State);


            if (DtTrend.Rows.Count > 0)
            {
                int x = MainChart.Series.Count;
                for (int i = 0; i <= x-1; i++)
                {
                    DtTrend = TempTable.DefaultView.Table.Select(LegendField + "='" + MainChart.Series[i].Name + "' ").CopyToDataTable();
                    DtTrend= DtTrend.DefaultView.Table.Select("Fullname = '0' ").CopyToDataTable();

                    MainChart.Series.Add("زمان در دسترس "+ MainChart.Series[i].Name);
                    for (int j = 0; j < DtTrend.DefaultView.Table.Rows.Count; j++)
                    {
                        

                        MainChart.Series["زمان در دسترس " + MainChart.Series[i].Name].Points.AddXY(DtTrend.DefaultView.Table.Rows[j][Xfield].ToString(), Convert.ToInt32(DtTrend.DefaultView.Table.Rows[j][YField]));
                        MainChart.Series["زمان در دسترس " + MainChart.Series[i].Name].ChartType = SeriesChartType.Line;
                        MainChart.Series["زمان در دسترس " + MainChart.Series[i].Name].Color = System.Drawing.ColorTranslator.FromHtml("#" + generator.NextColour());
                    }
                }

            }
        }
    }
}







public class ColourGenerator
{

    private int index = 0;
    private IntensityGenerator intensityGenerator = new IntensityGenerator();

    public string NextColour()
    {
        string colour = string.Format(PatternGenerator.NextPattern(index),
            intensityGenerator.NextIntensity(index));
        index++;
        return colour;
    }
}
public class PatternGenerator
{
    public static string NextPattern(int index)
    {
        switch (index % 7)
        {
            case 0: return "{0}0000";
            case 1: return "00{0}00";
            case 2: return "0000{0}";
            case 3: return "{0}{0}00";
            case 4: return "{0}00{0}";
            case 5: return "00{0}{0}";
            case 6: return "{0}{0}{0}";
            default: throw new Exception("Math error");
        }
    }
}

public class IntensityGenerator
{
    private IntensityValueWalker walker;
    private int current;

    public string NextIntensity(int index)
    {
        if (index == 0)
        {
            current = 255;
        }
        else if (index % 7 == 0)
        {
            if (walker == null)
            {
                walker = new IntensityValueWalker();
            }
            else
            {
                walker.MoveNext();
            }
            current = walker.Current.Value;
        }
        string currentText = current.ToString("X");
        if (currentText.Length == 1) currentText = "0" + currentText;
        return currentText;
    }
}

public class IntensityValue
{

    private IntensityValue mChildA;
    private IntensityValue mChildB;

    public IntensityValue(IntensityValue parent, int value, int level)
    {
        if (level > 7) throw new Exception("There are no more colours left");
        Value = value;
        Parent = parent;
        Level = level;
    }

    public int Level { get; set; }
    public int Value { get; set; }
    public IntensityValue Parent { get; set; }

    public IntensityValue ChildA
    {
        get
        {
            return mChildA ?? (mChildA = new IntensityValue(this, this.Value - (1 << (7 - Level)), Level + 1));
        }
    }

    public IntensityValue ChildB
    {
        get
        {
            return mChildB ?? (mChildB = new IntensityValue(this, Value + (1 << (7 - Level)), Level + 1));
        }
    }
}

public class IntensityValueWalker
{

    public IntensityValueWalker()
    {
        Current = new IntensityValue(null, 1 << 7, 1);
    }

    public IntensityValue Current { get; set; }

    public void MoveNext()
    {
        if (Current.Parent == null)
        {
            Current = Current.ChildA;
        }
        else if (Current.Parent.ChildA == Current)
        {
            Current = Current.Parent.ChildB;
        }
        else
        {
            int levelsUp = 1;
            Current = Current.Parent;
            while (Current.Parent != null && Current == Current.Parent.ChildB)
            {
                Current = Current.Parent;
                levelsUp++;
            }
            if (Current.Parent != null)
            {
                Current = Current.Parent.ChildB;
            }
            else
            {
                levelsUp++;
            }
            for (int i = 0; i < levelsUp; i++)
            {
                Current = Current.ChildA;
            }

        }
    }
}



