using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersianMIS.Public_Class;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using System.Drawing.Printing;
using System.Globalization;
using Telerik.WinControls;

namespace PersianMIS.CurrentState
{

    public partial class UCShowCurrentState : UserControl
    {
        public string[,] LastApprochmentInfo = new string[100, 2];

        string SelectedProductionLines = "0";

        Font HeaderFont = new Font("b titr", 10f, FontStyle.Bold);
        public Boolean IsFirstLoad = false;
        IraniDate.IraniDate.IraniDate IrDate = new IraniDate.IraniDate.IraniDate();
        Persistent.DataAccess.DataAccess pers = new Persistent.DataAccess.DataAccess();
        Random rand = new Random();
        BLL.CLS_Client BllClient = new BLL.CLS_Client();

        BLL.CLS_DeviceLine BllDeviceLine = new BLL.CLS_DeviceLine();
        DateTime CurDate = DateTime.Now;
        string startdate, enddate;
        PersianCulture persianCulture = new PersianCulture();
        BLL.Cls_ProductLines Bll_ProductLines = new BLL.Cls_ProductLines();
        public UCShowCurrentState()
        {

            InitializeComponent();

        }

        private void UCShowCurrentState_Load(object sender, EventArgs e)
        {

            this.radScheduler1.Culture = persianCulture;


            enddate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            radDateTimePickerElementStart.Value = CurDate.AddDays(-7);
            radDateTimePickerElementEnd.Value = CurDate;

            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            startdate = CurDate.AddDays(-7).ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            enddate = CurrentDate;
            // FillData(startdate, CurrentDate, SelectedProductionLines);

            FillLstProductLines();
        }


        private void FillLstProductLines()
        {
            LSTProrudtionLines.DataSource = Bll_ProductLines.GetProductLinesWithSetForDeviceLine();
            LSTProrudtionLines.DisplayMember = "ProductLineDesc";
            LSTProrudtionLines.ValueMember = "id";



        }


        //private void FillData(string StartDate, string EndDate, string ListOfProductionLines)
        //{
        //    try
        //    {
        //        Array.Clear(LastApprochmentInfo, 0, LastApprochmentInfo.Length);
        //        this.Cursor = Cursors.WaitCursor;

        //        this.radScheduler1.Appointments.Clear();

        //        radScheduler1.Resources.Clear();

        //        var persianCulture = new PersianCulture();
        //        System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
        //        System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;
        //        SchedulerNavigatorLocalizationProvider.CurrentProvider = new CustomSchedulerNavigatorLocalizationProvider();

        //        Color[] colors = new Color[]
        //        {
        //        Color.LightBlue
        //        };


        //        if (LSTProrudtionLines.CheckedItems.Count > 1)
        //        {
        //            DataRow[] foundRows = BllDeviceLine.GetAllResource().Select("ActiveLineForShowGroup=true", "ProductLineDesc");




        //            for (int i = 0; i < foundRows.Length; i++)
        //            {
        //                Resource resource = new Resource();
        //                resource.Id = new EventId(foundRows[i]["id"].ToString());
        //                resource.Name = foundRows[i]["GroupShowName"].ToString();
        //                resource.Color = colors[0];
        //                this.radScheduler1.Resources.Add(resource);
        //                LastApprochmentInfo[i, 0] = foundRows[i]["id"].ToString();

        //            }
        //        }
        //        else
        //        {
        //            BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetDeviceLineByProductLineId(LSTProrudtionLines.CheckedItems[0].Value.ToString());

        //            for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
        //            {
        //                Resource resource = new Resource();
        //                resource.Id = new EventId(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString());
        //                resource.Name = BLL.Cls_PublicOperations.Dt.DefaultView[i]["LineDesc"].ToString();
        //                resource.Color = colors[0];

        //                this.radScheduler1.Resources.Add(resource);

        //                LastApprochmentInfo[i, 0] = BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString();

        //            }

        //        }



