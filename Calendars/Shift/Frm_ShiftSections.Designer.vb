<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ShiftSections
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ShiftSections))
        Me.ManGroup = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Grd_Main = New Telerik.WinControls.UI.RadGridView()
        Me.Txt_SectionCaption = New Telerik.WinControls.UI.RadTextBox()
        Me.groupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Btn_Insert = New Telerik.WinControls.UI.RadButton()
        Me.Btn_Delete = New Telerik.WinControls.UI.RadButton()
        Me.Btn_Update = New Telerik.WinControls.UI.RadButton()
        Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.ManGroup.SuspendLayout()
        CType(Me.Grd_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd_Main.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_SectionCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupPanel2.SuspendLayout()
        CType(Me.Btn_Insert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManGroup
        '
        Me.ManGroup.CanvasColor = System.Drawing.SystemColors.Control
        Me.ManGroup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.ManGroup.Controls.Add(Me.Grd_Main)
        Me.ManGroup.Controls.Add(Me.Txt_SectionCaption)
        Me.ManGroup.Controls.Add(Me.groupPanel2)
        Me.ManGroup.Controls.Add(Me.radLabel1)
        Me.ManGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ManGroup.Location = New System.Drawing.Point(0, 0)
        Me.ManGroup.Name = "ManGroup"
        Me.ManGroup.Size = New System.Drawing.Size(378, 425)
        '
        '
        '
        Me.ManGroup.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ManGroup.Style.BackColorGradientAngle = 90
        Me.ManGroup.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ManGroup.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ManGroup.Style.BorderBottomWidth = 1
        Me.ManGroup.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ManGroup.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ManGroup.Style.BorderLeftWidth = 1
        Me.ManGroup.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ManGroup.Style.BorderRightWidth = 1
        Me.ManGroup.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.ManGroup.Style.BorderTopWidth = 1
        Me.ManGroup.Style.CornerDiameter = 4
        Me.ManGroup.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.ManGroup.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ManGroup.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ManGroup.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.ManGroup.TabIndex = 4
        '
        'Grd_Main
        '
        Me.Grd_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Grd_Main.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grd_Main.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Grd_Main.EnableCustomSorting = True
        Me.Grd_Main.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Grd_Main.ForeColor = System.Drawing.Color.Black
        Me.Grd_Main.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Grd_Main.Location = New System.Drawing.Point(0, 101)
        '
        '
        '
        Me.Grd_Main.MasterTemplate.AllowAddNewRow = False
        Me.Grd_Main.MasterTemplate.AllowCellContextMenu = False
        Me.Grd_Main.MasterTemplate.AllowDeleteRow = False
        Me.Grd_Main.MasterTemplate.AllowEditRow = False
        Me.Grd_Main.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable
        Me.Grd_Main.MasterTemplate.ClipboardCutMode = Telerik.WinControls.UI.GridViewClipboardCutMode.Disable
        Me.Grd_Main.MasterTemplate.ClipboardPasteMode = Telerik.WinControls.UI.GridViewClipboardPasteMode.Disable
        GridViewTextBoxColumn1.FieldName = "SectionId"
        GridViewTextBoxColumn1.HeaderText = "کد"
        GridViewTextBoxColumn1.Name = "SectionId"
        GridViewTextBoxColumn1.Width = 100
        GridViewTextBoxColumn2.FieldName = "SectionCaption"
        GridViewTextBoxColumn2.HeaderText = "عنوان ایستگاه"
        GridViewTextBoxColumn2.Name = "SectionCaption"
        GridViewTextBoxColumn2.Width = 300
        Me.Grd_Main.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2})
        Me.Grd_Main.MasterTemplate.EnableCustomSorting = True
        Me.Grd_Main.MasterTemplate.EnableFiltering = True
        Me.Grd_Main.MasterTemplate.EnableGrouping = False
        Me.Grd_Main.MasterTemplate.ShowChildViewCaptions = True
        Me.Grd_Main.MasterTemplate.ShowFilteringRow = False
        Me.Grd_Main.MasterTemplate.ShowHeaderCellButtons = True
        SortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending
        SortDescriptor1.PropertyName = "DeviceId"
        Me.Grd_Main.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.Grd_Main.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Grd_Main.Name = "Grd_Main"
        Me.Grd_Main.ReadOnly = True
        Me.Grd_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Grd_Main.ShowChildViewCaptions = True
        Me.Grd_Main.ShowHeaderCellButtons = True
        Me.Grd_Main.Size = New System.Drawing.Size(372, 318)
        Me.Grd_Main.TabIndex = 45
        '
        'Txt_SectionCaption
        '
        Me.Txt_SectionCaption.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txt_SectionCaption.Location = New System.Drawing.Point(91, 9)
        Me.Txt_SectionCaption.Name = "Txt_SectionCaption"
        Me.Txt_SectionCaption.NullText = "عنوان قسمت "
        Me.Txt_SectionCaption.Size = New System.Drawing.Size(198, 26)
        Me.Txt_SectionCaption.TabIndex = 39
        '
        'groupPanel2
        '
        Me.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupPanel2.Controls.Add(Me.Btn_Insert)
        Me.groupPanel2.Controls.Add(Me.Btn_Delete)
        Me.groupPanel2.Controls.Add(Me.Btn_Update)
        Me.groupPanel2.Location = New System.Drawing.Point(28, 52)
        Me.groupPanel2.Name = "groupPanel2"
        Me.groupPanel2.Size = New System.Drawing.Size(339, 45)
        '
        '
        '
        Me.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.groupPanel2.Style.BackColorGradientAngle = 90
        Me.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel2.Style.BorderBottomWidth = 1
        Me.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel2.Style.BorderLeftWidth = 1
        Me.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel2.Style.BorderRightWidth = 1
        Me.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupPanel2.Style.BorderTopWidth = 1
        Me.groupPanel2.Style.CornerDiameter = 4
        Me.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.groupPanel2.TabIndex = 37
        '
        'Btn_Insert
        '
        Me.Btn_Insert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Insert.Image = Global.Calendars.My.Resources.Resources.Add_Btn
        Me.Btn_Insert.Location = New System.Drawing.Point(111, 3)
        Me.Btn_Insert.Name = "Btn_Insert"
        Me.Btn_Insert.Size = New System.Drawing.Size(108, 33)
        Me.Btn_Insert.TabIndex = 48
        Me.Btn_Insert.Text = "ثبت "
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Delete.Image = Global.Calendars.My.Resources.Resources.Delete_OK
        Me.Btn_Delete.Location = New System.Drawing.Point(-3, 3)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(108, 33)
        Me.Btn_Delete.TabIndex = 47
        Me.Btn_Delete.Text = "حذف "
        '
        'Btn_Update
        '
        Me.Btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Update.Image = Global.Calendars.My.Resources.Resources.Create_Shift__Okpng
        Me.Btn_Update.Location = New System.Drawing.Point(225, 3)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(108, 33)
        Me.Btn_Update.TabIndex = 46
        Me.Btn_Update.Text = "ویرایش"
        CType(Me.Btn_Update.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Calendars.My.Resources.Resources.Create_Shift__Okpng
        CType(Me.Btn_Update.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ویرایش"
        CType(Me.Btn_Update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.Btn_Update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.Btn_Update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.Btn_Update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        '
        'radLabel1
        '
        Me.radLabel1.BackColor = System.Drawing.Color.Transparent
        Me.radLabel1.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.radLabel1.Location = New System.Drawing.Point(295, 11)
        Me.radLabel1.Name = "radLabel1"
        Me.radLabel1.Size = New System.Drawing.Size(73, 24)
        Me.radLabel1.TabIndex = 31
        Me.radLabel1.Text = "عنوان قسمت :"
        Me.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'Frm_ShiftSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 425)
        Me.Controls.Add(Me.ManGroup)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_ShiftSections"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعریف قسمت ها "
        Me.ManGroup.ResumeLayout(False)
        Me.ManGroup.PerformLayout()
        CType(Me.Grd_Main.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd_Main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_SectionCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupPanel2.ResumeLayout(False)
        CType(Me.Btn_Insert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ManGroup As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents Grd_Main As Telerik.WinControls.UI.RadGridView
    Private WithEvents Txt_SectionCaption As Telerik.WinControls.UI.RadTextBox
    Private WithEvents groupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents Btn_Insert As Telerik.WinControls.UI.RadButton
    Private WithEvents Btn_Delete As Telerik.WinControls.UI.RadButton
    Private WithEvents Btn_Update As Telerik.WinControls.UI.RadButton
    Private WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel
End Class

