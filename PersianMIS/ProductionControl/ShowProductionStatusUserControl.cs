﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace PersianMIS.ProductionControl
{
    public partial class ShowProductionStatusUserControl : UserControl
    {
        private GanttViewDataItem contextMenuItem;
        private Random rnd = new Random();

        public ShowProductionStatusUserControl()
        {
            InitializeComponent();
        }

        private void ShowProductionStatusUserControl_Load(object sender, EventArgs e)
        {
            this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Day;

            this.InitializeScheduler();

            this.radGanttView1.DataProvider = new GanttViewIntegrationProvider(this.radScheduler1);

            this.InitializeGanttView();

            this.radGanttView1.GraphicalViewItemFormatting += radGanttView1_GraphicalViewItemFormatting;
            this.radGanttView1.ItemChildIdNeeded += radGanttView1_ItemChildIdNeeded;
            this.radGanttView1.ScreenTipNeeded += radGanttView1_ScreenTipNeeded;
            this.radGanttView1.TextViewItemFormatting += radGanttView1_TextViewItemFormatting;
            this.radGanttView1.ContextMenuOpening += radGanttView1_ContextMenuOpening;
            this.radGanttView1.GanttViewElement.ItemEdited += GanttViewElement_ItemEdited;
            this.radGanttView1.GanttViewElement.Update(RadGanttViewElement.UpdateActions.Reset);
          

         
            //this.radTrackBarZoom.LargeTickFrequency = 200;
            //this.radTrackBarZoom.SmallTickFrequency = 20;
            //this.radTrackBarZoom.Minimum = 0;
            //this.radTrackBarZoom.Maximum = 1100;
            //this.radTrackBarZoom.Value = 100;





            this.radGanttView1.GanttViewElement.GraphicalViewElement.AutomaticTimelineTimeRange = true ;
              this.radGanttView1.GanttViewElement.GraphicalViewElement.TimelineRange = TimeRange.Day;

        }




        private void InitializeScheduler()
        {
            DateTime baseDate = DateTime.Today;
            string[,] summaries = new string[,]
            {
                { "Mr. Brown", "Mr. White", "Mrs. Green" },
                { "Mr. Pink", "Mr. Green", "Mrs. Yellow" },
                { "Mr. Cyan", "Mr. Purple", "Mrs. Blue" },
                { "Mr. Magenta", "Mr. Violet", "Mrs. Silver" },
                { "Mr. Black", "Mr. Azure", "Mrs. Maroon" }
            };
            string[] descriptions = new string[] { "", "", "" };
            string[] locations = new string[] { "City", "Out of town", "Service Center" };
            AppointmentBackground[] backgrounds = new AppointmentBackground[] { AppointmentBackground.Business, AppointmentBackground.MustAttend, AppointmentBackground.Personal };
            string[] names = new string[] { "Alan Smith", "Anne Dodsworth", "Boyan Mastoni", "Richard Duncan", "Maria Shnaider" };
            Color[] colors = new Color[] { Color.LightBlue, Color.LightGreen, Color.LightYellow, Color.Red, Color.Orange };

            for (int i = 0; i < names.Length; i++)
            {
                Resource resource = new Resource();
                resource.Id = new EventId(i);
                resource.Name = names[i];
                resource.Color = colors[i];
                resource.Image = this.imageList1.Images[i];

                this.radScheduler1.Resources.Add(resource);
            }

       //     this.radScheduler1.GetDayView().ResourcesPerView = 3;
            this.radScheduler1.GroupType = GroupType.Resource;
            SchedulerDayViewGroupedByResourceElement headerElement = this.radScheduler1.SchedulerElement.ViewElement as SchedulerDayViewGroupedByResourceElement;
            headerElement.ResourceHeaderHeight = 135;

            for (int i = 0; i < summaries.GetLength(0); i++)
            {
                for (int j = 0; j < summaries.GetLength(1); j++)
                {
                    DateTime start = baseDate.AddDays(1).AddHours(this.rnd.Next(1, 7));
                    Appointment appointment = new Appointment(start, start.AddHours(this.rnd.Next(12,15)), summaries[i, j], descriptions[j], locations[j]);
                    appointment.ResourceId = this.radScheduler1.Resources[i].Id;
                    appointment.BackgroundId = (int)backgrounds[(i + j) % backgrounds.Length];
                    this.radScheduler1.Appointments.Add(appointment);
                }
            }

            this.radScheduler1.SchedulerElement.SetResourceHeaderAngleTransform(SchedulerViewType.Day , 0);
        

        }

        private void InitializeGanttView()
        {
       
            //foreach (GanttViewTextViewColumn col in this.radGanttView1.Columns)
            //{
            //    col.Width = 5000;
            //}

        //    this.radGanttView1.Ratio = 0.3102f;
        }

        private void GanttViewElement_ItemEdited(object sender, GanttViewItemEditedEventArgs e)
        {
            if (e.Item.Start == e.Item.End)
            {
                e.Item.End = e.Item.Start.AddHours(1);
            }
        }

        private void radGanttView1_ContextMenuOpening(object sender, GanttViewContextMenuOpeningEventArgs e)
        {
            this.contextMenuItem = e.Item;

            GanttViewDefaultContextMenu menu = e.Menu as GanttViewDefaultContextMenu;
            menu.ShowProgress = false;
            menu.AddChildMenuItem.Visibility = ElementVisibility.Visible ;
        }

        private void radGanttView1_TextViewItemFormatting(object sender, GanttViewTextViewItemFormattingEventArgs e)
        {
            Appointment app = e.Item.DataBoundItem as Appointment;
            IResource resource = this.radScheduler1.Resources.GetById(app.ResourceId);
            e.ItemElement.BackColor = resource.Color;
            e.ItemElement.DrawFill = true;
        }

        private void radGanttView1_ScreenTipNeeded(object sender, ScreenTipNeededEventArgs e)
        {
            GanttViewTaskElement taskElement = e.Item as GanttViewTaskElement;

            if (taskElement != null)
            {
                RadOffice2007ScreenTipElement screenTip = new RadOffice2007ScreenTipElement();
                Appointment app = ((GanttGraphicalViewBaseItemElement)taskElement.Parent).Data.DataBoundItem as Appointment;
                IResource resource = this.radScheduler1.Resources.GetById(app.ResourceId);
                screenTip.MainTextLabel.Image = resource.Image;
                screenTip.CaptionLabel.Text = resource.Name;
                screenTip.MainTextLabel.Text = String.Empty;
                e.Item.ScreenTip = screenTip;
            }
        }

        private void radGanttView1_ItemChildIdNeeded(object sender, GanttViewItemChildIdNeededEventArgs e)
        {
            e.ChildId = new EventId(Guid.NewGuid());

            ((Appointment)e.Item.DataBoundItem).ResourceId = ((Appointment)this.contextMenuItem.DataBoundItem).ResourceId;
        }

        private void radGanttView1_GraphicalViewItemFormatting(object sender, GanttViewGraphicalViewItemFormattingEventArgs e)
        {
            Appointment app = e.Item.DataBoundItem as Appointment;
            ISchedulerStorage<IAppointmentBackgroundInfo> backGroundStorage = this.radScheduler1.GetBackgroundStorage();
            IAppointmentBackgroundInfo backInfo = backGroundStorage.GetById(app.BackgroundId);

            if (backInfo != null)
            {
                e.ItemElement.TaskElement.BackColor = backInfo.BackColor;
                e.ItemElement.TaskElement.BackColor2 = backInfo.BackColor2;
                e.ItemElement.TaskElement.BackColor3 = backInfo.BackColor3;
                e.ItemElement.TaskElement.BackColor4 = backInfo.BackColor4;
                e.ItemElement.TaskElement.BorderColor = backInfo.BorderColor;
                e.ItemElement.TaskElement.BorderColor2 = backInfo.BorderColor2;
                e.ItemElement.TaskElement.BorderColor3 = backInfo.BorderColor3;
                e.ItemElement.TaskElement.BorderColor4 = backInfo.BorderColor4;
                e.ItemElement.TaskElement.BorderBoxStyle = backInfo.BorderBoxStyle;
                e.ItemElement.TaskElement.BorderGradientStyle = backInfo.BorderGradientStyle;
                e.ItemElement.TaskElement.ForeColor = backInfo.ForeColor;
                e.ItemElement.TaskElement.GradientAngle = backInfo.GradientAngle;
                e.ItemElement.TaskElement.GradientStyle = backInfo.GradientStyle;
                e.ItemElement.TaskElement.GradientPercentage = backInfo.GradientPercentage;
                e.ItemElement.TaskElement.GradientPercentage2 = backInfo.GradientPercentage2;
                e.ItemElement.TaskElement.NumberOfColors = backInfo.NumberOfColors;

                if (backInfo.Font != null)
                {
                    e.ItemElement.TaskElement.Font = backInfo.Font;
                }
            }

            IResource resource = this.radScheduler1.Resources.GetById(app.ResourceId);

            if (resource != null)
            {
                e.ItemElement.BackColor = resource.Color;
                e.ItemElement.DrawFill = true;
            }
        }

        
        private void radTrackBarZoom_ValueChanged(object sender, EventArgs e)
        {
            //double value = 51 + 0.005d * Math.Pow(this.radTrackBarZoom.Value, 2d);
            //Console.WriteLine(string.Format("{0} - {1}", this.radTrackBarZoom.Value, value));

            //TimeSpan time = new TimeSpan(0, (int)value, 0);
            //this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = time;




        }
   int x = 100;
        int y = 100;
        int z = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            x = x + 50;
            y = y + 50;
            z = z + 50;
             this.radGanttView1.GanttViewElement.GraphicalViewElement.OnePixelTime = new TimeSpan(x, y, z);
            this.radGanttView1.ResumeLayout(); 
            


        }
    }

}