        //        BLL.Cls_PublicOperations.Dt = BllClient.GetAllClientData(StartDate, EndDate, ListOfProductionLines);

        //        DataRow[] ClientData;
        //        if (LSTProrudtionLines.CheckedItems.Count > 1)
        //        {
        //            ClientData = BLL.Cls_PublicOperations.Dt.Select("ActiveLineForShowGroup=true", "ProductLineDesc");
        //        }
        //        else
        //        {
        //            ClientData = BLL.Cls_PublicOperations.Dt.Select("");
        //        }

        //        int totalHours;

        //        for (int i = 0; i < ClientData.Length; i++)
        //        {
        //            this.radScheduler1.Backgrounds.Add(new AppointmentBackgroundInfo(this.radScheduler1.Backgrounds.Count + 1, "test", Color.FromArgb(Convert.ToInt32(ClientData[i]["color"].ToString()))));

        //            totalHours = 0;

        //            totalHours = Convert.ToInt32(ClientData[i]["duration"].ToString()); // (DateTime.Parse(dt.DefaultView[i]["MiladiFinishDateTime"].ToString()) - DateTime.Parse(dt.DefaultView[i]["MiladiStartDateTime"].ToString())).TotalSeconds;

        //            DateTime Start = new DateTime();
        //            DateTime end = new DateTime();
        //            Start = DateTime.Parse(ClientData[i]["MiladiStartDateTime"].ToString());
        //            end = DateTime.Parse(ClientData[i]["MiladiFinishDateTime"].ToString());




        //            Appointment app = new Appointment(Start.AddSeconds(1), end, (Math.Round((double)totalHours / 60)).ToString());

        //            app.StatusId = Convert.ToInt32(ClientData[i]["DeviceStateID"].ToString());



        //            app.ResourceId = this.radScheduler1.Resources.GetById(ClientData[i]["id"].ToString()).Id;

        //            app.BackgroundId = this.radScheduler1.Backgrounds[this.radScheduler1.Backgrounds.Count - 1].Id;

        //            if (ClientData[i]["color"].ToString() == "16777215")
        //            {
        //                app.Visible = false;
        //            }
        //            this.radScheduler1.Appointments.Add(app);

        //            var coordinates = LastApprochmentInfo.CoordinatesOf(ClientData[i]["id"].ToString());

        //            LastApprochmentInfo[coordinates.Item1, 1] = ClientData[i]["DeviceStateID"].ToString();


        //        }



        //        this.radScheduler1.GroupType = GroupType.Resource;

        //        this.radScheduler1.ActiveViewType = SchedulerViewType.Timeline;
        //        this.radScheduler1.GetTimelineView().GroupSeparatorWidth = 0;

        //        this.radScheduler1.GetTimelineView().ResourcesPerView = this.radScheduler1.Resources.Count;
        //        this.radScheduler1.GetTimelineView().ShowTimescale(Timescales.Minutes);
        //        RadSchedulerLocalizationProvider.CurrentProvider = new CustomSchedulerLocalizationProvider();


        //        if (IsFirstLoad == true)
        //        {
        //            IsFirstLoad = false;
        //        }
        //        TimelineGroupingByResourcesElement timelineElement = this.radScheduler1.SchedulerElement.ViewElement as TimelineGroupingByResourcesElement;

        //        SchedulerUIHelper.BringAppointmentIntoView(this.radScheduler1.Appointments[this.radScheduler1.Appointments.Count - 1], this.radScheduler1);
        //        timelineElement.ResourceHeaderWidth = 135;
        //        timelineElement.ResourcesHeader.TextOrientation = Orientation.Vertical;
        //        timelineElement.ResourcesHeader.Font = HeaderFont;
        //        this.Cursor = Cursors.Default;
        //    }
        //    catch (Exception E)
        //    {
        //        this.Cursor = Cursors.Default;
        //    }
        //}

