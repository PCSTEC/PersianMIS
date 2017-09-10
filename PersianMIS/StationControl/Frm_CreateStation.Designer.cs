namespace PersianMIS.StationControl
{
    partial class Frm_CreateStation
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CreateStation));
            this.ManGroup = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Grd_ListOfStation = new Telerik.WinControls.UI.RadGridView();
            this.Txt_StationName = new Telerik.WinControls.UI.RadTextBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.Btn_Update = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ManGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ListOfStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ListOfStation.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationName)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ManGroup
            // 
            this.ManGroup.CanvasColor = System.Drawing.SystemColors.Control;
            this.ManGroup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ManGroup.Controls.Add(this.Grd_ListOfStation);
            this.ManGroup.Controls.Add(this.Txt_StationName);
            this.ManGroup.Controls.Add(this.groupPanel2);
            this.ManGroup.Controls.Add(this.radLabel1);
            this.ManGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManGroup.Location = new System.Drawing.Point(0, 0);
            this.ManGroup.Name = "ManGroup";
            this.ManGroup.Size = new System.Drawing.Size(426, 439);
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
            this.ManGroup.TabIndex = 3;
            // 
            // Grd_ListOfStation
            // 
            this.Grd_ListOfStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.Grd_ListOfStation.Cursor = System.Windows.Forms.Cursors.Default;
            this.Grd_ListOfStation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Grd_ListOfStation.EnableCustomSorting = true;
            this.Grd_ListOfStation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Grd_ListOfStation.ForeColor = System.Drawing.Color.Black;
            this.Grd_ListOfStation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grd_ListOfStation.Location = new System.Drawing.Point(0, 115);
            // 
            // 
            // 
            this.Grd_ListOfStation.MasterTemplate.AllowAddNewRow = false;
            this.Grd_ListOfStation.MasterTemplate.AllowCellContextMenu = false;
            this.Grd_ListOfStation.MasterTemplate.AllowDeleteRow = false;
            this.Grd_ListOfStation.MasterTemplate.AllowEditRow = false;
            this.Grd_ListOfStation.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable;
            this.Grd_ListOfStation.MasterTemplate.ClipboardCutMode = Telerik.WinControls.UI.GridViewClipboardCutMode.Disable;
            this.Grd_ListOfStation.MasterTemplate.ClipboardPasteMode = Telerik.WinControls.UI.GridViewClipboardPasteMode.Disable;
            gridViewTextBoxColumn1.FieldName = "StationId";
            gridViewTextBoxColumn1.HeaderText = "کد";
            gridViewTextBoxColumn1.Name = "StationId";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "StationName";
            gridViewTextBoxColumn2.HeaderText = "عنوان ایستگاه";
            gridViewTextBoxColumn2.Name = "StationName";
            gridViewTextBoxColumn2.Width = 300;
            this.Grd_ListOfStation.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.Grd_ListOfStation.MasterTemplate.EnableCustomSorting = true;
            this.Grd_ListOfStation.MasterTemplate.EnableFiltering = true;
            this.Grd_ListOfStation.MasterTemplate.EnableGrouping = false;
            this.Grd_ListOfStation.MasterTemplate.ShowChildViewCaptions = true;
            this.Grd_ListOfStation.MasterTemplate.ShowFilteringRow = false;
            this.Grd_ListOfStation.MasterTemplate.ShowHeaderCellButtons = true;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "DeviceId";
            this.Grd_ListOfStation.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.Grd_ListOfStation.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grd_ListOfStation.Name = "Grd_ListOfStation";
            this.Grd_ListOfStation.ReadOnly = true;
            this.Grd_ListOfStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grd_ListOfStation.ShowChildViewCaptions = true;
            this.Grd_ListOfStation.ShowHeaderCellButtons = true;
            this.Grd_ListOfStation.Size = new System.Drawing.Size(420, 318);
            this.Grd_ListOfStation.TabIndex = 45;
            this.Grd_ListOfStation.Click += new System.EventHandler(this.Grd_ListOfStation_Click);
            // 
            // Txt_StationName
            // 
            this.Txt_StationName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_StationName.Location = new System.Drawing.Point(117, 9);
            this.Txt_StationName.Name = "Txt_StationName";
            this.Txt_StationName.NullText = "عنوان ایستگاه کاری";
            this.Txt_StationName.Size = new System.Drawing.Size(198, 26);
            this.Txt_StationName.TabIndex = 39;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.Btn_Delete);
            this.groupPanel2.Controls.Add(this.Btn_Update);
            this.groupPanel2.Location = new System.Drawing.Point(3, 64);
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
            this.Btn_Delete.Location = new System.Drawing.Point(31, 3);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(142, 33);
            this.Btn_Delete.TabIndex = 47;
            this.Btn_Delete.Text = "حذف اطلاعات";
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Image = global::PersianMIS.Properties.Resources.Create_Shift__Okpng;
            this.Btn_Update.Location = new System.Drawing.Point(220, 3);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(128, 33);
            this.Btn_Update.TabIndex = 46;
            this.Btn_Update.Text = "ویرایش اطلاعات";
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Update.GetChildAt(0))).Image = global::PersianMIS.Properties.Resources.Create_Shift__Okpng;
            ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Update.GetChildAt(0))).Text = "ویرایش اطلاعات";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.Btn_Update.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchHorizontally = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.Btn_Update.GetChildAt(0).GetChildAt(1).GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.Btn_Update.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.None;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.Btn_Update.GetChildAt(0).GetChildAt(1).GetChildAt(0))).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radLabel1.Location = new System.Drawing.Point(321, 11);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(76, 24);
            this.radLabel1.TabIndex = 31;
            this.radLabel1.Text = "عنوان ایستگاه:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm_CreateStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 439);
            this.Controls.Add(this.ManGroup);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_CreateStation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش ایستگاه های کاری";
            this.Load += new System.EventHandler(this.Frm_CreateStation_Load);
            this.ManGroup.ResumeLayout(false);
            this.ManGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ListOfStation.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_ListOfStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_StationName)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel ManGroup;
        private Telerik.WinControls.UI.RadTextBox Txt_StationName;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private   Telerik.WinControls.UI.RadButton  Btn_Delete;
        private Telerik.WinControls.UI.RadButton Btn_Update;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGridView Grd_ListOfStation;
    }
}
