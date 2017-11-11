<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddNode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddNode))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.cmbSafSetad = New System.Windows.Forms.ComboBox
        Me.lblSafSetad = New System.Windows.Forms.Label
        Me.cmbMDepart = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCodes = New System.Windows.Forms.Label
        Me.chkIndependent = New Janus.Windows.EditControls.UICheckBox
        Me.btnCancel = New Janus.Windows.EditControls.UIButton
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.lblRoot = New System.Windows.Forms.Label
        Me.lblUpperID = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.cmbKind = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox1.Controls.Add(Me.cmbKind)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.cmbSafSetad)
        Me.UiGroupBox1.Controls.Add(Me.lblSafSetad)
        Me.UiGroupBox1.Controls.Add(Me.cmbMDepart)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.lblCodes)
        Me.UiGroupBox1.Controls.Add(Me.chkIndependent)
        Me.UiGroupBox1.Controls.Add(Me.btnCancel)
        Me.UiGroupBox1.Controls.Add(Me.btnAdd)
        Me.UiGroupBox1.Controls.Add(Me.lblRoot)
        Me.UiGroupBox1.Controls.Add(Me.lblUpperID)
        Me.UiGroupBox1.Controls.Add(Me.txtName)
        Me.UiGroupBox1.Controls.Add(Me.cmbType)
        Me.UiGroupBox1.Controls.Add(Me.lblCode)
        Me.UiGroupBox1.Controls.Add(Me.lblName)
        Me.UiGroupBox1.Controls.Add(Me.lblType)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -4)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(324, 270)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'cmbSafSetad
        '
        Me.cmbSafSetad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSafSetad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSafSetad.FormattingEnabled = True
        Me.cmbSafSetad.Location = New System.Drawing.Point(20, 174)
        Me.cmbSafSetad.Name = "cmbSafSetad"
        Me.cmbSafSetad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbSafSetad.Size = New System.Drawing.Size(82, 21)
        Me.cmbSafSetad.TabIndex = 12
        Me.cmbSafSetad.Visible = False
        '
        'lblSafSetad
        '
        Me.lblSafSetad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSafSetad.BackColor = System.Drawing.Color.Transparent
        Me.lblSafSetad.Location = New System.Drawing.Point(111, 172)
        Me.lblSafSetad.Name = "lblSafSetad"
        Me.lblSafSetad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSafSetad.Size = New System.Drawing.Size(69, 21)
        Me.lblSafSetad.TabIndex = 11
        Me.lblSafSetad.Text = "’›/” «œ :"
        Me.lblSafSetad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSafSetad.Visible = False
        '
        'cmbMDepart
        '
        Me.cmbMDepart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMDepart.Enabled = False
        Me.cmbMDepart.FormattingEnabled = True
        Me.cmbMDepart.Location = New System.Drawing.Point(20, 44)
        Me.cmbMDepart.Name = "cmbMDepart"
        Me.cmbMDepart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbMDepart.Size = New System.Drawing.Size(229, 21)
        Me.cmbMDepart.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(255, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "‰«„ „œÌ—Ì  :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodes
        '
        Me.lblCodes.BackColor = System.Drawing.Color.Transparent
        Me.lblCodes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCodes.ForeColor = System.Drawing.Color.Yellow
        Me.lblCodes.Location = New System.Drawing.Point(164, 14)
        Me.lblCodes.Name = "lblCodes"
        Me.lblCodes.Size = New System.Drawing.Size(88, 22)
        Me.lblCodes.TabIndex = 1
        Me.lblCodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkIndependent
        '
        Me.chkIndependent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIndependent.BackColor = System.Drawing.Color.Transparent
        Me.chkIndependent.Location = New System.Drawing.Point(237, 172)
        Me.chkIndependent.Name = "chkIndependent"
        Me.chkIndependent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIndependent.Size = New System.Drawing.Size(73, 23)
        Me.chkIndependent.TabIndex = 10
        Me.chkIndependent.Text = ": „” ﬁ·"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Icon = CType(resources.GetObject("btnCancel.Icon"), System.Drawing.Icon)
        Me.btnCancel.Location = New System.Drawing.Point(67, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "«‰’—«›"
        Me.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(161, 241)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "À» "
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblRoot
        '
        Me.lblRoot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRoot.BackColor = System.Drawing.Color.Transparent
        Me.lblRoot.Location = New System.Drawing.Point(255, 208)
        Me.lblRoot.Name = "lblRoot"
        Me.lblRoot.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblRoot.Size = New System.Drawing.Size(51, 21)
        Me.lblRoot.TabIndex = 8
        Me.lblRoot.Text = "—Ì‘Â :"
        Me.lblRoot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUpperID
        '
        Me.lblUpperID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUpperID.BackColor = System.Drawing.Color.Transparent
        Me.lblUpperID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblUpperID.ForeColor = System.Drawing.Color.Yellow
        Me.lblUpperID.Location = New System.Drawing.Point(164, 208)
        Me.lblUpperID.Name = "lblUpperID"
        Me.lblUpperID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUpperID.Size = New System.Drawing.Size(88, 21)
        Me.lblUpperID.TabIndex = 9
        Me.lblUpperID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(20, 73)
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtName.Size = New System.Drawing.Size(229, 21)
        Me.txtName.TabIndex = 5
        '
        'cmbType
        '
        Me.cmbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(20, 102)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbType.Size = New System.Drawing.Size(229, 21)
        Me.cmbType.TabIndex = 7
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Location = New System.Drawing.Point(255, 13)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCode.Size = New System.Drawing.Size(48, 23)
        Me.lblCode.TabIndex = 0
        Me.lblCode.Text = "ﬂœ :"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Location = New System.Drawing.Point(255, 73)
        Me.lblName.Name = "lblName"
        Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblName.Size = New System.Drawing.Size(48, 19)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "‰«„ :"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblType
        '
        Me.lblType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Location = New System.Drawing.Point(255, 102)
        Me.lblType.Name = "lblType"
        Me.lblType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblType.Size = New System.Drawing.Size(48, 19)
        Me.lblType.TabIndex = 6
        Me.lblType.Text = "‰Ê⁄ :"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKind
        '
        Me.cmbKind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKind.FormattingEnabled = True
        Me.cmbKind.Location = New System.Drawing.Point(20, 130)
        Me.cmbKind.Name = "cmbKind"
        Me.cmbKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbKind.Size = New System.Drawing.Size(196, 21)
        Me.cmbKind.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(219, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Å‘ Ì»«‰Ì/ Ê·ÌœÌ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAddNode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 266)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddNode"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "œ—Ã «œ«—Â / ﬁ”„ "
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    ' Friend WithEvents PRSONAL_Omid_testDataSet As wappPersonely.PRSONAL_Omid_testDataSet
    ' Friend WithEvents TbHR_DepartTypeTableAdapter As wappPersonely.PRSONAL_Omid_testDataSetTableAdapters.tbHR_DepartTypeTableAdapter
    Friend WithEvents lblUpperID As System.Windows.Forms.Label
    Friend WithEvents lblRoot As System.Windows.Forms.Label
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkIndependent As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents lblCodes As System.Windows.Forms.Label
    Friend WithEvents cmbMDepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSafSetad As System.Windows.Forms.ComboBox
    Friend WithEvents lblSafSetad As System.Windows.Forms.Label
    Friend WithEvents cmbKind As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
