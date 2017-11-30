using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

using Persistent.DataAccess;
using DAL;
using System.Windows;
using FarsiLibrary.Utils;
using System.Threading;
using System.IO.Ports;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using IraniDate.IraniDate;
namespace PIASService
{
    public partial class PIASService : ServiceBase
    {
        BLL.CLS_Client Bll_Client = new BLL.CLS_Client();
        DataTable Dt = new DataTable();

        double totalHours;
        Persistent.DataAccess.DataAccess Pers = new Persistent.DataAccess.DataAccess();
        string stresive1;
        string[] ListOfStartShifTime = new string[60];
        PersianCalendar pc = new PersianCalendar();
        string sqlstr = "";

        int DeviceStateID1 = 0;
        int DeviceStateID2 = 0;
        int DeviceStateID3 = 0;
        int DeviceStateID4 = 0;
        int DeviceStateID5 = 0;
        int DeviceStateID6 = 0;
        int DeviceStateID7 = 0;
        int DeviceStateID8 = 0;
        int DeviceStateID9 = 0;
        int DeviceStateID10 = 0;
        int DeviceStateID11 = 0;
        int DeviceStateID12 = 0;
        int DeviceStateID13 = 0;
        int DeviceStateID14 = 0;
        int DeviceStateID15 = 0;
        int DeviceStateID16 = 0;
        int DeviceStateID17 = 0;
        int DeviceStateID18 = 0;
        int DeviceStateID19 = 0;
        int DeviceStateID20 = 0;
        int DeviceStateID21 = 0;
        int DeviceStateID22 = 0;
        int DeviceStateID23 = 0;
        int DeviceStateID24 = 0;


        int DeviceStateID1Old = 0;
        int DeviceStateID2Old = 0;
        int DeviceStateID3Old = 0;
        int DeviceStateID4Old = 0;
        int DeviceStateID5Old = 0;
        int DeviceStateID6Old = 0;
        int DeviceStateID7Old = 0;
        int DeviceStateID8Old = 0;
        int DeviceStateID9Old = 0;
        int DeviceStateID10Old = 0;
        int DeviceStateID11Old = 0;
        int DeviceStateID12Old = 0;
        int DeviceStateID13Old = 0;
        int DeviceStateID14Old = 0;
        int DeviceStateID15Old = 0;
        int DeviceStateID16Old = 0;
        int DeviceStateID17Old = 0;
        int DeviceStateID18Old = 0;
        int DeviceStateID19Old = 0;
        int DeviceStateID20Old = 0;
        int DeviceStateID21Old = 0;
        int DeviceStateID22Old = 0;
        int DeviceStateID23Old = 0;
        int DeviceStateID24Old = 0;
        DateTime LastTimeForShift = DateTime.Now ;

        Boolean ISStartInt1 = false;
        Boolean ISStartInt2 = false;
        Boolean ISStartInt3 = false;
        Boolean ISStartInt4 = false;
        Boolean ISStartInt5 = false;
        Boolean ISStartInt6 = false;
        Boolean ISStartInt7 = false;
        Boolean ISStartInt8 = false;
        Boolean ISStartInt9 = false;
        Boolean ISStartInt10 = false;
        Boolean ISStartInt11 = false;
        Boolean ISStartInt12 = false;
        Boolean ISStartInt13 = false;
        Boolean ISStartInt14 = false;
        Boolean ISStartInt15 = false;
        Boolean ISStartInt16 = false;
        Boolean ISStartInt17 = false;
        Boolean ISStartInt18 = false;
        Boolean ISStartInt19 = false;
        Boolean ISStartInt20 = false;
        Boolean ISStartInt21 = false;
        Boolean ISStartInt22 = false;
        Boolean ISStartInt23 = false;
        Boolean ISStartInt24 = false;

        int CountOfPuls1 = 0;
        int CountOfPuls2 = 0;
        int CountOfPuls3 = 0;
        int CountOfPuls4 = 0;
        int CountOfPuls5 = 0;
        int CountOfPuls6 = 0;
        int CountOfPuls7 = 0;
        int CountOfPuls8 = 0;
        int CountOfPuls9 = 0;
        int CountOfPuls10 = 0;
        int CountOfPuls11 = 0;
        int CountOfPuls12 = 0;
        int CountOfPuls13 = 0;
        int CountOfPuls14 = 0;
        int CountOfPuls15 = 0;
        int CountOfPuls16 = 0;
        int CountOfPuls17 = 0;
        int CountOfPuls18 = 0;
        int CountOfPuls19 = 0;
        int CountOfPuls20 = 0;
        int CountOfPuls21 = 0;
        int CountOfPuls22 = 0;
        int CountOfPuls23 = 0;
        int CountOfPuls24 = 0;
        string CurShamsiDate = "";

