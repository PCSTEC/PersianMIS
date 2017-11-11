<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewUnit
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
        Dim StringFormat2 As System.Drawing.StringFormat = New System.Drawing.StringFormat
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddNewUnit))
        Dim StringFormat3 As System.Drawing.StringFormat = New System.Drawing.StringFormat
        Dim StringFormat1 As System.Drawing.StringFormat = New System.Drawing.StringFormat
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.cmbKind = New Janus.Windows.EditControls.UIComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbSafSetad = New System.Windows.Forms.ComboBox
        Me.cmbMDepart = New System.Windows.Forms.ComboBox
        Me.lblSafSetad = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblContractName = New System.Windows.Forms.Label
        Me.txtContractionName = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblRoot = New System.Windows.Forms.Label
        Me.lblUpperID = New System.Windows.Forms.Label
        Me.lblContractionName = New System.Windows.Forms.Label
        Me.chkIndependent = New Janus.Windows.EditControls.UICheckBox
        Me.btnCancel = New Janus.Windows.EditControls.UIButton
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.cmbType = New Janus.Windows.EditControls.UIComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbManagerName = New Janus.Windows.EditControls.UIComboBox
        Me.lblManagerName = New System.Windows.Forms.Label
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
        Me.UiGroupBox1.Controls.Add(Me.cmbManagerName)
        Me.UiGroupBox1.Controls.Add(Me.lblManagerName)
        Me.UiGroupBox1.Controls.Add(Me.cmbKind)
        Me.UiGroupBox1.Controls.Add(Me.Label5)
        Me.UiGroupBox1.Controls.Add(Me.cmbSafSetad)
        Me.UiGroupBox1.Controls.Add(Me.cmbMDepart)
        Me.UiGroupBox1.Controls.Add(Me.lblSafSetad)
        Me.UiGroupBox1.Controls.Add(Me.Label4)
        Me.UiGroupBox1.Controls.Add(Me.lblContractName)
        Me.UiGroupBox1.Controls.Add(Me.txtContractionName)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.lblCode)
        Me.UiGroupBox1.Controls.Add(Me.lblRoot)
        Me.UiGroupBox1.Controls.Add(Me.lblUpperID)
        Me.UiGroupBox1.Controls.Add(Me.lblContractionName)
        Me.UiGroupBox1.Controls.Add(Me.chkIndependent)
        Me.UiGroupBox1.Controls.Add(Me.btnCancel)
        Me.UiGroupBox1.Controls.Add(Me.txtName)
        Me.UiGroupBox1.Controls.Add(Me.btnAdd)
        Me.UiGroupBox1.Controls.Add(Me.cmbType)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(328, 283)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'cmbKind
        '
        Me.cmbKind.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cmbKind.Location = New System.Drawing.Point(21, 154)
        Me.cmbKind.Name = "cmbKind"
        Me.cmbKind.Size = New System.Drawing.Size(202, 21)
        StringFormat2.Alignment = System.Drawing.StringAlignment.Near
        StringFormat2.FormatFlags = CType((((System.Drawing.StringFormatFlags.DirectionRightToLeft Or System.Drawing.StringFormatFlags.FitBlackBox) _
                    Or System.Drawing.StringFormatFlags.NoWrap) _
                    Or System.Drawing.StringFormatFlags.NoClip), System.Drawing.StringFormatFlags)
        StringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat2.LineAlignment = System.Drawing.StringAlignment.Center
        StringFormat2.Trimming = System.Drawing.StringTrimming.Character
        Me.cmbKind.StringFormat = StringFormat2
        Me.cmbKind.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(229, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Å‘ Ì»«‰Ì/ Ê·ÌœÌ :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbSafSetad
        '
        Me.cmbSafSetad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSafSetad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSafSetad.FormattingEnabled = True
        Me.cmbSafSetad.Location = New System.Drawing.Point(165, 180)
        Me.cmbSafSetad.Name = "cmbSafSetad"
        Me.cmbSafSetad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbSafSetad.Size = New System.Drawing.Size(84, 21)
        Me.cmbSafSetad.TabIndex = 15
        Me.cmbSafSetad.Visible = False
        '
        'cmbMDepart
        '
        Me.cmbMDepart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMDepart.Enabled = False
        Me.cmbMDepart.FormattingEnabled = True
        Me.cmbMDepart.Location = New System.Drawing.Point(21, 39)
        Me.cmbMDepart.Name = "cmbMDepart"
        Me.cmbMDepart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbMDepart.Size = New System.Drawing.Size(229, 21)
        Me.cmbMDepart.TabIndex = 3
        '
        'lblSafSetad
        '
        Me.lblSafSetad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSafSetad.BackColor = System.Drawing.Color.Transparent
        Me.lblSafSetad.Location = New System.Drawing.Point(253, 180)
        Me.lblSafSetad.Name = "lblSafSetad"
        Me.lblSafSetad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSafSetad.Size = New System.Drawing.Size(69, 21)
        Me.lblSafSetad.TabIndex = 14
        Me.lblSafSetad.Text = "’›/” «œ :"
        Me.lblSafSetad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSafSetad.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(254, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "‰«„ „œÌ—Ì  :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblContractName
        '
        Me.lblContractName.Location = New System.Drawing.Point(126, 128)
        Me.lblContractName.Name = "lblContractName"
        Me.lblContractName.Size = New System.Drawing.Size(17, 16)
        Me.lblContractName.TabIndex = 10
        Me.lblContractName.Visible = False
        '
        'txtContractionName
        '
        Me.txtContractionName.Location = New System.Drawing.Point(149, 125)
        Me.txtContractionName.Mask = "aa"
        Me.txtContractionName.Name = "txtContractionName"
        Me.txtContractionName.Size = New System.Drawing.Size(100, 21)
        Me.txtContractionName.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(254, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(51, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ﬂœ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.Gold
        Me.lblCode.Location = New System.Drawing.Point(167, 203)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCode.Size = New System.Drawing.Size(82, 21)
        Me.lblCode.TabIndex = 17
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRoot
        '
        Me.lblRoot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRoot.BackColor = System.Drawing.Color.Transparent
        Me.lblRoot.Location = New System.Drawing.Point(93, 203)
        Me.lblRoot.Name = "lblRoot"
        Me.lblRoot.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblRoot.Size = New System.Drawing.Size(51, 21)
        Me.lblRoot.TabIndex = 18
        Me.lblRoot.Text = "—Ì‘Â :"
        Me.lblRoot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUpperID
        '
        Me.lblUpperID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUpperID.BackColor = System.Drawing.Color.Transparent
        Me.lblUpperID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblUpperID.ForeColor = System.Drawing.Color.Gold
        Me.lblUpperID.Location = New System.Drawing.Point(10, 203)
        Me.lblUpperID.Name = "lblUpperID"
        Me.lblUpperID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUpperID.Size = New System.Drawing.Size(83, 21)
        Me.lblUpperID.TabIndex = 19
        Me.lblUpperID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContractionName
        '
        Me.lblContractionName.BackColor = System.Drawing.Color.Transparent
        Me.lblContractionName.Location = New System.Drawing.Point(253, 124)
        Me.lblContractionName.Name = "lblContractionName"
        Me.lblContractionName.Size = New System.Drawing.Size(72, 21)
        Me.lblContractionName.TabIndex = 8
        Me.lblContractionName.Text = "‰«„ «Œ ’«—Ì :"
        Me.lblContractionName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkIndependent
        '
        Me.chkIndependent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIndependent.BackColor = System.Drawing.Color.Transparent
        Me.chkIndependent.Location = New System.Drawing.Point(21, 123)
        Me.chkIndependent.Name = "chkIndependent"
        Me.chkIndependent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIndependent.Size = New System.Drawing.Size(84, 23)
        Me.chkIndependent.TabIndex = 11
        Me.chkIndependent.Text = ": „” ﬁ·"
        Me.chkIndependent.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Icon = CType(resources.GetObject("btnCancel.Icon"), System.Drawing.Icon)
        Me.btnCancel.Location = New System.Drawing.Point(81, 248)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "«‰’—«›"
        Me.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(22, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(228, 21)
        Me.txtName.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(175, 248)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "À» "
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'cmbType
        '
        Me.cmbType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cmbType.Location = New System.Drawing.Point(22, 67)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(228, 21)
        StringFormat3.Alignment = System.Drawing.StringAlignment.Near
        StringFormat3.FormatFlags = CType((((System.Drawing.StringFormatFlags.DirectionRightToLeft Or System.Drawing.StringFormatFlags.FitBlackBox) _
                    Or System.Drawing.StringFormatFlags.NoWrap) _
                    Or System.Drawing.StringFormatFlags.NoClip), System.Drawing.StringFormatFlags)
        StringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat3.LineAlignment = System.Drawing.StringAlignment.Center
        StringFormat3.Trimming = System.Drawing.StringTrimming.Character
        Me.cmbType.StringFormat = StringFormat3
        Me.cmbType.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(254, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "‰«„ :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(254, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "‰Ê⁄ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbManagerName
        '
        Me.cmbManagerName.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.cmbManagerName.Location = New System.Drawing.Point(22, 97)
        Me.cmbManagerName.Name = "cmbManagerName"
        Me.cmbManagerName.Size = New System.Drawing.Size(228, 21)
        StringFormat1.Alignment = System.Drawing.StringAlignment.Near
        StringFormat1.FormatFlags = CType((((System.Drawing.StringFormatFlags.DirectionRightToLeft Or System.Drawing.StringFormatFlags.FitBlackBox) _
                    Or System.Drawing.StringFormatFlags.NoWrap) _
                    Or System.Drawing.StringFormatFlags.NoClip), System.Drawing.StringFormatFlags)
        StringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None
        StringFormat1.LineAlignment = System.Drawing.StringAlignment.Center
        StringFormat1.Trimming = System.Drawing.StringTrimming.Character
        Me.cmbManagerName.StringFormat = StringFormat1
        Me.cmbManagerName.TabIndex = 7
        '
        'lblManagerName
        '
        Me.lblManagerName.BackColor = System.Drawing.Color.Transparent
        Me.lblManagerName.Location = New System.Drawing.Point(254, 97)
        Me.lblManagerName.Name = "lblManagerName"
        Me.lblManagerName.Size = New System.Drawing.Size(60, 21)
        Me.lblManagerName.TabIndex = 6
        Me.lblManagerName.Text = "‰«„ „œÌ— :"
        Me.lblManagerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAddNewUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 280)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddNewUnit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "œ—Ã Ê«Õœ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents btnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents chkIndependent As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents lblContractionName As System.Windows.Forms.Label
    Friend WithEvents lblRoot As System.Windows.Forms.Label
    Friend WithEvents lblUpperID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtContractionName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblContractName As System.Windows.Forms.Label
    Friend WithEvents cmbMDepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbSafSetad As System.Windows.Forms.ComboBox
    Friend WithEvents lblSafSetad As System.Windows.Forms.Label
    Friend WithEvents cmbKind As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbManagerName As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents lblManagerName As System.Windows.Forms.Label
End Class
