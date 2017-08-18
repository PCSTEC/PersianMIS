namespace PersianMIS.StationControl
{
    partial class Frm_CreateStationWithFormula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CreateStationWithFormula));
            this.GpHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlMain = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_StationCaption4 = new Telerik.WinControls.UI.RadTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Txt_Description = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ImgHome = new System.Windows.Forms.PictureBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_Save = new Janus.Windows.EditControls.UIButton();
            this.GpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).BeginInit();
            this.PnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationCaption4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GpHeader
            // 
            this.GpHeader.AutoScroll = true;
            this.GpHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.GpHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GpHeader.Controls.Add(this.ImgHome);
            this.GpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.GpHeader.Location = new System.Drawing.Point(0, 0);
            this.GpHeader.Name = "GpHeader";
            this.GpHeader.Size = new System.Drawing.Size(1399, 77);
            this.GpHeader.TabIndex = 0;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.PnlMain.Controls.Add(this.groupPanel2);
            this.PnlMain.Controls.Add(this.Txt_Description);
            this.PnlMain.Controls.Add(this.radLabel4);
            this.PnlMain.Controls.Add(this.numericUpDown1);
            this.PnlMain.Controls.Add(this.Txt_StationCaption4);
            this.PnlMain.Controls.Add(this.radLabel2);
            this.PnlMain.Controls.Add(this.radLabel1);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 77);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1399, 271);
            this.PnlMain.TabIndex = 1;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(1199, 96);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(173, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "تعداد پارامتر های ایستگاه مورد نظر :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(1251, 34);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(121, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "عنوان ایستگاه مورد نظر :";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_StationCaption4
            // 
            this.Txt_StationCaption4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_StationCaption4.Location = new System.Drawing.Point(954, 26);
            this.Txt_StationCaption4.Name = "Txt_StationCaption4";
            this.Txt_StationCaption4.NullText = "عنوان ایستگاه مورد نظر";
            this.Txt_StationCaption4.Size = new System.Drawing.Size(240, 26);
            this.Txt_StationCaption4.TabIndex = 40;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(953, 89);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 28);
            this.numericUpDown1.TabIndex = 41;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_Description.Location = new System.Drawing.Point(588, 145);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.NullText = "توضیحات";
            this.Txt_Description.Size = new System.Drawing.Size(606, 26);
            this.Txt_Description.TabIndex = 43;
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.Location = new System.Drawing.Point(1318, 147);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(54, 24);
            this.radLabel4.TabIndex = 42;
            this.radLabel4.Text = "توضیحات:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // ImgHome
            // 
            this.ImgHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgHome.Image = global::PersianMIS.Properties.Resources.StartProgressStep;
            this.ImgHome.Location = new System.Drawing.Point(1323, 3);
            this.ImgHome.Name = "ImgHome";
            this.ImgHome.Size = new System.Drawing.Size(73, 64);
            this.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgHome.TabIndex = 1;
            this.ImgHome.TabStop = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.Btn_Save);
            this.groupPanel2.Location = new System.Drawing.Point(909, 198);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(175, 45);
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
            this.groupPanel2.TabIndex = 44;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.Image = global::PersianMIS.Properties.Resources.save;
            this.Btn_Save.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Save.Location = new System.Drawing.Point(3, 3);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(159, 33);
            this.Btn_Save.TabIndex = 45;
            this.Btn_Save.Text = "ایجاد ایستگاه مورد نظر";
            this.Btn_Save.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010;
            // 
            // Frm_CreateStationWithFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 348);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.GpHeader);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_CreateStationWithFormula";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایجاد ایستگاه های کاری";
            this.GpHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlMain)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationCaption4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GpHeader;
        private System.Windows.Forms.PictureBox ImgHome;
        private Telerik.WinControls.UI.RadPanel PnlMain;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox Txt_StationCaption4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Telerik.WinControls.UI.RadTextBox Txt_Description;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Janus.Windows.EditControls.UIButton Btn_Save;
    }
}