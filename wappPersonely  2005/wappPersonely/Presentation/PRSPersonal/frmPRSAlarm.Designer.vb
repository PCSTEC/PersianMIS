<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSAlarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSAlarm))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.JGrade1 = New JFrameWork.jGrade
        Me.JSelect1 = New JFrameWork.jSelect
        Me.JGridNavigator1 = New JFrameWork.JGridNavigator
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.btnOnePrint = New Janus.Windows.EditControls.UIButton
        Me.btnPrintAll = New Janus.Windows.EditControls.UIButton
        Me.btnClose = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.cmbEngageType = New System.Windows.Forms.ComboBox
        Me.lblEngageType = New System.Windows.Forms.Label
        Me.grdEmployee = New Janus.Windows.GridEX.GridEX
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox1.Controls.Add(Me.JGrade1)
        Me.UiGroupBox1.Controls.Add(Me.JSelect1)
        Me.UiGroupBox1.Controls.Add(Me.JGridNavigator1)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -1)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(800, 425)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(0, 3)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 4
        '
        'JSelect1
        '
        Me.JSelect1.Location = New System.Drawing.Point(209, 18)
        Me.JSelect1.Name = "JSelect1"
        Me.JSelect1.Size = New System.Drawing.Size(195, 20)
        Me.JSelect1.TabIndex = 3
        '
        'JGridNavigator1
        '
        Me.JGridNavigator1.JDataTable = Nothing
        Me.JGridNavigator1.Location = New System.Drawing.Point(138, 18)
        Me.JGridNavigator1.Name = "JGridNavigator1"
        Me.JGridNavigator1.Size = New System.Drawing.Size(72, 21)
        Me.JGridNavigator1.TabIndex = 2
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Lime
        Me.UiGroupBox2.Controls.Add(Me.UiButton1)
        Me.UiGroupBox2.Controls.Add(Me.btnOnePrint)
        Me.UiGroupBox2.Controls.Add(Me.btnPrintAll)
        Me.UiGroupBox2.Controls.Add(Me.btnClose)
        Me.UiGroupBox2.Location = New System.Drawing.Point(6, 380)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(791, 42)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiButton1
        '
        Me.UiButton1.Icon = CType(resources.GetObject("UiButton1.Icon"), System.Drawing.Icon)
        Me.UiButton1.Location = New System.Drawing.Point(391, 13)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(99, 23)
        Me.UiButton1.TabIndex = 3
        Me.UiButton1.Text = "چاپ کلی فرم 2"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnOnePrint
        '
        Me.btnOnePrint.Icon = CType(resources.GetObject("btnOnePrint.Icon"), System.Drawing.Icon)
        Me.btnOnePrint.Location = New System.Drawing.Point(297, 13)
        Me.btnOnePrint.Name = "btnOnePrint"
        Me.btnOnePrint.Size = New System.Drawing.Size(88, 23)
        Me.btnOnePrint.TabIndex = 2
        Me.btnOnePrint.Text = "چاپ انفرادي"
        Me.btnOnePrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnPrintAll
        '
        Me.btnPrintAll.Icon = CType(resources.GetObject("btnPrintAll.Icon"), System.Drawing.Icon)
        Me.btnPrintAll.Location = New System.Drawing.Point(496, 13)
        Me.btnPrintAll.Name = "btnPrintAll"
        Me.btnPrintAll.Size = New System.Drawing.Size(99, 23)
        Me.btnPrintAll.TabIndex = 0
        Me.btnPrintAll.Text = "چاپ کلی فرم 1"
        Me.btnPrintAll.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnClose
        '
        Me.btnClose.Icon = CType(resources.GetObject("btnClose.Icon"), System.Drawing.Icon)
        Me.btnClose.Location = New System.Drawing.Point(216, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "انصراف"
        Me.btnClose.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiGroupBox3.Controls.Add(Me.cmbEngageType)
        Me.UiGroupBox3.Controls.Add(Me.lblEngageType)
        Me.UiGroupBox3.Location = New System.Drawing.Point(406, 8)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(392, 34)
        Me.UiGroupBox3.TabIndex = 1
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'cmbEngageType
        '
        Me.cmbEngageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEngageType.FormattingEnabled = True
        Me.cmbEngageType.Location = New System.Drawing.Point(3, 10)
        Me.cmbEngageType.Name = "cmbEngageType"
        Me.cmbEngageType.Size = New System.Drawing.Size(300, 21)
        Me.cmbEngageType.TabIndex = 1
        '
        'lblEngageType
        '
        Me.lblEngageType.BackColor = System.Drawing.Color.Transparent
        Me.lblEngageType.Location = New System.Drawing.Point(309, 9)
        Me.lblEngageType.Name = "lblEngageType"
        Me.lblEngageType.Size = New System.Drawing.Size(76, 20)
        Me.lblEngageType.TabIndex = 0
        Me.lblEngageType.Text = "نوع استخدام :"
        Me.lblEngageType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdEmployee
        '
        Me.grdEmployee.GroupByBoxVisible = False
        Me.grdEmployee.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grdEmployee.Location = New System.Drawing.Point(6, 70)
        Me.grdEmployee.Name = "grdEmployee"
        Me.grdEmployee.Size = New System.Drawing.Size(791, 311)
        Me.grdEmployee.TabIndex = 1
        '
        'frmPRSAlarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 425)
        Me.Controls.Add(Me.grdEmployee)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPRSAlarm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ليست پرسنلي كه قراردادشان تا 60 روز ديگر پايان مي پذيرد يا پايان يافته است"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdEmployee As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnPrintAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblEngageType As System.Windows.Forms.Label
    Friend WithEvents cmbEngageType As System.Windows.Forms.ComboBox
    Friend WithEvents btnOnePrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents JSelect1 As JFrameWork.jSelect
    Friend WithEvents JGridNavigator1 As JFrameWork.JGridNavigator
    Friend WithEvents JGrade1 As JFrameWork.jGrade
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
End Class
