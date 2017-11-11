<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJob
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
        Me.cmbJobTitle = New System.Windows.Forms.ComboBox
        Me.CmbDiplom = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbGroup = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPerson
        '
        Me.grdPerson.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPerson.CellToolTipText = "ÃÂ  ﬂ«—»—Ì ”—Ì⁄ — »— —ÊÌ ‰«„ Â— ›—œ ﬂ·Ìﬂ —«”  ‰„«ÌÌœ"
        Me.grdPerson.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grdPerson.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.grdPerson.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grdPerson.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grdPerson.Location = New System.Drawing.Point(3, 153)
        Me.grdPerson.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.RecordNavigator = True
        Me.grdPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grdPerson.Size = New System.Drawing.Size(1025, 528)
        Me.grdPerson.TabIndex = 7
        Me.grdPerson.TabStop = False
        '
        'cmbJobTitle
        '
        Me.cmbJobTitle.FormattingEnabled = True
        Me.cmbJobTitle.Location = New System.Drawing.Point(657, 18)
        Me.cmbJobTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbJobTitle.Name = "cmbJobTitle"
        Me.cmbJobTitle.Size = New System.Drawing.Size(283, 24)
        Me.cmbJobTitle.TabIndex = 8
        '
        'CmbDiplom
        '
        Me.CmbDiplom.FormattingEnabled = True
        Me.CmbDiplom.Location = New System.Drawing.Point(405, 18)
        Me.CmbDiplom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbDiplom.Name = "CmbDiplom"
        Me.CmbDiplom.Size = New System.Drawing.Size(148, 24)
        Me.CmbDiplom.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(360, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(39, 32)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "ê—ÊÂ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(940, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(82, 32)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "⁄‰Ê«‰ ‘€· :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(553, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(98, 32)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "„œ—ﬂ  Õ’Ì·Ì:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(165, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(78, 32)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = " Ã—»Â :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGroup
        '
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(217, 16)
        Me.cmbGroup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(140, 24)
        Me.cmbGroup.TabIndex = 59
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 16)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(94, 23)
        Me.TextBox1.TabIndex = 60
        '
        'FrmJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1032, 687)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmbGroup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbDiplom)
        Me.Controls.Add(Me.cmbJobTitle)
        Me.Controls.Add(Me.grdPerson)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmJob"
        Me.Text = "«ÿ·«⁄«  Å«ÌÂ"
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdPerson As Janus.Windows.GridEX.GridEX
    Friend WithEvents cmbJobTitle As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDiplom As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
