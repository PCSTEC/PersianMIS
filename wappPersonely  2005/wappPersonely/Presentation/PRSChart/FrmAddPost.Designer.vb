<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddPost
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddPost))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.grdPost = New Janus.Windows.GridEX.GridEX
        Me.lblPostTypeID = New System.Windows.Forms.Label
        Me.lblPostCodePishnahadi = New System.Windows.Forms.Label
        Me.cmbPostType = New System.Windows.Forms.ComboBox
        Me.lblPostDepartID = New System.Windows.Forms.Label
        Me.btnCancel = New Janus.Windows.EditControls.UIButton
        Me.btnAdd = New Janus.Windows.EditControls.UIButton
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdPost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.grdPost)
        Me.UiGroupBox1.Controls.Add(Me.lblPostTypeID)
        Me.UiGroupBox1.Controls.Add(Me.lblPostCodePishnahadi)
        Me.UiGroupBox1.Controls.Add(Me.cmbPostType)
        Me.UiGroupBox1.Controls.Add(Me.lblPostDepartID)
        Me.UiGroupBox1.Controls.Add(Me.btnCancel)
        Me.UiGroupBox1.Controls.Add(Me.btnAdd)
        Me.UiGroupBox1.Controls.Add(Me.txtName)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(370, 471)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'grdPost
        '
        Me.grdPost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPost.CellToolTipText = "ÃÂ  ﬂ«—»—Ì ”—Ì⁄ — »— —ÊÌ ‰«„ Â— ›—œ ﬂ·Ìﬂ —«”  ‰„«ÌÌœ"
        Me.grdPost.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.grdPost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.grdPost.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grdPost.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.grdPost.Location = New System.Drawing.Point(12, 201)
        Me.grdPost.Name = "grdPost"
        Me.grdPost.RecordNavigator = True
        Me.grdPost.Size = New System.Drawing.Size(346, 246)
        Me.grdPost.TabIndex = 11
        Me.grdPost.TabStop = False
        '
        'lblPostTypeID
        '
        Me.lblPostTypeID.Location = New System.Drawing.Point(12, 131)
        Me.lblPostTypeID.Name = "lblPostTypeID"
        Me.lblPostTypeID.Size = New System.Drawing.Size(42, 16)
        Me.lblPostTypeID.TabIndex = 10
        Me.lblPostTypeID.Visible = False
        '
        'lblPostCodePishnahadi
        '
        Me.lblPostCodePishnahadi.BackColor = System.Drawing.Color.Transparent
        Me.lblPostCodePishnahadi.ForeColor = System.Drawing.Color.Black
        Me.lblPostCodePishnahadi.Location = New System.Drawing.Point(161, 9)
        Me.lblPostCodePishnahadi.Name = "lblPostCodePishnahadi"
        Me.lblPostCodePishnahadi.Size = New System.Drawing.Size(105, 23)
        Me.lblPostCodePishnahadi.TabIndex = 5
        Me.lblPostCodePishnahadi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPostType
        '
        Me.cmbPostType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPostType.FormattingEnabled = True
        Me.cmbPostType.Location = New System.Drawing.Point(20, 86)
        Me.cmbPostType.Name = "cmbPostType"
        Me.cmbPostType.Size = New System.Drawing.Size(284, 21)
        Me.cmbPostType.TabIndex = 1
        '
        'lblPostDepartID
        '
        Me.lblPostDepartID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPostDepartID.Location = New System.Drawing.Point(60, 131)
        Me.lblPostDepartID.Name = "lblPostDepartID"
        Me.lblPostDepartID.Size = New System.Drawing.Size(39, 16)
        Me.lblPostDepartID.TabIndex = 9
        Me.lblPostDepartID.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Icon = CType(resources.GetObject("btnCancel.Icon"), System.Drawing.Icon)
        Me.btnCancel.Location = New System.Drawing.Point(94, 163)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "«‰’—«›"
        Me.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Icon = CType(resources.GetObject("btnAdd.Icon"), System.Drawing.Icon)
        Me.btnAdd.Location = New System.Drawing.Point(188, 163)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "À» "
        Me.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(20, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(284, 21)
        Me.txtName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(310, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ﬂœ Å”  :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(310, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "‰Ê⁄ Å”  :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(310, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "‰«„ Å”  :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAddPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 470)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddPost"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "œ—Ã Å” "
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdPost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAdd As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblPostDepartID As System.Windows.Forms.Label
    Friend WithEvents cmbPostType As System.Windows.Forms.ComboBox
    Friend WithEvents lblPostCodePishnahadi As System.Windows.Forms.Label
    Friend WithEvents lblPostTypeID As System.Windows.Forms.Label
    Friend WithEvents grdPost As Janus.Windows.GridEX.GridEX
End Class