        Boolean IsNewShift = false;

        Boolean LstState1 = false;
        Boolean LstState2 = false;
        Boolean LstState3 = false;
        Boolean LstState4 = false;
        Boolean LstState5 = false;
        Boolean LstState6 = false;
        Boolean LstState7 = false;
        Boolean LstState8 = false;
        Boolean LstState9 = false;
        Boolean LstState10 = false;
        Boolean LstState11 = false;
        Boolean LstState12 = false;
        Boolean LstState13 = false;
        Boolean LstState14 = false;
        Boolean LstState15 = false;
        Boolean LstState16 = false;
        Boolean LstState17 = false;
        Boolean LstState18 = false;
        Boolean LstState19 = false;
        Boolean LstState20 = false;
        Boolean LstState21 = false;
        Boolean LstState22 = false;
        Boolean LstState23 = false;
        Boolean LstState24 = false;

        public PIASService()
        {
            InitializeComponent();

        }

        IraniDate.IraniDate.IraniDate CurrentDate = new IraniDate.IraniDate.IraniDate();




        protected override void OnStart(string[] args)
        {
            //BLL.Cls_PublicOperations.Dt = Bll_Client.GetAllCientWithOutDiuratiion();
            //for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            //{

            //    DateTime FirstDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
            //    DateTime EndDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());
            //    totalHours = (EndDate - FirstDate).TotalSeconds;
            //    Bll_Client.UpdateClientDuratuin(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString(), totalHours.ToString());

            //}

            System.Diagnostics.Debugger.Launch();
            EventLog.WriteEntry("Start Mohsen Event", EventLogEntryType.Information);
            serialPort1.Close();
            serialPort1.DataBits = 8;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.BaudRate = int.Parse("9600");

            sqlstr = " SELECT   * FROM    Tb_Devices where DeviceId='1048'";
            Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);

            LastTimeForShift = DateTime.Now;

