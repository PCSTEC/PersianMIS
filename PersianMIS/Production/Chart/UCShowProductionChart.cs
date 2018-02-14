using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersianMIS.Public_Class;
using System.Globalization;
using Telerik.WinControls.UI;
using Telerik.WinControls;
using Telerik.WinControls.UI.Localization;
using Calendars;

namespace PersianMIS.Production.Chart
{
    public partial class UCShowProductionChart : UserControl
    {
        Telerik.WinControls.UI.RadCheckedListBox LSTStations = new Telerik.WinControls.UI.RadCheckedListBox();
        string SelectedStation = "0";
        Font HeaderFont = new Font("b titr", 10f, FontStyle.Bold);
        public Boolean IsFirstLoad = false;
        IraniDate.IraniDate.IraniDate IrDate = new IraniDate.IraniDate.IraniDate();
        Persistent.DataAccess.DataAccess pers = new Persistent.DataAccess.DataAccess();
        DateTime CurDate = DateTime.Now;
        string startdate, enddate;
        PersianCulture persianCulture = new PersianCulture();
        BLL.CLS_Chart Bll_Chart = new BLL.CLS_Chart();
        Calendars.Shift ShiftCalanders = new Shift();
        public UCShowProductionChart()
        {
            InitializeComponent();

            LSTStations.Controls.Add(Btn_Check);
            LSTStations.Name = "LSTStations";
            LSTStations.Dock = System.Windows.Forms.DockStyle.Fill;
            LSTStations.Visible = true;
            this.radCollapsiblePanel2.PanelContainer.Controls.Add(this.LSTStations);

            radCollapsiblePanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        
        }

        private void FillLstStation()
        {
            LSTStations.DataSource = Bll_Chart.GetListOFChartForSpecialUser("all");
            LSTStations.DisplayMember = "Caption";
            LSTStations.ValueMember = "ChartOptionId";
        }


        private void FillData(string ListOfStations)
        {
            MainPnl.Controls.Clear();


            foreach (var x in LSTStations.CheckedItems)
            {
                Chart.UCProductionChart  UcShowStation = new UCProductionChart();
               
                UcShowStation.Tag = x.Value.ToString();
                UcShowStation.TitleBar.Text = x.Text;
                MskStartDate.Culture = new CultureInfo("en-GB");
                UcShowStation.StartDate = (DateTime)MskStartDate.Value;
                MskStartDate.Culture = new CultureInfo("fa-IR");
     
                MskEndDate.Culture = new CultureInfo("en-GB");
                UcShowStation.EndDate = (DateTime)MskEndDate.Value;
                MskEndDate.Culture = new CultureInfo("fa-IR");
                UcShowStation.Times = "";

                if (Ch_Shift1.Checked)
                {
                    if (UcShowStation.Times.Length > 2)
                    {

                        if (Ch_DontCalcRestTime.Checked)
                        {

                            UcShowStation.Times = UcShowStation.Times + " or     CAST(EndTime AS time)  BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":59" + "'  and     CAST(StartTime AS time) >=   '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt1"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt1"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt2"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt2"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt3"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt3"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt4"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt4"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt5"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt5"].ToString() + ":00" + "' ";


                        }
                        else
                        {
                            UcShowStation.Times = UcShowStation.Times + " or     CAST(EndTime AS time)  BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":59" + "'  and     CAST(StartTime AS time) >=   '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "'";

                        }

                    }
                    else
                    {
                        if (Ch_DontCalcRestTime.Checked)
                        {
                            UcShowStation.Times = UcShowStation.Times + " and   ( CAST(EndTime AS time)  BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":59" + "'  and     CAST(StartTime AS time) >=   '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt1"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt1"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt2"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt2"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt3"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt3"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt4"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt4"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt5"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt5"].ToString() + ":00" + "' ";
                        }
                        else
                        {
                            UcShowStation.Times = UcShowStation.Times + " and   ( CAST(EndTime AS time)  BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":59" + "'  and     CAST(StartTime AS time) >=   '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift1.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "'";
                        }


                    }
                }

