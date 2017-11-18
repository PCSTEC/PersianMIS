Public Class DgSelect
    Inherits System.Windows.Forms.UserControl
    Dim i As Integer
    Public Event WlEvent(ByVal sender As Object, ByVal e As MyEventArgs)
    Public DG As System.Windows.Forms.DataGrid
    Public DT As DataTable
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnAll As System.Windows.Forms.Button
    Friend WithEvents btnNone As System.Windows.Forms.Button
    Friend WithEvents btnInv As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnAll = New System.Windows.Forms.Button
        Me.btnNone = New System.Windows.Forms.Button
        Me.btnInv = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnAll
        '
        Me.btnAll.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAll.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnAll.Location = New System.Drawing.Point(96, 0)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(40, 22)
        Me.btnAll.TabIndex = 5
        Me.btnAll.Text = "Â„Â"
        '
        'btnNone
        '
        Me.btnNone.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNone.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnNone.Location = New System.Drawing.Point(48, 0)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(48, 22)
        Me.btnNone.TabIndex = 4
        Me.btnNone.Text = "ÂÌçﬂœ«„"
        '
        'btnInv
        '
        Me.btnInv.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInv.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnInv.Location = New System.Drawing.Point(1, 0)
        Me.btnInv.Name = "btnInv"
        Me.btnInv.Size = New System.Drawing.Size(47, 22)
        Me.btnInv.TabIndex = 3
        Me.btnInv.Text = "„⁄ﬂÊ”"
        '
        'DgSelect
        '
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnNone)
        Me.Controls.Add(Me.btnInv)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "DgSelect"
        Me.Size = New System.Drawing.Size(136, 22)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        If DG.TableStyles(DG.TableStyles(0).MappingName).GridColumnStyles(DG.CurrentCell.ColumnNumber).GetType.FullName = "System.Windows.Forms.DataGridBoolColumn" Then
            For i = 0 To DT.DefaultView.Count - 1
                DG.Item(i, DG.CurrentCell.ColumnNumber) = True
            Next
        Else
            MsgBox("ŒÊ«Â‘„‰œ «”  ” Ê‰ ’ÕÌÕ —« ê“Ì‰‘ ›—„«ÌÌœ", MsgBoxStyle.OKOnly)
        End If

        Dim o As Object
        Dim e1 As New MyEventArgs
        e1.sendername = "SelectALL"
        RaiseEvent WlEvent(o, e1)
    End Sub

    Private Sub btnInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInv.Click
        Dim n As New IKIDUtility.Formating
        If DG.TableStyles(DG.TableStyles(0).MappingName).GridColumnStyles(DG.CurrentCell.ColumnNumber).GetType.FullName = "System.Windows.Forms.DataGridBoolColumn" Then
            For i = 0 To DT.DefaultView.Count - 1
                DG.Item(i, DG.CurrentCell.ColumnNumber) = Not n.NZ(DG.Item(i, DG.CurrentCell.ColumnNumber), False)
            Next
        Else
            MsgBox("ŒÊ«Â‘„‰œ «”  ” Ê‰ ’ÕÌÕ —« ê“Ì‰‘ ›—„«ÌÌœ", MsgBoxStyle.OKOnly)
        End If

        Dim o As Object
        Dim e1 As New MyEventArgs
        e1.sendername = "SelectALL"
        RaiseEvent WlEvent(o, e1)
    End Sub

    Private Sub btnNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNone.Click
        If DG.TableStyles(DG.TableStyles(0).MappingName).GridColumnStyles(DG.CurrentCell.ColumnNumber).GetType.FullName = "System.Windows.Forms.DataGridBoolColumn" Then
            For i = 0 To DT.DefaultView.Count - 1
                DG.Item(i, DG.CurrentCell.ColumnNumber) = False
            Next
        Else
            MsgBox("ŒÊ«Â‘„‰œ «”  ” Ê‰ ’ÕÌÕ —« ê“Ì‰‘ ›—„«ÌÌœ", MsgBoxStyle.OKOnly)
        End If

        Dim o As Object
        Dim e1 As New MyEventArgs
        e1.sendername = "SelectALL"
        RaiseEvent WlEvent(o, e1)
    End Sub
    Public Class MyEventArgs
        Inherits EventArgs
        Dim MYsender As String

        Public Property sendername()
            Get
                sendername = MYsender
            End Get
            Set(ByVal Value)
                MYsender = Value
            End Set
        End Property
    End Class
End Class
