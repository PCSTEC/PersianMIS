<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMadrak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddMadrak))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnAddAttitudeName = New Janus.Windows.EditControls.UIButton
        Me.lblAttitudeName = New System.Windows.Forms.Label
        Me.txtAttitudeName = New System.Windows.Forms.TextBox
        Me.grdAttitudeName = New Janus.Windows.GridEX.GridEX
        Me.btnAddBranchTxt = New Janus.Windows.EditControls.UIButton
        Me.lblBranchTxt = New System.Windows.Forms.Label
        Me.txtBranchTxt = New System.Windows.Forms.TextBox
        Me.btnAddEducationType = New Janus.Windows.EditControls.UIButton
        Me.lblEducationTypetxt = New System.Windows.Forms.Label
        Me.txtEducationTypetxt = New System.Windows.Forms.TextBox
        Me.grdBranchTxt = New Janus.Windows.GridEX.GridEX
        Me.grdEducationType = New Janus.Windows.GridEX.GridEX
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdAttitudeName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdBranchTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEducationType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(459, 443)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox2.Controls.Add(Me.btnAddAttitudeName)
        Me.UiGroupBox2.Controls.Add(Me.lblAttitudeName)
        Me.UiGroupBox2.Controls.Add(Me.txtAttitudeName)
        Me.UiGroupBox2.Controls.Add(Me.grdAttitudeName)
        Me.UiGroupBox2.Controls.Add(Me.btnAddBranchTxt)
        Me.UiGroupBox2.Controls.Add(Me.lblBranchTxt)
        Me.UiGroupBox2.Controls.Add(Me.txtBranchTxt)
        Me.UiGroupBox2.Controls.Add(Me.btnAddEducationType)
        Me.UiGroupBox2.Controls.Add(Me.lblEducationTypetxt)
        Me.UiGroupBox2.Controls.Add(Me.txtEducationTypetxt)
        Me.UiGroupBox2.Controls.Add(Me.grdBranchTxt)
        Me.UiGroupBox2.Controls.Add(Me.grdEducationType)
        Me.UiGroupBox2.Location = New System.Drawing.Point(2, -1)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(457, 438)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnAddAttitudeName
        '
        Me.btnAddAttitudeName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAttitudeName.Icon = CType(resources.GetObject("btnAddAttitudeName.Icon"), System.Drawing.Icon)
        Me.btnAddAttitudeName.Location = New System.Drawing.Point(10, 294)
        Me.btnAddAttitudeName.Name = "btnAddAttitudeName"
        Me.btnAddAttitudeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddAttitudeName.Size = New System.Drawing.Size(77, 23)
        Me.btnAddAttitudeName.TabIndex = 8
        Me.btnAddAttitudeName.Text = "À»  ê—«Ì‘"
        Me.btnAddAttitudeName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblAttitudeName
        '
        Me.lblAttitudeName.BackColor = System.Drawing.Color.Transparent
        Me.lblAttitudeName.Location = New System.Drawing.Point(344, 294)
        Me.lblAttitudeName.Name = "lblAttitudeName"
        Me.lblAttitudeName.Size = New System.Drawing.Size(101, 19)
        Me.lblAttitudeName.TabIndex = 6
        Me.lblAttitudeName.Text = "ê—«Ì‘ ÃœÌœ :"
        Me.lblAttitudeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAttitudeName
        '
        Me.txtAttitudeName.Location = New System.Drawing.Point(93, 295)
        Me.txtAttitudeName.Name = "txtAttitudeName"
        Me.txtAttitudeName.Size = New System.Drawing.Size(245, 21)
        Me.txtAttitudeName.TabIndex = 7
        '
        'grdAttitudeName
        '
        Me.grdAttitudeName.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdAttitudeName.GroupByBoxVisible = False
        Me.grdAttitudeName.Location = New System.Drawing.Point(12, 323)
        Me.grdAttitudeName.Name = "grdAttitudeName"
        Me.grdAttitudeName.Size = New System.Drawing.Size(431, 107)
        Me.grdAttitudeName.TabIndex = 18
        Me.grdAttitudeName.TabStop = False
        '
        'btnAddBranchTxt
        '
        Me.btnAddBranchTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBranchTxt.Icon = CType(resources.GetObject("btnAddBranchTxt.Icon"), System.Drawing.Icon)
        Me.btnAddBranchTxt.Location = New System.Drawing.Point(13, 151)
        Me.btnAddBranchTxt.Name = "btnAddBranchTxt"
        Me.btnAddBranchTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddBranchTxt.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBranchTxt.TabIndex = 5
        Me.btnAddBranchTxt.Text = "À»  —‘ Â"
        Me.btnAddBranchTxt.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblBranchTxt
        '
        Me.lblBranchTxt.BackColor = System.Drawing.Color.Transparent
        Me.lblBranchTxt.Location = New System.Drawing.Point(345, 151)
        Me.lblBranchTxt.Name = "lblBranchTxt"
        Me.lblBranchTxt.Size = New System.Drawing.Size(101, 19)
        Me.lblBranchTxt.TabIndex = 3
        Me.lblBranchTxt.Text = "—‘ Â ÃœÌœ :"
        Me.lblBranchTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBranchTxt
        '
        Me.txtBranchTxt.Location = New System.Drawing.Point(94, 152)
        Me.txtBranchTxt.Name = "txtBranchTxt"
        Me.txtBranchTxt.Size = New System.Drawing.Size(245, 21)
        Me.txtBranchTxt.TabIndex = 4
        '
        'btnAddEducationType
        '
        Me.btnAddEducationType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEducationType.Icon = CType(resources.GetObject("btnAddEducationType.Icon"), System.Drawing.Icon)
        Me.btnAddEducationType.Location = New System.Drawing.Point(13, 13)
        Me.btnAddEducationType.Name = "btnAddEducationType"
        Me.btnAddEducationType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddEducationType.Size = New System.Drawing.Size(75, 23)
        Me.btnAddEducationType.TabIndex = 2
        Me.btnAddEducationType.Text = "À»  ‰Ê⁄"
        Me.btnAddEducationType.Visible = False
        Me.btnAddEducationType.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblEducationTypetxt
        '
        Me.lblEducationTypetxt.BackColor = System.Drawing.Color.Transparent
        Me.lblEducationTypetxt.Location = New System.Drawing.Point(345, 13)
        Me.lblEducationTypetxt.Name = "lblEducationTypetxt"
        Me.lblEducationTypetxt.Size = New System.Drawing.Size(101, 19)
        Me.lblEducationTypetxt.TabIndex = 0
        Me.lblEducationTypetxt.Text = "‰Ê⁄  Õ’Ì·«  ÃœÌœ :"
        Me.lblEducationTypetxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEducationTypetxt
        '
        Me.txtEducationTypetxt.Location = New System.Drawing.Point(94, 14)
        Me.txtEducationTypetxt.Name = "txtEducationTypetxt"
        Me.txtEducationTypetxt.Size = New System.Drawing.Size(245, 21)
        Me.txtEducationTypetxt.TabIndex = 1
        '
        'grdBranchTxt
        '
        Me.grdBranchTxt.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdBranchTxt.GroupByBoxVisible = False
        Me.grdBranchTxt.Location = New System.Drawing.Point(13, 180)
        Me.grdBranchTxt.Name = "grdBranchTxt"
        Me.grdBranchTxt.Size = New System.Drawing.Size(431, 107)
        Me.grdBranchTxt.TabIndex = 1
        Me.grdBranchTxt.TabStop = False
        '
        'grdEducationType
        '
        Me.grdEducationType.AllowColumnDrag = False
        Me.grdEducationType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEducationType.GroupByBoxVisible = False
        Me.grdEducationType.Location = New System.Drawing.Point(12, 40)
        Me.grdEducationType.Name = "grdEducationType"
        Me.grdEducationType.Size = New System.Drawing.Size(431, 107)
        Me.grdEducationType.TabIndex = 0
        Me.grdEducationType.TabStop = False
        '
        'frmAddMadrak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 441)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddMadrak"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "‰Ê⁄  Õ’Ì·« "
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grdAttitudeName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdBranchTxt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEducationType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdEducationType As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtEducationTypetxt As System.Windows.Forms.TextBox
    Friend WithEvents grdBranchTxt As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblEducationTypetxt As System.Windows.Forms.Label
    Friend WithEvents btnAddEducationType As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAddBranchTxt As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblBranchTxt As System.Windows.Forms.Label
    Friend WithEvents txtBranchTxt As System.Windows.Forms.TextBox
    Friend WithEvents btnAddAttitudeName As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblAttitudeName As System.Windows.Forms.Label
    Friend WithEvents txtAttitudeName As System.Windows.Forms.TextBox
    Friend WithEvents grdAttitudeName As Janus.Windows.GridEX.GridEX
End Class
