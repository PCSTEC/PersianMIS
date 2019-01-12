namespace PersianMIS.Process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainProcess));
            this.Rd_Menu = new Telerik.WinControls.UI.RadDiagramRibbonBar();
            this.RdMainDiagram = new Telerik.WinControls.UI.RadDiagram();
            this.button1 = new System.Windows.Forms.Button();
            this.Rd_Toolbars = new Telerik.WinControls.UI.RadDiagramToolbox();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.Rd_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdMainDiagram)).BeginInit();
            this.RdMainDiagram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rd_Toolbars)).BeginInit();
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
            this.Rd_Menu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Rd_Menu.Location = new System.Drawing.Point(0, 0);
            this.Rd_Menu.Name = "Rd_Menu";
            // 
            // 
            // 
            this.Rd_Menu.OptionsButton.Text = "Options";
            this.Rd_Menu.Size = new System.Drawing.Size(931, 156);
            this.Rd_Menu.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("Rd_Menu.StartButtonImage")));
            this.Rd_Menu.TabIndex = 0;
            this.Rd_Menu.ThemeName = "TelerikMetro";
            // 
            // RdMainDiagram
            // 
            this.RdMainDiagram.AllowDrop = true;
            this.RdMainDiagram.AllowShowFocusCues = true;
            this.RdMainDiagram.AutoScroll = true;
            this.RdMainDiagram.BackColor = System.Drawing.Color.White;
            this.RdMainDiagram.Controls.Add(this.button1);
            this.RdMainDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdMainDiagram.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RdMainDiagram.IsSnapToGridEnabled = false;
            this.RdMainDiagram.Location = new System.Drawing.Point(135, 156);
            this.RdMainDiagram.Name = "RdMainDiagram";
            this.RdMainDiagram.Size = new System.Drawing.Size(796, 650);
            this.RdMainDiagram.SnapX = 0;
            this.RdMainDiagram.SnapY = 0;
            this.RdMainDiagram.TabIndex = 3;
            this.RdMainDiagram.Text = "radDiagram1";
            this.RdMainDiagram.CommandExecuted += new System.EventHandler<Telerik.Windows.Diagrams.Core.CommandEventArgs>(this.RdMainDiagram_CommandExecuted);
            this.RdMainDiagram.DiagramLayoutComplete += new System.EventHandler<Telerik.Windows.Diagrams.Core.DiagramLayoutEventArgs>(this.RdMainDiagram_DiagramLayoutComplete);
            this.RdMainDiagram.Click += new System.EventHandler(this.RdMainDiagram_Click);
            this.RdMainDiagram.DoubleClick += new System.EventHandler(this.RdMainDiagram_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Rd_Toolbars
            // 
            this.Rd_Toolbars.AllowDragDrop = true;
            this.Rd_Toolbars.AllowDrop = true;
            this.Rd_Toolbars.AllowEdit = false;
            this.Rd_Toolbars.Dock = System.Windows.Forms.DockStyle.Left;
            this.Rd_Toolbars.EnableCustomGrouping = true;
            this.Rd_Toolbars.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Rd_Toolbars.FullRowSelect = false;
            this.Rd_Toolbars.GroupIndent = 10;
            this.Rd_Toolbars.ItemSize = new System.Drawing.Size(64, 64);
            this.Rd_Toolbars.ItemSpacing = 15;
            this.Rd_Toolbars.Location = new System.Drawing.Point(0, 156);
            this.Rd_Toolbars.Name = "Rd_Toolbars";
            this.Rd_Toolbars.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.Rd_Toolbars.ShowGroups = true;
            this.Rd_Toolbars.Size = new System.Drawing.Size(135, 650);
            this.Rd_Toolbars.TabIndex = 2;
            this.Rd_Toolbars.Text = "radDiagramToolbox1";
            this.Rd_Toolbars.ThemeName = "Office2010Silver";
            this.Rd_Toolbars.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            this.Rd_Toolbars.ItemCreating += new Telerik.WinControls.UI.ListViewItemCreatingEventHandler(this.Rd_Toolbars_ItemCreating);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MainProcess";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Rd_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdMainDiagram)).EndInit();
            this.RdMainDiagram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rd_Toolbars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDiagramRibbonBar Rd_Menu;
        private Telerik.WinControls.UI.RadDiagramToolbox Rd_Toolbars;
        private Telerik.WinControls.UI.RadDiagram RdMainDiagram;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private System.Windows.Forms.Button button1;
    }
}