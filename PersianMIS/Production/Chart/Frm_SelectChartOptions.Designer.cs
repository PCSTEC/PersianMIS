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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelectChartOptions));
            this.MainPageView = new Telerik.WinControls.UI.RadPageView();
            this.ChartTypeTab = new Telerik.WinControls.UI.RadPageViewPage();
            this.SelectDataTab = new Telerik.WinControls.UI.RadPageViewPage();
            this.MainTree = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.MainPageView)).BeginInit();
            this.MainPageView.SuspendLayout();
            this.SelectDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPageView
            // 
            this.MainPageView.Controls.Add(this.ChartTypeTab);
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
            // ChartTypeTab
            // 
            this.ChartTypeTab.ItemSize = new System.Drawing.SizeF(86F, 34F);
            this.ChartTypeTab.Location = new System.Drawing.Point(10, 43);
            this.ChartTypeTab.Name = "ChartTypeTab";
            this.ChartTypeTab.Size = new System.Drawing.Size(603, 696);
            this.ChartTypeTab.Text = "تنظیمات چارت";
            // 
            // SelectDataTab
            // 
            this.SelectDataTab.Controls.Add(this.MainTree);
            this.SelectDataTab.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SelectDataTab.ItemSize = new System.Drawing.SizeF(83F, 34F);
            this.SelectDataTab.Location = new System.Drawing.Point(10, 43);
            this.SelectDataTab.Name = "SelectDataTab";
            this.SelectDataTab.Size = new System.Drawing.Size(603, 696);
            this.SelectDataTab.Text = "انتخاب داده ها";
            // 
            // MainTree
            // 
            this.MainTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTree.Location = new System.Drawing.Point(0, 0);
            this.MainTree.Name = "MainTree";
            this.MainTree.Size = new System.Drawing.Size(603, 696);
            this.MainTree.SpacingBetweenNodes = -1;
            this.MainTree.TabIndex = 0;
            this.MainTree.Text = "radTreeView1";
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
            ((System.ComponentModel.ISupportInitialize)(this.MainTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView MainPageView;
        private Telerik.WinControls.UI.RadPageViewPage ChartTypeTab;
        private Telerik.WinControls.UI.RadPageViewPage SelectDataTab;
        private Telerik.WinControls.UI.RadTreeView MainTree;
    }
}
