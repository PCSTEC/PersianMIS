<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobRequest
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobRequest))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.grdPerson = New Janus.Windows.GridEX.GridEX
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmFrmNewPerson = New System.Windows.Forms.ToolStripMenuItem
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnClose = New Janus.Windows.EditControls.UIButton
        Me.btnSave = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.cmbEducationType = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbMDepartCode = New System.Windows.Forms.ComboBox
        Me.lblMDepCode = New System.Windows.Forms.Label
        Me.cmbAttitudeID = New System.Windows.Forms.ComboBox
        Me.lblAttitudeType = New System.Windows.Forms.Label
        Me.cmbDiploma = New System.Windows.Forms.ComboBox
        Me.lblDiploma = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBirthDate = New System.Windows.Forms.MaskedTextBox
        Me.txtFormID = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbMilitary = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbBirthCity = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.txtIDNum = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNationalCode = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.JGrade1 = New JFrameWork.jGrade
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.JGrade1)
        Me.UiGroupBox1.Controls.Add(Me.grdPerson)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-3, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(869, 569)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'grdPerson
        '
        Me.grdPerson.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPerson.CellToolTipText = "ÃÂ  «‰ ﬁ«· ›—œ »Â Å—”‰· »œÊ «” Œœ«„ ﬂ·Ìﬂ —«”  ‰„«ÌÌœ"
        Me.grdPerson.ContextMenuStrip = Me.ContextMenuStrip1
        Me.grdPerson.Location = New System.Drawing.Point(9, 289)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.Size = New System.Drawing.Size(851, 277)
        Me.grdPerson.TabIndex = 0
        Me.grdPerson.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFrmNewPerson})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 26)
        '
        'tsmFrmNewPerson
        '
        Me.tsmFrmNewPerson.Image = CType(resources.GetObject("tsmFrmNewPerson.Image"), System.Drawing.Image)
        Me.tsmFrmNewPerson.Name = "tsmFrmNewPerson"
        Me.tsmFrmNewPerson.Size = New System.Drawing.Size(135, 22)
        Me.tsmFrmNewPerson.Text = "›—„ «” Œœ«„"
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox3.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox3.Controls.Add(Me.btnClose)
        Me.UiGroupBox3.Controls.Add(Me.btnSave)
        Me.UiGroupBox3.Location = New System.Drawing.Point(8, 248)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(851, 40)
        Me.UiGroupBox3.TabIndex = 1
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnClose
        '
        Me.btnClose.Icon = CType(resources.GetObject("btnClose.Icon"), System.Drawing.Icon)
        Me.btnClose.Location = New System.Drawing.Point(308, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "«‰’—«›"
        Me.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnSave
        '
        Me.btnSave.Icon = CType(resources.GetObject("btnSave.Icon"), System.Drawing.Icon)
        Me.btnSave.Location = New System.Drawing.Point(410, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "À» "
        Me.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Lime
        Me.UiGroupBox2.Controls.Add(Me.cmbEducationType)
        Me.UiGroupBox2.Controls.Add(Me.Label8)
        Me.UiGroupBox2.Controls.Add(Me.cmbMDepartCode)
        Me.UiGroupBox2.Controls.Add(Me.lblMDepCode)
        Me.UiGroupBox2.Controls.Add(Me.cmbAttitudeID)
        Me.UiGroupBox2.Controls.Add(Me.lblAttitudeType)
        Me.UiGroupBox2.Controls.Add(Me.cmbDiploma)
        Me.UiGroupBox2.Controls.Add(Me.lblDiploma)
        Me.UiGroupBox2.Controls.Add(Me.txtMobile)
        Me.UiGroupBox2.Controls.Add(Me.txtTel)
        Me.UiGroupBox2.Controls.Add(Me.Label10)
        Me.UiGroupBox2.Controls.Add(Me.Label9)
        Me.UiGroupBox2.Controls.Add(Me.txtDate)
        Me.UiGroupBox2.Controls.Add(Me.Label7)
        Me.UiGroupBox2.Controls.Add(Me.txtBirthDate)
        Me.UiGroupBox2.Controls.Add(Me.txtFormID)
        Me.UiGroupBox2.Controls.Add(Me.Label19)
        Me.UiGroupBox2.Controls.Add(Me.cmbMilitary)
        Me.UiGroupBox2.Controls.Add(Me.Label6)
        Me.UiGroupBox2.Controls.Add(Me.Label3)
        Me.UiGroupBox2.Controls.Add(Me.cmbBirthCity)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Controls.Add(Me.Label2)
        Me.UiGroupBox2.Controls.Add(Me.txtLName)
        Me.UiGroupBox2.Controls.Add(Me.Label11)
        Me.UiGroupBox2.Controls.Add(Me.Label13)
        Me.UiGroupBox2.Controls.Add(Me.txtFName)
        Me.UiGroupBox2.Controls.Add(Me.txtIDNum)
        Me.UiGroupBox2.Controls.Add(Me.Label5)
        Me.UiGroupBox2.Controls.Add(Me.Label4)
        Me.UiGroupBox2.Controls.Add(Me.txtNationalCode)
        Me.UiGroupBox2.Controls.Add(Me.txtName)
        Me.UiGroupBox2.Location = New System.Drawing.Point(142, -4)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(723, 252)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'cmbEducationType
        '
        Me.cmbEducationType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEducationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEducationType.FormattingEnabled = True
        Me.cmbEducationType.Location = New System.Drawing.Point(0, 160)
        Me.cmbEducationType.Name = "cmbEducationType"
        Me.cmbEducationType.Size = New System.Drawing.Size(240, 21)
        Me.cmbEducationType.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(242, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "‰Ê⁄ „œ—ﬂ :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMDepartCode
        '
        Me.cmbMDepartCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMDepartCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMDepartCode.FormattingEnabled = True
        Me.cmbMDepartCode.Location = New System.Drawing.Point(0, 216)
        Me.cmbMDepartCode.Name = "cmbMDepartCode"
        Me.cmbMDepartCode.Size = New System.Drawing.Size(240, 21)
        Me.cmbMDepartCode.TabIndex = 31
        '
        'lblMDepCode
        '
        Me.lblMDepCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMDepCode.BackColor = System.Drawing.Color.Transparent
        Me.lblMDepCode.Location = New System.Drawing.Point(242, 213)
        Me.lblMDepCode.Name = "lblMDepCode"
        Me.lblMDepCode.Size = New System.Drawing.Size(89, 25)
        Me.lblMDepCode.TabIndex = 30
        Me.lblMDepCode.Text = "Ê«Õœ „—»ÊÿÂ :"
        Me.lblMDepCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbAttitudeID
        '
        Me.cmbAttitudeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAttitudeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAttitudeID.FormattingEnabled = True
        Me.cmbAttitudeID.Location = New System.Drawing.Point(0, 188)
        Me.cmbAttitudeID.Name = "cmbAttitudeID"
        Me.cmbAttitudeID.Size = New System.Drawing.Size(240, 21)
        Me.cmbAttitudeID.TabIndex = 29
        '
        'lblAttitudeType
        '
        Me.lblAttitudeType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAttitudeType.BackColor = System.Drawing.Color.Transparent
        Me.lblAttitudeType.Location = New System.Drawing.Point(242, 185)
        Me.lblAttitudeType.Name = "lblAttitudeType"
        Me.lblAttitudeType.Size = New System.Drawing.Size(89, 25)
        Me.lblAttitudeType.TabIndex = 28
        Me.lblAttitudeType.Text = "—‘ Â  Õ’Ì·Ì :"
        Me.lblAttitudeType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDiploma
        '
        Me.cmbDiploma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDiploma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDiploma.FormattingEnabled = True
        Me.cmbDiploma.Location = New System.Drawing.Point(0, 132)
        Me.cmbDiploma.Name = "cmbDiploma"
        Me.cmbDiploma.Size = New System.Drawing.Size(240, 21)
        Me.cmbDiploma.TabIndex = 25
        '
        'lblDiploma
        '
        Me.lblDiploma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiploma.BackColor = System.Drawing.Color.Transparent
        Me.lblDiploma.Location = New System.Drawing.Point(242, 129)
        Me.lblDiploma.Name = "lblDiploma"
        Me.lblDiploma.Size = New System.Drawing.Size(63, 25)
        Me.lblDiploma.TabIndex = 24
        Me.lblDiploma.Text = "„œ—ﬂ :"
        Me.lblDiploma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobile
        '
        Me.txtMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMobile.Location = New System.Drawing.Point(0, 76)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(240, 21)
        Me.txtMobile.TabIndex = 21
        '
        'txtTel
        '
        Me.txtTel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTel.Location = New System.Drawing.Point(0, 104)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(239, 21)
        Me.txtTel.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(242, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = " ·›‰ Â„—«Â :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(242, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 26)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = " ·›‰ :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(0, 18)
        Me.txtDate.Mask = "0000/00/00"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(240, 21)
        Me.txtDate.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(242, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(79, 26)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = " «—ÌŒ „—«Ã⁄Â :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBirthDate
        '
        Me.txtBirthDate.Location = New System.Drawing.Point(355, 189)
        Me.txtBirthDate.Mask = "0000/00/00"
        Me.txtBirthDate.Name = "txtBirthDate"
        Me.txtBirthDate.Size = New System.Drawing.Size(270, 21)
        Me.txtBirthDate.TabIndex = 15
        '
        'txtFormID
        '
        Me.txtFormID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormID.Location = New System.Drawing.Point(433, 18)
        Me.txtFormID.Name = "txtFormID"
        Me.txtFormID.Size = New System.Drawing.Size(192, 21)
        Me.txtFormID.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(628, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(66, 26)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "‘„«—Â ›—„ :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMilitary
        '
        Me.cmbMilitary.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMilitary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMilitary.FormattingEnabled = True
        Me.cmbMilitary.Location = New System.Drawing.Point(0, 46)
        Me.cmbMilitary.Name = "cmbMilitary"
        Me.cmbMilitary.Size = New System.Drawing.Size(239, 21)
        Me.cmbMilitary.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(628, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(95, 26)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "‘„«—Â ‘‰«”‰«„Â :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(628, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(72, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "‰«„ Åœ— :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbBirthCity
        '
        Me.cmbBirthCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBirthCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBirthCity.FormattingEnabled = True
        Me.cmbBirthCity.Location = New System.Drawing.Point(355, 216)
        Me.cmbBirthCity.Name = "cmbBirthCity"
        Me.cmbBirthCity.Size = New System.Drawing.Size(270, 21)
        Me.cmbBirthCity.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(628, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(70, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "‰«„ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(628, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "‰«„ Œ«‰Ê«œêÌ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLName
        '
        Me.txtLName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLName.Location = New System.Drawing.Point(355, 76)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(270, 21)
        Me.txtLName.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(242, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 25)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Œœ„  ”—»«“Ì :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(628, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(63, 26)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "ﬂœ „·Ì :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFName
        '
        Me.txtFName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFName.Location = New System.Drawing.Point(355, 104)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(270, 21)
        Me.txtFName.TabIndex = 9
        '
        'txtIDNum
        '
        Me.txtIDNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIDNum.Location = New System.Drawing.Point(355, 132)
        Me.txtIDNum.Name = "txtIDNum"
        Me.txtIDNum.Size = New System.Drawing.Size(270, 21)
        Me.txtIDNum.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(628, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(66, 26)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "„Õ·  Ê·œ :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(628, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(66, 26)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = " «—ÌŒ  Ê·œ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNationalCode
        '
        Me.txtNationalCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNationalCode.Location = New System.Drawing.Point(355, 160)
        Me.txtNationalCode.Name = "txtNationalCode"
        Me.txtNationalCode.Size = New System.Drawing.Size(270, 21)
        Me.txtNationalCode.TabIndex = 13
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(355, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(270, 21)
        Me.txtName.TabIndex = 5
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(3, -5)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 2
        '
        'frmJobRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 568)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJobRequest"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "œ—ŒÊ«”  ﬂ«—"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtBirthDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFormID As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbMilitary As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbBirthCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtIDNum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNationalCode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbAttitudeID As System.Windows.Forms.ComboBox
    Friend WithEvents lblAttitudeType As System.Windows.Forms.Label
    Friend WithEvents cmbDiploma As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiploma As System.Windows.Forms.Label
    Friend WithEvents cmbMDepartCode As System.Windows.Forms.ComboBox
    Friend WithEvents lblMDepCode As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmbEducationType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grdPerson As Janus.Windows.GridEX.GridEX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmFrmNewPerson As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JGrade1 As JFrameWork.jGrade
End Class
