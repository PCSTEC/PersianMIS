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
        public     Boolean IsFirstLoad = true ;
        IraniDate.IraniDate.IraniDate IrDate = new IraniDate.IraniDate.IraniDate();
        Persistent.DataAccess.DataAccess pers = new Persistent.DataAccess.DataAccess();
        Random rand = new Random();
        BLL.Cls_Station BllStation = new BLL.Cls_Station();
        BLL.CLS_DeviceLine BllDeviceLine = new BLL.CLS_DeviceLine();
        DateTime CurDate = DateTime.Now ;
        string startdate, enddate;
        PersianCulture persianCulture = new PersianCulture();

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
             FillData(CurDate.AddDays(-7).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate);

            //this.radScheduler1.GetTimelineView().RangeStartDate = new DateTime(DateTime.Now.Year, 1, 1);
            //this.radScheduler1.GetTimelineView().RangeEndDate = new DateTime(DateTime.Now.Year, 12, 1);
       //  Program.ChangeCulture();
        }

        //private void FillData(string StartDate, string EndDate)
        //{
        //    this.radScheduler1.Appointments.Clear();

        //    radScheduler1.Resources.Clear();

        //    var persianCulture = new PersianCulture();
        //    System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
        //    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;
        //    SchedulerNavigatorLocalizationProvider.CurrentProvider = new CustomSchedulerNavigatorLocalizationProvider();

        //    Color[] colors = new Color[]
        //    {
        //        Color.LightBlue, Color.LightGreen, Color.LightYellow,
        //        Color.Red, Color.Orange, Color.Pink, Color.Purple, Color.Peru, Color.PowderBlue
        //    };


        //    BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetAllResource();

        //    for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
        //    {
        //        Resource resource = new Resource();
        //        resource.Id = new EventId(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString());
        //        resource.Name = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ProductLineDesc"].ToString();
        //        resource.Color = colors[rand.Next(0, 8)];

        //        this.radScheduler1.Resources.Add(resource);
        //    }



        //    BLL.Cls_PublicOperations.Dt = BllStation.GetAllStationData(StartDate, EndDate);
        //    double totalHours;

        //    for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
        //    {
        //        this.radScheduler1.Backgrounds.Add(new AppointmentBackgroundInfo(this.radScheduler1.Backgrounds.Count + 1, "test", Color.FromArgb(Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString()))));

        //        totalHours = 0;

        //        totalHours = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["duration"].ToString()); // (DateTime.Parse(dt.DefaultView[i]["MiladiFinishDateTime"].ToString()) - DateTime.Parse(dt.DefaultView[i]["MiladiStartDateTime"].ToString())).TotalSeconds;

        //        DateTime Start = new DateTime();
        //        if (i > 0)
        //        {
        //            if ((DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString()) - DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i - 1]["MiladiFinishDateTime"].ToString())).TotalSeconds <= Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["Gaptime"].ToString()))
        //            {
        //                Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i - 1]["MiladiFinishDateTime"].ToString());

        //            }
        //            else
        //            {
        //                Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());

        //            }
        //        }
        //        else
        //        {
        //            Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
        //        }


        //        Appointment app = new Appointment(Start, TimeSpan.FromSeconds(totalHours), "");


        //        app.ResourceId = this.radScheduler1.Resources.GetById(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString()).Id;
        //        app.BackgroundId = this.radScheduler1.Backgrounds[this.radScheduler1.Backgrounds.Count - 1].Id;

        //        this.radScheduler1.Appointments.Add(app);
        //    }


        //    this.radScheduler1.ActiveView.ResourcesPerView = 50;
        //    this.radScheduler1.GroupType = GroupType.Resource;

        //    this.radScheduler1.ActiveViewType = SchedulerViewType.Timeline;
        //    this.radScheduler1.GetTimelineView().GroupSeparatorWidth = 0;
        //    this.radScheduler1.GetTimelineView().ResourcesPerView = 4;
        //    this.radScheduler1.GetTimelineView().ShowTimescale(Timescales.Hours);
        //    RadSchedulerLocalizationProvider.CurrentProvider = new CustomSchedulerLocalizationProvider();


        //}


        private void FillData(string StartDate, string EndDate)
        {
            this.radScheduler1.Appointments.Clear();

            radScheduler1.Resources.Clear();

            var persianCulture = new PersianCulture();
            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;
            SchedulerNavigatorLocalizationProvider.CurrentProvider = new CustomSchedulerNavigatorLocalizationProvider();

            Color[] colors = new Color[]
            {
                Color.LightBlue, Color.LightGreen, Color.LightYellow,
                Color.Red, Color.Orange, Color.Pink, Color.Purple, Color.Peru, Color.PowderBlue
            };


            BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetAllResource();

            for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
            {
                Resource resource = new Resource();
                resource.Id = new EventId(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString());
                resource.Name = BLL.Cls_PublicOperations.Dt.DefaultView[i]["ProductLineDesc"].ToString();
                resource.Color = colors[rand.Next(0, 8)];

                this.radScheduler1.Resources.Add(resource);
            }



            BLL.Cls_PublicOperations.Dt = BllStation.GetAllStationData(StartDate, EndDate );
            int  totalHours;

            for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
            {
                this.radScheduler1.Backgrounds.Add(new AppointmentBackgroundInfo(this.radScheduler1.Backgrounds.Count + 1, "test", Color.FromArgb(Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString()))));

                totalHours = 0;

                totalHours = Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["duration"].ToString()); // (DateTime.Parse(dt.DefaultView[i]["MiladiFinishDateTime"].ToString()) - DateTime.Parse(dt.DefaultView[i]["MiladiStartDateTime"].ToString())).TotalSeconds;

                DateTime Start = new DateTime();
                     Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());




              
                Appointment app = new Appointment(Start, TimeSpan.FromSeconds(totalHours), (Math.Round((double)totalHours / 60)).ToString());
               
                app.StatusId  =Convert.ToInt32( BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString());

               

                //try
                //{

                //    if (this.radScheduler1.Appointments.Count > 2 && (this.radScheduler1.Appointments[this.radScheduler1.Appointments.Count - 2].End - app.Start).TotalSeconds == 0) //&& (this.radScheduler1.Appointments[this.radScheduler1.Appointments.Count - 2].End - app.End).TotalSeconds<5)
                //    {
                //        //  app.Start  = this.radScheduler1.Appointments[this.radScheduler1.Appointments.Count - 2].End  ;
                //        app.Start = app.Start.AddSeconds(61);

                //      //  app.End = app.End.AddSeconds(-61);
                         
                //        //app.End = app.End.AddSeconds(((this.radScheduler1.Appointments[this.radScheduler1.Appointments.Count - 1].End - app.Start).TotalSeconds) - 60);
                //    }
                //}
                //catch { }

                app.ResourceId = this.radScheduler1.Resources.GetById(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString()).Id;
                app.BackgroundId = this.radScheduler1.Backgrounds[this.radScheduler1.Backgrounds.Count - 1].Id;
                
                this.radScheduler1.Appointments.Add(app);

               


            }


            this.radScheduler1.ActiveView.ResourcesPerView = 100;
            this.radScheduler1.GroupType = GroupType.Resource;

            this.radScheduler1.ActiveViewType = SchedulerViewType.Timeline;
            this.radScheduler1.GetTimelineView().GroupSeparatorWidth = 0;
            this.radScheduler1.GetTimelineView().ResourcesPerView = 4;
            this.radScheduler1.GetTimelineView().ShowTimescale(Timescales.Minutes);
            RadSchedulerLocalizationProvider.CurrentProvider = new CustomSchedulerLocalizationProvider();
            this.radScheduler1.AllowAppointmentResize = true;
            this.radScheduler1.AutoSizeAppointments = true;
            this.radScheduler1.EnableExactTimeRendering = true;

            if (IsFirstLoad==true )
            {
                IsFirstLoad = false;
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
            FillData(CurDate.AddDays(-7).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-30);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-30).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Year_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-365);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-365).ToString("yyyy/MM/dd", new CultureInfo("en-US")), CurrentDate);
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
                        startdate = IrDate.GetDateIntToStr_GivenDate(IrDate.GetLatin_FromIraniDate(IrDate.ConvDateStrToInt_GivenDate(radDateTimePickerElementStart.Value.Value.ToShortDateString())).ToString());
                    }
                    FillData(startdate, enddate);
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
                    FillData(startdate, enddate);
                    System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;

                }

            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printablePanel.PrintPreview();
        }

        private void radScheduler1_CellFormatting(object sender, SchedulerCellEventArgs e)
        {
            e.CellElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
            e.CellElement.BorderColor = Color.Yellow;
            
        }

        private void radScheduler1_AppointmentFormatting(object sender, SchedulerAppointmentEventArgs e)
        {
      

            Font font = new Font("b nazanin", 10f, FontStyle.Bold);
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
            e.AppointmentElement.TitleFormat = "{2}'";

            RadOffice2007ScreenTipElement screenTip = new RadOffice2007ScreenTipElement();
            screenTip.CaptionLabel.Text = "مدت زمان فعاليت";
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



            // }
            // e.AppointmentElement.BorderInnerColor = Color.Green;
            // // e.Appointment.Visible = false ;
            // e.AppointmentElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
            // e.AppointmentElement.EnableFocusBorderAnimation = false;
            // e.AppointmentElement.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid;
            // e.AppointmentElement.EnableElementShadow = false;
            //e.AppointmentElement.ShadowColor = Color.Blue;
            // e.AppointmentElement.ShadowDepth = 0;
            // e.AppointmentElement.Alignment = ContentAlignment.MiddleRight;
            // e.AppointmentElement.DrawFill = true ;
            // e.AppointmentElement.BorderBottomShadowColor = Color.Blue;
            //if (e.Appointment.DataItem == null && e.Appointment.MasterEvent == null) return;

            //var appointment = (Transaction)e.Appointment.DataItem ??
            //           (e.Appointment.MasterEvent.DataItem != null
            //                ? (Transaction)e.Appointment.MasterEvent.DataItem
            //                : null);

            //if (appointment != null)
            //{
            //    string description = string.Format("{0}{1}{2}{1}{3}", appointment.starttime, Environment.NewLine,
            //                                       appointment.EndTime );

            e.AppointmentElement.ShowAppointmentDescription = true;
            //e.AppointmentElement.AppointmentLocation = appointment.Duration;
            //e.AppointmentElement.AppointmentSubject = description;
            //e.AppointmentElement.ToolTipText = description;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var t= this.radScheduler1.Appointments.Last();
            //BLL.Cls_PublicOperations.Dt = BllDeviceLine.GetAllResource();
            //for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            //{

            //    this.radScheduler1.Appointments.Select(a => a.ResourceId = new EventId(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString()));
            //    //if(radScheduler1.Resources.GetById(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString()))
            //}
        }

        private void radDateTimePickerElementStart_ValueChanged(object sender, ValueChangingEventArgs e)
        {
            if (IsFirstLoad == false )
            {
                  try
            {
                DateTime x = (DateTime)e.NewValue;
                startdate = x.Year + "/" + x.Month + "/" + x.Day;
                if (enddate == null)
                {
                    enddate = IrDate.GetDateIntToStr_GivenDate(IrDate.GetLatin_FromIraniDate(IrDate.ConvDateStrToInt_GivenDate(radDateTimePickerElementEnd.Value.Value.ToShortDateString())).ToString());
                }
                FillData(startdate, enddate);

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
                FillData(startdate, enddate);

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
