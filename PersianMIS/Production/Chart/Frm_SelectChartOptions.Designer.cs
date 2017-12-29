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
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelectChartOptions));
            this.MainPageView = new Telerik.WinControls.UI.RadPageView();
            this.SelectDataTab = new Telerik.WinControls.UI.RadPageViewPage();
            this.Btn_Save = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ChartTitle = new Telerik.WinControls.UI.RadTextBox();
            this.Lbl_ChartCaption = new System.Windows.Forms.Label();
            this.MainTree = new Telerik.WinControls.UI.RadTreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_ChartType = new Telerik.WinControls.UI.RadDropDownList();
            this.Cmb_FieldShowType = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageView)).BeginInit();
            this.MainPageView.SuspendLayout();
            this.SelectDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ChartTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_ChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_FieldShowType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPageView
            // 
            this.MainPageView.Controls.Add(this.SelectDataTab);
            this.MainPageView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageView.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.MainPageView.Location = new System.Drawing.Point(0, 0);
            this.MainPageView.Name = "MainPageView";
            this.MainPageView.SelectedPage = this.SelectDataTab;
            this.MainPageView.Size = new System.Drawing.Size(624, 750);
            this.MainPageView.TabIndex = 0;
            this.MainPageView.Text = "radPageView1";
            // 
            // SelectDataTab
            // 
            this.SelectDataTab.Controls.Add(this.Cmb_FieldShowType);
            this.SelectDataTab.Controls.Add(this.Cmb_ChartType);
            this.SelectDataTab.Controls.Add(this.label2);
            this.SelectDataTab.Controls.Add(this.Btn_Save);
            this.SelectDataTab.Controls.Add(this.label1);
            this.SelectDataTab.Controls.Add(this.Txt_ChartTitle);
            this.SelectDataTab.Controls.Add(this.Lbl_ChartCaption);
            this.SelectDataTab.Controls.Add(this.MainTree);
            this.SelectDataTab.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SelectDataTab.ItemSize = new System.Drawing.SizeF(88F, 34F);
            this.SelectDataTab.Location = new System.Drawing.Point(10, 43);
            this.SelectDataTab.Name = "SelectDataTab";
            this.SelectDataTab.Size = new System.Drawing.Size(603, 696);
            this.SelectDataTab.Text = "تنظیمات نمودار";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.Image = global::PersianMIS.Properties.Resources.save;
            this.Btn_Save.Location = new System.Drawing.Point(235, 648);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(138, 33);
            this.Btn_Save.TabIndex = 59;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "نوع نمودار:";
            // 
            // Txt_ChartTitle
            // 
            this.Txt_ChartTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ChartTitle.Location = new System.Drawing.Point(354, 14);
            this.Txt_ChartTitle.Name = "Txt_ChartTitle";
            this.Txt_ChartTitle.Size = new System.Drawing.Size(177, 23);
            this.Txt_ChartTitle.TabIndex = 56;
            // 
            // Lbl_ChartCaption
            // 
            this.Lbl_ChartCaption.AutoSize = true;
            this.Lbl_ChartCaption.Location = new System.Drawing.Point(528, 14);
            this.Lbl_ChartCaption.Name = "Lbl_ChartCaption";
            this.Lbl_ChartCaption.Size = new System.Drawing.Size(71, 20);
            this.Lbl_ChartCaption.TabIndex = 55;
            this.Lbl_ChartCaption.Text = "عنوان نمودار:";
            // 
            // MainTree
            // 
            this.MainTree.Location = new System.Drawing.Point(3, 122);
            this.MainTree.Name = "MainTree";
            this.MainTree.Size = new System.Drawing.Size(600, 514);
            this.MainTree.SpacingBetweenNodes = -1;
            this.MainTree.TabIndex = 0;
            this.MainTree.Text = "radTreeView1";
            this.MainTree.NodeCheckedChanged += new Telerik.WinControls.UI.TreeNodeCheckedEventHandler(this.MainTree_NodeCheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "عنوان فیلد ها :";
            // 
            // Cmb_ChartType
            // 
            this.Cmb_ChartType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem3.Text = "Cartesian";
            radListDataItem4.Text = "Polar";
            radListDataItem5.Text = "Pie";
            radListDataItem6.Tag = "Funnel";
            radListDataItem6.Text = "Funnel";
            this.Cmb_ChartType.Items.Add(radListDataItem3);
            this.Cmb_ChartType.Items.Add(radListDataItem4);
            this.Cmb_ChartType.Items.Add(radListDataItem5);
            this.Cmb_ChartType.Items.Add(radListDataItem6);
            this.Cmb_ChartType.Location = new System.Drawing.Point(354, 51);
            this.Cmb_ChartType.Name = "Cmb_ChartType";
            this.Cmb_ChartType.NullText = "نوع نمودار را انتخاب کنید";
            this.Cmb_ChartType.Size = new System.Drawing.Size(177, 26);
            this.Cmb_ChartType.TabIndex = 62;
            // 
            // Cmb_FieldShowType
            // 
            this.Cmb_FieldShowType.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            radListDataItem1.Tag = "0";
            radListDataItem1.Text = "عنوان اصلی فیلد";
            radListDataItem2.Tag = "1";
            radListDataItem2.Text = "ترکیبی (عنوان اصلی + عنوان ماشین(";
            this.Cmb_FieldShowType.Items.Add(radListDataItem1);
            this.Cmb_FieldShowType.Items.Add(radListDataItem2);
            this.Cmb_FieldShowType.Location = new System.Drawing.Point(354, 83);
            this.Cmb_FieldShowType.Name = "Cmb_FieldShowType";
            this.Cmb_FieldShowType.NullText = "نحوه نمایش عنوان فیلد ";
            this.Cmb_FieldShowType.Size = new System.Drawing.Size(177, 26);
            this.Cmb_FieldShowType.TabIndex = 63;
            // 
            // Frm_SelectChartOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 750);
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
            this.SelectDataTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ChartTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_ChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_FieldShowType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView MainPageView;
        private Telerik.WinControls.UI.RadPageViewPage SelectDataTab;
        private Telerik.WinControls.UI.RadTreeView MainTree;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox Txt_ChartTitle;
        private System.Windows.Forms.Label Lbl_ChartCaption;
        private Telerik.WinControls.UI.RadButton Btn_Save;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList Cmb_FieldShowType;
        private Telerik.WinControls.UI.RadDropDownList Cmb_ChartType;
    }
}
