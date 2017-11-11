<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangeNode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangeNode))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.chkIndependent = New Janus.Windows.EditControls.UICheckBox
        Me.LblDepID = New System.Windows.Forms.Label
        Me.cmbUpper = New System.Windows.Forms.ComboBox
        Me.btnClose = New Janus.Windows.EditControls.UIButton
        Me.btnSave = New Janus.Windows.EditControls.UIButton
        Me.LblUpper = New System.Windows.Forms.Label
        Me.LblID = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblRoot = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.chkIndependent)
        Me.UiGroupBox1.Controls.Add(Me.LblDepID)
        Me.UiGroupBox1.Controls.Add(Me.cmbUpper)
        Me.UiGroupBox1.Controls.Add(Me.btnClose)
        Me.UiGroupBox1.Controls.Add(Me.btnSave)
        Me.UiGroupBox1.Controls.Add(Me.LblUpper)
        Me.UiGroupBox1.Controls.Add(Me.LblID)
        Me.UiGroupBox1.Controls.Add(Me.cmbType)
        Me.UiGroupBox1.Controls.Add(Me.txtCode)
        Me.UiGroupBox1.Controls.Add(Me.txtName)
        Me.UiGroupBox1.Controls.Add(Me.lblRoot)
        Me.UiGroupBox1.Controls.Add(Me.lblType)
        Me.UiGroupBox1.Controls.Add(Me.lblCode)
        Me.UiGroupBox1.Controls.Add(Me.lblName)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-2, -3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(372, 220)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'chkIndependent
        '
        Me.chkIndependent.BackColor = System.Drawing.Color.Transparent
        Me.chkIndependent.Location = New System.Drawing.Point(296, 140)
        Me.chkIndependent.Name = "chkIndependent"
        Me.chkIndependent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkIndependent.Size = New System.Drawing.Size(72, 23)
        Me.chkIndependent.TabIndex = 9
        Me.chkIndependent.Text = ": „” ﬁ·"
        '
        'LblDepID
        '
        Me.LblDepID.Location = New System.Drawing.Point(205, 225)
        Me.LblDepID.Name = "LblDepID"
        Me.LblDepID.Size = New System.Drawing.Size(74, 20)
        Me.LblDepID.TabIndex = 17
        Me.LblDepID.Visible = False
        '
        'cmbUpper
        '
        Me.cmbUpper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUpper.FormattingEnabled = True
        Me.cmbUpper.Location = New System.Drawing.Point(37, 106)
        Me.cmbUpper.Name = "cmbUpper"
        Me.cmbUpper.Size = New System.Drawing.Size(273, 21)
        Me.cmbUpper.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Icon = CType(resources.GetObject("btnClose.Icon"), System.Drawing.Icon)
        Me.btnClose.Location = New System.Drawing.Point(100, 185)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "«‰’—«›"
        Me.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnSave
        '
        Me.btnSave.Icon = CType(resources.GetObject("btnSave.Icon"), System.Drawing.Icon)
        Me.btnSave.Location = New System.Drawing.Point(197, 185)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "À» "
        Me.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'LblUpper
        '
        Me.LblUpper.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LblUpper.Location = New System.Drawing.Point(149, 225)
        Me.LblUpper.Name = "LblUpper"
        Me.LblUpper.Size = New System.Drawing.Size(50, 20)
        Me.LblUpper.TabIndex = 12
        Me.LblUpper.Visible = False
        '
        'LblID
        '
        Me.LblID.Location = New System.Drawing.Point(72, 225)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(71, 20)
        Me.LblID.TabIndex = 11
        Me.LblID.Visible = False
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(37, 78)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(273, 21)
        Me.cmbType.TabIndex = 6
        '
        'txtCode
        '
        Me.txtCode.Enabled = False
        Me.txtCode.Location = New System.Drawing.Point(37, 16)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(273, 21)
        Me.txtCode.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(37, 46)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(273, 21)
        Me.txtName.TabIndex = 2
        '
        'lblRoot
        '
        Me.lblRoot.BackColor = System.Drawing.Color.Transparent
        Me.lblRoot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblRoot.Location = New System.Drawing.Point(316, 106)
        Me.lblRoot.Name = "lblRoot"
        Me.lblRoot.Size = New System.Drawing.Size(49, 20)
        Me.lblRoot.TabIndex = 7
        Me.lblRoot.Text = "—Ì‘Â :"
        Me.lblRoot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblType.Location = New System.Drawing.Point(318, 76)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(50, 20)
        Me.lblType.TabIndex = 5
        Me.lblType.Text = "‰Ê⁄  :"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.Transparent
        Me.lblCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCode.Location = New System.Drawing.Point(316, 16)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(46, 20)
        Me.lblCode.TabIndex = 3
        Me.lblCode.Text = "ﬂœ  :"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblName.Location = New System.Drawing.Point(316, 46)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "‰«„  :"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmChangeNode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 214)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChangeNode"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ÊÌ—«Ì‘ Ê«Õœ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblRoot As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents LblUpper As System.Windows.Forms.Label
    Friend WithEvents btnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmbUpper As System.Windows.Forms.ComboBox
    Friend WithEvents LblDepID As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkIndependent As Janus.Windows.EditControls.UICheckBox
End Class
