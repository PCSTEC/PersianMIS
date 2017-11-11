<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSPastOfMoavagheh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSPastOfMoavagheh))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnPrintHokm = New Janus.Windows.EditControls.UIButton
        Me.btnNewHokmMoavvaghe = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.grdHokm = New Janus.Windows.GridEX.GridEX
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMoavvaghehDate = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblCurDate = New System.Windows.Forms.Label
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblPersonCode = New System.Windows.Forms.Label
        Me.lblPersonName = New System.Windows.Forms.Label
        Me.btnClose = New Janus.Windows.EditControls.UIButton
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.grdHokm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UiGroupBox1.Controls.Add(Me.btnPrintHokm)
        Me.UiGroupBox1.Controls.Add(Me.btnNewHokmMoavvaghe)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.btnClose)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(719, 361)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnPrintHokm
        '
        Me.btnPrintHokm.Icon = CType(resources.GetObject("btnPrintHokm.Icon"), System.Drawing.Icon)
        Me.btnPrintHokm.Location = New System.Drawing.Point(418, 335)
        Me.btnPrintHokm.Name = "btnPrintHokm"
        Me.btnPrintHokm.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintHokm.TabIndex = 99
        Me.btnPrintHokm.Text = "ç«Å Õﬂ„"
        Me.btnPrintHokm.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnNewHokmMoavvaghe
        '
        Me.btnNewHokmMoavvaghe.Icon = CType(resources.GetObject("btnNewHokmMoavvaghe.Icon"), System.Drawing.Icon)
        Me.btnNewHokmMoavvaghe.Location = New System.Drawing.Point(305, 335)
        Me.btnNewHokmMoavvaghe.Name = "btnNewHokmMoavvaghe"
        Me.btnNewHokmMoavvaghe.Size = New System.Drawing.Size(107, 23)
        Me.btnNewHokmMoavvaghe.TabIndex = 98
        Me.btnNewHokmMoavvaghe.Text = "’œÊ— Õﬂ„ „⁄ÊﬁÂ"
        Me.btnNewHokmMoavvaghe.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox3.BorderColor = System.Drawing.Color.Lime
        Me.UiGroupBox3.Controls.Add(Me.grdHokm)
        Me.UiGroupBox3.Controls.Add(Me.Label2)
        Me.UiGroupBox3.Controls.Add(Me.lblMoavvaghehDate)
        Me.UiGroupBox3.Controls.Add(Me.Label4)
        Me.UiGroupBox3.Controls.Add(Me.lblCurDate)
        Me.UiGroupBox3.Location = New System.Drawing.Point(3, 62)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(710, 267)
        Me.UiGroupBox3.TabIndex = 97
        '
        'grdHokm
        '
        Me.grdHokm.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdHokm.GroupByBoxVisible = False
        Me.grdHokm.Location = New System.Drawing.Point(5, 46)
        Me.grdHokm.Name = "grdHokm"
        Me.grdHokm.Size = New System.Drawing.Size(702, 218)
        Me.grdHokm.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(587, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "«Õﬂ«„ ’«œ—Â «“  «—ÌŒ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoavvaghehDate
        '
        Me.lblMoavvaghehDate.BackColor = System.Drawing.Color.Transparent
        Me.lblMoavvaghehDate.ForeColor = System.Drawing.Color.Red
        Me.lblMoavvaghehDate.Location = New System.Drawing.Point(476, 16)
        Me.lblMoavvaghehDate.Name = "lblMoavvaghehDate"
        Me.lblMoavvaghehDate.Size = New System.Drawing.Size(105, 23)
        Me.lblMoavvaghehDate.TabIndex = 4
        Me.lblMoavvaghehDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(320, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = " «  «—ÌŒ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurDate
        '
        Me.lblCurDate.BackColor = System.Drawing.Color.Transparent
        Me.lblCurDate.ForeColor = System.Drawing.Color.Red
        Me.lblCurDate.Location = New System.Drawing.Point(203, 16)
        Me.lblCurDate.Name = "lblCurDate"
        Me.lblCurDate.Size = New System.Drawing.Size(105, 23)
        Me.lblCurDate.TabIndex = 6
        Me.lblCurDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UiGroupBox2.Controls.Add(Me.Label3)
        Me.UiGroupBox2.Controls.Add(Me.Label5)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonCode)
        Me.UiGroupBox2.Controls.Add(Me.lblPersonName)
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(710, 53)
        Me.UiGroupBox2.TabIndex = 96
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(596, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ﬂœ Å—”‰·Ì :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(329, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "‰«„ :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPersonCode
        '
        Me.lblPersonCode.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonCode.ForeColor = System.Drawing.Color.Red
        Me.lblPersonCode.Location = New System.Drawing.Point(485, 15)
        Me.lblPersonCode.Name = "lblPersonCode"
        Me.lblPersonCode.Size = New System.Drawing.Size(105, 23)
        Me.lblPersonCode.TabIndex = 9
        Me.lblPersonCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPersonName
        '
        Me.lblPersonName.BackColor = System.Drawing.Color.Transparent
        Me.lblPersonName.ForeColor = System.Drawing.Color.Red
        Me.lblPersonName.Location = New System.Drawing.Point(50, 18)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(267, 23)
        Me.lblPersonName.TabIndex = 10
        Me.lblPersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Icon = CType(resources.GetObject("btnClose.Icon"), System.Drawing.Icon)
        Me.btnClose.Location = New System.Drawing.Point(224, 335)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "«‰’—«›"
        Me.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'frmPRSPastOfMoavagheh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 360)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPRSPastOfMoavagheh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Õﬂ„ Â«Ì „«»Ì‰  «—ÌŒ „⁄ÊﬁÂ  « «„—Ê“"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.grdHokm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCurDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMoavvaghehDate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPersonName As System.Windows.Forms.Label
    Friend WithEvents lblPersonCode As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdHokm As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnNewHokmMoavvaghe As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPrintHokm As Janus.Windows.EditControls.UIButton
End Class
