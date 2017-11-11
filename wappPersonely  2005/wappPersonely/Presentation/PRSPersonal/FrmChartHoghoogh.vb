Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting.Utilities
Public Class FrmChartHoghoogh


    Private Sub FrmChartHoghoogh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt1 As New DataTable
        Dim cnn As String
        '''cnn = "Provider=SQLOLEDB;packet size=4096;integrated security=SSPI; Data Source=SQLSRV;Initial Catalog=Personely;Integrated Security=True;Connect Timeout=200 "

        cnn = "Provider=SQLOLEDB;packet size=4096;integrated security=SSPI;data source=SQLSRV;persist security info=False;initial catalog=Personely"

        SqlStr = "SELECT * FROM test"
        'dt1 = Persist1.GetDataTable(ConString, SqlStr)
        Dim myConnection As New OleDbConnection

        myConnection.ConnectionString = cnn
        Dim myCommand As New OleDbCommand(SqlStr, myConnection)
        myCommand.Connection.Open()
        Dim myReader As OleDbDataReader

        myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

        Chart1.DataBindCrossTable(myReader, "FirstName", "BirthDate", "BirthDate", "Label=BirthDate")

        myConnection.Open()



        'Chart1.DataSource = ConString
        'janus1.GetBindJGrid_DT(dt1, Chart1, ConString)
        '    Chart1.DataBindTable(myReader, "DepartName")
       





    End Sub
End Class