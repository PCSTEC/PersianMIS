<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSMeed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSMeed))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.JGrade1 = New JFrameWork.jGrade
        Me.lblPersonID = New System.Windows.Forms.Label
        Me.btnCancel = New Janus.Windows.EditControls.UIButton
        Me.btnSaveChange = New Janus.Windows.EditControls.UIButton
        Me.txtReason = New System.Windows.Forms.RichTextBox
        Me.txtMeedDate = New System.Windows.Forms.MaskedTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.txtLetterNum = New System.Windows.Forms.TextBox
        Me.cmbMeedType = New System.Windows.Forms.ComboBox
        Me.lblprsCode = New System.Windows.Forms.Label
        Me.lblDossierJob = New System.Windows.Forms.Label
        Me.lblRelated = New System.Windows.Forms.Label
        Me.lblDossierJobCo = New System.Windows.Forms.Label
        Me.btnDelete = New Janus.Windows.EditControls.UIButton
        Me.btnChange = New Janus.Windows.EditControls.UIButton
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.grdMeed = New Janus.Windows.GridEX.GridEX
        Me.txtMeedEndDate = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdMeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.grdMeed)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-1, -2)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(727, 573)
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
        Me.UiGroupBox2.Controls.Add(Me.txtMeedEndDate)
        Me.UiGroupBox2.Controls.Add(Me.Label3)
        Me.UiGroupBox2.Controls.Add(Me.JGrade1)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonID)
        Me.UiGroupBox2.Controls.Add(Me.btnCancel)
        Me.UiGroupBox2.Controls.Add(Me.btnSaveChange)
        Me.UiGroupBox2.Controls.Add(Me.txtReason)
        Me.UiGroupBox2.Controls.Add(Me.txtMeedDate)
        Me.UiGroupBox2.Controls.Add(Me.Label2)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Controls.Add(Me.lblName)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox2.Controls.Add(Me.txtLetterNum)
        Me.UiGroupBox2.Controls.Add(Me.cmbMeedType)
        Me.UiGroupBox2.Controls.Add(Me.lblprsCode)
        Me.UiGroupBox2.Controls.Add(Me.lblDossierJob)
        Me.UiGroupBox2.Controls.Add(Me.lblRelated)
        Me.UiGroupBox2.Controls.Add(Me.lblDossierJobCo)
        Me.UiGroupBox2.Controls.Add(Me.btnDelete)
        Me.UiGroupBox2.Controls.Add(Me.btnChange)
        Me.UiGroupBox2.Controls.Add(Me.btnAdd)
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 5)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(720, 198)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(-3, -3)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 18
        '
        'lblPersonID
        '
        Me.lblPersonID.Location = New System.Drawing.Point(424, 47)
        Me.lblPersonID.Name = "lblPersonID"
        Me.lblPersonID.Size = New System.Drawing.Size(62, 21)
        Me.lblPersonID.TabIndex = 17
        Me.lblPersonID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Icon = CType(resources.GetObject("btnCancel.Icon"), System.Drawing.Icon)
        Me.btnCancel.Location = New System.Drawing.Point(132, 162)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "انصراف"
        Me.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnSaveChange
        '
        Me.btnSaveChange.Icon = CType(resources.GetObject("btnSaveChange.Icon"), System.Drawing.Icon)
        Me.btnSaveChange.Location = New System.Drawing.Point(517, 162)
        Me.btnSaveChange.Name = "btnSaveChange"
        Me.btnSaveChange.Size = New System.Drawing.Size(79, 23)
        Me.btnSaveChange.TabIndex = 14
        Me.btnSaveChange.Text = "ثبت تغييرات"
        Me.btnSaveChange.Visible = False
        Me.btnSaveChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtReason
        '
        Me.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReason.Location = New System.Drawing.Point(32, 105)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(279, 51)
        Me.txtReason.TabIndex = 11
        Me.txtReason.Text = ""
        '
        'txtMeedDate
        '
        Me.txtMeedDate.Location = New System.Drawing.Point(187, 44)
        Me.txtMeedDate.Mask = "0000/00/00"
        Me.txtMeedDate.Name = "txtMeedDate"
        Me.txtMeedDate.Size = New System.Drawing.Size(124, 21)
        Me.txtMeedDate.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(316, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "شرح :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(316, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "تاريخ شروع: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.ForeColor = System.Drawing.Color.Red
        Me.lblName.Location = New System.Drawing.Point(186, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(236, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonCode
        '
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(528, 16)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(109, 20)
        Me.lblPersonCode.TabIndex = 1
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLetterNum
        '
        Me.txtLetterNum.Location = New System.Drawing.Point(525, 74)
        Me.txtLetterNum.Name = "txtLetterNum"
        Me.txtLetterNum.Size = New System.Drawing.Size(109, 21)
        Me.txtLetterNum.TabIndex = 7
        '
        'cmbMeedType
        '
        Me.cmbMeedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMeedType.FormattingEnabled = True
        Me.cmbMeedType.Location = New System.Drawing.Point(492, 44)
        Me.cmbMeedType.Name = "cmbMeedType"
        Me.cmbMeedType.Size = New System.Drawing.Size(142, 21)
        Me.cmbMeedType.TabIndex = 5
        '
        'lblprsCode
        '
        Me.lblprsCode.BackColor = System.Drawing.Color.Transparent
        Me.lblprsCode.Location = New System.Drawing.Point(640, 16)
        Me.lblprsCode.Name = "lblprsCode"
        Me.lblprsCode.Size = New System.Drawing.Size(70, 20)
        Me.lblprsCode.TabIndex = 0
        Me.lblprsCode.Text = "كد پرسنلي :"
        Me.lblprsCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDossierJob
        '
        Me.lblDossierJob.BackColor = System.Drawing.Color.Transparent
        Me.lblDossierJob.Location = New System.Drawing.Point(640, 74)
        Me.lblDossierJob.Name = "lblDossierJob"
        Me.lblDossierJob.Size = New System.Drawing.Size(70, 20)
        Me.lblDossierJob.TabIndex = 6
        Me.lblDossierJob.Text = "شماره نامه :"
        Me.lblDossierJob.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRelated
        '
        Me.lblRelated.BackColor = System.Drawing.Color.Transparent
        Me.lblRelated.Location = New System.Drawing.Point(640, 45)
        Me.lblRelated.Name = "lblRelated"
        Me.lblRelated.Size = New System.Drawing.Size(70, 20)
        Me.lblRelated.TabIndex = 4
        Me.lblRelated.Text = "نوع :"
        Me.lblRelated.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDossierJobCo
        '
        Me.lblDossierJobCo.BackColor = System.Drawing.Color.Transparent
        Me.lblDossierJobCo.Location = New System.Drawing.Point(424, 16)
        Me.lblDossierJobCo.Name = "lblDossierJobCo"
        Me.lblDossierJobCo.Size = New System.Drawing.Size(106, 20)
        Me.lblDossierJobCo.TabIndex = 2
        Me.lblDossierJobCo.Text = "نام و نام خانوادگي :"
        Me.lblDossierJobCo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Icon = CType(resources.GetObject("btnDelete.Icon"), System.Drawing.Icon)
        Me.btnDelete.Location = New System.Drawing.Point(255, 162)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnChange
        '
        Me.btnChange.Icon = CType(resources.GetObject("btnChange.Icon"), System.Drawing.Icon)
        Me.btnChange.Location = New System.Drawing.Point(387, 162)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 13
        Me.btnChange.Text = "ويرايش"
        Me.btnChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnAdd
        '
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(514, 162)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "ثبت"
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'grdMeed
        '
        Me.grdMeed.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMeed.GroupByBoxVisible = False
        Me.grdMeed.Location = New System.Drawing.Point(4, 209)
        Me.grdMeed.Name = "grdMeed"
        Me.grdMeed.Size = New System.Drawing.Size(719, 357)
        Me.grdMeed.TabIndex = 4
        Me.grdMeed.TabStop = False
        '
        'txtMeedEndDate
        '
        Me.txtMeedEndDate.Location = New System.Drawing.Point(187, 71)
        Me.txtMeedEndDate.Mask = "0000/00/00"
        Me.txtMeedEndDate.Name = "txtMeedEndDate"
        Me.txtMeedEndDate.Size = New System.Drawing.Size(124, 21)
        Me.txtMeedEndDate.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(316, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "تاريخ پایان: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPRSMeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 568)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPRSMeed"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تشويق و تنبيه"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grdMeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdMeed As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnDelete As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents txtLetterNum As System.Windows.Forms.TextBox
    Friend WithEvents cmbMeedType As System.Windows.Forms.ComboBox
    Friend WithEvents lblprsCode As System.Windows.Forms.Label
    Friend WithEvents lblDossierJob As System.Windows.Forms.Label
    Friend WithEvents lblRelated As System.Windows.Forms.Label
    Friend WithEvents lblDossierJobCo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMeedDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtReason As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSaveChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPersonID As System.Windows.Forms.Label
    Friend WithEvents JGrade1 As JFrameWork.jGrade
    Friend WithEvents txtMeedEndDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