            sqlstr = "SELECT        HumanResource.dbo.tbRCL_Shifts.*, Active AS Expr1  FROM            HumanResource.dbo.tbRCL_Shifts  WHERE        (Active = 1)";
            Dt = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
            int count = 0;


            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                ListOfStartShifTime[i] = Dt.DefaultView[i]["ShiftBeginHourTxt"].ToString();
                count = i;
            }

            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count +1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftEndHourTxt"].ToString();

            }



            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + 1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftBeginBreakTimeTxt1"].ToString();

            }



            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + 1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftEndBreakTimeTxt1"].ToString();

            }



            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + 1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftBeginBreakTimeTxt2"].ToString();

            }


            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + i;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftEndBreakTimeTxt2"].ToString();

            }




            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + 1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftBeginBreakTimeTxt3"].ToString();

            }

            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + i;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftEndBreakTimeTxt3"].ToString();

            }

            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + 1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftBeginBreakTimeTxt4"].ToString();

            }

            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + 1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftEndBreakTimeTxt4"].ToString();

            }


            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + 1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftBeginBreakTimeTxt5"].ToString();

            }




            for (int i = 0; i <= Dt.Rows.Count - 1; i++)
            {
                count = count + 1;
                ListOfStartShifTime[count] = Dt.DefaultView[i]["ShiftEndBreakTimeTxt5"].ToString();

            }



            serialPort1.PortName = Cls_Public.PublicDT.DefaultView[0]["PortName"].ToString();
            serialPort1.Open();
            serialPort1.DiscardInBuffer();
            EventLog.WriteEntry("Start serialPort1 Event", EventLogEntryType.Information);



        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("STOP PCS TEC Service ", EventLogEntryType.Information);

            //BLL.Cls_PublicOperations.Dt = Bll_Client.GetAllCientWithOutDiuratiion();
            //for (int i = 0; i <= BLL.Cls_PublicOperations.Dt.Rows.Count - 1; i++)
            //{

            //    DateTime FirstDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiStartDateTime"].ToString());
            //    DateTime EndDate = DateTime.Parse(BLL.Cls_PublicOperations.Dt.DefaultView[i]["MiladiFinishDateTime"].ToString());
            //    totalHours = (EndDate - FirstDate).TotalSeconds;
            //    Bll_Client.UpdateClientDuratuin(BLL.Cls_PublicOperations.Dt.DefaultView[i]["DeviceStateID"].ToString(), totalHours.ToString());

            //}


        }

        protected override void OnShutdown()
        {
            EventLog.WriteEntry("ShutDown PCS TEC Service ", EventLogEntryType.Information);

        }

        //      protected override void OnShutdown()
        //      {
        //          base.OnShutdown();
        //          for(int i = 1; i <= 24; i++)
        //          {

        //sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + 1048 + "') AND (DeviceLineId = '" + i + "')  ORDER BY DeviceStateID DESC)";
        //          Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
        //              if (string.IsNullOrEmpty(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString()))
        //              {

        //          DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
        //          DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());


        //          totalHours = (EndDate - FirstDate).TotalSeconds;
        //          sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + i + "') AND (DeviceLineId = '" + 1048 + "')  ORDER BY DeviceStateID DESC)";
        //          Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

        //              }

        //          }

        //      }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                IraniDate.IraniDate.IraniDate irdate = new IraniDate.IraniDate.IraniDate();

                //  IraniDate.IraniDate  Irdate = IraniDate.IraniDate  ;

                DateTime thisDate = DateTime.Now;
                CurShamsiDate = string.Format("{0}/{1}/{2}", pc.GetYear(thisDate), pc.GetMonth(thisDate).ToString("00"), pc.GetDayOfMonth(thisDate).ToString("00"));
                stresive1 = serialPort1.ReadLine();
                Thread thread1 = new Thread(new ThreadStart(display1));
                thread1.Start();
                thread1.Join();


            }

            catch { }
        }

        private void display1()
        {
            try
            {
                String strcode;
                string val;
                int num;

                strcode = stresive1.Substring(0, 9);
                val = stresive1.Substring(10, 3);
                num = int.Parse(val);
                val = Convert.ToString(num, 2);
                val = val.PadLeft(8, '0');



                //if (DateTime.Now.Hour == 23)
                //{
                //    IsNewShift = false;
                //    // EventLog.WriteEntry("false IS NEXT DAY VALUE IN " + DateTime.Now.ToString(), EventLogEntryType.Information);

                //}
                //if (DateTime.Now.Hour == 23 && DateTime.Now.Minute == 59 && DateTime.Now.Second == 59 && IsNewShift == false)
                //{
                //  EventLog.WriteEntry("Time 0:00 --  " + DateTime.Now.ToString(), EventLogEntryType.Information);


                string time = DateTime.Now.ToString("HH:mm");

                 

                foreach (string x in ListOfStartShifTime)
                {

                    if (time==x && (DateTime.Now   - LastTimeForShift ).TotalSeconds>60   )
                    {
                        
                            EventLog.WriteEntry("Insert Break Time  New Shift   In Timers in " + DateTime.Now.ToString(), EventLogEntryType.Information);

                            InsertData1(1048, 1, Convert.ToInt32(!LstState1));
                            InsertData2(1048, 2, Convert.ToInt32(!LstState2));
                            InsertData3(1048, 3, Convert.ToInt32(!LstState3));
                            InsertData4(1048, 4, Convert.ToInt32(!LstState4));
                            InsertData5(1048, 5, Convert.ToInt32(!LstState5));
                            InsertData6(1048, 6, Convert.ToInt32(!LstState6));
                            InsertData7(1048, 7, Convert.ToInt32(!LstState7));
                            InsertData8(1048, 8, Convert.ToInt32(!LstState8));
                            InsertData9(1048, 9, Convert.ToInt32(!LstState9));
                            InsertData10(1048, 10, Convert.ToInt32(!LstState10));
                            InsertData11(1048, 11, Convert.ToInt32(!LstState11));
                            InsertData12(1048, 12, Convert.ToInt32(!LstState12));
                            InsertData13(1048, 13, Convert.ToInt32(!LstState13));
                            InsertData14(1048, 14, Convert.ToInt32(!LstState14));
                            InsertData15(1048, 15, Convert.ToInt32(!LstState15));
                            InsertData16(1048, 16, Convert.ToInt32(!LstState16));
                            InsertData17(1048, 17, Convert.ToInt32(!LstState17));
                            InsertData18(1048, 18, Convert.ToInt32(!LstState18));
                            InsertData19(1048, 19, Convert.ToInt32(!LstState19));
                            InsertData20(1048, 20, Convert.ToInt32(!LstState20));
                            InsertData21(1048, 21, Convert.ToInt32(!LstState21));
                            InsertData22(1048, 22, Convert.ToInt32(!LstState22));
                            InsertData23(1048, 23, Convert.ToInt32(!LstState23));
                            InsertData24(1048, 24, Convert.ToInt32(!LstState24));

                          
                            Thread.Sleep(1000);

                        LastTimeForShift = DateTime.Now;


                            EventLog.WriteEntry("set IsNewShift to false in  " + DateTime.Now.ToString(), EventLogEntryType.Information);
                      




                    }



                    else
                    {

                        if (strcode == "INPUT= 65")
                        {
                            if (val.Substring(0, 1) == "1") { InsertData17(1048, 17, 1); } else { InsertData17(1048, 17, 0); }
                            if (val.Substring(1, 1) == "1") { InsertData18(1048, 18, 1); } else { InsertData18(1048, 18, 0); }
                            if (val.Substring(2, 1) == "1") { InsertData19(1048, 19, 1); } else { InsertData19(1048, 19, 0); }
                            if (val.Substring(3, 1) == "1") { InsertData20(1048, 20, 1); } else { InsertData20(1048, 20, 0); }
                            if (val.Substring(4, 1) == "1") { InsertData21(1048, 21, 1); } else { InsertData21(1048, 21, 0); }
                            if (val.Substring(5, 1) == "1") { InsertData22(1048, 22, 1); } else { InsertData22(1048, 22, 0); }
                            if (val.Substring(6, 1) == "1") { InsertData23(1048, 23, 1); } else { InsertData23(1048, 23, 0); }
                            if (val.Substring(7, 1) == "1") { InsertData24(1048, 24, 1); } else { InsertData24(1048, 24, 0); }

                        }

                        if (strcode == "INPUT= 66")
                        {


                            if (val.Substring(0, 1) == "1") { InsertData9(1048, 9, 1); } else { InsertData9(1048, 9, 0); }
                            if (val.Substring(1, 1) == "1") { InsertData10(1048, 10, 1); } else { InsertData10(1048, 10, 0); }
                            if (val.Substring(2, 1) == "1") { InsertData11(1048, 11, 1); } else { InsertData11(1048, 11, 0); }
                            if (val.Substring(3, 1) == "1") { InsertData12(1048, 12, 1); } else { InsertData12(1048, 12, 0); }
                            if (val.Substring(4, 1) == "1") { InsertData13(1048, 13, 1); } else { InsertData13(1048, 13, 0); }
                            if (val.Substring(5, 1) == "1") { InsertData14(1048, 14, 1); } else { InsertData14(1048, 14, 0); }
                            if (val.Substring(6, 1) == "1") { InsertData15(1048, 15, 1); } else { InsertData15(1048, 15, 0); }
                            if (val.Substring(7, 1) == "1") { InsertData16(1048, 16, 1); } else { InsertData16(1048, 16, 0); }

                        }
                        if (strcode == "INPUT= 67")
                        {

                            if (val.Substring(7, 1) == "1") { InsertData1(1048, 1, 1); } else { InsertData1(1048, 1, 0); }
                            if (val.Substring(6, 1) == "1") { InsertData2(1048, 2, 1); } else { InsertData2(1048, 2, 0); }
                            if (val.Substring(5, 1) == "1") { InsertData3(1048, 3, 1); } else { InsertData3(1048, 3, 0); }
                            if (val.Substring(4, 1) == "1") { InsertData4(1048, 4, 1); } else { InsertData4(1048, 4, 0); }
                            if (val.Substring(3, 1) == "1") { InsertData5(1048, 5, 1); } else { InsertData5(1048, 5, 0); }
                            if (val.Substring(2, 1) == "1") { InsertData6(1048, 6, 1); } else { InsertData6(1048, 6, 0); }
                            if (val.Substring(1, 1) == "1") { InsertData7(1048, 7, 1); } else { InsertData7(1048, 7, 0); }
                            if (val.Substring(0, 1) == "1") { InsertData8(1048, 8, 1); } else { InsertData8(1048, 8, 0); }

                        }
                    }
                }
            }
            catch { }



        }

        //  private void InsertClient(int DeviceID, int DeviceLineId, string startDate, string StartTime, string EndDate, string EndTime, int Duration, int StateId, int Count, DateTime MiladiStartDateTime, DateTime MiladiFinishDateTime)
        private void InsertClient(int DeviceID, int DeviceLineId, string startDate, string StartTime, int StateId, int Count, DateTime MiladiStartDateTime)

        {

            Pers.ClearParameter();
            Pers.Sp_AddParam("@DeviceID", System.Data.SqlDbType.Int, DeviceID, System.Data.ParameterDirection.Input);
            Pers.Sp_AddParam("@DeviceLineId", System.Data.SqlDbType.Int, DeviceLineId, System.Data.ParameterDirection.Input);
            Pers.Sp_AddParam("@startDate", System.Data.SqlDbType.NVarChar, startDate, System.Data.ParameterDirection.Input);
            Pers.Sp_AddParam("@StartTime", System.Data.SqlDbType.NVarChar, StartTime, System.Data.ParameterDirection.Input);
            // Pers.Sp_AddParam("@EndDate", System.Data.SqlDbType.NVarChar, EndDate, System.Data.ParameterDirection.Input);
            //    Pers.Sp_AddParam("@EndTime", System.Data.SqlDbType.NVarChar, EndTime, System.Data.ParameterDirection.Input);
            //   Pers.Sp_AddParam("@Duration", System.Data.SqlDbType.Int, Duration, System.Data.ParameterDirection.Input);
            Pers.Sp_AddParam("@StateId", System.Data.SqlDbType.Int, StateId, System.Data.ParameterDirection.Input);
            Pers.Sp_AddParam("@Count", System.Data.SqlDbType.Int, Count, System.Data.ParameterDirection.Input);
            Pers.Sp_AddParam("@MiladiStartDateTime", System.Data.SqlDbType.DateTime, MiladiStartDateTime, System.Data.ParameterDirection.Input);
            //    Pers.Sp_AddParam("@MiladiFinishDateTime", System.Data.SqlDbType.DateTime, MiladiFinishDateTime, System.Data.ParameterDirection.Input);
            Pers.Sp_Exe("SP_InsertClient", Cls_Public.CnnStr, true);
            Pers.ClearParameter();
        }


        private void InsertData1(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt1)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls1 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState1 = Convert.ToBoolean(StateID);
                        ISStartInt1 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID1 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID1Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID1Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState1 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where  DevicestateID='" + DeviceStateID1 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID1 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls1 + " where DevicestateID='" + DeviceStateID1Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID1 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where DevicestateID='" + DeviceStateID1 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState1 = Convert.ToBoolean(StateID);
                        ISStartInt1 = false;
                        CountOfPuls1 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt1 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls1 + " where  DevicestateID= '" + DeviceStateID1 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData2(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt2)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls2 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState2 = Convert.ToBoolean(StateID);
                        ISStartInt2 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID2 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID2Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID2Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState2 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls2 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls2 + " where  DevicestateID='" + DeviceStateID2 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID2 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls2 + " where DevicestateID='" + DeviceStateID2Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID2 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls2 + " where DevicestateID='" + DeviceStateID2 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls2 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState2 = Convert.ToBoolean(StateID);
                        ISStartInt2 = false;
                        CountOfPuls2 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt2 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls2 + " where  DevicestateID= '" + DeviceStateID2 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData3(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt3)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls3 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState3 = Convert.ToBoolean(StateID);
                        ISStartInt3 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID3 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID3Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID3Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState3 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls3 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls3 + " where  DevicestateID='" + DeviceStateID3 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID3 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls3 + " where DevicestateID='" + DeviceStateID3Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID3 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls3 + " where DevicestateID='" + DeviceStateID3 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls3 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState3 = Convert.ToBoolean(StateID);
                        ISStartInt3 = false;
                        CountOfPuls3 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt3 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls3 + " where  DevicestateID= '" + DeviceStateID3 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData4(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt4)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls4 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState4 = Convert.ToBoolean(StateID);
                        ISStartInt4 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID4 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID4Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID4Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState4 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls4 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls4 + " where  DevicestateID='" + DeviceStateID4 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID4 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls4 + " where DevicestateID='" + DeviceStateID4Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID4 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls4 + " where DevicestateID='" + DeviceStateID4 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls4 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState4 = Convert.ToBoolean(StateID);
                        ISStartInt4 = false;
                        CountOfPuls4 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt4 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls4 + " where  DevicestateID= '" + DeviceStateID4 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData5(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt5)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls5 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState5 = Convert.ToBoolean(StateID);
                        ISStartInt5 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID5 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID5Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID5Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState5 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls5 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls5 + " where  DevicestateID='" + DeviceStateID5 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID5 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls5 + " where DevicestateID='" + DeviceStateID5Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID5 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls5 + " where DevicestateID='" + DeviceStateID5 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls5 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState5 = Convert.ToBoolean(StateID);
                        ISStartInt5 = false;
                        CountOfPuls5 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt5 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls5 + " where  DevicestateID= '" + DeviceStateID5 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData6(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt6)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls6 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState6 = Convert.ToBoolean(StateID);
                        ISStartInt6 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID6 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID6Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID6Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState6 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls6 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls6 + " where  DevicestateID='" + DeviceStateID6 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID6 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls6 + " where DevicestateID='" + DeviceStateID6Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID6 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls6 + " where DevicestateID='" + DeviceStateID6 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls6 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState6 = Convert.ToBoolean(StateID);
                        ISStartInt6 = false;
                        CountOfPuls6 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt6 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls6 + " where  DevicestateID= '" + DeviceStateID6 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData7(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt7)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls7 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState7 = Convert.ToBoolean(StateID);
                        ISStartInt7 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID7 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID7Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID7Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState7 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls7 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls7 + " where  DevicestateID='" + DeviceStateID7 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID7 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls7 + " where DevicestateID='" + DeviceStateID7Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID7 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls7 + " where DevicestateID='" + DeviceStateID7 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls7 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState7 = Convert.ToBoolean(StateID);
                        ISStartInt7 = false;
                        CountOfPuls7 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt7 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls7 + " where  DevicestateID= '" + DeviceStateID7 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData8(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt8)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls8 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState8 = Convert.ToBoolean(StateID);
                        ISStartInt8 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID8 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID8Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID8Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState8 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls8 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls8 + " where  DevicestateID='" + DeviceStateID8 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID8 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls8 + " where DevicestateID='" + DeviceStateID8Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID8 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls8 + " where DevicestateID='" + DeviceStateID8 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls8 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState8 = Convert.ToBoolean(StateID);
                        ISStartInt8 = false;
                        CountOfPuls8 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt8 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls8 + " where  DevicestateID= '" + DeviceStateID8 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData9(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt9)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls9 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState9 = Convert.ToBoolean(StateID);
                        ISStartInt9 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID9 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID9Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID9Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState9 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls9 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls9 + " where  DevicestateID='" + DeviceStateID9 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID9 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls9 + " where DevicestateID='" + DeviceStateID9Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID9 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls9 + " where DevicestateID='" + DeviceStateID9 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls9 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState9 = Convert.ToBoolean(StateID);
                        ISStartInt9 = false;
                        CountOfPuls9 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt9 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls9 + " where  DevicestateID= '" + DeviceStateID9 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData10(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt10)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls10 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState10 = Convert.ToBoolean(StateID);
                        ISStartInt10 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID10 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID10Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID10Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState10 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls10 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls10 + " where  DevicestateID='" + DeviceStateID10 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID10 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls10 + " where DevicestateID='" + DeviceStateID10Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID10 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls10 + " where DevicestateID='" + DeviceStateID10 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls10 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState10 = Convert.ToBoolean(StateID);
                        ISStartInt10 = false;
                        CountOfPuls10 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt10 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls10 + " where  DevicestateID= '" + DeviceStateID10 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData11(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt11)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls11 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState11 = Convert.ToBoolean(StateID);
                        ISStartInt11 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID11 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID11Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID11Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState11 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls11 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls11 + " where  DevicestateID='" + DeviceStateID11 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID11 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls11 + " where DevicestateID='" + DeviceStateID11Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID11 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls11 + " where DevicestateID='" + DeviceStateID11 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls11 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState11 = Convert.ToBoolean(StateID);
                        ISStartInt11 = false;
                        CountOfPuls11 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt11 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls11 + " where  DevicestateID= '" + DeviceStateID11 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData12(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt12)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls12 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState12 = Convert.ToBoolean(StateID);
                        ISStartInt12 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID12 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID12Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID12Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState12 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls12 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls12 + " where  DevicestateID='" + DeviceStateID12 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID12 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls12 + " where DevicestateID='" + DeviceStateID12Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID12 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls12 + " where DevicestateID='" + DeviceStateID12 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls12 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState12 = Convert.ToBoolean(StateID);
                        ISStartInt12 = false;
                        CountOfPuls12 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt12 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls12 + " where  DevicestateID= '" + DeviceStateID12 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData13(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt13)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls13 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState13 = Convert.ToBoolean(StateID);
                        ISStartInt13 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID13 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID13Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID13Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState13 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls13 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls13 + " where  DevicestateID='" + DeviceStateID13 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID13 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls13 + " where DevicestateID='" + DeviceStateID13Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID13 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls13 + " where DevicestateID='" + DeviceStateID13 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls13 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState13 = Convert.ToBoolean(StateID);
                        ISStartInt13 = false;
                        CountOfPuls13 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt13 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls13 + " where  DevicestateID= '" + DeviceStateID13 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData14(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt14)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls14 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState14 = Convert.ToBoolean(StateID);
                        ISStartInt14 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID14 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID14Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID14Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState14 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls14 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls14 + " where  DevicestateID='" + DeviceStateID14 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID14 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls14 + " where DevicestateID='" + DeviceStateID14Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID14 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls14 + " where DevicestateID='" + DeviceStateID14 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls14 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState14 = Convert.ToBoolean(StateID);
                        ISStartInt14 = false;
                        CountOfPuls14 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt14 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls14 + " where  DevicestateID= '" + DeviceStateID14 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData15(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt15)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls15 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState15 = Convert.ToBoolean(StateID);
                        ISStartInt15 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID15 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID15Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID15Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState15 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls15 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls15 + " where  DevicestateID='" + DeviceStateID15 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID15 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls15 + " where DevicestateID='" + DeviceStateID15Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID15 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls15 + " where DevicestateID='" + DeviceStateID15 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls15 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState15 = Convert.ToBoolean(StateID);
                        ISStartInt15 = false;
                        CountOfPuls15 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt15 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls15 + " where  DevicestateID= '" + DeviceStateID15 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }
        private void InsertData16(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt16)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls16 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState16 = Convert.ToBoolean(StateID);
                        ISStartInt16 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID16 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID16Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID16Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState16 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where  DevicestateID='" + DeviceStateID16 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID16 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls16 + " where DevicestateID='" + DeviceStateID16Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID16 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where DevicestateID='" + DeviceStateID16 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState16 = Convert.ToBoolean(StateID);
                        ISStartInt16 = false;
                        CountOfPuls16 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt16 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls16 + " where  DevicestateID= '" + DeviceStateID16 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData17(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt17)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls17 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState17 = Convert.ToBoolean(StateID);
                        ISStartInt17 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID17 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID17Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID17Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState17 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls17 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls17 + " where  DevicestateID='" + DeviceStateID17 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID17 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls17 + " where DevicestateID='" + DeviceStateID17Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID17 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls17 + " where DevicestateID='" + DeviceStateID17 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls17 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState17 = Convert.ToBoolean(StateID);
                        ISStartInt17 = false;
                        CountOfPuls17 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt17 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls17 + " where  DevicestateID= '" + DeviceStateID17 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }
        private void InsertData18(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt18)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls18 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState18 = Convert.ToBoolean(StateID);
                        ISStartInt18 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID18 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID18Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID18Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState18 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls18 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls18 + " where  DevicestateID='" + DeviceStateID18 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID18 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls18 + " where DevicestateID='" + DeviceStateID18Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID18 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls18 + " where DevicestateID='" + DeviceStateID18 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls18 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState18 = Convert.ToBoolean(StateID);
                        ISStartInt18 = false;
                        CountOfPuls18 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt18 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls18 + " where  DevicestateID= '" + DeviceStateID18 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }
        private void InsertData19(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt19)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls19 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState19 = Convert.ToBoolean(StateID);
                        ISStartInt19 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID19 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID19Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID19Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState19 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls19 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls19 + " where  DevicestateID='" + DeviceStateID19 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID19 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls19 + " where DevicestateID='" + DeviceStateID19Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID19 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls19 + " where DevicestateID='" + DeviceStateID19 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls19 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState19 = Convert.ToBoolean(StateID);
                        ISStartInt19 = false;
                        CountOfPuls19 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt19 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls19 + " where  DevicestateID= '" + DeviceStateID19 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData20(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt20)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls20 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState20 = Convert.ToBoolean(StateID);
                        ISStartInt20 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID20 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID20Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID20Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState20 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls20 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls20 + " where  DevicestateID='" + DeviceStateID20 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID20 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls20 + " where DevicestateID='" + DeviceStateID20Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID20 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls20 + " where DevicestateID='" + DeviceStateID20 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls20 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState20 = Convert.ToBoolean(StateID);
                        ISStartInt20 = false;
                        CountOfPuls20 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt20 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls20 + " where  DevicestateID= '" + DeviceStateID20 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData21(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt21)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls21 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState21 = Convert.ToBoolean(StateID);
                        ISStartInt21 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID21 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID21Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID21Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState21 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls21 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls21 + " where  DevicestateID='" + DeviceStateID21 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID21 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls21 + " where DevicestateID='" + DeviceStateID21Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID21 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls21 + " where DevicestateID='" + DeviceStateID21 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls21 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState21 = Convert.ToBoolean(StateID);
                        ISStartInt21 = false;
                        CountOfPuls21 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt21 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls21 + " where  DevicestateID= '" + DeviceStateID21 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData22(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt22)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls22 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState22 = Convert.ToBoolean(StateID);
                        ISStartInt22 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID22 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID22Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID22Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState22 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls22 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls22 + " where  DevicestateID='" + DeviceStateID22 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID22 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls22 + " where DevicestateID='" + DeviceStateID22Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID22 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls22 + " where DevicestateID='" + DeviceStateID22 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls22 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState22 = Convert.ToBoolean(StateID);
                        ISStartInt22 = false;
                        CountOfPuls22 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt22 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls22 + " where  DevicestateID= '" + DeviceStateID22 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData23(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt23)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls23 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState23 = Convert.ToBoolean(StateID);
                        ISStartInt23 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID23 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID23Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID23Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState23 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls23 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls23 + " where  DevicestateID='" + DeviceStateID23 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID23 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls23 + " where DevicestateID='" + DeviceStateID23Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID23 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls23 + " where DevicestateID='" + DeviceStateID23 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls23 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState23 = Convert.ToBoolean(StateID);
                        ISStartInt23 = false;
                        CountOfPuls23 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt23 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls23 + " where  DevicestateID= '" + DeviceStateID23 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

        private void InsertData24(int DeviceId, int DeviceLineId, int StateID)
        {


            try
            {

                if (!ISStartInt24)
                {
                    try
                    {
                        sqlstr = "insert into Tb_Client (DeviceID,DeviceLineId,StartDate,StartTime,StateId,[Count],MiladiStartDateTime) values(" + DeviceId + "," + DeviceLineId + ",'" + CurShamsiDate + "','" + DateTime.Now.ToString("HH:mm:ss:ff") + "'," + StateID + "," + ++CountOfPuls24 + ",convert(datetime,'" + DateTime.Now.ToString() + "'))";
                        LstState24 = Convert.ToBoolean(StateID);
                        ISStartInt24 = true;
                        Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                    }
                    catch { }


                    sqlstr = " SELECT        TOP (2) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC ";
                    Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);


                    if (Cls_Public.PublicDT.Rows.Count == 2)
                    {
                        try
                        {
                            DeviceStateID24 = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[0]["DeviceStateID"].ToString());

                            DeviceStateID24Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());
                        }
                        catch { }
                    }
                    if (Cls_Public.PublicDT.Rows.Count == 1)
                    {

                        DeviceStateID24Old = Convert.ToInt32(Cls_Public.PublicDT.DefaultView[1]["DeviceStateID"].ToString());

                    }
                    return;


                }
                else
                {
                    if (LstState24 == Convert.ToBoolean(StateID))
                    {
                        // sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls24 + " where  DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls24 + " where  DevicestateID='" + DeviceStateID24 + "'";

                    }
                    else
                    {
                        //  sqlstr = "select * from  Tb_Client where DeviceStateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";
                        sqlstr = "select * from  Tb_Client where DeviceStateID='" + DeviceStateID24 + "'";

                        Cls_Public.PublicDT = Pers.GetDataTable(Cls_Public.CnnStr, sqlstr);
                        DateTime FirstDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiStartDateTime"].ToString());
                        DateTime EndDate = DateTime.Parse(Cls_Public.PublicDT.DefaultView[0]["MiladiFinishDateTime"].ToString());
                        totalHours = (EndDate - FirstDate).TotalSeconds;


                        if (totalHours <= 60)
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=Count+" + ++CountOfPuls24 + " where DevicestateID='" + DeviceStateID24Old + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                            sqlstr = "delete from Tb_Client  where DevicestateID='" + DeviceStateID24 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);
                        }
                        else
                        {
                            sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls24 + " where DevicestateID='" + DeviceStateID24 + "'";
                            Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

                        }
                        //   sqlstr = "update    Tb_Client  set duration=" + totalHours + ", enddate ='" + CurShamsiDate + "',MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') , endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls24 + " where DevicestateID=(SELECT        TOP (1) DeviceStateID  FROM            dbo.Tb_Client  WHERE        (DeviceID = '" + DeviceId + "') AND (DeviceLineId = '" + DeviceLineId + "')  ORDER BY DeviceStateID DESC)";

                        LstState24 = Convert.ToBoolean(StateID);
                        ISStartInt24 = false;
                        CountOfPuls24 = 0;
                    }
                }

                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);




            }
            catch (Exception e)
            {
                EventLog.WriteEntry("UnSuccess Insert Data With Method InsertData in db!!!" + e.Message + "   SQLSTR=" + sqlstr, EventLogEntryType.Information);
                ISStartInt24 = false;
                sqlstr = "update   Tb_Client  set  enddate='" + CurShamsiDate + "' ,MiladiFinishDateTime=convert(datetime,'" + DateTime.Now.ToString() + "') ,endtime='" + DateTime.Now.ToString("HH:mm:ss:ff") + "',[Count]=" + ++CountOfPuls24 + " where  DevicestateID= '" + DeviceStateID24 + "'";
                Pers.ExecuteNoneQuery(sqlstr, Cls_Public.CnnStr);

            }
        }

     

        
    }
}
