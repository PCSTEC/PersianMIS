namespace PersianMIS.StationControl
{
    partial class StationUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationUserControl));
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.TopPnl = new DevComponents.DotNetBar.PanelEx();
            this.BBManage = new DevComponents.DotNetBar.BubbleBar();
            this.BubbleBarTab2 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.BubbleButton8 = new DevComponents.DotNetBar.BubbleButton();
            this.BtnClosed = new DevComponents.DotNetBar.BubbleButton();
            this.Lbl_SumDisconnectTime = new System.Windows.Forms.Label();
            this.Lbl_SumConnectTime = new System.Windows.Forms.Label();
            this.Pnl_State = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_DeActiveName = new System.Windows.Forms.Label();
            this.Lbl_ActiveName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_LineDesc = new System.Windows.Forms.Label();
            this.Lbl_DeviceDesc = new System.Windows.Forms.Label();
            this.Lbl_ProductLineDesc = new System.Windows.Forms.Label();
            this.TimerState = new System.Windows.Forms.Timer(this.components);
            this.TopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BBManage)).BeginInit();
            this.Pnl_State.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPnl
            // 
            this.TopPnl.CanvasColor = System.Drawing.SystemColors.Control;
            this.TopPnl.Controls.Add(this.BBManage);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Size = new System.Drawing.Size(398, 44);
            this.TopPnl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.TopPnl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.TopPnl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.TopPnl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.TopPnl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.TopPnl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.TopPnl.Style.GradientAngle = 90;
            this.TopPnl.TabIndex = 3;
            this.TopPnl.Text = "سیستم داشبورد مدیریت";
            // 
            // BBManage
            // 
            this.BBManage.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.BBManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BBManage.AntiAlias = true;
            this.BBManage.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.BBManage.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent;
            this.BBManage.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.BBManage.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.BBManage.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.BBManage.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.BBManage.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.BBManage.ButtonBackAreaStyle.PaddingBottom = 3;
            this.BBManage.ButtonBackAreaStyle.PaddingLeft = 3;
            this.BBManage.ButtonBackAreaStyle.PaddingRight = 3;
            this.BBManage.ButtonBackAreaStyle.PaddingTop = 3;
            this.BBManage.Cursor = System.Windows.Forms.Cursors.Default;
            this.BBManage.ForeColor = System.Drawing.Color.Transparent;
            this.BBManage.ImageSizeLarge = new System.Drawing.Size(60, 60);
            this.BBManage.ImageSizeNormal = new System.Drawing.Size(35, 35);
            this.BBManage.Location = new System.Drawing.Point(292, -9);
            this.BBManage.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.BBManage.Name = "BBManage";
            this.BBManage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BBManage.SelectedTab = this.BubbleBarTab2;
            this.BBManage.SelectedTabColors.BackColor = System.Drawing.Color.Transparent;
            this.BBManage.SelectedTabColors.BackColor2 = System.Drawing.Color.Transparent;
            this.BBManage.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.BBManage.Size = new System.Drawing.Size(123, 54);
            this.BBManage.TabIndex = 15;
            this.BBManage.Tabs.Add(this.BubbleBarTab2);
            this.BBManage.TooltipOutlineColor = System.Drawing.Color.Transparent;
            this.BBManage.TooltipTextColor = System.Drawing.Color.Transparent;
            // 
            // BubbleBarTab2
            // 
            this.BubbleBarTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.BubbleBarTab2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.BubbleBarTab2.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.BubbleButton8,
            this.BtnClosed});
            this.BubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BubbleBarTab2.Name = "BubbleBarTab2";
            this.BubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.BubbleBarTab2.Text = "";
            this.BubbleBarTab2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
            // 
            // BubbleButton8
            // 
            this.BubbleButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BubbleButton8.Image = ((System.Drawing.Image)(resources.GetObject("BubbleButton8.Image")));
            this.BubbleButton8.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BubbleButton8.ImageLarge")));
            this.BubbleButton8.Name = "BubbleButton8";
            // 
            // BtnClosed
            // 
            this.BtnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClosed.Image = ((System.Drawing.Image)(resources.GetObject("BtnClosed.Image")));
            this.BtnClosed.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnClosed.ImageLarge")));
            this.BtnClosed.Name = "BtnClosed";
            // 
            // Lbl_SumDisconnectTime
            // 
            this.Lbl_SumDisconnectTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lbl_SumDisconnectTime.Location = new System.Drawing.Point(119, 146);
            this.Lbl_SumDisconnectTime.Name = "Lbl_SumDisconnectTime";
            this.Lbl_SumDisconnectTime.Size = new System.Drawing.Size(109, 24);
            this.Lbl_SumDisconnectTime.TabIndex = 2;
            this.Lbl_SumDisconnectTime.Text = "0";
            this.Lbl_SumDisconnectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_SumConnectTime
            // 
            this.Lbl_SumConnectTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lbl_SumConnectTime.Location = new System.Drawing.Point(119, 116);
            this.Lbl_SumConnectTime.Name = "Lbl_SumConnectTime";
            this.Lbl_SumConnectTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_SumConnectTime.Size = new System.Drawing.Size(109, 24);
            this.Lbl_SumConnectTime.TabIndex = 1;
            this.Lbl_SumConnectTime.Text = "0";
            this.Lbl_SumConnectTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_State
            // 
            this.Pnl_State.Controls.Add(this.label5);
            this.Pnl_State.Controls.Add(this.label4);
            this.Pnl_State.Controls.Add(this.Lbl_DeActiveName);
            this.Pnl_State.Controls.Add(this.Lbl_ActiveName);
            this.Pnl_State.Controls.Add(this.label3);
            this.Pnl_State.Controls.Add(this.label1);
            this.Pnl_State.Controls.Add(this.label2);
            this.Pnl_State.Controls.Add(this.Lbl_SumDisconnectTime);
            this.Pnl_State.Controls.Add(this.Lbl_SumConnectTime);
            this.Pnl_State.Controls.Add(this.Lbl_LineDesc);
            this.Pnl_State.Controls.Add(this.Lbl_DeviceDesc);
            this.Pnl_State.Controls.Add(this.Lbl_ProductLineDesc);
            this.Pnl_State.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_State.Location = new System.Drawing.Point(0, 44);
            this.Pnl_State.Name = "Pnl_State";
            this.Pnl_State.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pnl_State.Size = new System.Drawing.Size(398, 178);
            this.Pnl_State.TabIndex = 5;
            this.Pnl_State.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_State_Paint);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(3, 143);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(119, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "دقیقه";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "دقیقه";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_DeActiveName
            // 
            this.Lbl_DeActiveName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_DeActiveName.ForeColor = System.Drawing.Color.White;
            this.Lbl_DeActiveName.Location = new System.Drawing.Point(218, 142);
            this.Lbl_DeActiveName.Name = "Lbl_DeActiveName";
            this.Lbl_DeActiveName.Size = new System.Drawing.Size(163, 26);
            this.Lbl_DeActiveName.TabIndex = 13;
            this.Lbl_DeActiveName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_ActiveName
            // 
            this.Lbl_ActiveName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ActiveName.ForeColor = System.Drawing.Color.White;
            this.Lbl_ActiveName.Location = new System.Drawing.Point(218, 116);
            this.Lbl_ActiveName.Name = "Lbl_ActiveName";
            this.Lbl_ActiveName.Size = new System.Drawing.Size(168, 26);
            this.Lbl_ActiveName.TabIndex = 12;
            this.Lbl_ActiveName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(278, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "عنوان خط ورودی:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "عنوان دستگاه:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "عنوان خط تولید:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_LineDesc
            // 
            this.Lbl_LineDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_LineDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lbl_LineDesc.Location = new System.Drawing.Point(47, 74);
            this.Lbl_LineDesc.Name = "Lbl_LineDesc";
            this.Lbl_LineDesc.Size = new System.Drawing.Size(225, 26);
            this.Lbl_LineDesc.TabIndex = 8;
            this.Lbl_LineDesc.Text = "label1";
            this.Lbl_LineDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_DeviceDesc
            // 
            this.Lbl_DeviceDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_DeviceDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lbl_DeviceDesc.Location = new System.Drawing.Point(90, 39);
            this.Lbl_DeviceDesc.Name = "Lbl_DeviceDesc";
            this.Lbl_DeviceDesc.Size = new System.Drawing.Size(182, 26);
            this.Lbl_DeviceDesc.TabIndex = 7;
            this.Lbl_DeviceDesc.Text = "label1";
            this.Lbl_DeviceDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_ProductLineDesc
            // 
            this.Lbl_ProductLineDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ProductLineDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lbl_ProductLineDesc.Location = new System.Drawing.Point(92, 4);
            this.Lbl_ProductLineDesc.Name = "Lbl_ProductLineDesc";
            this.Lbl_ProductLineDesc.Size = new System.Drawing.Size(182, 26);
            this.Lbl_ProductLineDesc.TabIndex = 6;
            this.Lbl_ProductLineDesc.Text = "label1";
            this.Lbl_ProductLineDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerState
            // 
            this.TimerState.Interval = 1000;
            this.TimerState.Tick += new System.EventHandler(this.TimerState_Tick);
            // 
            // StationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.Pnl_State);
            this.Controls.Add(this.TopPnl);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StationUserControl";
            this.Size = new System.Drawing.Size(398, 222);
            this.Load += new System.EventHandler(this.StationUserControl_Load);
            this.TopPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BBManage)).EndInit();
            this.Pnl_State.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private DevComponents.DotNetBar.PanelEx TopPnl;
        internal DevComponents.DotNetBar.BubbleBar BBManage;
        internal DevComponents.DotNetBar.BubbleBarTab BubbleBarTab2;
        internal DevComponents.DotNetBar.BubbleButton BubbleButton8;
        internal DevComponents.DotNetBar.BubbleButton BtnClosed;
        private System.Windows.Forms.Label Lbl_SumDisconnectTime;
        private System.Windows.Forms.Label Lbl_SumConnectTime;
        private System.Windows.Forms.Panel Pnl_State;
        private System.Windows.Forms.Label Lbl_LineDesc;
        private System.Windows.Forms.Label Lbl_DeviceDesc;
        private System.Windows.Forms.Label Lbl_ProductLineDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_DeActiveName;
        private System.Windows.Forms.Label Lbl_ActiveName;
        private System.Windows.Forms.Timer TimerState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
