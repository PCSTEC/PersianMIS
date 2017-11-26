Public Class Frm_ShowCalander
    Private SelectedDate As String

    Public IsAlarm As Boolean
    Private Sub BubbleButton9_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton9.Click

        Me.Close()
    End Sub



    Private Sub fillcmb()

        SqlStr = "select * from tbRCL_CalendarYearIrani"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Pers.FillCmb(Dt, Cmb_Year, "IraniYearID", "IraniYearID")



        SqlStr = "select * from tbRCL_CalendarMonthIrani where IraniMonthID>0"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
        Pers.FillCmb(Dt, Cmb_Month, "IraniMonthID", "IraniMonthName")


    End Sub

    Private Sub Frm_Reminder_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        ' Cmb_Month.SelectedValue = irdate.GetIraniMonthNum_CurDate
        '   disableBtnCheck()
        ' Call createCalander()
    End Sub

    Private Sub Frm_Reminder_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsAlarm = True Then
            TopPnl.Text = "نرم افزار یادآور"
        Else
            TopPnl.Text = "تقویم کاری شرکت"

        End If
        fillcmb()
    End Sub

    Private Sub disableBtnCheck()
        Btn_1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground

        Btn_2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_9.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_10.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_11.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_14.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_15.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_16.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_17.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_18.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_19.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_20.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_21.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_22.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_23.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_24.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_26.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_27.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_28.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_29.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_30.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_31.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_32.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_33.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_34.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_35.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_36.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_37.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_38.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_39.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_40.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_41.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Btn_42.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground




        Btn_1.Checked = False
        Btn_2.Checked = False
        Btn_3.Checked = False
        Btn_4.Checked = False
        Btn_5.Checked = False
        Btn_6.Checked = False
        Btn_7.Checked = False
        Btn_8.Checked = False
        Btn_9.Checked = False
        Btn_10.Checked = False
        Btn_11.Checked = False
        Btn_12.Checked = False
        Btn_13.Checked = False
        Btn_14.Checked = False
        Btn_15.Checked = False
        Btn_16.Checked = False
        Btn_17.Checked = False
        Btn_18.Checked = False
        Btn_19.Checked = False
        Btn_20.Checked = False
        Btn_21.Checked = False
        Btn_22.Checked = False
        Btn_23.Checked = False
        Btn_24.Checked = False
        Btn_25.Checked = False
        Btn_26.Checked = False
        Btn_27.Checked = False
        Btn_28.Checked = False
        Btn_29.Checked = False
        Btn_30.Checked = False
        Btn_31.Checked = False
        Btn_32.Checked = False
        Btn_33.Checked = False
        Btn_34.Checked = False
        Btn_35.Checked = False
        Btn_36.Checked = False
        Btn_37.Checked = False
        Btn_38.Checked = False
        Btn_39.Checked = False
        Btn_40.Checked = False
        Btn_41.Checked = False
        Btn_42.Checked = False




        Btn_1.Text = ""
        Btn_2.Text = ""
        Btn_3.Text = ""
        Btn_4.Text = ""
        Btn_5.Text = ""
        Btn_6.Text = ""
        Btn_7.Text = ""
        Btn_8.Text = ""
        Btn_9.Text = ""
        Btn_10.Text = ""
        Btn_11.Text = ""
        Btn_12.Text = ""
        Btn_13.Text = ""
        Btn_14.Text = ""
        Btn_15.Text = ""
        Btn_16.Text = ""
        Btn_17.Text = ""
        Btn_18.Text = ""
        Btn_19.Text = ""
        Btn_20.Text = ""
        Btn_21.Text = ""
        Btn_22.Text = ""
        Btn_23.Text = ""
        Btn_24.Text = ""
        Btn_25.Text = ""
        Btn_26.Text = ""
        Btn_27.Text = ""
        Btn_28.Text = ""
        Btn_29.Text = ""
        Btn_30.Text = ""
        Btn_31.Text = ""
        Btn_32.Text = ""
        Btn_33.Text = ""
        Btn_34.Text = ""
        Btn_35.Text = ""
        Btn_36.Text = ""
        Btn_37.Text = ""
        Btn_38.Text = ""
        Btn_39.Text = ""
        Btn_40.Text = ""
        Btn_41.Text = ""
        Btn_42.Text = ""



    End Sub
    Private Sub createCalander()
        Try


            disableBtnCheck()
            SqlStr = "select * from Vw_Taghvim where CalIraniMonthID='" & Cmb_Month.SelectedValue & "' and CalIraniYearID='" & Cmb_Year.Text & "' order by CalIraniDayNum "
            Dt = Pers.GetDataTable(strConnection, SqlStr)
            Dim Day, firstBtn As String

            If Utility.NZ(Dt.Rows(0).Item("CalWeekID").ToString, "") = "1" Then
                Btn_1.Text = Utility.NZ(Dt.Rows(0).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 2 Then

                    Btn_1.Checked = True

                End If
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 3 Then
                    Btn_1.Checked = True
                    Btn_1.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_2.Text = Utility.NZ(Dt.Rows(1).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(1).Item("CalDayStatusID").ToString = 2 Then

                    Btn_2.Checked = True

                End If
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 3 Then
                    Btn_2.Checked = True
                    Btn_2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If


                Btn_3.Text = Utility.NZ(Dt.Rows(2).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 2 Then

                    Btn_3.Checked = True

                End If
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 3 Then
                    Btn_3.Checked = True
                    Btn_3.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_4.Text = Utility.NZ(Dt.Rows(3).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 2 Then

                    Btn_4.Checked = True

                End If
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 3 Then
                    Btn_4.Checked = True
                    Btn_4.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_5.Text = Utility.NZ(Dt.Rows(4).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 2 Then

                    Btn_5.Checked = True

                End If
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 3 Then
                    Btn_5.Checked = True
                    Btn_5.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_6.Text = Utility.NZ(Dt.Rows(5).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 2 Then

                    Btn_6.Checked = True

                End If
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 3 Then
                    Btn_6.Checked = True
                    Btn_6.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_7.Text = Utility.NZ(Dt.Rows(6).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 2 Then

                    Btn_7.Checked = True

                End If
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 3 Then
                    Btn_7.Checked = True
                    Btn_7.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If


                Btn_8.Text = Utility.NZ(Dt.Rows(7).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 2 Then

                    Btn_8.Checked = True

                End If
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 3 Then
                    Btn_8.Checked = True
                    Btn_8.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_9.Text = Utility.NZ(Dt.Rows(8).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 2 Then

                    Btn_9.Checked = True

                End If
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 3 Then
                    Btn_9.Checked = True
                    Btn_9.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_10.Text = Utility.NZ(Dt.Rows(9).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 2 Then

                    Btn_10.Checked = True

                End If
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 3 Then
                    Btn_10.Checked = True
                    Btn_10.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_11.Text = Utility.NZ(Dt.Rows(10).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 2 Then

                    Btn_11.Checked = True

                End If
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 3 Then
                    Btn_11.Checked = True
                    Btn_11.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_12.Text = Utility.NZ(Dt.Rows(11).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 2 Then

                    Btn_12.Checked = True

                End If
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 3 Then
                    Btn_12.Checked = True
                    Btn_12.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_13.Text = Utility.NZ(Dt.Rows(12).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 2 Then

                    Btn_13.Checked = True

                End If
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 3 Then
                    Btn_13.Checked = True
                    Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_14.Text = Utility.NZ(Dt.Rows(13).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 2 Then

                    Btn_14.Checked = True

                End If
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 3 Then
                    Btn_14.Checked = True
                    Btn_14.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_15.Text = Utility.NZ(Dt.Rows(14).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 2 Then

                    Btn_15.Checked = True

                End If
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 3 Then
                    Btn_15.Checked = True
                    Btn_15.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_16.Text = Utility.NZ(Dt.Rows(15).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 2 Then

                    Btn_16.Checked = True

                End If
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 3 Then
                    Btn_16.Checked = True
                    Btn_16.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_17.Text = Utility.NZ(Dt.Rows(16).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 2 Then

                    Btn_17.Checked = True

                End If
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 3 Then
                    Btn_17.Checked = True
                    Btn_17.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_18.Text = Utility.NZ(Dt.Rows(17).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 2 Then

                    Btn_18.Checked = True

                End If
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 3 Then
                    Btn_18.Checked = True
                    Btn_18.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_19.Text = Utility.NZ(Dt.Rows(18).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 2 Then

                    Btn_19.Checked = True

                End If
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 3 Then
                    Btn_19.Checked = True
                    Btn_19.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_20.Text = Utility.NZ(Dt.Rows(19).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 2 Then

                    Btn_20.Checked = True

                End If
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 3 Then
                    Btn_20.Checked = True
                    Btn_20.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_21.Text = Utility.NZ(Dt.Rows(20).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 2 Then

                    Btn_21.Checked = True

                End If
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 3 Then
                    Btn_21.Checked = True
                    Btn_21.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_22.Text = Utility.NZ(Dt.Rows(21).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 2 Then

                    Btn_22.Checked = True

                End If
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 3 Then
                    Btn_22.Checked = True
                    Btn_22.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_23.Text = Utility.NZ(Dt.Rows(22).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 2 Then

                    Btn_23.Checked = True

                End If
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 3 Then
                    Btn_23.Checked = True
                    Btn_23.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_24.Text = Utility.NZ(Dt.Rows(23).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 2 Then

                    Btn_24.Checked = True

                End If
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 3 Then
                    Btn_24.Checked = True
                    Btn_24.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_25.Text = Utility.NZ(Dt.Rows(24).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 2 Then

                    Btn_25.Checked = True

                End If
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 3 Then
                    Btn_25.Checked = True
                    Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_26.Text = Utility.NZ(Dt.Rows(25).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 2 Then

                    Btn_26.Checked = True

                End If
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 3 Then
                    Btn_26.Checked = True
                    Btn_26.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_27.Text = Utility.NZ(Dt.Rows(26).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 2 Then

                    Btn_27.Checked = True

                End If
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 3 Then
                    Btn_27.Checked = True
                    Btn_27.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_28.Text = Utility.NZ(Dt.Rows(27).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 2 Then

                    Btn_28.Checked = True

                End If
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 3 Then
                    Btn_28.Checked = True
                    Btn_28.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_29.Text = Utility.NZ(Dt.Rows(28).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 2 Then

                    Btn_29.Checked = True

                End If
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 3 Then
                    Btn_29.Checked = True
                    Btn_29.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_30.Text = Utility.NZ(Dt.Rows(29).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 2 Then

                    Btn_30.Checked = True

                End If
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 3 Then
                    Btn_30.Checked = True
                    Btn_30.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_31.Text = Utility.NZ(Dt.Rows(30).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 2 Then

                    Btn_31.Checked = True

                End If
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 3 Then
                    Btn_31.Checked = True
                    Btn_31.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
            End If

            '-------------------------------------------------------*** 1Shanbe ***--------------------------------------
            If Utility.NZ(Dt.Rows(0).Item("CalWeekID").ToString, "") = "2" Then
                Btn_2.Text = Utility.NZ(Dt.Rows(0).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(0).Item("CalDayStatusID").ToString = 2 Then

                    Btn_2.Checked = True

                End If
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 3 Then
                    Btn_2.Checked = True
                    Btn_2.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_3.Text = Utility.NZ(Dt.Rows(1).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(1).Item("CalDayStatusID").ToString = 2 Then

                    Btn_3.Checked = True

                End If
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 3 Then
                    Btn_3.Checked = True
                    Btn_3.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_4.Text = Utility.NZ(Dt.Rows(2).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(2).Item("CalDayStatusID").ToString = 2 Then

                    Btn_4.Checked = True

                End If
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 3 Then
                    Btn_4.Checked = True
                    Btn_4.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_5.Text = Utility.NZ(Dt.Rows(3).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(3).Item("CalDayStatusID").ToString = 2 Then

                    Btn_5.Checked = True

                End If
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 3 Then
                    Btn_5.Checked = True
                    Btn_5.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_6.Text = Utility.NZ(Dt.Rows(4).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(4).Item("CalDayStatusID").ToString = 2 Then

                    Btn_6.Checked = True

                End If
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 3 Then
                    Btn_6.Checked = True
                    Btn_6.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_7.Text = Utility.NZ(Dt.Rows(5).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(5).Item("CalDayStatusID").ToString = 2 Then

                    Btn_7.Checked = True

                End If
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 3 Then
                    Btn_7.Checked = True
                    Btn_7.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_8.Text = Utility.NZ(Dt.Rows(6).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(6).Item("CalDayStatusID").ToString = 2 Then

                    Btn_8.Checked = True

                End If
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 3 Then
                    Btn_8.Checked = True
                    Btn_8.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_9.Text = Utility.NZ(Dt.Rows(7).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(7).Item("CalDayStatusID").ToString = 2 Then

                    Btn_9.Checked = True

                End If
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 3 Then
                    Btn_9.Checked = True
                    Btn_9.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_10.Text = Utility.NZ(Dt.Rows(8).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(8).Item("CalDayStatusID").ToString = 2 Then

                    Btn_10.Checked = True

                End If
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 3 Then
                    Btn_10.Checked = True
                    Btn_10.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_11.Text = Utility.NZ(Dt.Rows(9).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(9).Item("CalDayStatusID").ToString = 2 Then

                    Btn_11.Checked = True

                End If
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 3 Then
                    Btn_11.Checked = True
                    Btn_11.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_12.Text = Utility.NZ(Dt.Rows(10).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(10).Item("CalDayStatusID").ToString = 2 Then

                    Btn_12.Checked = True

                End If
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 3 Then
                    Btn_12.Checked = True
                    Btn_12.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_13.Text = Utility.NZ(Dt.Rows(11).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(11).Item("CalDayStatusID").ToString = 2 Then

                    Btn_13.Checked = True

                End If
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 3 Then
                    Btn_13.Checked = True
                    Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_14.Text = Utility.NZ(Dt.Rows(12).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(12).Item("CalDayStatusID").ToString = 2 Then

                    Btn_14.Checked = True

                End If
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 3 Then
                    Btn_14.Checked = True
                    Btn_14.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_15.Text = Utility.NZ(Dt.Rows(13).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(13).Item("CalDayStatusID").ToString = 2 Then

                    Btn_15.Checked = True

                End If
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 3 Then
                    Btn_15.Checked = True
                    Btn_15.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_16.Text = Utility.NZ(Dt.Rows(14).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(14).Item("CalDayStatusID").ToString = 2 Then

                    Btn_16.Checked = True

                End If
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 3 Then
                    Btn_16.Checked = True
                    Btn_16.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_17.Text = Utility.NZ(Dt.Rows(15).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(15).Item("CalDayStatusID").ToString = 2 Then

                    Btn_17.Checked = True

                End If
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 3 Then
                    Btn_17.Checked = True
                    Btn_17.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_18.Text = Utility.NZ(Dt.Rows(16).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(16).Item("CalDayStatusID").ToString = 2 Then

                    Btn_18.Checked = True

                End If
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 3 Then
                    Btn_18.Checked = True
                    Btn_18.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_19.Text = Utility.NZ(Dt.Rows(17).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(17).Item("CalDayStatusID").ToString = 2 Then

                    Btn_19.Checked = True

                End If
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 3 Then
                    Btn_19.Checked = True
                    Btn_19.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_20.Text = Utility.NZ(Dt.Rows(18).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(18).Item("CalDayStatusID").ToString = 2 Then

                    Btn_20.Checked = True

                End If
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 3 Then
                    Btn_20.Checked = True
                    Btn_20.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_21.Text = Utility.NZ(Dt.Rows(19).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(19).Item("CalDayStatusID").ToString = 2 Then

                    Btn_21.Checked = True

                End If
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 3 Then
                    Btn_21.Checked = True
                    Btn_21.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_22.Text = Utility.NZ(Dt.Rows(20).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(20).Item("CalDayStatusID").ToString = 2 Then

                    Btn_22.Checked = True

                End If
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 3 Then
                    Btn_22.Checked = True
                    Btn_22.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_23.Text = Utility.NZ(Dt.Rows(21).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(21).Item("CalDayStatusID").ToString = 2 Then

                    Btn_23.Checked = True

                End If
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 3 Then
                    Btn_23.Checked = True
                    Btn_23.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_24.Text = Utility.NZ(Dt.Rows(22).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(22).Item("CalDayStatusID").ToString = 2 Then

                    Btn_24.Checked = True

                End If
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 3 Then
                    Btn_24.Checked = True
                    Btn_24.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_25.Text = Utility.NZ(Dt.Rows(23).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(23).Item("CalDayStatusID").ToString = 2 Then

                    Btn_25.Checked = True

                End If
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 3 Then
                    Btn_25.Checked = True
                    Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_26.Text = Utility.NZ(Dt.Rows(24).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(24).Item("CalDayStatusID").ToString = 2 Then

                    Btn_26.Checked = True

                End If
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 3 Then
                    Btn_26.Checked = True
                    Btn_26.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_27.Text = Utility.NZ(Dt.Rows(25).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(25).Item("CalDayStatusID").ToString = 2 Then

                    Btn_27.Checked = True

                End If
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 3 Then
                    Btn_27.Checked = True
                    Btn_27.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_28.Text = Utility.NZ(Dt.Rows(26).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(26).Item("CalDayStatusID").ToString = 2 Then

                    Btn_28.Checked = True

                End If
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 3 Then
                    Btn_28.Checked = True
                    Btn_28.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_29.Text = Utility.NZ(Dt.Rows(27).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(27).Item("CalDayStatusID").ToString = 2 Then

                    Btn_29.Checked = True

                End If
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 3 Then
                    Btn_29.Checked = True
                    Btn_29.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_30.Text = Utility.NZ(Dt.Rows(28).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(28).Item("CalDayStatusID").ToString = 2 Then

                    Btn_30.Checked = True

                End If
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 3 Then
                    Btn_30.Checked = True
                    Btn_30.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_31.Text = Utility.NZ(Dt.Rows(29).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(29).Item("CalDayStatusID").ToString = 2 Then

                    Btn_31.Checked = True

                End If
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 3 Then
                    Btn_31.Checked = True
                    Btn_31.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If


                Btn_32.Text = Utility.NZ(Dt.Rows(30).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(30).Item("CalDayStatusID").ToString = 2 Then

                    Btn_32.Checked = True

                End If
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 3 Then
                    Btn_32.Checked = True
                    Btn_32.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

            End If
            '------------------------------------------------*** 2Shanbe ***--------------------------------------------
            If Utility.NZ(Dt.Rows(0).Item("CalWeekID").ToString, "") = "3" Then
                Btn_3.Text = Utility.NZ(Dt.Rows(0).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(0).Item("CalDayStatusID").ToString = 2 Then

                    Btn_3.Checked = True

                End If
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 3 Then
                    Btn_3.Checked = True
                    Btn_3.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_4.Text = Utility.NZ(Dt.Rows(1).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(1).Item("CalDayStatusID").ToString = 2 Then

                    Btn_4.Checked = True

                End If
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 3 Then
                    Btn_4.Checked = True
                    Btn_4.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_5.Text = Utility.NZ(Dt.Rows(2).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(2).Item("CalDayStatusID").ToString = 2 Then

                    Btn_5.Checked = True

                End If
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 3 Then
                    Btn_5.Checked = True
                    Btn_5.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_6.Text = Utility.NZ(Dt.Rows(3).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(3).Item("CalDayStatusID").ToString = 2 Then

                    Btn_6.Checked = True

                End If
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 3 Then
                    Btn_6.Checked = True
                    Btn_6.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_7.Text = Utility.NZ(Dt.Rows(4).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(4).Item("CalDayStatusID").ToString = 2 Then

                    Btn_7.Checked = True

                End If
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 3 Then
                    Btn_7.Checked = True
                    Btn_7.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_8.Text = Utility.NZ(Dt.Rows(5).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(5).Item("CalDayStatusID").ToString = 2 Then

                    Btn_8.Checked = True

                End If
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 3 Then
                    Btn_8.Checked = True
                    Btn_8.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_9.Text = Utility.NZ(Dt.Rows(6).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(6).Item("CalDayStatusID").ToString = 2 Then

                    Btn_9.Checked = True

                End If
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 3 Then
                    Btn_9.Checked = True
                    Btn_9.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_10.Text = Utility.NZ(Dt.Rows(7).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(7).Item("CalDayStatusID").ToString = 2 Then

                    Btn_10.Checked = True

                End If
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 3 Then
                    Btn_10.Checked = True
                    Btn_10.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_11.Text = Utility.NZ(Dt.Rows(8).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(8).Item("CalDayStatusID").ToString = 2 Then

                    Btn_11.Checked = True

                End If
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 3 Then
                    Btn_11.Checked = True
                    Btn_11.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_12.Text = Utility.NZ(Dt.Rows(9).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(9).Item("CalDayStatusID").ToString = 2 Then

                    Btn_12.Checked = True

                End If
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 3 Then
                    Btn_12.Checked = True
                    Btn_12.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_13.Text = Utility.NZ(Dt.Rows(10).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(10).Item("CalDayStatusID").ToString = 2 Then

                    Btn_13.Checked = True

                End If
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 3 Then
                    Btn_13.Checked = True
                    Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_14.Text = Utility.NZ(Dt.Rows(11).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(11).Item("CalDayStatusID").ToString = 2 Then

                    Btn_14.Checked = True

                End If
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 3 Then
                    Btn_14.Checked = True
                    Btn_14.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_15.Text = Utility.NZ(Dt.Rows(12).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(12).Item("CalDayStatusID").ToString = 2 Then

                    Btn_15.Checked = True

                End If
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 3 Then
                    Btn_15.Checked = True
                    Btn_15.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_16.Text = Utility.NZ(Dt.Rows(13).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(13).Item("CalDayStatusID").ToString = 2 Then

                    Btn_16.Checked = True

                End If
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 3 Then
                    Btn_16.Checked = True
                    Btn_16.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_17.Text = Utility.NZ(Dt.Rows(14).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(14).Item("CalDayStatusID").ToString = 2 Then

                    Btn_17.Checked = True

                End If
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 3 Then
                    Btn_17.Checked = True
                    Btn_17.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_18.Text = Utility.NZ(Dt.Rows(15).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(15).Item("CalDayStatusID").ToString = 2 Then

                    Btn_18.Checked = True

                End If
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 3 Then
                    Btn_18.Checked = True
                    Btn_18.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_19.Text = Utility.NZ(Dt.Rows(16).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(16).Item("CalDayStatusID").ToString = 2 Then

                    Btn_19.Checked = True

                End If
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 3 Then
                    Btn_19.Checked = True
                    Btn_19.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_20.Text = Utility.NZ(Dt.Rows(17).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(17).Item("CalDayStatusID").ToString = 2 Then

                    Btn_20.Checked = True

                End If
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 3 Then
                    Btn_20.Checked = True
                    Btn_20.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_21.Text = Utility.NZ(Dt.Rows(18).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(18).Item("CalDayStatusID").ToString = 2 Then

                    Btn_21.Checked = True

                End If
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 3 Then
                    Btn_21.Checked = True
                    Btn_21.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_22.Text = Utility.NZ(Dt.Rows(19).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(19).Item("CalDayStatusID").ToString = 2 Then

                    Btn_22.Checked = True

                End If
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 3 Then
                    Btn_22.Checked = True
                    Btn_22.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_23.Text = Utility.NZ(Dt.Rows(20).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(20).Item("CalDayStatusID").ToString = 2 Then

                    Btn_23.Checked = True

                End If
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 3 Then
                    Btn_23.Checked = True
                    Btn_23.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_24.Text = Utility.NZ(Dt.Rows(21).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(21).Item("CalDayStatusID").ToString = 2 Then

                    Btn_24.Checked = True

                End If
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 3 Then
                    Btn_24.Checked = True
                    Btn_24.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_25.Text = Utility.NZ(Dt.Rows(22).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(22).Item("CalDayStatusID").ToString = 2 Then

                    Btn_25.Checked = True

                End If
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 3 Then
                    Btn_25.Checked = True
                    Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_26.Text = Utility.NZ(Dt.Rows(23).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(23).Item("CalDayStatusID").ToString = 2 Then

                    Btn_26.Checked = True

                End If
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 3 Then
                    Btn_26.Checked = True
                    Btn_26.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_27.Text = Utility.NZ(Dt.Rows(24).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(24).Item("CalDayStatusID").ToString = 2 Then

                    Btn_27.Checked = True

                End If
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 3 Then
                    Btn_27.Checked = True
                    Btn_27.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_28.Text = Utility.NZ(Dt.Rows(25).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(25).Item("CalDayStatusID").ToString = 2 Then

                    Btn_28.Checked = True

                End If
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 3 Then
                    Btn_28.Checked = True
                    Btn_28.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_29.Text = Utility.NZ(Dt.Rows(26).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(26).Item("CalDayStatusID").ToString = 2 Then

                    Btn_29.Checked = True

                End If
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 3 Then
                    Btn_29.Checked = True
                    Btn_29.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_30.Text = Utility.NZ(Dt.Rows(27).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(27).Item("CalDayStatusID").ToString = 2 Then

                    Btn_30.Checked = True

                End If
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 3 Then
                    Btn_30.Checked = True
                    Btn_30.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_31.Text = Utility.NZ(Dt.Rows(28).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(28).Item("CalDayStatusID").ToString = 2 Then

                    Btn_31.Checked = True

                End If
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 3 Then
                    Btn_31.Checked = True
                    Btn_31.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_32.Text = Utility.NZ(Dt.Rows(29).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(29).Item("CalDayStatusID").ToString = 2 Then

                    Btn_32.Checked = True

                End If
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 3 Then
                    Btn_32.Checked = True
                    Btn_32.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If


                Btn_33.Text = Utility.NZ(Dt.Rows(30).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(30).Item("CalDayStatusID").ToString = 2 Then

                    Btn_33.Checked = True

                End If
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 3 Then
                    Btn_33.Checked = True
                    Btn_33.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_34.Text = Utility.NZ(Dt.Rows(31).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(31).Item("CalDayStatusID").ToString = 2 Then

                    Btn_34.Checked = True

                End If
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 3 Then
                    Btn_34.Checked = True
                    Btn_34.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If





            End If
            '-------------------------------------- 3Shanbe ---------------------------------------------
            If Utility.NZ(Dt.Rows(0).Item("CalWeekID").ToString, "") = "4" Then
                Btn_4.Text = Utility.NZ(Dt.Rows(0).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(0).Item("CalDayStatusID").ToString = 2 Then

                    Btn_4.Checked = True

                End If
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 3 Then
                    Btn_4.Checked = True
                    Btn_4.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_5.Text = Utility.NZ(Dt.Rows(1).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(1).Item("CalDayStatusID").ToString = 2 Then

                    Btn_5.Checked = True

                End If
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 3 Then
                    Btn_5.Checked = True
                    Btn_5.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_6.Text = Utility.NZ(Dt.Rows(2).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(2).Item("CalDayStatusID").ToString = 2 Then

                    Btn_6.Checked = True

                End If
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 3 Then
                    Btn_6.Checked = True
                    Btn_6.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_7.Text = Utility.NZ(Dt.Rows(3).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(3).Item("CalDayStatusID").ToString = 2 Then

                    Btn_7.Checked = True

                End If
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 3 Then
                    Btn_7.Checked = True
                    Btn_7.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_8.Text = Utility.NZ(Dt.Rows(4).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(4).Item("CalDayStatusID").ToString = 2 Then

                    Btn_8.Checked = True

                End If
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 3 Then
                    Btn_8.Checked = True
                    Btn_8.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_9.Text = Utility.NZ(Dt.Rows(5).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(5).Item("CalDayStatusID").ToString = 2 Then

                    Btn_9.Checked = True

                End If
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 3 Then
                    Btn_9.Checked = True
                    Btn_9.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_10.Text = Utility.NZ(Dt.Rows(6).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(6).Item("CalDayStatusID").ToString = 2 Then

                    Btn_10.Checked = True

                End If
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 3 Then
                    Btn_10.Checked = True
                    Btn_10.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_11.Text = Utility.NZ(Dt.Rows(7).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 2 Then

                    Btn_11.Checked = True

                End If
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 3 Then
                    Btn_11.Checked = True
                    Btn_11.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_12.Text = Utility.NZ(Dt.Rows(8).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 2 Then

                    Btn_12.Checked = True

                End If
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 3 Then
                    Btn_12.Checked = True
                    Btn_12.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_13.Text = Utility.NZ(Dt.Rows(9).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 2 Then

                    Btn_13.Checked = True

                End If
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 3 Then
                    Btn_13.Checked = True
                    Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_14.Text = Utility.NZ(Dt.Rows(10).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 2 Then

                    Btn_14.Checked = True

                End If
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 3 Then
                    Btn_14.Checked = True
                    Btn_14.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_15.Text = Utility.NZ(Dt.Rows(11).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 2 Then

                    Btn_15.Checked = True

                End If
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 3 Then
                    Btn_15.Checked = True
                    Btn_15.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_16.Text = Utility.NZ(Dt.Rows(12).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 2 Then

                    Btn_16.Checked = True

                End If
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 3 Then
                    Btn_16.Checked = True
                    Btn_16.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_17.Text = Utility.NZ(Dt.Rows(13).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 2 Then

                    Btn_17.Checked = True

                End If
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 3 Then
                    Btn_17.Checked = True
                    Btn_17.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_18.Text = Utility.NZ(Dt.Rows(14).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 2 Then

                    Btn_18.Checked = True

                End If
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 3 Then
                    Btn_18.Checked = True
                    Btn_18.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_19.Text = Utility.NZ(Dt.Rows(15).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 2 Then

                    Btn_19.Checked = True

                End If
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 3 Then
                    Btn_19.Checked = True
                    Btn_19.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_20.Text = Utility.NZ(Dt.Rows(16).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 2 Then

                    Btn_20.Checked = True

                End If
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 3 Then
                    Btn_20.Checked = True
                    Btn_20.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_21.Text = Utility.NZ(Dt.Rows(17).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 2 Then

                    Btn_21.Checked = True

                End If
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 3 Then
                    Btn_21.Checked = True
                    Btn_21.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_22.Text = Utility.NZ(Dt.Rows(18).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 2 Then

                    Btn_22.Checked = True

                End If
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 3 Then
                    Btn_22.Checked = True
                    Btn_22.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_23.Text = Utility.NZ(Dt.Rows(19).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 2 Then

                    Btn_23.Checked = True

                End If
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 3 Then
                    Btn_23.Checked = True
                    Btn_23.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_24.Text = Utility.NZ(Dt.Rows(20).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 2 Then

                    Btn_24.Checked = True

                End If
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 3 Then
                    Btn_24.Checked = True
                    Btn_24.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_25.Text = Utility.NZ(Dt.Rows(21).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 2 Then

                    Btn_25.Checked = True

                End If
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 3 Then
                    Btn_25.Checked = True
                    Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_26.Text = Utility.NZ(Dt.Rows(22).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 2 Then

                    Btn_26.Checked = True

                End If
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 3 Then
                    Btn_26.Checked = True
                    Btn_26.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_27.Text = Utility.NZ(Dt.Rows(23).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 2 Then

                    Btn_27.Checked = True

                End If
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 3 Then
                    Btn_27.Checked = True
                    Btn_27.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_28.Text = Utility.NZ(Dt.Rows(24).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 2 Then

                    Btn_28.Checked = True

                End If
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 3 Then
                    Btn_28.Checked = True
                    Btn_28.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_29.Text = Utility.NZ(Dt.Rows(25).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 2 Then

                    Btn_29.Checked = True

                End If
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 3 Then
                    Btn_29.Checked = True
                    Btn_29.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_30.Text = Utility.NZ(Dt.Rows(26).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 2 Then

                    Btn_30.Checked = True

                End If
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 3 Then
                    Btn_30.Checked = True
                    Btn_30.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_31.Text = Utility.NZ(Dt.Rows(27).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 2 Then

                    Btn_31.Checked = True

                End If
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 3 Then
                    Btn_31.Checked = True
                    Btn_31.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_32.Text = Utility.NZ(Dt.Rows(28).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 2 Then

                    Btn_32.Checked = True

                End If
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 3 Then
                    Btn_32.Checked = True
                    Btn_32.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_33.Text = Utility.NZ(Dt.Rows(29).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 2 Then

                    Btn_33.Checked = True

                End If
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 3 Then
                    Btn_33.Checked = True
                    Btn_33.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_34.Text = Utility.NZ(Dt.Rows(30).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 2 Then

                    Btn_34.Checked = True

                End If
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 3 Then
                    Btn_34.Checked = True
                    Btn_34.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_35.Text = Utility.NZ(Dt.Rows(31).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 2 Then

                    Btn_35.Checked = True

                End If
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 3 Then
                    Btn_35.Checked = True
                    Btn_35.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

            End If
            '---------------------------------------------------------------------------------- 4Shanbe -------------------------------------
            If Utility.NZ(Dt.Rows(0).Item("CalWeekID").ToString, "") = "5" Then
                Btn_5.Text = Utility.NZ(Dt.Rows(0).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 2 Then

                    Btn_5.Checked = True

                End If
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 3 Then
                    Btn_5.Checked = True
                    Btn_5.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_6.Text = Utility.NZ(Dt.Rows(1).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 2 Then

                    Btn_6.Checked = True

                End If
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 3 Then
                    Btn_6.Checked = True
                    Btn_6.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_7.Text = Utility.NZ(Dt.Rows(2).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 2 Then

                    Btn_7.Checked = True

                End If
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 3 Then
                    Btn_7.Checked = True
                    Btn_7.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_8.Text = Utility.NZ(Dt.Rows(3).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 2 Then

                    Btn_8.Checked = True

                End If
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 3 Then
                    Btn_8.Checked = True
                    Btn_8.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_9.Text = Utility.NZ(Dt.Rows(4).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 2 Then

                    Btn_9.Checked = True

                End If
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 3 Then
                    Btn_9.Checked = True
                    Btn_9.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_10.Text = Utility.NZ(Dt.Rows(5).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 2 Then

                    Btn_10.Checked = True

                End If
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 3 Then
                    Btn_10.Checked = True
                    Btn_10.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_11.Text = Utility.NZ(Dt.Rows(6).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 2 Then

                    Btn_11.Checked = True

                End If
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 3 Then
                    Btn_11.Checked = True
                    Btn_11.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_12.Text = Utility.NZ(Dt.Rows(7).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 2 Then

                    Btn_12.Checked = True

                End If
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 3 Then
                    Btn_12.Checked = True
                    Btn_12.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_13.Text = Utility.NZ(Dt.Rows(8).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 2 Then

                    Btn_13.Checked = True

                End If
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 3 Then
                    Btn_13.Checked = True
                    Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_14.Text = Utility.NZ(Dt.Rows(9).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 2 Then

                    Btn_14.Checked = True

                End If
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 3 Then
                    Btn_14.Checked = True
                    Btn_14.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_15.Text = Utility.NZ(Dt.Rows(10).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 2 Then

                    Btn_15.Checked = True

                End If
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 3 Then
                    Btn_15.Checked = True
                    Btn_15.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_16.Text = Utility.NZ(Dt.Rows(11).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 2 Then

                    Btn_16.Checked = True

                End If
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 3 Then
                    Btn_16.Checked = True
                    Btn_16.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_17.Text = Utility.NZ(Dt.Rows(12).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 2 Then

                    Btn_17.Checked = True

                End If
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 3 Then
                    Btn_17.Checked = True
                    Btn_17.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_18.Text = Utility.NZ(Dt.Rows(13).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 2 Then

                    Btn_18.Checked = True

                End If
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 3 Then
                    Btn_18.Checked = True
                    Btn_18.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_19.Text = Utility.NZ(Dt.Rows(14).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 2 Then

                    Btn_19.Checked = True

                End If
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 3 Then
                    Btn_19.Checked = True
                    Btn_19.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_20.Text = Utility.NZ(Dt.Rows(15).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 2 Then

                    Btn_20.Checked = True

                End If
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 3 Then
                    Btn_20.Checked = True
                    Btn_20.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_21.Text = Utility.NZ(Dt.Rows(16).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 2 Then

                    Btn_21.Checked = True

                End If
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 3 Then
                    Btn_21.Checked = True
                    Btn_21.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_22.Text = Utility.NZ(Dt.Rows(17).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 2 Then

                    Btn_22.Checked = True

                End If
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 3 Then
                    Btn_22.Checked = True
                    Btn_22.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_23.Text = Utility.NZ(Dt.Rows(18).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 2 Then

                    Btn_23.Checked = True

                End If
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 3 Then
                    Btn_23.Checked = True
                    Btn_23.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_24.Text = Utility.NZ(Dt.Rows(19).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 2 Then

                    Btn_24.Checked = True

                End If
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 3 Then
                    Btn_24.Checked = True
                    Btn_24.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_25.Text = Utility.NZ(Dt.Rows(20).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 2 Then

                    Btn_25.Checked = True

                End If
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 3 Then
                    Btn_25.Checked = True
                    Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_26.Text = Utility.NZ(Dt.Rows(21).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 2 Then

                    Btn_26.Checked = True

                End If
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 3 Then
                    Btn_26.Checked = True
                    Btn_26.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_27.Text = Utility.NZ(Dt.Rows(22).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 2 Then

                    Btn_27.Checked = True

                End If
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 3 Then
                    Btn_27.Checked = True
                    Btn_27.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_28.Text = Utility.NZ(Dt.Rows(23).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 2 Then

                    Btn_28.Checked = True

                End If
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 3 Then
                    Btn_28.Checked = True
                    Btn_28.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_29.Text = Utility.NZ(Dt.Rows(24).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 2 Then

                    Btn_29.Checked = True

                End If
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 3 Then
                    Btn_29.Checked = True
                    Btn_29.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_30.Text = Utility.NZ(Dt.Rows(25).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 2 Then

                    Btn_30.Checked = True

                End If
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 3 Then
                    Btn_30.Checked = True
                    Btn_30.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_31.Text = Utility.NZ(Dt.Rows(26).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 2 Then

                    Btn_31.Checked = True

                End If
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 3 Then
                    Btn_31.Checked = True
                    Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_32.Text = Utility.NZ(Dt.Rows(27).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 2 Then

                    Btn_32.Checked = True

                End If
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 3 Then
                    Btn_32.Checked = True
                    Btn_32.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_33.Text = Utility.NZ(Dt.Rows(28).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 2 Then

                    Btn_33.Checked = True

                End If
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 3 Then
                    Btn_33.Checked = True
                    Btn_33.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_34.Text = Utility.NZ(Dt.Rows(29).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 2 Then

                    Btn_34.Checked = True

                End If
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 3 Then
                    Btn_34.Checked = True
                    Btn_34.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_35.Text = Utility.NZ(Dt.Rows(30).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 2 Then

                    Btn_35.Checked = True

                End If
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 3 Then
                    Btn_35.Checked = True
                    Btn_35.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_36.Text = Utility.NZ(Dt.Rows(31).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 2 Then

                    Btn_36.Checked = True

                End If
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 3 Then
                    Btn_36.Checked = True
                    Btn_36.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If




            End If
            '---------------------------------------------------------------------------------- 5Shanbe -------------------------------------
            If Utility.NZ(Dt.Rows(0).Item("CalWeekID").ToString, "") = "6" Then
                Btn_6.Text = Utility.NZ(Dt.Rows(0).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 2 Then

                    Btn_6.Checked = True

                End If
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 3 Then
                    Btn_6.Checked = True
                    Btn_6.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_7.Text = Utility.NZ(Dt.Rows(1).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 2 Then

                    Btn_7.Checked = True

                End If
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 3 Then
                    Btn_7.Checked = True
                    Btn_7.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_8.Text = Utility.NZ(Dt.Rows(2).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 2 Then

                    Btn_8.Checked = True

                End If
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 3 Then
                    Btn_8.Checked = True
                    Btn_8.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_9.Text = Utility.NZ(Dt.Rows(3).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 2 Then

                    Btn_9.Checked = True

                End If
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 3 Then
                    Btn_9.Checked = True
                    Btn_9.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_10.Text = Utility.NZ(Dt.Rows(4).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 2 Then

                    Btn_10.Checked = True

                End If
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 3 Then
                    Btn_10.Checked = True
                    Btn_10.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_11.Text = Utility.NZ(Dt.Rows(5).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 2 Then

                    Btn_11.Checked = True

                End If
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 3 Then
                    Btn_11.Checked = True
                    Btn_11.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_12.Text = Utility.NZ(Dt.Rows(6).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 2 Then

                    Btn_12.Checked = True

                End If
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 3 Then
                    Btn_12.Checked = True
                    Btn_12.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_13.Text = Utility.NZ(Dt.Rows(7).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 2 Then

                    Btn_13.Checked = True

                End If
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 3 Then
                    Btn_13.Checked = True
                    Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_14.Text = Utility.NZ(Dt.Rows(8).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 2 Then

                    Btn_14.Checked = True

                End If
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 3 Then
                    Btn_14.Checked = True
                    Btn_14.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_15.Text = Utility.NZ(Dt.Rows(9).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 2 Then

                    Btn_15.Checked = True

                End If
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 3 Then
                    Btn_15.Checked = True
                    Btn_15.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_16.Text = Utility.NZ(Dt.Rows(10).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 2 Then

                    Btn_16.Checked = True

                End If
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 3 Then
                    Btn_16.Checked = True
                    Btn_16.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_17.Text = Utility.NZ(Dt.Rows(11).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 2 Then

                    Btn_17.Checked = True

                End If
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 3 Then
                    Btn_17.Checked = True
                    Btn_17.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_18.Text = Utility.NZ(Dt.Rows(12).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 2 Then

                    Btn_18.Checked = True

                End If
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 3 Then
                    Btn_18.Checked = True
                    Btn_18.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_19.Text = Utility.NZ(Dt.Rows(13).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 2 Then

                    Btn_19.Checked = True

                End If
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 3 Then
                    Btn_19.Checked = True
                    Btn_19.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_20.Text = Utility.NZ(Dt.Rows(14).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 2 Then

                    Btn_20.Checked = True

                End If
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 3 Then
                    Btn_20.Checked = True
                    Btn_20.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_21.Text = Utility.NZ(Dt.Rows(15).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 2 Then

                    Btn_21.Checked = True

                End If
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 3 Then
                    Btn_21.Checked = True
                    Btn_21.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_22.Text = Utility.NZ(Dt.Rows(16).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 2 Then

                    Btn_22.Checked = True

                End If
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 3 Then
                    Btn_22.Checked = True
                    Btn_22.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_23.Text = Utility.NZ(Dt.Rows(17).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 2 Then

                    Btn_23.Checked = True

                End If
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 3 Then
                    Btn_23.Checked = True
                    Btn_23.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_24.Text = Utility.NZ(Dt.Rows(18).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 2 Then

                    Btn_24.Checked = True

                End If
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 3 Then
                    Btn_24.Checked = True
                    Btn_24.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_25.Text = Utility.NZ(Dt.Rows(19).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 2 Then

                    Btn_25.Checked = True

                End If
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 3 Then
                    Btn_25.Checked = True
                    Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_26.Text = Utility.NZ(Dt.Rows(20).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 2 Then

                    Btn_26.Checked = True

                End If
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 3 Then
                    Btn_26.Checked = True
                    Btn_26.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_27.Text = Utility.NZ(Dt.Rows(21).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 2 Then

                    Btn_27.Checked = True

                End If
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 3 Then
                    Btn_27.Checked = True
                    Btn_27.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_28.Text = Utility.NZ(Dt.Rows(22).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 2 Then

                    Btn_28.Checked = True

                End If
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 3 Then
                    Btn_28.Checked = True
                    Btn_28.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_29.Text = Utility.NZ(Dt.Rows(23).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 2 Then

                    Btn_29.Checked = True

                End If
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 3 Then
                    Btn_29.Checked = True
                    Btn_29.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_30.Text = Utility.NZ(Dt.Rows(24).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 2 Then

                    Btn_30.Checked = True

                End If
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 3 Then
                    Btn_30.Checked = True
                    Btn_30.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_31.Text = Utility.NZ(Dt.Rows(25).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 2 Then

                    Btn_31.Checked = True

                End If
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 3 Then
                    Btn_31.Checked = True
                    Btn_31.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_32.Text = Utility.NZ(Dt.Rows(26).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 2 Then

                    Btn_32.Checked = True

                End If
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 3 Then
                    Btn_32.Checked = True
                    Btn_32.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_33.Text = Utility.NZ(Dt.Rows(27).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 2 Then

                    Btn_33.Checked = True

                End If
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 3 Then
                    Btn_33.Checked = True
                    Btn_33.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_34.Text = Utility.NZ(Dt.Rows(28).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 2 Then

                    Btn_34.Checked = True

                End If
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 3 Then
                    Btn_34.Checked = True
                    Btn_34.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_35.Text = Utility.NZ(Dt.Rows(29).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 2 Then

                    Btn_35.Checked = True

                End If
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 3 Then
                    Btn_35.Checked = True
                    Btn_35.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_36.Text = Utility.NZ(Dt.Rows(30).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 2 Then

                    Btn_36.Checked = True

                End If
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 3 Then
                    Btn_36.Checked = True
                    Btn_36.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_37.Text = Utility.NZ(Dt.Rows(31).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 2 Then

                    Btn_37.Checked = True

                End If
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 3 Then
                    Btn_37.Checked = True
                    Btn_37.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If


            End If
            '---------------------------------------------------------------------------------- Jome -------------------------------------
            If Utility.NZ(Dt.Rows(0).Item("CalWeekID").ToString, "") = "7" Then
                Btn_7.Text = Utility.NZ(Dt.Rows(0).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 2 Then

                    Btn_7.Checked = True

                End If
                If Dt.Rows(0).Item("CalDayStatusID").ToString = 3 Then
                    Btn_7.Checked = True
                    Btn_7.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_8.Text = Utility.NZ(Dt.Rows(1).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 2 Then

                    Btn_8.Checked = True

                End If
                If Dt.Rows(1).Item("CalDayStatusID").ToString = 3 Then
                    Btn_8.Checked = True
                    Btn_8.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_9.Text = Utility.NZ(Dt.Rows(2).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 2 Then

                    Btn_9.Checked = True

                End If
                If Dt.Rows(2).Item("CalDayStatusID").ToString = 3 Then
                    Btn_9.Checked = True
                    Btn_9.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_10.Text = Utility.NZ(Dt.Rows(3).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 2 Then

                    Btn_10.Checked = True

                End If
                If Dt.Rows(3).Item("CalDayStatusID").ToString = 3 Then
                    Btn_10.Checked = True
                    Btn_10.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_11.Text = Utility.NZ(Dt.Rows(4).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 2 Then

                    Btn_11.Checked = True

                End If
                If Dt.Rows(4).Item("CalDayStatusID").ToString = 3 Then
                    Btn_11.Checked = True
                    Btn_11.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_12.Text = Utility.NZ(Dt.Rows(5).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 2 Then

                    Btn_12.Checked = True

                End If
                If Dt.Rows(5).Item("CalDayStatusID").ToString = 3 Then
                    Btn_12.Checked = True
                    Btn_12.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_13.Text = Utility.NZ(Dt.Rows(6).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 2 Then

                    Btn_13.Checked = True

                End If
                If Dt.Rows(6).Item("CalDayStatusID").ToString = 3 Then
                    Btn_13.Checked = True
                    Btn_13.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_14.Text = Utility.NZ(Dt.Rows(7).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 2 Then

                    Btn_14.Checked = True

                End If
                If Dt.Rows(7).Item("CalDayStatusID").ToString = 3 Then
                    Btn_14.Checked = True
                    Btn_14.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_15.Text = Utility.NZ(Dt.Rows(8).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 2 Then

                    Btn_15.Checked = True

                End If
                If Dt.Rows(8).Item("CalDayStatusID").ToString = 3 Then
                    Btn_15.Checked = True
                    Btn_15.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_16.Text = Utility.NZ(Dt.Rows(9).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 2 Then

                    Btn_16.Checked = True

                End If
                If Dt.Rows(9).Item("CalDayStatusID").ToString = 3 Then
                    Btn_16.Checked = True
                    Btn_16.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_17.Text = Utility.NZ(Dt.Rows(10).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 2 Then

                    Btn_17.Checked = True

                End If
                If Dt.Rows(10).Item("CalDayStatusID").ToString = 3 Then
                    Btn_17.Checked = True
                    Btn_17.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_18.Text = Utility.NZ(Dt.Rows(11).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 2 Then

                    Btn_18.Checked = True

                End If
                If Dt.Rows(11).Item("CalDayStatusID").ToString = 3 Then
                    Btn_18.Checked = True
                    Btn_18.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_19.Text = Utility.NZ(Dt.Rows(12).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 2 Then

                    Btn_19.Checked = True

                End If
                If Dt.Rows(12).Item("CalDayStatusID").ToString = 3 Then
                    Btn_19.Checked = True
                    Btn_19.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_20.Text = Utility.NZ(Dt.Rows(13).Item("CalIraniDayNum").ToString, "")

                If Dt.Rows(13).Item("CalDayStatusID").ToString = 2 Then

                    Btn_20.Checked = True

                End If
                If Dt.Rows(13).Item("CalDayStatusID").ToString = 3 Then
                    Btn_20.Checked = True
                    Btn_20.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_21.Text = Utility.NZ(Dt.Rows(14).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 2 Then

                    Btn_21.Checked = True

                End If
                If Dt.Rows(14).Item("CalDayStatusID").ToString = 3 Then
                    Btn_21.Checked = True
                    Btn_21.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_22.Text = Utility.NZ(Dt.Rows(15).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 2 Then

                    Btn_22.Checked = True

                End If
                If Dt.Rows(15).Item("CalDayStatusID").ToString = 3 Then
                    Btn_22.Checked = True
                    Btn_22.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_23.Text = Utility.NZ(Dt.Rows(16).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 2 Then

                    Btn_23.Checked = True

                End If
                If Dt.Rows(16).Item("CalDayStatusID").ToString = 3 Then
                    Btn_23.Checked = True
                    Btn_23.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_24.Text = Utility.NZ(Dt.Rows(17).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 2 Then

                    Btn_24.Checked = True

                End If
                If Dt.Rows(17).Item("CalDayStatusID").ToString = 3 Then
                    Btn_24.Checked = True
                    Btn_24.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_25.Text = Utility.NZ(Dt.Rows(18).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 2 Then

                    Btn_25.Checked = True

                End If
                If Dt.Rows(18).Item("CalDayStatusID").ToString = 3 Then
                    Btn_25.Checked = True
                    Btn_25.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_26.Text = Utility.NZ(Dt.Rows(19).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 2 Then

                    Btn_26.Checked = True

                End If
                If Dt.Rows(19).Item("CalDayStatusID").ToString = 3 Then
                    Btn_26.Checked = True
                    Btn_26.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_27.Text = Utility.NZ(Dt.Rows(20).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 2 Then

                    Btn_27.Checked = True

                End If
                If Dt.Rows(20).Item("CalDayStatusID").ToString = 3 Then
                    Btn_27.Checked = True
                    Btn_27.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_28.Text = Utility.NZ(Dt.Rows(21).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 2 Then

                    Btn_28.Checked = True

                End If
                If Dt.Rows(21).Item("CalDayStatusID").ToString = 3 Then
                    Btn_28.Checked = True
                    Btn_28.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_29.Text = Utility.NZ(Dt.Rows(22).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 2 Then

                    Btn_29.Checked = True

                End If
                If Dt.Rows(22).Item("CalDayStatusID").ToString = 3 Then
                    Btn_29.Checked = True
                    Btn_29.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_30.Text = Utility.NZ(Dt.Rows(23).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 2 Then

                    Btn_30.Checked = True

                End If
                If Dt.Rows(23).Item("CalDayStatusID").ToString = 3 Then
                    Btn_30.Checked = True
                    Btn_30.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_31.Text = Utility.NZ(Dt.Rows(24).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 2 Then

                    Btn_31.Checked = True

                End If
                If Dt.Rows(24).Item("CalDayStatusID").ToString = 3 Then
                    Btn_31.Checked = True
                    Btn_31.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_32.Text = Utility.NZ(Dt.Rows(25).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 2 Then

                    Btn_32.Checked = True

                End If
                If Dt.Rows(25).Item("CalDayStatusID").ToString = 3 Then
                    Btn_32.Checked = True
                    Btn_32.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_33.Text = Utility.NZ(Dt.Rows(26).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 2 Then

                    Btn_33.Checked = True

                End If
                If Dt.Rows(26).Item("CalDayStatusID").ToString = 3 Then
                    Btn_33.Checked = True
                    Btn_33.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_34.Text = Utility.NZ(Dt.Rows(27).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 2 Then

                    Btn_34.Checked = True

                End If
                If Dt.Rows(27).Item("CalDayStatusID").ToString = 3 Then
                    Btn_34.Checked = True
                    Btn_34.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If
                Btn_35.Text = Utility.NZ(Dt.Rows(28).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 2 Then

                    Btn_35.Checked = True

                End If
                If Dt.Rows(28).Item("CalDayStatusID").ToString = 3 Then
                    Btn_35.Checked = True
                    Btn_35.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_36.Text = Utility.NZ(Dt.Rows(29).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 2 Then

                    Btn_36.Checked = True

                End If
                If Dt.Rows(29).Item("CalDayStatusID").ToString = 3 Then
                    Btn_36.Checked = True
                    Btn_36.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_37.Text = Utility.NZ(Dt.Rows(30).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 2 Then

                    Btn_37.Checked = True

                End If
                If Dt.Rows(30).Item("CalDayStatusID").ToString = 3 Then
                    Btn_37.Checked = True
                    Btn_37.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If

                Btn_38.Text = Utility.NZ(Dt.Rows(31).Item("CalIraniDayNum").ToString, "")
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 2 Then

                    Btn_38.Checked = True

                End If
                If Dt.Rows(31).Item("CalDayStatusID").ToString = 3 Then
                    Btn_38.Checked = True
                    Btn_38.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta


                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_Calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cmb_Month_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Month.SelectedIndexChanged

    End Sub

    Private Sub Cmb_Month_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_Month.SelectedValueChanged
        disableBtnCheck()
        TopPnl.Text = "تقویم کاری سال " & Cmb_Year.Text & " - " & Cmb_Month.Text & " ماه "

        Call createCalander()
    End Sub
    Private Sub SetReminder()


        Dim frm As New Frm_ChangeDateState
        frm.SetLblDate.Text = SelectedDate
        frm.ShowDialog()
        Dim e As New EventArgs

        Cmb_Month_SelectedValueChanged(vbNull, e)

    End Sub

    Private Sub Btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_1.Click
        If Btn_1.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_1.Text))
            SetReminder()

        End If

    End Sub

    Private Sub Btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_2.Click
        If Btn_2.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_2.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_3.Click
        If Btn_3.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_3.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_4.Click
        If Btn_4.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_4.Text))
            SetReminder()
        End If

    End Sub

    Private Sub Btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_5.Click
        If Btn_5.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_5.Text))
            SetReminder()
        End If

    End Sub

    Private Sub Btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_6.Click
        If Btn_6.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_6.Text))
            SetReminder()
        End If

    End Sub

    Private Sub Btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_7.Click
        If Btn_7.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_7.Text))
            SetReminder()
        End If

    End Sub

    Private Sub Btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_8.Click
        If Btn_8.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_8.Text))
            SetReminder()
        End If

    End Sub

    Private Sub Btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_9.Click
        If Btn_9.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_9.Text))
            SetReminder()
        End If

    End Sub

    Private Sub Btn_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_10.Click
        If Btn_10.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_10.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_11.Click
        If Btn_11.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_11.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_12.Click
        If Btn_12.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_12.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_13.Click
        If Btn_13.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_13.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_14.Click
        If Btn_14.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_14.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_15.Click
        If Btn_15.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_15.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_16.Click
        If Btn_16.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_16.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_17.Click
        If Btn_17.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_17.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_18.Click
        If Btn_18.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_18.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_19.Click
        If Btn_19.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_19.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_20.Click
        If Btn_20.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_20.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_21.Click
        If Btn_21.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_21.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_22.Click
        If Btn_22.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_22.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_23.Click
        If Btn_23.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_23.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_24.Click
        If Btn_24.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_24.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_25.Click
        If Btn_25.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_25.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_26.Click
        If Btn_26.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_26.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_27.Click
        If Btn_27.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_27.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_28.Click
        If Btn_28.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_28.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_29.Click
        If Btn_29.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_29.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_30.Click
        If Btn_30.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_30.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_31.Click
        If Btn_31.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_31.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_32.Click
        If Btn_32.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_32.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_33.Click
        If Btn_33.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_33.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_34.Click
        If Btn_34.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_34.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Btn_35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_35.Click
        If Btn_35.Text <> "" Then
            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(Btn_35.Text))
            SetReminder()
        End If
    End Sub

    Private Sub Cmb_Year_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Year.SelectedValueChanged
        TopPnl.Text = "تقویم کاری سال " & Cmb_Year.Text & " - " & Cmb_Month.Text & " ماه "

        disableBtnCheck()
        Call createCalander()
    End Sub

    Private Sub Btn_1_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_1.MouseMove
        ShowDescription(Btn_1)
    End Sub

    Private Sub ShowDescription(CurButton As DevComponents.DotNetBar.ButtonX)
        Try

            SelectedDate = Cmb_Year.Text & "/" & String.Format("{0:00}/{1:00}", Cmb_Month.SelectedValue, Convert.ToInt32(CurButton.Text))
        SqlStr = "select * from tbRCL_Calendar_Machin where CalIraniDate='" & SelectedDate & "'"
        Dt = Pers.GetDataTable(strConnection, SqlStr)
            If (Dt.Rows.Count > 0) Then
                CurButton.Tooltip = Dt.DefaultView.Item(0).Item("Description").ToString()

                '  Lbl_Desc.Text = Dt.DefaultView.Item(0).Item("Description").ToString()
            Else
                '  Lbl_Desc.Text = ""

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_2_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_2.MouseMove
        ShowDescription(Btn_2)
    End Sub

    Private Sub Btn_3_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_3.MouseMove
        ShowDescription(Btn_3)
    End Sub

    Private Sub Btn_4_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_4.MouseMove
        ShowDescription(Btn_4)
    End Sub

    Private Sub Btn_5_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_5.MouseMove
        ShowDescription(Btn_5)
    End Sub

    Private Sub Btn_6_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_6.MouseMove
        ShowDescription(Btn_6)
    End Sub

    Private Sub Btn_7_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_7.MouseMove
        ShowDescription(Btn_7)
    End Sub

    Private Sub Btn_8_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_8.MouseMove
        ShowDescription(Btn_8)
    End Sub

    Private Sub Btn_9_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_9.MouseMove
        ShowDescription(Btn_9)
    End Sub

    Private Sub Btn_10_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_10.MouseMove
        ShowDescription(Btn_10)
    End Sub

    Private Sub Btn_11_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_11.MouseMove
        ShowDescription(Btn_11)
    End Sub

    Private Sub Btn_12_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_12.MouseMove
        ShowDescription(Btn_12)
    End Sub

    Private Sub Btn_13_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_13.MouseMove
        ShowDescription(Btn_13)
    End Sub

    Private Sub Btn_14_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_14.MouseMove
        ShowDescription(Btn_14)
    End Sub

    Private Sub Btn_15_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_15.MouseMove
        ShowDescription(Btn_15)
    End Sub

    Private Sub Btn_16_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_16.MouseMove
        ShowDescription(Btn_16)
    End Sub

    Private Sub Btn_17_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_17.MouseMove
        ShowDescription(Btn_17)
    End Sub

    Private Sub Btn_18_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_18.MouseMove
        ShowDescription(Btn_18)
    End Sub

    Private Sub Btn_19_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_19.MouseMove
        ShowDescription(Btn_19)
    End Sub

    Private Sub Btn_20_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_20.MouseMove
        ShowDescription(Btn_20)
    End Sub

    Private Sub Btn_21_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_21.MouseMove
        ShowDescription(Btn_21)
    End Sub

    Private Sub Btn_22_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_22.MouseMove
        ShowDescription(Btn_22)
    End Sub

    Private Sub Btn_23_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_23.MouseMove
        ShowDescription(Btn_23)
    End Sub

    Private Sub Btn_24_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_24.MouseMove
        ShowDescription(Btn_24)
    End Sub

    Private Sub Btn_25_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_25.MouseMove
        ShowDescription(Btn_25)
    End Sub

    Private Sub Btn_26_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_26.MouseMove
        ShowDescription(Btn_26)
    End Sub

    Private Sub Btn_27_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_27.MouseMove
        ShowDescription(Btn_27)
    End Sub

    Private Sub Btn_28_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_28.MouseMove
        ShowDescription(Btn_28)
    End Sub

    Private Sub Btn_29_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_29.MouseMove
        ShowDescription(Btn_29)
    End Sub

    Private Sub Btn_30_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_30.MouseMove
        ShowDescription(Btn_30)
    End Sub

    Private Sub Btn_31_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_31.MouseMove
        ShowDescription(Btn_31)
    End Sub

    Private Sub Btn_32_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_32.MouseMove
        ShowDescription(Btn_32)
    End Sub

    Private Sub Btn_33_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_33.MouseMove
        ShowDescription(Btn_33)
    End Sub

    Private Sub Btn_34_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_34.MouseMove
        ShowDescription(Btn_34)
    End Sub

    Private Sub Btn_35_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_35.MouseMove
        ShowDescription(Btn_35)
    End Sub

    Private Sub Btn_36_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_36.MouseMove
        ShowDescription(Btn_36)
    End Sub

    Private Sub Btn_37_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_37.MouseMove
        ShowDescription(Btn_37)
    End Sub

    Private Sub Btn_38_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_38.MouseMove
        ShowDescription(Btn_38)
    End Sub

    Private Sub Btn_39_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_39.MouseMove
        ShowDescription(Btn_39)
    End Sub

    Private Sub Btn_40_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_40.MouseMove
        ShowDescription(Btn_40)
    End Sub

    Private Sub Btn_41_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_41.MouseMove
        ShowDescription(Btn_41)
    End Sub

    Private Sub Btn_42_MouseMove(sender As Object, e As MouseEventArgs) Handles Btn_42.MouseMove
        ShowDescription(Btn_42)
    End Sub
End Class
