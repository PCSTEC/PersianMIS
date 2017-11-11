<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSPastHokm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSPastHokm))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnDeletHokm = New Janus.Windows.EditControls.UIButton
        Me.JGrade1 = New JFrameWork.jGrade
        Me.btnGhararadadPrint = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblEngageDate = New System.Windows.Forms.Label
        Me.lblEngDate = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.lblprsCode = New System.Windows.Forms.Label
        Me.lblDossierJobCo = New System.Windows.Forms.Label
        Me.btnPrint = New Janus.Windows.EditControls.UIButton
        Me.grdEmployee = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        ç«ÅÕﬂ„ToolStripMenuItem = New ToolStripMenuItem
        Me.ç«Åﬁ—«—œ«œToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnudelHokm = New System.Windows.Forms.ToolStripMenuItem
        Me.savbegh = New Janus.Windows.EditControls.UIButton
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.savbegh)
        Me.UiGroupBox1.Controls.Add(Me.btnDeletHokm)
        Me.UiGroupBox1.Controls.Add(Me.JGrade1)
        Me.UiGroupBox1.Controls.Add(Me.btnGhararadadPrint)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.btnPrint)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -2)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(721, 573)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnDeletHokm
        '
        Me.btnDeletHokm.Icon = CType(resources.GetObject("btnDeletHokm.Icon"), System.Drawing.Icon)
        Me.btnDeletHokm.Location = New System.Drawing.Point(620, 546)
        Me.btnDeletHokm.Name = "btnDeletHokm"
        Me.btnDeletHokm.Size = New System.Drawing.Size(77, 23)
        Me.btnDeletHokm.TabIndex = 4
        Me.btnDeletHokm.Tag = ""
        Me.btnDeletHokm.Text = "Õ–› Õﬂ„"
        Me.btnDeletHokm.Visible = False
        Me.btnDeletHokm.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(4, 0)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 3
        '
        'btnGhararadadPrint
        '
        Me.btnGhararadadPrint.Icon = CType(resources.GetObject("btnGhararadadPrint.Icon"), System.Drawing.Icon)
        Me.btnGhararadadPrint.Location = New System.Drawing.Point(3, 546)
        Me.btnGhararadadPrint.Name = "btnGhararadadPrint"
        Me.btnGhararadadPrint.Size = New System.Drawing.Size(77, 23)
        Me.btnGhararadadPrint.TabIndex = 2
        Me.btnGhararadadPrint.Tag = ""
        Me.btnGhararadadPrint.Text = "ç«Å ﬁ—«—œ«œ"
        Me.btnGhararadadPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox2.Controls.Add(Me.lblEngageDate)
        Me.UiGroupBox2.Controls.Add(Me.lblEngDate)
        Me.UiGroupBox2.Controls.Add(Me.lblName)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox2.Controls.Add(Me.lblprsCode)
        Me.UiGroupBox2.Controls.Add(Me.lblDossierJobCo)
        Me.UiGroupBox2.Location = New System.Drawing.Point(138, 3)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(579, 58)
        Me.UiGroupBox2.TabIndex = 1
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'lblEngageDate
        '
        Me.lblEngageDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEngageDate.ForeColor = System.Drawing.Color.Red
        Me.lblEngageDate.Location = New System.Drawing.Point(368, 33)
        Me.lblEngageDate.Name = "lblEngageDate"
        Me.lblEngageDate.Size = New System.Drawing.Size(123, 20)
        Me.lblEngageDate.TabIndex = 5
        Me.lblEngageDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEngDate
        '
        Me.lblEngDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEngDate.Location = New System.Drawing.Point(492, 33)
        Me.lblEngDate.Name = "lblEngDate"
        Me.lblEngDate.Size = New System.Drawing.Size(87, 20)
        Me.lblEngDate.TabIndex = 4
        Me.lblEngDate.Text = " «—ÌŒ «” Œœ«„ :"
        Me.lblEngDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.ForeColor = System.Drawing.Color.Red
        Me.lblName.Location = New System.Drawing.Point(3, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(224, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonCode
        '
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(383, 8)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(109, 20)
        Me.lblPersonCode.TabIndex = 1
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprsCode
        '
        Me.lblprsCode.BackColor = System.Drawing.Color.Transparent
        Me.lblprsCode.Location = New System.Drawing.Point(492, 8)
        Me.lblprsCode.Name = "lblprsCode"
        Me.lblprsCode.Size = New System.Drawing.Size(70, 20)
        Me.lblprsCode.TabIndex = 0
        Me.lblprsCode.Text = "ﬂœ Å—”‰·Ì :"
        Me.lblprsCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDossierJobCo
        '
        Me.lblDossierJobCo.BackColor = System.Drawing.Color.Transparent
        Me.lblDossierJobCo.Location = New System.Drawing.Point(226, 8)
        Me.lblDossierJobCo.Name = "lblDossierJobCo"
        Me.lblDossierJobCo.Size = New System.Drawing.Size(106, 20)
        Me.lblDossierJobCo.TabIndex = 2
        Me.lblDossierJobCo.Text = "‰«„ Ê ‰«„ Œ«‰Ê«œêÌ :"
        Me.lblDossierJobCo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnPrint
        '
        Me.btnPrint.Icon = CType(resources.GetObject("btnPrint.Icon"), System.Drawing.Icon)
        Me.btnPrint.Location = New System.Drawing.Point(83, 546)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(77, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Tag = ""
        Me.btnPrint.Text = "ç«Å Õﬂ„"
        Me.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'grdEmployee
        '
        Me.grdEmployee.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEmployee.CellToolTipText = "ÃÂ  ﬂ«—»—Ì ”—Ì⁄ — ﬂ·Ìﬂ —«”  ‰„«ÌÌœ"
        Me.grdEmployee.ContextMenuStrip = Me.ContextMenuStrip1
        Me.grdEmployee.GroupByBoxVisible = False
        Me.grdEmployee.Location = New System.Drawing.Point(2, 65)
        Me.grdEmployee.Name = "grdEmployee"
        Me.grdEmployee.Size = New System.Drawing.Size(712, 477)
        Me.grdEmployee.TabIndex = 1
        Me.grdEmployee.TabStop = False
        Me.grdEmployee.Tag = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ç«ÅÕﬂ„ToolStripMenuItem, Me.ç«Åﬁ—«—œ«œToolStripMenuItem, Me.mnudelHokm})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 70)
        '
        'ç«ÅÕﬂ„ToolStripMenuItem
        '
        Me.ç«ÅÕﬂ„ToolStripMenuItem.Image = CType(resources.GetObject("ç«ÅÕﬂ„ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ç«ÅÕﬂ„ToolStripMenuItem.Name = "ç«ÅÕﬂ„ToolStripMenuItem"
        Me.ç«ÅÕﬂ„ToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ç«ÅÕﬂ„ToolStripMenuItem.Text = "ç«Å Õﬂ„"
        '
        'ç«Åﬁ—«—œ«œToolStripMenuItem
        '
        Me.ç«Åﬁ—«—œ«œToolStripMenuItem.Image = CType(resources.GetObject("ç«Åﬁ—«—œ«œToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ç«Åﬁ—«—œ«œToolStripMenuItem.Name = "ç«Åﬁ—«—œ«œToolStripMenuItem"
        Me.ç«Åﬁ—«—œ«œToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ç«Åﬁ—«—œ«œToolStripMenuItem.Text = "ç«Å ﬁ—«—œ«œ"
        '
        'mnudelHokm
        '
        Me.mnudelHokm.Image = CType(resources.GetObject("mnudelHokm.Image"), System.Drawing.Image)
        Me.mnudelHokm.Name = "mnudelHokm"
        Me.mnudelHokm.Size = New System.Drawing.Size(126, 22)
        Me.mnudelHokm.Text = "Õ–› Õﬂ„"
        Me.mnudelHokm.Visible = False
        '
        'savbegh
        '
        Me.savbegh.Icon = CType(resources.GetObject("savbegh.Icon"), System.Drawing.Icon)
        Me.savbegh.Location = New System.Drawing.Point(166, 544)
        Me.savbegh.Name = "savbegh"
        Me.savbegh.Size = New System.Drawing.Size(124, 27)
        Me.savbegh.TabIndex = 5
        Me.savbegh.Tag = ""
        Me.savbegh.Text = "ç«Å ”Ê«»ﬁ Õﬂ„"
        Me.savbegh.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'frmPRSPastHokm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 568)
        Me.Controls.Add(Me.grdEmployee)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPRSPastHokm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "”Ê«»ﬁ Õﬂ„ Ê ﬁ—«—œ«œ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdEmployee As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ç«ÅÕﬂ„ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblEngageDate As System.Windows.Forms.Label
    Friend WithEvents lblEngDate As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents lblprsCode As System.Windows.Forms.Label
    Friend WithEvents lblDossierJobCo As System.Windows.Forms.Label
    Friend WithEvents btnGhararadadPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents ç«Åﬁ—«—œ«œToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JGrade1 As JFrameWork.jGrade
    Friend WithEvents btnDeletHokm As Janus.Windows.EditControls.UIButton
    Friend WithEvents mnudelHokm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents savbegh As Janus.Windows.EditControls.UIButton
End Class
