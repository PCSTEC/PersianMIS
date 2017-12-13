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



            this.radCollapsiblePanel2.PanelContainer.Controls.Add(this.LSTStations);
            LSTStations.Name = "LSTStations";
            LSTStations.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.LSTStations_ItemCheckedChanged);
            LSTStations.Dock = System.Windows.Forms.DockStyle.Fill;


        

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

                MainPnl.Controls.Add(UcShowStation);

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
            //    String CurrentDate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            FillData(SelectedStation);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-30);
            MskEndDate.Value = CurDate;
            Cmb_FromShift_TextChanged(e, e);
            Cmb_ToShift_TextChanged(e, e);
            //   String CurrentDate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
            FillData(SelectedStation);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Year_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-365);
            MskEndDate.Value = CurDate;
            Cmb_FromShift_TextChanged(e, e);
            Cmb_ToShift_TextChanged(e, e);
            //      String CurrentDate = CurDate.ToString("yyyy/mm/dd HH:mm:ss", new CultureInfo("en-US"));
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


            pers.FillCmb(ShiftCalanders.GetShiftListWithInfo(), Cmb_FromShift, "ShiftID", "ShiftTitle");
            pers.FillCmb(ShiftCalanders.GetShiftListWithInfo(), Cmb_ToShift, "ShiftID", "ShiftTitle");

            Cmb_FromShift_TextChanged(e, e);
            Cmb_ToShift_TextChanged(e, e);
            enddate = CurrentDate;
            FillLstStation();



            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;




        }

        private void radDateTimePickerElementEnd_ValueChanged(object sender, ValueChangingEventArgs e)
        {
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

            Cmb_FromShift_TextChanged(e, e);
            Cmb_ToShift_TextChanged(e, e);

        }

        private void Btn_Week_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            MskStartDate.Value = CurDate.AddDays(-7);
            MskEndDate.Value = CurDate;
            Cmb_FromShift_TextChanged(e, e);
            Cmb_ToShift_TextChanged(e, e);
            FillData(SelectedStation);
            this.Cursor = Cursors.Default;

        }

        private void Cmb_FromShift_SelectedValueChanged(object sender, Telerik.WinControls.UI.Data.ValueChangedEventArgs e)
        {
            try
            {
                DateTime ShiftDate = new DateTime();
                ShiftDate = (DateTime)MskStartDate.Value;

                string Time = " " + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Cmb_FromShift.SelectedValue.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00";

                MskStartDate.Value = DateTime.Parse(ShiftDate.ToShortDateString().Trim() + Time);

            }
            catch
            {

            }

           
        }

        private void Cmb_ToShift_SelectedValueChanged(object sender, Telerik.WinControls.UI.Data.ValueChangedEventArgs e)
        {
            try
            {
                DateTime ShiftDate2 = new DateTime();
                ShiftDate2 = (DateTime)MskEndDate.Value;

                string Time = " " + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Cmb_ToShift.SelectedValue.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":00";

                MskEndDate.Value = DateTime.Parse(ShiftDate2.ToShortDateString().Trim() + Time);

            }
            catch
            {

            }
        }

        private void Cmb_FromShift_TextChanged(object sender, EventArgs e)
        {

            try
            {
                DateTime ShiftDate = new DateTime();
                ShiftDate = (DateTime)MskStartDate.Value;

                string Time = " " + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Cmb_FromShift.SelectedValue.ToString())).DefaultView[0]["ShiftBeginHourTxt"].ToString() + ":00";

                MskStartDate.Value = DateTime.Parse(ShiftDate.ToShortDateString().Trim() + Time);

            }
            catch
            {

            }


        }

        private void Cmb_ToShift_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime ShiftDate = new DateTime();
                ShiftDate = (DateTime)MskEndDate.Value;

                string Time = " " + ShiftCalanders.GetShiftInfoByShiftID(int.Parse(Cmb_ToShift .SelectedValue.ToString())).DefaultView[0]["ShiftEndHourTxt"].ToString() + ":00";

                MskEndDate.Value = DateTime.Parse(ShiftDate.ToShortDateString().Trim() + Time);

            }
            catch
            {

            }
        }

        private void Mnu_Refresh_Click(object sender, EventArgs e)
        {
FillData(SelectedStation);
        }

        private void radDateTimePickerElementStart_ValueChanged(object sender, ValueChangingEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;
          


        }


    }
}




