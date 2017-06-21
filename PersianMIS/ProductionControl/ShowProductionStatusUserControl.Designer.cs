namespace PersianMIS.ProductionControl
{
    partial class ShowProductionStatusUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProductionStatusUserControl));
            this.radScheduler1 = new Telerik.WinControls.UI.RadScheduler();
            this.radGanttView1 = new Telerik.WinControls.UI.RadGanttView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).BeginInit();
            this.radScheduler1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).BeginInit();
            this.radGanttView1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radScheduler1
            // 
            this.radScheduler1.AppointmentTitleFormat = null;
            this.radScheduler1.AutoScroll = true;
            this.radScheduler1.Controls.Add(this.radGanttView1);
            this.radScheduler1.Culture = new System.Globalization.CultureInfo("en-US");
            this.radScheduler1.Location = new System.Drawing.Point(0, 0);
            this.radScheduler1.Name = "radScheduler1";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2013, 9, 24, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2013, 9, 19, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.radScheduler1.PrintStyle = schedulerDailyPrintStyle1;
            this.radScheduler1.Size = new System.Drawing.Size(1420, 638);
            this.radScheduler1.TabIndex = 3;
            this.radScheduler1.Text = "radScheduler1";
            // 
            // radGanttView1
            // 
            this.radGanttView1.Controls.Add(this.button1);
            this.radGanttView1.Location = new System.Drawing.Point(0, 0);
            this.radGanttView1.Name = "radGanttView1";
            this.radGanttView1.Ratio = 0F;
            this.radGanttView1.Size = new System.Drawing.Size(17579, 50);
            this.radGanttView1.SplitterWidth = 0;
            this.radGanttView1.TabIndex = 4;
            this.radGanttView1.Text = "radGanttView1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowProductionStatusUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radScheduler1);
            this.Name = "ShowProductionStatusUserControl";
            this.Size = new System.Drawing.Size(1420, 638);
            this.Load += new System.EventHandler(this.ShowProductionStatusUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radScheduler1)).EndInit();
            this.radScheduler1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGanttView1)).EndInit();
            this.radGanttView1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadScheduler radScheduler1;
        private Telerik.WinControls.UI.RadGanttView radGanttView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}
