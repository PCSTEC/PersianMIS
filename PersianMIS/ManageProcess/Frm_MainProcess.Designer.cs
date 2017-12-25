﻿namespace PersianMIS.Process
{
    partial class Frm_MainProcess
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
            this.Rd_Menu = new Telerik.WinControls.UI.RadDiagramRibbonBar();
            this.Rd_Toolbars = new Telerik.WinControls.UI.RadDiagramToolbox();
            this.RdMainDiagram = new Telerik.WinControls.UI.RadDiagram();
            ((System.ComponentModel.ISupportInitialize)(this.Rd_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rd_Toolbars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdMainDiagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Rd_Menu
            // 
            this.Rd_Menu.AllowDrop = true;
            this.Rd_Menu.AllowShowFocusCues = true;
            this.Rd_Menu.AssociatedDiagram = this.RdMainDiagram;
            this.Rd_Menu.AutoScroll = true;
            // 
            // 
            // 
            this.Rd_Menu.ExitButton.Text = "خروج";
            this.Rd_Menu.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Rd_Menu.Location = new System.Drawing.Point(0, 0);
            this.Rd_Menu.Name = "Rd_Menu";
            // 
            // 
            // 
            this.Rd_Menu.OptionsButton.Text = "Options";
            this.Rd_Menu.Size = new System.Drawing.Size(931, 180);
            this.Rd_Menu.TabIndex = 0;
            // 
            // Rd_Toolbars
            // 
            this.Rd_Toolbars.AllowDragDrop = true;
            this.Rd_Toolbars.AllowDrop = true;
            this.Rd_Toolbars.AllowEdit = false;
            this.Rd_Toolbars.Dock = System.Windows.Forms.DockStyle.Left;
            this.Rd_Toolbars.EnableCustomGrouping = true;
            this.Rd_Toolbars.FullRowSelect = false;
            this.Rd_Toolbars.ItemSize = new System.Drawing.Size(64, 64);
            this.Rd_Toolbars.Location = new System.Drawing.Point(0, 180);
            this.Rd_Toolbars.Name = "Rd_Toolbars";
            this.Rd_Toolbars.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.Rd_Toolbars.ShowGroups = true;
            this.Rd_Toolbars.Size = new System.Drawing.Size(140, 626);
            this.Rd_Toolbars.TabIndex = 2;
            this.Rd_Toolbars.Text = "radDiagramToolbox1";
            this.Rd_Toolbars.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            // 
            // RdMainDiagram
            // 
            this.RdMainDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdMainDiagram.Location = new System.Drawing.Point(140, 180);
            this.RdMainDiagram.Name = "RdMainDiagram";
            this.RdMainDiagram.Size = new System.Drawing.Size(791, 626);
            this.RdMainDiagram.TabIndex = 3;
            this.RdMainDiagram.Text = "radDiagram1";
            // 
            // Frm_MainProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 806);
            this.Controls.Add(this.RdMainDiagram);
            this.Controls.Add(this.Rd_Toolbars);
            this.Controls.Add(this.Rd_Menu);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MainProcess";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Rd_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rd_Toolbars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdMainDiagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDiagramRibbonBar Rd_Menu;
        private Telerik.WinControls.UI.RadDiagramToolbox Rd_Toolbars;
        private Telerik.WinControls.UI.RadDiagram RdMainDiagram;
    }
}