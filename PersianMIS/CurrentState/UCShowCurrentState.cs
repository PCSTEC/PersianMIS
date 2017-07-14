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

namespace PersianMIS.CurrentState
{

    public partial class UCShowCurrentState : UserControl
    {
     
        IraniDate.IraniDate.IraniDate IrDate = new IraniDate.IraniDate.IraniDate();
        Persistent.DataAccess.DataAccess pers = new Persistent.DataAccess.DataAccess();
        Random rand = new Random();
        BLL.Cls_Station BllStation = new BLL.Cls_Station();
        BLL.CLS_DeviceLine BllDeviceLine = new BLL.CLS_DeviceLine();
        DateTime CurDate = DateTime.Now;
        string startdate, enddate;
        public UCShowCurrentState()
        {
            
            InitializeComponent();


        }

        private void UCShowCurrentState_Load(object sender, EventArgs e)
        {

            var persianCulture = new PersianCulture();
            this.radScheduler1.Culture = persianCulture;


            enddate = CurDate.ToString("yyyy/MM/dd H:mm:ss ", new CultureInfo("en-US"));
            radDateTimePickerElementStart.Value = CurDate.AddDays(-7);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd H:mm:ss ", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-7).ToString("yyyy/MM/dd H:mm:ss", new CultureInfo("en-US")), CurrentDate);

        }

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

 
             
            BLL.Cls_PublicOperations.Dt = BllStation.GetAllStationData(StartDate, EndDate);
            double totalHours;

            for (int i = 0; i < BLL.Cls_PublicOperations.Dt.Rows.Count; i++)
            {
                this.radScheduler1.Backgrounds.Add(new AppointmentBackgroundInfo(this.radScheduler1.Backgrounds.Count + 1, "test", Color.FromArgb(Convert.ToInt32(BLL.Cls_PublicOperations.Dt.DefaultView[i]["color"].ToString()))));

                totalHours = 0;

                totalHours = Convert.ToDouble(BLL.Cls_PublicOperations.Dt.DefaultView[i]["duration"].ToString()); // (DateTime.Parse(dt.DefaultView[i]["MiladiFinishDateTime"].ToString()) - DateTime.Parse(dt.DefaultView[i]["MiladiStartDateTime"].ToString())).TotalSeconds;

                DateTime Start = new DateTime();
                if (i > 0)
                {
                    if ((DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString()) - DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i - 1]["MiladiFinishDateTime"].ToString())).TotalSeconds <= Convert.ToDouble(BLL.Cls_PublicOperations.Dt.DefaultView[i]["Gaptime"].ToString()))
                    {
                        Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i - 1]["MiladiFinishDateTime"].ToString());

                    }
                    else
                    {
                        Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());

                    }
                }
                else
                {
                    Start = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
                }


                Appointment app = new Appointment(Start, TimeSpan.FromSeconds(totalHours), "");


                app.ResourceId = this.radScheduler1.Resources.GetById(BLL.Cls_PublicOperations.Dt.DefaultView[i]["id"].ToString()).Id;
                app.BackgroundId = this.radScheduler1.Backgrounds[this.radScheduler1.Backgrounds.Count - 1].Id;

                this.radScheduler1.Appointments.Add(app);
            }

 
            this.radScheduler1.ActiveView.ResourcesPerView = 50;
            this.radScheduler1.GroupType = GroupType.Resource;

            this.radScheduler1.ActiveViewType = SchedulerViewType.Timeline;
            this.radScheduler1.GetTimelineView().GroupSeparatorWidth = 0;
            this.radScheduler1.GetTimelineView().ResourcesPerView = 4;
            this.radScheduler1.GetTimelineView().ShowTimescale(Timescales.Hours);
            RadSchedulerLocalizationProvider.CurrentProvider = new CustomSchedulerLocalizationProvider();
         

        }

        private void radScheduler1_CellFormatting(object sender, Telerik.WinControls.UI.SchedulerCellEventArgs e)
        {
            e.CellElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
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
            String CurrentDate = CurDate.ToString("yyyy/MM/dd H:mm:ss ", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-7).ToString("yyyy/MM/dd H:mm:ss", new CultureInfo("en-US")), CurrentDate);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Month_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-30);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd H:mm:ss ", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-30).ToString("yyyy/MM/dd H:mm:ss", new CultureInfo("en-US")), CurrentDate);
            this.Cursor = Cursors.Default;
        }

        private void Btn_Year_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            radDateTimePickerElementStart.Value = CurDate.AddDays(-365);
            radDateTimePickerElementEnd.Value = CurDate;
            String CurrentDate = CurDate.ToString("yyyy/MM/dd H:mm:ss ", new CultureInfo("en-US"));
            FillData(CurDate.AddDays(-365).ToString("yyyy/MM/dd H:mm:ss", new CultureInfo("en-US")), CurrentDate);
            this.Cursor = Cursors.Default;
        }
 
        private void radDateTimePickerElementEnd_ValueChanged(object sender, ValueChangingEventArgs e)
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
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printablePanel.PrintPreview();
        }

        private void radDateTimePickerElementStart_ValueChanged(object sender, ValueChangingEventArgs e)
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
