<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SelectYearForDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SelectYearForDelete))
        Me.Cmb_Year = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_DeleteYear = New Telerik.WinControls.UI.RadButton()
        CType(Me.Cmb_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_DeleteYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmb_Year
        '
        Me.Cmb_Year.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Cmb_Year.Location = New System.Drawing.Point(163, 28)
        Me.Cmb_Year.Name = "Cmb_Year"
        Me.Cmb_Year.Size = New System.Drawing.Size(146, 29)
        Me.Cmb_Year.TabIndex = 56
        Me.Cmb_Year.Text = "عادی"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 20)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "سال :"
        '
        'Btn_DeleteYear
        '
        Me.Btn_DeleteYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_DeleteYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_DeleteYear.Image = Global.Calendars.My.Resources.Resources.Delete_OK
        Me.Btn_DeleteYear.Location = New System.Drawing.Point(163, 99)
        Me.Btn_DeleteYear.Name = "Btn_DeleteYear"
        Me.Btn_DeleteYear.Size = New System.Drawing.Size(137, 33)
        Me.Btn_DeleteYear.TabIndex = 57
        Me.Btn_DeleteYear.Text = "حذف سال "
        CType(Me.Btn_DeleteYear.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Calendars.My.Resources.Resources.Delete_OK
        CType(Me.Btn_DeleteYear.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف سال "
        CType(Me.Btn_DeleteYear.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.Btn_DeleteYear.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.Btn_DeleteYear.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.Btn_DeleteYear.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        '
        'Frm_SelectYearForDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 158)
        Me.Controls.Add(Me.Btn_DeleteYear)
        Me.Controls.Add(Me.Cmb_Year)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_SelectYearForDelete"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حذف سال"
        CType(Me.Cmb_Year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_DeleteYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmb_Year As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label1 As Label
    Private WithEvents Btn_DeleteYear As Telerik.WinControls.UI.RadButton
End Class

