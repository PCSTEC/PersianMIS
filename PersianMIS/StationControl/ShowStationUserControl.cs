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
        string startdate, enddate;
        PersianCulture persianCulture = new PersianCulture();
        BLL.Cls_Station Bll_Stations = new BLL.Cls_Station();

        public ShowStationUserControl()
        {
            InitializeComponent();
        }




        private void FillLstStation()
        {
            LSTStations.DataSource = Bll_Stations.GetStations();
            LSTStations.DisplayMember = "stationName";
            LSTStations.ValueMember = "stationid";
        }


        private void FillData(string StartDate, string EndDate, string ListOfStations)
        {
            if (LSTStations.CheckedItems.Count > 1)
            {

                for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
                {


                }
            }
            else
            {
            //    BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetDeviceLineByProductLineId(LSTStations.CheckedItems[0].Value.ToString());


            }



        }




        private void radButtonElementWeek_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-7);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-7).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate, SelectedStation);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-30);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-30).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate, SelectedStation);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Year_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-365);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-365).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate, "");
            this.Cursor = Cursors.Default;
        }

  

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printablePanel.PrintPreview();
        }



        private void FillLastData()
        {
            //BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetLastStateOfDeviceLineData();
            //for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            //{
            //    try
            //    {


            //        var coordinates = LastApprochmentInfo.CoordinatesOf(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString());

            //        if (coordinates.Item1 == -1) //New Event In Device Line Id 
            //        {
            //            LastApprochmentInfo[ExtensionMethods.NewIndex, 0] = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ID"].ToString();
            //            LastApprochmentInfo[ExtensionMethods.NewIndex, 1] = BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString();

            //            int totalHours;


            //            this.radScheduler1.Backgrounds.Add(new AppointmentBackgroundInfo(this.radScheduler1.Backgrounds.Count + 1, "test", Color.FromArgb(Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString()))));

            //            totalHours = 0;

            //            totalHours = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["duration"].ToString()); // (DateTime.Parse(dt.DefaultView[i]["MiladiFinishDateTime"].ToString()) - DateTime.Parse(dt.DefaultView[i]["MiladiStartDateTime"].ToString())).TotalSeconds;

            //            DateTime Start = new DateTime();
            //            DateTime end = new DateTime();
            //            Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
            //            end = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());




            //            Appointment app = new Appointment(Start.AddSeconds(1), end, (Math.Round((double)totalHours / 60)).ToString());

            //            app.StatusId = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString());



            //            app.ResourceId = this.radScheduler1.Resources.GetById(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString()).Id;

            //            app.BackgroundId = this.radScheduler1.Backgrounds[this.radScheduler1.Backgrounds.Count - 1].Id;

            //            if (BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString() == "16777215")
            //            {
            //                app.Visible = false;
            //            }
            //            this.radScheduler1.Appointments.Add(app);



            //        }
            //        else
            //        {
            //            var z = radScheduler1.Appointments.FindIndex(n => n.StatusId == Convert.ToInt32(LastApprochmentInfo[coordinates.Item1, 1].ToString()));
            //            radScheduler1.Appointments[z].Summary = (Math.Round((double)Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["Duration"].ToString()) / 60)).ToString();

            //            radScheduler1.Appointments[z].Start = (DateTime)BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"];
            //            radScheduler1.Appointments[z].End = (DateTime)BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"];

            //        }
            //    }
            //    catch (Exception E)
            //    {
            //        MessageBox.Show(E.ToString());
            //    }

        //    }
        }



        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            //if (radScheduler1.Appointments.Count > 0)
            //{
            //    FillLastData();
            //}

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


            enddate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            radDateTimePickerElementStart.Value = CurDate.AddDays(-1);
            radDateTimePickerElementEnd.Value = CurDate;

            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            startdate = CurDate.AddDays(-1).ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            enddate = CurrentDate;
            FillLstStation();
        }

        private void radDateTimePickerElementEnd_ValueChanged(object sender, ValueChangingEventArgs e)
        {
            if (IsFirstLoad == false)
            {

                try
                {
                    DateTime x = (DateTime)e.NewValue;
                    enddate = x.Year + "/" + x.Month + "/" + x.Day;

                    if (startdate == null)
                    {
                        DateTime StDate = (DateTime)radDateTimePickerElementStart.Value;
                        startdate = StDate.Year + "/" + StDate.Month + "/" + StDate.Day;// (DateTime.se (Select x => (DateTime) radDateTimePickerElementStart.Value());// IrDate.GetDateIntToStr_GivenDate(IrDate.GetLatin_FromIraniDate(IrDate.ConvDateStrToInt_GivenDate(radDateTimePickerElementStart.Value.Value.ToShortDateString())).ToString());
                    }
                    FillData(startdate, enddate, SelectedStation);
                    System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;


                }
                catch
                {
                    DateTime x = (DateTime)e.OldValue;
                    startdate = x.Year + "/" + x.Month + "/" + x.Day;
                    if (startdate == null)
                    {
                        startdate = IrDate.GetDateIntToStr_GivenDate(IrDate.GetLatin_FromIraniDate(IrDate.ConvDateStrToInt_GivenDate(radDateTimePickerElementStart.Value.Value.ToShortDateString())).ToString());
                    }
                    FillData(startdate, enddate, SelectedStation);
                    System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;

                }
            }
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
            FillData(startdate, enddate, SelectedStation);
            this.Cursor = Cursors.Default;

        }

        private void radDateTimePickerElementStart_ValueChanged(object sender, ValueChangingEventArgs e)
        {
            if (IsFirstLoad == false)
            {
                try
                {
                    DateTime x = (DateTime)e.NewValue;
                    startdate = x.Year + "/" + x.Month + "/" + x.Day;
                    if (enddate == null)
                    {
                        enddate = IrDate.GetDateIntToStr_GivenDate(IrDate.GetLatin_FromIraniDate(IrDate.ConvDateStrToInt_GivenDate(radDateTimePickerElementEnd.Value.Value.ToShortDateString())).ToString());
                    }
                    FillData(startdate, enddate, SelectedStation);

                    System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;

                }
                catch
                {
                    DateTime x = (DateTime)e.OldValue;
                    startdate = x.Year + "/" + x.Month + "/" + x.Day;
                    if (enddate == null)
                    {
                        enddate = IrDate.GetDateIntToStr_GivenDate(IrDate.GetLatin_FromIraniDate(IrDate.ConvDateStrToInt_GivenDate(radDateTimePickerElementEnd.Value.Value.ToShortDateString())).ToString());
                    }
                    FillData(startdate, enddate, SelectedStation);

                    System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;

                }
            }
        }


    }
}