                if (Ch_Shift2.Checked)
                {
                    if (UcShowStation.Times.Length > 2)
                    {

                        if (Ch_DontCalcRestTime.Checked)
                        {
                            UcShowStation.Times = UcShowStation.Times + " or   CAST(EndTime AS time)  BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":59" + "'  and     CAST(StartTime AS time) >=   '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt1"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt1"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt2"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt2"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt3"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt3"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt4"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt4"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt5"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt5"].ToString() + ":00" + "' ";

                        }
                        else
                        {

                            UcShowStation.Times = UcShowStation.Times + " or     CAST(EndTime AS time)  BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":59" + "'  and     CAST(StartTime AS time) >=   '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "'";

                        }

                    }
                    else
                    {
                        if (Ch_DontCalcRestTime.Checked)
                        {
                            UcShowStation.Times = UcShowStation.Times + " and   ( CAST(EndTime AS time)  BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":59" + "'  and     CAST(StartTime AS time) >=   '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt1"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt1"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt2"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt2"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt3"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt3"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt4"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt4"].ToString() + ":00" + "' and  CAST(StartTime AS time)  NOT BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginBreakTimeTxt5"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndBreakTimeTxt5"].ToString() + ":00" + "' ";

                        }
                        else
                        {
                            UcShowStation.Times = UcShowStation.Times + " and   ( CAST(EndTime AS time)  BETWEEN '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "' and '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":59" + "'  and     CAST(StartTime AS time) >=   '" + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift2.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00" + "'";

                        }
                    }
                }
                if (Ch_Shift3.Checked)
                {
                    UcShowStation.IsSHift3 = true;
                    DateTime StartDate = (DateTime)MskStartDate.Value;
                    DateTime EndDate = (DateTime)MskEndDate.Value;

                    UcShowStation.Shift3beginDate = StartDate.AddDays(1);
                    UcShowStation.Shift3Enddate = EndDate.AddDays(1);
                    UcShowStation.Shift3beginTime = ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift3.Tag.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00";
                    UcShowStation.Shift3EndTime = ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Ch_Shift3.Tag.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":00";


                }
                if (MskCountOfColumns.Text != "0")
                {
                    UcShowStation.Width = (MainPnl.Width - 40 ) / Convert.ToInt32(MskCountOfColumns.Text) ;
                }
                if (MskCountOfRow .Text != "0")
                {
                    UcShowStation.Height  = (MainPnl.Height - 40 ) /  Convert.ToInt32(MskCountOfRow.Text) ;
                }


                MainPnl.Controls.Add(UcShowStation);



            }



            MskEndDate.Culture = persianCulture;
            MskStartDate.Culture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;



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

        private void UCShowProductionChart_Load(object sender, EventArgs e)
        {
            enddate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            MskStartDate.Value = CurDate.AddDays(-1);
            MskEndDate.Value = CurDate;

            String CurrentDate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            startdate = CurDate.AddDays(-1).ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));




            enddate = CurrentDate;
            FillLstStation();



            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;


        }

        private void Btn_Check_Click(object sender, EventArgs e)
        {
            if (this.Btn_Check.Tag.ToString() == "1")
            {
                this.LSTStations.CheckAllItems();
                this.Btn_Check.Tag = "0";
                ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Check.GetChildAt(0))).Image = global::PersianMIS.Properties.Resources.UnCheck;

            }
            else
            {
                this.LSTStations.UncheckAllItems();
                this.Btn_Check.Tag = "1";
                ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Check.GetChildAt(0))).Image = global::PersianMIS.Properties.Resources.Check;

            }
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            if (Ch_Shift1.Checked == false && Ch_Shift2.Checked == false && Ch_Shift3.Checked == false)
            {
                MessageBox.Show("لطفاً حداقل یک شیفت را انتخاب نمائید", Properties.Settings.Default.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            SelectedStation = "0";

            foreach (var CheckedItem in LSTStations.CheckedItems)
            {
                SelectedStation = SelectedStation + "," + CheckedItem.Value.ToString() + "";

            }
            SelectedStation = "'" + SelectedStation + "'";
            FillData(SelectedStation);
            this.Cursor = Cursors.Default;

        }

   

        private void Ch_ShowOnlineData_CheckStateChanged(object sender, EventArgs e)
        {
            foreach (Control Ctrl in MainPnl.Controls)
            {
                var n = (Production.Chart.UCProductionChart)Ctrl;
                n.Maintimer.Enabled = Ch_ShowOnlineData.Checked;
            }
        }

        private void Mnu_Refresh_Click(object sender, EventArgs e)
        {
            Btn_Show_Click(sender, e);
        }

        private void Mnu_AddChart_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_SelectChartOptions();
            frm.ShowDialog();
            FillLstStation();
        }
    }
}
