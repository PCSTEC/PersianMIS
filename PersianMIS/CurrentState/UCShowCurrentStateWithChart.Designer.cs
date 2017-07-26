namespace PersianMIS.CurrentState
{
    partial class UCShowCurrentStateWithChart
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
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            Telerik.WinControls.UI.CategoricalAxis categoricalAxis1 = new Telerik.WinControls.UI.CategoricalAxis();
            Telerik.WinControls.UI.LinearAxis linearAxis1 = new Telerik.WinControls.UI.LinearAxis();
            this.MainChart = new Telerik.WinControls.UI.RadChartView();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.MainChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            this.MainChart.AreaDesign = cartesianArea1;
            categoricalAxis1.IsPrimary = true;
            linearAxis1.AxisType = Telerik.Charting.AxisType.Second;
            linearAxis1.IsPrimary = true;
            linearAxis1.TickOrigin = null;
            this.MainChart.Axes.AddRange(new Telerik.WinControls.UI.Axis[] {
            categoricalAxis1,
            linearAxis1});
            this.MainChart.Controls.Add(this.radCheckBox1);
            this.MainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainChart.Location = new System.Drawing.Point(0, 0);
            this.MainChart.Name = "MainChart";
            this.MainChart.ShowGrid = false;
            this.MainChart.ShowPanZoom = true;
            this.MainChart.ShowToolTip = true;
            this.MainChart.ShowTrackBall = true;
            this.MainChart.Size = new System.Drawing.Size(792, 700);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "radChartView1";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(124, 87);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(91, 18);
            this.radCheckBox1.TabIndex = 0;
            this.radCheckBox1.Text = "radCheckBox1";
            this.radCheckBox1.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radCheckBox1_ToggleStateChanged);
            // 
            // UCShowCurrentStateWithChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainChart);
            this.Name = "UCShowCurrentStateWithChart";
            this.Size = new System.Drawing.Size(792, 700);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.MainChart.ResumeLayout(false);
            this.MainChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView MainChart;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
    }
}
