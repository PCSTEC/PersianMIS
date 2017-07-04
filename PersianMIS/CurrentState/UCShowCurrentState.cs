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

namespace PersianMIS.CurrentState
{
    public partial class UCShowCurrentState : UserControl
    {
        BLL.CLS_DeviceLine BllStation = new BLL.CLS_DeviceLine();

        public UCShowCurrentState()
        {
            PrintablePanel panel;
            InitializeComponent();
             
            //panel = new PrintablePanel();
            //panel.Dock = DockStyle.Fill;
            //this.Controls.Add(panel);
            var persianCulture = new PersianCulture();
            System.Threading.Thread.CurrentThread.CurrentCulture = persianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = persianCulture;
            SchedulerNavigatorLocalizationProvider.CurrentProvider = new CustomSchedulerNavigatorLocalizationProvider();
            //radScheduler1 = new RadScheduler();
            //radScheduler1.Dock = DockStyle.Fill;
            //panel.Controls.Add(radScheduler1);
            Color[] colors = new Color[]
            {
                Color.LightBlue, Color.LightGreen, Color.LightYellow,
                Color.Red, Color.Orange, Color.Pink, Color.Purple, Color.Peru, Color.PowderBlue
            };

            string[] names = new string[]
            {
                "Alan Smith", "Anne Dodsworth",
                "Boyan Mastoni", "Richard Duncan", "Maria Shnaider"
            };

            for (int i = 0; i < names.Length; i++)
            {
                Resource resource = new Resource();
                resource.Id = new EventId(i);
                resource.Name = names[i];
                resource.Color = colors[i];

                this.radScheduler1.Resources.Add(resource);
            }

            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Appointment app = new Appointment(DateTime.Now.AddHours(i), TimeSpan.FromMinutes(45), "App" + i);
                app.ResourceId = this.radScheduler1.Resources[rand.Next(0, radScheduler1.Resources.Count)].Id;
                app.BackgroundId = this.radScheduler1.Backgrounds[rand.Next(0, radScheduler1.Backgrounds.Count)].Id;

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

        private void UCShowCurrentState_Load(object sender, EventArgs e)
        {

            var persianCulture = new PersianCulture();
            this.radScheduler1.Culture = persianCulture;
            // this.PnlPrintable.PrintPreview();
            FillData();
        }

        private void FillData()
        {

            DataTable Dt = BllStation.GetAllStationData();

            //this.radGanttView1.GanttViewElement.DataSource = Dt;
            //this.radGanttView1.DataSource = Dt;
            //this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineStart = Convert.ToDateTime(Dt.DefaultView[0]["MiladiStartDateTime"]);
            //this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineEnd = Convert.ToDateTime(Dt.DefaultView[Dt.Rows.Count - 1]["MiladiFinishDateTime"]);
            this.radDateTimePickerElementStart.Value = Convert.ToDateTime(Dt.DefaultView[0]["MiladiStartDateTime"]);
            this.radDateTimePickerElementEnd.Value = Convert.ToDateTime(Dt.DefaultView[Dt.Rows.Count - 1]["MiladiFinishDateTime"]);
            this.radScheduler1.GetTimelineView().StartDate = Convert.ToDateTime(Dt.DefaultView[0]["MiladiStartDateTime"]);
         

        }

        private void radScheduler1_CellFormatting(object sender, Telerik.WinControls.UI.SchedulerCellEventArgs e)
        {
            e.CellElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder;
        }

        private void radTrackBarElementZoom_ValueChanged(object sender, EventArgs e)
        {
            if (radScheduler1.SelectionBehavior.CurrentCellElement != null)
            {
                SchedulerViewGroupedByResourceElementBase viewGroupedByResource = radScheduler1.ViewElement as SchedulerViewGroupedByResourceElementBase;
                int resourceId = GetResourceIndex(viewGroupedByResource);

                if (resourceId >= 0  )
                {
                    viewGroupedByResource.SetResourceSize(resourceId, this.radTrackBarElementZoom.Value);
                }
            }
        }
        private int GetResourceIndex(SchedulerViewGroupedByResourceElementBase viewGroupedByResource)
        {
            IResource cellResource = radScheduler1.SelectionBehavior.CurrentCellElement.View.GetResource();
            int cellResourceIndex = radScheduler1.Resources.IndexOf(cellResource);

            int resourceId = cellResourceIndex - viewGroupedByResource.ResourceStartIndex;
            return resourceId;
        }

        private void radButtonElementPrevious_Click(object sender, EventArgs e)
        {
             
       //     SchedulerDayViewElement dayViewElement = (this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewElement);
       ////     TimeSpan time = new TimeSpan(this.radDateTimePicker1.Value.Hour - 1, this.radDateTimePicker1.Value.Minute, 0);
       //     dayViewElement.DataAreaElement.Table.ScrollToTime( );


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
