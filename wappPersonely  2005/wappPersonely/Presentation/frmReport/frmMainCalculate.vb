Imports System.IO

Public Class frmMainCalculate
    Dim FloatStartDate As Double
    Dim FloatEndDate As Double
    Dim Cnnstring_mali As String = "Persist Security Info=False;User ID=sa;PWD=afarinesh;Connect Timeout=100;Initial Catalog=PwKara ;Data Source=SQLSRVMALI"
    Dim Janus2, Janus3 As New JFrameWork.JanusGrid
    Dim dt_Person, dt_Post As New DataTable
    Public ReqNum As Integer



    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim sec As New IKIDSecurity.Information.LoginInfo
        '   Dim MDepart1 As New MDepart
        Dim dt As New DataTable
        Dim CurDate As String
        Dim dt_pr As New DataTable
        Dim Grade As Decimal
        Dim sum As Integer
        Dim UPGrade As Integer
        Dim dif As Integer
        Dim GradeZarib As Decimal
        Dim Fee As Decimal
        Dim dt_Fee As New DataTable
        Dim Percent2 As Integer
        '   Dim Percent1 As New Percent
        '  Dim personList As New Person
        Dim j As Integer
        Dim p1 As New Persistent.DataAccess.DataAccess
        Dim PostID_tmp As Integer
        Dim Cnt As Integer
        Dim Cnt_20_Year As Integer
        Dim dt_20 As New DataTable


        MainEndDate = IraniDate1.GetIrani8DateStr_CurDate


        ProgressBar1.Visible = True


        SqlStr = _
             "SELECT     tbHR_Person.PersonCode, tbHR_Person.LastName + ' ' + tbHR_Person.FirstName AS prName, tbHR_Person.FirstName, tbHR_Person.LastName,  " & _
             "                      tbHR_Employee.Active, tbHR_Post.PostTypeCode, tbHR_Post.DepartCode, tbHR_Person.EngageDate, tbHR_Post.PostTypeID,  " & _
             "                      tbHR_Employee.EngageTypeID, tbHR_Employee.MaxKarkard, tbHR_Card.CardNumber, tbHR_Depart.DepartName,  " & _
             "                      tbHR_Depart_1.DepartName AS MDepartName, tbHR_Person.PersonKeyOnPost, tbHR_Post.Posttxt, tbHR_EngageType.EngageType " & _
             "FROM         tbHR_Person INNER JOIN " & _
             "                      tbHR_Employee ON tbHR_Person.PersonID = tbHR_Employee.PersonID INNER JOIN " & _
             "                      tbHR_Post ON tbHR_Employee.PostID = tbHR_Post.PostID INNER JOIN " & _
             "                      tbHR_Card ON tbHR_Person.PersonCode = tbHR_Card.PersonCode INNER JOIN " & _
             "                      tbHR_Depart ON tbHR_Post.DepartCode = tbHR_Depart.DepartCode INNER JOIN " & _
             "                      tbHR_Depart AS tbHR_Depart_1 ON tbHR_Depart.MDepartCode = tbHR_Depart_1.DepartCode INNER JOIN " & _
             "                      tbARZ_Engage ON tbHR_Employee.EngageTypeID = tbARZ_Engage.EngageTypeID INNER JOIN " & _
             "                      tbHR_EngageType ON tbHR_Employee.EngageTypeID = tbHR_EngageType.EngageTypeID " & _
             " WHERE (tbHR_Employee.Active = 1)  "

        dt_pr = Persist1.GetDataTable(ConString, SqlStr)


        ProgressBar1.Maximum = dt_pr.DefaultView.Count


        sqlstr = "Delete tbTAB_TabghaeMashaghel"

        p1.GetDataAccess(SqlStr, 2, ConString)


        For i = 0 To dt_pr.DefaultView.Count - 1
            sum = 0
            ProgressBar1.Value = i

            'sqlstr = _
            '       " SELECT     Func_PersonOnPost_List_1.PersonCode, Func_PersonOnPost_List_1.ExecDate, Func_PersonOnPost_List_1.PostID,   GeneralObjects.dbo.FunGen_Def2ShamsiSDateN(Func_PersonOnPost_List_1.ExecDate, ISNULL " & _
            '       "       ((SELECT     TOP (1) PERCENT ExecDate  FROM          tbHR_Employee      WHERE      (PersonCode = Func_PersonOnPost_List_1.PersonCode) AND (ExecDate > Func_PersonOnPost_List_1.ExecDate) AND    (ExecDate < '1394/01/01')  " & _
            '       "           ORDER BY ExecDate), '1394/04/07')) AS cnt, tbHR_Post.Posttxt " & _
            '       " FROM         dbo.Func_PersonOnPost_List('1111/11/11', 720007) AS Func_PersonOnPost_List_1 INNER JOIN " & _
            '       "   tbHR_Person ON Func_PersonOnPost_List_1.PersonCode = tbHR_Person.PersonCode INNER JOIN " & _
            '       "   tbHR_Post ON Func_PersonOnPost_List_1.PostID = tbHR_Post.PostID " & _
            '       " WHERE     (Func_PersonOnPost_List_1.ExecDate <= '1394/04/07') "



            SqlStr = _
                    "SELECT     Func_PersonOnPost_List_1.PersonCode, Func_PersonOnPost_List_1.EmissionDate, Func_PersonOnPost_List_1.PostID, " & _
                    "                      GeneralObjects.dbo.FunGen_Def2ShamsiSDateN(Func_PersonOnPost_List_1.EmissionDate, ISNULL " & _
                    "                          ((SELECT     TOP (1) PERCENT EmissionDate " & _
                    "                              FROM          dbo.tbHR_Employee " & _
                    "                              WHERE      (PersonCode = Func_PersonOnPost_List_1.PersonCode) AND (EmissionDate > Func_PersonOnPost_List_1.EmissionDate) AND (EmissionDate < '" & MainEndDate & "') " & _
                    "                              ORDER BY EmissionDate), '" & MainEndDate & "')) AS cnt " & _
                    "FROM         dbo.Func_PersonOnPost_List( '1111/11/11',  " & dt_pr.DefaultView.Item(i).Item("PersonCode") & ") AS Func_PersonOnPost_List_1 INNER JOIN " & _
                    "                      dbo.tbHR_Person ON Func_PersonOnPost_List_1.PersonCode = dbo.tbHR_Person.PersonCode " & _
                    " WHERE     (Func_PersonOnPost_List_1.EmissionDate <= '" & MainEndDate & "') "


            dt = Persist1.GetDataTable(ConString, SqlStr)


            For j = 0 To dt.DefaultView.Count - 1


                SqlStr = "INSERT INTO [Personely].[dbo].[tbTAB_TabghaeMashaghel] ([PersonCode],[ExecDate] ,[PostID] ,[Cnt],[Cnt20Year]) VALUES (" & dt_pr.DefaultView.Item(i).Item("PersonCode") & ",'" & dt.DefaultView.Item(j).Item("EmissionDate") & "'," & dt.DefaultView.Item(j).Item("PostID") & "," & dt.DefaultView.Item(j).Item("cnt") & "," & Cnt_20_Year & ")"
                p1.GetDataAccess(SqlStr, 2, ConString)

            Next

            SqlStr = "SELECT     SUM(Cnt20Year) AS Expr1, PostID fROM         dbo.tbTAB_TabghaeMashaghel WHERE     (PersonCode = " & dt_pr.DefaultView.Item(i).Item("PersonCode") & ") GROUP BY PostID HAVING      (SUM(Cnt20Year) > 20*365)"

            dt_20 = p1.GetDataTable(ConString, SqlStr)
            If dt_20.DefaultView.Count = 0 Then
                SqlStr = "Update [Personely].[dbo].[tbTAB_TabghaeMashaghel] Set Cnt20Year=0 Where PersonCode=" & dt_pr.DefaultView.Item(i).Item("PersonCode")
                p1.GetDataAccess(SqlStr, 2, ConString)
            End If

        Next

        ProgressBar1.Visible = False

        MsgBox("محاسبه تمام شد")

        Me.Close()


    End Sub

    Private Sub frmMainCalculate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        sqlstr = "SELECT    ParameterID, ParameterTxt, ParmeterGrade, ParameterTypeID  FROM tbARZ_Parameter  WHERE(ParameterTypeID = 4)"
        dt = Persist1.GetDataTable(ConString, SqlStr)
 
    End Sub
  
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frmReportSakhti
        frm.ReqNum = ReqNum
        frm.ShowDialog()
    End Sub
End Class