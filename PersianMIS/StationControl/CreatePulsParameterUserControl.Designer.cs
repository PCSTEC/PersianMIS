namespace PersianMIS.StationControl
{
    partial class CreatePulsParameterUserControl
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
            this.lbl_PulsNumber = new System.Windows.Forms.Label();
            this.Txt_ParameterCount = new System.Windows.Forms.NumericUpDown();
            this.Lbl_SelectStation = new Telerik.WinControls.UI.RadLabel();
            this.Btn_ShowStation = new Janus.Windows.EditControls.UIButton();
            this.MainPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ParameterCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_SelectStation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PulsNumber
            // 
            this.lbl_PulsNumber.AutoSize = true;
            this.lbl_PulsNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PulsNumber.Location = new System.Drawing.Point(-1, 24);
            this.lbl_PulsNumber.Name = "lbl_PulsNumber";
            this.lbl_PulsNumber.Size = new System.Drawing.Size(70, 20);
            this.lbl_PulsNumber.TabIndex = 39;
            this.lbl_PulsNumber.Text = "پالس شماره 0";
            // 
            // Txt_ParameterCount
            // 
            this.Txt_ParameterCount.Location = new System.Drawing.Point(277, 16);
            this.Txt_ParameterCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Txt_ParameterCount.Name = "Txt_ParameterCount";
            this.Txt_ParameterCount.Size = new System.Drawing.Size(106, 28);
            this.Txt_ParameterCount.TabIndex = 38;
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
            this.Lbl_SelectStation.Location = new System.Drawing.Point(389, 20);
            this.Lbl_SelectStation.Name = "Lbl_SelectStation";
            this.Lbl_SelectStation.Size = new System.Drawing.Size(70, 24);
            this.Lbl_SelectStation.TabIndex = 2;
            this.Lbl_SelectStation.Text = "تعداد پارامتر :";
            this.Lbl_SelectStation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Btn_ShowStation
            // 
            this.Btn_ShowStation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ShowStation.Image = global::PersianMIS.Properties.Resources.create_Production_Line1;
            this.Btn_ShowStation.ImageSize = new System.Drawing.Size(40, 40);
            this.Btn_ShowStation.Location = new System.Drawing.Point(188, 59);
            this.Btn_ShowStation.Name = "Btn_ShowStation";
            this.Btn_ShowStation.Size = new System.Drawing.Size(62, 52);
            this.Btn_ShowStation.TabIndex = 45;
            this.Btn_ShowStation.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010;
            this.Btn_ShowStation.Click += new System.EventHandler(this.Btn_ShowStation_Click);
            // 
            // MainPnl
            // 
            this.MainPnl.AutoScroll = true;
            this.MainPnl.AutoSize = true;
            this.MainPnl.BackColor = System.Drawing.Color.Transparent;
            this.MainPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainPnl.Location = new System.Drawing.Point(76, 187);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(456, 603);
            this.MainPnl.TabIndex = 0;
            this.MainPnl.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Btn_ShowStation);
            this.panel1.Controls.Add(this.Txt_ParameterCount);
            this.panel1.Controls.Add(this.lbl_PulsNumber);
            this.panel1.Controls.Add(this.Lbl_SelectStation);
            this.panel1.Location = new System.Drawing.Point(17, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 121);
            this.panel1.TabIndex = 8;
            // 
            // CreatePulsParameterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.MainPnl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePulsParameterUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(512, 729);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ParameterCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lbl_SelectStation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel Lbl_SelectStation;
        private Janus.Windows.EditControls.UIButton Btn_ShowStation;
        private System.Windows.Forms.Label lbl_PulsNumber;
        private System.Windows.Forms.NumericUpDown Txt_ParameterCount;
        private System.Windows.Forms.FlowLayoutPanel MainPnl;
        private System.Windows.Forms.Panel panel1;
    }
}
