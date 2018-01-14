namespace PersianMIS.Production.Chart
{
    partial class Frm_SelectChartOptions
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelectChartOptions));
            this.MainPageView = new Telerik.WinControls.UI.RadPageView();
            this.SelectDataTab = new Telerik.WinControls.UI.RadPageViewPage();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Ch_ShowChartPurpose = new Telerik.WinControls.UI.RadCheckBox();
            this.Ch_ShowChart3d = new Telerik.WinControls.UI.RadCheckBox();
            this.Ch_ShowTitleOption = new Telerik.WinControls.UI.RadCheckBox();
            this.Cmb_ChartType = new Telerik.WinControls.UI.RadDropDownList();
            this.Cmb_ChartLegendType = new Telerik.WinControls.UI.RadDropDownList();
            this.Cmb_ChartAxisXType = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ChartTitle = new Telerik.WinControls.UI.RadTextBox();
            this.Lbl_ChartCaption = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_DataTypeShow = new Telerik.WinControls.UI.RadDropDownList();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemplateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Btn_Save = new Telerik.WinControls.UI.RadButton();
            this.SelectDataPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.MainTree = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageView)).BeginInit();
            this.MainPageView.SuspendLayout();
            this.SelectDataTab.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_ShowChartPurpose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_ShowChart3d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_ShowTitleOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_ChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_ChartLegendType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_ChartAxisXType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ChartTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_DataTypeShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemplateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Save)).BeginInit();
            this.SelectDataPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPageView
            // 
            this.MainPageView.Controls.Add(this.SelectDataTab);
            this.MainPageView.Controls.Add(this.SelectDataPage);
            this.MainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageView.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.MainPageView.Location = new System.Drawing.Point(0, 0);
            this.MainPageView.Name = "MainPageView";
            this.MainPageView.SelectedPage = this.SelectDataPage;
            this.MainPageView.Size = new System.Drawing.Size(678, 750);
            this.MainPageView.TabIndex = 0;
            this.MainPageView.Text = "انتخاب داده";
            // 
            // SelectDataTab
            // 
            this.SelectDataTab.Controls.Add(this.groupPanel2);
            this.SelectDataTab.Controls.Add(this.ThemplateChart);
            this.SelectDataTab.Controls.Add(this.Btn_Save);
            this.SelectDataTab.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SelectDataTab.ItemSize = new System.Drawing.SizeF(88F, 34F);
            this.SelectDataTab.Location = new System.Drawing.Point(10, 43);
            this.SelectDataTab.Name = "SelectDataTab";
            this.SelectDataTab.Size = new System.Drawing.Size(657, 696);
            this.SelectDataTab.Text = "تنظیمات نمودار";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.Ch_ShowChartPurpose);
            this.groupPanel2.Controls.Add(this.Ch_ShowChart3d);
            this.groupPanel2.Controls.Add(this.Ch_ShowTitleOption);
            this.groupPanel2.Controls.Add(this.Cmb_ChartType);
            this.groupPanel2.Controls.Add(this.Cmb_ChartLegendType);
            this.groupPanel2.Controls.Add(this.Cmb_ChartAxisXType);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.label2);
            this.groupPanel2.Controls.Add(this.Txt_ChartTitle);
            this.groupPanel2.Controls.Add(this.Lbl_ChartCaption);
            this.groupPanel2.Controls.Add(this.label4);
            this.groupPanel2.Controls.Add(this.Cmb_DataTypeShow);
            this.groupPanel2.Controls.Add(this.label3);
            this.groupPanel2.Location = new System.Drawing.Point(3, 17);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(654, 109);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 65;
            // 
            // Ch_ShowChartPurpose
            // 
            this.Ch_ShowChartPurpose.BackColor = System.Drawing.Color.Transparent;
            this.Ch_ShowChartPurpose.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Ch_ShowChartPurpose.Location = new System.Drawing.Point(180, 36);
            this.Ch_ShowChartPurpose.Name = "Ch_ShowChartPurpose";
            this.Ch_ShowChartPurpose.Size = new System.Drawing.Size(72, 24);
            this.Ch_ShowChartPurpose.TabIndex = 69;
            this.Ch_ShowChartPurpose.Text = "نماش هدف";
            // 
            // Ch_ShowChart3d
            // 
            this.Ch_ShowChart3d.AutoSize = false;
            this.Ch_ShowChart3d.BackColor = System.Drawing.Color.Transparent;
            this.Ch_ShowChart3d.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Ch_ShowChart3d.Location = new System.Drawing.Point(292, 68);
            this.Ch_ShowChart3d.Name = "Ch_ShowChart3d";
            this.Ch_ShowChart3d.Size = new System.Drawing.Size(90, 24);
            this.Ch_ShowChart3d.TabIndex = 68;
            this.Ch_ShowChart3d.Text = "نماش سه بعدی";
            this.Ch_ShowChart3d.CheckStateChanged += new System.EventHandler(this.Ch_3d_CheckStateChanged);
            // 
            // Ch_ShowTitleOption
            // 
            this.Ch_ShowTitleOption.BackColor = System.Drawing.Color.Transparent;
            this.Ch_ShowTitleOption.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Ch_ShowTitleOption.Location = new System.Drawing.Point(271, 36);
            this.Ch_ShowTitleOption.Name = "Ch_ShowTitleOption";
            this.Ch_ShowTitleOption.Size = new System.Drawing.Size(111, 24);
            this.Ch_ShowTitleOption.TabIndex = 67;
            this.Ch_ShowTitleOption.Text = "نمایش عنوان نمودار";
            this.Ch_ShowTitleOption.CheckStateChanged += new System.EventHandler(this.Ch_ShowTitleOption_CheckStateChanged);
            // 
            // Cmb_ChartType
            // 
            this.Cmb_ChartType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.Text = "Cartesian";
            radListDataItem2.Text = "Polar";
            radListDataItem3.Text = "Pie";
            radListDataItem4.Tag = "Funnel";
            radListDataItem4.Text = "Funnel";
            this.Cmb_ChartType.Items.Add(radListDataItem1);
            this.Cmb_ChartType.Items.Add(radListDataItem2);
            this.Cmb_ChartType.Items.Add(radListDataItem3);
            this.Cmb_ChartType.Items.Add(radListDataItem4);
            this.Cmb_ChartType.Location = new System.Drawing.Point(389, 66);
            this.Cmb_ChartType.Name = "Cmb_ChartType";
            this.Cmb_ChartType.NullText = "نوع نمودار را انتخاب کنید";
            this.Cmb_ChartType.Size = new System.Drawing.Size(189, 26);
            this.Cmb_ChartType.TabIndex = 62;
            this.Cmb_ChartType.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.Cmb_ChartType_SelectedIndexChanged);
            // 
            // Cmb_ChartLegendType
            // 
            this.Cmb_ChartLegendType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_ChartLegendType.Location = new System.Drawing.Point(390, 34);
            this.Cmb_ChartLegendType.Name = "Cmb_ChartLegendType";
            this.Cmb_ChartLegendType.NullText = "نحوه نمایش عنوان فیلد ";
            this.Cmb_ChartLegendType.Size = new System.Drawing.Size(188, 26);
            this.Cmb_ChartLegendType.TabIndex = 63;
            // 
            // Cmb_ChartAxisXType
            // 
            this.Cmb_ChartAxisXType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_ChartAxisXType.Location = new System.Drawing.Point(3, 0);
            this.Cmb_ChartAxisXType.Name = "Cmb_ChartAxisXType";
            this.Cmb_ChartAxisXType.NullText = "محور افقی نمودار";
            this.Cmb_ChartAxisXType.Size = new System.Drawing.Size(116, 26);
            this.Cmb_ChartAxisXType.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(576, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "نوع نمودار:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(575, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "فیلد راهنما:";
            // 
            // Txt_ChartTitle
            // 
            this.Txt_ChartTitle.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.Txt_ChartTitle.Location = new System.Drawing.Point(389, 1);
            this.Txt_ChartTitle.Name = "Txt_ChartTitle";
            this.Txt_ChartTitle.Size = new System.Drawing.Size(189, 26);
            this.Txt_ChartTitle.TabIndex = 56;
            // 
            // Lbl_ChartCaption
            // 
            this.Lbl_ChartCaption.AutoSize = true;
            this.Lbl_ChartCaption.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ChartCaption.Location = new System.Drawing.Point(575, 4);
            this.Lbl_ChartCaption.Name = "Lbl_ChartCaption";
            this.Lbl_ChartCaption.Size = new System.Drawing.Size(71, 20);
            this.Lbl_ChartCaption.TabIndex = 55;
            this.Lbl_ChartCaption.Text = "عنوان نمودار:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(115, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "محور افقی:";
            // 
            // Cmb_DataTypeShow
            // 
            this.Cmb_DataTypeShow.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_DataTypeShow.Location = new System.Drawing.Point(180, -1);
            this.Cmb_DataTypeShow.Name = "Cmb_DataTypeShow";
            this.Cmb_DataTypeShow.NullText = " نحوه نمایش ";
            this.Cmb_DataTypeShow.Size = new System.Drawing.Size(106, 26);
            this.Cmb_DataTypeShow.TabIndex = 64;
            this.Cmb_DataTypeShow.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.Cmb_DataTypeShow_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(283, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "نحوه نمایش داده ها :";
            // 
            // ThemplateChart
            // 
            this.ThemplateChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.ThemplateChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.ThemplateChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.ThemplateChart.BackSecondaryColor = System.Drawing.Color.White;
            this.ThemplateChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.ThemplateChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.ThemplateChart.BorderlineWidth = 2;
            this.ThemplateChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
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
            this.ThemplateChart.Legends.Add(legend1);
            this.ThemplateChart.Location = new System.Drawing.Point(3, 141);
            this.ThemplateChart.Name = "ThemplateChart";
            this.ThemplateChart.Size = new System.Drawing.Size(654, 513);
            this.ThemplateChart.TabIndex = 64;
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            title1.Name = "Title1";
            title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            title1.ShadowOffset = 3;
            title1.Text = "Polar Chart";
            this.ThemplateChart.Titles.Add(title1);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.Image = global::PersianMIS.Properties.Resources.save;
            this.Btn_Save.Location = new System.Drawing.Point(260, 660);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(138, 33);
            this.Btn_Save.TabIndex = 59;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // SelectDataPage
            // 
            this.SelectDataPage.Controls.Add(this.MainTree);
            this.SelectDataPage.ItemSize = new System.Drawing.SizeF(71F, 34F);
            this.SelectDataPage.Location = new System.Drawing.Point(10, 43);
            this.SelectDataPage.Name = "SelectDataPage";
            this.SelectDataPage.Size = new System.Drawing.Size(657, 696);
            this.SelectDataPage.Text = "انتخاب داده";
            // 
            // MainTree
            // 
            this.MainTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTree.Location = new System.Drawing.Point(0, 0);
            this.MainTree.Name = "MainTree";
            this.MainTree.Size = new System.Drawing.Size(657, 696);
            this.MainTree.SpacingBetweenNodes = -1;
            this.MainTree.TabIndex = 1;
            this.MainTree.Text = "radTreeView1";
            this.MainTree.NodeCheckedChanged += new Telerik.WinControls.UI.TreeNodeCheckedEventHandler(this.MainTree_NodeCheckedChanged);
            // 
            // Frm_SelectChartOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 750);
            this.Controls.Add(this.MainPageView);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_SelectChartOptions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات نمودار";
            this.Load += new System.EventHandler(this.Frm_SelectChartOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPageView)).EndInit();
            this.MainPageView.ResumeLayout(false);
            this.SelectDataTab.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_ShowChartPurpose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_ShowChart3d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_ShowTitleOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_ChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_ChartLegendType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_ChartAxisXType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ChartTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_DataTypeShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThemplateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Save)).EndInit();
            this.SelectDataPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView MainPageView;
        private Telerik.WinControls.UI.RadPageViewPage SelectDataTab;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox Txt_ChartTitle;
        private System.Windows.Forms.Label Lbl_ChartCaption;
        private Telerik.WinControls.UI.RadButton Btn_Save;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList Cmb_ChartLegendType;
        private Telerik.WinControls.UI.RadDropDownList Cmb_ChartType;
        private System.Windows.Forms.DataVisualization.Charting.Chart ThemplateChart;
        private Telerik.WinControls.UI.RadPageViewPage SelectDataPage;
        private Telerik.WinControls.UI.RadTreeView MainTree;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Telerik.WinControls.UI.RadDropDownList Cmb_ChartAxisXType;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDropDownList Cmb_DataTypeShow;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadCheckBox Ch_ShowChart3d;
        private Telerik.WinControls.UI.RadCheckBox Ch_ShowTitleOption;
        private Telerik.WinControls.UI.RadCheckBox Ch_ShowChartPurpose;
    }
}
