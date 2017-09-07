namespace PersianMIS.StationControl
{
    partial class CreateParameterFormulaUserControl
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
            this.MainPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.Txt_ParameterCount = new System.Windows.Forms.NumericUpDown();
            this.Lbl_SelectStation = new Telerik.WinControls.UI.RadLabel();
            this.Btn_ShowStation = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ParameterCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_SelectStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_ShowStation)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPnl
            // 
            this.MainPnl.AutoScroll = true;
            this.MainPnl.AutoSize = true;
            this.MainPnl.BackColor = System.Drawing.Color.Transparent;
            this.MainPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainPnl.Location = new System.Drawing.Point(9, 112);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(454, 358);
            this.MainPnl.TabIndex = 46;
            this.MainPnl.WrapContents = false;
            // 
            // Txt_ParameterCount
            // 
            this.Txt_ParameterCount.Location = new System.Drawing.Point(276, 13);
            this.Txt_ParameterCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Txt_ParameterCount.Name = "Txt_ParameterCount";
            this.Txt_ParameterCount.Size = new System.Drawing.Size(106, 28);
            this.Txt_ParameterCount.TabIndex = 48;
            this.Txt_ParameterCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_SelectStation
            // 
            this.Lbl_SelectStation.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_SelectStation.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl_SelectStation.Location = new System.Drawing.Point(388, 17);
            this.Lbl_SelectStation.Name = "Lbl_SelectStation";
            this.Lbl_SelectStation.Size = new System.Drawing.Size(70, 24);
            this.Lbl_SelectStation.TabIndex = 47;
            this.Lbl_SelectStation.Text = "تعداد پارامتر :";
            this.Lbl_SelectStation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Btn_ShowStation
            // 
            this.Btn_ShowStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ShowStation.Image = global::PersianMIS.Properties.Resources.create_Production_Line1;
            this.Btn_ShowStation.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_ShowStation.Location = new System.Drawing.Point(162, 61);
            this.Btn_ShowStation.Name = "Btn_ShowStation";
            this.Btn_ShowStation.Size = new System.Drawing.Size(81, 45);
            this.Btn_ShowStation.TabIndex = 50;
            this.Btn_ShowStation.Click += new System.EventHandler(this.Btn_ShowStation_Click);
            // 
            // CreateParameterFormulaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_ShowStation);
            this.Controls.Add(this.MainPnl);
            this.Controls.Add(this.Txt_ParameterCount);
            this.Controls.Add(this.Lbl_SelectStation);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateParameterFormulaUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(467, 474);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ParameterCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_SelectStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_ShowStation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton Btn_ShowStation;
        private System.Windows.Forms.FlowLayoutPanel MainPnl;
        private System.Windows.Forms.NumericUpDown Txt_ParameterCount;
        private Telerik.WinControls.UI.RadLabel Lbl_SelectStation;
    }
}
