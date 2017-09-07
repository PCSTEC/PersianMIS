namespace PersianMIS.StationControl
{
    partial class Frm_HomeStationCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HomeStationCreate));
            this.MainPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.Pnl_InputA = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_LineCode = new Telerik.WinControls.UI.RadTextBox();
            this.Lbl_StationCaption = new System.Windows.Forms.Label();
            this.Btn_Save = new Telerik.WinControls.UI.RadButton();
            this.MainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_InputA)).BeginInit();
            this.Pnl_InputA.PanelContainer.SuspendLayout();
            this.Pnl_InputA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_LineCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPnl
            // 
            this.MainPnl.Controls.Add(this.Pnl_InputA);
            this.MainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPnl.Location = new System.Drawing.Point(0, 0);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(744, 697);
            this.MainPnl.TabIndex = 0;
            // 
            // Pnl_InputA
            // 
            this.Pnl_InputA.Location = new System.Drawing.Point(0, 3);
            this.Pnl_InputA.Name = "Pnl_InputA";
            // 
            // Pnl_InputA.PanelContainer
            // 
            this.Pnl_InputA.PanelContainer.Controls.Add(this.Btn_Save);
            this.Pnl_InputA.PanelContainer.Controls.Add(this.numericUpDown1);
            this.Pnl_InputA.PanelContainer.Controls.Add(this.label1);
            this.Pnl_InputA.PanelContainer.Controls.Add(this.Txt_LineCode);
            this.Pnl_InputA.PanelContainer.Controls.Add(this.Lbl_StationCaption);
            this.Pnl_InputA.PanelContainer.Size = new System.Drawing.Size(739, 142);
            this.Pnl_InputA.Size = new System.Drawing.Size(741, 170);
            this.Pnl_InputA.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.numericUpDown1.Location = new System.Drawing.Point(446, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 28);
            this.numericUpDown1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(614, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "تعداد پالس های نمایش :";
            // 
            // Txt_LineCode
            // 
            this.Txt_LineCode.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_LineCode.Location = new System.Drawing.Point(446, 9);
            this.Txt_LineCode.Name = "Txt_LineCode";
            this.Txt_LineCode.NullText = "عنوان ایستگاه";
            this.Txt_LineCode.Size = new System.Drawing.Size(208, 26);
            this.Txt_LineCode.TabIndex = 40;
            // 
            // Lbl_StationCaption
            // 
            this.Lbl_StationCaption.AutoSize = true;
            this.Lbl_StationCaption.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_StationCaption.Location = new System.Drawing.Point(652, 15);
            this.Lbl_StationCaption.Name = "Lbl_StationCaption";
            this.Lbl_StationCaption.Size = new System.Drawing.Size(79, 20);
            this.Lbl_StationCaption.TabIndex = 0;
            this.Lbl_StationCaption.Text = "عنوان ایستگاه:";
            // 
            // Btn_Save
            // 
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.Image = global::PersianMIS.Properties.Resources.save;
            this.Btn_Save.Location = new System.Drawing.Point(295, 98);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(149, 33);
            this.Btn_Save.TabIndex = 46;
            this.Btn_Save.Text = "ذخیره /  ایجاد پالس های";
            // 
            // Frm_HomeStationCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 697);
            this.Controls.Add(this.MainPnl);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_HomeStationCreate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ایجاد ایستگاه  کاری جدید";
            this.Load += new System.EventHandler(this.Frm_HomeStationCreate_Load);
            this.MainPnl.ResumeLayout(false);
            this.Pnl_InputA.PanelContainer.ResumeLayout(false);
            this.Pnl_InputA.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pnl_InputA)).EndInit();
            this.Pnl_InputA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_LineCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainPnl;
        private Telerik.WinControls.UI.RadCollapsiblePanel Pnl_InputA;
        private System.Windows.Forms.Label Lbl_StationCaption;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox Txt_LineCode;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Telerik.WinControls.UI.RadButton Btn_Save;
    }
}