<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSEducation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSEducation))
        Me.btnDelete = New Janus.Windows.EditControls.UIButton
        Me.btnChange = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblAttitudeCode = New System.Windows.Forms.Label
        Me.lblAttitudeID = New System.Windows.Forms.Label
        Me.lblStudyPlaceCode = New System.Windows.Forms.Label
        Me.btnAtitude = New Janus.Windows.EditControls.UIButton
        Me.btnStudyPlace = New Janus.Windows.EditControls.UIButton
        Me.lblStudyPlace = New System.Windows.Forms.Label
        Me.lblAtitude = New System.Windows.Forms.Label
        Me.btnSaveChange = New Janus.Windows.EditControls.UIButton
        Me.lblName = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.lblStudyPlaceID = New System.Windows.Forms.Label
        Me.lblDiplomaID = New System.Windows.Forms.Label
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.txtAverage = New System.Windows.Forms.TextBox
        Me.cmbDiploma = New System.Windows.Forms.ComboBox
        Me.txtEnd = New System.Windows.Forms.MaskedTextBox
        Me.lblprsCode = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBigin = New System.Windows.Forms.MaskedTextBox
        Me.lblBirthDate = New System.Windows.Forms.Label
        Me.lblAffine = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblNamemadrak = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grdEducation = New Janus.Windows.GridEX.GridEX
        Me.JGrade1 = New JFrameWork.jGrade
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdEducation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Icon = CType(resources.GetObject("btnDelete.Icon"), System.Drawing.Icon)
        Me.btnDelete.Location = New System.Drawing.Point(260, 141)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Õ–›"
        Me.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnChange
        '
        Me.btnChange.Icon = CType(resources.GetObject("btnChange.Icon"), System.Drawing.Icon)
        Me.btnChange.Location = New System.Drawing.Point(360, 141)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 24
        Me.btnChange.Text = "ÊÌ—«Ì‘"
        Me.btnChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-1, -1)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(896, 570)
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
        Me.UiGroupBox2.Controls.Add(Me.JGrade1)
        Me.UiGroupBox2.Controls.Add(Me.lblAttitudeCode)
        Me.UiGroupBox2.Controls.Add(Me.lblAttitudeID)
        Me.UiGroupBox2.Controls.Add(Me.lblStudyPlaceCode)
        Me.UiGroupBox2.Controls.Add(Me.btnAtitude)
        Me.UiGroupBox2.Controls.Add(Me.btnStudyPlace)
        Me.UiGroupBox2.Controls.Add(Me.lblStudyPlace)
        Me.UiGroupBox2.Controls.Add(Me.lblAtitude)
        Me.UiGroupBox2.Controls.Add(Me.btnSaveChange)
        Me.UiGroupBox2.Controls.Add(Me.lblName)
        Me.UiGroupBox2.Controls.Add(Me.Label3)
        Me.UiGroupBox2.Controls.Add(Me.UiButton1)
        Me.UiGroupBox2.Controls.Add(Me.lblStudyPlaceID)
        Me.UiGroupBox2.Controls.Add(Me.btnDelete)
        Me.UiGroupBox2.Controls.Add(Me.lblDiplomaID)
        Me.UiGroupBox2.Controls.Add(Me.btnChange)
        Me.UiGroupBox2.Controls.Add(Me.btnAdd)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox2.Controls.Add(Me.txtAverage)
        Me.UiGroupBox2.Controls.Add(Me.cmbDiploma)
        Me.UiGroupBox2.Controls.Add(Me.txtEnd)
        Me.UiGroupBox2.Controls.Add(Me.lblprsCode)
        Me.UiGroupBox2.Controls.Add(Me.Label4)
        Me.UiGroupBox2.Controls.Add(Me.txtBigin)
        Me.UiGroupBox2.Controls.Add(Me.lblBirthDate)
        Me.UiGroupBox2.Controls.Add(Me.lblAffine)
        Me.UiGroupBox2.Controls.Add(Me.Label8)
        Me.UiGroupBox2.Controls.Add(Me.lblNamemadrak)
        Me.UiGroupBox2.Controls.Add(Me.Label7)
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(720, 173)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'lblAttitudeCode
        '
        Me.lblAttitudeCode.Location = New System.Drawing.Point(322, 74)
        Me.lblAttitudeCode.Name = "lblAttitudeCode"
        Me.lblAttitudeCode.Size = New System.Drawing.Size(28, 17)
        Me.lblAttitudeCode.TabIndex = 11
        Me.lblAttitudeCode.Visible = False
        '
        'lblAttitudeID
        '
        Me.lblAttitudeID.Location = New System.Drawing.Point(356, 73)
        Me.lblAttitudeID.Name = "lblAttitudeID"
        Me.lblAttitudeID.Size = New System.Drawing.Size(36, 17)
        Me.lblAttitudeID.TabIndex = 10
        Me.lblAttitudeID.Visible = False
        '
        'lblStudyPlaceCode
        '
        Me.lblStudyPlaceCode.Location = New System.Drawing.Point(322, 102)
        Me.lblStudyPlaceCode.Name = "lblStudyPlaceCode"
        Me.lblStudyPlaceCode.Size = New System.Drawing.Size(28, 17)
        Me.lblStudyPlaceCode.TabIndex = 16
        Me.lblStudyPlaceCode.Visible = False
        '
        'btnAtitude
        '
        Me.btnAtitude.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnAtitude.Location = New System.Drawing.Point(398, 68)
        Me.btnAtitude.Name = "btnAtitude"
        Me.btnAtitude.Size = New System.Drawing.Size(23, 23)
        Me.btnAtitude.TabIndex = 9
        Me.btnAtitude.Text = "+"
        Me.btnAtitude.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnStudyPlace
        '
        Me.btnStudyPlace.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnStudyPlace.Location = New System.Drawing.Point(398, 96)
        Me.btnStudyPlace.Name = "btnStudyPlace"
        Me.btnStudyPlace.Size = New System.Drawing.Size(23, 23)
        Me.btnStudyPlace.TabIndex = 14
        Me.btnStudyPlace.Text = "+"
        Me.btnStudyPlace.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblStudyPlace
        '
        Me.lblStudyPlace.BackColor = System.Drawing.Color.Transparent
        Me.lblStudyPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStudyPlace.ForeColor = System.Drawing.Color.Red
        Me.lblStudyPlace.Location = New System.Drawing.Point(427, 97)
        Me.lblStudyPlace.Name = "lblStudyPlace"
        Me.lblStudyPlace.Size = New System.Drawing.Size(211, 20)
        Me.lblStudyPlace.TabIndex = 13
        Me.lblStudyPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAtitude
        '
        Me.lblAtitude.BackColor = System.Drawing.Color.Transparent
        Me.lblAtitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAtitude.ForeColor = System.Drawing.Color.Red
        Me.lblAtitude.Location = New System.Drawing.Point(427, 70)
        Me.lblAtitude.Name = "lblAtitude"
        Me.lblAtitude.Size = New System.Drawing.Size(211, 20)
        Me.lblAtitude.TabIndex = 8
        Me.lblAtitude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSaveChange
        '
        Me.btnSaveChange.Icon = CType(resources.GetObject("btnSaveChange.Icon"), System.Drawing.Icon)
        Me.btnSaveChange.Location = New System.Drawing.Point(466, 141)
        Me.btnSaveChange.Name = "btnSaveChange"
        Me.btnSaveChange.Size = New System.Drawing.Size(80, 23)
        Me.btnSaveChange.TabIndex = 25
        Me.btnSaveChange.Text = "À»   €ÌÌ—« "
        Me.btnSaveChange.Visible = False
        Me.btnSaveChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.ForeColor = System.Drawing.Color.Red
        Me.lblName.Location = New System.Drawing.Point(162, 15)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(192, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(360, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "‰«„ Ê ‰«„ Œ«‰Ê«œêÌ :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UiButton1
        '
        Me.UiButton1.Icon = CType(resources.GetObject("UiButton1.Icon"), System.Drawing.Icon)
        Me.UiButton1.Location = New System.Drawing.Point(162, 141)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(75, 23)
        Me.UiButton1.TabIndex = 27
        Me.UiButton1.Text = "«‰’—«›"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblStudyPlaceID
        '
        Me.lblStudyPlaceID.Location = New System.Drawing.Point(356, 101)
        Me.lblStudyPlaceID.Name = "lblStudyPlaceID"
        Me.lblStudyPlaceID.Size = New System.Drawing.Size(36, 17)
        Me.lblStudyPlaceID.TabIndex = 15
        Me.lblStudyPlaceID.Visible = False
        '
        'lblDiplomaID
        '
        Me.lblDiplomaID.Location = New System.Drawing.Point(440, 48)
        Me.lblDiplomaID.Name = "lblDiplomaID"
        Me.lblDiplomaID.Size = New System.Drawing.Size(21, 13)
        Me.lblDiplomaID.TabIndex = 6
        Me.lblDiplomaID.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(463, 141)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "À» "
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblPersonCode
        '
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(556, 15)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(82, 20)
        Me.lblPersonCode.TabIndex = 1
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(81, 98)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(128, 21)
        Me.txtAverage.TabIndex = 22
        '
        'cmbDiploma
        '
        Me.cmbDiploma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDiploma.FormattingEnabled = True
        Me.cmbDiploma.Location = New System.Drawing.Point(467, 42)
        Me.cmbDiploma.Name = "cmbDiploma"
        Me.cmbDiploma.Size = New System.Drawing.Size(171, 21)
        Me.cmbDiploma.TabIndex = 5
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(128, 70)
        Me.txtEnd.Mask = "0000/00/00"
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(81, 21)
        Me.txtEnd.TabIndex = 20
        '
        'lblprsCode
        '
        Me.lblprsCode.BackColor = System.Drawing.Color.Transparent
        Me.lblprsCode.Location = New System.Drawing.Point(644, 16)
        Me.lblprsCode.Name = "lblprsCode"
        Me.lblprsCode.Size = New System.Drawing.Size(70, 20)
        Me.lblprsCode.TabIndex = 0
        Me.lblprsCode.Text = "ﬂœ Å—”‰·Ì :"
        Me.lblprsCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(644, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ê—«Ì‘ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBigin
        '
        Me.txtBigin.Location = New System.Drawing.Point(128, 42)
        Me.txtBigin.Mask = "0000/00/00"
        Me.txtBigin.Name = "txtBigin"
        Me.txtBigin.Size = New System.Drawing.Size(81, 21)
        Me.txtBigin.TabIndex = 18
        '
        'lblBirthDate
        '
        Me.lblBirthDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthDate.Location = New System.Drawing.Point(215, 42)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(70, 20)
        Me.lblBirthDate.TabIndex = 17
        Me.lblBirthDate.Text = " «—ÌŒ ‘—Ê⁄ :"
        Me.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAffine
        '
        Me.lblAffine.BackColor = System.Drawing.Color.Transparent
        Me.lblAffine.Location = New System.Drawing.Point(644, 94)
        Me.lblAffine.Name = "lblAffine"
        Me.lblAffine.Size = New System.Drawing.Size(73, 20)
        Me.lblAffine.TabIndex = 12
        Me.lblAffine.Text = "„Õ·  Õ’Ì· :"
        Me.lblAffine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(215, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "„⁄œ· :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNamemadrak
        '
        Me.lblNamemadrak.BackColor = System.Drawing.Color.Transparent
        Me.lblNamemadrak.Location = New System.Drawing.Point(645, 42)
        Me.lblNamemadrak.Name = "lblNamemadrak"
        Me.lblNamemadrak.Size = New System.Drawing.Size(61, 20)
        Me.lblNamemadrak.TabIndex = 4
        Me.lblNamemadrak.Text = "‰Ê⁄ „œ—ﬂ :"
        Me.lblNamemadrak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(215, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = " «—ÌŒ « „«„ :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdEducation
        '
        Me.grdEducation.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdEducation.GroupByBoxVisible = False
        Me.grdEducation.Location = New System.Drawing.Point(2, 180)
        Me.grdEducation.Name = "grdEducation"
        Me.grdEducation.Size = New System.Drawing.Size(720, 384)
        Me.grdEducation.TabIndex = 3
        Me.grdEducation.TabStop = False
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(-3, -6)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 28
        '
        'frmPRSEducation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 568)
        Me.Controls.Add(Me.grdEducation)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPRSEducation"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ê÷⁄Ì   Õ’Ì·Ì"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grdEducation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDelete As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblStudyPlaceID As System.Windows.Forms.Label
    Friend WithEvents lblDiplomaID As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents cmbDiploma As System.Windows.Forms.ComboBox
    Friend WithEvents txtEnd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblprsCode As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBigin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblBirthDate As System.Windows.Forms.Label
    Friend WithEvents lblAffine As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNamemadrak As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSaveChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStudyPlace As System.Windows.Forms.Label
    Friend WithEvents lblAtitude As System.Windows.Forms.Label
    Friend WithEvents btnAtitude As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnStudyPlace As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStudyPlaceCode As System.Windows.Forms.Label
    Friend WithEvents lblAttitudeCode As System.Windows.Forms.Label
    Friend WithEvents lblAttitudeID As System.Windows.Forms.Label
    Friend WithEvents grdEducation As Janus.Windows.GridEX.GridEX
    Friend WithEvents JGrade1 As JFrameWork.jGrade
End Class
