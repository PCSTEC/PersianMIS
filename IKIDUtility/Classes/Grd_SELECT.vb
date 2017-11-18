Public Class Grd_SELECT
    Dim dg As New System.Windows.Forms.DataGrid
    Dim drow As DataRow
    Dim i, j, SelColNum As Integer

    Public Function get_Collection_String(ByVal dg As System.Windows.Forms.DataGrid, ByVal ColToCollect As Integer, ByVal dt As DataTable, ByVal SelColNumP As Integer) As String
        Dim x As String = "("
        Dim i As Integer
        On Error Resume Next
        For i = 0 To dt.DefaultView.Count - 1
            If dg.Item(i, SelColNumP) = True Then
                x = x & "'" & dg.Item(i, ColToCollect) & "',"
            End If
        Next i
        x = x & " '')"

        get_Collection_String = x
    End Function
    Public Function Add_ColDt(ByRef dts As DataTable)
        dts.Columns.Add("sel", System.Type.GetType("System.Boolean"))
        For i = 0 To dts.DefaultView.Count - 1

            dts.DefaultView.Item(i).Item("sel") = 0
        Next
        SelColNum = dts.Columns.Count - 1
    End Function
    Public Sub Grid_State(ByRef DG As System.Windows.Forms.DataGrid)

        If IsDBNull(DG.Item(DG.CurrentCell.RowNumber, SelColNum)) Then
            DG.Item(DG.CurrentCell.RowNumber, SelColNum) = False
            Exit Sub
        End If
        If DG.Item(DG.CurrentCell.RowNumber, SelColNum) Then
            DG.Item(DG.CurrentCell.RowNumber, SelColNum) = False
        Else
            DG.Item(DG.CurrentCell.RowNumber, SelColNum) = True
        End If
    End Sub
    Public Sub Grid_State(ByRef DG As System.Windows.Forms.DataGrid, ByVal ColNo As Integer)

        If IsDBNull(DG.Item(DG.CurrentCell.RowNumber, ColNo)) Then
            DG.Item(DG.CurrentCell.RowNumber, ColNo) = False
            Exit Sub
        End If
        If DG.Item(DG.CurrentCell.RowNumber, ColNo) Then
            DG.Item(DG.CurrentCell.RowNumber, ColNo) = False
        Else
            DG.Item(DG.CurrentCell.RowNumber, ColNo) = True
        End If
    End Sub
End Class