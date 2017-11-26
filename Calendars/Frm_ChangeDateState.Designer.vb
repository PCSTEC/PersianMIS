<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ChangeDateState
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ChangeDateState))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.Cmb_Calendare = New Telerik.WinControls.UI.RadDropDownList()
        Me.Btn_CreateCalendare = New Telerik.WinControls.UI.RadButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Description = New System.Windows.Forms.TextBox()
        CType(Me.Cmb_Calendare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_CreateCalendare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "وضعیت :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "تاریخ مورد نظر :"
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.ForeColor = System.Drawing.Color.Maroon
        Me.Lbl_Date.Location = New System.Drawing.Point(203, 9)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(15, 20)
        Me.Lbl_Date.TabIndex = 53
        Me.Lbl_Date.Text = "-"
        '
        'Cmb_Calendare
        '
        Me.Cmb_Calendare.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Cmb_Calendare.Location = New System.Drawing.Point(105, 50)
        Me.Cmb_Calendare.Name = "Cmb_Calendare"
        Me.Cmb_Calendare.Size = New System.Drawing.Size(209, 29)
        Me.Cmb_Calendare.TabIndex = 54
        Me.Cmb_Calendare.Text = "عادی"
        '
        'Btn_CreateCalendare
        '
        Me.Btn_CreateCalendare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_CreateCalendare.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CreateCalendare.Image = Global.Calendars.My.Resources.Resources.Create_Shift__Okpng
        Me.Btn_CreateCalendare.Location = New System.Drawing.Point(156, 173)
        Me.Btn_CreateCalendare.Name = "Btn_CreateCalendare"
        Me.Btn_CreateCalendare.Size = New System.Drawing.Size(137, 33)
        Me.Btn_CreateCalendare.TabIndex = 51
        Me.Btn_CreateCalendare.Text = "ویرایش وضعیت"
        CType(Me.Btn_CreateCalendare.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Calendars.My.Resources.Resources.Create_Shift__Okpng
        CType(Me.Btn_CreateCalendare.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ویرایش وضعیت"
        CType(Me.Btn_CreateCalendare.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.Btn_CreateCalendare.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.Btn_CreateCalendare.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.Btn_CreateCalendare.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "درج مناسبت ها:"
        '
        'Txt_Description
        '
        Me.Txt_Description.Location = New System.Drawing.Point(105, 85)
        Me.Txt_Description.Multiline = True
        Me.Txt_Description.Name = "Txt_Description"
        Me.Txt_Description.Size = New System.Drawing.Size(209, 82)
        Me.Txt_Description.TabIndex = 56
        '
        'Frm_ChangeDateState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 208)
        Me.Controls.Add(Me.Txt_Description)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cmb_Calendare)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_CreateCalendare)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_ChangeDateState"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تغییر وضعیت تقویم یک روز"
        CType(Me.Cmb_Calendare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_CreateCalendare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Private WithEvents Btn_CreateCalendare As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Date As Label
    Friend WithEvents Cmb_Calendare As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Description As TextBox
End Class

