<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRSMainChart
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPRSMainChart))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.JGrade1 = New JFrameWork.jGrade
        Me.lblDepName = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GrdPost = New Janus.Windows.GridEX.GridEX
        Me.ContextGrdPost = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.contextAddPost = New System.Windows.Forms.ToolStripMenuItem
        Me.contextDelPost = New System.Windows.Forms.ToolStripMenuItem
        Me.����������с��ToolStripMenuItem = New ToolStripMenuItem
        Me.TrvOrganChart = New System.Windows.Forms.TreeView
        Me.ContextTrvChart = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.contextAddNode = New System.Windows.Forms.ToolStripMenuItem
        Me.contextDelNode = New System.Windows.Forms.ToolStripMenuItem
        Me.contextPersonInDepart = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.���������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.���ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.�������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.���������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.��������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.��́��ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.��݁��ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.����������с��ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.����ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.����ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.contextPersEzafeInMDep = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextGrdPost.SuspendLayout()
        Me.ContextTrvChart.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.JGrade1)
        Me.UiGroupBox1.Controls.Add(Me.lblDepName)
        Me.UiGroupBox1.Controls.Add(Me.PictureBox1)
        Me.UiGroupBox1.Controls.Add(Me.GrdPost)
        Me.UiGroupBox1.Controls.Add(Me.TrvOrganChart)
        Me.UiGroupBox1.Location = New System.Drawing.Point(0, -11)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(862, 468)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'JGrade1
        '
        Me.JGrade1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.JGrade1.BackColor = System.Drawing.Color.White
        Me.JGrade1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JGrade1.Location = New System.Drawing.Point(728, 167)
        Me.JGrade1.Name = "JGrade1"
        Me.JGrade1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.JGrade1.Size = New System.Drawing.Size(128, 67)
        Me.JGrade1.TabIndex = 5
        '
        'lblDepName
        '
        Me.lblDepName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDepName.BackColor = System.Drawing.Color.Transparent
        Me.lblDepName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepName.Font = New System.Drawing.Font("Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblDepName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDepName.Location = New System.Drawing.Point(433, 238)
        Me.lblDepName.Name = "lblDepName"
        Me.lblDepName.Size = New System.Drawing.Size(423, 19)
        Me.lblDepName.TabIndex = 4
        Me.lblDepName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(433, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(424, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GrdPost
        '
        Me.GrdPost.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdPost.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdPost.BlendColor = System.Drawing.Color.Transparent
        Me.GrdPost.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GrdPost.ContextMenuStrip = Me.ContextGrdPost
        Me.GrdPost.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GrdPost.GroupByBoxVisible = False
        Me.GrdPost.Location = New System.Drawing.Point(433, 258)
        Me.GrdPost.Name = "GrdPost"
        Me.GrdPost.Size = New System.Drawing.Size(424, 203)
        Me.GrdPost.TabIndex = 2
        '
        'ContextGrdPost
        '
        Me.ContextGrdPost.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contextAddPost, Me.contextDelPost, Me.����������с��ToolStripMenuItem})
        Me.ContextGrdPost.Name = "ContextMenuStrip2"
        Me.ContextGrdPost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextGrdPost.Size = New System.Drawing.Size(178, 70)
        '
        'contextAddPost
        '
        Me.contextAddPost.Image = CType(resources.GetObject("contextAddPost.Image"), System.Drawing.Image)
        Me.contextAddPost.Name = "contextAddPost"
        Me.contextAddPost.Size = New System.Drawing.Size(177, 22)
        Me.contextAddPost.Text = "���"
        '
        'contextDelPost
        '
        Me.contextDelPost.Image = CType(resources.GetObject("contextDelPost.Image"), System.Drawing.Image)
        Me.contextDelPost.Name = "contextDelPost"
        Me.contextDelPost.Size = New System.Drawing.Size(177, 22)
        Me.contextDelPost.Text = "���"
        '
        '����������с��ToolStripMenuItem
        '
        Me.����������с��ToolStripMenuItem.Image = CType(resources.GetObject("����������с��ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.����������с��ToolStripMenuItem.Name = "����������с��ToolStripMenuItem"
        Me.����������с��ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.����������с��ToolStripMenuItem.Text = "����� ���� �� ���"
        '
        'TrvOrganChart
        '
        Me.TrvOrganChart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TrvOrganChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TrvOrganChart.ContextMenuStrip = Me.ContextTrvChart
        Me.TrvOrganChart.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TrvOrganChart.Location = New System.Drawing.Point(4, 44)
        Me.TrvOrganChart.Name = "TrvOrganChart"
        Me.TrvOrganChart.Size = New System.Drawing.Size(425, 418)
        Me.TrvOrganChart.TabIndex = 1
        '
        'ContextTrvChart
        '
        Me.ContextTrvChart.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contextAddNode, Me.contextDelNode, Me.contextPersonInDepart, Me.contextPersEzafeInMDep})
        Me.ContextTrvChart.Name = "ContextMenuStrip1"
        Me.ContextTrvChart.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextTrvChart.Size = New System.Drawing.Size(174, 114)
        '
        'contextAddNode
        '
        Me.contextAddNode.Image = CType(resources.GetObject("contextAddNode.Image"), System.Drawing.Image)
        Me.contextAddNode.Name = "contextAddNode"
        Me.contextAddNode.Size = New System.Drawing.Size(173, 22)
        Me.contextAddNode.Text = "���"
        '
        'contextDelNode
        '
        Me.contextDelNode.Image = CType(resources.GetObject("contextDelNode.Image"), System.Drawing.Image)
        Me.contextDelNode.Name = "contextDelNode"
        Me.contextDelNode.Size = New System.Drawing.Size(173, 22)
        Me.contextDelNode.Text = "���"
        '
        'contextPersonInDepart
        '
        Me.contextPersonInDepart.Image = CType(resources.GetObject("contextPersonInDepart.Image"), System.Drawing.Image)
        Me.contextPersonInDepart.Name = "contextPersonInDepart"
        Me.contextPersonInDepart.Size = New System.Drawing.Size(173, 22)
        Me.contextPersonInDepart.Text = "����� ���� �� ����"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.���������ToolStripMenuItem, Me.��������ToolStripMenuItem, Me.����ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(861, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '���������ToolStripMenuItem
        '
        Me.���������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.���ToolStripMenuItem, Me.�������ToolStripMenuItem, Me.���������������ToolStripMenuItem})
        Me.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem"
        Me.���������ToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.���������ToolStripMenuItem.Text = "������ ����"
        '
        '���ToolStripMenuItem
        '
        Me.���ToolStripMenuItem.Image = CType(resources.GetObject("���ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.���ToolStripMenuItem.Name = "���ToolStripMenuItem"
        Me.���ToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.���ToolStripMenuItem.Text = "��� ����"
        '
        '�������ToolStripMenuItem
        '
        Me.�������ToolStripMenuItem.Image = CType(resources.GetObject("�������ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem"
        Me.�������ToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.�������ToolStripMenuItem.Text = "��� ����"
        '
        '���������������ToolStripMenuItem
        '
        Me.���������������ToolStripMenuItem.Image = CType(resources.GetObject("���������������ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.���������������ToolStripMenuItem.Name = "���������������ToolStripMenuItem"
        Me.���������������ToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.���������������ToolStripMenuItem.Text = "����� ���� �� ����"
        '
        '��������ToolStripMenuItem
        '
        Me.��������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.��́��ToolStripMenuItem, Me.��݁��ToolStripMenuItem, Me.����������с��ToolStripMenuItem1})
        Me.��������ToolStripMenuItem.Name = "��������ToolStripMenuItem"
        Me.��������ToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.��������ToolStripMenuItem.Text = "������ ���"
        '
        '��́��ToolStripMenuItem
        '
        Me.��́��ToolStripMenuItem.Image = CType(resources.GetObject("��́��ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.��́��ToolStripMenuItem.Name = "��́��ToolStripMenuItem"
        Me.��́��ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.��́��ToolStripMenuItem.Text = "��� ���"
        '
        '��݁��ToolStripMenuItem
        '
        Me.��݁��ToolStripMenuItem.Image = CType(resources.GetObject("��݁��ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.��݁��ToolStripMenuItem.Name = "��݁��ToolStripMenuItem"
        Me.��݁��ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.��݁��ToolStripMenuItem.Text = "��� ���"
        '
        '����������с��ToolStripMenuItem1
        '
        Me.����������с��ToolStripMenuItem1.Image = CType(resources.GetObject("����������с��ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.����������с��ToolStripMenuItem1.Name = "����������с��ToolStripMenuItem1"
        Me.����������с��ToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.����������с��ToolStripMenuItem1.Text = "����� ���� �� ���"
        '
        '����ToolStripMenuItem
        '
        Me.����ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.����ToolStripMenuItem1})
        Me.����ToolStripMenuItem.Name = "����ToolStripMenuItem"
        Me.����ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.����ToolStripMenuItem.Text = "����"
        '
        '����ToolStripMenuItem1
        '
        Me.����ToolStripMenuItem1.Image = CType(resources.GetObject("����ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.����ToolStripMenuItem1.Name = "����ToolStripMenuItem1"
        Me.����ToolStripMenuItem1.Size = New System.Drawing.Size(98, 22)
        Me.����ToolStripMenuItem1.Text = "����"
        '
        'contextPersEzafeInMDep
        '
        Me.contextPersEzafeInMDep.Name = "contextPersEzafeInMDep"
        Me.contextPersEzafeInMDep.Size = New System.Drawing.Size(173, 22)
        Me.contextPersEzafeInMDep.Text = "����� ����� ����"
        '
        'frmPRSMainChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 455)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPRSMainChart"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "���� �������"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextGrdPost.ResumeLayout(False)
        Me.ContextTrvChart.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents TrvOrganChart As System.Windows.Forms.TreeView
    Friend WithEvents ContextTrvChart As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents contextAddNode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contextDelNode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GrdPost As Janus.Windows.GridEX.GridEX
    Friend WithEvents ContextGrdPost As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents contextDelPost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents contextAddPost As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ���������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��́��ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ��݁��ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDepName As System.Windows.Forms.Label
    Friend WithEvents contextPersonInDepart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������с��ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ����������с��ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JGrade1 As JFrameWork.jGrade
    Friend WithEvents contextPersEzafeInMDep As System.Windows.Forms.ToolStripMenuItem

End Class
