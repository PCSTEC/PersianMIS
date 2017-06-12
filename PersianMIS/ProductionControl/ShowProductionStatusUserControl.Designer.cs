namespace PersianMIS.ProductionControl
{
    partial class ShowProductionStatusUserControl
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
            this.GantViewMain = new Telerik.WinControls.UI.RadGanttView();
            ((System.ComponentModel.ISupportInitialize)(this.GantViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // GantViewMain
            // 
            this.GantViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GantViewMain.Location = new System.Drawing.Point(0, 0);
            this.GantViewMain.Name = "GantViewMain";
            this.GantViewMain.Size = new System.Drawing.Size(1079, 595);
            this.GantViewMain.SplitterWidth = 7;
            this.GantViewMain.TabIndex = 0;
            this.GantViewMain.Text = "radGanttView1";
            // 
            // ShowProductionStatusUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GantViewMain);
            this.Name = "ShowProductionStatusUserControl";
            this.Size = new System.Drawing.Size(1079, 595);
            ((System.ComponentModel.ISupportInitialize)(this.GantViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGanttView GantViewMain;
    }
}
