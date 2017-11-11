<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommodeDevotion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommodeDevotion))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox5 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblCommodeNumberID = New System.Windows.Forms.Label
        Me.lblPersonID = New System.Windows.Forms.Label
        Me.txtTahvilDate = New System.Windows.Forms.MaskedTextBox
        Me.lblCommodeNumber = New System.Windows.Forms.Label
        Me.lblPersonName = New System.Windows.Forms.Label
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.btnChangeAdd = New Janus.Windows.EditControls.UIButton
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDelete = New Janus.Windows.EditControls.UIButton
        Me.btnChange = New Janus.Windows.EditControls.UIButton
        Me.btnExit = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblCommodeID = New System.Windows.Forms.Label
        Me.JGridNavigator2 = New JFrameWork.JGridNavigator
        Me.lblCommodeDevition = New System.Windows.Forms.Label
        Me.grdPersonAndCommode = New Janus.Windows.GridEX.GridEX
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnDeleteCommodeNumber = New Janus.Windows.EditControls.UIButton
        Me.txtCommodeNumber = New System.Windows.Forms.MaskedTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnAddCommode = New Janus.Windows.EditControls.UIButton
        Me.lblCommode = New System.Windows.Forms.Label
        Me.grdCommodeNumber = New Janus.Windows.GridEX.GridEX
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.JGridNavigator1 = New JFrameWork.JGridNavigator
        Me.lblPerson = New System.Windows.Forms.Label
        Me.grdPerson = New Janus.Windows.GridEX.GridEX
        Me.JGrade1 = New JFrameWork.jGrade
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox5.SuspendLayout()
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox4.SuspendLayout()
        CType(Me.grdPersonAndCommode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.grdCommodeNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.AllowDrop = True
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox5)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox4)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(1011, 570)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiGroupBox5
        '
        Me.UiGroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox5.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox5.Controls.Add(Me.lblCommodeNumberID)
        Me.UiGroupBox5.Controls.Add(Me.lblPersonID)
        Me.UiGroupBox5.Controls.Add(Me.txtTahvilDate)
        Me.UiGroupBox5.Controls.Add(Me.lblCommodeNumber)
        Me.UiGroupBox5.Controls.Add(Me.lblPersonName)
        Me.UiGroupBox5.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox5.Controls.Add(Me.btnChangeAdd)
        Me.UiGroupBox5.Controls.Add(Me.btnAdd)
        Me.UiGroupBox5.Controls.Add(Me.Label3)
        Me.UiGroupBox5.Controls.Add(Me.Label4)
        Me.UiGroupBox5.Controls.Add(Me.Label2)
        Me.UiGroupBox5.Controls.Add(Me.Label1)
        Me.UiGroupBox5.Controls.Add(Me.btnDelete)
        Me.UiGroupBox5.Controls.Add(Me.btnChange)
        Me.UiGroupBox5.Controls.Add(Me.btnExit)
        Me.UiGroupBox5.Location = New System.Drawing.Point(8, 255)
        Me.UiGroupBox5.Name = "UiGroupBox5"
        Me.UiGroupBox5.Size = New System.Drawing.Size(995, 61)
        Me.UiGroupBox5.TabIndex = 2
        '
        'lblCommodeNumberID
        '
        Me.lblCommodeNumberID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommodeNumberID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCommodeNumberID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommodeNumberID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCommodeNumberID.Location = New System.Drawing.Point(486, 13)
        Me.lblCommodeNumberID.Name = "lblCommodeNumberID"
        Me.lblCommodeNumberID.Size = New System.Drawing.Size(38, 16)
        Me.lblCommodeNumberID.TabIndex = 7
        Me.lblCommodeNumberID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCommodeNumberID.Visible = False
        '
        'lblPersonID
        '
        Me.lblPersonID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPersonID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblPersonID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPersonID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPersonID.Location = New System.Drawing.Point(755, 13)
        Me.lblPersonID.Name = "lblPersonID"
        Me.lblPersonID.Size = New System.Drawing.Size(38, 16)
        Me.lblPersonID.TabIndex = 2
        Me.lblPersonID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPersonID.Visible = False
        '
        'txtTahvilDate
        '
        Me.txtTahvilDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTahvilDate.Location = New System.Drawing.Point(530, 37)
        Me.txtTahvilDate.Mask = "0000/00/00"
        Me.txtTahvilDate.Name = "txtTahvilDate"
        Me.txtTahvilDate.Size = New System.Drawing.Size(98, 21)
        Me.txtTahvilDate.TabIndex = 9
        '
        'lblCommodeNumber
        '
        Me.lblCommodeNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommodeNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblCommodeNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommodeNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCommodeNumber.Location = New System.Drawing.Point(530, 13)
        Me.lblCommodeNumber.Name = "lblCommodeNumber"
        Me.lblCommodeNumber.Size = New System.Drawing.Size(98, 16)
        Me.lblCommodeNumber.TabIndex = 6
        Me.lblCommodeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonName
        '
        Me.lblPersonName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPersonName.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPersonName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblPersonName.ForeColor = System.Drawing.Color.Red
        Me.lblPersonName.Location = New System.Drawing.Point(695, 39)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(207, 16)
        Me.lblPersonName.TabIndex = 4
        Me.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonCode
        '
        Me.lblPersonCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPersonCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(804, 13)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(98, 16)
        Me.lblPersonCode.TabIndex = 1
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChangeAdd
        '
        Me.btnChangeAdd.Icon = CType(resources.GetObject("btnChangeAdd.Icon"), System.Drawing.Icon)
        Me.btnChangeAdd.Location = New System.Drawing.Point(152, 22)
        Me.btnChangeAdd.Name = "btnChangeAdd"
        Me.btnChangeAdd.Size = New System.Drawing.Size(67, 23)
        Me.btnChangeAdd.TabIndex = 12
        Me.btnChangeAdd.Text = "À» "
        Me.btnChangeAdd.Visible = False
        Me.btnChangeAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnAdd
        '
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(223, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(67, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "œ—Ã"
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(629, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = " «—ÌŒ  ÕÊÌ· :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(629, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "‘„«—Â ﬂ„œ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(905, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "‰«„ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(905, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ﬂœ Å—”‰·Ì :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Icon = CType(resources.GetObject("btnDelete.Icon"), System.Drawing.Icon)
        Me.btnDelete.Location = New System.Drawing.Point(77, 22)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(67, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Õ–›"
        Me.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnChange
        '
        Me.btnChange.Icon = CType(resources.GetObject("btnChange.Icon"), System.Drawing.Icon)
        Me.btnChange.Location = New System.Drawing.Point(150, 22)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(67, 23)
        Me.btnChange.TabIndex = 11
        Me.btnChange.Text = "ÊÌ—«Ì‘"
        Me.btnChange.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnExit
        '
        Me.btnExit.Icon = CType(resources.GetObject("btnExit.Icon"), System.Drawing.Icon)
        Me.btnExit.Location = New System.Drawing.Point(4, 22)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "«‰’—«›"
        Me.btnExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox4
        '
        Me.UiGroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UiGroupBox4.Controls.Add(Me.lblCommodeID)
        Me.UiGroupBox4.Controls.Add(Me.JGridNavigator2)
        Me.UiGroupBox4.Controls.Add(Me.lblCommodeDevition)
        Me.UiGroupBox4.Controls.Add(Me.grdPersonAndCommode)
        Me.UiGroupBox4.Location = New System.Drawing.Point(8, 315)
        Me.UiGroupBox4.Name = "UiGroupBox4"
        Me.UiGroupBox4.Size = New System.Drawing.Size(996, 252)
        Me.UiGroupBox4.TabIndex = 3
        '
        'lblCommodeID
        '
        Me.lblCommodeID.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCommodeID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommodeID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCommodeID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCommodeID.Location = New System.Drawing.Point(562, 11)
        Me.lblCommodeID.Name = "lblCommodeID"
        Me.lblCommodeID.Size = New System.Drawing.Size(38, 16)
        Me.lblCommodeID.TabIndex = 15
        Me.lblCommodeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCommodeID.Visible = False
        '
        'JGridNavigator2
        '
        Me.JGridNavigator2.JDataTable = Nothing
        Me.JGridNavigator2.Location = New System.Drawing.Point(14, 11)
        Me.JGridNavigator2.Name = "JGridNavigator2"
        Me.JGridNavigator2.Size = New System.Drawing.Size(74, 21)
        Me.JGridNavigator2.TabIndex = 1
        Me.JGridNavigator2.TabStop = False
        '
        'lblCommodeDevition
        '
        Me.lblCommodeDevition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommodeDevition.BackColor = System.Drawing.Color.Transparent
        Me.lblCommodeDevition.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCommodeDevition.Location = New System.Drawing.Point(877, 10)
        Me.lblCommodeDevition.Name = "lblCommodeDevition"
        Me.lblCommodeDevition.Size = New System.Drawing.Size(110, 16)
        Me.lblCommodeDevition.TabIndex = 0
        Me.lblCommodeDevition.Text = "Å—”‰· œ«—«Ì ﬂ„œ"
        Me.lblCommodeDevition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdPersonAndCommode
        '
        Me.grdPersonAndCommode.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPersonAndCommode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPersonAndCommode.Location = New System.Drawing.Point(4, 34)
        Me.grdPersonAndCommode.Name = "grdPersonAndCommode"
        Me.grdPersonAndCommode.Size = New System.Drawing.Size(987, 214)
        Me.grdPersonAndCommode.TabIndex = 0
        Me.grdPersonAndCommode.TabStop = False
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UiGroupBox3.Controls.Add(Me.JGrade1)
        Me.UiGroupBox3.Controls.Add(Me.btnDeleteCommodeNumber)
        Me.UiGroupBox3.Controls.Add(Me.txtCommodeNumber)
        Me.UiGroupBox3.Controls.Add(Me.Label5)
        Me.UiGroupBox3.Controls.Add(Me.btnAddCommode)
        Me.UiGroupBox3.Controls.Add(Me.lblCommode)
        Me.UiGroupBox3.Controls.Add(Me.grdCommodeNumber)
        Me.UiGroupBox3.Location = New System.Drawing.Point(3, 5)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(356, 250)
        Me.UiGroupBox3.TabIndex = 1
        '
        'btnDeleteCommodeNumber
        '
        Me.btnDeleteCommodeNumber.Icon = CType(resources.GetObject("btnDeleteCommodeNumber.Icon"), System.Drawing.Icon)
        Me.btnDeleteCommodeNumber.Location = New System.Drawing.Point(157, 53)
        Me.btnDeleteCommodeNumber.Name = "btnDeleteCommodeNumber"
        Me.btnDeleteCommodeNumber.Size = New System.Drawing.Size(84, 23)
        Me.btnDeleteCommodeNumber.TabIndex = 4
        Me.btnDeleteCommodeNumber.Text = "Õ–› ‘„«—Â"
        Me.btnDeleteCommodeNumber.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtCommodeNumber
        '
        Me.txtCommodeNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommodeNumber.Location = New System.Drawing.Point(201, 29)
        Me.txtCommodeNumber.Mask = "0000"
        Me.txtCommodeNumber.Name = "txtCommodeNumber"
        Me.txtCommodeNumber.Size = New System.Drawing.Size(58, 21)
        Me.txtCommodeNumber.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(265, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "‘„«—Â ﬂ„œ ÃœÌœ :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddCommode
        '
        Me.btnAddCommode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCommode.Icon = CType(resources.GetObject("btnAddCommode.Icon"), System.Drawing.Icon)
        Me.btnAddCommode.Location = New System.Drawing.Point(273, 53)
        Me.btnAddCommode.Name = "btnAddCommode"
        Me.btnAddCommode.Size = New System.Drawing.Size(79, 23)
        Me.btnAddCommode.TabIndex = 3
        Me.btnAddCommode.Text = "œ—Ã ‘„«—Â"
        Me.btnAddCommode.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblCommode
        '
        Me.lblCommode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCommode.BackColor = System.Drawing.Color.Transparent
        Me.lblCommode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCommode.Location = New System.Drawing.Point(44, 7)
        Me.lblCommode.Name = "lblCommode"
        Me.lblCommode.Size = New System.Drawing.Size(309, 18)
        Me.lblCommode.TabIndex = 0
        Me.lblCommode.Text = "‘„«—Â ﬂ„œÂ«Ì Œ«·Ì "
        Me.lblCommode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdCommodeNumber
        '
        Me.grdCommodeNumber.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdCommodeNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCommodeNumber.CellToolTipText = "»—«Ì «‰ Œ«» ‘„«—Â ﬂ„œ »— —ÊÌ ‘„«—Â ﬂ„œ „Ê—œ ‰Ÿ— œÊ»«— ﬂ·Ìﬂ ‰„«ÌÌœ"
        Me.grdCommodeNumber.GroupByBoxVisible = False
        Me.grdCommodeNumber.Location = New System.Drawing.Point(3, 82)
        Me.grdCommodeNumber.Name = "grdCommodeNumber"
        Me.grdCommodeNumber.Size = New System.Drawing.Size(349, 162)
        Me.grdCommodeNumber.TabIndex = 2
        Me.grdCommodeNumber.TabStop = False
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Lime
        Me.UiGroupBox2.Controls.Add(Me.JGridNavigator1)
        Me.UiGroupBox2.Controls.Add(Me.lblPerson)
        Me.UiGroupBox2.Controls.Add(Me.grdPerson)
        Me.UiGroupBox2.Location = New System.Drawing.Point(361, 4)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(643, 251)
        Me.UiGroupBox2.TabIndex = 0
        '
        'JGridNavigator1
        '
        Me.JGridNavigator1.JDataTable = Nothing
        Me.JGridNavigator1.Location = New System.Drawing.Point(13, 9)
        Me.JGridNavigator1.Name = "JGridNavigator1"
        Me.JGridNavigator1.Size = New System.Drawing.Size(72, 21)
        Me.JGridNavigator1.TabIndex = 1
        Me.JGridNavigator1.TabStop = False
        '
        'lblPerson
        '
        Me.lblPerson.BackColor = System.Drawing.Color.Transparent
        Me.lblPerson.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblPerson.Location = New System.Drawing.Point(499, 11)
        Me.lblPerson.Name = "lblPerson"
        Me.lblPerson.Size = New System.Drawing.Size(86, 16)
        Me.lblPerson.TabIndex = 0
        Me.lblPerson.Text = "«”«„Ì Å—”‰· "
        Me.lblPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdPerson
        '
        Me.grdPerson.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdPerson.CellToolTipText = "»—«Ì «‰ Œ«» Â— ›—œ »— —ÊÌ ‰«„ ‘Œ’ œÊ»«— ﬂ·Ìﬂ ‰„«ÌÌœ"
        Me.grdPerson.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grdPerson.Location = New System.Drawing.Point(4, 30)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.Size = New System.Drawing.Size(634, 215)
        Me.grdPerson.TabIndex = 2
        Me.grdPerson.TabStop = False
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(3, 8)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 15
        '
        'frmCommodeDevotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 568)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCommodeDevotion"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Œ’Ì’ ﬂ„œ »Â Å—”‰·"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox5.ResumeLayout(False)
        Me.UiGroupBox5.PerformLayout()
        CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox4.ResumeLayout(False)
        CType(Me.grdPersonAndCommode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.grdCommodeNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdPerson As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblCommode As System.Windows.Forms.Label
    Friend WithEvents grdCommodeNumber As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblPerson As System.Windows.Forms.Label
    Friend WithEvents lblCommodeDevition As System.Windows.Forms.Label
    Friend WithEvents grdPersonAndCommode As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAddCommode As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox5 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents JGridNavigator1 As JFrameWork.JGridNavigator
    Friend WithEvents btnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDelete As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnChange As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnChangeAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCommodeNumber As System.Windows.Forms.Label
    Friend WithEvents lblPersonName As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents txtTahvilDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCommodeNumberID As System.Windows.Forms.Label
    Friend WithEvents lblPersonID As System.Windows.Forms.Label
    Friend WithEvents JGridNavigator2 As JFrameWork.JGridNavigator
    Friend WithEvents btnDeleteCommodeNumber As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtCommodeNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCommodeID As System.Windows.Forms.Label
    Friend WithEvents JGrade1 As JFrameWork.jGrade
End Class