        private void FillData(string StartDate, string EndDate, string ListOfProductionLines)
        {
            try
            {
                Array.Clear(LastApprochmentInfo, 0, LastApprochmentInfo.Length);
                this.Cursor = Cursors.WaitCursor;

                this.radScheduler1.Appointments.Clear();

                radScheduler1.Resources.Clear();

                var persianCulture = new PersianCulture();
                System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
                System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;
                SchedulerNavigatorLocalizationProvider.CurrentProvider = new CustomSchedulerNavigatorLocalizationProvider();

                Color[] colors = new Color[]
                {
                Color.LightBlue, Color.LightBlue, Color.LightBlue,
                Color.LightBlue, Color.LightBlue, Color.LightBlue, Color.LightBlue, Color.LightBlue, Color.LightBlue
                };


                if (LSTProrudtionLines.CheckedItems.Count > 1)
                {
                    BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetAllResource();

                    BLL.Cls_PublicOperations.Dt.DefaultView.RowFilter=  "ActiveLineForShowGroup =1";

                    for (int i = 0; i < BLL.Cls_PublicOperations.Dt.DefaultView.Count; i++)
                    {
                        Resource resource = new Resource();
                        resource.Id = new EventId(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString());
                        resource.Name = BLL.Cls_PublicOperations.Dt.DefaultView[i]["GroupShowName"].ToString() ;
                        resource.Color = colors[rand.Next(0, 8)];
                        this.radScheduler1.Resources.Add(resource);
                        LastApprochmentInfo[i, 0] = BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString();
                    }
                }
                else
                {
                    BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetDeviceLineByProductLineId(LSTProrudtionLines.CheckedItems[0].Value.ToString());

                    for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
                    {
                        Resource resource = new Resource();
                        resource.Id = new EventId(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString());
                        resource.Name = BLL.Cls_PublicOperations.Dt.DefaultView[i]["LineDesc"].ToString();
                        resource.Color = colors[0];

                        this.radScheduler1.Resources.Add(resource);

                        LastApprochmentInfo[i, 0] = BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString();

                    }


                }



                BLL.Cls_PublicOperations.Dt = BllClient.GetAllClientData(StartDate, EndDate, ListOfProductionLines);

                int totalHours;


                if (LSTProrudtionLines.CheckedItems.Count > 1)
                {
                    BLL.Cls_PublicOperations.Dt.DefaultView.RowFilter="ActiveLineForShowGroup=1";
                }



                    for (int i = 0; i < BLL.Cls_PublicOperations.Dt.DefaultView.Count ; i++)
                {
                    this.radScheduler1.Backgrounds.Add(new AppointmentBackgroundInfo(this.radScheduler1.Backgrounds.Count + 1, "test", Color.FromArgb(Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString()))));

                    totalHours = 0;

                    totalHours = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["duration"].ToString()); // (DateTime.Parse(dt.DefaultView[i]["MiladiFinishDateTime"].ToString()) - DateTime.Parse(dt.DefaultView[i]["MiladiStartDateTime"].ToString())).TotalSeconds;

                    DateTime Start = new DateTime();
                    DateTime end = new DateTime();
                    Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
                    end = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());




                    Appointment app = new Appointment(Start.AddSeconds(1), end, (Math.Round((double)totalHours / 60)).ToString());

                    app.StatusId = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString());



                    app.ResourceId = this.radScheduler1.Resources.GetById(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString()).Id;

                    app.BackgroundId = this.radScheduler1.Backgrounds[this.radScheduler1.Backgrounds.Count - 1].Id;

                    if (BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString() == "16777215")
                    {
                        app.Visible = false;
                    }
                    this.radScheduler1.Appointments.Add(app);

                    var coordinates = LastApprochmentInfo.CoordinatesOf(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString());

