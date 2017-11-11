<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostaafiPerson
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMostaafiPerson))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.grdPerson = New Janus.Windows.GridEX.GridEX
        Me.btPrint = New Janus.Windows.EditControls.UIButton
        Me.btnClose = New Janus.Windows.EditControls.UIButton
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.grdPerson)
        Me.UiGroupBox1.Controls.Add(Me.btPrint)
        Me.UiGroupBox1.Controls.Add(Me.btnClose)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(561, 226)
        Me.UiGroupBox1.TabIndex = 0
        '
        'grdPerson
        '
        Me.grdPerson.Location = New System.Drawing.Point(9, 5)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.Size = New System.Drawing.Size(542, 187)
        Me.grdPerson.TabIndex = 4
        '
        'btPrint
        '
        Me.btPrint.Icon = CType(resources.GetObject("btPrint.Icon"), System.Drawing.Icon)
        Me.btPrint.Location = New System.Drawing.Point(274, 198)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(54, 23)
        Me.btPrint.TabIndex = 2
        Me.btPrint.Text = "ç«Å"
        Me.btPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnClose
        '
        Me.btnClose.Icon = CType(resources.GetObject("btnClose.Icon"), System.Drawing.Icon)
        Me.btnClose.Location = New System.Drawing.Point(211, 198)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "«‰’—«›"
        Me.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'frmMostaafiPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 224)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMostaafiPerson"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "œ—Ã ‘„«—Â ﬂ„œ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdPerson As Janus.Windows.GridEX.GridEX
End Class
