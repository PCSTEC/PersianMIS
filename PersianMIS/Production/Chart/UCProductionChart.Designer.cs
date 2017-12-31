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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TopPnl = new DevComponents.DotNetBar.PanelEx();
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab1 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.BtnClosed = new DevComponents.DotNetBar.BubbleButton();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
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
            this.TopPnl.Size = new System.Drawing.Size(394, 44);
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
            this.bubbleBar1.Location = new System.Drawing.Point(319, -9);
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
            // MainChart
            // 
            this.MainChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.MainChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.MainChart.BackSecondaryColor = System.Drawing.Color.White;
            this.MainChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.MainChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.MainChart.BorderlineWidth = 2;
            this.MainChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Default";
            legend1.Position.Auto = false;
            legend1.Position.Height = 14.23021F;
            legend1.Position.Width = 19.34047F;
            legend1.Position.X = 74.73474F;
            legend1.Position.Y = 74.08253F;
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(0, 44);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(394, 402);
            this.MainChart.TabIndex = 6;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Polar Chart";
            this.MainChart.Titles.Add(title1);
            // 
            // UCProductionChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.TopPnl);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCProductionChart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(394, 446);
            this.Load += new System.EventHandler(this.UCProductionChart_Load);
            this.TopPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx TopPnl;
        internal DevComponents.DotNetBar.BubbleBar bubbleBar1;
        internal DevComponents.DotNetBar.BubbleBarTab bubbleBarTab1;
        internal DevComponents.DotNetBar.BubbleButton BtnClosed;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
    }
}
