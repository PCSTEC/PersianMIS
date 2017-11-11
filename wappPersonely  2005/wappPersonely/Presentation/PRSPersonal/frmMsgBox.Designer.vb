<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgBox))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.lbltxt = New System.Windows.Forms.Label
        Me.btnYes = New Janus.Windows.EditControls.UIButton
        Me.btnNo = New Janus.Windows.EditControls.UIButton
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox1.Controls.Add(Me.btnNo)
        Me.UiGroupBox1.Controls.Add(Me.btnYes)
        Me.UiGroupBox1.Controls.Add(Me.lbltxt)
        Me.UiGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -2)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(424, 75)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'lbltxt
        '
        Me.lbltxt.BackColor = System.Drawing.Color.Transparent
        Me.lbltxt.Font = New System.Drawing.Font("Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbltxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbltxt.Location = New System.Drawing.Point(3, 11)
        Me.lbltxt.Name = "lbltxt"
        Me.lbltxt.Size = New System.Drawing.Size(420, 34)
        Me.lbltxt.TabIndex = 0
        Me.lbltxt.Text = "¬Ì« „«Ì· »Â „‘«ÂœÂ ·Ì”  «›—«œÌ ﬂÂ ﬁ—«—œ«œ‘«‰ œ— Õ«· « „«„ «”  ° „Ì »«‘Ìœ ø"
        Me.lbltxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(233, 48)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(68, 22)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "»·Ì"
        Me.btnYes.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(124, 48)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(68, 22)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "ŒÌ—"
        Me.btnNo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'frmMsgBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 73)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsgBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnNo As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnYes As Janus.Windows.EditControls.UIButton
    Friend WithEvents lbltxt As System.Windows.Forms.Label
End Class
