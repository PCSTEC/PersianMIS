<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOlad_18
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
        Me.grdOlad = New Janus.Windows.GridEX.GridEX
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.grdOlad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdOlad
        '
        Me.grdOlad.AllowColumnDrag = False
        Me.grdOlad.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdOlad.GroupByBoxVisible = False
        Me.grdOlad.Location = New System.Drawing.Point(12, 61)
        Me.grdOlad.Name = "grdOlad"
        Me.grdOlad.Size = New System.Drawing.Size(977, 470)
        Me.grdOlad.TabIndex = 1
        Me.grdOlad.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "گزارش اکسل"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmOlad_18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 543)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grdOlad)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "FrmOlad_18"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "فرم اولاد بالای 18 سال"
        CType(Me.grdOlad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdOlad As Janus.Windows.GridEX.GridEX
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
