Public Class FrmChart

    Dim Modir, Raees, Karshenas, Saier As Long
    Dim CountMOdi, countRaees, countKarshenas, Countsaier As Integer




    Private Sub FrmChart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fillchart()

    End Sub

    Public Sub fillchart()
        Modir = 0
        Raees = 0
        Karshenas = 0
        Saier = 0
        chart1.Titles("Title1").Text = "نمودار حقوق کارکنان "

        ' پیدا کردن مقدار حقوق مدیران
        SqlStr = _
"SELECT     EmployeeID, EmployeeCode, PersonID, PersonCode, FirstName, LastName, FatherName, BirthDate, NationalCode, IDNum, Citytxt, MilitaryStateName,  " & _
"                      Posttxt, EngageType, Describtion, JobTitletxt, PostCode, UnderTestFee, GroupFee, GradeFee, HouseFee, MarriageFee, GroupID, SoldierFee, FoodFee,  " & _
"                      OverJazb, OverPost, Sanavat, Differ, Barjeste, Salary, EngageDate, BeginDate, EmissionDate, ExecDate, MoavagheDate, EndDate, DayAmountFee,  " & _
"                      EmployeeActive, EmployeeType, EmployeeTypeID, EngageTypeID, EmployTypeID, TimeAmountFee, MaxTime, MaxKarkard, GradeCount, BranchCode,  " & _
"                      MariageType, PersonChildQty, DiplomaName, DepartName, PostType, name " & _
"FROM         dbo.Wv_rpt_hoghoogh " & _
"WHERE     (PostType = N'مدير عامل') OR " & _
"                      (PostType = N'عضو هيئت مديره/قائم مقام') OR " & _
"                      (PostType = N'مدير/رئيس مستقل') OR " & _
"                      (PostType = N'جانشين مدير/رئيس مستقل') OR " & _
"                      (PostType = N'مدير پروژه') OR " & _
"                      (PostType = N'جانشين مدير پروژه')"

        DtGeneral = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(DtGeneral, VirtualGrid, ConString)

        janus1.setMyJGrid(VirtualGrid, "Salary", "Salary", 65)
        janus1.setMyJGrid(VirtualGrid, "Barjeste", "Barjeste", 65)
        janus1.setMyJGrid(VirtualGrid, "Differ", "Differ", 65)
        janus1.setMyJGrid(VirtualGrid, "Sanavat", "Sanavat", 65)
        janus1.setMyJGrid(VirtualGrid, "OverPost", "OverPost", 65)
        janus1.setMyJGrid(VirtualGrid, "OverJazb", "OverJazb", 65)
        janus1.setMyJGrid(VirtualGrid, "FoodFee", "FoodFee", 65)
        janus1.setMyJGrid(VirtualGrid, "SoldierFee", "SoldierFee", 65)
        janus1.setMyJGrid(VirtualGrid, "MarriageFee", "MarriageFee", 65)
        janus1.setMyJGrid(VirtualGrid, "HouseFee", "HouseFee", 65)
        janus1.setMyJGrid(VirtualGrid, "GradeFee", "GradeFee", 65)
        janus1.setMyJGrid(VirtualGrid, "GroupFee", "GroupFee", 65)
        janus1.setMyJGrid(VirtualGrid, "UnderTestFee", "UnderTestFee", 65)
        LblMOdir.Text = "تعداد مدیر:" & VirtualGrid.RowCount

        For i = 0 To VirtualGrid.RowCount - 1
            VirtualGrid.Row = i
            Modir = Modir + VirtualGrid.GetValue("Barjeste") + VirtualGrid.GetValue("Differ") + VirtualGrid.GetValue("Sanavat") + VirtualGrid.GetValue("OverPost") + VirtualGrid.GetValue("OverJazb") + VirtualGrid.GetValue("FoodFee") + VirtualGrid.GetValue("SoldierFee") + VirtualGrid.GetValue("MarriageFee") + VirtualGrid.GetValue("HouseFee") + VirtualGrid.GetValue("GradeFee") + VirtualGrid.GetValue("GroupFee") + VirtualGrid.GetValue("UnderTestFee")
        Next
        '---------------------------------------------  end  peida kardan hoghoogh modiran ----------------------------


        ' --------------------------------------------- hoghoogh Raeesan ----------------------------------------
        SqlStr = _
