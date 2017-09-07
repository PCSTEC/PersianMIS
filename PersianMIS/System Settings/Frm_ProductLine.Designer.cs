namespace PersianMIS.System_Settings
{
    partial class Frm_ProductLine
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProductLine));
            this.Grd_ListOfProductLines = new Telerik.WinControls.UI.RadGridView();
            this.ManGroup = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Txt_Description = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_LineCode = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.Btn_Update = new Telerik.WinControls.UI.RadButton();
            this.Btn_Save = new Telerik.WinControls.UI.RadButton();
            this.Txt_Salon = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_MizaneTolid = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_ProductionLine = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ListOfProductLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ListOfProductLines.MasterTemplate)).BeginInit();
            this.ManGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_LineCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Salon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MizaneTolid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProductionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Grd_ListOfProductLines
            // 
            this.Grd_ListOfProductLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.Grd_ListOfProductLines.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grd_ListOfProductLines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grd_ListOfProductLines.EnableCustomSorting = true;
            this.Grd_ListOfProductLines.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Grd_ListOfProductLines.ForeColor = System.Drawing.Color.Black;
            this.Grd_ListOfProductLines.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grd_ListOfProductLines.Location = new System.Drawing.Point(0, 271);
            // 
            // 
            // 
            this.Grd_ListOfProductLines.MasterTemplate.AllowAddNewRow = false;
            this.Grd_ListOfProductLines.MasterTemplate.AllowCellContextMenu = false;
            this.Grd_ListOfProductLines.MasterTemplate.AllowDeleteRow = false;
            this.Grd_ListOfProductLines.MasterTemplate.AllowEditRow = false;
            this.Grd_ListOfProductLines.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable;
            this.Grd_ListOfProductLines.MasterTemplate.ClipboardCutMode = Telerik.WinControls.UI.GridViewClipboardCutMode.Disable;
            this.Grd_ListOfProductLines.MasterTemplate.ClipboardPasteMode = Telerik.WinControls.UI.GridViewClipboardPasteMode.Disable;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "کد";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.FieldName = "ProductLineId";
            gridViewTextBoxColumn2.HeaderText = "کد خط تولیدی";
            gridViewTextBoxColumn2.Name = "ProductLineId";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FieldName = "ProductLineDesc";
            gridViewTextBoxColumn3.HeaderText = "عنوان خط تولیدی";
            gridViewTextBoxColumn3.Name = "ProductLineDesc";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.FieldName = "MizaneTolid";
            gridViewTextBoxColumn4.HeaderText = "میزان تولید";
            gridViewTextBoxColumn4.Name = "MizaneTolid";
            gridViewTextBoxColumn4.Width = 75;
            gridViewTextBoxColumn5.FieldName = "SalonDesc";
            gridViewTextBoxColumn5.HeaderText = "عنوان سالن مربوطه";
            gridViewTextBoxColumn5.Name = "SalonDesc";
            gridViewTextBoxColumn5.Width = 120;
            gridViewTextBoxColumn6.FieldName = "Description";
            gridViewTextBoxColumn6.HeaderText = "توضیحات";
            gridViewTextBoxColumn6.Name = "Description";
            gridViewTextBoxColumn6.Width = 250;
            this.Grd_ListOfProductLines.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.Grd_ListOfProductLines.MasterTemplate.EnableCustomSorting = true;
            this.Grd_ListOfProductLines.MasterTemplate.EnableFiltering = true;
            this.Grd_ListOfProductLines.MasterTemplate.EnableGrouping = false;
            this.Grd_ListOfProductLines.MasterTemplate.ShowChildViewCaptions = true;
            this.Grd_ListOfProductLines.MasterTemplate.ShowFilteringRow = false;
            this.Grd_ListOfProductLines.MasterTemplate.ShowHeaderCellButtons = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "DeviceId";
            this.Grd_ListOfProductLines.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.Grd_ListOfProductLines.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grd_ListOfProductLines.Name = "Grd_ListOfProductLines";
            this.Grd_ListOfProductLines.ReadOnly = true;
            this.Grd_ListOfProductLines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grd_ListOfProductLines.ShowChildViewCaptions = true;
            this.Grd_ListOfProductLines.ShowHeaderCellButtons = true;
            this.Grd_ListOfProductLines.Size = new System.Drawing.Size(652, 360);
            this.Grd_ListOfProductLines.TabIndex = 1;
            this.Grd_ListOfProductLines.RowsChanged += new Telerik.WinControls.UI.GridViewCollectionChangedEventHandler(this.Grd_ListOfProductLines_RowsChanged);
            this.Grd_ListOfProductLines.Click += new System.EventHandler(this.Grd_ListOfProductLines_Click);
            // 
            // ManGroup
            // 
            this.ManGroup.CanvasColor = System.Drawing.SystemColors.Control;
            this.ManGroup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ManGroup.Controls.Add(this.Txt_Description);
            this.ManGroup.Controls.Add(this.radLabel4);
            this.ManGroup.Controls.Add(this.Txt_LineCode);
            this.ManGroup.Controls.Add(this.radLabel3);
            this.ManGroup.Controls.Add(this.groupPanel2);
            this.ManGroup.Controls.Add(this.Txt_Salon);
            this.ManGroup.Controls.Add(this.radLabel2);
            this.ManGroup.Controls.Add(this.Txt_MizaneTolid);
            this.ManGroup.Controls.Add(this.radLabel10);
            this.ManGroup.Controls.Add(this.Txt_ProductionLine);
            this.ManGroup.Controls.Add(this.radLabel1);
            this.ManGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManGroup.Location = new System.Drawing.Point(0, 0);
            this.ManGroup.Name = "ManGroup";
            this.ManGroup.Size = new System.Drawing.Size(652, 271);
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
            this.ManGroup.TabIndex = 2;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_Description.Location = new System.Drawing.Point(125, 168);
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.NullText = "توضیحات";
            this.Txt_Description.Size = new System.Drawing.Size(411, 26);
            this.Txt_Description.TabIndex = 41;
            // 
            // radLabel4
            // 
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel4.Location = new System.Drawing.Point(540, 170);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(54, 24);
            this.radLabel4.TabIndex = 40;
            this.radLabel4.Text = "توضیحات:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_LineCode
            // 
            this.Txt_LineCode.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_LineCode.Location = new System.Drawing.Point(337, 8);
            this.Txt_LineCode.Name = "Txt_LineCode";
            this.Txt_LineCode.NullText = "کد خط تولیدی";
            this.Txt_LineCode.Size = new System.Drawing.Size(198, 26);
            this.Txt_LineCode.TabIndex = 39;
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel3.Location = new System.Drawing.Point(539, 9);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(78, 24);
            this.radLabel3.TabIndex = 38;
            this.radLabel3.Text = "کد خط تولیدی:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.Btn_Delete);
            this.groupPanel2.Controls.Add(this.Btn_Update);
            this.groupPanel2.Controls.Add(this.Btn_Save);
            this.groupPanel2.Location = new System.Drawing.Point(125, 215);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(410, 45);
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
            // Btn_Delete
            // 
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Image = global::PersianMIS.Properties.Resources.Delete_OK;
          //  this.Btn_Delete.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Delete.Location = new System.Drawing.Point(3, 3);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(128, 33);
            this.Btn_Delete.TabIndex = 47;
            this.Btn_Delete.Text = "حذف اطلاعات";
           // this.Btn_Delete.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Image = global::PersianMIS.Properties.Resources.Create_Shift__Okpng;
          //  this.Btn_Update.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Update.Location = new System.Drawing.Point(137, 3);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(128, 33);
            this.Btn_Update.TabIndex = 46;
            this.Btn_Update.Text = "ویرایش اطلاعات";
          //  this.Btn_Update.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.Image = global::PersianMIS.Properties.Resources.save;
            //this.Btn_Save.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_Save.Location = new System.Drawing.Point(271, 3);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(128, 33);
            this.Btn_Save.TabIndex = 45;
            this.Btn_Save.Text = "ذخیره";
           // this.Btn_Save.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Txt_Salon
            // 
            this.Txt_Salon.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_Salon.Location = new System.Drawing.Point(337, 127);
            this.Txt_Salon.Name = "Txt_Salon";
            this.Txt_Salon.NullText = "عنوان سالن مربوطه";
            this.Txt_Salon.Size = new System.Drawing.Size(198, 26);
            this.Txt_Salon.TabIndex = 36;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel2.Location = new System.Drawing.Point(539, 129);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(98, 24);
            this.radLabel2.TabIndex = 35;
            this.radLabel2.Text = "عنوان سالن مربوطه:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_MizaneTolid
            // 
            this.Txt_MizaneTolid.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_MizaneTolid.Location = new System.Drawing.Point(338, 84);
            this.Txt_MizaneTolid.Name = "Txt_MizaneTolid";
            this.Txt_MizaneTolid.NullText = "میزان تولید روزانه";
            this.Txt_MizaneTolid.Size = new System.Drawing.Size(198, 26);
            this.Txt_MizaneTolid.TabIndex = 34;
            // 
            // radLabel10
            // 
            this.radLabel10.BackColor = System.Drawing.Color.Transparent;
            this.radLabel10.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel10.Location = new System.Drawing.Point(540, 86);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(92, 24);
            this.radLabel10.TabIndex = 33;
            this.radLabel10.Text = "میزان تولید روزانه:";
            this.radLabel10.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_ProductionLine
            // 
            this.Txt_ProductionLine.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_ProductionLine.Location = new System.Drawing.Point(337, 45);
            this.Txt_ProductionLine.Name = "Txt_ProductionLine";
            this.Txt_ProductionLine.NullText = "عنوان خط تولیدی";
            this.Txt_ProductionLine.Size = new System.Drawing.Size(198, 26);
            this.Txt_ProductionLine.TabIndex = 32;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(539, 46);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(92, 24);
            this.radLabel1.TabIndex = 31;
            this.radLabel1.Text = "عنوان خط تولیدی:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm_ProductLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 631);
            this.Controls.Add(this.ManGroup);
            this.Controls.Add(this.Grd_ListOfProductLines);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ProductLine";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خطوط تولید";
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ListOfProductLines.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ListOfProductLines)).EndInit();
            this.ManGroup.ResumeLayout(false);
            this.ManGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_LineCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Salon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_MizaneTolid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProductionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView Grd_ListOfProductLines;
        private DevComponents.DotNetBar.Controls.GroupPanel ManGroup;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private Telerik.WinControls.UI.RadTextBox Txt_Salon;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox Txt_MizaneTolid;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        private Telerik.WinControls.UI.RadTextBox Txt_ProductionLine;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton Btn_Save;
        private Telerik.WinControls.UI.RadButton Btn_Delete;
        private Telerik.WinControls.UI.RadButton Btn_Update;
        private Telerik.WinControls.UI.RadTextBox Txt_Description;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox Txt_LineCode;
        private Telerik.WinControls.UI.RadLabel radLabel3;
    }
}
