<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSSale
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
        Me.grdPerson = New Janus.Windows.GridEX.GridEX
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPerson
        '
        Me.grdPerson.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPerson.CellToolTipText = "جهت كاربري سريعتر بر روي نام هر فرد كليك راست نماييد"
        Me.grdPerson.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grdPerson.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.grdPerson.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grdPerson.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grdPerson.Location = New System.Drawing.Point(38, 31)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.RecordNavigator = True
        Me.grdPerson.Size = New System.Drawing.Size(934, 408)
        Me.grdPerson.TabIndex = 7
        Me.grdPerson.TabStop = False
        '
        'frmPRSSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 463)
        Me.Controls.Add(Me.grdPerson)
        Me.Name = "frmPRSSale"
        Me.Text = "حقوق و دستمزد"
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdPerson As Janus.Windows.GridEX.GridEX
End Class
