Public Class UserCommunication
    Public Enum QuestionResault As Short
        Delete = 1
        Update = 2
    End Enum
    Public Sub Message(ByVal txt As String)
        MsgBox(txt, MsgBoxStyle.OKOnly, "IKID Systems")
    End Sub

    Public Function Question(ByVal QSTParam As QuestionResault) As MsgBoxResult
        Select Case QSTParam
            Case QuestionResault.Delete
                ' Return MsgBox("����� ���� ��� ��� ����� ��.��� ����� ����Ͽ", MsgBoxStyle.YesNo, "IKID Systems")
            Case QuestionResault.Update
                ' Return MsgBox("����� ���� ��� ������ ����� ��.��� ����� ����Ͽ", MsgBoxStyle.YesNo, "IKID Systems")
        End Select
    End Function
End Class