                    LastApprochmentInfo[coordinates.Item1, 1] = BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString();


                }



                this.radScheduler1.GroupType = GroupType.Resource;

                this.radScheduler1.ActiveViewType = SchedulerViewType.Timeline;
                this.radScheduler1.GetTimelineView().GroupSeparatorWidth = 0;

                this.radScheduler1.GetTimelineView().ResourcesPerView = this.radScheduler1.Resources.Count;
                this.radScheduler1.GetTimelineView().ShowTimescale(Timescales.Minutes);
                RadSchedulerLocalizationProvider.CurrentProvider = new CustomSchedulerLocalizationProvider();


                if (IsFirstLoad == true)
                {
                    IsFirstLoad = false;
                }
                TimelineGroupingByResourcesElement timelineElement = this.radScheduler1.SchedulerElement.ViewElement as TimelineGroupingByResourcesElement;

                SchedulerUIHelper.BringAppointmentIntoView(this.radScheduler1.Appointments[this.radScheduler1.Appointments.Count - 1], this.radScheduler1);
                timelineElement.ResourceHeaderWidth = 135;
                timelineElement.ResourcesHeader.TextOrientation = Orientation.Vertical;
                timelineElement.ResourcesHeader.Font = HeaderFont;
                this.Cursor = Cursors.Default;
            }
            catch (Exception E)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private int GetResourceIndex(SchedulerViewGroupedByResourceElementBase viewGroupedByResource)
        {
            IResource cellResource = radScheduler1.SelectionBehavior.CurrentCellElement.View.GetResource();
            int cellResourceIndex = radScheduler1.Resources.IndexOf(cellResource);

            int resourceId = cellResourceIndex - viewGroupedByResource.ResourceStartIndex;
            return resourceId;
        }


        private void radButtonElementWeek_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-7);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-7).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate, SelectedProductionLines);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-30);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-30).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate, SelectedProductionLines);
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
                    FillData(startdate, enddate, SelectedProductionLines);
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
                    FillData(startdate, enddate, SelectedProductionLines);
                    System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;

                }

            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printablePanel.PrintPreview();
        }


        private void radScheduler1_AppointmentFormatting(object sender, SchedulerAppointmentEventArgs e)
        {


            Font font = new Font("b nazanin", 9f, FontStyle.Bold);
            Font HeaderFont = new Font("b titr", 10f, FontStyle.Bold);

            e.AppointmentElement.ResetValue(VisualElement.FontProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(LightVisualElement.TextAlignmentProperty, ValueResetFlags.Local);
            e.AppointmentElement.UseDefaultPaint = true;
            e.AppointmentElement.ResetValue(LightVisualElement.BorderColorProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(LightVisualElement.BorderWidthProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(LightVisualElement.BorderBoxStyleProperty, ValueResetFlags.Local);
            // e.AppointmentElement.ResetValue(VisualElement.BackColorProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(VisualElement.BackgroundShapeProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(VisualElement.BorderThicknessProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(VisualElement.ForeColorProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(VisualElement.ShapeProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(VisualElement.ShouldPaintProperty, ValueResetFlags.Local);
            e.AppointmentElement.ResetValue(VisualElement.StyleProperty, ValueResetFlags.Local);
            e.AppointmentElement.Font = font;
            e.AppointmentElement.ForeColor = Color.Black;
            e.AppointmentElement.TextAlignment = ContentAlignment.MiddleCenter;
            e.AppointmentElement.TextOrientation = Orientation.Horizontal;
            e.AppointmentElement.TitleFormat = "{2}";

            RadOffice2007ScreenTipElement screenTip = new RadOffice2007ScreenTipElement();
            screenTip.CaptionLabel.Text = "مدت زمان";
            screenTip.CaptionLabel.Font = HeaderFont;
            screenTip.CaptionLabel.TextOrientation = Orientation.Horizontal;
            screenTip.CaptionLabel.Alignment = ContentAlignment.MiddleRight;
            screenTip.Alignment = ContentAlignment.MiddleCenter;
            screenTip.CaptionLabel.Alignment = ContentAlignment.TopRight;
            screenTip.CaptionLabel.TextAlignment = ContentAlignment.TopRight;
            screenTip.CaptionLabel.TextOrientation = Orientation.Horizontal;

            screenTip.CaptionLabel.ForeColor = Color.Blue;
            screenTip.MainTextLabel.Text = e.AppointmentElement.Start.TimeOfDay + "  --   " + e.AppointmentElement.End.TimeOfDay;
            screenTip.MainTextLabel.Font = font;
            e.AppointmentElement.ScreenTip = screenTip;


            e.AppointmentElement.ShowAppointmentDescription = true;

        }

        //private void FillLastData()
        //{
        //    BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetLastStateOfDeviceLineData();
        //    for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
        //    {
        //        try
        //        {

        //            var coordinates = LastApprochmentInfo.CoordinatesOf(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString());


        //            var z = radScheduler1.Appointments.FindIndex(n => n.StatusId == Convert.ToInt32(LastApprochmentInfo[coordinates.Item1, 1].ToString()));
        //            radScheduler1.Appointments[z].Summary = (Math.Round((double)Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["Duration"].ToString()) / 60)).ToString();

        //            radScheduler1.Appointments[z].Start = (DateTime)BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"];
        //            radScheduler1.Appointments[z].End = (DateTime)BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"];
        //        }
        //        catch
        //        {

        //        }

        //    }


        //}


        private void FillLastData()
        {
            BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetLastStateOfDeviceLineData();
            for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            {
                try
                {


                    var coordinates = LastApprochmentInfo.CoordinatesOf(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString());

                    if (coordinates.Item1 == -1) //New Event In Device Line Id 
                    {
                        LastApprochmentInfo[ExtensionMethods.NewIndex, 0] = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ID"].ToString();
                        LastApprochmentInfo[ExtensionMethods.NewIndex, 1] = BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString();

                        int totalHours;


                        this.radScheduler1.Backgrounds.Add(new AppointmentBackgroundInfo(this.radScheduler1.Backgrounds.Count + 1, "test", Color.FromArgb(Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString()))));

                        totalHours = 0;

                        totalHours = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["duration"].ToString()); // (DateTime.Parse(dt.DefaultView[i]["MiladiFinishDateTime"].ToString()) - DateTime.Parse(dt.DefaultView[i]["MiladiStartDateTime"].ToString())).TotalSeconds;

                        DateTime Start = new DateTime();
                        DateTime end = new DateTime();
                        Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
                        end = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());




                        Appointment app = new Appointment(Start.AddSeconds(1), end, (Math.Round((double)totalHours / 60)).ToString());

                        app.StatusId = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString());



                        app.ResourceId = this.radScheduler1.Resources.GetById(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString()).Id;

                        app.BackgroundId = this.radScheduler1.Backgrounds[this.radScheduler1.Backgrounds.Count - 1].Id;

                        if (BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString() == "16777215")
                        {
                            app.Visible = false;
                        }
                        this.radScheduler1.Appointments.Add(app);



                    }
                    else
                    {
                        var z = radScheduler1.Appointments.FindIndex(n => n.StatusId == Convert.ToInt32(LastApprochmentInfo[coordinates.Item1, 1].ToString()));
                        try
                        {
                            radScheduler1.Appointments[z].Summary = (Math.Round((double)Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["Duration"].ToString()) / 60)).ToString();


                            radScheduler1.Appointments[z].Start = (DateTime)BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"];
                            radScheduler1.Appointments[z].End = (DateTime)BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"];
                        }
                        catch
                        {
                            //  radScheduler1.Appointments[z].Summary = "0";

                        }
                    }
                }
                catch (Exception E)
                {
                    //  MessageBox.Show(E.ToString());
                }

            }


        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (radScheduler1.Appointments.Count > 0)
            {
                FillLastData();
            }

        }

        private void radDateTimePickerElementEnd_Click(object sender, EventArgs e)
        {
            IsFirstLoad = false;
        }

        private void radDateTimePickerElementStart_Click(object sender, EventArgs e)
        {
            IsFirstLoad = false;
        }

        private void LSTProrudtionLines_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            SelectedProductionLines = "0";

            foreach (var CheckedItem in LSTProrudtionLines.CheckedItems)
            {
                SelectedProductionLines = SelectedProductionLines + "," + CheckedItem.Value.ToString() + "";

            }
            SelectedProductionLines = "'" + SelectedProductionLines + "'";
            FillData(startdate, enddate, SelectedProductionLines);
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
                    FillData(startdate, enddate, SelectedProductionLines);

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
                    FillData(startdate, enddate, SelectedProductionLines);

                    System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;

                }
            }


        }
    }






    public class PrintablePanel : RadPanel, IPrintable
    {
        public int BeginPrint(RadPrintDocument sender, PrintEventArgs args)
        {
            return 1;
        }

        public bool EndPrint(RadPrintDocument sender, PrintEventArgs args)
        {
            return true;
        }

        public Form GetSettingsDialog(RadPrintDocument document)
        {
            return new PrintSettingsDialog(document);
        }

        public bool PrintPage(int pageNumber, RadPrintDocument sender, PrintPageEventArgs args)
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(Point.Empty, this.Size));
            args.Graphics.DrawImage(bmp, Point.Empty);

            return false;
        }

        public void Print()
        {
            RadPrintDocument doc = this.CreatePrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.Print();
        }

        public void PrintPreview()
        {
            RadPrintDocument doc = this.CreatePrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            RadPrintPreviewDialog dialog = new RadPrintPreviewDialog(doc);

            dialog.ThemeName = this.ThemeName;
            dialog.ShowDialog();
        }

        private RadPrintDocument CreatePrintDocument()
        {
            RadPrintDocument doc = new RadPrintDocument();
            doc.AssociatedObject = this;
            return doc;
        }
    }
}


