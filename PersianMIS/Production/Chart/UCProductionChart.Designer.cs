namespace PersianMIS.Production.Chart
{
    partial class UCProductionChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductionChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.TopPnl = new DevComponents.DotNetBar.PanelEx();
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.BtnClosed = new DevComponents.DotNetBar.BubbleButton();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainContexMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Mnu_XType = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_FullDate = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Month = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Week = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Year = new System.Windows.Forms.ToolStripMenuItem();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
            this.MainContexMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.TopPnl.Controls.Add(this.bubbleBar1);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Size = new System.Drawing.Size(392, 44);
            this.TopPnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.TopPnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.TopPnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.TopPnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TopPnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.TopPnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.TopPnl.Style.GradientAngle = 90;
            this.TopPnl.TabIndex = 5;
            this.TopPnl.Text = "سیستم داشبورد مدیریت";
            // 
            // bubbleBar1
            // 
            this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bubbleBar1.AntiAlias = true;
            this.bubbleBar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bubbleBar1.ForeColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.ImageSizeLarge = new System.Drawing.Size(60, 60);
            this.bubbleBar1.ImageSizeNormal = new System.Drawing.Size(35, 35);
            this.bubbleBar1.Location = new System.Drawing.Point(317, -9);
            this.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.Name = "bubbleBar1";
            this.bubbleBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bubbleBar1.SelectedTab = this.bubbleBarTab1;
            this.bubbleBar1.SelectedTabColors.BackColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.SelectedTabColors.BackColor2 = System.Drawing.Color.Transparent;
            this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.bubbleBar1.Size = new System.Drawing.Size(92, 54);
            this.bubbleBar1.TabIndex = 15;
            this.bubbleBar1.Tabs.Add(this.bubbleBarTab1);
            this.bubbleBar1.TooltipOutlineColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.TooltipTextColor = System.Drawing.Color.Transparent;
            // 
            // bubbleBarTab1
            // 
            this.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab1.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.BtnClosed});
            this.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab1.Name = "bubbleBarTab1";
            this.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab1.Text = "";
            this.bubbleBarTab1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
            // 
            // BtnClosed
            // 
            this.BtnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClosed.Image = ((System.Drawing.Image)(resources.GetObject("BtnClosed.Image")));
            this.BtnClosed.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnClosed.ImageLarge")));
            this.BtnClosed.Name = "BtnClosed";
            this.BtnClosed.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnClosed_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 10000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainContexMenuStrip
            // 
            this.MainContexMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_XType});
            this.MainContexMenuStrip.Name = "MainContexMenuStrip";
            this.MainContexMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainContexMenuStrip.Size = new System.Drawing.Size(128, 26);
            // 
            // Mnu_XType
            // 
            this.Mnu_XType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_FullDate,
            this.Mnu_Month,
            this.Mnu_Week,
            this.Mnu_Year});
            this.Mnu_XType.Name = "Mnu_XType";
            this.Mnu_XType.Size = new System.Drawing.Size(127, 22);
            this.Mnu_XType.Text = "محور افقی";
            // 
            // Mnu_FullDate
            // 
            this.Mnu_FullDate.Checked = true;
            this.Mnu_FullDate.CheckOnClick = true;
            this.Mnu_FullDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Mnu_FullDate.Name = "Mnu_FullDate";
            this.Mnu_FullDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mnu_FullDate.Size = new System.Drawing.Size(131, 22);
            this.Mnu_FullDate.Text = "تاریخ کامل";
            this.Mnu_FullDate.CheckStateChanged += new System.EventHandler(this.Mnu_FullDate_CheckStateChanged);
            // 
            // Mnu_Month
            // 
            this.Mnu_Month.CheckOnClick = true;
            this.Mnu_Month.Name = "Mnu_Month";
            this.Mnu_Month.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mnu_Month.Size = new System.Drawing.Size(131, 22);
            this.Mnu_Month.Text = "عنوان ماه";
            this.Mnu_Month.CheckStateChanged += new System.EventHandler(this.Mnu_Month_CheckStateChanged);
            // 
            // Mnu_Week
            // 
            this.Mnu_Week.CheckOnClick = true;
            this.Mnu_Week.Name = "Mnu_Week";
            this.Mnu_Week.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mnu_Week.Size = new System.Drawing.Size(131, 22);
            this.Mnu_Week.Text = "شماره هفته";
            this.Mnu_Week.CheckStateChanged += new System.EventHandler(this.Mnu_Week_CheckStateChanged);
            // 
            // Mnu_Year
            // 
            this.Mnu_Year.CheckOnClick = true;
            this.Mnu_Year.Name = "Mnu_Year";
            this.Mnu_Year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mnu_Year.Size = new System.Drawing.Size(131, 22);
            this.Mnu_Year.Text = "سال";
            this.Mnu_Year.CheckStateChanged += new System.EventHandler(this.Mnu_Year_CheckStateChanged);
            // 
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MainChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.MainChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.MainChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.MainChart.BorderlineWidth = 2;
            this.MainChart.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            this.MainChart.BorderSkin.BackImage = "D:\\PCS11\\PCS\\graphic\\01.jpg";
            this.MainChart.BorderSkin.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.MainChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            this.MainChart.ContextMenuStrip = this.MainContexMenuStrip;
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainChart.Location = new System.Drawing.Point(0, 44);
            this.MainChart.Name = "MainChart";
            this.MainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.MainChart.Size = new System.Drawing.Size(392, 438);
            this.MainChart.TabIndex = 6;
            this.MainChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainChart_MouseDown);
            this.MainChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainChart_MouseMove);
            this.MainChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainChart_MouseUp);
            // 
            // UCProductionChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.TopPnl);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCProductionChart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(392, 482);
            this.Load += new System.EventHandler(this.UCProductionChart_Load);
            this.TopPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            this.MainContexMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx TopPnl;
        internal DevComponents.DotNetBar.BubbleBar bubbleBar1;
        internal DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
        internal DevComponents.DotNetBar.BubbleButton BtnClosed;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ContextMenuStrip MainContexMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Mnu_XType;
        private System.Windows.Forms.ToolStripMenuItem Mnu_FullDate;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Month;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Week;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Year;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
    }
}