"SELECT     EmployeeID, EmployeeCode, PersonID, PersonCode, FirstName, LastName, FatherName, BirthDate, NationalCode, IDNum, Citytxt, MilitaryStateName,  " & _
"                      Posttxt, EngageType, Describtion, JobTitletxt, PostCode, UnderTestFee, GroupFee, GradeFee, HouseFee, MarriageFee, GroupID, SoldierFee, FoodFee,  " & _
"                      OverJazb, OverPost, Sanavat, Differ, Barjeste, Salary, EngageDate, BeginDate, EmissionDate, ExecDate, MoavagheDate, EndDate, DayAmountFee,  " & _
"                      EmployeeActive, EmployeeType, EmployeeTypeID, EngageTypeID, EmployTypeID, TimeAmountFee, MaxTime, MaxKarkard, GradeCount, BranchCode,  " & _
"                      MariageType, PersonChildQty, DiplomaName, DepartName, PostType, name " & _
"FROM         dbo.Wv_rpt_hoghoogh " & _
"WHERE     (PostType = N'رئيس/مسئول بلافصل') OR " & _
"                      (PostType = N'جانشين رييس')"

        DtGeneral = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(DtGeneral, VirtualGrid, ConString)

        janus1.setMyJGrid(VirtualGrid, "Salary", "Salary", 65)
        janus1.setMyJGrid(VirtualGrid, "Barjeste", "Barjeste", 65)
        janus1.setMyJGrid(VirtualGrid, "Differ", "Differ", 65)
        janus1.setMyJGrid(VirtualGrid, "Sanavat", "Sanavat", 65)
        janus1.setMyJGrid(VirtualGrid, "OverPost", "OverPost", 65)
        janus1.setMyJGrid(VirtualGrid, "OverJazb", "OverJazb", 65)
        janus1.setMyJGrid(VirtualGrid, "FoodFee", "FoodFee", 65)
        janus1.setMyJGrid(VirtualGrid, "SoldierFee", "SoldierFee", 65)
        janus1.setMyJGrid(VirtualGrid, "MarriageFee", "MarriageFee", 65)
        janus1.setMyJGrid(VirtualGrid, "HouseFee", "HouseFee", 65)
        janus1.setMyJGrid(VirtualGrid, "GradeFee", "GradeFee", 65)
        janus1.setMyJGrid(VirtualGrid, "GroupFee", "GroupFee", 65)
        janus1.setMyJGrid(VirtualGrid, "UnderTestFee", "UnderTestFee", 65)
        LblRaees.Text = "تعداد رئیس:" & VirtualGrid.RowCount
        For i = 0 To VirtualGrid.RowCount - 1
            VirtualGrid.Row = i
            Raees = Raees + VirtualGrid.GetValue("Barjeste") + VirtualGrid.GetValue("Differ") + VirtualGrid.GetValue("Sanavat") + VirtualGrid.GetValue("OverPost") + VirtualGrid.GetValue("OverJazb") + VirtualGrid.GetValue("FoodFee") + VirtualGrid.GetValue("SoldierFee") + VirtualGrid.GetValue("MarriageFee") + VirtualGrid.GetValue("HouseFee") + VirtualGrid.GetValue("GradeFee") + VirtualGrid.GetValue("GroupFee") + VirtualGrid.GetValue("UnderTestFee")
        Next
        ' ----------------------------------------------- End Of Salary Raees -----------------------

        '------------------------------------------------- mohasebe hoghoogh Karshenasan ------------------

        SqlStr = _
        "SELECT     EmployeeID, EmployeeCode, PersonID, PersonCode, FirstName, LastName, FatherName, BirthDate, NationalCode, IDNum, Citytxt, MilitaryStateName,  " & _
        "                      Posttxt, EngageType, Describtion, JobTitletxt, PostCode, UnderTestFee, GroupFee, GradeFee, HouseFee, MarriageFee, GroupID, SoldierFee, FoodFee,  " & _
        "                      OverJazb, OverPost, Sanavat, Differ, Barjeste, Salary, EngageDate, BeginDate, EmissionDate, ExecDate, MoavagheDate, EndDate, DayAmountFee,  " & _
        "                      EmployeeActive, EmployeeType, EmployeeTypeID, EngageTypeID, EmployTypeID, TimeAmountFee, MaxTime, MaxKarkard, GradeCount, BranchCode,  " & _
        "                      MariageType, PersonChildQty, DiplomaName, DepartName, PostType, name " & _
        "FROM         dbo.Wv_rpt_hoghoogh " & _
        "WHERE     (PostType = N'كارشناس')"
        DtGeneral = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(DtGeneral, VirtualGrid, ConString)

        janus1.setMyJGrid(VirtualGrid, "Salary", "Salary", 65)
        janus1.setMyJGrid(VirtualGrid, "Barjeste", "Barjeste", 65)
        janus1.setMyJGrid(VirtualGrid, "Differ", "Differ", 65)
        janus1.setMyJGrid(VirtualGrid, "Sanavat", "Sanavat", 65)
        janus1.setMyJGrid(VirtualGrid, "OverPost", "OverPost", 65)
        janus1.setMyJGrid(VirtualGrid, "OverJazb", "OverJazb", 65)
        janus1.setMyJGrid(VirtualGrid, "FoodFee", "FoodFee", 65)
        janus1.setMyJGrid(VirtualGrid, "SoldierFee", "SoldierFee", 65)
        janus1.setMyJGrid(VirtualGrid, "MarriageFee", "MarriageFee", 65)
        janus1.setMyJGrid(VirtualGrid, "HouseFee", "HouseFee", 65)
        janus1.setMyJGrid(VirtualGrid, "GradeFee", "GradeFee", 65)
        janus1.setMyJGrid(VirtualGrid, "GroupFee", "GroupFee", 65)
        janus1.setMyJGrid(VirtualGrid, "UnderTestFee", "UnderTestFee", 65)
        LblKarshenas.Text = "تعداد کارشناس:" & VirtualGrid.RowCount
        For i = 0 To VirtualGrid.RowCount - 1
            VirtualGrid.Row = i
            Karshenas = Karshenas + VirtualGrid.GetValue("Barjeste") + VirtualGrid.GetValue("Differ") + VirtualGrid.GetValue("Sanavat") + VirtualGrid.GetValue("OverPost") + VirtualGrid.GetValue("OverJazb") + VirtualGrid.GetValue("FoodFee") + VirtualGrid.GetValue("SoldierFee") + VirtualGrid.GetValue("MarriageFee") + VirtualGrid.GetValue("HouseFee") + VirtualGrid.GetValue("GradeFee") + VirtualGrid.GetValue("GroupFee") + VirtualGrid.GetValue("UnderTestFee")
        Next
        ' ------------------------------------ End Of karshenas salary ----------------------------------------
        SqlStr = _
  "SELECT     EmployeeID, EmployeeCode, PersonID, PersonCode, FirstName, LastName, FatherName, BirthDate, NationalCode, IDNum, Citytxt, MilitaryStateName,  " & _
  "                      Posttxt, EngageType, Describtion, JobTitletxt, PostCode, UnderTestFee, GroupFee, GradeFee, HouseFee, MarriageFee, GroupID, SoldierFee, FoodFee,  " & _
  "                      OverJazb, OverPost, Sanavat, Differ, Barjeste, Salary, EngageDate, BeginDate, EmissionDate, ExecDate, MoavagheDate, EndDate, DayAmountFee,  " & _
  "                      EmployeeActive, EmployeeType, EmployeeTypeID, EngageTypeID, EmployTypeID, TimeAmountFee, MaxTime, MaxKarkard, GradeCount, BranchCode,  " & _
  "                      MariageType, PersonChildQty, DiplomaName, DepartName, PostType, name " & _
  "FROM         dbo.Wv_rpt_hoghoogh " & _
  "WHERE     (NOT (PostType IN (N'عضو هيئت مديره/قائم مقام', N'مدير/رئيس مستقل', N'جانشين مدير/رئيس مستقل', N'مدير پروژه', N'جانشين مدير پروژه', N'رئيس/مسئول بلافصل',  " & _
  "                      N'جانشين رييس', N'كارشناس')))"

        DtGeneral = Persist1.GetDataTable(ConString, SqlStr)
        janus1.GetBindJGrid_DT(DtGeneral, VirtualGrid, ConString)

        janus1.setMyJGrid(VirtualGrid, "Salary", "Salary", 65)
        janus1.setMyJGrid(VirtualGrid, "Barjeste", "Barjeste", 65)
        janus1.setMyJGrid(VirtualGrid, "Differ", "Differ", 65)
        janus1.setMyJGrid(VirtualGrid, "Sanavat", "Sanavat", 65)
        janus1.setMyJGrid(VirtualGrid, "OverPost", "OverPost", 65)
        janus1.setMyJGrid(VirtualGrid, "OverJazb", "OverJazb", 65)
        janus1.setMyJGrid(VirtualGrid, "FoodFee", "FoodFee", 65)
        janus1.setMyJGrid(VirtualGrid, "SoldierFee", "SoldierFee", 65)
        janus1.setMyJGrid(VirtualGrid, "MarriageFee", "MarriageFee", 65)
        janus1.setMyJGrid(VirtualGrid, "HouseFee", "HouseFee", 65)
        janus1.setMyJGrid(VirtualGrid, "GradeFee", "GradeFee", 65)
        janus1.setMyJGrid(VirtualGrid, "GroupFee", "GroupFee", 65)
        janus1.setMyJGrid(VirtualGrid, "UnderTestFee", "UnderTestFee", 65)
        LblSaier.Text = "سایر:" & VirtualGrid.RowCount
        For i = 0 To VirtualGrid.RowCount - 1
            VirtualGrid.Row = i
            Saier = Saier + VirtualGrid.GetValue("Barjeste") + VirtualGrid.GetValue("Differ") + VirtualGrid.GetValue("Sanavat") + VirtualGrid.GetValue("OverPost") + VirtualGrid.GetValue("OverJazb") + VirtualGrid.GetValue("FoodFee") + VirtualGrid.GetValue("SoldierFee") + VirtualGrid.GetValue("MarriageFee") + VirtualGrid.GetValue("HouseFee") + VirtualGrid.GetValue("GradeFee") + VirtualGrid.GetValue("GroupFee") + VirtualGrid.GetValue("UnderTestFee")
        Next

        ' ------------------------------------- end of saier
        Dim yValues As Double() = {Modir, Raees, Karshenas, Saier}
        Dim xValues As String() = {"مدیر ", "رئیس", "کارشناس", "سایر"}
        chart1.Series(0).Points.DataBindXY(xValues, yValues)
        ' نمایش اطلاعات هدف شاخص در سال های مختلف 
       


    End Sub
End Class