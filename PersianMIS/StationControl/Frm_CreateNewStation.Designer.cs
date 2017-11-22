namespace PersianMIS.StationControl
{
    partial class Frm_CreateNewStation
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
            this.Txt_StationCaption = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_StationPulsCount = new System.Windows.Forms.NumericUpDown();
            this.Lbl_StationPulsCount = new Telerik.WinControls.UI.RadLabel();
            this.Cmb_SelectStation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Lbl_SelectStation = new Telerik.WinControls.UI.RadLabel();
            this.MainPnl = new System.Windows.Forms.Panel();
            this.Gp_CreateDeviceLine = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Pnl_Step4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_Finished = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pnl_Step3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.FlowPnl_Step3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Pnl_Step2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_GotoStep3 = new Telerik.WinControls.UI.RadButton();
            this.PnlStep1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_CreateStep1 = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Step4 = new System.Windows.Forms.PictureBox();
            this.Btn_Step1 = new System.Windows.Forms.PictureBox();
            this.Btn_Step2 = new System.Windows.Forms.PictureBox();
            this.Btn_Step3 = new System.Windows.Forms.PictureBox();
            this.MainStatusBar = new Telerik.WinControls.UI.RadStatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationPulsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_StationPulsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_SelectStation)).BeginInit();
            this.Gp_CreateDeviceLine.SuspendLayout();
            this.Pnl_Step4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Finished)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Pnl_Step3.SuspendLayout();
            this.Pnl_Step2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_GotoStep3)).BeginInit();
            this.PnlStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_CreateStep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Step4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Step1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Step2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Step3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainStatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_StationCaption
            // 
            this.Txt_StationCaption.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_StationCaption.Location = new System.Drawing.Point(225, 24);
            this.Txt_StationCaption.Name = "Txt_StationCaption";
            this.Txt_StationCaption.NullText = "عنوان ایستگاه";
            this.Txt_StationCaption.Size = new System.Drawing.Size(160, 28);
            this.Txt_StationCaption.TabIndex = 40;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(382, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(79, 24);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "عنوان ایستگاه :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_StationPulsCount
            // 
            this.Txt_StationPulsCount.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_StationPulsCount.Location = new System.Drawing.Point(3, 19);
            this.Txt_StationPulsCount.Name = "Txt_StationPulsCount";
            this.Txt_StationPulsCount.Size = new System.Drawing.Size(88, 30);
            this.Txt_StationPulsCount.TabIndex = 1;
            this.Txt_StationPulsCount.ValueChanged += new System.EventHandler(this.Txt_StationPulsCount_ValueChanged);
            // 
            // Lbl_StationPulsCount
            // 
            this.Lbl_StationPulsCount.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_StationPulsCount.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_StationPulsCount.Location = new System.Drawing.Point(97, 28);
            this.Lbl_StationPulsCount.Name = "Lbl_StationPulsCount";
            this.Lbl_StationPulsCount.Size = new System.Drawing.Size(123, 24);
            this.Lbl_StationPulsCount.TabIndex = 0;
            this.Lbl_StationPulsCount.Text = "تعداد پالس های ایستگاه :";
            this.Lbl_StationPulsCount.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Cmb_SelectStation
            // 
            this.Cmb_SelectStation.DisplayMember = "Text";
            this.Cmb_SelectStation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_SelectStation.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cmb_SelectStation.FormattingEnabled = true;
            this.Cmb_SelectStation.ItemHeight = 24;
            this.Cmb_SelectStation.Location = new System.Drawing.Point(173, 15);
            this.Cmb_SelectStation.Name = "Cmb_SelectStation";
            this.Cmb_SelectStation.Size = new System.Drawing.Size(186, 30);
            this.Cmb_SelectStation.TabIndex = 46;
            this.Cmb_SelectStation.Text = "پالس را انتخاب کنید";
            this.Cmb_SelectStation.SelectedValueChanged += new System.EventHandler(this.Cmb_SelectStation_SelectedValueChanged);
            // 
            // Lbl_SelectStation
            // 
            this.Lbl_SelectStation.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_SelectStation.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_SelectStation.Location = new System.Drawing.Point(365, 19);
            this.Lbl_SelectStation.Name = "Lbl_SelectStation";
            this.Lbl_SelectStation.Size = new System.Drawing.Size(70, 24);
            this.Lbl_SelectStation.TabIndex = 2;
            this.Lbl_SelectStation.Text = "انتخاب پالس :";
            this.Lbl_SelectStation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainPnl
            // 
            this.MainPnl.Location = new System.Drawing.Point(3, 57);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(460, 466);
            this.MainPnl.TabIndex = 8;
            // 
            // Gp_CreateDeviceLine
            // 
            this.Gp_CreateDeviceLine.CanvasColor = System.Drawing.SystemColors.Control;
            this.Gp_CreateDeviceLine.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Gp_CreateDeviceLine.Controls.Add(this.Pnl_Step4);
            this.Gp_CreateDeviceLine.Controls.Add(this.Pnl_Step3);
            this.Gp_CreateDeviceLine.Controls.Add(this.Pnl_Step2);
            this.Gp_CreateDeviceLine.Controls.Add(this.PnlStep1);
            this.Gp_CreateDeviceLine.Controls.Add(this.pictureBox1);
            this.Gp_CreateDeviceLine.Controls.Add(this.Btn_Step4);
            this.Gp_CreateDeviceLine.Controls.Add(this.Btn_Step1);
            this.Gp_CreateDeviceLine.Controls.Add(this.Btn_Step2);
            this.Gp_CreateDeviceLine.Controls.Add(this.Btn_Step3);
            this.Gp_CreateDeviceLine.Location = new System.Drawing.Point(5, 11);
            this.Gp_CreateDeviceLine.Name = "Gp_CreateDeviceLine";
            this.Gp_CreateDeviceLine.Size = new System.Drawing.Size(484, 745);
            // 
            // 
            // 
            this.Gp_CreateDeviceLine.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Gp_CreateDeviceLine.Style.BackColorGradientAngle = 90;
            this.Gp_CreateDeviceLine.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Gp_CreateDeviceLine.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Gp_CreateDeviceLine.Style.BorderBottomWidth = 1;
            this.Gp_CreateDeviceLine.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Gp_CreateDeviceLine.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Gp_CreateDeviceLine.Style.BorderLeftWidth = 1;
            this.Gp_CreateDeviceLine.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Gp_CreateDeviceLine.Style.BorderRightWidth = 1;
            this.Gp_CreateDeviceLine.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Gp_CreateDeviceLine.Style.BorderTopWidth = 1;
            this.Gp_CreateDeviceLine.Style.CornerDiameter = 4;
            this.Gp_CreateDeviceLine.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Gp_CreateDeviceLine.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Gp_CreateDeviceLine.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Gp_CreateDeviceLine.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.Gp_CreateDeviceLine.TabIndex = 54;
            // 
            // Pnl_Step4
            // 
            this.Pnl_Step4.AutoScroll = true;
            this.Pnl_Step4.CanvasColor = System.Drawing.SystemColors.Control;
            this.Pnl_Step4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Pnl_Step4.Controls.Add(this.Btn_Finished);
            this.Pnl_Step4.Controls.Add(this.label1);
            this.Pnl_Step4.Controls.Add(this.pictureBox2);
            this.Pnl_Step4.Location = new System.Drawing.Point(1, 175);
            this.Pnl_Step4.Name = "Pnl_Step4";
            this.Pnl_Step4.Size = new System.Drawing.Size(472, 539);
            // 
            // 
            // 
            this.Pnl_Step4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Pnl_Step4.Style.BackColorGradientAngle = 90;
            this.Pnl_Step4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Pnl_Step4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step4.Style.BorderBottomWidth = 1;
            this.Pnl_Step4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Pnl_Step4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step4.Style.BorderLeftWidth = 1;
            this.Pnl_Step4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step4.Style.BorderRightWidth = 1;
            this.Pnl_Step4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step4.Style.BorderTopWidth = 1;
            this.Pnl_Step4.Style.CornerDiameter = 4;
            this.Pnl_Step4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Pnl_Step4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Pnl_Step4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Pnl_Step4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.Pnl_Step4.TabIndex = 57;
            this.Pnl_Step4.Visible = false;
            // 
            // Btn_Finished
            // 
            this.Btn_Finished.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Finished.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Finished.Image = global::PersianMIS.Properties.Resources.nextButton;
            this.Btn_Finished.Location = new System.Drawing.Point(205, 270);
            this.Btn_Finished.Name = "Btn_Finished";
            this.Btn_Finished.Size = new System.Drawing.Size(103, 36);
            this.Btn_Finished.TabIndex = 52;
            this.Btn_Finished.Text = "خروج";
            this.Btn_Finished.Click += new System.EventHandler(this.Btn_Finished_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(30, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ایستگاه مورد نظر با موفقیت ایجاد گردید";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::PersianMIS.Properties.Resources.complete;
            this.pictureBox2.Location = new System.Drawing.Point(196, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Pnl_Step3
            // 
            this.Pnl_Step3.AutoScroll = true;
            this.Pnl_Step3.CanvasColor = System.Drawing.SystemColors.Control;
            this.Pnl_Step3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Pnl_Step3.Controls.Add(this.FlowPnl_Step3);
            this.Pnl_Step3.Location = new System.Drawing.Point(3, 177);
            this.Pnl_Step3.Name = "Pnl_Step3";
            this.Pnl_Step3.Size = new System.Drawing.Size(472, 539);
            // 
            // 
            // 
            this.Pnl_Step3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Pnl_Step3.Style.BackColorGradientAngle = 90;
            this.Pnl_Step3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Pnl_Step3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step3.Style.BorderBottomWidth = 1;
            this.Pnl_Step3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Pnl_Step3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step3.Style.BorderLeftWidth = 1;
            this.Pnl_Step3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step3.Style.BorderRightWidth = 1;
            this.Pnl_Step3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step3.Style.BorderTopWidth = 1;
            this.Pnl_Step3.Style.CornerDiameter = 4;
            this.Pnl_Step3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Pnl_Step3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Pnl_Step3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Pnl_Step3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.Pnl_Step3.TabIndex = 56;
            this.Pnl_Step3.Visible = false;
            // 
            // FlowPnl_Step3
            // 
            this.FlowPnl_Step3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPnl_Step3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPnl_Step3.Location = new System.Drawing.Point(0, 0);
            this.FlowPnl_Step3.Name = "FlowPnl_Step3";
            this.FlowPnl_Step3.Size = new System.Drawing.Size(466, 533);
            this.FlowPnl_Step3.TabIndex = 0;
            this.FlowPnl_Step3.WrapContents = false;
            // 
            // Pnl_Step2
            // 
            this.Pnl_Step2.CanvasColor = System.Drawing.SystemColors.Control;
            this.Pnl_Step2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Pnl_Step2.Controls.Add(this.Btn_GotoStep3);
            this.Pnl_Step2.Controls.Add(this.Cmb_SelectStation);
            this.Pnl_Step2.Controls.Add(this.Lbl_SelectStation);
            this.Pnl_Step2.Controls.Add(this.MainPnl);
            this.Pnl_Step2.Location = new System.Drawing.Point(3, 176);
            this.Pnl_Step2.Name = "Pnl_Step2";
            this.Pnl_Step2.Size = new System.Drawing.Size(472, 539);
            // 
            // 
            // 
            this.Pnl_Step2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Pnl_Step2.Style.BackColorGradientAngle = 90;
            this.Pnl_Step2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Pnl_Step2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step2.Style.BorderBottomWidth = 1;
            this.Pnl_Step2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Pnl_Step2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step2.Style.BorderLeftWidth = 1;
            this.Pnl_Step2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step2.Style.BorderRightWidth = 1;
            this.Pnl_Step2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_Step2.Style.BorderTopWidth = 1;
            this.Pnl_Step2.Style.CornerDiameter = 4;
            this.Pnl_Step2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Pnl_Step2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Pnl_Step2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Pnl_Step2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.Pnl_Step2.TabIndex = 55;
            this.Pnl_Step2.Visible = false;
            // 
            // Btn_GotoStep3
            // 
            this.Btn_GotoStep3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_GotoStep3.Image = global::PersianMIS.Properties.Resources.nextButton;
            this.Btn_GotoStep3.Location = new System.Drawing.Point(42, 9);
            this.Btn_GotoStep3.Name = "Btn_GotoStep3";
            this.Btn_GotoStep3.Size = new System.Drawing.Size(103, 36);
            this.Btn_GotoStep3.TabIndex = 51;
            this.Btn_GotoStep3.Text = "ادامه";
            this.Btn_GotoStep3.Click += new System.EventHandler(this.Btn_GotoStep3_Click);
            // 
            // PnlStep1
            // 
            this.PnlStep1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlStep1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.PnlStep1.Controls.Add(this.Txt_StationCaption);
            this.PnlStep1.Controls.Add(this.Btn_CreateStep1);
            this.PnlStep1.Controls.Add(this.radLabel1);
            this.PnlStep1.Controls.Add(this.Lbl_StationPulsCount);
            this.PnlStep1.Controls.Add(this.Txt_StationPulsCount);
            this.PnlStep1.Location = new System.Drawing.Point(3, 176);
            this.PnlStep1.Name = "PnlStep1";
            this.PnlStep1.Size = new System.Drawing.Size(472, 539);
            // 
            // 
            // 
            this.PnlStep1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlStep1.Style.BackColorGradientAngle = 90;
            this.PnlStep1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlStep1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PnlStep1.Style.BorderBottomWidth = 1;
            this.PnlStep1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlStep1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PnlStep1.Style.BorderLeftWidth = 1;
            this.PnlStep1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PnlStep1.Style.BorderRightWidth = 1;
            this.PnlStep1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PnlStep1.Style.BorderTopWidth = 1;
            this.PnlStep1.Style.CornerDiameter = 4;
            this.PnlStep1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.PnlStep1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.PnlStep1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlStep1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.PnlStep1.TabIndex = 54;
            // 
            // Btn_CreateStep1
            // 
            this.Btn_CreateStep1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CreateStep1.Image = global::PersianMIS.Properties.Resources.Create_Shift__Okpng;
            this.Btn_CreateStep1.Location = new System.Drawing.Point(159, 124);
            this.Btn_CreateStep1.Name = "Btn_CreateStep1";
            this.Btn_CreateStep1.Size = new System.Drawing.Size(133, 33);
            this.Btn_CreateStep1.TabIndex = 53;
            this.Btn_CreateStep1.Text = "ادامه";
            this.Btn_CreateStep1.Click += new System.EventHandler(this.Btn_CreateStep1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PersianMIS.Properties.Resources.Line;
            this.pictureBox1.Location = new System.Drawing.Point(18, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Step4
            // 
            this.Btn_Step4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Step4.Image = global::PersianMIS.Properties.Resources.Step4NotOk;
            this.Btn_Step4.Location = new System.Drawing.Point(18, 23);
            this.Btn_Step4.Name = "Btn_Step4";
            this.Btn_Step4.Size = new System.Drawing.Size(112, 109);
            this.Btn_Step4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Step4.TabIndex = 51;
            this.Btn_Step4.TabStop = false;
            // 
            // Btn_Step1
            // 
            this.Btn_Step1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Step1.Image = global::PersianMIS.Properties.Resources.Step11;
            this.Btn_Step1.Location = new System.Drawing.Point(347, 22);
            this.Btn_Step1.Name = "Btn_Step1";
            this.Btn_Step1.Size = new System.Drawing.Size(112, 109);
            this.Btn_Step1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Step1.TabIndex = 48;
            this.Btn_Step1.TabStop = false;
            this.Btn_Step1.Click += new System.EventHandler(this.Btn_Step1_Click);
            // 
            // Btn_Step2
            // 
            this.Btn_Step2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Step2.Image = global::PersianMIS.Properties.Resources.Step2NotOk;
            this.Btn_Step2.Location = new System.Drawing.Point(241, 24);
            this.Btn_Step2.Name = "Btn_Step2";
            this.Btn_Step2.Size = new System.Drawing.Size(112, 109);
            this.Btn_Step2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Step2.TabIndex = 49;
            this.Btn_Step2.TabStop = false;
            this.Btn_Step2.Click += new System.EventHandler(this.Btn_Step2_Click);
            // 
            // Btn_Step3
            // 
            this.Btn_Step3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Step3.Image = global::PersianMIS.Properties.Resources.Step3NotOk;
            this.Btn_Step3.Location = new System.Drawing.Point(130, 23);
            this.Btn_Step3.Name = "Btn_Step3";
            this.Btn_Step3.Size = new System.Drawing.Size(112, 109);
            this.Btn_Step3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Step3.TabIndex = 50;
            this.Btn_Step3.TabStop = false;
            this.Btn_Step3.Click += new System.EventHandler(this.Btn_Step3_Click);
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Location = new System.Drawing.Point(0, 735);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainStatusBar.Size = new System.Drawing.Size(489, 24);
            this.MainStatusBar.TabIndex = 55;
            this.MainStatusBar.Text = "radStatusStrip1";
            // 
            // Frm_CreateNewStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 759);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.Gp_CreateDeviceLine);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_CreateNewStation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایجاد ایستگاه های کاری";
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationPulsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_StationPulsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_SelectStation)).EndInit();
            this.Gp_CreateDeviceLine.ResumeLayout(false);
            this.Pnl_Step4.ResumeLayout(false);
            this.Pnl_Step4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Finished)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Pnl_Step3.ResumeLayout(false);
            this.Pnl_Step2.ResumeLayout(false);
            this.Pnl_Step2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_GotoStep3)).EndInit();
            this.PnlStep1.ResumeLayout(false);
            this.PnlStep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_CreateStep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Step4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Step1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Step2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Step3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainStatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox Txt_StationCaption;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown Txt_StationPulsCount;
        private Telerik.WinControls.UI.RadLabel Lbl_StationPulsCount;
      //  private Telerik.WinControls.UI.RadButton Btn_Save;
        private Telerik.WinControls.UI.RadLabel Lbl_SelectStation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Cmb_SelectStation;
        private System.Windows.Forms.Panel MainPnl;
        private System.Windows.Forms.PictureBox Btn_Step1;
        private System.Windows.Forms.PictureBox Btn_Step2;
        private System.Windows.Forms.PictureBox Btn_Step3;
        private System.Windows.Forms.PictureBox Btn_Step4;
        private DevComponents.DotNetBar.Controls.GroupPanel Gp_CreateDeviceLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadStatusStrip MainStatusBar;
        private Telerik.WinControls.UI.RadButton Btn_CreateStep1;
        private DevComponents.DotNetBar.Controls.GroupPanel PnlStep1;
        private DevComponents.DotNetBar.Controls.GroupPanel Pnl_Step2;
        private Telerik.WinControls.UI.RadButton Btn_GotoStep3;
        private DevComponents.DotNetBar.Controls.GroupPanel Pnl_Step3;
        private System.Windows.Forms.FlowLayoutPanel FlowPnl_Step3;
        private DevComponents.DotNetBar.Controls.GroupPanel Pnl_Step4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton Btn_Finished;
    }
}