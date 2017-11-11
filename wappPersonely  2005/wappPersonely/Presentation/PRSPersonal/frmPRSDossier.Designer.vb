<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSDossier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSDossier))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.JGrade1 = New JFrameWork.jGrade
        Me.lblPersonID = New System.Windows.Forms.Label
        Me.txtSumDay = New System.Windows.Forms.TextBox
        Me.lblSumDay = New System.Windows.Forms.Label
        Me.btnSaveChange = New Janus.Windows.EditControls.UIButton
        Me.lblName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.txtDossierSallary = New System.Windows.Forms.TextBox
        Me.txtDossierJobCo = New System.Windows.Forms.TextBox
        Me.btnDelete = New Janus.Windows.EditControls.UIButton
        Me.lblDossierSallary = New System.Windows.Forms.Label
        Me.btnChange = New Janus.Windows.EditControls.UIButton
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.txtDossierJob = New System.Windows.Forms.TextBox
        Me.cmbRelated = New System.Windows.Forms.ComboBox
        Me.txtDossierEndDate = New System.Windows.Forms.MaskedTextBox
        Me.lblprsCode = New System.Windows.Forms.Label
        Me.cmbAssure = New System.Windows.Forms.ComboBox
        Me.lblDossierJob = New System.Windows.Forms.Label
        Me.txtDossierBeginDate = New System.Windows.Forms.MaskedTextBox
        Me.lblDossierBeginDate = New System.Windows.Forms.Label
        Me.lblAssure = New System.Windows.Forms.Label
        Me.lblRelated = New System.Windows.Forms.Label
        Me.lblDossierJobCo = New System.Windows.Forms.Label
        Me.lblDossierEndDate = New System.Windows.Forms.Label
        Me.grdDossier = New Janus.Windows.GridEX.GridEX
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdDossier, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UiGroupBox1.Controls.Add(Me.grdDossier)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(725, 571)
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
        Me.UiGroupBox2.Controls.Add(Me.lblPersonID)
        Me.UiGroupBox2.Controls.Add(Me.txtSumDay)
        Me.UiGroupBox2.Controls.Add(Me.lblSumDay)
        Me.UiGroupBox2.Controls.Add(Me.btnSaveChange)
        Me.UiGroupBox2.Controls.Add(Me.lblName)
        Me.UiGroupBox2.Controls.Add(Me.Label2)
        Me.UiGroupBox2.Controls.Add(Me.UiButton1)
        Me.UiGroupBox2.Controls.Add(Me.txtDossierSallary)
        Me.UiGroupBox2.Controls.Add(Me.txtDossierJobCo)
        Me.UiGroupBox2.Controls.Add(Me.btnDelete)
        Me.UiGroupBox2.Controls.Add(Me.lblDossierSallary)
        Me.UiGroupBox2.Controls.Add(Me.btnChange)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox2.Controls.Add(Me.btnAdd)
        Me.UiGroupBox2.Controls.Add(Me.txtDossierJob)
        Me.UiGroupBox2.Controls.Add(Me.cmbRelated)
        Me.UiGroupBox2.Controls.Add(Me.txtDossierEndDate)
        Me.UiGroupBox2.Controls.Add(Me.lblprsCode)
        Me.UiGroupBox2.Controls.Add(Me.cmbAssure)
        Me.UiGroupBox2.Controls.Add(Me.lblDossierJob)
        Me.UiGroupBox2.Controls.Add(Me.txtDossierBeginDate)
        Me.UiGroupBox2.Controls.Add(Me.lblDossierBeginDate)
        Me.UiGroupBox2.Controls.Add(Me.lblAssure)
        Me.UiGroupBox2.Controls.Add(Me.lblRelated)
        Me.UiGroupBox2.Controls.Add(Me.lblDossierJobCo)
        Me.UiGroupBox2.Controls.Add(Me.lblDossierEndDate)
        Me.UiGroupBox2.Location = New System.Drawing.Point(4, 5)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(717, 179)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(1, 4)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 7
        '
        'lblPersonID
        '
        Me.lblPersonID.Location = New System.Drawing.Point(390, 87)
        Me.lblPersonID.Name = "lblPersonID"
        Me.lblPersonID.Size = New System.Drawing.Size(42, 20)
        Me.lblPersonID.TabIndex = 25
        Me.lblPersonID.Visible = False
        '
        'txtSumDay
        '
        Me.txtSumDay.Location = New System.Drawing.Point(92, 89)
        Me.txtSumDay.Name = "txtSumDay"
        Me.txtSumDay.Size = New System.Drawing.Size(142, 21)
        Me.txtSumDay.TabIndex = 24
        '
        'lblSumDay
        '
        Me.lblSumDay.BackColor = System.Drawing.Color.Transparent
        Me.lblSumDay.Location = New System.Drawing.Point(241, 90)
        Me.lblSumDay.Name = "lblSumDay"
        Me.lblSumDay.Size = New System.Drawing.Size(111, 20)
        Me.lblSumDay.TabIndex = 23
        Me.lblSumDay.Text = "„Ã„Ê⁄ ﬂ«—ﬂ—œ »Â —Ê“ :"
        Me.lblSumDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSaveChange
        '
        Me.btnSaveChange.Icon = CType(resources.GetObject("btnSaveChange.Icon"), System.Drawing.Icon)
        Me.btnSaveChange.Location = New System.Drawing.Point(431, 153)
        Me.btnSaveChange.Name = "btnSaveChange"
        Me.btnSaveChange.Size = New System.Drawing.Size(80, 23)
        Me.btnSaveChange.TabIndex = 22
        Me.btnSaveChange.Text = "À»   €ÌÌ—« "
        Me.btnSaveChange.Visible = False
        Me.btnSaveChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.ForeColor = System.Drawing.Color.Red
        Me.lblName.Location = New System.Drawing.Point(133, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(212, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(351, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = " ‰«„ Ê ‰«„ Œ«‰Ê«œêÌ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UiButton1
        '
        Me.UiButton1.Icon = CType(resources.GetObject("UiButton1.Icon"), System.Drawing.Icon)
        Me.UiButton1.Location = New System.Drawing.Point(136, 153)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(75, 23)
        Me.UiButton1.TabIndex = 21
        Me.UiButton1.Text = "«‰’—«›"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtDossierSallary
        '
        Me.txtDossierSallary.Location = New System.Drawing.Point(458, 114)
        Me.txtDossierSallary.Name = "txtDossierSallary"
        Me.txtDossierSallary.Size = New System.Drawing.Size(142, 21)
        Me.txtDossierSallary.TabIndex = 11
        '
        'txtDossierJobCo
        '
        Me.txtDossierJobCo.Location = New System.Drawing.Point(457, 33)
        Me.txtDossierJobCo.Name = "txtDossierJobCo"
        Me.txtDossierJobCo.Size = New System.Drawing.Size(142, 21)
        Me.txtDossierJobCo.TabIndex = 5
        '
        'btnDelete
        '
        Me.btnDelete.Icon = CType(resources.GetObject("btnDelete.Icon"), System.Drawing.Icon)
        Me.btnDelete.Location = New System.Drawing.Point(234, 153)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Õ–›"
        Me.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblDossierSallary
        '
        Me.lblDossierSallary.BackColor = System.Drawing.Color.Transparent
        Me.lblDossierSallary.Location = New System.Drawing.Point(606, 115)
        Me.lblDossierSallary.Name = "lblDossierSallary"
        Me.lblDossierSallary.Size = New System.Drawing.Size(79, 20)
        Me.lblDossierSallary.TabIndex = 10
        Me.lblDossierSallary.Text = "ÕﬁÊﬁ „«ÂÌ«‰Â :"
        Me.lblDossierSallary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnChange
        '
        Me.btnChange.Icon = CType(resources.GetObject("btnChange.Icon"), System.Drawing.Icon)
        Me.btnChange.Location = New System.Drawing.Point(331, 153)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 19
        Me.btnChange.Text = "ÊÌ—«Ì‘"
        Me.btnChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblPersonCode
        '
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(518, 10)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(82, 20)
        Me.lblPersonCode.TabIndex = 1
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(428, 153)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "À» "
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtDossierJob
        '
        Me.txtDossierJob.Location = New System.Drawing.Point(457, 60)
        Me.txtDossierJob.Name = "txtDossierJob"
        Me.txtDossierJob.Size = New System.Drawing.Size(142, 21)
        Me.txtDossierJob.TabIndex = 7
        '
        'cmbRelated
        '
        Me.cmbRelated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRelated.FormattingEnabled = True
        Me.cmbRelated.Location = New System.Drawing.Point(457, 87)
        Me.cmbRelated.Name = "cmbRelated"
        Me.cmbRelated.Size = New System.Drawing.Size(142, 21)
        Me.cmbRelated.TabIndex = 9
        '
        'txtDossierEndDate
        '
        Me.txtDossierEndDate.Location = New System.Drawing.Point(133, 62)
        Me.txtDossierEndDate.Mask = "0000/00/00"
        Me.txtDossierEndDate.Name = "txtDossierEndDate"
        Me.txtDossierEndDate.Size = New System.Drawing.Size(101, 21)
        Me.txtDossierEndDate.TabIndex = 15
        '
        'lblprsCode
        '
        Me.lblprsCode.BackColor = System.Drawing.Color.Transparent
        Me.lblprsCode.Location = New System.Drawing.Point(606, 10)
        Me.lblprsCode.Name = "lblprsCode"
        Me.lblprsCode.Size = New System.Drawing.Size(70, 20)
        Me.lblprsCode.TabIndex = 0
        Me.lblprsCode.Text = "ﬂœ Å—”‰·Ì :"
        Me.lblprsCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbAssure
        '
        Me.cmbAssure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAssure.FormattingEnabled = True
        Me.cmbAssure.Location = New System.Drawing.Point(92, 114)
        Me.cmbAssure.Name = "cmbAssure"
        Me.cmbAssure.Size = New System.Drawing.Size(142, 21)
        Me.cmbAssure.TabIndex = 17
        '
        'lblDossierJob
        '
        Me.lblDossierJob.BackColor = System.Drawing.Color.Transparent
        Me.lblDossierJob.Location = New System.Drawing.Point(605, 60)
        Me.lblDossierJob.Name = "lblDossierJob"
        Me.lblDossierJob.Size = New System.Drawing.Size(70, 20)
        Me.lblDossierJob.TabIndex = 6
        Me.lblDossierJob.Text = "⁄‰Ê«‰ ‘€· :"
        Me.lblDossierJob.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDossierBeginDate
        '
        Me.txtDossierBeginDate.Location = New System.Drawing.Point(133, 36)
        Me.txtDossierBeginDate.Mask = "0000/00/00"
        Me.txtDossierBeginDate.Name = "txtDossierBeginDate"
        Me.txtDossierBeginDate.Size = New System.Drawing.Size(101, 21)
        Me.txtDossierBeginDate.TabIndex = 13
        '
        'lblDossierBeginDate
        '
        Me.lblDossierBeginDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDossierBeginDate.Location = New System.Drawing.Point(240, 35)
        Me.lblDossierBeginDate.Name = "lblDossierBeginDate"
        Me.lblDossierBeginDate.Size = New System.Drawing.Size(70, 20)
        Me.lblDossierBeginDate.TabIndex = 12
        Me.lblDossierBeginDate.Text = " «—ÌŒ ‘—Ê⁄ :"
        Me.lblDossierBeginDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAssure
        '
        Me.lblAssure.BackColor = System.Drawing.Color.Transparent
        Me.lblAssure.Location = New System.Drawing.Point(240, 114)
        Me.lblAssure.Name = "lblAssure"
        Me.lblAssure.Size = New System.Drawing.Size(73, 20)
        Me.lblAssure.TabIndex = 16
        Me.lblAssure.Text = "‰Ê⁄ »Ì„Â :"
        Me.lblAssure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRelated
        '
        Me.lblRelated.BackColor = System.Drawing.Color.Transparent
        Me.lblRelated.Location = New System.Drawing.Point(605, 88)
        Me.lblRelated.Name = "lblRelated"
        Me.lblRelated.Size = New System.Drawing.Size(70, 20)
        Me.lblRelated.TabIndex = 8
        Me.lblRelated.Text = "‰Ê⁄ ‘€· :"
        Me.lblRelated.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDossierJobCo
        '
        Me.lblDossierJobCo.BackColor = System.Drawing.Color.Transparent
        Me.lblDossierJobCo.Location = New System.Drawing.Point(606, 34)
        Me.lblDossierJobCo.Name = "lblDossierJobCo"
        Me.lblDossierJobCo.Size = New System.Drawing.Size(66, 20)
        Me.lblDossierJobCo.TabIndex = 4
        Me.lblDossierJobCo.Text = "‰«„ „Õ· ﬂ«— :"
        Me.lblDossierJobCo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDossierEndDate
        '
        Me.lblDossierEndDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDossierEndDate.Location = New System.Drawing.Point(240, 61)
        Me.lblDossierEndDate.Name = "lblDossierEndDate"
        Me.lblDossierEndDate.Size = New System.Drawing.Size(70, 20)
        Me.lblDossierEndDate.TabIndex = 14
        Me.lblDossierEndDate.Text = " «—ÌŒ « „«„ :"
        Me.lblDossierEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdDossier
        '
        Me.grdDossier.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdDossier.GroupByBoxVisible = False
        Me.grdDossier.Location = New System.Drawing.Point(4, 190)
        Me.grdDossier.Name = "grdDossier"
        Me.grdDossier.Size = New System.Drawing.Size(717, 375)
        Me.grdDossier.TabIndex = 4
        Me.grdDossier.TabStop = False
        '
        'frmPRSDossier
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
        Me.Name = "frmPRSDossier"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "”Ê«»ﬁ «” Œœ«„Ì"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.grdDossier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdDossier As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnDelete As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtDossierSallary As System.Windows.Forms.TextBox
    Friend WithEvents txtDossierJobCo As System.Windows.Forms.TextBox
    Friend WithEvents lblDossierSallary As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents txtDossierJob As System.Windows.Forms.TextBox
    Friend WithEvents cmbRelated As System.Windows.Forms.ComboBox
    Friend WithEvents txtDossierEndDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblprsCode As System.Windows.Forms.Label
    Friend WithEvents cmbAssure As System.Windows.Forms.ComboBox
    Friend WithEvents lblDossierJob As System.Windows.Forms.Label
    Friend WithEvents txtDossierBeginDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDossierBeginDate As System.Windows.Forms.Label
    Friend WithEvents lblAssure As System.Windows.Forms.Label
    Friend WithEvents lblRelated As System.Windows.Forms.Label
    Friend WithEvents lblDossierJobCo As System.Windows.Forms.Label
    Friend WithEvents lblDossierEndDate As System.Windows.Forms.Label
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSaveChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtSumDay As System.Windows.Forms.TextBox
    Friend WithEvents lblSumDay As System.Windows.Forms.Label
    Friend WithEvents lblPersonID As System.Windows.Forms.Label
    Friend WithEvents JGrade1 As JFrameWork.jGrade
End Class
