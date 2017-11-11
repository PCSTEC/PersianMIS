<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHokmMoavvagheh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHokmMoavvagheh))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblPersonName = New System.Windows.Forms.Label
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New Janus.Windows.EditControls.UIButton
        Me.btnNewHokm = New Janus.Windows.EditControls.UIButton
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtMoavvaghehDate = New System.Windows.Forms.MaskedTextBox
        Me.Label22 = New System.Windows.Forms.Label
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(330, 194)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox2.Controls.Add(Me.lblPersonName)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Controls.Add(Me.btnClose)
        Me.UiGroupBox2.Controls.Add(Me.btnNewHokm)
        Me.UiGroupBox2.Controls.Add(Me.Label24)
        Me.UiGroupBox2.Controls.Add(Me.txtMoavvaghehDate)
        Me.UiGroupBox2.Controls.Add(Me.Label22)
        Me.UiGroupBox2.Location = New System.Drawing.Point(1, -3)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(325, 191)
        Me.UiGroupBox2.TabIndex = 98
        '
        'lblPersonName
        '
        Me.lblPersonName.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonName.ForeColor = System.Drawing.Color.Red
        Me.lblPersonName.Location = New System.Drawing.Point(19, 64)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(206, 26)
        Me.lblPersonName.TabIndex = 107
        Me.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPersonCode
        '
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(123, 15)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(94, 26)
        Me.lblPersonCode.TabIndex = 106
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(231, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 26)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "‰«„ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Icon = CType(resources.GetObject("btnClose.Icon"), System.Drawing.Icon)
        Me.btnClose.Location = New System.Drawing.Point(66, 161)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "«‰’—«›"
        Me.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnNewHokm
        '
        Me.btnNewHokm.Icon = CType(resources.GetObject("btnNewHokm.Icon"), System.Drawing.Icon)
        Me.btnNewHokm.Location = New System.Drawing.Point(171, 161)
        Me.btnNewHokm.Name = "btnNewHokm"
        Me.btnNewHokm.Size = New System.Drawing.Size(94, 23)
        Me.btnNewHokm.TabIndex = 2
        Me.btnNewHokm.Text = "„‘«ÂœÂ «Õﬂ«„"
        Me.btnNewHokm.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(231, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(94, 26)
        Me.Label24.TabIndex = 102
        Me.Label24.Text = "ﬂœ Å—”‰·Ì :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMoavvaghehDate
        '
        Me.txtMoavvaghehDate.Location = New System.Drawing.Point(56, 118)
        Me.txtMoavvaghehDate.Mask = "0000/00/00"
        Me.txtMoavvaghehDate.Name = "txtMoavvaghehDate"
        Me.txtMoavvaghehDate.Size = New System.Drawing.Size(169, 21)
        Me.txtMoavvaghehDate.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(231, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 26)
        Me.Label22.TabIndex = 101
        Me.Label22.Text = " «—ÌŒ „⁄ÊﬁÂ :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmHokmMoavvagheh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 192)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHokmMoavvagheh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Õﬂ„ „⁄ÊﬁÂ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblPersonName As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNewHokm As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtMoavvaghehDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
