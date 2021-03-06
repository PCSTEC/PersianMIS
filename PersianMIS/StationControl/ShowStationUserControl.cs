﻿using System;
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
namespace PersianMIS.StationControl
{
    public partial class ShowStationUserControl : UserControl
    {

        string SelectedStation = "0";
        Font HeaderFont = new Font("b titr", 10f, FontStyle.Bold);
        public Boolean IsFirstLoad = false;
        IraniDate.IraniDate.IraniDate IrDate = new IraniDate.IraniDate.IraniDate();
        Persistent.DataAccess.DataAccess pers = new Persistent.DataAccess.DataAccess();
        DateTime CurDate = DateTime.Now;
        Telerik.WinControls.UI.RadCheckedListBox LSTStations = new Telerik.WinControls.UI.RadCheckedListBox();
        string startdate, enddate;
        PersianCulture persianCulture = new PersianCulture();
        BLL.Cls_Station Bll_Stations = new BLL.Cls_Station();
        Calendars.Shift ShiftCalanders = new Shift();
        public ShowStationUserControl()
        {
            InitializeComponent();


            LSTStations.Controls.Add(Btn_Check);
            LSTStations.Name = "LSTStations";
            LSTStations.Dock = System.Windows.Forms.DockStyle.Fill;

            this.radCollapsiblePanel2.PanelContainer.Controls.Add(this.LSTStations);

            radCollapsiblePanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;


        }


        private void FillLstStation()
        {
            LSTStations.DataSource = Bll_Stations.GetStations();
            LSTStations.DisplayMember = "StationName";
            LSTStations.ValueMember = "StationId";
        }


        private void FillData(string ListOfStations)
        {
            MainPnl.Controls.Clear();


            if (Ch_Accumulative.Checked)
            {
                StationControl.StationUserControl UcShowStation = new StationUserControl();

                UcShowStation.ISAccumulative = true;

                UcShowStation.Tag = ListOfStations;
                UcShowStation.TitleBar.Text = "مشاهده اطلاعات تجمعی ";
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
                MainPnl.Controls.Add(UcShowStation);
            }
            else
            {
                foreach (var x in LSTStations.CheckedItems)
                {
                    StationControl.StationUserControl UcShowStation = new StationUserControl();

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


                    MainPnl.Controls.Add(UcShowStation);



                }
            }


            MskEndDate.Culture = persianCulture;
            MskStartDate.Culture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;



        }




        private void radButtonElementWeek_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-7);
            MskEndDate.Value = CurDate;

            FillData(SelectedStation);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-30);
            MskEndDate.Value = CurDate;
            FillData(SelectedStation);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Year_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-365);
            MskEndDate.Value = CurDate;

            FillData("");
            this.Cursor = Cursors.Default;
        }



        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printablePanel.PrintPreview();
        }







        private void radDateTimePickerElementEnd_Click(object sender, EventArgs e)
        {
            IsFirstLoad = false;
        }

        private void radDateTimePickerElementStart_Click(object sender, EventArgs e)
        {
            IsFirstLoad = false;
        }



        private void ShowStationUserControl_Load(object sender, EventArgs e)
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


        private void LSTStations_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
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

        private void Btn_Week_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-7);
            MskEndDate.Value = CurDate;

            FillData(SelectedStation);
            this.Cursor = Cursors.Default;

        }


        private void Mnu_Refresh_Click(object sender, EventArgs e)
        {
            FillData(SelectedStation);
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


        private void Ch_ShowOnlineData_CheckStateChanged(object sender, EventArgs e)
        {
            foreach (Control Ctrl in MainPnl.Controls)
            {
                var n = (StationControl.StationUserControl)Ctrl;
                n.Maintimer.Enabled = Ch_ShowOnlineData.Checked;
            }
        }

        private void Ch_ShowOnlineData_Click(object sender, EventArgs e)
        {

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




    }
}




