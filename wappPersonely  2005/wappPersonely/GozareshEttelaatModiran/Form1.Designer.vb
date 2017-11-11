<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRpt = New System.Windows.Forms.Button
        Me.grdPerson = New System.Windows.Forms.DataGrid
        Me.IkidFormToolbar1 = New WLFormGlobalCtrl_DT.IKIDFormToolbar
        Me.DgSelect2 = New IKIDUtility.DgSelect
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(71, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "·ÿ›« «Ì‰ ê“«—‘ —« —ÊÌ ‘»ﬂÂ ‰ê–«—Ìœ «Ì‰ ê“«—‘ „Œ ’ ¬ﬁ«Ì „ÃœÌ „Ì »«‘œ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRpt
        '
        Me.btnRpt.Location = New System.Drawing.Point(200, 385)
        Me.btnRpt.Name = "btnRpt"
        Me.btnRpt.Size = New System.Drawing.Size(156, 23)
        Me.btnRpt.TabIndex = 1
        Me.btnRpt.Text = "ê“«—‘ «ÿ·«⁄«  ›—œÌ „œÌ—«‰"
        Me.btnRpt.UseVisualStyleBackColor = True
        '
        'grdPerson
        '
        Me.grdPerson.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPerson.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grdPerson.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdPerson.CaptionText = "Å—”‰· ‘«€·"
        Me.grdPerson.DataMember = ""
        Me.grdPerson.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPerson.Location = New System.Drawing.Point(12, 60)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.ReadOnly = True
        Me.grdPerson.SelectionBackColor = System.Drawing.Color.Yellow
        Me.grdPerson.Size = New System.Drawing.Size(521, 319)
        Me.grdPerson.TabIndex = 7
        Me.grdPerson.TabStop = False
        '
        'IkidFormToolbar1
        '
        Me.IkidFormToolbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.IkidFormToolbar1.Location = New System.Drawing.Point(193, 32)
        Me.IkidFormToolbar1.Name = "IkidFormToolbar1"
        Me.IkidFormToolbar1.Size = New System.Drawing.Size(273, 22)
        Me.IkidFormToolbar1.TabIndex = 8
        '
        'DgSelect2
        '
        Me.DgSelect2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DgSelect2.Location = New System.Drawing.Point(56, 31)
        Me.DgSelect2.Name = "DgSelect2"
        Me.DgSelect2.Size = New System.Drawing.Size(136, 24)
        Me.DgSelect2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 411)
        Me.Controls.Add(Me.IkidFormToolbar1)
        Me.Controls.Add(Me.DgSelect2)
        Me.Controls.Add(Me.grdPerson)
        Me.Controls.Add(Me.btnRpt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRpt As System.Windows.Forms.Button
    Friend WithEvents grdPerson As System.Windows.Forms.DataGrid
    Friend WithEvents IkidFormToolbar1 As WLFormGlobalCtrl_DT.IKIDFormToolbar
    Friend WithEvents DgSelect2 As IKIDUtility.DgSelect
End Class
