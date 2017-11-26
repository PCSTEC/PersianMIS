<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DefineCalendar
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DefineCalendar))
        Me.label2 = New System.Windows.Forms.Label()
        Me.Btn_ShowCalendar = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Btn_EditCalendar = New System.Windows.Forms.PictureBox()
        Me.Lbl_DeleteCalendar = New System.Windows.Forms.Label()
        Me.Btn_DeleteCalendar = New System.Windows.Forms.PictureBox()
        Me.Lbl_CreateCalendar = New System.Windows.Forms.Label()
        Me.Btn_GenerateCalendar = New System.Windows.Forms.PictureBox()
        CType(Me.Btn_ShowCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_EditCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_DeleteCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_GenerateCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(143, 119)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(115, 20)
        Me.label2.TabIndex = 65
        Me.label2.Text = "مشاهده و ویرایش تقویم"
        '
        'Btn_ShowCalendar
        '
        Me.Btn_ShowCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ShowCalendar.Image = Global.Calendars.My.Resources.Resources.show
        Me.Btn_ShowCalendar.Location = New System.Drawing.Point(150, 12)
        Me.Btn_ShowCalendar.Name = "Btn_ShowCalendar"
        Me.Btn_ShowCalendar.Size = New System.Drawing.Size(104, 104)
        Me.Btn_ShowCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_ShowCalendar.TabIndex = 64
        Me.Btn_ShowCalendar.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(453, 267)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(69, 20)
        Me.label1.TabIndex = 63
        Me.label1.Text = "ویرایش تقویم"
        Me.label1.Visible = False
        '
        'Btn_EditCalendar
        '
        Me.Btn_EditCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EditCalendar.Image = Global.Calendars.My.Resources.Resources.edit
        Me.Btn_EditCalendar.Location = New System.Drawing.Point(430, 159)
        Me.Btn_EditCalendar.Name = "Btn_EditCalendar"
        Me.Btn_EditCalendar.Size = New System.Drawing.Size(104, 104)
        Me.Btn_EditCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_EditCalendar.TabIndex = 62
        Me.Btn_EditCalendar.TabStop = False
        Me.Btn_EditCalendar.Visible = False
        '
        'Lbl_DeleteCalendar
        '
        Me.Lbl_DeleteCalendar.AutoSize = True
        Me.Lbl_DeleteCalendar.Location = New System.Drawing.Point(43, 120)
        Me.Lbl_DeleteCalendar.Name = "Lbl_DeleteCalendar"
        Me.Lbl_DeleteCalendar.Size = New System.Drawing.Size(60, 20)
        Me.Lbl_DeleteCalendar.TabIndex = 61
        Me.Lbl_DeleteCalendar.Text = "حذف تقویم"
        '
        'Btn_DeleteCalendar
        '
        Me.Btn_DeleteCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_DeleteCalendar.Image = Global.Calendars.My.Resources.Resources.delete
        Me.Btn_DeleteCalendar.Location = New System.Drawing.Point(23, 12)
        Me.Btn_DeleteCalendar.Name = "Btn_DeleteCalendar"
        Me.Btn_DeleteCalendar.Size = New System.Drawing.Size(104, 104)
        Me.Btn_DeleteCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_DeleteCalendar.TabIndex = 60
        Me.Btn_DeleteCalendar.TabStop = False
        '
        'Lbl_CreateCalendar
        '
        Me.Lbl_CreateCalendar.AutoSize = True
        Me.Lbl_CreateCalendar.Location = New System.Drawing.Point(311, 120)
        Me.Lbl_CreateCalendar.Name = "Lbl_CreateCalendar"
        Me.Lbl_CreateCalendar.Size = New System.Drawing.Size(63, 20)
        Me.Lbl_CreateCalendar.TabIndex = 59
        Me.Lbl_CreateCalendar.Text = "ایجاد تقویم "
        '
        'Btn_GenerateCalendar
        '
        Me.Btn_GenerateCalendar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_GenerateCalendar.Image = Global.Calendars.My.Resources.Resources.create
        Me.Btn_GenerateCalendar.Location = New System.Drawing.Point(288, 12)
        Me.Btn_GenerateCalendar.Name = "Btn_GenerateCalendar"
        Me.Btn_GenerateCalendar.Size = New System.Drawing.Size(104, 104)
        Me.Btn_GenerateCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_GenerateCalendar.TabIndex = 58
        Me.Btn_GenerateCalendar.TabStop = False
        '
        'Frm_DefineCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(413, 152)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Btn_ShowCalendar)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Btn_EditCalendar)
        Me.Controls.Add(Me.Lbl_DeleteCalendar)
        Me.Controls.Add(Me.Btn_DeleteCalendar)
        Me.Controls.Add(Me.Lbl_CreateCalendar)
        Me.Controls.Add(Me.Btn_GenerateCalendar)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_DefineCalendar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعریف تقویم "
        CType(Me.Btn_ShowCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_EditCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_DeleteCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_GenerateCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents Btn_ShowCalendar As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents Btn_EditCalendar As PictureBox
    Private WithEvents Lbl_DeleteCalendar As Label
    Private WithEvents Btn_DeleteCalendar As PictureBox
    Private WithEvents Lbl_CreateCalendar As Label
    Private WithEvents Btn_GenerateCalendar As PictureBox
End Class

