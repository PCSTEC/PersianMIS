<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPezeshki
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
        Me.btnPicIns = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtEmissionDate = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdPerson = New Janus.Windows.GridEX.GridEX
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPicIns
        '
        Me.btnPicIns.Location = New System.Drawing.Point(25, 485)
        Me.btnPicIns.Name = "btnPicIns"
        Me.btnPicIns.Size = New System.Drawing.Size(75, 23)
        Me.btnPicIns.TabIndex = 0
        Me.btnPicIns.Text = "ثبت آزمایش"
        Me.btnPicIns.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(433, 473)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtEmissionDate
        '
        Me.txtEmissionDate.Location = New System.Drawing.Point(130, 488)
        Me.txtEmissionDate.Mask = "0000/00/00"
        Me.txtEmissionDate.Name = "txtEmissionDate"
        Me.txtEmissionDate.Size = New System.Drawing.Size(95, 20)
        Me.txtEmissionDate.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 490)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "تاریخ آزمایش"
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
        Me.grdPerson.Location = New System.Drawing.Point(502, 6)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.RecordNavigator = True
        Me.grdPerson.Size = New System.Drawing.Size(312, 473)
        Me.grdPerson.TabIndex = 21
        Me.grdPerson.TabStop = False
        '
        'FrmPezeshki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 520)
        Me.Controls.Add(Me.grdPerson)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmissionDate)
        Me.Controls.Add(Me.btnPicIns)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmPezeshki"
        Me.Text = "FrmPezeshki"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPicIns As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtEmissionDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdPerson As Janus.Windows.GridEX.GridEX
End Class
