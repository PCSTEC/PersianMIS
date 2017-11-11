<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChart
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Me.chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.VirtualGrid = New Janus.Windows.GridEX.GridEX
        Me.LblMOdir = New System.Windows.Forms.Label
        Me.LblRaees = New System.Windows.Forms.Label
        Me.LblKarshenas = New System.Windows.Forms.Label
        Me.LblSaier = New System.Windows.Forms.Label
        CType(Me.chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VirtualGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chart1
        '
        Me.chart1.BackColor = System.Drawing.Color.ForestGreen
        Me.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter
        Me.chart1.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.chart1.BorderlineWidth = 2
        Me.chart1.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal
        Me.chart1.BorderSkin.BackImage = "D:\PCS11\PCS\graphic\01.jpg"
        Me.chart1.BorderSkin.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Me.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea2.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea2.Area3DStyle.Inclination = 40
        ChartArea2.Area3DStyle.IsClustered = True
        ChartArea2.Area3DStyle.IsRightAngleAxes = False
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.Area3DStyle.Perspective = 9
        ChartArea2.Area3DStyle.Rotation = 25
        ChartArea2.Area3DStyle.WallWidth = 3
        ChartArea2.AxisX.LabelStyle.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        ChartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        ChartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea2.BackColor = System.Drawing.Color.OldLace
        ChartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea2.BackImage = "C:\IkidSystems\ChartBack.jpg"
        ChartArea2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        ChartArea2.BackSecondaryColor = System.Drawing.Color.White
        ChartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot
        ChartArea2.BorderWidth = 2
        ChartArea2.Name = "Default"
        ChartArea2.ShadowColor = System.Drawing.Color.Black
        ChartArea2.ShadowOffset = 10
        Me.chart1.ChartAreas.Add(ChartArea2)
        Me.chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chart1.Location = New System.Drawing.Point(0, 0)
        Me.chart1.Name = "chart1"
        Me.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Series2.ChartArea = "Default"
        Series2.Color = System.Drawing.SystemColors.ControlDark
        Series2.CustomProperties = "PointWidth=0.3"
        Series2.EmptyPointStyle.LabelToolTip = "??IC?? ?IC?I"
        Series2.Font = New System.Drawing.Font("B Traffic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.IsXValueIndexed = True
        Series2.MarkerSize = 1
        Series2.Name = "مقدار واقعی"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light
        Series2.ShadowColor = System.Drawing.Color.Black
        Series2.ShadowOffset = 2
        Series2.YValuesPerPoint = 6
        Me.chart1.Series.Add(Series2)
        Me.chart1.Size = New System.Drawing.Size(803, 554)
        Me.chart1.TabIndex = 5
        Title3.Font = New System.Drawing.Font("B Titr", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Title3.Name = "Title1"
        Title4.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Title4.Name = "Title2"
        Me.chart1.Titles.Add(Title3)
        Me.chart1.Titles.Add(Title4)
        '
        'VirtualGrid
        '
        Me.VirtualGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VirtualGrid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.VirtualGrid.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.VirtualGrid.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.VirtualGrid.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.VirtualGrid.Location = New System.Drawing.Point(740, 507)
        Me.VirtualGrid.Name = "VirtualGrid"
        Me.VirtualGrid.RecordNavigator = True
        Me.VirtualGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.VirtualGrid.Size = New System.Drawing.Size(19, 21)
        Me.VirtualGrid.TabIndex = 44
        Me.VirtualGrid.TabStop = False
        Me.VirtualGrid.Visible = False
        '
        'LblMOdir
        '
        Me.LblMOdir.AutoSize = True
        Me.LblMOdir.BackColor = System.Drawing.Color.ForestGreen
        Me.LblMOdir.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblMOdir.Location = New System.Drawing.Point(178, 521)
        Me.LblMOdir.Name = "LblMOdir"
        Me.LblMOdir.Size = New System.Drawing.Size(61, 24)
        Me.LblMOdir.TabIndex = 45
        Me.LblMOdir.Text = "Label1"
        '
        'LblRaees
        '
        Me.LblRaees.AutoSize = True
        Me.LblRaees.BackColor = System.Drawing.Color.ForestGreen
        Me.LblRaees.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblRaees.Location = New System.Drawing.Point(321, 521)
        Me.LblRaees.Name = "LblRaees"
        Me.LblRaees.Size = New System.Drawing.Size(61, 24)
        Me.LblRaees.TabIndex = 46
        Me.LblRaees.Text = "Label1"
        '
        'LblKarshenas
        '
        Me.LblKarshenas.AutoSize = True
        Me.LblKarshenas.BackColor = System.Drawing.Color.ForestGreen
        Me.LblKarshenas.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblKarshenas.Location = New System.Drawing.Point(465, 521)
        Me.LblKarshenas.Name = "LblKarshenas"
        Me.LblKarshenas.Size = New System.Drawing.Size(61, 24)
        Me.LblKarshenas.TabIndex = 47
        Me.LblKarshenas.Text = "Label1"
        '
        'LblSaier
        '
        Me.LblSaier.AutoSize = True
        Me.LblSaier.BackColor = System.Drawing.Color.ForestGreen
        Me.LblSaier.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSaier.Location = New System.Drawing.Point(608, 521)
        Me.LblSaier.Name = "LblSaier"
        Me.LblSaier.Size = New System.Drawing.Size(61, 24)
        Me.LblSaier.TabIndex = 48
        Me.LblSaier.Text = "Label1"
        '
        'FrmChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 554)
        Me.Controls.Add(Me.LblSaier)
        Me.Controls.Add(Me.LblKarshenas)
        Me.Controls.Add(Me.LblRaees)
        Me.Controls.Add(Me.LblMOdir)
        Me.Controls.Add(Me.VirtualGrid)
        Me.Controls.Add(Me.chart1)
        Me.Name = "FrmChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نمودار"
        CType(Me.chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VirtualGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents VirtualGrid As Janus.Windows.GridEX.GridEX
    Friend WithEvents LblMOdir As System.Windows.Forms.Label
    Friend WithEvents LblRaees As System.Windows.Forms.Label
    Friend WithEvents LblKarshenas As System.Windows.Forms.Label
    Friend WithEvents LblSaier As System.Windows.Forms.Label
End Class
