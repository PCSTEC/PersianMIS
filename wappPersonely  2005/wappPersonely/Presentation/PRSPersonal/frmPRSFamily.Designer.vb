<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSFamily
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSFamily))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.JGrade1 = New JFrameWork.jGrade
        Me.cmbIssueCity = New System.Windows.Forms.ComboBox
        Me.cmbBirthCity = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblPersonName = New System.Windows.Forms.Label
        Me.btnSaveChange = New Janus.Windows.EditControls.UIButton
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.lblBirthCityID = New System.Windows.Forms.Label
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.btnChange = New Janus.Windows.EditControls.UIButton
        Me.btnDelete = New Janus.Windows.EditControls.UIButton
        Me.lblIssueID = New System.Windows.Forms.Label
        Me.txtNationalcode = New System.Windows.Forms.TextBox
        Me.lblncode = New System.Windows.Forms.Label
        Me.cmbAffine = New System.Windows.Forms.ComboBox
        Me.txtBirthDate = New System.Windows.Forms.MaskedTextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtIDNum = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.lblAffine = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblprsCode = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblBirthDate = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.grdFamily = New Janus.Windows.GridEX.GridEX
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbmarried = New System.Windows.Forms.ComboBox
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdFamily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(839, 570)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox2.Controls.Add(Me.cmbmarried)
        Me.UiGroupBox2.Controls.Add(Me.Label2)
        Me.UiGroupBox2.Controls.Add(Me.JGrade1)
        Me.UiGroupBox2.Controls.Add(Me.cmbIssueCity)
        Me.UiGroupBox2.Controls.Add(Me.cmbBirthCity)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonName)
        Me.UiGroupBox2.Controls.Add(Me.btnSaveChange)
        Me.UiGroupBox2.Controls.Add(Me.UiButton1)
        Me.UiGroupBox2.Controls.Add(Me.lblBirthCityID)
        Me.UiGroupBox2.Controls.Add(Me.btnAdd)
        Me.UiGroupBox2.Controls.Add(Me.btnChange)
        Me.UiGroupBox2.Controls.Add(Me.btnDelete)
        Me.UiGroupBox2.Controls.Add(Me.lblIssueID)
        Me.UiGroupBox2.Controls.Add(Me.txtNationalcode)
        Me.UiGroupBox2.Controls.Add(Me.lblncode)
        Me.UiGroupBox2.Controls.Add(Me.cmbAffine)
        Me.UiGroupBox2.Controls.Add(Me.txtBirthDate)
        Me.UiGroupBox2.Controls.Add(Me.txtFirstName)
        Me.UiGroupBox2.Controls.Add(Me.txtIDNum)
        Me.UiGroupBox2.Controls.Add(Me.txtLastName)
        Me.UiGroupBox2.Controls.Add(Me.lblAffine)
        Me.UiGroupBox2.Controls.Add(Me.lblName)
        Me.UiGroupBox2.Controls.Add(Me.lblprsCode)
        Me.UiGroupBox2.Controls.Add(Me.Label7)
        Me.UiGroupBox2.Controls.Add(Me.Label8)
        Me.UiGroupBox2.Controls.Add(Me.lblBirthDate)
        Me.UiGroupBox2.Controls.Add(Me.Label6)
        Me.UiGroupBox2.Controls.Add(Me.Label4)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 0)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(772, 173)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(-3, 0)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(133, 68)
        Me.JGrade1.TabIndex = 27
        '
        'cmbIssueCity
        '
        Me.cmbIssueCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIssueCity.FormattingEnabled = True
        Me.cmbIssueCity.Location = New System.Drawing.Point(186, 58)
        Me.cmbIssueCity.Name = "cmbIssueCity"
        Me.cmbIssueCity.Size = New System.Drawing.Size(141, 21)
        Me.cmbIssueCity.TabIndex = 17
        '
        'cmbBirthCity
        '
        Me.cmbBirthCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBirthCity.FormattingEnabled = True
        Me.cmbBirthCity.Location = New System.Drawing.Point(186, 31)
        Me.cmbBirthCity.Name = "cmbBirthCity"
        Me.cmbBirthCity.Size = New System.Drawing.Size(141, 21)
        Me.cmbBirthCity.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(478, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "‰«„ Ê ‰«„ Œ«‰Ê«œêÌ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPersonName
        '
        Me.lblPersonName.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonName.ForeColor = System.Drawing.Color.Red
        Me.lblPersonName.Location = New System.Drawing.Point(247, 10)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(229, 20)
        Me.lblPersonName.TabIndex = 3
        Me.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveChange
        '
        Me.btnSaveChange.Icon = CType(resources.GetObject("btnSaveChange.Icon"), System.Drawing.Icon)
        Me.btnSaveChange.Location = New System.Drawing.Point(539, 147)
        Me.btnSaveChange.Name = "btnSaveChange"
        Me.btnSaveChange.Size = New System.Drawing.Size(80, 23)
        Me.btnSaveChange.TabIndex = 24
        Me.btnSaveChange.Text = "À»   €ÌÌ—« "
        Me.btnSaveChange.Visible = False
        Me.btnSaveChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton1
        '
        Me.UiButton1.Icon = CType(resources.GetObject("UiButton1.Icon"), System.Drawing.Icon)
        Me.UiButton1.Location = New System.Drawing.Point(222, 147)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(75, 23)
        Me.UiButton1.TabIndex = 26
        Me.UiButton1.Text = "«‰’—«›"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblBirthCityID
        '
        Me.lblBirthCityID.Location = New System.Drawing.Point(408, 33)
        Me.lblBirthCityID.Name = "lblBirthCityID"
        Me.lblBirthCityID.Size = New System.Drawing.Size(16, 19)
        Me.lblBirthCityID.TabIndex = 12
        Me.lblBirthCityID.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(510, 147)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "À» "
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnChange
        '
        Me.btnChange.Icon = CType(resources.GetObject("btnChange.Icon"), System.Drawing.Icon)
        Me.btnChange.Location = New System.Drawing.Point(415, 147)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 23
        Me.btnChange.Text = "ÊÌ—«Ì‘"
        Me.btnChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnDelete
        '
        Me.btnDelete.Icon = CType(resources.GetObject("btnDelete.Icon"), System.Drawing.Icon)
        Me.btnDelete.Location = New System.Drawing.Point(318, 147)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Õ–›"
        Me.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblIssueID
        '
        Me.lblIssueID.Location = New System.Drawing.Point(408, 61)
        Me.lblIssueID.Name = "lblIssueID"
        Me.lblIssueID.Size = New System.Drawing.Size(16, 19)
        Me.lblIssueID.TabIndex = 13
        Me.lblIssueID.Visible = False
        '
        'txtNationalcode
        '
        Me.txtNationalcode.Location = New System.Drawing.Point(139, 112)
        Me.txtNationalcode.Name = "txtNationalcode"
        Me.txtNationalcode.Size = New System.Drawing.Size(187, 21)
        Me.txtNationalcode.TabIndex = 21
        '
        'lblncode
        '
        Me.lblncode.BackColor = System.Drawing.Color.Transparent
        Me.lblncode.Location = New System.Drawing.Point(332, 113)
        Me.lblncode.Name = "lblncode"
        Me.lblncode.Size = New System.Drawing.Size(98, 20)
        Me.lblncode.TabIndex = 20
        Me.lblncode.Text = "ﬂœ „·Ì :"
        Me.lblncode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbAffine
        '
        Me.cmbAffine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAffine.FormattingEnabled = True
        Me.cmbAffine.Location = New System.Drawing.Point(508, 90)
        Me.cmbAffine.Name = "cmbAffine"
        Me.cmbAffine.Size = New System.Drawing.Size(176, 21)
        Me.cmbAffine.TabIndex = 9
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Location = New System.Drawing.Point(509, 117)
        Me.txtBirthDate.Mask = "0000/00/00"
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(176, 21)
        Me.txtBirthDate.TabIndex = 11
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(508, 36)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(177, 21)
        Me.txtFirstName.TabIndex = 5
        '
        'txtIDNum
        '
        Me.txtIDNum.Location = New System.Drawing.Point(139, 85)
        Me.txtIDNum.Name = "txtIDNum"
        Me.txtIDNum.Size = New System.Drawing.Size(187, 21)
        Me.txtIDNum.TabIndex = 19
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(508, 63)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(176, 21)
        Me.txtLastName.TabIndex = 7
        '
        'lblAffine
        '
        Me.lblAffine.BackColor = System.Drawing.Color.Transparent
        Me.lblAffine.Location = New System.Drawing.Point(690, 91)
        Me.lblAffine.Name = "lblAffine"
        Me.lblAffine.Size = New System.Drawing.Size(68, 20)
        Me.lblAffine.TabIndex = 8
        Me.lblAffine.Text = "‰”»  :"
        Me.lblAffine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(691, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 20)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "‰«„ :"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblprsCode
        '
        Me.lblprsCode.BackColor = System.Drawing.Color.Transparent
        Me.lblprsCode.Location = New System.Drawing.Point(690, 10)
        Me.lblprsCode.Name = "lblprsCode"
        Me.lblprsCode.Size = New System.Drawing.Size(70, 20)
        Me.lblprsCode.TabIndex = 0
        Me.lblprsCode.Text = "ﬂœ Å—”‰·Ì :"
        Me.lblprsCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(332, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "„Õ·  Ê·œ :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(332, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "„Õ· ’œÊ— :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBirthDate
        '
        Me.lblBirthDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthDate.Location = New System.Drawing.Point(691, 118)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(70, 20)
        Me.lblBirthDate.TabIndex = 10
        Me.lblBirthDate.Text = " «—ÌŒ  Ê·œ :"
        Me.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(332, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "‘„«—Â ‘‰«”‰«„Â :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(690, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "‰«„ Œ«‰Ê«œêÌ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPersonCode
        '
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(592, 10)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(92, 20)
        Me.lblPersonCode.TabIndex = 1
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdFamily
        '
        Me.grdFamily.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdFamily.GroupByBoxVisible = False
        Me.grdFamily.Location = New System.Drawing.Point(3, 178)
        Me.grdFamily.Name = "grdFamily"
        Me.grdFamily.Size = New System.Drawing.Size(772, 388)
        Me.grdFamily.TabIndex = 1
        Me.grdFamily.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(106, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Ê÷⁄Ì   «Â· :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbmarried
        '
        Me.cmbmarried.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmarried.FormattingEnabled = True
        Me.cmbmarried.Location = New System.Drawing.Point(12, 136)
        Me.cmbmarried.Name = "cmbmarried"
        Me.cmbmarried.Size = New System.Drawing.Size(88, 21)
        Me.cmbmarried.TabIndex = 29
        '
        'frmPRSFamily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 568)
        Me.Controls.Add(Me.grdFamily)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPRSFamily"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«ÿ·«⁄«  Œ«‰Ê«œêÌ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grdFamily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdFamily As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblBirthCityID As System.Windows.Forms.Label
    Friend WithEvents lblIssueID As System.Windows.Forms.Label
    Friend WithEvents txtNationalcode As System.Windows.Forms.TextBox
    Friend WithEvents lblncode As System.Windows.Forms.Label
    Friend WithEvents cmbAffine As System.Windows.Forms.ComboBox
    Friend WithEvents txtBirthDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtIDNum As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblAffine As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblprsCode As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents btnSaveChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDelete As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPersonName As System.Windows.Forms.Label
    Friend WithEvents cmbIssueCity As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBirthCity As System.Windows.Forms.ComboBox
    Friend WithEvents JGrade1 As JFrameWork.jGrade
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbmarried As System.Windows.Forms.ComboBox
End Class
