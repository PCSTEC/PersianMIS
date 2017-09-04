namespace PersianMIS.StationControl
{
    partial class CreatePulsStationUserControl
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
            this.Lbl_StationPulsCount = new Telerik.WinControls.UI.RadLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_StationCaption = new Telerik.WinControls.UI.RadTextBox();
            this.ManGroup = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_Save = new Janus.Windows.EditControls.UIButton();
            this.Pnl_SelectStation = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Lbl_SelectStation = new Telerik.WinControls.UI.RadLabel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_ShowStation = new Janus.Windows.EditControls.UIButton();
            this.Cmb_SelectStation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.MainPnl = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_StationPulsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationCaption)).BeginInit();
            this.ManGroup.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.Pnl_SelectStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_SelectStation)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_StationPulsCount
            // 
            this.Lbl_StationPulsCount.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_StationPulsCount.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_StationPulsCount.Location = new System.Drawing.Point(743, 70);
            this.Lbl_StationPulsCount.Name = "Lbl_StationPulsCount";
            this.Lbl_StationPulsCount.Size = new System.Drawing.Size(123, 24);
            this.Lbl_StationPulsCount.TabIndex = 0;
            this.Lbl_StationPulsCount.Text = "تعداد پالس های ایستگاه :";
            this.Lbl_StationPulsCount.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(551, 66);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(186, 28);
            this.numericUpDown1.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(743, 19);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(79, 24);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "عنوان ایستگاه :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_StationCaption
            // 
            this.Txt_StationCaption.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_StationCaption.Location = new System.Drawing.Point(551, 17);
            this.Txt_StationCaption.Name = "Txt_StationCaption";
            this.Txt_StationCaption.NullText = "عنوان ایستگاه";
            this.Txt_StationCaption.Size = new System.Drawing.Size(186, 26);
            this.Txt_StationCaption.TabIndex = 40;
            // 
            // ManGroup
            // 
            this.ManGroup.CanvasColor = System.Drawing.SystemColors.Control;
            this.ManGroup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ManGroup.Controls.Add(this.Txt_StationCaption);
            this.ManGroup.Controls.Add(this.radLabel1);
            this.ManGroup.Controls.Add(this.groupPanel2);
            this.ManGroup.Controls.Add(this.numericUpDown1);
            this.ManGroup.Controls.Add(this.Lbl_StationPulsCount);
            this.ManGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManGroup.Location = new System.Drawing.Point(0, 0);
            this.ManGroup.Name = "ManGroup";
            this.ManGroup.Size = new System.Drawing.Size(881, 180);
            // 
            // 
            // 
            this.ManGroup.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.ManGroup.Style.BackColorGradientAngle = 90;
            this.ManGroup.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ManGroup.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ManGroup.Style.BorderBottomWidth = 1;
            this.ManGroup.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ManGroup.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ManGroup.Style.BorderLeftWidth = 1;
            this.ManGroup.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ManGroup.Style.BorderRightWidth = 1;
            this.ManGroup.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ManGroup.Style.BorderTopWidth = 1;
            this.ManGroup.Style.CornerDiameter = 4;
            this.ManGroup.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ManGroup.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ManGroup.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.ManGroup.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.ManGroup.TabIndex = 4;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.Btn_Save);
            this.groupPanel2.Location = new System.Drawing.Point(398, 111);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(188, 45);
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
            this.groupPanel2.TabIndex = 37;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.Image = global::PersianMIS.Properties.Resources.save;
            this.Btn_Save.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Save.Location = new System.Drawing.Point(3, 3);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(173, 33);
            this.Btn_Save.TabIndex = 45;
            this.Btn_Save.Text = "ذخیره / ایجاد ایستگاه ها ";
            this.Btn_Save.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010;
            // 
            // Pnl_SelectStation
            // 
            this.Pnl_SelectStation.CanvasColor = System.Drawing.SystemColors.Control;
            this.Pnl_SelectStation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Pnl_SelectStation.Controls.Add(this.Cmb_SelectStation);
            this.Pnl_SelectStation.Controls.Add(this.Lbl_SelectStation);
            this.Pnl_SelectStation.Controls.Add(this.groupPanel3);
            this.Pnl_SelectStation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SelectStation.Location = new System.Drawing.Point(0, 180);
            this.Pnl_SelectStation.Name = "Pnl_SelectStation";
            this.Pnl_SelectStation.Size = new System.Drawing.Size(881, 117);
            // 
            // 
            // 
            this.Pnl_SelectStation.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Pnl_SelectStation.Style.BackColorGradientAngle = 90;
            this.Pnl_SelectStation.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Pnl_SelectStation.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_SelectStation.Style.BorderBottomWidth = 1;
            this.Pnl_SelectStation.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Pnl_SelectStation.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_SelectStation.Style.BorderLeftWidth = 1;
            this.Pnl_SelectStation.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_SelectStation.Style.BorderRightWidth = 1;
            this.Pnl_SelectStation.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Pnl_SelectStation.Style.BorderTopWidth = 1;
            this.Pnl_SelectStation.Style.CornerDiameter = 4;
            this.Pnl_SelectStation.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Pnl_SelectStation.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Pnl_SelectStation.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Pnl_SelectStation.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.Pnl_SelectStation.TabIndex = 5;
            // 
            // Lbl_SelectStation
            // 
            this.Lbl_SelectStation.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_SelectStation.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_SelectStation.Location = new System.Drawing.Point(743, 16);
            this.Lbl_SelectStation.Name = "Lbl_SelectStation";
            this.Lbl_SelectStation.Size = new System.Drawing.Size(70, 24);
            this.Lbl_SelectStation.TabIndex = 2;
            this.Lbl_SelectStation.Text = "انتخاب پالس :";
            this.Lbl_SelectStation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.Btn_ShowStation);
            this.groupPanel3.Location = new System.Drawing.Point(398, 58);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(188, 45);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 37;
            // 
            // Btn_ShowStation
            // 
            this.Btn_ShowStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ShowStation.Image = global::PersianMIS.Properties.Resources.save;
            this.Btn_ShowStation.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_ShowStation.Location = new System.Drawing.Point(3, 3);
            this.Btn_ShowStation.Name = "Btn_ShowStation";
            this.Btn_ShowStation.Size = new System.Drawing.Size(173, 33);
            this.Btn_ShowStation.TabIndex = 45;
            this.Btn_ShowStation.Text = "ایجاد / ویرایش ایستگاه";
            this.Btn_ShowStation.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010;
            // 
            // Cmb_SelectStation
            // 
            this.Cmb_SelectStation.DisplayMember = "Text";
            this.Cmb_SelectStation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_SelectStation.FormattingEnabled = true;
            this.Cmb_SelectStation.ItemHeight = 22;
            this.Cmb_SelectStation.Location = new System.Drawing.Point(551, 12);
            this.Cmb_SelectStation.Name = "Cmb_SelectStation";
            this.Cmb_SelectStation.Size = new System.Drawing.Size(186, 28);
            this.Cmb_SelectStation.TabIndex = 45;
            this.Cmb_SelectStation.Text = "پالس مورد نظرخود را انتخاب نمایید";
            // 
            // MainPnl
            // 
            this.MainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPnl.Location = new System.Drawing.Point(0, 297);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(881, 381);
            this.MainPnl.TabIndex = 6;
            // 
            // CreatePulsStationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPnl);
            this.Controls.Add(this.Pnl_SelectStation);
            this.Controls.Add(this.ManGroup);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePulsStationUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(881, 678);
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_StationPulsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationCaption)).EndInit();
            this.ManGroup.ResumeLayout(false);
            this.ManGroup.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.Pnl_SelectStation.ResumeLayout(false);
            this.Pnl_SelectStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_SelectStation)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel Lbl_StationPulsCount;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Telerik.WinControls.UI.RadTextBox Txt_StationCaption;
        private DevComponents.DotNetBar.Controls.GroupPanel ManGroup;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Janus.Windows.EditControls.UIButton Btn_Save;
        private DevComponents.DotNetBar.Controls.GroupPanel Pnl_SelectStation;
        private Telerik.WinControls.UI.RadLabel Lbl_SelectStation;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private Janus.Windows.EditControls.UIButton Btn_ShowStation;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Cmb_SelectStation;
        private System.Windows.Forms.FlowLayoutPanel MainPnl;
    }
}