public static class ExtensionMethods
{
    public static int NewIndex;
    public static Tuple<int, int> CoordinatesOf<T>(this T[,] matrix, T value)
    {


        try
        {
            int w = matrix.GetLength(0); // width
            int h = matrix.GetLength(1); // height

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    NewIndex = x;
                    if (matrix[x, y].Equals(value))
                        return Tuple.Create(x, y);
                }
            }

            return Tuple.Create(-1, -1);
        }
        catch
        {
            NewIndex = NewIndex;
            return Tuple.Create(-1, -1);

        }

    }
}


//  public static Tuple<int, int > CoordinatesOf<T>(this T[,] matrix, T value)
//  {


//      try
//      {
//          int w = matrix.GetLength(0); // width
//      int h = matrix.GetLength(1); // height

//      for (int x = 0; x < w; ++x)
//      {
//          for (int y = 0; y < h; ++y)
//          {
//              NewIndex = x;
//                  // if(matrix[x, y] != null  )
//                  //{
//if (matrix[x, y].Equals(value))
//                          return Tuple.Create(x, y);
//                 // }




//          }
//      }

//      return Tuple.Create(-1, -1);
//      }
//      catch
//      {
//          NewIndex = NewIndex;
//          return Tuple.Create(-1, -1);

//      }

//  }
// }


//public static class ExtensionMethods
//{
//    public static Tuple<int, int> CoordinatesOf<T>(this T[,] matrix, T value)
//    {
//        //try
//        //{
//        int w = matrix.GetLength(0); // width
//        int h = matrix.GetLength(1); // height
//        int NewIndex = -1;
//        for (int x = 0; x < w; ++x)
//        {
//            for (int y = 0; y < h; ++y)
//            {
//                if (matrix[x, y].Equals(value))
//                    NewIndex = x;
//                    return Tuple.Create(x, y);

//            }
//        }

//      return Tuple.Create(-1, -1);
//        //  }
//        //catch
//        //{
//        // return Tuple.Create(-1, -1);

//        // }

//    }
//}