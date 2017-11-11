<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBon))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.JSelect1 = New JFrameWork.jSelect
        Me.grdPRS = New Janus.Windows.GridEX.GridEX
        Me.txtBonDate = New System.Windows.Forms.TextBox
        Me.txtBonType = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnList = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.grdMDepart = New Janus.Windows.GridEX.GridEX
        Me.btnPrint = New Janus.Windows.EditControls.UIButton
        Me.JGrade1 = New JFrameWork.jGrade
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.grdPRS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.grdMDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiGroupBox1.Controls.Add(Me.JGrade1)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox1.Controls.Add(Me.txtBonDate)
        Me.UiGroupBox1.Controls.Add(Me.txtBonType)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.btnList)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.btnPrint)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -3)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(562, 604)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiGroupBox3.Controls.Add(Me.JSelect1)
        Me.UiGroupBox3.Controls.Add(Me.grdPRS)
        Me.UiGroupBox3.Location = New System.Drawing.Point(2, 280)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(556, 290)
        Me.UiGroupBox3.TabIndex = 6
        '
        'JSelect1
        '
        Me.JSelect1.Location = New System.Drawing.Point(4, 12)
        Me.JSelect1.Name = "JSelect1"
        Me.JSelect1.Size = New System.Drawing.Size(195, 20)
        Me.JSelect1.TabIndex = 34
        '
        'grdPRS
        '
        Me.grdPRS.Location = New System.Drawing.Point(4, 36)
        Me.grdPRS.Name = "grdPRS"
        Me.grdPRS.Size = New System.Drawing.Size(549, 251)
        Me.grdPRS.TabIndex = 0
        Me.grdPRS.TabStop = False
        '
        'txtBonDate
        '
        Me.txtBonDate.Location = New System.Drawing.Point(7, 80)
        Me.txtBonDate.Name = "txtBonDate"
        Me.txtBonDate.Size = New System.Drawing.Size(204, 21)
        Me.txtBonDate.TabIndex = 1
        '
        'txtBonType
        '
        Me.txtBonType.Location = New System.Drawing.Point(290, 80)
        Me.txtBonType.Name = "txtBonType"
        Me.txtBonType.Size = New System.Drawing.Size(197, 21)
        Me.txtBonType.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(211, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = " «—ÌŒ ﬂ«·« »—ê :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(487, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "‰Ê⁄ ﬂ«·« »—ê :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnList
        '
        Me.btnList.Icon = CType(resources.GetObject("btnList.Icon"), System.Drawing.Icon)
        Me.btnList.Location = New System.Drawing.Point(24, 576)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(96, 27)
        Me.btnList.TabIndex = 6
        Me.btnList.Text = "·Ì”  »‰"
        Me.btnList.Visible = False
        Me.btnList.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiGroupBox2.Controls.Add(Me.grdMDepart)
        Me.UiGroupBox2.Location = New System.Drawing.Point(2, 98)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(556, 182)
        Me.UiGroupBox2.TabIndex = 5
        '
        'grdMDepart
        '
        Me.grdMDepart.Location = New System.Drawing.Point(4, 12)
        Me.grdMDepart.Name = "grdMDepart"
        Me.grdMDepart.Size = New System.Drawing.Size(549, 167)
        Me.grdMDepart.TabIndex = 0
        Me.grdMDepart.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Icon = CType(resources.GetObject("btnPrint.Icon"), System.Drawing.Icon)
        Me.btnPrint.Location = New System.Drawing.Point(228, 576)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(96, 27)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "ç«Å »‰"
        Me.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(0, 0)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 7
        '
        'frmBon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 601)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBon"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "’œÊ— »‰"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.grdPRS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.grdMDepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtBonDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBonType As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdMDepart As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnList As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdPRS As Janus.Windows.GridEX.GridEX
    Friend WithEvents JSelect1 As JFrameWork.jSelect
    Friend WithEvents JGrade1 As JFrameWork.jGrade

End Class
