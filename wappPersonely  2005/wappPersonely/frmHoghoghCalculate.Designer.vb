<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoghoghCalculate
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
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnSoldierFeeCalculate = New Janus.Windows.EditControls.UIButton
        Me.btnHoghoghCalculate = New Janus.Windows.EditControls.UIButton
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.UiButton1)
        Me.UiGroupBox1.Controls.Add(Me.btnSoldierFeeCalculate)
        Me.UiGroupBox1.Controls.Add(Me.btnHoghoghCalculate)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-2, -3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(368, 270)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnSoldierFeeCalculate
        '
        Me.btnSoldierFeeCalculate.Font = New System.Drawing.Font("Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnSoldierFeeCalculate.Location = New System.Drawing.Point(34, 43)
        Me.btnSoldierFeeCalculate.Name = "btnSoldierFeeCalculate"
        Me.btnSoldierFeeCalculate.Size = New System.Drawing.Size(106, 36)
        Me.btnSoldierFeeCalculate.TabIndex = 2
        Me.btnSoldierFeeCalculate.Text = "„Õ«”»Â Õﬁ ”—»«“Ì"
        Me.btnSoldierFeeCalculate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnHoghoghCalculate
        '
        Me.btnHoghoghCalculate.Font = New System.Drawing.Font("Nazanin", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnHoghoghCalculate.Location = New System.Drawing.Point(176, 43)
        Me.btnHoghoghCalculate.Name = "btnHoghoghCalculate"
        Me.btnHoghoghCalculate.Size = New System.Drawing.Size(106, 36)
        Me.btnHoghoghCalculate.TabIndex = 1
        Me.btnHoghoghCalculate.Text = "„Õ«”»Â ÕﬁÊﬁ"
        Me.btnHoghoghCalculate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton1
        '
        Me.UiButton1.Font = New System.Drawing.Font("Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton1.Location = New System.Drawing.Point(131, 117)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(106, 36)
        Me.UiButton1.TabIndex = 3
        Me.UiButton1.Text = "sdf"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'frmHoghoghCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 264)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHoghoghCalculate"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "„Õ«”»Â ÕﬁÊﬁ ”«· »⁄œ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnHoghoghCalculate As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSoldierFeeCalculate As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
End Class
