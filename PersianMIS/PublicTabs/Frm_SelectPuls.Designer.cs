namespace PersianMIS.PublicTabs
{
    partial class Frm_SelectPuls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelectPuls));
            this.MainTree = new Telerik.WinControls.UI.RadTreeView();
            this.Btn_Ok = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTree
            // 
            this.MainTree.Location = new System.Drawing.Point(8, 8);
            this.MainTree.Name = "MainTree";
            this.MainTree.Size = new System.Drawing.Size(406, 550);
            this.MainTree.SpacingBetweenNodes = -1;
            this.MainTree.TabIndex = 2;
            this.MainTree.NodeMouseClick += new Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.MainTree_NodeMouseClick);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Ok.Image = global::PersianMIS.Properties.Resources._1111;
            this.Btn_Ok.Location = new System.Drawing.Point(140, 564);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(137, 33);
            this.Btn_Ok.TabIndex = 45;
            this.Btn_Ok.Text = "تایید";
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Frm_SelectPuls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 601);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.MainTree);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_SelectPuls";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب پالس";
            this.Load += new System.EventHandler(this.Frm_SelectPuls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTreeView MainTree;
        private Telerik.WinControls.UI.RadButton Btn_Ok;
    }
}
