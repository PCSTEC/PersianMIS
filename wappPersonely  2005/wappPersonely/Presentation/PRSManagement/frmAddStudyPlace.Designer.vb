<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudyPlace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddStudyPlace))
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.JGrade1 = New JFrameWork.jGrade
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.grdCity = New Janus.Windows.GridEX.GridEX
        Me.grdStudyPlaceType = New Janus.Windows.GridEX.GridEX
        Me.lblStudyPlaceType = New System.Windows.Forms.Label
        Me.txtCityTxt = New System.Windows.Forms.TextBox
        Me.lblCity = New System.Windows.Forms.Label
        Me.btnAddCity = New Janus.Windows.EditControls.UIButton
        Me.btnAddStudyPlace = New Janus.Windows.EditControls.UIButton
        Me.lblStudyPlace = New System.Windows.Forms.Label
        Me.txtStudyPlaceName = New System.Windows.Forms.TextBox
        Me.grdStudyPlace = New Janus.Windows.GridEX.GridEX
        Me.btnAddCountry = New Janus.Windows.EditControls.UIButton
        Me.lblCountry = New System.Windows.Forms.Label
        Me.txtCountrytxt = New System.Windows.Forms.TextBox
        Me.grdCountry = New Janus.Windows.GridEX.GridEX
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStudyPlaceType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdStudyPlace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox2.Controls.Add(Me.JGrade1)
        Me.UiGroupBox2.Controls.Add(Me.UiGroupBox1)
        Me.UiGroupBox2.Controls.Add(Me.btnAddStudyPlace)
        Me.UiGroupBox2.Controls.Add(Me.lblStudyPlace)
        Me.UiGroupBox2.Controls.Add(Me.txtStudyPlaceName)
        Me.UiGroupBox2.Controls.Add(Me.grdStudyPlace)
        Me.UiGroupBox2.Controls.Add(Me.btnAddCountry)
        Me.UiGroupBox2.Controls.Add(Me.lblCountry)
        Me.UiGroupBox2.Controls.Add(Me.txtCountrytxt)
        Me.UiGroupBox2.Controls.Add(Me.grdCountry)
        Me.UiGroupBox2.Location = New System.Drawing.Point(1, 0)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(572, 592)
        Me.UiGroupBox2.TabIndex = 1
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(3, 13)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 68)
        Me.JGrade1.TabIndex = 25
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.grdCity)
        Me.UiGroupBox1.Controls.Add(Me.grdStudyPlaceType)
        Me.UiGroupBox1.Controls.Add(Me.lblStudyPlaceType)
        Me.UiGroupBox1.Controls.Add(Me.txtCityTxt)
        Me.UiGroupBox1.Controls.Add(Me.lblCity)
        Me.UiGroupBox1.Controls.Add(Me.btnAddCity)
        Me.UiGroupBox1.Location = New System.Drawing.Point(3, 151)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(563, 295)
        Me.UiGroupBox1.TabIndex = 23
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'grdCity
        '
        Me.grdCity.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdCity.GroupByBoxVisible = False
        Me.grdCity.Location = New System.Drawing.Point(7, 44)
        Me.grdCity.Name = "grdCity"
        Me.grdCity.Size = New System.Drawing.Size(553, 107)
        Me.grdCity.TabIndex = 24
        Me.grdCity.TabStop = False
        '
        'grdStudyPlaceType
        '
        Me.grdStudyPlaceType.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdStudyPlaceType.GroupByBoxVisible = False
        Me.grdStudyPlaceType.Location = New System.Drawing.Point(5, 181)
        Me.grdStudyPlaceType.Name = "grdStudyPlaceType"
        Me.grdStudyPlaceType.Size = New System.Drawing.Size(555, 107)
        Me.grdStudyPlaceType.TabIndex = 23
        Me.grdStudyPlaceType.TabStop = False
        '
        'lblStudyPlaceType
        '
        Me.lblStudyPlaceType.BackColor = System.Drawing.Color.Transparent
        Me.lblStudyPlaceType.Location = New System.Drawing.Point(456, 159)
        Me.lblStudyPlaceType.Name = "lblStudyPlaceType"
        Me.lblStudyPlaceType.Size = New System.Drawing.Size(101, 19)
        Me.lblStudyPlaceType.TabIndex = 19
        Me.lblStudyPlaceType.Text = "‰Ê⁄ „Õ·  Õ’Ì· :"
        Me.lblStudyPlaceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCityTxt
        '
        Me.txtCityTxt.Location = New System.Drawing.Point(212, 14)
        Me.txtCityTxt.Name = "txtCityTxt"
        Me.txtCityTxt.Size = New System.Drawing.Size(245, 21)
        Me.txtCityTxt.TabIndex = 4
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.Color.Transparent
        Me.lblCity.Location = New System.Drawing.Point(456, 14)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(101, 19)
        Me.lblCity.TabIndex = 3
        Me.lblCity.Text = "‰«„ ‘Â— :"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAddCity
        '
        Me.btnAddCity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCity.Icon = CType(resources.GetObject("btnAddCity.Icon"), System.Drawing.Icon)
        Me.btnAddCity.Location = New System.Drawing.Point(123, 15)
        Me.btnAddCity.Name = "btnAddCity"
        Me.btnAddCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddCity.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCity.TabIndex = 5
        Me.btnAddCity.Text = "À»  ‘Â—"
        Me.btnAddCity.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnAddStudyPlace
        '
        Me.btnAddStudyPlace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddStudyPlace.Icon = CType(resources.GetObject("btnAddStudyPlace.Icon"), System.Drawing.Icon)
        Me.btnAddStudyPlace.Location = New System.Drawing.Point(131, 451)
        Me.btnAddStudyPlace.Name = "btnAddStudyPlace"
        Me.btnAddStudyPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddStudyPlace.Size = New System.Drawing.Size(103, 23)
        Me.btnAddStudyPlace.TabIndex = 8
        Me.btnAddStudyPlace.Text = "œ—Ã „Õ·  Õ’Ì·"
        Me.btnAddStudyPlace.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblStudyPlace
        '
        Me.lblStudyPlace.BackColor = System.Drawing.Color.Transparent
        Me.lblStudyPlace.Location = New System.Drawing.Point(465, 451)
        Me.lblStudyPlace.Name = "lblStudyPlace"
        Me.lblStudyPlace.Size = New System.Drawing.Size(101, 19)
        Me.lblStudyPlace.TabIndex = 6
        Me.lblStudyPlace.Text = "‰«„ „Õ·  Õ’Ì· :"
        Me.lblStudyPlace.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStudyPlaceName
        '
        Me.txtStudyPlaceName.Location = New System.Drawing.Point(235, 452)
        Me.txtStudyPlaceName.Name = "txtStudyPlaceName"
        Me.txtStudyPlaceName.Size = New System.Drawing.Size(224, 21)
        Me.txtStudyPlaceName.TabIndex = 7
        '
        'grdStudyPlace
        '
        Me.grdStudyPlace.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdStudyPlace.GroupByBoxVisible = False
        Me.grdStudyPlace.Location = New System.Drawing.Point(8, 478)
        Me.grdStudyPlace.Name = "grdStudyPlace"
        Me.grdStudyPlace.Size = New System.Drawing.Size(556, 107)
        Me.grdStudyPlace.TabIndex = 18
        Me.grdStudyPlace.TabStop = False
        '
        'btnAddCountry
        '
        Me.btnAddCountry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCountry.Icon = CType(resources.GetObject("btnAddCountry.Icon"), System.Drawing.Icon)
        Me.btnAddCountry.Location = New System.Drawing.Point(134, 12)
        Me.btnAddCountry.Name = "btnAddCountry"
        Me.btnAddCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnAddCountry.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCountry.TabIndex = 2
        Me.btnAddCountry.Text = "À»  ﬂ‘Ê—"
        Me.btnAddCountry.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblCountry
        '
        Me.lblCountry.BackColor = System.Drawing.Color.Transparent
        Me.lblCountry.Location = New System.Drawing.Point(466, 12)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(101, 19)
        Me.lblCountry.TabIndex = 0
        Me.lblCountry.Text = "‰«„ ﬂ‘Ê— :"
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCountrytxt
        '
        Me.txtCountrytxt.Location = New System.Drawing.Point(215, 13)
        Me.txtCountrytxt.Name = "txtCountrytxt"
        Me.txtCountrytxt.Size = New System.Drawing.Size(245, 21)
        Me.txtCountrytxt.TabIndex = 1
        '
        'grdCountry
        '
        Me.grdCountry.AllowColumnDrag = False
        Me.grdCountry.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdCountry.GroupByBoxVisible = False
        Me.grdCountry.Location = New System.Drawing.Point(133, 39)
        Me.grdCountry.Name = "grdCountry"
        Me.grdCountry.Size = New System.Drawing.Size(431, 107)
        Me.grdCountry.TabIndex = 0
        Me.grdCountry.TabStop = False
        '
        'frmAddStudyPlace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 593)
        Me.Controls.Add(Me.UiGroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddStudyPlace"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "œ—Ã ﬂ‘Ê—-‘Â—-„Õ·  Õ’Ì·"
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.grdCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStudyPlaceType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdStudyPlace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnAddStudyPlace As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblStudyPlace As System.Windows.Forms.Label
    Friend WithEvents txtStudyPlaceName As System.Windows.Forms.TextBox
    Friend WithEvents grdStudyPlace As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnAddCity As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtCityTxt As System.Windows.Forms.TextBox
    Friend WithEvents btnAddCountry As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents txtCountrytxt As System.Windows.Forms.TextBox
    Friend WithEvents grdCountry As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblStudyPlaceType As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdStudyPlaceType As Janus.Windows.GridEX.GridEX
    Friend WithEvents grdCity As Janus.Windows.GridEX.GridEX
    Friend WithEvents JGrade1 As JFrameWork.jGrade
End Class
