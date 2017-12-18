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
            this.TopPnl = new DevComponents.DotNetBar.PanelEx();
            this.BBManage = new DevComponents.DotNetBar.BubbleBar();
            this.BubbleBarTab2 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.BtnClosed = new DevComponents.DotNetBar.BubbleButton();
            this.Pnl_State = new System.Windows.Forms.Panel();
            this.Lbl_ParameterCaption = new System.Windows.Forms.Label();
            this.Lbl_ParameterDesc = new System.Windows.Forms.Label();
            this.Pnl_Main = new System.Windows.Forms.FlowLayoutPanel();
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
            this.TopPnl.Size = new System.Drawing.Size(395, 44);
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
            this.BBManage.Location = new System.Drawing.Point(320, -9);
            this.BBManage.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.BBManage.Name = "BBManage";
            this.BBManage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BBManage.SelectedTab = this.BubbleBarTab2;
            this.BBManage.SelectedTabColors.BackColor = System.Drawing.Color.Transparent;
            this.BBManage.SelectedTabColors.BackColor2 = System.Drawing.Color.Transparent;
            this.BBManage.SelectedTabColors.BorderColor = System.Drawing.Color.Black;
            this.BBManage.Size = new System.Drawing.Size(92, 54);
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
            this.BtnClosed});
            this.BubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.BubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BubbleBarTab2.Name = "BubbleBarTab2";
            this.BubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.BubbleBarTab2.Text = "";
            this.BubbleBarTab2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
            // 
            // BtnClosed
            // 
            this.BtnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClosed.Image = ((System.Drawing.Image)(resources.GetObject("BtnClosed.Image")));
            this.BtnClosed.ImageLarge = ((System.Drawing.Image)(resources.GetObject("BtnClosed.ImageLarge")));
            this.BtnClosed.Name = "BtnClosed";
            this.BtnClosed.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnClosed_Click);
            // 
            // Pnl_State
            // 
            this.Pnl_State.Controls.Add(this.Lbl_ParameterCaption);
            this.Pnl_State.Controls.Add(this.Lbl_ParameterDesc);
            this.Pnl_State.Location = new System.Drawing.Point(477, 360);
            this.Pnl_State.Name = "Pnl_State";
            this.Pnl_State.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pnl_State.Size = new System.Drawing.Size(362, 37);
            this.Pnl_State.TabIndex = 5;
            // 
            // Lbl_ParameterCaption
            // 
            this.Lbl_ParameterCaption.ForeColor = System.Drawing.Color.White;
            this.Lbl_ParameterCaption.Location = new System.Drawing.Point(97, 7);
            this.Lbl_ParameterCaption.Name = "Lbl_ParameterCaption";
            this.Lbl_ParameterCaption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_ParameterCaption.Size = new System.Drawing.Size(262, 26);
            this.Lbl_ParameterCaption.TabIndex = 9;
            this.Lbl_ParameterCaption.Text = "(دقیقه)Emergency Stop";
            this.Lbl_ParameterCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_ParameterDesc
            // 
            this.Lbl_ParameterDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lbl_ParameterDesc.Location = new System.Drawing.Point(8, 7);
            this.Lbl_ParameterDesc.Name = "Lbl_ParameterDesc";
            this.Lbl_ParameterDesc.Size = new System.Drawing.Size(91, 26);
            this.Lbl_ParameterDesc.TabIndex = 6;
            this.Lbl_ParameterDesc.Text = "label1";
            this.Lbl_ParameterDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Main
            // 
            this.Pnl_Main.Location = new System.Drawing.Point(14, 44);
            this.Pnl_Main.Name = "Pnl_Main";
            this.Pnl_Main.Size = new System.Drawing.Size(378, 428);
            this.Pnl_Main.TabIndex = 6;
            // 
            // StationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(228)))));
            this.Controls.Add(this.Pnl_Main);
            this.Controls.Add(this.Pnl_State);
            this.Controls.Add(this.TopPnl);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StationUserControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(395, 475);
            this.Load += new System.EventHandler(this.StationUserControl_Load);
            this.TopPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BBManage)).EndInit();
            this.Pnl_State.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx TopPnl;
        internal DevComponents.DotNetBar.BubbleBar BBManage;
        internal DevComponents.DotNetBar.BubbleBarTab BubbleBarTab2;
        internal DevComponents.DotNetBar.BubbleButton BtnClosed;
        private System.Windows.Forms.Panel Pnl_State;
        private System.Windows.Forms.Label Lbl_ParameterDesc;
        private System.Windows.Forms.Label Lbl_ParameterCaption;
        private System.Windows.Forms.FlowLayoutPanel Pnl_Main;
    }
}
