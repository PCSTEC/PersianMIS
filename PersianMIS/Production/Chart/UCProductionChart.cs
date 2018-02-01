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

            }
        }
 

 

   

        private void RadResizerChart_MouseDown(object sender, MouseEventArgs e)
        {
        
        }

        private void RadResizerChart_MouseUp(object sender, MouseEventArgs e)
        {
          

        }

        private void RadResizerChart_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MainChart_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
        }

        private void MainChart_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
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






        private void FillData()
        {

            BLL.Cls_PublicOperations.Dt = Bll_Chart.GetSpecialChartParameterData(this.Tag.ToString());
            MainChart.Series.Clear();
            MainChart.ChartAreas.Clear();
            MainChart.Legends.Clear();

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
                    TSql = TSql.Replace("strcolumns", ",StartDate");

                }
                if (Mnu_Month.Checked)
                {
                    TSql = TSql.Replace("strcolumns", ",CalIraniMonthID");

                }
                if (Mnu_Week.Checked)
                {
                    TSql = TSql.Replace("strcolumns", ",CalIraniWeekNum");
                }
                if (Mnu_Year.Checked)
                {
                    TSql = TSql.Replace("strcolumns", ",CalIraniYearID");
                }
            }

            Dt = Bll_Public.GetDataTableFromTSQL(TSql);
            MainChart.DataSource = Dt;
            MainChart.DataBind();
            //    MainChart.Series.Add("Default");
            //    MainChart.Series[0].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartType"].ToString()); ;// Enum.GetValues (typeof(SeriesChartType), "RangeBar");// System.Windows.Forms.DataVisualization.Charting.SeriesChartType( "System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar") ;
            MainChart.Legends.Add("Default");
            MainChart.Legends.Add("Date");
            Boolean IsRandomColor = false;
            if (Dt.DefaultView[0]["StateColor"].ToString() == Dt.DefaultView[1]["StateColor"].ToString())
            {
                IsRandomColor = true;
            }
            ColourGenerator generator = new ColourGenerator();

            for (int i = 0; i <= Dt.Rows.Count; i++)
            {
                try
                {
                    MainChart.Series.Add(Dt.DefaultView[i]["Fullname"].ToString());
                    // MainChart.Series[Dt.DefaultView[i]["Fullname"].ToString()].ChartArea = "Main Area";
                    MainChart.Series[Dt.DefaultView[i]["Fullname"].ToString()].YValueMembers = "Duration";
                    if (IsRandomColor)
                    {
                        
                        string x = generator.NextColour();
                        //  Random rnd = new Random();
                        MainChart.Series[Dt.DefaultView[i]["Fullname"].ToString()].Color = System.Drawing.ColorTranslator.FromHtml("#" + generator.NextColour());

                        // Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                    }
                    else
                    {
                        MainChart.Series[Dt.DefaultView[i]["Fullname"].ToString()].Color = Color.FromArgb(Convert.ToInt32(Dt.DefaultView[i]["StateColor"].ToString()));

                    }

                    MainChart.Series[Dt.DefaultView[i]["Fullname"].ToString()].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartType"].ToString());// Enum.GetValues (typeof(SeriesChartType), "RangeBar");// System.Windows.Forms.DataVisualization.Charting.SeriesChartType( "System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar") ;
                                                                                                                                                                                                                    //  MainChart.Series [Dt.DefaultView[i]["Fullname"].ToString()].Legend = "Default";
                                                                                                                                                                                                                    //      MainChart.Series [Dt.DefaultView[i]["Fullname"].ToString()].LegendText = "#VALX";
                }

                catch
                {

                }

            }










            //  MainChart.Series[0].LegendText = "StartDate";// "#VALX";

            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["chartAxisXType"].ToString() == "1")
            {

                if (Mnu_FullDate.Checked)
                {
                    foreach (var N in MainChart.Series)
                    {
                        N.XValueMember = "StartDate";
                    }
                    //   MainChart.Series[0].XValueMember = "StartDate";
                    //     MainChart.Series["Date"].XValueMember = "ProductLineDesc";
                    //   MainChart.Series["Date"].Legend = "Default";
                    //  MainChart.Series["Date"].LegendText = "#VALX";
                    // MainChart.Series["Date"].YValueMembers = "Duration";
                    //    MainChart.Series[0].XValueMember = "StartDate";
                }
                if (Mnu_Month.Checked)
                {
                    MainChart.Series[0].XValueMember = "CalIraniMonthID";

                }
                if (Mnu_Week.Checked)
                {
                    MainChart.Series[0].XValueMember = "CalIraniWeekNum";

                }
                if (Mnu_Year.Checked)
                {
                    MainChart.Series[0].XValueMember = "CalIraniYearID";

                }
            }



            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["chartAxisXType"].ToString() == "2")
            {

                MainChart.Series[0].XValueMember = "StateCaption";

            }
            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["chartAxisXType"].ToString() == "3")
            {

                MainChart.Series[0].XValueMember = "Fullname";
            }



            //if (  BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "1")
            //{
            //    MainChart.Series[0].Legend = "Default";
            //    MainChart.Series[0].LegendText = "#VALX";
            //}

           
            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartLegentType"].ToString() == "3")
            {
                MainChart.Series[0].IsVisibleInLegend = false;
            }







         //   MainChart.Series[0].YValueMembers = "Duration";// نمایش مقدار در قسمت Y

            //  MainChart.Series[0].Points.DataBindXY(, );
            //  MainChart.Series[0].LabelToolTip  = "!StartDate";




            MainChart.ChartAreas.Add("Main Area");
            MainChart.ChartAreas[0].BackColor = Color.Transparent;


            MainChart.Legends[0].BackColor = Color.Transparent;
            MainChart.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;


            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ShowChartCaption"].ToString() == "True")
            {
                MainChart.Titles[0].Text = BLL.Cls_PublicOperations.Dt.DefaultView[0]["Caption"].ToString();
                MainChart.Titles[0].Visible = true;
            }



            if (BLL.Cls_PublicOperations.Dt.DefaultView[0]["ChartTypeDataShow"].ToString() == "1")
            {
                //MainChart.Series["Default"].IsValueShownAsLabel = false;
                MainChart.Series["Default"].Label = "#VAL";
             //   MainChart.Series[0].IsValueShownAsLabel = true;
            }
            else
            {
                foreach (var N in MainChart.Series)
                {
                  
                    
                 //   N.IsValueShownAsLabel = true;
                    N.Label = "#PERCENT";
                }

               
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