<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommodeMain
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
        Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommodeMain))
        Dim ExplorerBarItem1 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarItem2 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarItem3 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarItem4 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarItem5 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.ExplorerBar1 = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.grpTimer = New Janus.Windows.EditControls.UIGroupBox
        Me.lblCurrentTime = New System.Windows.Forms.Label
        Me.lblCurDate = New System.Windows.Forms.Label
        Me.JGrade1 = New JFrameWork.jGrade
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExplorerBar1.SuspendLayout()
        CType(Me.grpTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTimer.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.JGrade1)
        Me.UiGroupBox1.Controls.Add(Me.ExplorerBar1)
        Me.UiGroupBox1.Image = CType(resources.GetObject("UiGroupBox1.Image"), System.Drawing.Image)
        Me.UiGroupBox1.ImageSize = New System.Drawing.Size(1150, 850)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 1)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(796, 569)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'ExplorerBar1
        '
        Me.ExplorerBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExplorerBar1.Controls.Add(Me.grpTimer)
        ExplorerBarGroup1.Icon = CType(resources.GetObject("ExplorerBarGroup1.Icon"), System.Drawing.Icon)
        ExplorerBarItem1.Icon = CType(resources.GetObject("ExplorerBarItem1.Icon"), System.Drawing.Icon)
        ExplorerBarItem1.Key = "btnCommode"
        ExplorerBarItem1.Text = " Œ’Ì’ ﬂ„œ »Â Å—”‰·"
        ExplorerBarGroup1.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem1})
        ExplorerBarGroup1.Key = "grpWorking"
        ExplorerBarGroup1.Text = "ﬂ«—»—Ì ‰—„ «›“«—"
        ExplorerBarGroup2.Icon = CType(resources.GetObject("ExplorerBarGroup2.Icon"), System.Drawing.Icon)
        ExplorerBarItem2.Icon = CType(resources.GetObject("ExplorerBarItem2.Icon"), System.Drawing.Icon)
        ExplorerBarItem2.Key = "btnCommodeAmar"
        ExplorerBarItem2.Text = "ê“«—‘ ¬„«— ﬂ„œÂ«"
        ExplorerBarItem3.Icon = CType(resources.GetObject("ExplorerBarItem3.Icon"), System.Drawing.Icon)
        ExplorerBarItem3.Key = "btnCommodeKhali"
        ExplorerBarItem3.Text = "ê“«—‘ ‘„«—Â ﬂ„œÂ«Ì Œ«·Ì"
        ExplorerBarItem4.Icon = CType(resources.GetObject("ExplorerBarItem4.Icon"), System.Drawing.Icon)
        ExplorerBarItem4.Key = "btnCommodeAndPersonTafkik"
        ExplorerBarItem4.Text = "ê“«—‘  Œ’Ì’ ﬂ„œ »Â  ›ﬂÌﬂ Ê«Õœ"
        ExplorerBarGroup2.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem2, ExplorerBarItem3, ExplorerBarItem4})
        ExplorerBarGroup2.Key = "grpReprt"
        ExplorerBarGroup2.Text = "ê“«—‘ êÌ—Ì"
        ExplorerBarGroup3.Icon = CType(resources.GetObject("ExplorerBarGroup3.Icon"), System.Drawing.Icon)
        ExplorerBarItem5.Icon = CType(resources.GetObject("ExplorerBarItem5.Icon"), System.Drawing.Icon)
        ExplorerBarItem5.Key = "btnClose"
        ExplorerBarItem5.Text = "Œ—ÊÃ"
        ExplorerBarGroup3.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem5})
        ExplorerBarGroup3.Key = "grpClose"
        ExplorerBarGroup3.Text = "Œ—ÊÃ"
        Me.ExplorerBar1.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1, ExplorerBarGroup2, ExplorerBarGroup3})
        Me.ExplorerBar1.HoverItemFormatStyle.FontUnderline = Janus.Windows.ExplorerBar.TriState.[True]
        Me.ExplorerBar1.Location = New System.Drawing.Point(555, 0)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.Selectable = True
        Me.ExplorerBar1.Size = New System.Drawing.Size(238, 565)
        Me.ExplorerBar1.TabIndex = 3
        '
        'grpTimer
        '
        Me.grpTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTimer.BackColor = System.Drawing.Color.Transparent
        Me.grpTimer.BorderColor = System.Drawing.Color.Transparent
        Me.grpTimer.Controls.Add(Me.lblCurrentTime)
        Me.grpTimer.Controls.Add(Me.lblCurDate)
        Me.grpTimer.Location = New System.Drawing.Point(68, 511)
        Me.grpTimer.Name = "grpTimer"
        Me.grpTimer.Size = New System.Drawing.Size(164, 51)
        Me.grpTimer.TabIndex = 3
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentTime.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentTime.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCurrentTime.ForeColor = System.Drawing.Color.Yellow
        Me.lblCurrentTime.Location = New System.Drawing.Point(3, 2)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(160, 25)
        Me.lblCurrentTime.TabIndex = 1
        Me.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurDate
        '
        Me.lblCurDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurDate.BackColor = System.Drawing.Color.Transparent
        Me.lblCurDate.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCurDate.ForeColor = System.Drawing.Color.Yellow
        Me.lblCurDate.Location = New System.Drawing.Point(3, 28)
        Me.lblCurDate.Name = "lblCurDate"
        Me.lblCurDate.Size = New System.Drawing.Size(160, 23)
        Me.lblCurDate.TabIndex = 2
        Me.lblCurDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(0, 0)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 4
        '
        'frmCommodeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCommodeMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "ﬂ„œ ·»«” Å—”‰·"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExplorerBar1.ResumeLayout(False)
        CType(Me.grpTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTimer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents ExplorerBar1 As Janus.Windows.ExplorerBar.ExplorerBar
    Friend WithEvents grpTimer As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCurrentTime As System.Windows.Forms.Label
    Friend WithEvents lblCurDate As System.Windows.Forms.Label
    Friend WithEvents JGrade1 As JFrameWork.jGrade
End Class
