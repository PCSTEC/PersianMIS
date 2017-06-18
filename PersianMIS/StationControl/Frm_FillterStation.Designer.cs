namespace PersianMIS.StationControl
{
    partial class Frm_FillterStation
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.Cmb_Shift = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MskEndTime = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_ProductLine = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Lbl_ProductLine = new System.Windows.Forms.Label();
            this.Btn_OK = new Janus.Windows.EditControls.UIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MskBeginTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNextDayNumber = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNextDayNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.TxtNextDayNumber);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.Cmb_Shift);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.MskEndTime);
            this.groupPanel1.Controls.Add(this.Cmb_ProductLine);
            this.groupPanel1.Controls.Add(this.Lbl_ProductLine);
            this.groupPanel1.Controls.Add(this.Btn_OK);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.MskBeginTime);
            this.groupPanel1.Controls.Add(this.MskDate);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(498, 185);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            // 
            // Cmb_Shift
            // 
            this.Cmb_Shift.DisplayMember = "Text";
            this.Cmb_Shift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_Shift.FormattingEnabled = true;
            this.Cmb_Shift.ItemHeight = 14;
            this.Cmb_Shift.Location = new System.Drawing.Point(31, 93);
            this.Cmb_Shift.Name = "Cmb_Shift";
            this.Cmb_Shift.Size = new System.Drawing.Size(137, 20);
            this.Cmb_Shift.TabIndex = 53;
            this.Cmb_Shift.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(174, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "شیفت:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(113, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 51;
            this.label3.Text = "لغایت:";
            // 
            // MskEndTime
            // 
            this.MskEndTime.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MskEndTime.Location = new System.Drawing.Point(31, 11);
            this.MskEndTime.Mask = "##:##:##";
            this.MskEndTime.Name = "MskEndTime";
            this.MskEndTime.Size = new System.Drawing.Size(75, 28);
            this.MskEndTime.TabIndex = 50;
            this.MskEndTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskEndTime_KeyPress);
            // 
            // Cmb_ProductLine
            // 
            this.Cmb_ProductLine.DisplayMember = "Text";
            this.Cmb_ProductLine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_ProductLine.FormattingEnabled = true;
            this.Cmb_ProductLine.ItemHeight = 14;
            this.Cmb_ProductLine.Location = new System.Drawing.Point(261, 93);
            this.Cmb_ProductLine.Name = "Cmb_ProductLine";
            this.Cmb_ProductLine.Size = new System.Drawing.Size(137, 20);
            this.Cmb_ProductLine.TabIndex = 49;
            this.Cmb_ProductLine.Visible = false;
            // 
            // Lbl_ProductLine
            // 
            this.Lbl_ProductLine.AutoSize = true;
            this.Lbl_ProductLine.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ProductLine.Location = new System.Drawing.Point(404, 93);
            this.Lbl_ProductLine.Name = "Lbl_ProductLine";
            this.Lbl_ProductLine.Size = new System.Drawing.Size(67, 26);
            this.Lbl_ProductLine.TabIndex = 48;
            this.Lbl_ProductLine.Text = "خط تولید:";
            this.Lbl_ProductLine.Visible = false;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OK.Image = global::PersianMIS.Properties.Resources.RUN_OK;
            this.Btn_OK.ImageSize = new System.Drawing.Size(25, 25);
            this.Btn_OK.Location = new System.Drawing.Point(157, 139);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(128, 33);
            this.Btn_OK.TabIndex = 47;
            this.Btn_OK.Text = "تایید";
            this.Btn_OK.VisualStyle = Janus.Windows.UI.VisualStyle.VS2010;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(245, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "از ساعت :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(426, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "تاریخ:";
            // 
            // MskBeginTime
            // 
            this.MskBeginTime.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MskBeginTime.Location = new System.Drawing.Point(171, 10);
            this.MskBeginTime.Mask = "##:##:##";
            this.MskBeginTime.Name = "MskBeginTime";
            this.MskBeginTime.Size = new System.Drawing.Size(73, 28);
            this.MskBeginTime.TabIndex = 1;
            this.MskBeginTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTime_KeyPress);
            // 
            // MskDate
            // 
            this.MskDate.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MskDate.Location = new System.Drawing.Point(320, 9);
            this.MskDate.Mask = "####/##/##";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(100, 28);
            this.MskDate.TabIndex = 0;
            this.MskDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskDate_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(399, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 55;
            this.label5.Text = "محاسبه تا ";
            // 
            // TxtNextDayNumber
            // 
            this.TxtNextDayNumber.Location = new System.Drawing.Point(355, 56);
            this.TxtNextDayNumber.Name = "TxtNextDayNumber";
            this.TxtNextDayNumber.Size = new System.Drawing.Size(43, 20);
            this.TxtNextDayNumber.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(306, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 26);
            this.label6.TabIndex = 57;
            this.label6.Text = "روز بعد";
            // 
            // Frm_FillterStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 185);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "Frm_FillterStation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیم  بازه ای ایستگاه های کاری";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNextDayNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskBeginTime;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private Janus.Windows.EditControls.UIButton Btn_OK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Cmb_ProductLine;
        private System.Windows.Forms.Label Lbl_ProductLine;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Cmb_Shift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskEndTime;
        private System.Windows.Forms.NumericUpDown TxtNextDayNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
