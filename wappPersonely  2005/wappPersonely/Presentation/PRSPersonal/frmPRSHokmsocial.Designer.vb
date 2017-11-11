<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSHokmsocial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSHokmsocial))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.cmbPercent = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.JGrade1 = New JFrameWork.jGrade
        Me.chkGharardad = New System.Windows.Forms.CheckBox
        Me.lblEmployeeType = New System.Windows.Forms.Label
        Me.cmbEmployeeType = New System.Windows.Forms.ComboBox
        Me.ckbEmployeeCode = New System.Windows.Forms.CheckBox
        Me.btnTrity = New Janus.Windows.EditControls.UIButton
        Me.btnPrint = New Janus.Windows.EditControls.UIButton
        Me.ckbHoghooghDate = New System.Windows.Forms.CheckBox
        Me.txtBeginDate = New System.Windows.Forms.MaskedTextBox
        Me.txtEmissionDate = New System.Windows.Forms.MaskedTextBox
        Me.txtEndDate = New System.Windows.Forms.MaskedTextBox
        Me.txtExecuteDate = New System.Windows.Forms.MaskedTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.lblYear = New System.Windows.Forms.Label
        Me.btnExit = New Janus.Windows.EditControls.UIButton
        Me.DgSelect2 = New IKIDUtility.DgSelect
        Me.DgSelect1 = New IKIDUtility.DgSelect
        Me.grdPerson = New System.Windows.Forms.DataGrid
        Me.grdMDepart = New System.Windows.Forms.DataGrid
        Me.btnSave = New Janus.Windows.EditControls.UIButton
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.AllowDrop = True
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.cmbPercent)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.JGrade1)
        Me.UiGroupBox1.Controls.Add(Me.chkGharardad)
        Me.UiGroupBox1.Controls.Add(Me.lblEmployeeType)
        Me.UiGroupBox1.Controls.Add(Me.cmbEmployeeType)
        Me.UiGroupBox1.Controls.Add(Me.ckbEmployeeCode)
        Me.UiGroupBox1.Controls.Add(Me.btnTrity)
        Me.UiGroupBox1.Controls.Add(Me.btnPrint)
        Me.UiGroupBox1.Controls.Add(Me.ckbHoghooghDate)
        Me.UiGroupBox1.Controls.Add(Me.txtBeginDate)
        Me.UiGroupBox1.Controls.Add(Me.txtEmissionDate)
        Me.UiGroupBox1.Controls.Add(Me.txtEndDate)
        Me.UiGroupBox1.Controls.Add(Me.txtExecuteDate)
        Me.UiGroupBox1.Controls.Add(Me.Label23)
        Me.UiGroupBox1.Controls.Add(Me.Label22)
        Me.UiGroupBox1.Controls.Add(Me.Label21)
        Me.UiGroupBox1.Controls.Add(Me.Label20)
        Me.UiGroupBox1.Controls.Add(Me.cmbYear)
        Me.UiGroupBox1.Controls.Add(Me.lblYear)
        Me.UiGroupBox1.Controls.Add(Me.btnExit)
        Me.UiGroupBox1.Controls.Add(Me.DgSelect2)
        Me.UiGroupBox1.Controls.Add(Me.DgSelect1)
        Me.UiGroupBox1.Controls.Add(Me.grdPerson)
        Me.UiGroupBox1.Controls.Add(Me.grdMDepart)
        Me.UiGroupBox1.Controls.Add(Me.btnSave)
        Me.UiGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -1)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(883, 601)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'cmbPercent
        '
        Me.cmbPercent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPercent.FormattingEnabled = True
        Me.cmbPercent.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbPercent.Location = New System.Drawing.Point(422, 101)
        Me.cmbPercent.Name = "cmbPercent"
        Me.cmbPercent.Size = New System.Drawing.Size(86, 21)
        Me.cmbPercent.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(514, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 26)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "œ—’œ «›“«Ì‘  :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(9, 37)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 23
        '
        'chkGharardad
        '
        Me.chkGharardad.BackColor = System.Drawing.Color.Transparent
        Me.chkGharardad.Location = New System.Drawing.Point(411, 10)
        Me.chkGharardad.Name = "chkGharardad"
        Me.chkGharardad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGharardad.Size = New System.Drawing.Size(179, 18)
        Me.chkGharardad.TabIndex = 22
        Me.chkGharardad.Text = "¬Ì« „ÌŒÊ«ÂÌœ ﬁ—«—œ«œ ’«œ— ‰„«ÌÌœ ø"
        Me.chkGharardad.UseVisualStyleBackColor = False
        '
        'lblEmployeeType
        '
        Me.lblEmployeeType.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeType.Location = New System.Drawing.Point(515, 67)
        Me.lblEmployeeType.Name = "lblEmployeeType"
        Me.lblEmployeeType.Size = New System.Drawing.Size(54, 26)
        Me.lblEmployeeType.TabIndex = 21
        Me.lblEmployeeType.Text = "‰Ê⁄ Õﬂ„ :"
        Me.lblEmployeeType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbEmployeeType
        '
        Me.cmbEmployeeType.FormattingEnabled = True
        Me.cmbEmployeeType.Location = New System.Drawing.Point(176, 69)
        Me.cmbEmployeeType.Name = "cmbEmployeeType"
        Me.cmbEmployeeType.Size = New System.Drawing.Size(333, 21)
        Me.cmbEmployeeType.TabIndex = 20
        '
        'ckbEmployeeCode
        '
        Me.ckbEmployeeCode.BackColor = System.Drawing.Color.Transparent
        Me.ckbEmployeeCode.Location = New System.Drawing.Point(575, 72)
        Me.ckbEmployeeCode.Name = "ckbEmployeeCode"
        Me.ckbEmployeeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckbEmployeeCode.Size = New System.Drawing.Size(282, 18)
        Me.ckbEmployeeCode.TabIndex = 19
        Me.ckbEmployeeCode.Text = "¬Ì« „Ì ŒÊ«ÂÌœ ‰Ê⁄ Õﬂ„ —Ê»—Ê —« »—«Ì Â„Â À»  ‰„«ÌÌœ ø"
        Me.ckbEmployeeCode.UseVisualStyleBackColor = False
        '
        'btnTrity
        '
        Me.btnTrity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTrity.Icon = CType(resources.GetObject("btnTrity.Icon"), System.Drawing.Icon)
        Me.btnTrity.Location = New System.Drawing.Point(292, 575)
        Me.btnTrity.Name = "btnTrity"
        Me.btnTrity.Size = New System.Drawing.Size(120, 23)
        Me.btnTrity.TabIndex = 17
        Me.btnTrity.Text = "ç«Å ﬁ—«—œ«œ Ã„⁄Ì"
        Me.btnTrity.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Icon = CType(resources.GetObject("btnPrint.Icon"), System.Drawing.Icon)
        Me.btnPrint.Location = New System.Drawing.Point(418, 576)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 23)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "ç«Å Õﬂ„ Ã„⁄Ì"
        Me.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'ckbHoghooghDate
        '
        Me.ckbHoghooghDate.BackColor = System.Drawing.Color.Transparent
        Me.ckbHoghooghDate.Location = New System.Drawing.Point(176, 45)
        Me.ckbHoghooghDate.Name = "ckbHoghooghDate"
        Me.ckbHoghooghDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ckbHoghooghDate.Size = New System.Drawing.Size(333, 18)
        Me.ckbHoghooghDate.TabIndex = 10
        Me.ckbHoghooghDate.Text = "¬Ì« „Ì ŒÊ«ÂÌœ ÕﬁÊﬁ Ê „“«Ì« »—Õ”» ”«· «‰ Œ«»Ì „Õ«”»Â ‘Êœ ø"
        Me.ckbHoghooghDate.UseVisualStyleBackColor = False
        '
        'txtBeginDate
        '
        Me.txtBeginDate.Enabled = False
        Me.txtBeginDate.Location = New System.Drawing.Point(260, 9)
        Me.txtBeginDate.Mask = "0000/00/00"
        Me.txtBeginDate.Name = "txtBeginDate"
        Me.txtBeginDate.Size = New System.Drawing.Size(77, 21)
        Me.txtBeginDate.TabIndex = 3
        '
        'txtEmissionDate
        '
        Me.txtEmissionDate.Location = New System.Drawing.Point(576, 37)
        Me.txtEmissionDate.Mask = "0000/00/00"
        Me.txtEmissionDate.Name = "txtEmissionDate"
        Me.txtEmissionDate.Size = New System.Drawing.Size(69, 21)
        Me.txtEmissionDate.TabIndex = 9
        '
        'txtEndDate
        '
        Me.txtEndDate.Enabled = False
        Me.txtEndDate.Location = New System.Drawing.Point(101, 10)
        Me.txtEndDate.Mask = "0000/00/00"
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(77, 21)
        Me.txtEndDate.TabIndex = 5
        '
        'txtExecuteDate
        '
        Me.txtExecuteDate.Location = New System.Drawing.Point(722, 37)
        Me.txtExecuteDate.Mask = "0000/00/00"
        Me.txtExecuteDate.Name = "txtExecuteDate"
        Me.txtExecuteDate.Size = New System.Drawing.Size(71, 21)
        Me.txtExecuteDate.TabIndex = 7
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(645, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 22)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = " «—ÌŒ ’œÊ— :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(793, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 22)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = " «—ÌŒ «Ã—« :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(184, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 26)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = " «—ÌŒ « „«„ :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(336, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(69, 26)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = " «—ÌŒ ‘—Ê⁄ :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(596, 9)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(86, 21)
        Me.cmbYear.TabIndex = 1
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Red
        Me.lblYear.Location = New System.Drawing.Point(688, 10)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(182, 21)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "”«· „Ê—œ ‰Ÿ— ŒÊœ —« «‰ Œ«» ‰„«ÌÌœ :"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Icon = CType(resources.GetObject("btnExit.Icon"), System.Drawing.Icon)
        Me.btnExit.Location = New System.Drawing.Point(208, 575)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "«‰’—«›"
        Me.btnExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'DgSelect2
        '
        Me.DgSelect2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgSelect2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DgSelect2.Location = New System.Drawing.Point(226, 96)
        Me.DgSelect2.Name = "DgSelect2"
        Me.DgSelect2.Size = New System.Drawing.Size(136, 24)
        Me.DgSelect2.TabIndex = 12
        '
        'DgSelect1
        '
        Me.DgSelect1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgSelect1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DgSelect1.Location = New System.Drawing.Point(709, 97)
        Me.DgSelect1.Name = "DgSelect1"
        Me.DgSelect1.Size = New System.Drawing.Size(136, 24)
        Me.DgSelect1.TabIndex = 11
        '
        'grdPerson
        '
        Me.grdPerson.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grdPerson.CaptionBackColor = System.Drawing.Color.MediumSpringGreen
        Me.grdPerson.CaptionForeColor = System.Drawing.Color.Red
        Me.grdPerson.CaptionText = "Å—”‰· ‘«€·"
        Me.grdPerson.DataMember = ""
        Me.grdPerson.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPerson.Location = New System.Drawing.Point(9, 126)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.Size = New System.Drawing.Size(460, 445)
        Me.grdPerson.TabIndex = 14
        Me.grdPerson.TabStop = False
        '
        'grdMDepart
        '
        Me.grdMDepart.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grdMDepart.CaptionBackColor = System.Drawing.Color.MediumSpringGreen
        Me.grdMDepart.CaptionForeColor = System.Drawing.Color.Red
        Me.grdMDepart.CaptionText = "Ê«ÕœÂ«"
        Me.grdMDepart.DataMember = ""
        Me.grdMDepart.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdMDepart.Location = New System.Drawing.Point(481, 126)
        Me.grdMDepart.Name = "grdMDepart"
        Me.grdMDepart.Size = New System.Drawing.Size(389, 445)
        Me.grdMDepart.TabIndex = 13
        Me.grdMDepart.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Icon = CType(resources.GetObject("btnSave.Icon"), System.Drawing.Icon)
        Me.btnSave.Location = New System.Drawing.Point(544, 575)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "À»  Õﬂ„"
        Me.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'frmPRSHokmsocial
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 599)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPRSHokmsocial"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "’œÊ— Õﬂ„ œ” Â Ã„⁄Ì"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMDepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents grdPerson As System.Windows.Forms.DataGrid
    Friend WithEvents grdMDepart As System.Windows.Forms.DataGrid
    Friend WithEvents DgSelect2 As IKIDUtility.DgSelect
    Friend WithEvents DgSelect1 As IKIDUtility.DgSelect
    Friend WithEvents btnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtBeginDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmissionDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtExecuteDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ckbHoghooghDate As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnTrity As Janus.Windows.EditControls.UIButton
    Friend WithEvents ckbEmployeeCode As System.Windows.Forms.CheckBox
    Friend WithEvents lblEmployeeType As System.Windows.Forms.Label
    Friend WithEvents cmbEmployeeType As System.Windows.Forms.ComboBox
    Friend WithEvents chkGharardad As System.Windows.Forms.CheckBox
    Friend WithEvents JGrade1 As JFrameWork.jGrade
    Friend WithEvents cmbPercent As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
