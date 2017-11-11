<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeReport
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
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.JGrade1 = New JFrameWork.jGrade
        Me.btnExportToExcell = New Janus.Windows.EditControls.UIButton
        Me.IkidFormToolbar1 = New WLFormGlobalCtrl_DT.IKIDFormToolbar
        Me.grpParakanesh = New Janus.Windows.EditControls.UIGroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbEngageType = New System.Windows.Forms.ComboBox
        Me.lblMounth = New System.Windows.Forms.Label
        Me.btnParakanesh = New Janus.Windows.EditControls.UIButton
        Me.lblYear = New System.Windows.Forms.Label
        Me.cmbYear = New System.Windows.Forms.ComboBox
        Me.cmbMounth = New System.Windows.Forms.ComboBox
        Me.UiGroupBox5 = New Janus.Windows.EditControls.UIGroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbReportType = New System.Windows.Forms.ComboBox
        Me.grpBetWeenDate = New Janus.Windows.EditControls.UIGroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBegindate = New System.Windows.Forms.MaskedTextBox
        Me.txtUntilDate = New System.Windows.Forms.MaskedTextBox
        Me.DgSelect2 = New IKIDUtility.DgSelect
        Me.grdPerson = New System.Windows.Forms.DataGrid
        Me.btnPrintReport = New Janus.Windows.EditControls.UIButton
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grpParakanesh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParakanesh.SuspendLayout()
        CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox5.SuspendLayout()
        CType(Me.grpBetWeenDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBetWeenDate.SuspendLayout()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.UiButton1)
        Me.UiGroupBox1.Controls.Add(Me.JGrade1)
        Me.UiGroupBox1.Controls.Add(Me.btnExportToExcell)
        Me.UiGroupBox1.Controls.Add(Me.IkidFormToolbar1)
        Me.UiGroupBox1.Controls.Add(Me.grpParakanesh)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox5)
        Me.UiGroupBox1.Controls.Add(Me.grpBetWeenDate)
        Me.UiGroupBox1.Controls.Add(Me.DgSelect2)
        Me.UiGroupBox1.Controls.Add(Me.grdPerson)
        Me.UiGroupBox1.Controls.Add(Me.btnPrintReport)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(875, 571)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiButton1
        '
        Me.UiButton1.Location = New System.Drawing.Point(50, 79)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(89, 23)
        Me.UiButton1.TabIndex = 9
        Me.UiButton1.Text = "«ﬂ”· Õ”«»—”"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(0, -1)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 8
        '
        'btnExportToExcell
        '
        Me.btnExportToExcell.Location = New System.Drawing.Point(220, 50)
        Me.btnExportToExcell.Name = "btnExportToExcell"
        Me.btnExportToExcell.Size = New System.Drawing.Size(75, 23)
        Me.btnExportToExcell.TabIndex = 7
        Me.btnExportToExcell.Text = "Excell"
        Me.btnExportToExcell.Visible = False
        Me.btnExportToExcell.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'IkidFormToolbar1
        '
        Me.IkidFormToolbar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IkidFormToolbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.IkidFormToolbar1.Location = New System.Drawing.Point(453, 80)
        Me.IkidFormToolbar1.Name = "IkidFormToolbar1"
        Me.IkidFormToolbar1.Size = New System.Drawing.Size(273, 22)
        Me.IkidFormToolbar1.TabIndex = 4
        '
        'grpParakanesh
        '
        Me.grpParakanesh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpParakanesh.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.grpParakanesh.BorderColor = System.Drawing.Color.Red
        Me.grpParakanesh.Controls.Add(Me.Label5)
        Me.grpParakanesh.Controls.Add(Me.cmbEngageType)
        Me.grpParakanesh.Controls.Add(Me.lblMounth)
        Me.grpParakanesh.Controls.Add(Me.btnParakanesh)
        Me.grpParakanesh.Controls.Add(Me.lblYear)
        Me.grpParakanesh.Controls.Add(Me.cmbYear)
        Me.grpParakanesh.Controls.Add(Me.cmbMounth)
        Me.grpParakanesh.Location = New System.Drawing.Point(318, 38)
        Me.grpParakanesh.Name = "grpParakanesh"
        Me.grpParakanesh.Size = New System.Drawing.Size(546, 41)
        Me.grpParakanesh.TabIndex = 2
        Me.grpParakanesh.Visible = False
        Me.grpParakanesh.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(235, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "‰Ê⁄ «” Œœ«„ :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbEngageType
        '
        Me.cmbEngageType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEngageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEngageType.FormattingEnabled = True
        Me.cmbEngageType.Items.AddRange(New Object() {"‘—ﬂ Ì", "ÅÌ„«‰ﬂ«—"})
        Me.cmbEngageType.Location = New System.Drawing.Point(95, 13)
        Me.cmbEngageType.Name = "cmbEngageType"
        Me.cmbEngageType.Size = New System.Drawing.Size(134, 21)
        Me.cmbEngageType.TabIndex = 5
        '
        'lblMounth
        '
        Me.lblMounth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMounth.BackColor = System.Drawing.Color.Transparent
        Me.lblMounth.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblMounth.Location = New System.Drawing.Point(519, 14)
        Me.lblMounth.Name = "lblMounth"
        Me.lblMounth.Size = New System.Drawing.Size(31, 20)
        Me.lblMounth.TabIndex = 0
        Me.lblMounth.Text = "„«Â :"
        Me.lblMounth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnParakanesh
        '
        Me.btnParakanesh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnParakanesh.Location = New System.Drawing.Point(4, 14)
        Me.btnParakanesh.Name = "btnParakanesh"
        Me.btnParakanesh.Size = New System.Drawing.Size(85, 20)
        Me.btnParakanesh.TabIndex = 6
        Me.btnParakanesh.Text = "„Õ«”»Â Å—«ﬂ‰‘"
        Me.btnParakanesh.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblYear
        '
        Me.lblYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblYear.Location = New System.Drawing.Point(400, 15)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(37, 19)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "”«· :"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(315, 14)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(79, 21)
        Me.cmbYear.TabIndex = 3
        '
        'cmbMounth
        '
        Me.cmbMounth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMounth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMounth.FormattingEnabled = True
        Me.cmbMounth.Location = New System.Drawing.Point(439, 13)
        Me.cmbMounth.Name = "cmbMounth"
        Me.cmbMounth.Size = New System.Drawing.Size(79, 21)
        Me.cmbMounth.TabIndex = 1
        '
        'UiGroupBox5
        '
        Me.UiGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox5.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox5.Controls.Add(Me.Label1)
        Me.UiGroupBox5.Controls.Add(Me.cmbReportType)
        Me.UiGroupBox5.Location = New System.Drawing.Point(134, 0)
        Me.UiGroupBox5.Name = "UiGroupBox5"
        Me.UiGroupBox5.Size = New System.Drawing.Size(359, 37)
        Me.UiGroupBox5.TabIndex = 0
        Me.UiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "‰Ê⁄ ê“«—‘ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbReportType
        '
        Me.cmbReportType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.Location = New System.Drawing.Point(2, 12)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(273, 21)
        Me.cmbReportType.TabIndex = 1
        '
        'grpBetWeenDate
        '
        Me.grpBetWeenDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpBetWeenDate.BackColor = System.Drawing.Color.Transparent
        Me.grpBetWeenDate.BorderColor = System.Drawing.Color.Red
        Me.grpBetWeenDate.Controls.Add(Me.Label2)
        Me.grpBetWeenDate.Controls.Add(Me.Label3)
        Me.grpBetWeenDate.Controls.Add(Me.Label4)
        Me.grpBetWeenDate.Controls.Add(Me.txtBegindate)
        Me.grpBetWeenDate.Controls.Add(Me.txtUntilDate)
        Me.grpBetWeenDate.Enabled = False
        Me.grpBetWeenDate.Location = New System.Drawing.Point(495, -1)
        Me.grpBetWeenDate.Name = "grpBetWeenDate"
        Me.grpBetWeenDate.Size = New System.Drawing.Size(369, 38)
        Me.grpBetWeenDate.TabIndex = 1
        Me.grpBetWeenDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(278, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "„ÕœÊœÌ  “„«‰Ì :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(228, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "«“  «—ÌŒ :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " «  «—ÌŒ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBegindate
        '
        Me.txtBegindate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBegindate.Location = New System.Drawing.Point(155, 12)
        Me.txtBegindate.Mask = "0000/00/00"
        Me.txtBegindate.Name = "txtBegindate"
        Me.txtBegindate.Size = New System.Drawing.Size(67, 21)
        Me.txtBegindate.TabIndex = 2
        '
        'txtUntilDate
        '
        Me.txtUntilDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUntilDate.Location = New System.Drawing.Point(4, 13)
        Me.txtUntilDate.Mask = "0000/00/00"
        Me.txtUntilDate.Name = "txtUntilDate"
        Me.txtUntilDate.Size = New System.Drawing.Size(91, 21)
        Me.txtUntilDate.TabIndex = 4
        '
        'DgSelect2
        '
        Me.DgSelect2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgSelect2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DgSelect2.Location = New System.Drawing.Point(728, 80)
        Me.DgSelect2.Name = "DgSelect2"
        Me.DgSelect2.Size = New System.Drawing.Size(136, 24)
        Me.DgSelect2.TabIndex = 5
        '
        'grdPerson
        '
        Me.grdPerson.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPerson.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grdPerson.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grdPerson.CaptionText = "Å—”‰· ‘«€·"
        Me.grdPerson.DataMember = ""
        Me.grdPerson.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPerson.Location = New System.Drawing.Point(7, 103)
        Me.grdPerson.Name = "grdPerson"
        Me.grdPerson.ReadOnly = True
        Me.grdPerson.SelectionBackColor = System.Drawing.Color.Yellow
        Me.grdPerson.Size = New System.Drawing.Size(857, 460)
        Me.grdPerson.TabIndex = 6
        Me.grdPerson.TabStop = False
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Location = New System.Drawing.Point(139, 50)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintReport.TabIndex = 3
        Me.btnPrintReport.Text = "‰„«Ì‘"
        Me.btnPrintReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'frmMakeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 568)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMakeReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ê“«—‘ êÌ—Ì"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.grpParakanesh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParakanesh.ResumeLayout(False)
        CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox5.ResumeLayout(False)
        CType(Me.grpBetWeenDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBetWeenDate.ResumeLayout(False)
        Me.grpBetWeenDate.PerformLayout()
        CType(Me.grdPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnPrintReport As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUntilDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBegindate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grdPerson As System.Windows.Forms.DataGrid
    Friend WithEvents DgSelect2 As IKIDUtility.DgSelect
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpBetWeenDate As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox5 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnParakanesh As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmbMounth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblMounth As System.Windows.Forms.Label
    Friend WithEvents grpParakanesh As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents IkidFormToolbar1 As WLFormGlobalCtrl_DT.IKIDFormToolbar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbEngageType As System.Windows.Forms.ComboBox
    Friend WithEvents btnExportToExcell As Janus.Windows.EditControls.UIButton
    Friend WithEvents JGrade1 As JFrameWork.jGrade
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
End Class
