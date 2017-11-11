<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSakhti
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.btnView = New System.Windows.Forms.Button
        Me.JSelect12 = New System.Windows.Forms.GroupBox
        Me.RdNonSel = New System.Windows.Forms.RadioButton
        Me.rdbtnRev = New System.Windows.Forms.RadioButton
        Me.rdbtnNone = New System.Windows.Forms.RadioButton
        Me.rdbtnAll = New System.Windows.Forms.RadioButton
        Me.dgdMDepart = New Janus.Windows.GridEX.GridEX
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rdbtnRevMDep = New System.Windows.Forms.RadioButton
        Me.rdbtnNoneMDep = New System.Windows.Forms.RadioButton
        Me.rdbtnAllMDep = New System.Windows.Forms.RadioButton
        Me.dgdPost = New Janus.Windows.GridEX.GridEX
        Me.dgdPerson = New Janus.Windows.GridEX.GridEX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.rdbtnRevPerson = New System.Windows.Forms.RadioButton
        Me.rdbtnNonePerson = New System.Windows.Forms.RadioButton
        Me.rdbtnAllPerson = New System.Windows.Forms.RadioButton
        Me.chkALL = New System.Windows.Forms.CheckBox
        Me.JSelect12.SuspendLayout()
        CType(Me.dgdMDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgdPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(776, 9)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 17
        Me.btnView.Text = "نمایش"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'JSelect12
        '
        Me.JSelect12.Controls.Add(Me.RdNonSel)
        Me.JSelect12.Controls.Add(Me.rdbtnRev)
        Me.JSelect12.Controls.Add(Me.rdbtnNone)
        Me.JSelect12.Controls.Add(Me.rdbtnAll)
        Me.JSelect12.Location = New System.Drawing.Point(17, 32)
        Me.JSelect12.Name = "JSelect12"
        Me.JSelect12.Size = New System.Drawing.Size(195, 29)
        Me.JSelect12.TabIndex = 118
        Me.JSelect12.TabStop = False
        '
        'RdNonSel
        '
        Me.RdNonSel.AutoSize = True
        Me.RdNonSel.Location = New System.Drawing.Point(75, 56)
        Me.RdNonSel.Name = "RdNonSel"
        Me.RdNonSel.Size = New System.Drawing.Size(58, 17)
        Me.RdNonSel.TabIndex = 3
        Me.RdNonSel.TabStop = True
        Me.RdNonSel.Text = "NonSel"
        Me.RdNonSel.UseVisualStyleBackColor = True
        '
        'rdbtnRev
        '
        Me.rdbtnRev.AutoSize = True
        Me.rdbtnRev.Location = New System.Drawing.Point(8, 8)
        Me.rdbtnRev.Name = "rdbtnRev"
        Me.rdbtnRev.Size = New System.Drawing.Size(44, 17)
        Me.rdbtnRev.TabIndex = 2
        Me.rdbtnRev.TabStop = True
        Me.rdbtnRev.Text = "Rev"
        Me.rdbtnRev.UseVisualStyleBackColor = True
        '
        'rdbtnNone
        '
        Me.rdbtnNone.AutoSize = True
        Me.rdbtnNone.Location = New System.Drawing.Point(70, 8)
        Me.rdbtnNone.Name = "rdbtnNone"
        Me.rdbtnNone.Size = New System.Drawing.Size(50, 17)
        Me.rdbtnNone.TabIndex = 1
        Me.rdbtnNone.TabStop = True
        Me.rdbtnNone.Text = "None"
        Me.rdbtnNone.UseVisualStyleBackColor = True
        '
        'rdbtnAll
        '
        Me.rdbtnAll.AutoSize = True
        Me.rdbtnAll.Location = New System.Drawing.Point(143, 8)
        Me.rdbtnAll.Name = "rdbtnAll"
        Me.rdbtnAll.Size = New System.Drawing.Size(36, 17)
        Me.rdbtnAll.TabIndex = 0
        Me.rdbtnAll.TabStop = True
        Me.rdbtnAll.Text = "All"
        Me.rdbtnAll.UseVisualStyleBackColor = True
        '
        'dgdMDepart
        '
        Me.dgdMDepart.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.dgdMDepart.AllowDrop = True
        Me.dgdMDepart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdMDepart.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable></GridEXLayoutDa" & _
            "ta>"
        Me.dgdMDepart.DesignTimeLayout = GridEXLayout1
        Me.dgdMDepart.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.dgdMDepart.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.dgdMDepart.GroupByBoxVisible = False
        Me.dgdMDepart.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.dgdMDepart.Location = New System.Drawing.Point(702, 64)
        Me.dgdMDepart.Name = "dgdMDepart"
        Me.dgdMDepart.Size = New System.Drawing.Size(336, 537)
        Me.dgdMDepart.TabIndex = 119
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rdbtnRevMDep)
        Me.GroupBox1.Controls.Add(Me.rdbtnNoneMDep)
        Me.GroupBox1.Controls.Add(Me.rdbtnAllMDep)
        Me.GroupBox1.Location = New System.Drawing.Point(758, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 29)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(75, 56)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "NonSel"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rdbtnRevMDep
        '
        Me.rdbtnRevMDep.AutoSize = True
        Me.rdbtnRevMDep.Location = New System.Drawing.Point(8, 8)
        Me.rdbtnRevMDep.Name = "rdbtnRevMDep"
        Me.rdbtnRevMDep.Size = New System.Drawing.Size(44, 17)
        Me.rdbtnRevMDep.TabIndex = 2
        Me.rdbtnRevMDep.TabStop = True
        Me.rdbtnRevMDep.Text = "Rev"
        Me.rdbtnRevMDep.UseVisualStyleBackColor = True
        '
        'rdbtnNoneMDep
        '
        Me.rdbtnNoneMDep.AutoSize = True
        Me.rdbtnNoneMDep.Location = New System.Drawing.Point(70, 8)
        Me.rdbtnNoneMDep.Name = "rdbtnNoneMDep"
        Me.rdbtnNoneMDep.Size = New System.Drawing.Size(50, 17)
        Me.rdbtnNoneMDep.TabIndex = 1
        Me.rdbtnNoneMDep.TabStop = True
        Me.rdbtnNoneMDep.Text = "None"
        Me.rdbtnNoneMDep.UseVisualStyleBackColor = True
        '
        'rdbtnAllMDep
        '
        Me.rdbtnAllMDep.AutoSize = True
        Me.rdbtnAllMDep.Location = New System.Drawing.Point(143, 8)
        Me.rdbtnAllMDep.Name = "rdbtnAllMDep"
        Me.rdbtnAllMDep.Size = New System.Drawing.Size(36, 17)
        Me.rdbtnAllMDep.TabIndex = 0
        Me.rdbtnAllMDep.TabStop = True
        Me.rdbtnAllMDep.Text = "All"
        Me.rdbtnAllMDep.UseVisualStyleBackColor = True
        '
        'dgdPost
        '
        Me.dgdPost.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.dgdPost.AllowDrop = True
        Me.dgdPost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable></GridEXLayoutDa" & _
            "ta>"
        Me.dgdPost.DesignTimeLayout = GridEXLayout2
        Me.dgdPost.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.dgdPost.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.dgdPost.GroupByBoxVisible = False
        Me.dgdPost.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.dgdPost.Location = New System.Drawing.Point(22, 63)
        Me.dgdPost.Name = "dgdPost"
        Me.dgdPost.Size = New System.Drawing.Size(326, 537)
        Me.dgdPost.TabIndex = 123
        '
        'dgdPerson
        '
        Me.dgdPerson.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.dgdPerson.AllowDrop = True
        Me.dgdPerson.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdPerson.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable></GridEXLayoutDa" & _
            "ta>"
        Me.dgdPerson.DesignTimeLayout = GridEXLayout3
        Me.dgdPerson.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.dgdPerson.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.dgdPerson.GroupByBoxVisible = False
        Me.dgdPerson.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.dgdPerson.Location = New System.Drawing.Point(354, 65)
        Me.dgdPerson.Name = "dgdPerson"
        Me.dgdPerson.Size = New System.Drawing.Size(342, 537)
        Me.dgdPerson.TabIndex = 125
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.rdbtnRevPerson)
        Me.GroupBox2.Controls.Add(Me.rdbtnNonePerson)
        Me.GroupBox2.Controls.Add(Me.rdbtnAllPerson)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 29)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(75, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "NonSel"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rdbtnRevPerson
        '
        Me.rdbtnRevPerson.AutoSize = True
        Me.rdbtnRevPerson.Location = New System.Drawing.Point(8, 8)
        Me.rdbtnRevPerson.Name = "rdbtnRevPerson"
        Me.rdbtnRevPerson.Size = New System.Drawing.Size(44, 17)
        Me.rdbtnRevPerson.TabIndex = 2
        Me.rdbtnRevPerson.TabStop = True
        Me.rdbtnRevPerson.Text = "Rev"
        Me.rdbtnRevPerson.UseVisualStyleBackColor = True
        '
        'rdbtnNonePerson
        '
        Me.rdbtnNonePerson.AutoSize = True
        Me.rdbtnNonePerson.Location = New System.Drawing.Point(70, 8)
        Me.rdbtnNonePerson.Name = "rdbtnNonePerson"
        Me.rdbtnNonePerson.Size = New System.Drawing.Size(50, 17)
        Me.rdbtnNonePerson.TabIndex = 1
        Me.rdbtnNonePerson.TabStop = True
        Me.rdbtnNonePerson.Text = "None"
        Me.rdbtnNonePerson.UseVisualStyleBackColor = True
        '
        'rdbtnAllPerson
        '
        Me.rdbtnAllPerson.AutoSize = True
        Me.rdbtnAllPerson.Location = New System.Drawing.Point(143, 8)
        Me.rdbtnAllPerson.Name = "rdbtnAllPerson"
        Me.rdbtnAllPerson.Size = New System.Drawing.Size(36, 17)
        Me.rdbtnAllPerson.TabIndex = 0
        Me.rdbtnAllPerson.TabStop = True
        Me.rdbtnAllPerson.Text = "All"
        Me.rdbtnAllPerson.UseVisualStyleBackColor = True
        '
        'chkALL
        '
        Me.chkALL.AutoSize = True
        Me.chkALL.Checked = True
        Me.chkALL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkALL.Location = New System.Drawing.Point(258, 41)
        Me.chkALL.Name = "chkALL"
        Me.chkALL.Size = New System.Drawing.Size(50, 17)
        Me.chkALL.TabIndex = 127
        Me.chkALL.Text = "همه "
        Me.chkALL.UseVisualStyleBackColor = True
        '
        'frmReportSakhti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 613)
        Me.Controls.Add(Me.chkALL)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgdPerson)
        Me.Controls.Add(Me.dgdPost)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgdMDepart)
        Me.Controls.Add(Me.JSelect12)
        Me.Controls.Add(Me.btnView)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "frmReportSakhti"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "گزارش ها"
        Me.JSelect12.ResumeLayout(False)
        Me.JSelect12.PerformLayout()
        CType(Me.dgdMDepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgdPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents JSelect12 As System.Windows.Forms.GroupBox
    Friend WithEvents RdNonSel As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnRev As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnNone As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnAll As System.Windows.Forms.RadioButton
    Friend WithEvents dgdMDepart As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnRevMDep As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnNoneMDep As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnAllMDep As System.Windows.Forms.RadioButton
    Friend WithEvents dgdPost As Janus.Windows.GridEX.GridEX
    Friend WithEvents dgdPerson As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnRevPerson As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnNonePerson As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnAllPerson As System.Windows.Forms.RadioButton
    Friend WithEvents chkALL As System.Windows.Forms.CheckBox
End Class
