namespace PersianMIS.StationControl
{
    partial class ShowStationUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStationUserControl));
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElementAddMilestone = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElementDeleteTask = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup7 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup5 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radTrackBarElementZoom = new Telerik.WinControls.UI.RadTrackBarElement();
            this.radButtonElementProgress100 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElementProgress50 = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElementProgress25 = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.printablePanel = new PersianMIS.CurrentState.PrintablePanel();
            this.radCollapsiblePanel2 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.LSTStations = new Telerik.WinControls.UI.RadCheckedListBox();
            this.radCollapsiblePanel1 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.Btn_Week = new Telerik.WinControls.UI.RadButtonElement();
            this.Btn_Month = new Telerik.WinControls.UI.RadButtonElement();
            this.Btn_Year = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup6 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radDateTimePickerElementStart = new Telerik.WinControls.UI.RadDateTimePickerElement();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.radDateTimePickerElementEnd = new Telerik.WinControls.UI.RadDateTimePickerElement();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.BtnPrint = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.MainPnl = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.printablePanel)).BeginInit();
            this.printablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel2)).BeginInit();
            this.radCollapsiblePanel2.PanelContainer.SuspendLayout();
            this.radCollapsiblePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LSTStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).BeginInit();
            this.radCollapsiblePanel1.PanelContainer.SuspendLayout();
            this.radCollapsiblePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.AccessibleDescription = "چاپ";
            this.radButtonElement2.AccessibleName = "چاپ";
            this.radButtonElement2.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.radButtonElement2.Image = global::PersianMIS.Properties.Resources.printer1;
            this.radButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement2.MinSize = new System.Drawing.Size(60, 0);
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.radButtonElement2.Text = "چاپ پیمایش زمانی";
            this.radButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElement2.UseCompatibleTextRendering = false;
            // 
            // radButtonElementAddMilestone
            // 
            this.radButtonElementAddMilestone.Image = global::PersianMIS.Properties.Resources.GanttAddMilestone;
            this.radButtonElementAddMilestone.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElementAddMilestone.MaxSize = new System.Drawing.Size(80, 0);
            this.radButtonElementAddMilestone.Name = "radButtonElementAddMilestone";
            this.radButtonElementAddMilestone.Text = "Add milestone";
            this.radButtonElementAddMilestone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElementAddMilestone.TextWrap = true;
            this.radButtonElementAddMilestone.UseCompatibleTextRendering = false;
            // 
            // radButtonElementDeleteTask
            // 
            this.radButtonElementDeleteTask.Image = global::PersianMIS.Properties.Resources.GanttDelete;
            this.radButtonElementDeleteTask.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElementDeleteTask.MaxSize = new System.Drawing.Size(80, 0);
            this.radButtonElementDeleteTask.Name = "radButtonElementDeleteTask";
            this.radButtonElementDeleteTask.Text = "Delete selected task";
            this.radButtonElementDeleteTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElementDeleteTask.TextWrap = true;
            this.radButtonElementDeleteTask.UseCompatibleTextRendering = false;
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.AccessibleDescription = "چاپ";
            this.radButtonElement1.AccessibleName = "چاپ";
            this.radButtonElement1.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.radButtonElement1.Image = global::PersianMIS.Properties.Resources.printer1;
            this.radButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButtonElement1.MinSize = new System.Drawing.Size(60, 0);
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.radButtonElement1.Text = "چاپ پیمایش زمانی";
            this.radButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radButtonElement1.UseCompatibleTextRendering = false;
            // 
            // radRibbonBarGroup7
            // 
            this.radRibbonBarGroup7.AccessibleDescription = "Print";
            this.radRibbonBarGroup7.AccessibleName = "Print";
            this.radRibbonBarGroup7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1});
            this.radRibbonBarGroup7.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup7.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup7.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup7.Name = "radRibbonBarGroup7";
            this.radRibbonBarGroup7.Text = "چاپ اطلاعات";
            this.radRibbonBarGroup7.UseCompatibleTextRendering = false;
            // 
            // radRibbonBarGroup5
            // 
            this.radRibbonBarGroup5.AutoSize = true;
            this.radRibbonBarGroup5.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radTrackBarElementZoom});
            this.radRibbonBarGroup5.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup5.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup5.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup5.Name = "radRibbonBarGroup5";
            this.radRibbonBarGroup5.Text = "بزرگنمایی";
            this.radRibbonBarGroup5.UseCompatibleTextRendering = false;
            // 
            // radTrackBarElementZoom
            // 
            this.radTrackBarElementZoom.AutoSize = false;
            this.radTrackBarElementZoom.Bounds = new System.Drawing.Rectangle(0, 0, 483, 42);
            this.radTrackBarElementZoom.Comparer = null;
            this.radTrackBarElementZoom.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTrackBarElementZoom.FitInAvailableSize = true;
            this.radTrackBarElementZoom.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.radTrackBarElementZoom.Maximum = 50F;
            this.radTrackBarElementZoom.MinSize = new System.Drawing.Size(100, 0);
            this.radTrackBarElementZoom.Name = "radTrackBarElementZoom";
            this.radTrackBarElementZoom.Text = "radButtonElement9";
            this.radTrackBarElementZoom.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.radTrackBarElementZoom.UseCompatibleTextRendering = false;
            // 
            // radButtonElementProgress100
            // 
            this.radButtonElementProgress100.Image = global::PersianMIS.Properties.Resources.Gantt100;
            this.radButtonElementProgress100.Name = "radButtonElementProgress100";
            this.radButtonElementProgress100.Text = "100%";
            this.radButtonElementProgress100.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButtonElementProgress100.UseCompatibleTextRendering = false;
            // 
            // radButtonElementProgress50
            // 
            this.radButtonElementProgress50.Image = global::PersianMIS.Properties.Resources.Gantt50;
            this.radButtonElementProgress50.Name = "radButtonElementProgress50";
            this.radButtonElementProgress50.Text = "50%";
            this.radButtonElementProgress50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButtonElementProgress50.UseCompatibleTextRendering = false;
            // 
            // radButtonElementProgress25
            // 
            this.radButtonElementProgress25.Image = global::PersianMIS.Properties.Resources.Gantt25;
            this.radButtonElementProgress25.Name = "radButtonElementProgress25";
            this.radButtonElementProgress25.Text = "25%";
            this.radButtonElementProgress25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radButtonElementProgress25.UseCompatibleTextRendering = false;
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElementProgress25,
            this.radButtonElementProgress50,
            this.radButtonElementProgress100});
            this.radRibbonBarGroup2.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup2.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup2.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarGroup2.Text = "میزان بزرگنمایی";
            this.radRibbonBarGroup2.UseCompatibleTextRendering = false;
            // 
            // printablePanel
            // 
            this.printablePanel.AutoScroll = true;
            this.printablePanel.Controls.Add(this.MainPnl);
            this.printablePanel.Controls.Add(this.radCollapsiblePanel2);
            this.printablePanel.Controls.Add(this.radCollapsiblePanel1);
            this.printablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printablePanel.Location = new System.Drawing.Point(0, 0);
            this.printablePanel.Name = "printablePanel";
            this.printablePanel.Size = new System.Drawing.Size(966, 564);
            this.printablePanel.TabIndex = 1;
            this.printablePanel.Text = "printablePanel1";
            // 
            // radCollapsiblePanel2
            // 
            this.radCollapsiblePanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.radCollapsiblePanel2.ExpandDirection = Telerik.WinControls.UI.RadDirection.Left;
            this.radCollapsiblePanel2.Location = new System.Drawing.Point(625, 21);
            this.radCollapsiblePanel2.Name = "radCollapsiblePanel2";
            this.radCollapsiblePanel2.OwnerBoundsCache = new System.Drawing.Rectangle(625, 21, 341, 543);
            // 
            // radCollapsiblePanel2.PanelContainer
            // 
            this.radCollapsiblePanel2.PanelContainer.Controls.Add(this.LSTStations);
            this.radCollapsiblePanel2.PanelContainer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.radCollapsiblePanel2.PanelContainer.Size = new System.Drawing.Size(313, 541);
            this.radCollapsiblePanel2.Size = new System.Drawing.Size(341, 543);
            this.radCollapsiblePanel2.TabIndex = 13;
            this.radCollapsiblePanel2.Text = "radCollapsiblePanel2";
            // 
            // LSTStations
            // 
            this.LSTStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSTStations.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LSTStations.Location = new System.Drawing.Point(0, 0);
            this.LSTStations.Name = "LSTStations";
            this.LSTStations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSTStations.Size = new System.Drawing.Size(313, 541);
            this.LSTStations.TabIndex = 0;
            this.LSTStations.Text = "radCheckedListBox1";
            this.LSTStations.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.LSTStations_ItemCheckedChanged);
            // 
            // radCollapsiblePanel1
            // 
            this.radCollapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCollapsiblePanel1.IsExpanded = false;
            this.radCollapsiblePanel1.Location = new System.Drawing.Point(0, 0);
            this.radCollapsiblePanel1.Name = "radCollapsiblePanel1";
            this.radCollapsiblePanel1.OwnerBoundsCache = new System.Drawing.Rectangle(0, 0, 966, 189);
            // 
            // radCollapsiblePanel1.PanelContainer
            // 
            this.radCollapsiblePanel1.PanelContainer.Controls.Add(this.radRibbonBar1);
            this.radCollapsiblePanel1.PanelContainer.Location = new System.Drawing.Point(18, 1);
            this.radCollapsiblePanel1.PanelContainer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.radCollapsiblePanel1.PanelContainer.Size = new System.Drawing.Size(0, 0);
            this.radCollapsiblePanel1.Size = new System.Drawing.Size(966, 21);
            this.radCollapsiblePanel1.TabIndex = 12;
            this.radCollapsiblePanel1.Text = "radCollapsiblePanel1";
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radRibbonBar1.Size = new System.Drawing.Size(0, 144);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.TabIndex = 9;
            this.radRibbonBar1.Text = "RadGanttViewExample";
            this.radRibbonBar1.ThemeName = "TelerikMetroBlue";
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "RadGanttViewExample";
            ((Telerik.WinControls.UI.RadQuickAccessToolBar)(this.radRibbonBar1.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadRibbonBarCaption)(this.radRibbonBar1.GetChildAt(0).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RibbonTabStripElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(4))).RightToLeft = true;
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.radRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(4).GetChildAt(1))).Margin = new System.Windows.Forms.Padding(0);
            ((Telerik.WinControls.UI.RadApplicationMenuButtonElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(5))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadApplicationMenuButtonElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(5))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.StackLayoutElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AutoEllipsis = false;
            this.ribbonTab1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup6,
            this.radRibbonBarGroup4});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "s";
            this.ribbonTab1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab1.UseCompatibleTextRendering = false;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.AutoSize = false;
            this.radRibbonBarGroup1.Bounds = new System.Drawing.Rectangle(0, 0, 5, 101);
            this.radRibbonBarGroup1.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup1.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup1.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "ITEMS";
            this.radRibbonBarGroup1.UseCompatibleTextRendering = false;
            this.radRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.AccessibleDescription = "NAVIGATE";
            this.radRibbonBarGroup3.AccessibleName = "NAVIGATE";
            this.radRibbonBarGroup3.AutoSize = true;
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.Btn_Week,
            this.Btn_Month,
            this.Btn_Year});
            this.radRibbonBarGroup3.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup3.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup3.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarGroup3.Text = "سبک نمایش";
            this.radRibbonBarGroup3.UseCompatibleTextRendering = false;
            // 
            // Btn_Week
            // 
            this.Btn_Week.Image = global::PersianMIS.Properties.Resources.GanttWeek;
            this.Btn_Week.Name = "Btn_Week";
            this.Btn_Week.Text = "هفتگی";
            this.Btn_Week.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Week.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Week.UseCompatibleTextRendering = false;
            // 
            // Btn_Month
            // 
            this.Btn_Month.Image = global::PersianMIS.Properties.Resources.GanttMonth;
            this.Btn_Month.Name = "Btn_Month";
            this.Btn_Month.Text = "ماهیانه";
            this.Btn_Month.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Month.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Month.UseCompatibleTextRendering = false;
            // 
            // Btn_Year
            // 
            this.Btn_Year.AutoSize = true;
            this.Btn_Year.Image = global::PersianMIS.Properties.Resources.GanttYear;
            this.Btn_Year.Name = "Btn_Year";
            this.Btn_Year.Text = "سالیانه";
            this.Btn_Year.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Year.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Year.UseCompatibleTextRendering = false;
            // 
            // radRibbonBarGroup6
            // 
            this.radRibbonBarGroup6.AccessibleDescription = "TIMERANGE";
            this.radRibbonBarGroup6.AccessibleName = "TIMERANGE";
            this.radRibbonBarGroup6.AutoSize = true;
            this.radRibbonBarGroup6.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup1,
            this.radRibbonBarButtonGroup2});
            this.radRibbonBarGroup6.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup6.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup6.MinSize = new System.Drawing.Size(1, 1);
            this.radRibbonBarGroup6.Name = "radRibbonBarGroup6";
            this.radRibbonBarGroup6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarGroup6.Text = "نرخ نمایش";
            this.radRibbonBarGroup6.UseCompatibleTextRendering = false;
            // 
            // radRibbonBarButtonGroup1
            // 
            this.radRibbonBarButtonGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.radDateTimePickerElementStart});
            this.radRibbonBarButtonGroup1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.radRibbonBarButtonGroup1.MinSize = new System.Drawing.Size(22, 22);
            this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Padding = new System.Windows.Forms.Padding(1);
            this.radRibbonBarButtonGroup1.ShowBackColor = false;
            this.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.UseCompatibleTextRendering = false;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radLabelElement1.Text = "شروع";
            this.radLabelElement1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.UseCompatibleTextRendering = false;
            // 
            // radDateTimePickerElementStart
            // 
            this.radDateTimePickerElementStart.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radDateTimePickerElementStart.AutoSize = false;
            this.radDateTimePickerElementStart.Bounds = new System.Drawing.Rectangle(0, 0, 150, 25);
            this.radDateTimePickerElementStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePickerElementStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePickerElementStart.MinDate = new System.DateTime(((long)(0)));
            this.radDateTimePickerElementStart.MinSize = new System.Drawing.Size(1, 0);
            this.radDateTimePickerElementStart.Name = "radDateTimePickerElementStart";
            this.radDateTimePickerElementStart.NullDate = new System.DateTime(((long)(0)));
            this.radDateTimePickerElementStart.RightToLeft = true;
            this.radDateTimePickerElementStart.StretchVertically = false;
            this.radDateTimePickerElementStart.Text = "radButtonElement9";
            this.radDateTimePickerElementStart.UseCompatibleTextRendering = false;
            this.radDateTimePickerElementStart.ValueChanging += new Telerik.WinControls.UI.ValueChangingEventHandler(this.radDateTimePickerElementStart_ValueChanged);
            this.radDateTimePickerElementStart.Click += new System.EventHandler(this.radDateTimePickerElementStart_Click);
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement2,
            this.radDateTimePickerElementEnd});
            this.radRibbonBarButtonGroup2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.radRibbonBarButtonGroup2.MinSize = new System.Drawing.Size(22, 22);
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Padding = new System.Windows.Forms.Padding(1);
            this.radRibbonBarButtonGroup2.ShowBackColor = false;
            this.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.UseCompatibleTextRendering = false;
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.MinSize = new System.Drawing.Size(1, 0);
            this.radLabelElement2.Name = "radLabelElement2";
            this.radLabelElement2.Text = "پایان";
            this.radLabelElement2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement2.TextWrap = true;
            this.radLabelElement2.UseCompatibleTextRendering = false;
            // 
            // radDateTimePickerElementEnd
            // 
            this.radDateTimePickerElementEnd.AutoSize = false;
            this.radDateTimePickerElementEnd.Bounds = new System.Drawing.Rectangle(0, 0, 155, 25);
            this.radDateTimePickerElementEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.radDateTimePickerElementEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.radDateTimePickerElementEnd.MinDate = new System.DateTime(((long)(0)));
            this.radDateTimePickerElementEnd.MinSize = new System.Drawing.Size(1, 0);
            this.radDateTimePickerElementEnd.Name = "radDateTimePickerElementEnd";
            this.radDateTimePickerElementEnd.NullDate = new System.DateTime(((long)(0)));
            this.radDateTimePickerElementEnd.StretchVertically = false;
            this.radDateTimePickerElementEnd.Text = "radButtonElement10";
            this.radDateTimePickerElementEnd.UseCompatibleTextRendering = false;
            this.radDateTimePickerElementEnd.ValueChanging += new Telerik.WinControls.UI.ValueChangingEventHandler(this.radDateTimePickerElementEnd_ValueChanged);
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.AccessibleDescription = "Print";
            this.radRibbonBarGroup4.AccessibleName = "Print";
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.BtnPrint});
            this.radRibbonBarGroup4.Margin = new System.Windows.Forms.Padding(0);
            this.radRibbonBarGroup4.MaxSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup4.MinSize = new System.Drawing.Size(0, 0);
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "چاپ اطلاعات";
            this.radRibbonBarGroup4.UseCompatibleTextRendering = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.AccessibleDescription = "چاپ";
            this.BtnPrint.AccessibleName = "چاپ";
            this.BtnPrint.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.BtnPrint.Image = global::PersianMIS.Properties.Resources.printer1;
            this.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPrint.MinSize = new System.Drawing.Size(1, 0);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnPrint.Text = "چاپ پیمایش زمانی";
            this.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPrint.UseCompatibleTextRendering = false;
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.AutoEllipsis = false;
            this.ribbonTab2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "ribbonTab2";
            this.ribbonTab2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ribbonTab2.UseCompatibleTextRendering = false;
            // 
            // MainPnl
            // 
            this.MainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPnl.Location = new System.Drawing.Point(0, 21);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(625, 543);
            this.MainPnl.TabIndex = 14;
            // 
            // ShowStationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printablePanel);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ShowStationUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(966, 564);
            this.Load += new System.EventHandler(this.ShowStationUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printablePanel)).EndInit();
            this.printablePanel.ResumeLayout(false);
            this.radCollapsiblePanel2.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel2)).EndInit();
            this.radCollapsiblePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LSTStations)).EndInit();
            this.radCollapsiblePanel1.PanelContainer.ResumeLayout(false);
            this.radCollapsiblePanel1.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel1)).EndInit();
            this.radCollapsiblePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadButtonElement Btn_Week;
        private Telerik.WinControls.UI.RadButtonElement Btn_Month;
        private Telerik.WinControls.UI.RadButtonElement Btn_Year;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup6;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadDateTimePickerElement radDateTimePickerElementStart;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        private Telerik.WinControls.UI.RadDateTimePickerElement radDateTimePickerElementEnd;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadButtonElement BtnPrint;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel2;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private CurrentState.PrintablePanel printablePanel;
        private System.Windows.Forms.Timer RefreshTimer;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElementAddMilestone;
        private Telerik.WinControls.UI.RadButtonElement radButtonElementDeleteTask;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup7;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup5;
        private Telerik.WinControls.UI.RadTrackBarElement radTrackBarElementZoom;
        private Telerik.WinControls.UI.RadButtonElement radButtonElementProgress100;
        private Telerik.WinControls.UI.RadButtonElement radButtonElementProgress50;
        private Telerik.WinControls.UI.RadButtonElement radButtonElementProgress25;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadCheckedListBox LSTStations;
        private System.Windows.Forms.FlowLayoutPanel MainPnl;
    }
}
