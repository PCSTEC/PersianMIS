<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSTraining
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSTraining))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdTraining = New Janus.Windows.GridEX.GridEX
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.CmbCourcePlace = New System.Windows.Forms.ComboBox
        Me.CmbCourceName = New System.Windows.Forms.ComboBox
        Me.JGrade1 = New JFrameWork.jGrade
        Me.lblPersonID = New System.Windows.Forms.Label
        Me.btnSaveChange = New Janus.Windows.EditControls.UIButton
        Me.lblPersonName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnDelete = New Janus.Windows.EditControls.UIButton
        Me.btnCancel = New Janus.Windows.EditControls.UIButton
        Me.btnChange = New Janus.Windows.EditControls.UIButton
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.txtAverage = New System.Windows.Forms.TextBox
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.txtEndDate = New System.Windows.Forms.MaskedTextBox
        Me.txtBeginDate = New System.Windows.Forms.MaskedTextBox
        Me.cmbCity = New System.Windows.Forms.ComboBox
        Me.lblAverage = New System.Windows.Forms.Label
        Me.lblEndDate = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblCourcePlace = New System.Windows.Forms.Label
        Me.lblBeginDate = New System.Windows.Forms.Label
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.lblPrsCode = New System.Windows.Forms.Label
        Me.lblPlaceCity = New System.Windows.Forms.Label
        Me.lblCourseName = New System.Windows.Forms.Label
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdTraining, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
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
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.grdTraining)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -2)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(728, 624)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiButton1
        '
        Me.UiButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UiButton1.Icon = CType(resources.GetObject("UiButton1.Icon"), System.Drawing.Icon)
        Me.UiButton1.Location = New System.Drawing.Point(7, 554)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(110, 23)
        Me.UiButton1.TabIndex = 32
        Me.UiButton1.Text = "نمایش گواهینامه"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(142, 588)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "دوره ثبت شده در نرم افزار پرسنلی"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(104, 590)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(344, 587)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "دوره ثبت شده در نرم افزار آموزش منطبق با استاندارد مهارت"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(313, 588)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 16)
        Me.Label1.TabIndex = 29
        '
        'grdTraining
        '
        Me.grdTraining.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdTraining.GroupByBoxVisible = False
        Me.grdTraining.Location = New System.Drawing.Point(4, 198)
        Me.grdTraining.Name = "grdTraining"
        Me.grdTraining.Size = New System.Drawing.Size(715, 350)
        Me.grdTraining.TabIndex = 1
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox2.Controls.Add(Me.CmbCourcePlace)
        Me.UiGroupBox2.Controls.Add(Me.CmbCourceName)
        Me.UiGroupBox2.Controls.Add(Me.JGrade1)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonID)
        Me.UiGroupBox2.Controls.Add(Me.btnSaveChange)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonName)
        Me.UiGroupBox2.Controls.Add(Me.Label2)
        Me.UiGroupBox2.Controls.Add(Me.btnDelete)
        Me.UiGroupBox2.Controls.Add(Me.btnCancel)
        Me.UiGroupBox2.Controls.Add(Me.btnChange)
        Me.UiGroupBox2.Controls.Add(Me.btnAdd)
        Me.UiGroupBox2.Controls.Add(Me.txtAverage)
        Me.UiGroupBox2.Controls.Add(Me.txtTime)
        Me.UiGroupBox2.Controls.Add(Me.txtEndDate)
        Me.UiGroupBox2.Controls.Add(Me.txtBeginDate)
        Me.UiGroupBox2.Controls.Add(Me.cmbCity)
        Me.UiGroupBox2.Controls.Add(Me.lblAverage)
        Me.UiGroupBox2.Controls.Add(Me.lblEndDate)
        Me.UiGroupBox2.Controls.Add(Me.lblTime)
        Me.UiGroupBox2.Controls.Add(Me.lblCourcePlace)
        Me.UiGroupBox2.Controls.Add(Me.lblBeginDate)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox2.Controls.Add(Me.lblPrsCode)
        Me.UiGroupBox2.Controls.Add(Me.lblPlaceCity)
        Me.UiGroupBox2.Controls.Add(Me.lblCourseName)
        Me.UiGroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(715, 189)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'CmbCourcePlace
        '
        Me.CmbCourcePlace.FormattingEnabled = True
        Me.CmbCourcePlace.Location = New System.Drawing.Point(365, 64)
        Me.CmbCourcePlace.Name = "CmbCourcePlace"
        Me.CmbCourcePlace.Size = New System.Drawing.Size(255, 21)
        Me.CmbCourcePlace.TabIndex = 31
        '
        'CmbCourceName
        '
        Me.CmbCourceName.FormattingEnabled = True
        Me.CmbCourceName.Location = New System.Drawing.Point(364, 36)
        Me.CmbCourceName.Name = "CmbCourceName"
        Me.CmbCourceName.Size = New System.Drawing.Size(255, 21)
        Me.CmbCourceName.TabIndex = 29
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(3, 11)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 24
        '
        'lblPersonID
        '
        Me.lblPersonID.Location = New System.Drawing.Point(62, 92)
        Me.lblPersonID.Name = "lblPersonID"
        Me.lblPersonID.Size = New System.Drawing.Size(37, 16)
        Me.lblPersonID.TabIndex = 23
        Me.lblPersonID.Visible = False
        '
        'btnSaveChange
        '
        Me.btnSaveChange.Icon = CType(resources.GetObject("btnSaveChange.Icon"), System.Drawing.Icon)
        Me.btnSaveChange.Location = New System.Drawing.Point(568, 157)
        Me.btnSaveChange.Name = "btnSaveChange"
        Me.btnSaveChange.Size = New System.Drawing.Size(79, 23)
        Me.btnSaveChange.TabIndex = 22
        Me.btnSaveChange.Text = "ثبت تغييرات"
        Me.btnSaveChange.Visible = False
        Me.btnSaveChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblPersonName
        '
        Me.lblPersonName.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonName.ForeColor = System.Drawing.Color.Red
        Me.lblPersonName.Location = New System.Drawing.Point(208, 11)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(212, 19)
        Me.lblPersonName.TabIndex = 3
        Me.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(422, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "نام و نام خانوادگي :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Icon = CType(resources.GetObject("btnDelete.Icon"), System.Drawing.Icon)
        Me.btnDelete.Location = New System.Drawing.Point(275, 157)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnCancel
        '
        Me.btnCancel.Icon = CType(resources.GetObject("btnCancel.Icon"), System.Drawing.Icon)
        Me.btnCancel.Location = New System.Drawing.Point(186, 157)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "انصراف"
        Me.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnChange
        '
        Me.btnChange.Icon = CType(resources.GetObject("btnChange.Icon"), System.Drawing.Icon)
        Me.btnChange.Location = New System.Drawing.Point(364, 157)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 19
        Me.btnChange.Text = "ويرايش"
        Me.btnChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnAdd
        '
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(453, 157)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "ثبت"
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(161, 93)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(125, 21)
        Me.txtAverage.TabIndex = 17
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(161, 65)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(125, 21)
        Me.txtTime.TabIndex = 15
        '
        'txtEndDate
        '
        Me.txtEndDate.Location = New System.Drawing.Point(161, 37)
        Me.txtEndDate.Mask = "0000/00/00"
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(125, 21)
        Me.txtEndDate.TabIndex = 13
        '
        'txtBeginDate
        '
        Me.txtBeginDate.Location = New System.Drawing.Point(535, 119)
        Me.txtBeginDate.Mask = "0000/00/00"
        Me.txtBeginDate.Name = "txtBeginDate"
        Me.txtBeginDate.Size = New System.Drawing.Size(84, 21)
        Me.txtBeginDate.TabIndex = 11
        '
        'cmbCity
        '
        Me.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(485, 92)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(134, 21)
        Me.cmbCity.TabIndex = 9
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.Color.Transparent
        Me.lblAverage.Location = New System.Drawing.Point(288, 92)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(77, 19)
        Me.lblAverage.TabIndex = 16
        Me.lblAverage.Text = "نمره :"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEndDate
        '
        Me.lblEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblEndDate.Location = New System.Drawing.Point(288, 38)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(77, 19)
        Me.lblEndDate.TabIndex = 12
        Me.lblEndDate.Text = "تاريخ پايان :"
        Me.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Location = New System.Drawing.Point(288, 66)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(77, 19)
        Me.lblTime.TabIndex = 14
        Me.lblTime.Text = "مدت دوره :"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourcePlace
        '
        Me.lblCourcePlace.BackColor = System.Drawing.Color.Transparent
        Me.lblCourcePlace.Location = New System.Drawing.Point(620, 66)
        Me.lblCourcePlace.Name = "lblCourcePlace"
        Me.lblCourcePlace.Size = New System.Drawing.Size(77, 19)
        Me.lblCourcePlace.TabIndex = 6
        Me.lblCourcePlace.Text = "نام آموزشگاه :"
        Me.lblCourcePlace.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBeginDate
        '
        Me.lblBeginDate.BackColor = System.Drawing.Color.Transparent
        Me.lblBeginDate.Location = New System.Drawing.Point(620, 119)
        Me.lblBeginDate.Name = "lblBeginDate"
        Me.lblBeginDate.Size = New System.Drawing.Size(77, 19)
        Me.lblBeginDate.TabIndex = 10
        Me.lblBeginDate.Text = "تاريخ شروع :"
        Me.lblBeginDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPersonCode
        '
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(520, 11)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(94, 19)
        Me.lblPersonCode.TabIndex = 1
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrsCode
        '
        Me.lblPrsCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPrsCode.Location = New System.Drawing.Point(620, 11)
        Me.lblPrsCode.Name = "lblPrsCode"
        Me.lblPrsCode.Size = New System.Drawing.Size(77, 19)
        Me.lblPrsCode.TabIndex = 0
        Me.lblPrsCode.Text = "كد پرسنلي :"
        Me.lblPrsCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPlaceCity
        '
        Me.lblPlaceCity.BackColor = System.Drawing.Color.Transparent
        Me.lblPlaceCity.Location = New System.Drawing.Point(620, 92)
        Me.lblPlaceCity.Name = "lblPlaceCity"
        Me.lblPlaceCity.Size = New System.Drawing.Size(77, 19)
        Me.lblPlaceCity.TabIndex = 8
        Me.lblPlaceCity.Text = "محل برگزاري :"
        Me.lblPlaceCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCourseName
        '
        Me.lblCourseName.BackColor = System.Drawing.Color.Transparent
        Me.lblCourseName.Location = New System.Drawing.Point(620, 38)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(77, 19)
        Me.lblCourseName.TabIndex = 4
        Me.lblCourseName.Text = "نام دوره :"
        Me.lblCourseName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPRSTraining
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 619)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPRSTraining"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اطلاعات دوره آموزش"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.grdTraining, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDelete As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBeginDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblCourcePlace As System.Windows.Forms.Label
    Friend WithEvents lblBeginDate As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents lblPrsCode As System.Windows.Forms.Label
    Friend WithEvents lblPlaceCity As System.Windows.Forms.Label
    Friend WithEvents lblCourseName As System.Windows.Forms.Label
    Friend WithEvents lblPersonName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSaveChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdTraining As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblPersonID As System.Windows.Forms.Label
    Friend WithEvents JGrade1 As JFrameWork.jGrade
    Friend WithEvents CmbCourceName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbCourcePlace As System.Windows.Forms.ComboBox
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
End Class
